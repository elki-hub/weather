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
        private int locationWoeid;

        public Form2(int woeid)
        {
            InitializeComponent();
            _api = new RestApi();
            locationWoeid = woeid;
        }

        

        private void Form2_Load(object sender, EventArgs e)
        {

            
        }

        public void printWeather(TabPage tabPage, PictureBox pictureBox, Label lable, WeatherForecast weather)
        {
            tabPage.Text = weather.ApplicableDate.ToString("ddd");

            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.ImageLocation = GetImage(weather.WeatherStateAbbr);

            lable.Text = $"{weather.ApplicableDate.ToString("M")}\n"
                + $"{weather.WeatherName}\n\n"

                + $"Min temperature: {weather.MinTemp} °C\n"
                + $"Max temperature: {weather.MaxTemp} °C\n\n"

                + $"Humidity: {weather.Humidity}%\n"
                + $"Wind: {weather.WindSpeed} m/h\n";
        }

        public string GetImage(string search)
        {
            var url = "https://www.metaweather.com/static/img/weather/png/" + search + ".png";
            return url;
        }


        private void button2_Click(object sender, EventArgs e)
        {
           this.Hide();
           Form1 main = new Form1();
           main.ShowDialog();
           this.Close();
        }

        private void calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            //"2013/4/27";
            var date = calendar.SelectionStart.ToString("yyyy/M/dd");
            var results = _api.GetByWoeidHistory(locationWoeid, date);
            List<WeatherForecast> weather;
            var j = 0;
            var minTemp = 50;

            foreach (var i in results)
            {
               var a = i.ApplicableDate.ToString("yyyy/M/dd");
               if(a != date)
               {
                    return;
               }
                //j++;
               if(minTemp > i.MinTemp)
               {

               }
                //var a = results[i].ApplicableDate.Day;
                //if ()
            }


            ForecastTab.Visible = true;
            labelWeatherForecast.Text = "WeatherForecast:";

            //var temp = weather.ConsolidatedWeather[0].MinTemp;
            //+ $"Min temperature: {temp.ToString()}\n"
            //+ $"Min temperature: {Math.Round(temp,0, MidpointRounding.ToEven).ToString()}\n"

            //printWeather(tabPage0, pictureBox0, tabPagelable0, weather[0]);
            //printWeather(tabPage1, pictureBox1, tabPagelable1, weather[1]);
            //printWeather(tabPage2, pictureBox2, tabPagelable2, weather[2]);
            //printWeather(tabPage3, pictureBox3, tabPagelable3, weather[3]);
            //printWeather(tabPage4, pictureBox4, tabPagelable4, weather[4]);
            // printWeather(tabPage5, pictureBox5, tabPagelable5, weather[5]);
        }
    }
}
