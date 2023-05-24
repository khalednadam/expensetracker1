using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using MySql.Data.MySqlClient;
namespace expensetracker1
{

    public partial class DashboardForm : KryptonForm
    {
        private MySqlConnection connection;
        private const string connectionString = "server=localhost;database=tracker;user=root;password=";
        public DashboardForm(string name)
        {
            InitializeComponent();
            label1.Text = name;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonLabel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonButton6_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection(connectionString);
            connection.Open();
            if (connection.State == ConnectionState.Open)
            {
                // Connection is open
                Console.WriteLine("Connection is open.");
            }
            else
            {
                // Connection is not open
                Console.WriteLine("Connection is not open.");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click_1(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
