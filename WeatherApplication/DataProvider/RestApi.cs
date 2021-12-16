using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace WeatherApplication.DataProvider
{
    public class RestApi : IRestApi
    {
        private IRestClient m_client;
        private readonly string _baseUrl;

        public RestApi(string baseUrl, IRestClient restClient)
        {
            _baseUrl = baseUrl;
            m_client = restClient;
            m_client.BaseUrl = new Uri(baseUrl);
            m_client.Timeout = -1;
        }

        public RestApi() : this("https://www.metaweather.com", new RestClient())
        {
        }

        public LocationModel GetByWoeid(int woeid) //Get Where on earth ID
        {
            var request = new RestRequest($"api/location/{woeid}", Method.GET);
            var response = m_client.Execute(request);
            if (!response.IsSuccessful)
            {
               return null;
            }
            var result = JsonConvert.DeserializeObject<LocationModel>(response.Content);
            return result;
        }

        public List<SearchModel> GetLocations(string searchTerm) //Get Where on earth ID
        {
            var request = new RestRequest($"api/location/search/?query={searchTerm}");
            var response = m_client.Get(request);
            var result = JsonConvert.DeserializeObject<List<SearchModel>>(response.Content);
            return result;
        }

        public List<WeatherForecast> GetByWoeidHistory(int woeid, string date) //Get Weather history
        {
            var request = new RestRequest($"api/location/{woeid}/{date}");
            var response = m_client.Get(request);
            var result = JsonConvert.DeserializeObject<List<WeatherForecast>>(response.Content);
            return result;
        }

        public string GetImageUrl(string abbr)
        {
            var url = $"{_baseUrl}/static/img/weather/png/{abbr}.png";
            return url;
        }
    }

   
}
