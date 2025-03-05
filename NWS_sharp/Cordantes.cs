using System;

namespace NWS_sharp
{
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
