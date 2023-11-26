namespace Spinitron.Client.Converters;

public class DateTimeOffsetConverterUsingDateTimeParse : JsonConverter<DateTimeOffset >
{
    public override DateTimeOffset Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return DateTimeOffset.Parse(reader.GetString() ?? throw new InvalidOperationException());
    }

    public override void Write(Utf8JsonWriter writer, DateTimeOffset  value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString());
    }
}