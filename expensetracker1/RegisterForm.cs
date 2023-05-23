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
    public partial class RegisterForm : KryptonForm
    {
        private MySqlConnection connection;
        private const string connectionString = "server=localhost;database=tracker;user=root;password=";

        public RegisterForm()
        {
            InitializeComponent();

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            // Establish the connection to MySQL
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

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
            string name = txtName.Text.ToString();
            string email = txtEmail.Text.ToString();
            string password = txtPassword.Text.ToString();
            string phoneNumber = txtNumber.Text.ToString();
            int spendingIds = 0;
            int incomeIds = 0;
            float yearlyGoal = 0;
            string currency = "SD";
            string Query = "insert into users(email, password, phoneNumber, name, spendingIds, incomeIds, yearlyGoal, currency) " +
                "values ( '" + email + "','" + password + "', '" + phoneNumber + "',  '" + name + "', '" + spendingIds +"','" + incomeIds + "',  '" + yearlyGoal +"', '" +currency+ "')";
            
                MySqlConnection MyConn2 = new MySqlConnection(connectionString);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                MessageBox.Show("Save Data");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
