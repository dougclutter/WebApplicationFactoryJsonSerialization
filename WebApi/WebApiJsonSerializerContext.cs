using System.Text.Json.Serialization;

namespace WebApi;

[JsonSerializable(typeof(WeatherForecast[]))]
public partial class WebApiJsonSerializerContext : JsonSerializerContext { }
