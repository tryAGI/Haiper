
#nullable enable

namespace Haiper
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NewCreationValue
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_id")]
        public string? GenerationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NewCreationValue" /> class.
        /// </summary>
        /// <param name="generationId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NewCreationValue(
            string? generationId)
        {
            this.GenerationId = generationId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewCreationValue" /> class.
        /// </summary>
        public NewCreationValue()
        {
        }

    }
}