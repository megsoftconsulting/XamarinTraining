using Newtonsoft.Json;

namespace WeatherApi.Models
{
    public class Location
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("region")]
        public string Region { get; set; }
        [JsonProperty("country")]
        public string Country { get; set; }
        [JsonProperty("localtime")]
        public string LocalTime { get; set; }
    }
}