using System;
using Newtonsoft.Json;

namespace XFGettingDataServerSample
{
    public class WeatherForecast
    {
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("temperatureC")]
        public int TemperatureC { get; set; }

        [JsonProperty("temperatureF")]
        public int TemperatureF { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }
    }
}
