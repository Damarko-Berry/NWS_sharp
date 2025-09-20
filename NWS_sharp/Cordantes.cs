using System;
using System.Collections.Generic;

namespace NWS_sharp
{
    [Serializable]
    public struct Coordinates
    {
        public double latitude;
        public double longitude;

        public Coordinates(double lat, double lon)
        {
            latitude = lat;
            longitude = lon;
        }
        

    }
    
}
