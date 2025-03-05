﻿
namespace NWS_sharp
{
    public enum StateAbrv
    {
        DC,
        AL,
        AK,
        AZ,
        AR,
        CA,
        CO,
        CT,
        DE,
        FL,
        GA,
        HI,
        ID,
        IL,
        IN,
        IA,
        KS,
        KY,
        LA,
        ME,
        MD,
        MA,
        MI,
        MN,
        MS,
        MO,
        MT,
        NE,
        NV,
        NH,
        NJ,
        NM,
        NY,
        NC,
        ND,
        OH,
        OK,
        OR,
        PA,
        RI,
        SC,
        SD,
        TN,
        TX,
        UT,
        VT,
        VA,
        WA,
        WV,
        WI,
        WY
    }
    public enum Direction
    {
        N,
        NE,
        E,
        SE,
        S,
        SW,
        W,
        NW,
        WNW,
        WSW,
        NNE,
        ENE,
        ESE,
        SSE,
        SSW,
        NNW
    }
    public enum SkyCover { Clear, PartlyCloudy, MostlyCloudy, Overcast }
    public enum  Forecast
    {
        forecast,
        forecastHourly,
    }
}
