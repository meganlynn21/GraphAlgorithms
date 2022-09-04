using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Text.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using Microsoft.Xrm.Sdk.Messages;

namespace GraphAlgorithms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void AllFlightsBtn_Click(object sender, EventArgs e)
        {
            //WebClient client = new WebClient(); 
            //string url = "https://data.transportation.gov/resource/4f3n-jbg2.json?year=2021";
            //string webPage = client.DownloadString(url);
            ////webPage.Replace("[", "").Replace("]", "");
            //var deserialize = (JArray)JsonConvert.DeserializeObject(webPage, typeof(JArray));

            //foreach (JObject obj in deserialize)
            //{
            //    lstBox.Items.Add("" + obj);
            //}
            Flight flight = new Flight();
            flight.GetApiData();
        }

    }
}

