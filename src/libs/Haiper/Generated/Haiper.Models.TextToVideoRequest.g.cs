
#nullable enable

namespace Haiper
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextToVideoRequest
    {
        /// <summary>
        /// Whether the generation is public on Haiper.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_public")]
        public bool? IsPublic { get; set; }

        /// <summary>
        /// Whether Haiper should enhance the prompt.
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Haiper.JsonConverters.TextToVideoRequestGenModeJsonConverter))]
        public global::Haiper.TextToVideoRequestGenMode? GenMode { get; set; }

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
        /// Initializes a new instance of the <see cref="TextToVideoRequest" /> class.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="isPublic">
        /// Whether the generation is public on Haiper.
        /// </param>
        /// <param name="isEnablePromptEnhancer">
        /// Whether Haiper should enhance the prompt.
        /// </param>
        /// <param name="negativePrompt"></param>
        /// <param name="genMode"></param>
        /// <param name="settings"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextToVideoRequest(
            string prompt,
            bool? isPublic,
            bool? isEnablePromptEnhancer,
            string? negativePrompt,
            global::Haiper.TextToVideoRequestGenMode? genMode,
            global::Haiper.VideoSettings? settings)
        {
            this.IsPublic = isPublic;
            this.IsEnablePromptEnhancer = isEnablePromptEnhancer;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.NegativePrompt = negativePrompt;
            this.GenMode = genMode;
            this.Settings = settings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToVideoRequest" /> class.
        /// </summary>
        public TextToVideoRequest()
        {
        }
    }
}