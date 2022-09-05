using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GraphAlgorithms
{
    public partial class Form1 : Form
    {
        Flight flight = new Flight();

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
            //(int i = 0; i < students.Count; i++)
            {
                if (flight.City1.Contains(fromTxt) && flight.City2.Contains(toTxt))
                {
                    lstBox.Items.Clear();
                    lstBox.Items.Add($"{flight.City1} to {flight.City2}: ${flight.Fare}");
                }
            }

        }
    }
}

