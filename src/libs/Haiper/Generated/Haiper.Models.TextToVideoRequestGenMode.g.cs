
#nullable enable

namespace Haiper
{
    /// <summary>
    /// 
    /// </summary>
    public enum TextToVideoRequestGenMode
    {
        /// <summary>
        /// 
        /// </summary>
        Enhanced,
        /// <summary>
        /// 
        /// </summary>
        Smooth,
        /// <summary>
        /// 
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextToVideoRequestGenModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextToVideoRequestGenMode value)
        {
            return value switch
            {
                TextToVideoRequestGenMode.Enhanced => "enhanced",
                TextToVideoRequestGenMode.Smooth => "smooth",
                TextToVideoRequestGenMode.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextToVideoRequestGenMode? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => TextToVideoRequestGenMode.Enhanced,
                "smooth" => TextToVideoRequestGenMode.Smooth,
                "standard" => TextToVideoRequestGenMode.Standard,
                _ => null,
            };
        }
    }
}