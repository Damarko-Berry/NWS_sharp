using System;
using System.Collections.Generic;
using System.Text;

namespace NWS_sharp
{
    [Serializable]
    public class WeatherPeriod
    {
        public int Number;
        public string Name;
        public DateTime StartTime;
        public DateTime EndTime;
        public bool IsDaytime;
        public int Temperature;
        public string TemperatureUnit;
        public string WindSpeed;
        public Direction WindDirection;
        public string Icon;
        public string ShortForecast;
        public string DetailedForecast;
        ForecastType ForecastType => (Name == string.Empty) ? ForecastType.forecastHourly : ForecastType.forecast;
        public SkyCover SkyCoverage
        {
            get
            {
                var SF = Parse(ShortForecast);
                switch (ForecastType)
                {
                    case ForecastType.forecastHourly:
                    return SF;
                    case ForecastType.forecast:
                    var DF = Parse(ShortForecast);
                    var DDF = Parse(DetailedForecast);
                    if(DF != SkyCover.NA)
                    {
                        return DF;
                    }
                    else
                    {
                        return DDF;
                    }
                }
                return SkyCover.NA;
            }
        }

        public Precipitation ProbabilityOfPrecipitation;

        public static SkyCover Parse(string str)
        {
            if (str == string.Empty) return SkyCover.NA;
            var Coverages = Enum.GetValues(typeof(SkyCover));
            for (int i = 1; i < Coverages.Length; i++)
            {
                if (str.Contains(Coverages.GetValue(i).ToString().Replace("_"," "), StringComparison.InvariantCultureIgnoreCase))
                {
                    return (SkyCover)Coverages.GetValue(i);
                }
            }
            return SkyCover.NA;
        }
    }

    [Serializable]
    public struct Precipitation
    {
        public string UnitCode;
        public int? Value;
        public double Probability()
        {
            if (Value == null)
                return 0;
            return (double)Value / 100;
        }
    }
}
