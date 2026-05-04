
#nullable enable

namespace Haiper
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KeyframeConditioningRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_public")]
        public bool? IsPublic { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Haiper.KeyframeConditioningRequestConfig Config { get; set; }

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
        /// Initializes a new instance of the <see cref="KeyframeConditioningRequest" /> class.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="config"></param>
        /// <param name="isPublic"></param>
        /// <param name="negativePrompt"></param>
        /// <param name="settings"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KeyframeConditioningRequest(
            string prompt,
            global::Haiper.KeyframeConditioningRequestConfig config,
            bool? isPublic,
            string? negativePrompt,
            global::Haiper.VideoSettings? settings)
        {
            this.IsPublic = isPublic;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.NegativePrompt = negativePrompt;
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.Settings = settings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyframeConditioningRequest" /> class.
        /// </summary>
        public KeyframeConditioningRequest()
        {
        }
    }
}