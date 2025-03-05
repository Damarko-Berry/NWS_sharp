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
        
        public async Task<string> GetNWSGridpointAsync(Coordinates coordinates, Forecast forecast)
        {
            string url = $"https://api.weather.gov/points/{coordinates.latitude},{coordinates.longitude}";
            Console.WriteLine($"NWS Gridpoint URL: {url}");
            client.DefaultRequestHeaders.Add("User-Agent", $"({Product}, {ContactInfo})");

            var response = await client.GetStringAsync(url);

            var data = JObject.Parse(response);
            Console.WriteLine($"NWS Gridpoint Data: {data["properties"]["relativeLocation"]["properties"]["city"]},{data["properties"]["relativeLocation"]["properties"]["state"]}");
            string forecastUrl = data["properties"][forecast.ToString()].ToString();
            Console.WriteLine($"NWS Forecast URL: {forecastUrl}");
            return forecastUrl;
        }
        public async Task<List<WeatherPeriod>> GetWeatherAsync(Coordinates coordinates, Forecast forecast = Forecast.forecast)
        {
            string forecastUrl = await GetNWSGridpointAsync(coordinates, forecast);

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

        public NWSService(string product, string contactInfo)
        {
            Product = product;
            ContactInfo = contactInfo;
        }
    }
}
