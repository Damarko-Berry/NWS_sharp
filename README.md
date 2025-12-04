# NWS_sharp
A simple use of the NWS (National Weather Service) API. The NWS is completely free and doesn't reqire a key to use, but they do ask that you send requests with your app's name and contact info.
Unfortunatly, the NSW is U.S. specific, so trying to make calls for a set of coordinates outside of the US will result in an error. Before you ask: I opted for fields instead of properties for the sake of having it present in the Unity inspector for debugging. Feel free to rewrite it to be properties. This is also a .NET standard 2.1 library.

## Usage
`NWSService` is the primary class.
### using the coordindate struct
This block of code will grab based on coordindates
```
NWSService nwsService = new NWSService("App_Name", "Contact", new Coordinates(38.89511, -77.03637));
await nwsService.GetWeather();
foreach (var period in nwsService.weatherPeriods)
{
    Console.WriteLine($"{period.Name}: {period.Temperature}°{period.TemperatureUnit}, {period.ShortForecast}");
}
```
A `WeatherPeriod` will tell you what the weather should be durring a specific time period, and does a half day period by default. if you want a hourly:
```
NWSService nwsService = new NWSService("App_Name", "Contact", new Coordinates(38.89511, -77.03637), Forecast.forecastHourly);
await nwsService.GetWeather();
foreach (var period in nwsService.weatherPeriods)
{
    Console.WriteLine($"{period.Name}: {period.Temperature}°{period.TemperatureUnit}, {period.ShortForecast}");
}
```

### the State class
The `State` class can be used as an alternative for the coordinate struct.

It's only construct `State(StateAbrv code)`, is loaded with each states Capital and 3 major cities coordinates. it's only purpose was to be easier than having to look up each state capitol on your own.

The state class converts to the coordinate class. so you can use it like

```
NWSService nwsService = new NWSService("App_Name", "Contact", State.GetState(StateAbrv.DC), Forecast.forecastHourly);
await nwsService.GetWeather();
foreach (var period in nwsService.weatherPeriods)
{
    Console.WriteLine($"{period.Name}: {period.Temperature}°{period.TemperatureUnit}, {period.ShortForecast}");
}
```
or
```
 NWSService nwsService = new NWSService("App_Name", "Contact", State.GetState(StateAbrv.DC).Capital, Forecast.forecastHourly);
 await nwsService.GetWeather();
 foreach (var period in nwsService.weatherPeriods)
 {
     Console.WriteLine($"{period.Name}: {period.Temperature}°{period.TemperatureUnit}, {period.ShortForecast}");
 }
```
if you want to use a major city
```
NWSService nwsService = new NWSService("App_Name", "Contact", State.GetState(StateAbrv.OH).MajorCities["Columbus"], Forecast.forecastHourly);
await nwsService.GetWeather();
foreach (var period in nwsService.weatherPeriods)
{
    Console.WriteLine($"{period.Name}: {period.Temperature}°{period.TemperatureUnit}, {period.ShortForecast}");
}
```

Keep in mind that forcast isn't hourly by default, and setting the forcast to hourly tells sets it as your perfered forcast type.
