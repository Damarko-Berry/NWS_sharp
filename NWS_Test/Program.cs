using NWS_sharp;
namespace NWS_Test
{
    internal class Program
    {
        static async void Main(string[] args)
        {
            NWSService nwsService = new NWSService("App_Name", "Contact", State.GetState(StateAbrv.OH).MajorCities["Columbus"], Forecast.forecastHourly);
            await nwsService.GetWeather();
            foreach (var period in nwsService.weatherPeriods)
            {
                Console.WriteLine($"{period.Name}: {period.Temperature}°{period.TemperatureUnit}, {period.ShortForecast}");
            }
        }
    }
}
