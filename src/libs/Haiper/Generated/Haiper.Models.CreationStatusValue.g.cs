
#nullable enable

namespace Haiper
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreationStatusValue
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Haiper.JsonConverters.CreationStatusValueStatusJsonConverter))]
        public global::Haiper.CreationStatusValueStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        public float? Progress { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreationStatusValue" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="progress"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreationStatusValue(
            global::Haiper.CreationStatusValueStatus? status,
            float? progress)
        {
            this.Status = status;
            this.Progress = progress;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreationStatusValue" /> class.
        /// </summary>
        public CreationStatusValue()
        {
        }
    }
}