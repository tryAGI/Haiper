
#nullable enable

namespace Haiper
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoSettings
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public long? Seed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Haiper.JsonConverters.VideoSettingsAspectRatioJsonConverter))]
        public global::Haiper.VideoSettingsAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoSettings" /> class.
        /// </summary>
        /// <param name="seed"></param>
        /// <param name="aspectRatio"></param>
        /// <param name="duration"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoSettings(
            long? seed,
            global::Haiper.VideoSettingsAspectRatio? aspectRatio,
            int? duration)
        {
            this.Seed = seed;
            this.AspectRatio = aspectRatio;
            this.Duration = duration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoSettings" /> class.
        /// </summary>
        public VideoSettings()
        {
        }
    }
}