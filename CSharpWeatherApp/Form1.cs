using System;
using System.Net.Http;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CSharpWeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnGetWeather_Click(object sender, EventArgs e)
        {
            string city = textBoxCity.Text;
            string apiKey = "c048a8b270f379cc5e5f3da023d456b2"; // Replace with your OpenWeatherMap API key
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string response = await client.GetStringAsync(url);
                    dynamic weatherData = JsonConvert.DeserializeObject(response);

                    txtTemp.Text = "Temp: " + weatherData.main.temp + "°C";
                    txtCon.Text = "Condition: " + weatherData.weather[0].main;
                    txtHum.Text = "Humidity: " + weatherData.main.humidity + "%";
                    txtWind.Text = "Wind: " + weatherData.wind.speed + " m/s";

                    // Optional: set icon
                    string icon = weatherData.weather[0].icon;
                    pictureBoxWeather.Load($"http://openweathermap.org/img/wn/{icon}@2x.png");
                }
                catch
                {
                    MessageBox.Show("City not found or network error!");
                }
            }
        }
    }
}