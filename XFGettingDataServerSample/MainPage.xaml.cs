using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Xamarin.Forms;
using Newtonsoft.Json;

namespace XFGettingDataServerSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            var httpClient = new HttpClient();
            var resultJson = await httpClient.GetStringAsync("http://192.168.1.77:3333/weatherforecast");

            var resultForecasts = JsonConvert.DeserializeObject<WeatherForecast[]>(resultJson);

            forecasts.ItemsSource = resultForecasts;
        }
    }
}
