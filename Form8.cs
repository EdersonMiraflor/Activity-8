using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace MySystem
{
    public partial class Form8 : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                txtOutput.Clear();
                HttpResponseMessage response = await client.GetAsync("http://127.0.0.1/myapi/phpapi/api1.php");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                txtOutput.Text = responseBody;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnPost_Click(object sender, EventArgs e)
        {
            var userData = new {
                event_name = txtName.Text,
                event_date = txtDate.Text,
                event_description = txtDesc.Text,
                barangay_id = txtId.Text
            };
            string json = JsonConvert.SerializeObject(userData);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await client.PostAsync("http://127.0.0.1/myapi/phpapi/api1.php", content);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                txtOutput.Text = responseBody;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtOutput2_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnGet2_Click(object sender, EventArgs e)
        {
            try
            {
                txtOutput.Clear();
                HttpResponseMessage response = await client.GetAsync("http://127.0.0.1/myapi/phpapi/api2.php");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                txtOutput2.Text = responseBody;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async void btnPost2_Click(object sender, EventArgs e)
        {
            // Validate project_budget
            if (decimal.TryParse(txtBudget2.Text, out decimal projectBudget))
            {
                // If parsing is successful, proceed with sending the data
                var userData = new
                {
                    project_name = txtName2.Text,
                    project_description = txtDesc2.Text,
                    project_budget = projectBudget,
                    start_date = txtStart2.Text,
                    end_date = txtEnd2.Text,
                    proj_status = txtStat2.Text,
                    barangay_id = txtId2.Text
                };
                string json = JsonConvert.SerializeObject(userData);
                HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

                try
                {
                    HttpResponseMessage response = await client.PostAsync("http://127.0.0.1/myapi/phpapi/api2.php", content);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    txtOutput2.Text = responseBody;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                // If parsing fails, show an error message
                MessageBox.Show("Project budget must be a valid decimal value. or You must fill all the fields");
            }
        }


        private void txtBudget2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myform = new Form4();
            myform.Show();
        }
    }
}
