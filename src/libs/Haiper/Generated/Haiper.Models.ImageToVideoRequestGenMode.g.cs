
#nullable enable

namespace Haiper
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImageToVideoRequestGenMode
    {
        /// <summary>
        /// 
        /// </summary>
        Enhanced,
        /// <summary>
        /// 
        /// </summary>
        Smooth,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageToVideoRequestGenModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageToVideoRequestGenMode value)
        {
            return value switch
            {
                ImageToVideoRequestGenMode.Enhanced => "enhanced",
                ImageToVideoRequestGenMode.Smooth => "smooth",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageToVideoRequestGenMode? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => ImageToVideoRequestGenMode.Enhanced,
                "smooth" => ImageToVideoRequestGenMode.Smooth,
                _ => null,
            };
        }
    }
}