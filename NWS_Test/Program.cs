using NWS_sharp;
namespace NWS_Test
{
    internal class Program
    {
        static NWSService nwsService = new NWSService("NWS_Test", "Markopolo");
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Choooose:
            Console.WriteLine("Choose a state number");
            int S = int.Parse(Console.ReadLine());
            if (S < 1 || S > 50)
            {
                Console.WriteLine("Invalid state number");
                goto Choooose;
            }
            Console.WriteLine($"Fetching weather data for {(StateAbrv)S}");
            State state = new((StateAbrv)S);
            Coordinates coordinates = state.Capital;
            var weatherPeriods = nwsService.GetWeatherAsync(coordinates, Forecast.forecast).Result;
        }
    }
}
