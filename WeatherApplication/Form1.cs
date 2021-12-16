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
    public partial class Form1 : Form
    {
        private readonly IRestApi _api;
        private readonly Repository repository;
        public Form1()
        {
            _api = new RestApi();
            repository = new Repository(_api);
            InitializeComponent();
            textBoxSearchLocation.Focus();
            ForecastTab.Visible = false;
            weatherHistoryButton.Visible = false;
            labelWeatherForecast.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_Click(object sender, EventArgs e)
        {
            var selectedItem = listViewOfLocations.SelectedItems[0];
            var selectedModel = (SearchModel)selectedItem.Tag;
            var weather = _api.GetByWoeid(selectedModel.Woeid);

            labelLocationDescription.Text = $"{weather.Title}\n\n "
                + $"Lattitude: {weather.Latt} \n"
                + $"Longitude: {weather.Long} \n"
                + $"Current time: {weather.Time.ToString("g")}\n"
                + $"Sun rise: {weather.SunRise.ToString("HH:mm:ss")}\n"
                + $"Sun set: {weather.SunSet.ToString("HH:mm:ss")}\n";

            ForecastTab.Visible = true;
            weatherHistoryButton.Visible = true;
            labelWeatherForecast.Visible = true;

            printWeather(tabPage0, pictureBox0, tabPagelable0, weather.ConsolidatedWeather[0]);
            printWeather(tabPage1, pictureBox1, tabPagelable1, weather.ConsolidatedWeather[1]);
            printWeather(tabPage2, pictureBox2, tabPagelable2, weather.ConsolidatedWeather[2]);
            printWeather(tabPage3, pictureBox3, tabPagelable3, weather.ConsolidatedWeather[3]);
            printWeather(tabPage4, pictureBox4, tabPagelable4, weather.ConsolidatedWeather[4]);
            printWeather(tabPage5, pictureBox5, tabPagelable5, weather.ConsolidatedWeather[5]);
        }

        public void printWeather(TabPage tabPage,PictureBox pictureBox , Label lable, WeatherForecast weather)
        {
            tabPage.Text = weather.ApplicableDate.ToString("ddd");

            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.ImageLocation = _api.GetImageUrl(weather.WeatherStateAbbr);

            lable.Text = repository.weatherToString(weather);
        }

        private void button2_Click(object sender, EventArgs e) //open form2
        {
            var selectedItem = listViewOfLocations.SelectedItems[0];
            var selectedModel = (SearchModel)selectedItem.Tag;

            Form2 main = new Form2(selectedModel.Woeid);
            main.ShowDialog();
        }

        private void textBoxSearchChanged(object sender, EventArgs e)
        {
            if (!textBoxSearchLocation.Text.Trim().Any())
            {
                enableProperties("");
                return;
            }
                textBoxSearchLocation.Text = textBoxSearchLocation.Text.Trim();
                var search = textBoxSearchLocation.Text;
                var locations = _api.GetLocations(search);

            if (!locations.Any())
            {
                enableProperties("None cities found in the data base with this name");
                return;
            }
                label9.Text = $"{locations.Count} result found";
                listViewOfLocations.Items.Clear();
                foreach (SearchModel place in locations)
                {
                    var listItem = new ListViewItem();
                    listItem.Tag = place;
                    listItem.Text = place.Title;
                    listViewOfLocations.Items.Add(listItem);
                }
        }

        private void enableProperties(String text)
        {
            labelLocationDescription.Text = "";
            ForecastTab.Visible = false;
            labelWeatherForecast.Visible = false;
            weatherHistoryButton.Visible = false;
            listViewOfLocations.Items.Clear();
            label9.Text = text;
        }

    }
}
