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
    public partial class LoginForm : KryptonForm
    {
        private MySqlConnection connection;
        private const string connectionString = "server=sql7.freemysqlhosting.net;database=sql7621530;user=sql7621530;password=j9svHz1IY1";
        string id, email, phoneNumber, yearlyGoal, spendingIds, incomeIds, name, currency, password;


        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection(connectionString);
            connection.Open();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.ToString();
            string password = txtPassword.Text.ToString();

            string sql = "SELECT id FROM users WHERE email = @email AND password = @password";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@password", password);

                    connection.Open();
                    
                    int id = Convert.ToInt32(command.ExecuteScalar());
                     
                    if (id != 0)
                    {
                        //MessageBox.Show("Login successful!");
                        // Perform actions after successful login
                        // TODO: Implement going to next step which is dahsboard
                        this.Hide();
                        DashboardForm dashboardForm = new DashboardForm(id);
                        dashboardForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password. Please try again.");
                    }
                }
            }



            }
    }
}
