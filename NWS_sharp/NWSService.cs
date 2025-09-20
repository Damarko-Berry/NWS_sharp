using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace NWS_sharp
{
    [Serializable]
    public class NWSService
    {
        private readonly HttpClient client = new HttpClient();
        public string Product;
        public string ContactInfo;
        public Coordinates Coordinates;
        

        public List<WeatherPeriod> SemiDailyForecast= new List<WeatherPeriod>();
        public List<WeatherPeriod> HourlyForecast = new List<WeatherPeriod>();
        async Task<string> GetNWSGridPointAsync(Coordinates coordinates, ForecastType forecast)
        {
            string url = $"https://api.weather.gov/points/{coordinates.latitude},{coordinates.longitude}";
            client.DefaultRequestHeaders.Add("User-Agent", $"({Product}, {ContactInfo})");

            var response = await client.GetStringAsync(url);

            var data = JObject.Parse(response);
            string forecastUrl = data["properties"][forecast.ToString()].ToString();
            Console.WriteLine($"NWS ForecastType URL: {forecastUrl}");
            return forecastUrl;
        }
        async Task<List<WeatherPeriod>> GetWeatherAsync(Coordinates coordinates, ForecastType forecast = ForecastType.forecast)
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
            HourlyForecast = await GetWeatherAsync(coordinates, ForecastType.forecastHourly);
            SemiDailyForecast = await GetWeatherAsync(coordinates, ForecastType.forecast);

        }
        public async Task GetWeather(Coordinates coordinates, ForecastType forecast)
        {
            switch (forecast)
            {
                case ForecastType.forecastHourly:
                    HourlyForecast = await GetWeatherAsync(coordinates, forecast);
                    break;
                case ForecastType.forecast:
                    SemiDailyForecast = await GetWeatherAsync(coordinates, forecast);
                    break;
            }
        }

            
        public async Task GetWeather(ForecastType forecast)
        {
            switch (forecast)
            {
                case ForecastType.forecastHourly:
                    HourlyForecast = await GetWeatherAsync(Coordinates, forecast);
                    break;
                case ForecastType.forecast:
                    SemiDailyForecast = await GetWeatherAsync(Coordinates, forecast);
                    break;
            }
        }
        public async Task GetWeather()
        {
            HourlyForecast = await GetWeatherAsync(Coordinates, ForecastType.forecastHourly);
            SemiDailyForecast = await GetWeatherAsync(Coordinates, ForecastType.forecast);
        }
        public NWSService(string product, string contactInfo, Coordinates coordinates)
        {
            Product = product;
            ContactInfo = contactInfo;
            Coordinates = coordinates;
        }
        public NWSService(string product, string contactInfo)
        {
            Product = product;
            ContactInfo = contactInfo;
            Coordinates = State.GetState(StateAbrv.DC).Capital;
        }
    }
}
