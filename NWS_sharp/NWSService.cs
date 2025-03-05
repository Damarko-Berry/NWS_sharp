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
        public string Product { get; set; }
        public string ContactInfo { get; set; }
        public Coordinates Coordinates { get; private set; }
        public Coordinates m_Coordinates
        {
            set
            {
                Coordinates = value;
                GetWeather(value);
            } 
        }
        public List<WeatherPeriod> weatherPeriods = new List<WeatherPeriod>();
        public async Task<string> GetNWSGridPointAsync(Coordinates coordinates, Forecast forecast)
        {
            string url = $"https://api.weather.gov/points/{coordinates.latitude},{coordinates.longitude}";
            client.DefaultRequestHeaders.Add("User-Agent", $"({Product}, {ContactInfo})");

            var response = await client.GetStringAsync(url);

            var data = JObject.Parse(response);
            string forecastUrl = data["properties"][forecast.ToString()].ToString();
            Console.WriteLine($"NWS Forecast URL: {forecastUrl}");
            return forecastUrl;
        }
        public async Task<List<WeatherPeriod>> GetWeatherAsync(Coordinates coordinates, Forecast forecast = Forecast.forecast)
        {
            string forecastUrl = await GetNWSGridPointAsync(coordinates, forecast);

            var response = await client.GetStringAsync(forecastUrl);
            var data = JObject.Parse(response);

            var periodsJson = data["properties"]["periods"].ToString();
            var weatherPeriods = JsonConvert.DeserializeObject<List<WeatherPeriod>>(periodsJson);

            foreach (var period in weatherPeriods)
            {
                Console.WriteLine($"{period.Name}: {period.Temperature}°{period.TemperatureUnit}, {period.ShortForecast}");
            }

            return weatherPeriods;
        }
        public async Task GetWeather(Coordinates coordinates)
        {
            weatherPeriods = await GetWeatherAsync(coordinates);
        }
        public NWSService(string product, string contactInfo, Coordinates coordinates)
        {
            Product = product;
            ContactInfo = contactInfo;
            m_Coordinates = coordinates;
        }
        public NWSService(string product, string contactInfo)
        {
            Product = product;
            ContactInfo = contactInfo;
        }
    }
}
