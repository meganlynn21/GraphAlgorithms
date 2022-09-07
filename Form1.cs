using NPOI.POIFS.Crypt.Dsig;
using System;
using System.Windows.Forms;


namespace GraphAlgorithms
{
    public partial class Form1 : Form
    {
        Flight flight = new Flight();

        // Getting values of textboxes so I can use in Graph class
        public string ToTxtBox
        {
            get { return toTxtBox.Text; }
        }
        public string FromTxtBox
        {
            get { return fromTxtBox.Text; }
        }
        // Getting ListBox value
        public string ListBox
        {
            get { return lst.Text; }
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
            ListBox lst = new ListBox();
            lst.Items.Clear();
            var apiData = flight.GetApiData();

            foreach (var item in apiData)
            {
                this.lst.Items.Add($"{item.City1} to {item.City2}: ${item.Fare}");
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            lst.Items.Clear();
            var toTxt = toTxtBox.Text;
            var fromTxt = fromTxtBox.Text;

            var apiData = flight.GetApiData();

            foreach (Flight flight in apiData)
            {
                if (flight.City1.Contains(fromTxt) && flight.City2.Contains(toTxt))
                {
                    lst.Items.Clear();
                    lst.Items.Add($"{flight.City1} to {flight.City2}: ${flight.Fare}");
                }
            }
        }

        private void connectingFlightsBtn_Click(object sender, EventArgs e)
        {
            lst.Items.Clear();
            Graph graph = new Graph();
            var data = graph.GetConnectingFlights(FromTxtBox, ToTxtBox);
            foreach (var item in data)
            {
                lst.Items.Add($"{item.City1} to {item.City2} ${item.Fare}");
            }
        }
    }
}


