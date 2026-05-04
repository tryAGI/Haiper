
#nullable enable

namespace Haiper
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextToImageRequestConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_number")]
        public int? ImageNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToImageRequestConfig" /> class.
        /// </summary>
        /// <param name="imageNumber"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextToImageRequestConfig(
            int? imageNumber)
        {
            this.ImageNumber = imageNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToImageRequestConfig" /> class.
        /// </summary>
        public TextToImageRequestConfig()
        {
        }
    }
}