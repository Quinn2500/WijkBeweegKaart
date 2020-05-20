using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace DataModels
{
    public class Location
    {
        public Location(double latitude, double longitude, int zoomLevel)
        {
            Latitude = latitude;
            Longitude = longitude;
            ZoomLevel = zoomLevel;
        }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("zoomlevel")]
        public int ZoomLevel { get; set; }
    }
}
