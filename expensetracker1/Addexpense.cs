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
using System.Globalization;
namespace expensetracker1
{
    public partial class Addexpense : KryptonForm
    {
        DateTime dateTime;
        private MySqlConnection connection;
        private const string connectionString = "server=localhost;database=tracker;user=root;password=";
        public int id;
        public Addexpense(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Addexpense_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection(connectionString);
            connection.Open();
            MessageBox.Show("Connection is open.");
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                float amount = float.Parse(txtamount.Text.ToString(), CultureInfo.InvariantCulture.NumberFormat);
                string description = txtDiscription.Text.ToString();
                string date = dateexpense.Value.ToString("yyyy-MM-dd");
                string category = drpbtnCategory.SelectedItem.ToString();
                
                int userid = id;
                if (amount != 0)
                {
                    string Query = "insert into spending(amount, description, date, category, userId) " +
                "values ( '" + (float) amount + "','" + description + "', '" + date + "', '" + category + "',  '" + id + "' )";
                    MySqlConnection MyConn2 = new MySqlConnection(connectionString);
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("Expense added successfully.");
                    txtamount.Text = "";
                    txtDiscription.Text = "";
                    drpbtnCategory.Text = "";
                    drpbtnCategory.SelectedItem = "";
                   
                    // TODO: Fix category dropdown


                }

            }
            catch (Exception err)
            {
                MessageBox.Show("" + err);
            }
        }

        private void btnAddincome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Addincome addincome = new Addincome(1);
            addincome.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardForm dashboardForm = new DashboardForm(1);
            dashboardForm.Show();
        }

        private void btnTotalspendings_Click(object sender, EventArgs e)
        {
            this.Hide();
            Totalspending totalspending = new Totalspending();
            totalspending.Show();
        }

        private void btnPrefrences_Click(object sender, EventArgs e)
        {
            this.Hide();
            prefrencesForm prefrencesForm = new prefrencesForm();
            prefrencesForm.Show();
        }

        private void btnAboutus_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutUsForm aboutUsForm = new AboutUsForm();
            aboutUsForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Logout logout = new Logout();
            logout.Show();
        }

        private void dateexpense_ValueChanged(object sender, EventArgs e)
        {
            int year = dateexpense.Value.Year;
            int month = dateexpense.Value.Month;
            int day = dateexpense.Value.Day;
            DateTime dateTime1 = new DateTime(year, month, day);
            
        }
    }
}
