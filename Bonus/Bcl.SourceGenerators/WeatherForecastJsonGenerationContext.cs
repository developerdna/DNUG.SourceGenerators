using System.Text.Json.Serialization;

namespace Bcl.SourceGenerators;

[JsonSourceGenerationOptions(WriteIndented = true)]
[JsonSerializable(typeof(WeatherForecast))]
internal partial class WeatherForecastJsonGenerationContext : JsonSerializerContext
{
}