using System.Buffers.Binary;
using System.Text;
using SixLabors.ImageSharp;

namespace Runway.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void WatchBridgeDecoder_DecodesRecordedJpegAndFmp4Frames()
    {
        var decoder = new WatchBridgeFixtureDecoder();

        var jpegFrame = decoder.ReadJpegFrame(CreateRecordedJpegBridgeFrame());
        using var image = Image.Load(jpegFrame.Payload);

        image.Width.Should().Be(2);
        image.Height.Should().Be(2);

        decoder.AppendFmp4Frame(CreateRecordedFmp4BridgeFrame(MakeMp4Box("ftyp", "isomiso2avc1mp41"u8.ToArray()), sequence: 0));
        decoder.AppendFmp4Frame(CreateRecordedFmp4BridgeFrame(
            [
                .. MakeMp4Box("moof", [0, 0, 0, 0]),
                .. MakeMp4Box("mdat", [0, 0, 1, 0x67, 0x42, 0, 0x1e, 0x89]),
            ],
            sequence: 1));

        var fmp4 = decoder.GetFmp4Bytes();
        ContainsAscii(fmp4, "ftyp").Should().BeTrue();
        ContainsAscii(fmp4, "moof").Should().BeTrue();
        ContainsAscii(fmp4, "mdat").Should().BeTrue();
    }

    private static byte[] CreateRecordedJpegBridgeFrame()
    {
        var payload = Convert.FromBase64String(
            "/9j/4AAQSkZJRgABAQAAAQABAAD/2wBDAAgGBgcGBQgHBwcJCQgKDBQNDAsLDBkSEw8UHRofHh0aHBwgJC4nICIsIxwcKDcpLDAxNDQ0Hyc5PTgyPC4zNDL/2wBDAQkJCQwLDBgNDRgyIRwhMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjL/wAARCAACAAIDASIAAhEBAxEB/8QAHwAAAQUBAQEBAQEAAAAAAAAAAAECAwQFBgcICQoL/8QAtRAAAgEDAwIEAwUFBAQAAAF9AQIDAAQRBRIhMUEGE1FhByJxFDKBkaEII0KxwRVS0fAkM2JyggkKFhcYGRolJicoKSo0NTY3ODk6Q0RFRkdISUpTVFVWV1hZWmNkZWZnaGlqc3R1dnd4eXqDhIWGh4iJipKTlJWWl5iZmqKjpKWmp6ipqrKztLW2t7i5usLDxMXGx8jJytLT1NXW19jZ2uHi4+Tl5ufo6erx8vP09fb3+Pn6/8QAHwEAAwEBAQEBAQEBAQAAAAAAAAECAwQFBgcICQoL/8QAtREAAgECBAQDBAcFBAQAAQJ3AAECAxEEBSExBhJBUQdhcRMiMoEIFEKRobHBCSMzUvAVYnLRChYkNOEl8RcYGRomJygpKjU2Nzg5OkNERUZHSElKU1RVVldYWVpjZGVmZ2hpanN0dXZ3eHl6goOEhYaHiImKkpOUlZaXmJmaoqOkpaanqKmqsrO0tba3uLm6wsPExcbHyMnK0tPU1dbX2Nna4uPk5ebn6Onq8vP09fb3+Pn6/9oADAMBAAIRAxEAPwDi6KKK+ZP3E//Z");

        return BuildRecordedBridgeFrame(
            kind: WatchBridgeAvatarJpegKind,
            sequence: 0,
            arg0: 2,
            arg1: 2,
            payload: payload);
    }

    private static byte[] CreateRecordedFmp4BridgeFrame(byte[] payload, uint sequence)
    {
        return BuildRecordedBridgeFrame(
            kind: WatchBridgeAvatarFmp4Kind,
            sequence: sequence,
            arg0: WatchBridgeH264CodecId,
            arg1: 0,
            payload: payload);
    }

    private static byte[] BuildRecordedBridgeFrame(
        byte kind,
        uint sequence,
        ushort arg0,
        ushort arg1,
        byte[] payload)
    {
        var frame = new byte[WatchBridgeHeaderBytes + payload.Length];
        frame[0] = kind;
        frame[1] = WatchBridgeProtocolVersion;
        BinaryPrimitives.WriteUInt16LittleEndian(frame.AsSpan(2), WatchBridgeHeaderBytes);
        BinaryPrimitives.WriteUInt32LittleEndian(frame.AsSpan(4), sequence);
        BinaryPrimitives.WriteUInt64LittleEndian(frame.AsSpan(8), 1_000);
        BinaryPrimitives.WriteUInt32LittleEndian(frame.AsSpan(16), (uint)payload.Length);
        BinaryPrimitives.WriteUInt16LittleEndian(frame.AsSpan(20), arg0);
        BinaryPrimitives.WriteUInt16LittleEndian(frame.AsSpan(22), arg1);
        payload.CopyTo(frame.AsSpan(WatchBridgeHeaderBytes));
        return frame;
    }

    private static byte[] MakeMp4Box(string type, byte[] payload)
    {
        type.Length.Should().Be(4);

        var box = new byte[8 + payload.Length];
        BinaryPrimitives.WriteUInt32BigEndian(box.AsSpan(0), (uint)box.Length);
        Encoding.ASCII.GetBytes(type, box.AsSpan(4, 4));
        payload.CopyTo(box.AsSpan(8));
        return box;
    }

    private static bool ContainsAscii(byte[] payload, string value)
    {
        var needle = Encoding.ASCII.GetBytes(value);
        return payload.AsSpan().IndexOf(needle) >= 0;
    }

    private sealed class WatchBridgeFixtureDecoder
    {
        private readonly MemoryStream _fmp4 = new();

        public DecodedJpegFrame ReadJpegFrame(byte[] frame)
        {
            var parsed = ParseFrame(frame);
            parsed.Kind.Should().Be(WatchBridgeAvatarJpegKind);
            parsed.Arg0.Should().BeGreaterThan(0);
            parsed.Arg1.Should().BeGreaterThan(0);
            parsed.Payload[0].Should().Be(0xFF);
            parsed.Payload[1].Should().Be(0xD8);
            parsed.Payload[^2].Should().Be(0xFF);
            parsed.Payload[^1].Should().Be(0xD9);

            return new DecodedJpegFrame(parsed.Arg0, parsed.Arg1, parsed.Payload);
        }

        public void AppendFmp4Frame(byte[] frame)
        {
            var parsed = ParseFrame(frame);
            parsed.Kind.Should().Be(WatchBridgeAvatarFmp4Kind);
            parsed.Arg0.Should().Be(WatchBridgeH264CodecId);
            _fmp4.Write(parsed.Payload);
        }

        public byte[] GetFmp4Bytes()
        {
            return _fmp4.ToArray();
        }

        private static DecodedBridgeFrame ParseFrame(byte[] frame)
        {
            frame.Length.Should().BeGreaterThanOrEqualTo(WatchBridgeHeaderBytes);
            frame[1].Should().Be(WatchBridgeProtocolVersion);
            BinaryPrimitives.ReadUInt16LittleEndian(frame.AsSpan(2)).Should().Be(WatchBridgeHeaderBytes);

            var payloadLength = BinaryPrimitives.ReadUInt32LittleEndian(frame.AsSpan(16));
            payloadLength.Should().Be((uint)(frame.Length - WatchBridgeHeaderBytes));

            return new DecodedBridgeFrame(
                Kind: frame[0],
                Arg0: BinaryPrimitives.ReadUInt16LittleEndian(frame.AsSpan(20)),
                Arg1: BinaryPrimitives.ReadUInt16LittleEndian(frame.AsSpan(22)),
                Payload: frame.AsSpan(WatchBridgeHeaderBytes).ToArray());
        }
    }

    private sealed record DecodedJpegFrame(
        int Width,
        int Height,
        byte[] Payload);

    private readonly record struct DecodedBridgeFrame(
        byte Kind,
        int Arg0,
        int Arg1,
        byte[] Payload);
}
