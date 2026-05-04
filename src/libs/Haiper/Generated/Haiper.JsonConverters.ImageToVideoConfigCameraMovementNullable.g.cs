#nullable enable

namespace Haiper.JsonConverters
{
    /// <inheritdoc />
    public sealed class ImageToVideoConfigCameraMovementNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Haiper.ImageToVideoConfigCameraMovement?>
    {
        /// <inheritdoc />
        public override global::Haiper.ImageToVideoConfigCameraMovement? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Haiper.ImageToVideoConfigCameraMovementExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Haiper.ImageToVideoConfigCameraMovement)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Haiper.ImageToVideoConfigCameraMovement?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Haiper.ImageToVideoConfigCameraMovement? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Haiper.ImageToVideoConfigCameraMovementExtensions.ToValueString(value.Value));
            }
        }
    }
}
