
#nullable enable

namespace Runway
{
    /// <summary>
    /// ID of a preset avatar.
    /// </summary>
    public enum CreateRealtimeSessionsRequestAvatarRunwayPresetAvatarPresetId
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
    public static class CreateRealtimeSessionsRequestAvatarRunwayPresetAvatarPresetIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRealtimeSessionsRequestAvatarRunwayPresetAvatarPresetId value)
        {
            return value switch
            {
                CreateRealtimeSessionsRequestAvatarRunwayPresetAvatarPresetId.CatCharacter => "cat-character",
                CreateRealtimeSessionsRequestAvatarRunwayPresetAvatarPresetId.CookingTeacher => "cooking-teacher",
                CreateRealtimeSessionsRequestAvatarRunwayPresetAvatarPresetId.FashionDesigner => "fashion-designer",
                CreateRealtimeSessionsRequestAvatarRunwayPresetAvatarPresetId.GameCharacter => "game-character",
                CreateRealtimeSessionsRequestAvatarRunwayPresetAvatarPresetId.GameCharacterMan => "game-character-man",
                CreateRealtimeSessionsRequestAvatarRunwayPresetAvatarPresetId.HumanResource => "human-resource",
                CreateRealtimeSessionsRequestAvatarRunwayPresetAvatarPresetId.Influencer => "influencer",
                CreateRealtimeSessionsRequestAvatarRunwayPresetAvatarPresetId.MusicSuperstar => "music-superstar",
                CreateRealtimeSessionsRequestAvatarRunwayPresetAvatarPresetId.TennisCoach => "tennis-coach",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRealtimeSessionsRequestAvatarRunwayPresetAvatarPresetId? ToEnum(string value)
        {
            return value switch
            {
                "cat-character" => CreateRealtimeSessionsRequestAvatarRunwayPresetAvatarPresetId.CatCharacter,
                "cooking-teacher" => CreateRealtimeSessionsRequestAvatarRunwayPresetAvatarPresetId.CookingTeacher,
                "fashion-designer" => CreateRealtimeSessionsRequestAvatarRunwayPresetAvatarPresetId.FashionDesigner,
                "game-character" => CreateRealtimeSessionsRequestAvatarRunwayPresetAvatarPresetId.GameCharacter,
                "game-character-man" => CreateRealtimeSessionsRequestAvatarRunwayPresetAvatarPresetId.GameCharacterMan,
                "human-resource" => CreateRealtimeSessionsRequestAvatarRunwayPresetAvatarPresetId.HumanResource,
                "influencer" => CreateRealtimeSessionsRequestAvatarRunwayPresetAvatarPresetId.Influencer,
                "music-superstar" => CreateRealtimeSessionsRequestAvatarRunwayPresetAvatarPresetId.MusicSuperstar,
                "tennis-coach" => CreateRealtimeSessionsRequestAvatarRunwayPresetAvatarPresetId.TennisCoach,
                _ => null,
            };
        }
    }
}