using System;
using System.Collections.Generic;
using System.Text;

namespace NWS_sharp
{
    public class State
    {
        public string Name { get; set; }
        public Coordinates Capital { get; set; }
        public Dictionary<string, Coordinates> MajorCities { get; set; }

        public static State GetState(StateAbrv code)
        {
            return code switch
            {
                StateAbrv.DC => new State(
                    "District of Columbia", new Coordinates(38.89511, -77.03637), new Dictionary<string, Coordinates>
                    {
                        { "Washington", new Coordinates(38.89511, -77.03637) }
                    }),
                StateAbrv.AL => new State(
                    "Alabama", new Coordinates(32.377716, -86.300568), new Dictionary<string, Coordinates>
                    {
                        { "Birmingham", new Coordinates(33.520682, -86.802433) },
                        { "Montgomery", new Coordinates(32.379223, -86.307737) },
                        { "Mobile", new Coordinates(30.695365, -88.039891) }
                    }),
                StateAbrv.AK => new State(
                    "Alaska", new Coordinates(58.301598, -134.420212), new Dictionary<string, Coordinates>
                    {
                        { "Anchorage", new Coordinates(61.218056, -149.900278) },
                        { "Fairbanks", new Coordinates(64.837778, -147.716389) },
                        { "Juneau", new Coordinates(58.301598, -134.420212) }
                    }),
                StateAbrv.AZ => new State(
                    "Arizona", new Coordinates(33.448376, -112.074036), new Dictionary<string, Coordinates>
                    {
                        { "Phoenix", new Coordinates(33.448376, -112.074036) },
                        { "Tucson", new Coordinates(32.222607, -110.974711) },
                        { "Mesa", new Coordinates(33.415184, -111.831472) }
                    }),
                StateAbrv.AR => new State(
                    "Arkansas", new Coordinates(34.746613, -92.288986), new Dictionary<string, Coordinates>
                    {
                        { "Little Rock", new Coordinates(34.746613, -92.288986) },
                        { "Fort Smith", new Coordinates(35.385924, -94.398548) },
                        { "Fayetteville", new Coordinates(36.082156, -94.171854) }
                    }),
                StateAbrv.CA => new State(
                    "California", new Coordinates(38.576668, -121.493629), new Dictionary<string, Coordinates>
                    {
                        { "Los Angeles", new Coordinates(34.052235, -118.243683) },
                        { "San Diego", new Coordinates(32.715736, -117.161087) },
                        { "San Francisco", new Coordinates(37.774929, -122.419416) }
                    }),
                StateAbrv.CO => new State(
                    "Colorado", new Coordinates(39.739235, -104.990250), new Dictionary<string, Coordinates>
                    {
                        { "Denver", new Coordinates(39.739235, -104.990250) },
                        { "Colorado Springs", new Coordinates(38.833882, -104.821363) },
                        { "Aurora", new Coordinates(39.729431, -104.831917) }
                    }),
                StateAbrv.CT => new State(
                    "Connecticut", new Coordinates(41.764046, -72.682198), new Dictionary<string, Coordinates>
                    {
                        { "Bridgeport", new Coordinates(41.186548, -73.195177) },
                        { "New Haven", new Coordinates(41.308274, -72.927883) },
                        { "Hartford", new Coordinates(41.764046, -72.682198) }
                    }),
                StateAbrv.DE => new State(
                    "Delaware", new Coordinates(39.158168, -75.524368), new Dictionary<string, Coordinates>
                    {
                        { "Wilmington", new Coordinates(39.739072, -75.539787) },
                        { "Dover", new Coordinates(39.158168, -75.524368) },
                        { "Newark", new Coordinates(39.683723, -75.749657) }
                    }),
                StateAbrv.FL => new State(
                    "Florida", new Coordinates(30.438118, -84.281296), new Dictionary<string, Coordinates>
                    {
                        { "Jacksonville", new Coordinates(30.332184, -81.655651) },
                        { "Miami", new Coordinates(25.774265, -80.193658) },
                        { "Tampa", new Coordinates(27.950575, -82.457178) }
                    }),
                StateAbrv.GA => new State(
                    "Georgia", new Coordinates(33.749027, -84.388229), new Dictionary<string, Coordinates>
                    {
                        { "Atlanta", new Coordinates(33.749027, -84.388229) },
                        { "Augusta", new Coordinates(33.470971, -81.974842) },
                        { "Savannah", new Coordinates(32.080898, -81.091203) }
                    }),
                StateAbrv.HI => new State(
                    "Hawaii", new Coordinates(21.307442, -157.857376), new Dictionary<string, Coordinates>
                    {
                        { "Honolulu", new Coordinates(21.307442, -157.857376) },
                        { "Hilo", new Coordinates(19.707094, -155.081398) },
                        { "Kailua", new Coordinates(21.402222, -157.739444) }
                    }),
                StateAbrv.ID => new State(
                    "Idaho", new Coordinates(43.617775, -116.199722), new Dictionary<string, Coordinates>
                    {
                        { "Boise", new Coordinates(43.615019, -116.202314) },
                        { "Nampa", new Coordinates(43.540717, -116.563462) },
                        { "Meridian", new Coordinates(43.612108, -116.391513) }
                    }),
                StateAbrv.IL => new State(
                    "Illinois", new Coordinates(39.798363, -89.654961), new Dictionary<string, Coordinates>
                    {
                        { "Chicago", new Coordinates(41.878114, -87.629798) },
                        { "Aurora", new Coordinates(41.760585, -88.320072) },
                        { "Rockford", new Coordinates(42.271131, -89.093995) }
                    }),
                StateAbrv.IN => new State(
                    "Indiana", new Coordinates(39.768623, -86.162643), new Dictionary<string, Coordinates>
                    {
                        { "Indianapolis", new Coordinates(39.768623, -86.162643) },
                        { "Fort Wayne", new Coordinates(41.079273, -85.139351) },
                        { "Evansville", new Coordinates(37.971559, -87.571090) }
                    }),
                StateAbrv.IA => new State(
                    "Iowa", new Coordinates(41.591087, -93.603729), new Dictionary<string, Coordinates>
                    {
                        { "Des Moines", new Coordinates(41.600545, -93.609106) },
                        { "Cedar Rapids", new Coordinates(41.977880, -91.665623) },
                        { "Davenport", new Coordinates(41.523643, -90.577636) }
                    }),
                StateAbrv.KS => new State(
                    "Kansas", new Coordinates(39.047345, -95.675158), new Dictionary<string, Coordinates>
                    {
                        { "Wichita", new Coordinates(37.692236, -97.337545) },
                        { "Overland Park", new Coordinates(38.982228, -94.670791) },
                        { "Kansas City", new Coordinates(39.106667, -94.676392) }
                    }),
                StateAbrv.KY => new State(
                    "Kentucky", new Coordinates(38.186722, -84.875374), new Dictionary<string, Coordinates>
                    {
                        { "Louisville", new Coordinates(38.254238, -85.759407) },
                        { "Lexington", new Coordinates(38.040584, -84.503716) },
                        { "Bowling Green", new Coordinates(36.990319, -86.443604) }
                    }),
                StateAbrv.LA => new State(
                    "Louisiana", new Coordinates(30.457069, -91.187393), new Dictionary<string, Coordinates>
                    {
                        { "New Orleans", new Coordinates(29.951065, -90.071533) },
                        { "Baton Rouge", new Coordinates(30.451467, -91.187146) },
                        { "Shreveport", new Coordinates(32.525152, -93.750179) }
                    }),
                StateAbrv.ME => new State(
                    "Maine", new Coordinates(44.307167, -69.781693), new Dictionary<string, Coordinates>
                    {
                        { "Portland", new Coordinates(43.661471, -70.255325) },
                        { "Lewiston", new Coordinates(44.100351, -70.214776) },
                        { "Bangor", new Coordinates(44.801182, -68.777813) }
                    }),
                StateAbrv.MD => new State(
                    "Maryland", new Coordinates(38.978764, -76.490936), new Dictionary<string, Coordinates>
                    {
                        { "Baltimore", new Coordinates(39.290385, -76.612189) },
                        { "Columbia", new Coordinates(39.203714, -76.861046) },
                        { "Germantown", new Coordinates(39.173162, -77.271650) }
                    }),
                StateAbrv.MA => new State(
                    "Massachusetts", new Coordinates(42.360253, -71.058291), new Dictionary<string, Coordinates>
                    {
                        { "Boston", new Coordinates(42.360253, -71.058291) },
                        { "Worcester", new Coordinates(42.262593, -71.802293) },
                        { "Springfield", new Coordinates(42.101483, -72.589811) }
                    }),
                StateAbrv.MI => new State(
                    "Michigan", new Coordinates(42.733635, -84.555328), new Dictionary<string, Coordinates>
                    {
                        { "Detroit", new Coordinates(42.331429, -83.045753) },
                        { "Grand Rapids", new Coordinates(42.963360, -85.668086) },
                        { "Warren", new Coordinates(42.514857, -83.014040) }
                    }),
                StateAbrv.MN => new State(
                    "Minnesota", new Coordinates(44.955097, -93.102211), new Dictionary<string, Coordinates>
                    {
                        { "Minneapolis", new Coordinates(44.977753, -93.265011) },
                        { "Saint Paul", new Coordinates(44.953703, -93.089958) },
                        { "Rochester", new Coordinates(44.021630, -92.469899) }
                    }),
                StateAbrv.MS => new State(
                    "Mississippi", new Coordinates(32.298690, -90.184776), new Dictionary<string, Coordinates>
                    {
                        { "Jackson", new Coordinates(32.298690, -90.184776) },
                        { "Gulfport", new Coordinates(30.367420, -89.092816) },
                        { "Southaven", new Coordinates(34.991858, -90.002296) }
                    }),
                StateAbrv.MO => new State(
                    "Missouri", new Coordinates(38.579201, -92.172935), new Dictionary<string, Coordinates>
                    {
                        { "Kansas City", new Coordinates(39.099724, -94.578331) },
                        { "Saint Louis", new Coordinates(38.627003, -90.199402) },
                        { "Springfield", new Coordinates(37.208957, -93.292298) }
                    }),
                StateAbrv.MT => new State(
                    "Montana", new Coordinates(46.585709, -112.018417), new Dictionary<string, Coordinates>
                    {
                        { "Billings", new Coordinates(45.783285, -108.500690) },
                        { "Missoula", new Coordinates(46.872128, -113.994031) },
                        { "Great Falls", new Coordinates(47.504876, -111.300738) }
                    }),
                StateAbrv.NE => new State(
                    "Nebraska", new Coordinates(40.808075, -96.699654), new Dictionary<string, Coordinates>
                    {
                        { "Omaha", new Coordinates(41.256536, -95.934503) },
                        { "Lincoln", new Coordinates(40.813616, -96.702596) },
                        { "Bellevue", new Coordinates(41.154443, -95.914556) }
                    }),
                StateAbrv.NV => new State(
                    "Nevada", new Coordinates(39.163914, -119.766121), new Dictionary<string, Coordinates>
                    {
                        { "Las Vegas", new Coordinates(36.114647, -115.172813) },
                        { "Henderson", new Coordinates(36.039524, -114.981721) },
                        { "Reno", new Coordinates(39.529633, -119.813803) }
                    }),
                StateAbrv.NH => new State(
                    "New Hampshire", new Coordinates(43.206898, -71.537994), new Dictionary<string, Coordinates>
                    {
                        { "Manchester", new Coordinates(42.995639, -71.454789) },
                        { "Nashua", new Coordinates(42.765366, -71.467566) },
                        { "Concord", new Coordinates(43.208137, -71.537572) }
                    }),
                StateAbrv.NJ => new State(
                    "New Jersey", new Coordinates(40.220596, -74.769913), new Dictionary<string, Coordinates>
                    {
                        { "Newark", new Coordinates(40.735657, -74.172366) },
                        { "Jersey City", new Coordinates(40.728157, -74.077644) },
                        { "Paterson", new Coordinates(40.916765, -74.171811) }
                    }),
                StateAbrv.NM => new State(
                    "New Mexico", new Coordinates(35.682240, -105.939728), new Dictionary<string, Coordinates>
                    {
                        { "Albuquerque", new Coordinates(35.084103, -106.650985) },
                        { "Las Cruces", new Coordinates(32.319939, -106.763654) },
                        { "Rio Rancho", new Coordinates(35.232754, -106.663043) }
                    }),
                StateAbrv.NY => new State(
                    "New York", new Coordinates(42.652580, -73.756233), new Dictionary<string, Coordinates>
                    {
                        { "New York City", new Coordinates(40.712776, -74.005974) },
                        { "Buffalo", new Coordinates(42.886448, -78.878372) },
                        { "Rochester", new Coordinates(43.156168, -77.608860) }
                    }),
                StateAbrv.NC => new State(
                    "North Carolina", new Coordinates(35.780430, -78.639099), new Dictionary<string, Coordinates>
                    {
                        { "Charlotte", new Coordinates(35.227085, -80.843124) },
                        { "Raleigh", new Coordinates(35.780430, -78.639099) },
                        { "Greensboro", new Coordinates(36.072635, -79.791975) }
                    }),
                StateAbrv.ND => new State(
                    "North Dakota", new Coordinates(46.820850, -100.783318), new Dictionary<string, Coordinates>
                    {
                        { "Fargo", new Coordinates(46.877186, -96.789803) },
                        { "Bismarck", new Coordinates(46.808327, -100.783739) },
                        { "Grand Forks", new Coordinates(47.925257, -97.032855) }
                    }),
                StateAbrv.OH => new State(
                    "Ohio", new Coordinates(39.961346, -82.999069), new Dictionary<string, Coordinates>
                    {
                        { "Cleveland", new Coordinates(41.499320, -81.694361) },
                        { "Cincinnati", new Coordinates(39.103119, -84.512016) },
                        { "Columbus", new Coordinates(39.961346, -82.999069) }
                    }),
                StateAbrv.OK => new State(
                    "Oklahoma", new Coordinates(35.492207, -97.503342), new Dictionary<string, Coordinates>
                    {
                        { "Oklahoma City", new Coordinates(35.467560, -97.516428) },
                        { "Tulsa", new Coordinates(36.154000, -95.992775) },
                        { "Norman", new Coordinates(35.222567, -97.439478) }
                    }),
                StateAbrv.OR => new State(
                    "Oregon", new Coordinates(44.938461, -123.030403), new Dictionary<string, Coordinates>
                    {
                        { "Portland", new Coordinates(45.523064, -122.676483) },
                        { "Salem", new Coordinates(44.942898, -123.035096) },
                        { "Eugene", new Coordinates(44.052069, -123.086754) }
                    }),
                StateAbrv.PA => new State(
                    "Pennsylvania", new Coordinates(40.264378, -76.883598), new Dictionary<string, Coordinates>
                    {
                        { "Philadelphia", new Coordinates(39.952583, -75.165222) },
                        { "Pittsburgh", new Coordinates(40.440624, -79.995888) },
                        { "Allentown", new Coordinates(40.602293, -75.471498) }
                    }),
                StateAbrv.RI => new State(
                    "Rhode Island", new Coordinates(41.830914, -71.414963), new Dictionary<string, Coordinates>
                    {
                        { "Providence", new Coordinates(41.8240, -71.4128) },
                        { "Warwick", new Coordinates(41.7001, -71.4162) },
                        { "Cranston", new Coordinates(41.7798, -71.4373) }
                    }),
                StateAbrv.SC => new State(
                    "South Carolina", new Coordinates(34.000343, -81.033211), new Dictionary<string, Coordinates>
                    {
                        { "Columbia", new Coordinates(34.000343, -81.033211) },
                        { "Charleston", new Coordinates(32.776475, -79.931051) },
                        { "North Charleston", new Coordinates(32.854619, -79.974810) }
                    }),
                StateAbrv.SD => new State( "South Dakota", new Coordinates(44.367031, -100.346405),new Dictionary<string, Coordinates>
                    {
                        { "Sioux Falls", new Coordinates(43.546948, -96.731389) },
                        { "Rapid City", new Coordinates(44.080543, -103.231015) },
                        { "Aberdeen", new Coordinates(45.464664, -98.486392) }
                    }),
                StateAbrv.TN => new State(
                "Tennessee", new Coordinates(36.165810, -86.784241), new Dictionary<string, Coordinates>
                {
                    { "Memphis", new Coordinates(35.149532, -90.048981) },
                    { "Nashville", new Coordinates(36.165810, -86.784241) },
                    { "Knoxville", new Coordinates(35.960638, -83.920739) }
                }),
                StateAbrv.TX => new State(
                    "Texas", new Coordinates(30.274670, -97.740349), new Dictionary<string, Coordinates>
                    {
                { "Houston", new Coordinates(29.760427, -95.369804) },
                { "San Antonio", new Coordinates(29.424122, -98.493628) },
                { "Dallas", new Coordinates(32.776665, -96.796988) }
                    }),
                StateAbrv.UT => new State(
                    "Utah", new Coordinates(40.777477, -111.888237), new Dictionary<string, Coordinates>
                    {
                { "Salt Lake City", new Coordinates(40.777477, -111.888237) },
                { "West Valley City", new Coordinates(40.691613, -112.001050) },
                { "Provo", new Coordinates(40.233844, -111.658534) }
                    }),
                StateAbrv.VT => new State(
                    "Vermont", new Coordinates(44.262436, -72.580536), new Dictionary<string, Coordinates>
                    {
                { "Burlington", new Coordinates(44.475882, -73.212072) },
                { "South Burlington", new Coordinates(44.466994, -73.170960) },
                { "Rutland", new Coordinates(43.610623, -72.972606) }
                    }),
                StateAbrv.VA => new State(
                    "Virginia", new Coordinates(37.538857, -77.433640), new Dictionary<string, Coordinates>
                    {
                { "Virginia Beach", new Coordinates(36.852926, -75.977985) },
                { "Norfolk", new Coordinates(36.850769, -76.285873) },
                { "Chesapeake", new Coordinates(36.768208, -76.287492) }
                    }),
                StateAbrv.WA => new State(
                    "Washington", new Coordinates(47.037872, -122.900696), new Dictionary<string, Coordinates>
                    {
                { "Seattle", new Coordinates(47.606209, -122.332069) },
                { "Spokane", new Coordinates(47.658780, -117.426046) },
                { "Tacoma", new Coordinates(47.252877, -122.444291) }
                    }),
                StateAbrv.WV => new State(
                    "West Virginia", new Coordinates(38.336246, -81.612328), new Dictionary<string, Coordinates>
                    {
                { "Charleston", new Coordinates(38.349820, -81.632623) },
                { "Huntington", new Coordinates(38.419250, -82.445154) },
                { "Parkersburg", new Coordinates(39.266741, -81.561513) }
                    }),
                StateAbrv.WI => new State(
                    "Wisconsin", new Coordinates(43.074684, -89.384445), new Dictionary<string, Coordinates>
                    {
                { "Milwaukee", new Coordinates(43.038902, -87.906471) },
                { "Madison", new Coordinates(43.073051, -89.401230) },
                { "Green Bay", new Coordinates(44.513319, -88.013296) }
                    }),
                StateAbrv.WY => new State(
                    "Wyoming", new Coordinates(41.140259, -104.820236), new Dictionary<string, Coordinates>
                    {
                { "Cheyenne", new Coordinates(41.139981, -104.820246) },
                { "Casper", new Coordinates(42.866632, -106.313081) },
                { "Laramie", new Coordinates(41.311367, -105.591101) }
                    }),
                _ => throw new ArgumentException("Invalid state code")
            };
        }


        public State(string name, Coordinates capital, Dictionary<string, Coordinates> majorCities)
        {
            Name = name;
            Capital = capital;
            MajorCities = majorCities;
        }

        public static implicit operator Coordinates(State v)
        {
            return v.Capital;
        }
    }
}
