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

        public RestApi(IRestClient restClient)
        {
            m_client = restClient;
        }

        public RestApi()
        {
            m_client = new RestClient($"https://www.metaweather.com/");
            m_client.Timeout = -1;
        }

        public LocationModel GetByWoeid(int woeid) //Get Where on earth ID
        {
            var request = new RestRequest($"api/location/{woeid}");
            var response = m_client.Get(request);
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


    }

   
}
