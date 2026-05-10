
#nullable enable

namespace Haiper
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NewCreation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public global::Haiper.NewCreationValue? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NewCreation" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NewCreation(
            string status,
            global::Haiper.NewCreationValue? value)
        {
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewCreation" /> class.
        /// </summary>
        public NewCreation()
        {
        }

    }
}