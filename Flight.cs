using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GraphAlgorithms
{
    public class Flight
    {

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("city1")]
        public string City1 { get; set; }

        [JsonProperty("city2")]
        public string City2 { get; set; }

        [JsonProperty("nsmiles")]
        public string Miles { get; set; }

        [JsonProperty("passengers")]
        public string Passengers { get; set; }

        [JsonProperty("fare")]
        public string Fare { get; set; }


        public List<Flight> GetApiData()
        {
            WebClient client = new WebClient();
            string url = "https://data.transportation.gov/resource/4f3n-jbg2.json?year=2021";
            string webPage = client.DownloadString(url);
            List<Flight> items = JsonConvert.DeserializeObject<List<Flight>>(webPage);
            return items;
        }
    }
}





