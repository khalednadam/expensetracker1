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
    public partial class Totalspending : KryptonForm
    {
        private MySqlConnection connection;
        private const string connectionString = "server=localhost;database=tracker;user=root;password=";
        public int id;
        public Totalspending(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Totalspending_Load(object sender, EventArgs e)
        {
            // For Clothing
            float totalClothing = 0;
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
            string clothingSql = "SELECT amount FROM spending WHERE category = @category";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(clothingSql, connection))
                {
                    command.Parameters.AddWithValue("@category", "Clothing");
                    connection.Open();

                    MySqlDataReader clothingReader = command.ExecuteReader();

                    while (clothingReader.Read())
                    {
                        float clothing = (float)clothingReader["amount"];
                        Console.WriteLine((float)clothing);
                        totalClothing += clothing;
                    }

                    label7.Text = totalClothing.ToString() + " $";
                }
            }


        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardForm dashboardForm = new DashboardForm(id);
            dashboardForm.Show();
        }

        private void btnAddincome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Addincome addincome = new Addincome(id);
            addincome.Show();
        }

        private void btnAddexpence_Click(object sender, EventArgs e)
        {
            this.Hide();
            Addexpense addexpense = new Addexpense(id);
            addexpense.Show();
        }

        private void btnTotalspendings_Click(object sender, EventArgs e)
        {

        }

        private void btnPrefrences_Click(object sender, EventArgs e)
        {
            this.Hide();
            prefrencesForm prefrencesForm = new prefrencesForm(id);
            prefrencesForm.Show();
        }

        private void btnAboutus_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutUsForm aboutUsForm = new AboutUsForm(id);
            aboutUsForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Logout logout = new Logout(id);
            logout.Show();
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            this.Hide();
            Totalspendingmain totalspendingmain = new Totalspendingmain(id);
            totalspendingmain.Show();
        }
    }
}
