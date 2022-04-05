using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace facturacionApp.UI
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            this.SplashTimer.Start();
        }

        private async void SplashTimer_Tick(object sender, EventArgs e)
        {
            string myConnectionString = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString;

            await ExecuteFileFromRoot(myConnectionString, "practica_final_db.sql"); 

            SplashTimer.Stop();
            Hide();
            new DashboardForm().Show();
        }

        private async Task ExecuteFileFromRoot(string connectionString, string fileName)
        {
            string filePath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, fileName);

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string data = File.ReadAllText(filePath);

                conn.Open();

                using (MySqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = data;
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }
    }
}
