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
using System.Globalization;
using MySql.Data.MySqlClient;
namespace expensetracker1
{

    public partial class Addincome : KryptonForm
    {
        private MySqlConnection connection;
        private const string connectionString = "server=sql7.freemysqlhosting.net;database=sql7621530;user=sql7621530;password=j9svHz1IY1";
        public int id;
        public Addincome(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Addincome_Load(object sender, EventArgs e)
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                float amount = float.Parse(txtamount.Text.ToString(), CultureInfo.InvariantCulture.NumberFormat);
                Console.WriteLine((float)amount);
                string description = txtDiscription.Text.ToString();
                string date = dateAddincome.Value.ToString("yyyy-MM-dd");
                int userid = id;
                if(amount != 0)
                {
                    string Query = "insert into income(amount, description, date, userId) " +
                "values ( '" + (float) amount + "','" + description + "', '" + date + "', '"+ id + "' )";
                    MySqlConnection MyConn2 = new MySqlConnection(connectionString);
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("Income added successfully.");
                    txtamount.Text = "";
                    txtDiscription.Text = "";
                }

            }catch(Exception err)
            {
                MessageBox.Show( "" + err);
            }
            
        }

        private void btnAddexpence_Click(object sender, EventArgs e)
        {
            this.Hide();
            Addexpense addexpense = new Addexpense(id);
            addexpense.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardForm dashboardForm = new DashboardForm(id);
            dashboardForm.Show();
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

        private void dateAddincome_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Addincome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
