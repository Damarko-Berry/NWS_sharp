using System;
using System.Collections.Generic;
using System.Text;

namespace NWS_sharp
{
    public class WeatherPeriod
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool IsDaytime { get; set; }
        public int Temperature { get; set; }
        public string TemperatureUnit { get; set; }
        public string WindSpeed { get; set; }
        public Direction WindDirection { get; set; }
        public string Icon { get; set; }
        public string ShortForecast { get; set; }
        public string DetailedForecast { get; set; }

        public Precipitation ProbabilityOfPrecipitation { get; set; }
    }
    public struct Precipitation
    {
        public string UnitCode { get; set; }
        public int? Value { get; set; } // Nullable, since NWS sometimes returns null
    }
}
