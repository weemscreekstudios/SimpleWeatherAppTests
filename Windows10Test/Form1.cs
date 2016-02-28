using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows10Test
{
    public partial class Form1 : Form
    {
        String OpenWeatherURL = "http://openweathermap.org/city/2643743";


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //OpenWeatherURL = textBox1.Text;
            //Navigate(OpenWeatherURL);  //Navigates to the URL if the address is valid
            webBrowser11.Refresh();
            webBrowser12.Refresh();
            webBrowser13.Refresh();
            webBrowser21.Refresh();
            webBrowser22.Refresh();
            webBrowser23.Refresh();
        }

        // Navigates to the given URL if it is valid.
        private void Navigate(String address)
        {
            if (String.IsNullOrEmpty(address)) return;
            if (address.Equals("about:blank")) return;
            if (!address.StartsWith("http://") &&
                !address.StartsWith("https://"))
            {
                address = "http://" + address;
            }
            try
            {
                webBrowser11.Navigate(new Uri(address));
            }
            catch (System.UriFormatException)
            {
                return;
            }
        }

        private void webBrowser1_Navigated_1(object sender, WebBrowserNavigatedEventArgs e)
        {
            textBoxNavigatedURL.Text = webBrowser11.Url.ToString();  //set the text box to display the full returned URL
            //textBoxNavigatedURL.Text = "Test";
        }
    }
}
