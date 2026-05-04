
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Haiper
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Haiper.JsonConverters.TextToVideoRequestGenModeJsonConverter),

            typeof(global::Haiper.JsonConverters.TextToVideoRequestGenModeNullableJsonConverter),

            typeof(global::Haiper.JsonConverters.ImageToVideoRequestGenModeJsonConverter),

            typeof(global::Haiper.JsonConverters.ImageToVideoRequestGenModeNullableJsonConverter),

            typeof(global::Haiper.JsonConverters.ImageToVideoConfigCameraMovementJsonConverter),

            typeof(global::Haiper.JsonConverters.ImageToVideoConfigCameraMovementNullableJsonConverter),

            typeof(global::Haiper.JsonConverters.VideoSettingsAspectRatioJsonConverter),

            typeof(global::Haiper.JsonConverters.VideoSettingsAspectRatioNullableJsonConverter),

            typeof(global::Haiper.JsonConverters.CreationStatusValueStatusJsonConverter),

            typeof(global::Haiper.JsonConverters.CreationStatusValueStatusNullableJsonConverter),

            typeof(global::Haiper.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Haiper.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Haiper.TextToVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Haiper.TextToVideoRequestGenMode), TypeInfoPropertyName = "TextToVideoRequestGenMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Haiper.VideoSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Haiper.ImageToVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Haiper.ImageToVideoRequestGenMode), TypeInfoPropertyName = "ImageToVideoRequestGenMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Haiper.ImageToVideoConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Haiper.TextToImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Haiper.TextToImageRequestConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Haiper.ImageSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Haiper.KeyframeConditioningRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Haiper.KeyframeConditioningRequestConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Haiper.ImageToVideoConfigCameraMovement), TypeInfoPropertyName = "ImageToVideoConfigCameraMovement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Haiper.VideoSettingsAspectRatio), TypeInfoPropertyName = "VideoSettingsAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Haiper.NewCreation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Haiper.NewCreationValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Haiper.CreationStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Haiper.CreationStatusValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Haiper.CreationStatusValueStatus), TypeInfoPropertyName = "CreationStatusValueStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Haiper.CreationDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Haiper.CreationDetailValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Haiper.WatermarkFreeUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Haiper.WatermarkFreeUrlValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Haiper.CancelCreation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Haiper.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}