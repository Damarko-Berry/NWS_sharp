using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace NWS_sharp
{
    public class NWSService
    {
        private readonly HttpClient client = new HttpClient();
        string Product { get; set; }
        string ContactInfo { get; set; }
        public Coordinates Coordinates { get; private set; }
        

        public Forecast PreferencedForecast { get; set; } = Forecast.forecast;
        public List<WeatherPeriod> weatherPeriods = new List<WeatherPeriod>();
        async Task<string> GetNWSGridPointAsync(Coordinates coordinates, Forecast forecast)
        {
            string url = $"https://api.weather.gov/points/{coordinates.latitude},{coordinates.longitude}";
            client.DefaultRequestHeaders.Add("User-Agent", $"({Product}, {ContactInfo})");

            var response = await client.GetStringAsync(url);

            var data = JObject.Parse(response);
            string forecastUrl = data["properties"][forecast.ToString()].ToString();
            Console.WriteLine($"NWS Forecast URL: {forecastUrl}");
            return forecastUrl;
        }
        async Task<List<WeatherPeriod>> GetWeatherAsync(Coordinates coordinates, Forecast forecast = Forecast.forecast)
        {
            string forecastUrl = await GetNWSGridPointAsync(coordinates, forecast);

            var response = await client.GetStringAsync(forecastUrl);
            var data = JObject.Parse(response);

            var periodsJson = data["properties"]["periods"].ToString();
            var weatherPeriods = JsonConvert.DeserializeObject<List<WeatherPeriod>>(periodsJson);
            return weatherPeriods;
        }
        public async Task GetWeather(Coordinates coordinates)
        {
            weatherPeriods = await GetWeatherAsync(coordinates, PreferencedForecast);
        }
        public async Task GetWeather(Coordinates coordinates, Forecast forecast)
        {
            weatherPeriods = await GetWeatherAsync(coordinates, forecast);
        }
        public async Task GetWeather(Forecast forecast)
        {
            weatherPeriods = await GetWeatherAsync(Coordinates, forecast);
        }
        public async Task GetWeather()
        {
            weatherPeriods = await GetWeatherAsync(Coordinates, PreferencedForecast);
        }
        public NWSService(string product, string contactInfo, Coordinates coordinates, Forecast forecast = Forecast.forecast)
        {
            Product = product;
            ContactInfo = contactInfo;
            Coordinates = coordinates;
            PreferencedForecast = forecast;
        }
        public NWSService(string product, string contactInfo)
        {
            Product = product;
            ContactInfo = contactInfo;
            Coordinates = State.GetState(StateAbrv.DC).Capital;
        }
    }
}
