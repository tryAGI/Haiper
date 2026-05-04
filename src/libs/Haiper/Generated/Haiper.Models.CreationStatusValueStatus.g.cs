
#nullable enable

namespace Haiper
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreationStatusValueStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        PostProcessing,
        /// <summary>
        /// 
        /// </summary>
        Processing,
        /// <summary>
        /// 
        /// </summary>
        Succeed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreationStatusValueStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreationStatusValueStatus value)
        {
            return value switch
            {
                CreationStatusValueStatus.Failed => "failed",
                CreationStatusValueStatus.Pending => "pending",
                CreationStatusValueStatus.PostProcessing => "post_processing",
                CreationStatusValueStatus.Processing => "processing",
                CreationStatusValueStatus.Succeed => "succeed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreationStatusValueStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => CreationStatusValueStatus.Failed,
                "pending" => CreationStatusValueStatus.Pending,
                "post_processing" => CreationStatusValueStatus.PostProcessing,
                "processing" => CreationStatusValueStatus.Processing,
                "succeed" => CreationStatusValueStatus.Succeed,
                _ => null,
            };
        }
    }
}