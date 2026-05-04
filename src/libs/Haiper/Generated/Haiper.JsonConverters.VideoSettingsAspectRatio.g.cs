#nullable enable

namespace Haiper.JsonConverters
{
    /// <inheritdoc />
    public sealed class VideoSettingsAspectRatioJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Haiper.VideoSettingsAspectRatio>
    {
        /// <inheritdoc />
        public override global::Haiper.VideoSettingsAspectRatio Read(
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
                        return global::Haiper.VideoSettingsAspectRatioExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Haiper.VideoSettingsAspectRatio)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Haiper.VideoSettingsAspectRatio);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Haiper.VideoSettingsAspectRatio value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Haiper.VideoSettingsAspectRatioExtensions.ToValueString(value));
        }
    }
}
