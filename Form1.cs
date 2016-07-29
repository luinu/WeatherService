using System;
using System.Data;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Windows.Forms;
using System.Xml.Serialization;
using WeatherApp.ServiceReference;
using System.Diagnostics;

namespace WeatherApp
{
    public partial class FormWeather : Form
    {
        internal Cities.NewDataSet cn;
        public FormWeather()
        {
            InitializeComponent();
            // Binding app to web service
            BasicHttpBinding binding = new BasicHttpBinding();
            binding.MaxReceivedMessageSize = 2000000;

            EndpointAddress address = new EndpointAddress("http://www.webservicex.net/globalweather.asmx");

            GlobalWeatherSoapClient gwsc = new GlobalWeatherSoapClient(binding, address);
            var cities = gwsc.GetCitiesByCountry("");

            XmlSerializer result = new XmlSerializer(typeof(Cities.NewDataSet));

            cn = (Cities.NewDataSet)result.Deserialize(new StringReader(cities));

            var countries = cn.Table.Select(c => c.Country).Distinct().ToList();
            countries.Sort();
            comboBoxCountry.Items.AddRange(countries.ToArray());
        }

        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            var citiesInCountry = cn.Table.Where(k => k.Country == comboBoxCountry.Text).Select(c => c.City).ToList();
            citiesInCountry.Sort();
            comboBoxCity.Items.Clear();
            comboBoxCity.Items.AddRange(citiesInCountry.ToArray());
        }

        private void comboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            BasicHttpBinding binding = new BasicHttpBinding();

            EndpointAddress address = new EndpointAddress("http://www.webservicex.net/globalweather.asmx");
            GlobalWeatherSoapClient gwsc = new GlobalWeatherSoapClient(binding, address);

            var weather = gwsc.GetWeather(comboBoxCity.Text, comboBoxCountry.Text);
            if(weather != "Data Not Found")
            {
                richTextBoxWeather.Clear();
                XmlSerializer result = new XmlSerializer(typeof(Weather.CurrentWeather));
                var w = (Weather.CurrentWeather)result.Deserialize(new StringReader(weather));
                string s = "";
                    richTextBoxWeather.Text += "Location: " + w.Location + "\r\n" +
                    "Pressure: " + w.Pressure + "\r\n" +
                    "Relative Humidity: " + w.RelativeHumidity + "\r\n" +
                    "Sky Conditions: " + (s = w.SkyConditions != null ? w.SkyConditions : "data not found") + "\r\n" +
                    "Status: " + w.Status + "\r\n" +
                    "Temperature: " + w.Temperature + "\r\n" +
                    "Visibility: " + w.Visibility + "\r\n" +
                    "Wind: " + w.Wind + "\r\n" +
                    "Time: " + w.Time + "\r\n";
                
            }
            else
            {
                richTextBoxWeather.Clear();
                richTextBoxWeather.Text = "Data Not Found";
            }
        }

        private void linkLabelCountry_Click(object sender, EventArgs e)
        {
            string s = "https://www.google.pl/?gws_rd=ssl#q=" + comboBoxCountry.Text;
            Process.Start(s);
        }

        private void linkLabelCity_Click(object sender, EventArgs e)
        {
            string s = "https://www.google.pl/?gws_rd=ssl#q=" + comboBoxCity.Text;
            Process.Start(s);
        }
    }
}
