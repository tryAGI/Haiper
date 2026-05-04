
#nullable enable

namespace Haiper
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KeyframeConditioningRequestConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_images")]
        public global::System.Collections.Generic.IList<string>? SourceImages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("camera_movement")]
        public string? CameraMovement { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyframeConditioningRequestConfig" /> class.
        /// </summary>
        /// <param name="sourceImages"></param>
        /// <param name="cameraMovement"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KeyframeConditioningRequestConfig(
            global::System.Collections.Generic.IList<string>? sourceImages,
            string? cameraMovement)
        {
            this.SourceImages = sourceImages;
            this.CameraMovement = cameraMovement;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyframeConditioningRequestConfig" /> class.
        /// </summary>
        public KeyframeConditioningRequestConfig()
        {
        }
    }
}