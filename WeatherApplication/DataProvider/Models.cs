using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeatherApplication.DataProvider
{
    public class SearchModel
    {
        public string Title { get; set; }
        public int Woeid { get; set; }
        
    }
    public class LocationModel
    {
        [JsonProperty("consolidated_weather")]
        public List<WeatherForecast> ConsolidatedWeather { get; set; }

        [JsonProperty("time")]
        public DateTime Time { get; set; }

        [JsonProperty("sun_rise")]
        public DateTime SunRise { get; set; }

        [JsonProperty("sun_set")]
        public DateTime SunSet { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        public string Title { get; set; }
        public string location_type { get; set; }
        public int woeid { get; set; }
        public string Latt { get; set; }
        public string Long { get; set; }
        public string Latt_Long
        {
            get
            {
                return $"{Latt}, {Long}";
            }
            set
            {
                var split = value.Split(',');
                Latt = split[0].Trim();
                Long = split[1].Trim();
            }
        }
    }

    public class WeatherForecast
    {
        [JsonProperty("weather_state_name")]
        public string WeatherName { get; set; }

        [JsonProperty("weather_state_abbr")]
        public string WeatherStateAbbr { get; set; }

        [JsonProperty("applicable_date")]
        public DateTime ApplicableDate { get; set; }

        [JsonProperty("min_temp")]
        public double MinTemp { get; set; }

        [JsonProperty("max_temp")]
        public double MaxTemp { get; set; }

        [JsonProperty("wind_speed")]
        public double WindSpeed { get; set; }

        [JsonProperty("wind_direction")]
        public string WindDirection { get; set; }

        public string Humidity { get; set; }

    }
}
