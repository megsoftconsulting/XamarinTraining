using Newtonsoft.Json;

namespace WeatherApi.Models
{
    public class WeatherResponse
    {
        [JsonProperty("location")]
        public Location Location { get; set; }
        [JsonProperty("current")]
        public Weather Weather { get; set; }
    }
}