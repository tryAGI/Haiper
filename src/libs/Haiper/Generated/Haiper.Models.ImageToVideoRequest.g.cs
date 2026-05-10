
#nullable enable

namespace Haiper
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageToVideoRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_public")]
        public bool? IsPublic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_enable_prompt_enhancer")]
        public bool? IsEnablePromptEnhancer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative_prompt")]
        public string? NegativePrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gen_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Haiper.JsonConverters.ImageToVideoRequestGenModeJsonConverter))]
        public global::Haiper.ImageToVideoRequestGenMode? GenMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Haiper.ImageToVideoConfig Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public global::Haiper.VideoSettings? Settings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageToVideoRequest" /> class.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="config"></param>
        /// <param name="isPublic"></param>
        /// <param name="isEnablePromptEnhancer"></param>
        /// <param name="negativePrompt"></param>
        /// <param name="genMode"></param>
        /// <param name="settings"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageToVideoRequest(
            string prompt,
            global::Haiper.ImageToVideoConfig config,
            bool? isPublic,
            bool? isEnablePromptEnhancer,
            string? negativePrompt,
            global::Haiper.ImageToVideoRequestGenMode? genMode,
            global::Haiper.VideoSettings? settings)
        {
            this.IsPublic = isPublic;
            this.IsEnablePromptEnhancer = isEnablePromptEnhancer;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.NegativePrompt = negativePrompt;
            this.GenMode = genMode;
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.Settings = settings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageToVideoRequest" /> class.
        /// </summary>
        public ImageToVideoRequest()
        {
        }

    }
}