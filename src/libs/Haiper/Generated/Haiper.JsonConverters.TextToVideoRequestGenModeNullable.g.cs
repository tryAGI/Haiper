#nullable enable

namespace Haiper.JsonConverters
{
    /// <inheritdoc />
    public sealed class TextToVideoRequestGenModeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Haiper.TextToVideoRequestGenMode?>
    {
        /// <inheritdoc />
        public override global::Haiper.TextToVideoRequestGenMode? Read(
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
                        return global::Haiper.TextToVideoRequestGenModeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Haiper.TextToVideoRequestGenMode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Haiper.TextToVideoRequestGenMode?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Haiper.TextToVideoRequestGenMode? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Haiper.TextToVideoRequestGenModeExtensions.ToValueString(value.Value));
            }
        }
    }
}
