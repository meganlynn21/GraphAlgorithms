using System;
using System.Drawing;
using System.Windows.Forms;


namespace GraphAlgorithms
{
    public partial class Form1 : Form
    {
        Flight flight = new Flight();
        Form frm = new Form();
        public bool HorizontalScrollbar { get; set; }
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

        private void hScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            // Make sure no items are displayed partially.
            lst.IntegralHeight = true;

            // Add items that are wide to the ListBox.
            for (int x = 0; x < 10; x++)
            {
                lst.Items.Add("Item  " + x.ToString() + " is a very large value that requires scroll bars");
            }

            // Display a horizontal scroll bar.
            lst.HorizontalScrollbar = true;

            // Create a Graphics object to use when determining the size of the largest item in the ListBox.
            Graphics g = lst.CreateGraphics();

            // Determine the size for HorizontalExtent using the MeasureString method using the last item in the list.
            int hzSize = (int)g.MeasureString(lst.Items[lst.Items.Count - 1].ToString(), lst.Font).Width;
            // Set the HorizontalExtent property.
            lst.HorizontalExtent = hzSize;
        }
    }
}


