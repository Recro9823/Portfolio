using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json;
using Connector;

namespace WeatherAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            getData();
        }
        EmpConnection.Rootobject result;


        private void getData()
        {
            //original https://api.open-meteo.com/v1/forecast?latitude=50.2584&longitude=19.0275&hourly=temperature_2m,precipitation,rain,showers,snowfall,snow_depth&timezone=Europe%2
            var client = new RestClient("https://api.open-meteo.com/v1/");
            var request = new RestRequest("forecast?latitude=50.2584&longitude=19.0275&hourly=temperature_2m,precipitation,rain,showers,snowfall,snow_depth&timezone=Europe%2FBerlin&forecast_days=3");
            var response = client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string rawResponse = response.Content;

                result = JsonConvert.DeserializeObject<EmpConnection.Rootobject>(rawResponse);

                if (result != null)
                {
                    int index = 0;
                    foreach (var obj in result.hourly.time)
                    {

                        listbox.Items.Add(obj + "\t" + result.hourly.temperature_2m[index]);
                        dataGridTable.Rows.Add(obj, result.hourly.temperature_2m[index]);

                        index++;
                    }



                    for (int i = 0; i < result.hourly.time.Length; i++)
                    {
                        if (result.hourly.temperature_2m[i] < 4)
                        {
                            textBoxResult.Text += $"Temperature is below 4 degrees Celsius! {result.hourly.time[i]}";
                            temperatureAlarm.BackColor = Color.Red;
                            i = result.hourly.time.Length; // Exit the loop after finding the first instance
                        }



                    }
                }
            }
        }
        private void listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            getData();
            TimerBoc.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
