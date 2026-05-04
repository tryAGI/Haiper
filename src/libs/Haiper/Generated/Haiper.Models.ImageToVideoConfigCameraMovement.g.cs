
#nullable enable

namespace Haiper
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImageToVideoConfigCameraMovement
    {
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        PanLeft,
        /// <summary>
        /// 
        /// </summary>
        PanRight,
        /// <summary>
        /// 
        /// </summary>
        TiltDown,
        /// <summary>
        /// 
        /// </summary>
        TiltUp,
        /// <summary>
        /// 
        /// </summary>
        ZoomIn,
        /// <summary>
        /// 
        /// </summary>
        ZoomOut,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageToVideoConfigCameraMovementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageToVideoConfigCameraMovement value)
        {
            return value switch
            {
                ImageToVideoConfigCameraMovement.None => "none",
                ImageToVideoConfigCameraMovement.PanLeft => "pan_left",
                ImageToVideoConfigCameraMovement.PanRight => "pan_right",
                ImageToVideoConfigCameraMovement.TiltDown => "tilt_down",
                ImageToVideoConfigCameraMovement.TiltUp => "tilt_up",
                ImageToVideoConfigCameraMovement.ZoomIn => "zoom_in",
                ImageToVideoConfigCameraMovement.ZoomOut => "zoom_out",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageToVideoConfigCameraMovement? ToEnum(string value)
        {
            return value switch
            {
                "none" => ImageToVideoConfigCameraMovement.None,
                "pan_left" => ImageToVideoConfigCameraMovement.PanLeft,
                "pan_right" => ImageToVideoConfigCameraMovement.PanRight,
                "tilt_down" => ImageToVideoConfigCameraMovement.TiltDown,
                "tilt_up" => ImageToVideoConfigCameraMovement.TiltUp,
                "zoom_in" => ImageToVideoConfigCameraMovement.ZoomIn,
                "zoom_out" => ImageToVideoConfigCameraMovement.ZoomOut,
                _ => null,
            };
        }
    }
}