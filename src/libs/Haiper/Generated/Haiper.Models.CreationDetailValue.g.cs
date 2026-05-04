
#nullable enable

namespace Haiper
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreationDetailValue
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creation_id")]
        public string? CreationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_type")]
        public string? InputType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public object? Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public object? Settings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreationDetailValue" /> class.
        /// </summary>
        /// <param name="creationId"></param>
        /// <param name="prompt"></param>
        /// <param name="type"></param>
        /// <param name="inputType"></param>
        /// <param name="output"></param>
        /// <param name="settings"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreationDetailValue(
            string? creationId,
            string? prompt,
            string? type,
            string? inputType,
            object? output,
            object? settings)
        {
            this.CreationId = creationId;
            this.Prompt = prompt;
            this.Type = type;
            this.InputType = inputType;
            this.Output = output;
            this.Settings = settings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreationDetailValue" /> class.
        /// </summary>
        public CreationDetailValue()
        {
        }
    }
}