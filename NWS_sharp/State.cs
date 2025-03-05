﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NWS_sharp
{
    public class State
    {
        public string Name { get; set; }
        public Coordinates Capital { get; set; }
        public Dictionary<string, Coordinates> MajorCities { get; set; }

        public State(StateAbrv code)
        {
            MajorCities = new Dictionary<string, Coordinates>();
            switch (code)
            {
                case StateAbrv.DC:
                    Name = "District of Columbia"; Capital = new Coordinates(38.89511, -77.03637);
                    MajorCities.Add("Washington", new Coordinates(38.89511, -77.03637));
                    break;
                case StateAbrv.AL: Name = "Alabama"; Capital = new Coordinates(32.377716, -86.300568);
                    MajorCities.Add("Birmingham", new Coordinates(33.520682, -86.802433));
                    MajorCities.Add("Montgomery", new Coordinates(32.379223, -86.307737));
                    MajorCities.Add("Mobile", new Coordinates(30.695365, -88.039891));
                    break;
                case StateAbrv.AK: Name = "Alaska"; Capital = new Coordinates(58.301598, -134.420212);
                    MajorCities.Add("Anchorage", new Coordinates(61.218056, -149.900278));
                    MajorCities.Add("Fairbanks", new Coordinates(64.837778, -147.716389));
                    MajorCities.Add("Juneau", new Coordinates(58.301598, -134.420212));

                    break;
                case StateAbrv.AZ: Name = "Arizona"; Capital = new Coordinates(33.448376, -112.074036);
                    MajorCities.Add("Phoenix", new Coordinates(33.448376, -112.074036));
                    MajorCities.Add("Tucson", new Coordinates(32.222607, -110.974711));
                    MajorCities.Add("Mesa", new Coordinates(33.415184, -111.831472));


                    break;
                case StateAbrv.AR: Name = "Arkansas"; Capital = new Coordinates(34.746613, -92.288986);
                    MajorCities.Add("Little Rock", new Coordinates(34.746613, -92.288986));
                    MajorCities.Add("Fort Smith", new Coordinates(35.385924, -94.398548));
                    MajorCities.Add("Fayetteville", new Coordinates(36.082156, -94.171854));
                    break;
                case StateAbrv.CA: Name = "California"; Capital = new Coordinates(38.576668, -121.493629);
                    MajorCities.Add("Los Angeles", new Coordinates(34.052235, -118.243683));
                    MajorCities.Add("San Diego", new Coordinates(32.715736, -117.161087));
                    MajorCities.Add("San Francisco", new Coordinates(37.774929, -122.419416));

                    break;
                case StateAbrv.CO: Name = "Colorado"; Capital = new Coordinates(39.739235, -104.990250);
                    MajorCities.Add("Denver", new Coordinates(39.739235, -104.990250));
                    MajorCities.Add("Colorado Springs", new Coordinates(38.833882, -104.821363));
                    MajorCities.Add("Aurora", new Coordinates(39.729431, -104.831917));

                    break;
                case StateAbrv.CT: Name = "Connecticut"; Capital = new Coordinates(41.764046, -72.682198);
                    MajorCities.Add("Bridgeport", new Coordinates(41.186548, -73.195177));
                    MajorCities.Add("New Haven", new Coordinates(41.308274, -72.927883));
                    MajorCities.Add("Hartford", new Coordinates(41.764046, -72.682198));
                    break;
                case StateAbrv.DE: Name = "Delaware"; Capital = new Coordinates(39.158168, -75.524368);
                    MajorCities.Add("Wilmington", new Coordinates(39.739072, -75.539787));
                    MajorCities.Add("Dover", new Coordinates(39.158168, -75.524368));
                    MajorCities.Add("Newark", new Coordinates(39.683723, -75.749657));
                    break;
                case StateAbrv.FL: Name = "Florida"; Capital = new Coordinates(30.438118, -84.281296);
                    MajorCities.Add("Jacksonville", new Coordinates(30.332184, -81.655651));
                    MajorCities.Add("Miami", new Coordinates(25.774265, -80.193658));
                    MajorCities.Add("Tampa", new Coordinates(27.950575, -82.457178));
                    break;
                case StateAbrv.GA: Name = "Georgia"; Capital = new Coordinates(33.749027, -84.388229);
                    MajorCities.Add("Atlanta", new Coordinates(33.749027, -84.388229));
                    MajorCities.Add("Augusta", new Coordinates(33.470971, -81.974842));
                    MajorCities.Add("Savannah", new Coordinates(32.080898, -81.091203));
                    break;
                case StateAbrv.HI: Name = "Hawaii"; Capital = new Coordinates(21.307442, -157.857376);
                    MajorCities.Add("Honolulu", new Coordinates(21.307442, -157.857376));
                    MajorCities.Add("Hilo", new Coordinates(19.707094, -155.081398));
                    MajorCities.Add("Kailua", new Coordinates(21.402222, -157.739444));
                    break;
                case StateAbrv.ID: Name = "Idaho"; Capital = new Coordinates(43.617775, -116.199722);
                    MajorCities.Add("Boise", new Coordinates(43.615019, -116.202314));
                    MajorCities.Add("Nampa", new Coordinates(43.540717, -116.563462));
                    MajorCities.Add("Meridian", new Coordinates(43.612108, -116.391513));
                    break;
                case StateAbrv.IL: Name = "Illinois"; Capital = new Coordinates(39.798363, -89.654961);
                    MajorCities.Add("Chicago", new Coordinates(41.878114, -87.629798));
                    MajorCities.Add("Aurora", new Coordinates(41.760585, -88.320072));
                    MajorCities.Add("Rockford", new Coordinates(42.271131, -89.093995));
                    break;
                case StateAbrv.IN: Name = "Indiana"; Capital = new Coordinates(39.768623, -86.162643);
                    MajorCities.Add("Indianapolis", new Coordinates(39.768623, -86.162643));
                    MajorCities.Add("Fort Wayne", new Coordinates(41.079273, -85.139351));
                    MajorCities.Add("Evansville", new Coordinates(37.971559, -87.571090));
                    break;
                case StateAbrv.IA: Name = "Iowa"; Capital = new Coordinates(41.591087, -93.603729);
                    MajorCities.Add("Des Moines", new Coordinates(41.600545, -93.609106));
                    MajorCities.Add("Cedar Rapids", new Coordinates(41.977880, -91.665623));
                    MajorCities.Add("Davenport", new Coordinates(41.523643, -90.577636));
                    break;
                case StateAbrv.KS: Name = "Kansas"; Capital = new Coordinates(39.047345, -95.675158);
                    MajorCities.Add("Wichita", new Coordinates(37.692236, -97.337545));
                    MajorCities.Add("Overland Park", new Coordinates(38.982228, -94.670791));
                    MajorCities.Add("Kansas City", new Coordinates(39.106667, -94.676392));
                    break;
                case StateAbrv.KY: Name = "Kentucky"; Capital = new Coordinates(38.186722, -84.875374);
                    MajorCities.Add("Louisville", new Coordinates(38.254238, -85.759407));
                    MajorCities.Add("Lexington", new Coordinates(38.040584, -84.503716));
                    MajorCities.Add("Bowling Green", new Coordinates(36.990319, -86.443604));
                    break;
                case StateAbrv.LA: Name = "Louisiana"; Capital = new Coordinates(30.457069, -91.187393);
                    MajorCities.Add("New Orleans", new Coordinates(29.951065, -90.071533));
                    MajorCities.Add("Baton Rouge", new Coordinates(30.451467, -91.187146));
                    MajorCities.Add("Shreveport", new Coordinates(32.525152, -93.750179));
                    break;
                case StateAbrv.ME: Name = "Maine"; Capital = new Coordinates(44.307167, -69.781693);
                    MajorCities.Add("Portland", new Coordinates(43.661471, -70.255325));
                    MajorCities.Add("Lewiston", new Coordinates(44.100351, -70.214776));
                    MajorCities.Add("Bangor", new Coordinates(44.801182, -68.777813));
                    break;
                case StateAbrv.MD: Name = "Maryland"; Capital = new Coordinates(38.978764, -76.490936);
                    MajorCities.Add("Baltimore", new Coordinates(39.290385, -76.612189));
                    MajorCities.Add("Columbia", new Coordinates(39.203714, -76.861046));
                    MajorCities.Add("Germantown", new Coordinates(39.173162, -77.271650));
                    break;
                case StateAbrv.MA: Name = "Massachusetts"; Capital = new Coordinates(42.360253, -71.058291);
                    MajorCities.Add("Boston", new Coordinates(42.360253, -71.058291));
                    MajorCities.Add("Worcester", new Coordinates(42.262593, -71.802293));
                    MajorCities.Add("Springfield", new Coordinates(42.101483, -72.589811));
                    break;
                case StateAbrv.MI: Name = "Michigan"; Capital = new Coordinates(42.733635, -84.555328);
                    MajorCities.Add("Detroit", new Coordinates(42.331429, -83.045753));
                    MajorCities.Add("Grand Rapids", new Coordinates(42.963360, -85.668086));
                    MajorCities.Add("Warren", new Coordinates(42.514857, -83.014040));
                    break;
                case StateAbrv.MN: Name = "Minnesota"; Capital = new Coordinates(44.955097, -93.102211);
                    MajorCities.Add("Minneapolis", new Coordinates(44.977753, -93.265011));
                    MajorCities.Add("Saint Paul", new Coordinates(44.953703, -93.089958));
                    MajorCities.Add("Rochester", new Coordinates(44.021630, -92.469899));
                    break;
                case StateAbrv.MS: Name = "Mississippi"; Capital = new Coordinates(32.298690, -90.184776);
                    MajorCities.Add("Jackson", new Coordinates(32.298690, -90.184776));
                    MajorCities.Add("Gulfport", new Coordinates(30.367420, -89.092816));
                    MajorCities.Add("Southaven", new Coordinates(34.991858, -90.002296));
                    break;
                case StateAbrv.MO: Name = "Missouri"; Capital = new Coordinates(38.579201, -92.172935);
                    MajorCities.Add("Kansas City", new Coordinates(39.099724, -94.578331));
                    MajorCities.Add("Saint Louis", new Coordinates(38.627003, -90.199402));
                    MajorCities.Add("Springfield", new Coordinates(37.208957, -93.292298));
                    break;
                case StateAbrv.MT: Name = "Montana"; Capital = new Coordinates(46.585709, -112.018417);
                    MajorCities.Add("Billings", new Coordinates(45.783285, -108.500690));
                    MajorCities.Add("Missoula", new Coordinates(46.872128, -113.994031));
                    MajorCities.Add("Great Falls", new Coordinates(47.504876, -111.300738));
                    break;
                case StateAbrv.NE: Name = "Nebraska"; Capital = new Coordinates(40.808075, -96.699654);
                    MajorCities.Add("Omaha", new Coordinates(41.256536, -95.934503));
                    MajorCities.Add("Lincoln", new Coordinates(40.813616, -96.702596));
                    MajorCities.Add("Bellevue", new Coordinates(41.154443, -95.914556));
                    break;
                case StateAbrv.NV: Name = "Nevada"; Capital = new Coordinates(39.163914, -119.766121);
                    MajorCities.Add("Las Vegas", new Coordinates(36.114647, -115.172813));
                    MajorCities.Add("Henderson", new Coordinates(36.039524, -114.981721));
                    MajorCities.Add("Reno", new Coordinates(39.529633, -119.813803));
                    break;
                case StateAbrv.NH: Name = "New Hampshire"; Capital = new Coordinates(43.206898, -71.537994);
                    MajorCities.Add("Manchester", new Coordinates(42.995639, -71.454789));
                    MajorCities.Add("Nashua", new Coordinates(42.765366, -71.467566));
                    MajorCities.Add("Concord", new Coordinates(43.208137, -71.537572));
                    break;
                case StateAbrv.NJ: Name = "New Jersey"; Capital = new Coordinates(40.220596, -74.769913);
                    MajorCities.Add("Newark", new Coordinates(40.735657, -74.172366));
                    MajorCities.Add("Jersey City", new Coordinates(40.728157, -74.077644));
                    MajorCities.Add("Paterson", new Coordinates(40.916765, -74.171811));
                    break;
                case StateAbrv.NM: Name = "New Mexico"; Capital = new Coordinates(35.682240, -105.939728);
                    MajorCities.Add("Albuquerque", new Coordinates(35.084103, -106.650985));
                    MajorCities.Add("Las Cruces", new Coordinates(32.319939, -106.763654));
                    MajorCities.Add("Rio Rancho", new Coordinates(35.232754, -106.663043));
                    break;
                case StateAbrv.NY: Name = "New York"; Capital = new Coordinates(42.652580, -73.756233);
                    MajorCities.Add("New York City", new Coordinates(40.712776, -74.005974));
                    MajorCities.Add("Buffalo", new Coordinates(42.886448, -78.878372));
                    MajorCities.Add("Rochester", new Coordinates(43.156168, -77.608860));
                    break;
                case StateAbrv.NC: Name = "North Carolina"; Capital = new Coordinates(35.780430, -78.639099);
                    MajorCities.Add("Charlotte", new Coordinates(35.227085, -80.843124));
                    MajorCities.Add("Raleigh", new Coordinates(35.780430, -78.639099));
                    MajorCities.Add("Greensboro", new Coordinates(36.072635, -79.791975));
                    break;
                case StateAbrv.ND: Name = "North Dakota"; Capital = new Coordinates(46.820850, -100.783318);
                    MajorCities.Add("Fargo", new Coordinates(46.877186, -96.789803));
                    MajorCities.Add("Bismarck", new Coordinates(46.808327, -100.783739));
                    MajorCities.Add("Grand Forks", new Coordinates(47.925257, -97.032855));
                    break;
                case StateAbrv.OH: Name = "Ohio"; Capital = new Coordinates(39.961346, -82.999069);
                    MajorCities.Add("Cleveland", new Coordinates(41.499320, -81.694361));
                    MajorCities.Add("Cincinnati", new Coordinates(39.103119, -84.512016));
                    MajorCities.Add("Columbus", new Coordinates(39.961346, -82.999069));
                    break;
                case StateAbrv.OK: Name = "Oklahoma"; Capital = new Coordinates(35.492207, -97.503342);
                    MajorCities.Add("Oklahoma City", new Coordinates(35.467560, -97.516428));
                    MajorCities.Add("Tulsa", new Coordinates(36.154000, -95.992775));
                    MajorCities.Add("Norman", new Coordinates(35.222567, -97.439478));
                    break;
                case StateAbrv.OR: Name = "Oregon"; Capital = new Coordinates(44.938461, -123.030403);
                    MajorCities.Add("Portland", new Coordinates(45.523064, -122.676483));
                    MajorCities.Add("Salem", new Coordinates(44.942898, -123.035096));
                    MajorCities.Add("Eugene", new Coordinates(44.052069, -123.086754));
                    break;
                case StateAbrv.PA: Name = "Pennsylvania"; Capital = new Coordinates(40.264378, -76.883598);
                    MajorCities.Add("Philadelphia", new Coordinates(39.952583, -75.165222));
                    MajorCities.Add("Pittsburgh", new Coordinates(40.440624, -79.995888));
                    MajorCities.Add("Allentown", new Coordinates(40.602293, -75.471498));
                    break;
                case StateAbrv.RI: Name = "Rhode Island"; Capital = new Coordinates(41.830914, -71.414963);
                    MajorCities.Add("Providence", new Coordinates(41.8240, -71.4128));
                    MajorCities.Add("Warwick", new Coordinates(41.7001, -71.4162));
                    MajorCities.Add("Cranston", new Coordinates(41.7798, -71.4373));
                    break;
                case StateAbrv.SC: Name = "South Carolina"; Capital = new Coordinates(34.000343, -81.033211);
                    MajorCities.Add("Columbia", new Coordinates(34.000343, -81.033211));
                    MajorCities.Add("Charleston", new Coordinates(32.776475, -79.931051));
                    MajorCities.Add("North Charleston", new Coordinates(32.854619, -79.974810));
                    break;
                case StateAbrv.SD: Name = "South Dakota"; Capital = new Coordinates(44.367031, -100.346405);
                    MajorCities.Add("Sioux Falls", new Coordinates(43.546948, -96.731389));
                    MajorCities.Add("Rapid City", new Coordinates(44.080543, -103.231015));
                    MajorCities.Add("Aberdeen", new Coordinates(45.464664, -98.486392));
                    break;
                case StateAbrv.TN: Name = "Tennessee"; Capital = new Coordinates(36.165810, -86.784241);
                    MajorCities.Add("Memphis", new Coordinates(35.149532, -90.048981));
                    MajorCities.Add("Nashville", new Coordinates(36.165810, -86.784241));
                    MajorCities.Add("Knoxville", new Coordinates(35.960638, -83.920739));
                    break;
                case StateAbrv.TX: Name = "Texas"; Capital = new Coordinates(30.274670, -97.740349);
                    MajorCities.Add("Houston", new Coordinates(29.760427, -95.369804));
                    MajorCities.Add("San Antonio", new Coordinates(29.424122, -98.493628));
                    MajorCities.Add("Dallas", new Coordinates(32.776665, -96.796988));
                    break;
                case StateAbrv.UT: Name = "Utah"; Capital = new Coordinates(40.777477, -111.888237);
                    MajorCities.Add("Salt Lake City", new Coordinates(40.777477, -111.888237));
                    MajorCities.Add("West Valley City", new Coordinates(40.691613, -112.001050));
                    MajorCities.Add("Provo", new Coordinates(40.233844, -111.658534));
                    break;
                case StateAbrv.VT: Name = "Vermont"; Capital = new Coordinates(44.262436, -72.580536);
                    MajorCities.Add("Burlington", new Coordinates(44.475882, -73.212072));
                    MajorCities.Add("South Burlington", new Coordinates(44.466994, -73.170960));
                    MajorCities.Add("Rutland", new Coordinates(43.610623, -72.972606));
                    break;
                case StateAbrv.VA: Name = "Virginia"; Capital = new Coordinates(37.538857, -77.433640);
                    MajorCities.Add("Virginia Beach", new Coordinates(36.852926, -75.977985));
                    MajorCities.Add("Norfolk", new Coordinates(36.850769, -76.285873));
                    MajorCities.Add("Chesapeake", new Coordinates(36.768208, -76.287492));
                    break;
                case StateAbrv.WA: Name = "Washington"; Capital = new Coordinates(47.037872, -122.900696);
                    MajorCities.Add("Seattle", new Coordinates(47.606209, -122.332069));
                    MajorCities.Add("Spokane", new Coordinates(47.658780, -117.426046));
                    MajorCities.Add("Tacoma", new Coordinates(47.252877, -122.444291));
                    break;
                case StateAbrv.WV: Name = "West Virginia"; Capital = new Coordinates(38.336246, -81.612328);
                    MajorCities.Add("Charleston", new Coordinates(38.349820, -81.632623));
                    MajorCities.Add("Huntington", new Coordinates(38.419250, -82.445154));
                    MajorCities.Add("Parkersburg", new Coordinates(39.266741, -81.561513));
                    break;
                case StateAbrv.WI: Name = "Wisconsin"; Capital = new Coordinates(43.074684, -89.384445);
                    MajorCities.Add("Milwaukee", new Coordinates(43.038902, -87.906471));
                    MajorCities.Add("Madison", new Coordinates(43.073051, -89.401230));
                    MajorCities.Add("Green Bay", new Coordinates(44.513319, -88.013296));
                    break;
                case StateAbrv.WY: Name = "Wyoming"; Capital = new Coordinates(41.140259, -104.820236);
                    MajorCities.Add("Cheyenne", new Coordinates(41.139981, -104.820246));
                    MajorCities.Add("Casper", new Coordinates(42.866632, -106.313081));
                    MajorCities.Add("Laramie", new Coordinates(41.311367, -105.591101));
                    break;
                default: throw new ArgumentException("Invalid state code");
            }

        }

        public static implicit operator Coordinates(State v)
        {
            return v.Capital;
        }
    }
}
