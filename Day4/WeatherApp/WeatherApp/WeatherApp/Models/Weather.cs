using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace WeatherApp.Models
{
    public class Weather
    {
        [JsonProperty("temperature")]
        public int Celsius { get; set; }
        
        public int Fahrenheit => (Celsius - 32) * (5 / 9);
        
        public string CelsiusText => $"{Celsius} °C";

        public string FahrenheitText => $"{Fahrenheit} °F";

        [JsonProperty("weather_icons")]
        public List<string> WeatherIcons { get; set; } = new List<string>();

        public string WeatherIcon => WeatherIcons.Any() ? WeatherIcons.First() : "";
        
        [JsonProperty("is_day")]
        public string IsDay { get; set; }
        
        [JsonProperty("last_updated")]
        public string LastUpdated { get; set; }
    }
}