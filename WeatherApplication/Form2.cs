using WeatherApplication.DataProvider;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApplication
{
    public partial class Form2 : Form
    {
        private readonly IRestApi _api;
        private readonly Repository repository;
        private int locationWoeid;

        public Form2(int woeid)
        {
            InitializeComponent();
            _api = new RestApi();
            repository = new Repository(_api);
            locationWoeid = woeid;
        }

        

        private void Form2_Load(object sender, EventArgs e)
        {
            lable0.Visible = false;
        }

        public void printWeather(PictureBox pictureBox, Label lable, WeatherForecast weather, int year)
        {
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.ImageLocation = _api.GetImageUrl(weather.WeatherStateAbbr);
            lable0.Visible = true;

            lable.Text = year + repository.weatherToString(weather);
        }


        private void calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            var calendarDate = calendar.SelectionStart;
            var date = calendarDate.ToString("yyyy/M/dd");
            var results = _api.GetByWoeidHistory(locationWoeid, date);

            WeatherForecast weather = results[0];

            foreach (var i in results)
            {
               var a = i.ApplicableDate.ToString("yyyy/M/dd");
               if(a != date)
               {
                    return;
               }
                weather.MinTemp = repository.GetLower(weather.MinTemp, i.MinTemp);

                weather.MaxTemp = repository.getHigher(weather.MaxTemp, i.MaxTemp);

                weather.WindSpeed = repository.getHigher(weather.WindSpeed, i.WindSpeed);
               
            }

            printWeather(pictureBox0, lable0, weather, calendarDate.Year);

        }

        
    }
}
