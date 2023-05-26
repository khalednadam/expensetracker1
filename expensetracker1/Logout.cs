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
    public partial class Logout : KryptonForm
    {
        private MySqlConnection connection;
        private const string connectionString = "server=localhost;database=tracker;user=root;password=";
        public int id;
        public Logout(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Logout_Load(object sender, EventArgs e)
        {
            string getUserInfo = "SELECT name FROM users WHERE id = @id";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(getUserInfo, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    connection.Open();

                    string name = Convert.ToString(command.ExecuteScalar());
                    label1.Text = name;
                    Console.WriteLine(name);
                }
            }
        }

        private void clickLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LandForm landForm = new LandForm();
            landForm.Show();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardForm dashboardForm = new DashboardForm(id);
            dashboardForm.Show();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Addincome addincome = new Addincome(id);
            addincome.Show();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Addexpense addexpense = new Addexpense(id);   
            addexpense.Show();
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Totalspendingmain totalspending   = new Totalspendingmain(id);
            totalspending.Show();
        }

        private void kryptonButton6_Click(object sender, EventArgs e)
        {
           this.Hide();
           prefrencesForm prefrencesForm = new prefrencesForm(id);
           prefrencesForm.Show();
        }

        private void kryptonButton7_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutUsForm aboutForm = new AboutUsForm(id);
            aboutForm.Show();
        }

        private void kryptonButton8_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardForm dashboardForm = new DashboardForm(id);
            dashboardForm.Show();
        }

        private void Logout_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
