using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApplication.DataProvider
{
    public interface IRestApi
    {
        LocationModel GetByWoeid(int woeid);
        List<WeatherForecast> GetByWoeidHistory(int woeid, string date);
        List<SearchModel> GetLocations(string searchTerm);

        string GetImageUrl(string abbr);
    }
}
