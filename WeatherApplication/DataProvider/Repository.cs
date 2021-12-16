using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApplication.DataProvider
{
    public class Repository
    {
        private readonly  IRestApi m_provider;

        public Repository(IRestApi provider)
        {
            m_provider = provider;
        }

        public int countList(string search)
        {
            return m_provider.GetLocations(search).Count();
        }

        public double round(double number)
        {
            return Math.Round(number, 0, MidpointRounding.ToEven);
        }

        public double getHigher(double val1, double val2)
        {
            if (val1 > val2)
            {
                return val1;
            }
            return val2;
        }

        public double GetLower(double val1, double val2)
        {
            if (val1 < val2)
            {
                return val1;
            }
            return val2;
        }

        public string weatherToString(WeatherForecast weather)
        {
            var text = $"{weather.ApplicableDate.ToString("M")}\n"
                 + $"{weather.WeatherName}\n\n"
                 + $"Min temperature: {round(weather.MinTemp)} °C\n"
                 + $"Max temperature: {round(weather.MaxTemp)} °C\n\n"
                 + $"Humidity: {weather.Humidity}%\n"
                 + $"Wind: {round(weather.WindSpeed)} m/h\n";
            return text;
        }

    }
}
