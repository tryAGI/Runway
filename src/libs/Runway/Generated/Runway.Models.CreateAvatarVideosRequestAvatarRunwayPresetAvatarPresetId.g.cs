
#nullable enable

namespace Runway
{
    /// <summary>
    /// ID of a preset avatar.
    /// </summary>
    public enum CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetId
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
    public static class CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetId value)
        {
            return value switch
            {
                CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetId.CatCharacter => "cat-character",
                CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetId.CookingTeacher => "cooking-teacher",
                CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetId.FashionDesigner => "fashion-designer",
                CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetId.GameCharacter => "game-character",
                CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetId.GameCharacterMan => "game-character-man",
                CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetId.HumanResource => "human-resource",
                CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetId.Influencer => "influencer",
                CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetId.MusicSuperstar => "music-superstar",
                CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetId.TennisCoach => "tennis-coach",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetId? ToEnum(string value)
        {
            return value switch
            {
                "cat-character" => CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetId.CatCharacter,
                "cooking-teacher" => CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetId.CookingTeacher,
                "fashion-designer" => CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetId.FashionDesigner,
                "game-character" => CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetId.GameCharacter,
                "game-character-man" => CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetId.GameCharacterMan,
                "human-resource" => CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetId.HumanResource,
                "influencer" => CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetId.Influencer,
                "music-superstar" => CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetId.MusicSuperstar,
                "tennis-coach" => CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetId.TennisCoach,
                _ => null,
            };
        }
    }
}