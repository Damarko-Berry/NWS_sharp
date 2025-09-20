using NWS_sharp;
namespace NWS_Test
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            NWSService nwsService = new NWSService("App_Name", "Contact", State.GetState(StateAbrv.OH).MajorCities["Columbus"]);
            await nwsService.GetWeather();
            foreach (var period in nwsService.HourlyForecast)
            {
                Console.WriteLine($"{period.Name}: {period.Temperature}°{period.TemperatureUnit}, {period.ShortForecast}");
            }
        }
    }
}
