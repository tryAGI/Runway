
#nullable enable

namespace Runway
{
    /// <summary>
    /// ID of a preset avatar.
    /// </summary>
    public enum CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatarPresetId
    {
        /// <summary>
        ///
        /// </summary>
        CatCharacter,
        /// <summary>
        ///
        /// </summary>
        CookingTeacher,
        /// <summary>
        ///
        /// </summary>
        FashionDesigner,
        /// <summary>
        ///
        /// </summary>
        GameCharacter,
        /// <summary>
        ///
        /// </summary>
        GameCharacterMan,
        /// <summary>
        ///
        /// </summary>
        HumanResource,
        /// <summary>
        ///
        /// </summary>
        Influencer,
        /// <summary>
        ///
        /// </summary>
        MusicSuperstar,
        /// <summary>
        ///
        /// </summary>
        TennisCoach,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatarPresetIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatarPresetId value)
        {
            return value switch
            {
                CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatarPresetId.CatCharacter => "cat-character",
                CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatarPresetId.CookingTeacher => "cooking-teacher",
                CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatarPresetId.FashionDesigner => "fashion-designer",
                CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatarPresetId.GameCharacter => "game-character",
                CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatarPresetId.GameCharacterMan => "game-character-man",
                CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatarPresetId.HumanResource => "human-resource",
                CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatarPresetId.Influencer => "influencer",
                CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatarPresetId.MusicSuperstar => "music-superstar",
                CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatarPresetId.TennisCoach => "tennis-coach",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatarPresetId? ToEnum(string value)
        {
            return value switch
            {
                "cat-character" => CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatarPresetId.CatCharacter,
                "cooking-teacher" => CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatarPresetId.CookingTeacher,
                "fashion-designer" => CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatarPresetId.FashionDesigner,
                "game-character" => CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatarPresetId.GameCharacter,
                "game-character-man" => CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatarPresetId.GameCharacterMan,
                "human-resource" => CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatarPresetId.HumanResource,
                "influencer" => CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatarPresetId.Influencer,
                "music-superstar" => CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatarPresetId.MusicSuperstar,
                "tennis-coach" => CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatarPresetId.TennisCoach,
                _ => null,
            };
        }
    }
}