using Newtonsoft.Json.Linq;
using NPOI.POIFS.Crypt.Dsig;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GraphAlgorithms
{
    public partial class Form1 : Form
    {
        Flight flight = new Flight();
        Form frm = new Form();
        // Getting values of textboxes so I can use in Graph class
        public string ToTxtBox
        {
            get { return toTxtBox.Text; }
        }
        public string FromTxtBox
        {
            get { return fromTxtBox.Text; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void lstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void AllFlightsBtn_Click(object sender, EventArgs e)
        {
            var apiData = flight.GetApiData();

            foreach (var item in apiData)
            {
                lstBox.Items.Add($"{item.City1} to {item.City2}: ${item.Fare}");
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            var toTxt = toTxtBox.Text;
            var fromTxt = fromTxtBox.Text;

            var apiData = flight.GetApiData();

            foreach (Flight flight in apiData)
            {
                if (flight.City1.Contains(fromTxt) && flight.City2.Contains(toTxt))
                {
                    lstBox.Items.Clear();
                    lstBox.Items.Add($"{flight.City1} to {flight.City2}: ${flight.Fare}");
                }
            }

        }

        private void connectingFlightsBtn_Click(object sender, EventArgs e)
        {
            Graph graph = new Graph();
            var data = graph.GetConnectingFlights(FromTxtBox,ToTxtBox);
            lstBox.Items.Add(data);
            foreach (var item in data)
            {
                lstBox.Items.Add($"{item}");

            }
            
        }
    }
}

