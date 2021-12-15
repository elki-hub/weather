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
    }
}
