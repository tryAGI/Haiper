
#nullable enable

namespace Haiper
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageToVideoConfig
    {
        /// <summary>
        /// URL or base64-encoded image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceImage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("camera_movement")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Haiper.JsonConverters.ImageToVideoConfigCameraMovementJsonConverter))]
        public global::Haiper.ImageToVideoConfigCameraMovement? CameraMovement { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageToVideoConfig" /> class.
        /// </summary>
        /// <param name="sourceImage">
        /// URL or base64-encoded image.
        /// </param>
        /// <param name="cameraMovement"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageToVideoConfig(
            string sourceImage,
            global::Haiper.ImageToVideoConfigCameraMovement? cameraMovement)
        {
            this.SourceImage = sourceImage ?? throw new global::System.ArgumentNullException(nameof(sourceImage));
            this.CameraMovement = cameraMovement;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageToVideoConfig" /> class.
        /// </summary>
        public ImageToVideoConfig()
        {
        }

    }
}