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
    public partial class AboutUsForm : KryptonForm
    {
        private MySqlConnection connection;
        private const string connectionString = "server=sql7.freemysqlhosting.net;database=sql7621530;user=sql7621530;password=j9svHz1IY1";
        public int id;
        public AboutUsForm(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void AboutUs_Load(object sender, EventArgs e)
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

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardForm dashboardForm = new DashboardForm(id);
            dashboardForm.Show();
        }

        private void btnAboutus_Click(object sender, EventArgs e)
        {

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
            this.Hide();
            Totalspendingmain totalspending = new Totalspendingmain(id);
            totalspending.Show();

        }

        private void btnPrefrences_Click(object sender, EventArgs e)
        {
            this.Hide();
            prefrencesForm prefrencesForm = new prefrencesForm(id);
            prefrencesForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Logout logout = new Logout(id);
            logout.Show();

        }

        private void AboutUsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
