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
    public partial class prefrencesForm : KryptonForm

    {
        private MySqlConnection connection;
        private const string connectionString = "server=sql7.freemysqlhosting.net;database=sql7621530;user=sql7621530;password=j9svHz1IY1";
        public int id;
        public string userName, userEmail, userPhone, userPassword;
        public prefrencesForm(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void prefrencs_Load(object sender, EventArgs e)
        {
            string getUsername = "SELECT name FROM users WHERE id = @id";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(getUsername, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    connection.Open();

                    string name = Convert.ToString(command.ExecuteScalar());
                    label1.Text = name;
                    Console.WriteLine(name);
                }
            }


            string getUserInfo = "SELECT * FROM users WHERE id = @id";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(getUserInfo, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    connection.Open();
                    string name = Convert.ToString(command.ExecuteScalar());
                    
                    Console.WriteLine(name);
                

                MySqlDataReader userReader = command.ExecuteReader();

                    while (userReader.Read())
                    {
                         userName = (string)userReader["name"];
                         userEmail = (string)userReader["email"];
                         userPhone = (string)userReader["phoneNumber"];
                         userPassword = (string)userReader["password"];
                    }

                    if (txtamount.Text.ToString() != "")
                    {

                        string Query = "UPDATE users SET name = @newName WHERE id = @id  ";
                        command.Parameters.AddWithValue("@newName", txtamount.Text);
                        Console.WriteLine(txtamount.Text);
                        command.Parameters.AddWithValue("@id", id);
                        MySqlConnection MyConn2 = new MySqlConnection(connectionString);
                        MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                        MySqlDataReader MyReader2;



                        MyConn2.Open();
                        MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.


                        while (MyReader2.Read())
                        {
                        }
                        MyConn2.Close();
                    }

                    if (kryptonTextBox1.Text.ToString() != "")
                    {
                        string Query = "UPDATE users SET email = @newEmail WHERE id = @id  ";

                        MySqlConnection MyConn2 = new MySqlConnection(connectionString);
                        MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                        MySqlDataReader MyReader2;

                        command.Parameters.AddWithValue("@newEmail", kryptonTextBox1.Text.ToString());
                        MyConn2.Open();
                        MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.


                        while (MyReader2.Read())
                        {
                        }
                        MyConn2.Close();
                    }

                    if (kryptonTextBox2.Text.ToString() != "")
                    {
                        string Query = "UPDATE users SET phoneNumber = @newPhoneNumber WHERE id = @id  ";

                        MySqlConnection MyConn2 = new MySqlConnection(connectionString);
                        MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                        MySqlDataReader MyReader2;

                        command.Parameters.AddWithValue("@newPhoneNumber", kryptonTextBox2.Text.ToString());
                        MyConn2.Open();
                        MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.


                        while (MyReader2.Read())
                        {
                        }
                        MyConn2.Close();
                    }

                    if (kryptonTextBox3.Text.ToString() != "")
                    {
                        string Query = "UPDATE users SET password = @newPassword WHERE id = @id  ";

                        MySqlConnection MyConn2 = new MySqlConnection(connectionString);
                        MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                        MySqlDataReader MyReader2;

                        command.Parameters.AddWithValue("@newPassword", kryptonTextBox3.Text.ToString());
                        MyConn2.Open();
                        MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.


                        while (MyReader2.Read())
                        {
                        }
                        MyConn2.Close();

                    }

                }
            }

        }

        private void btnPrefrences_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
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
            this.Hide();
            Totalspendingmain totalspending = new Totalspendingmain(id);
            totalspending.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardForm dashboardForm = new DashboardForm(id);
            dashboardForm.Show();
        }

        private void prefrencesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtamount.Text.ToString();
                string email = kryptonTextBox1.Text.ToString();
                string password = kryptonTextBox2.Text.ToString();
                string phoneNumber = kryptonTextBox2.Text.ToString();
                
                
                if (name != "")
                {

                    string Query = "UPDATE users SET name = '" + name + "' WHERE id = '" + id + "'";
                        //"values ( '" + email + "','" + password + "', '" + phoneNumber + "',  '" + name + "', '" + spendingIds + "','" + incomeIds + "')";

                    MySqlConnection MyConn2 = new MySqlConnection(connectionString);
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                   
                    while (MyReader2.Read())
                    {
                    }
                    MyConn2.Close();
                }

                if (email != "")
                {

                    string Query = "UPDATE users SET email = '" + email + "' WHERE id = '" + id + "'";
                    //"values ( '" + email + "','" + password + "', '" + phoneNumber + "',  '" + name + "', '" + spendingIds + "','" + incomeIds + "')";

                    MySqlConnection MyConn2 = new MySqlConnection(connectionString);
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.

                    while (MyReader2.Read())
                    {
                    }
                    MyConn2.Close();
                }

                if (phoneNumber != "")
                {

                    string Query = "UPDATE users SET phoneNumber = '" + phoneNumber + "' WHERE id = '" + id + "'";
                    //"values ( '" + email + "','" + password + "', '" + phoneNumber + "',  '" + name + "', '" + spendingIds + "','" + incomeIds + "')";

                    MySqlConnection MyConn2 = new MySqlConnection(connectionString);
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.

                    while (MyReader2.Read())
                    {
                    }
                    MyConn2.Close();
                }

                if (password != "")
                {

                    string Query = "UPDATE users SET password = '" + password + "' WHERE id = '" + id + "'";
                    //"values ( '" + email + "','" + password + "', '" + phoneNumber + "',  '" + name + "', '" + spendingIds + "','" + incomeIds + "')";

                    MySqlConnection MyConn2 = new MySqlConnection(connectionString);
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.

                    while (MyReader2.Read())
                    {
                    }
                    MyConn2.Close();
                }
                MessageBox.Show("Edited successfully");
                this.Hide();
                DashboardForm dashboardForm = new DashboardForm(id);
                dashboardForm.Show();

            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }
    }
}
