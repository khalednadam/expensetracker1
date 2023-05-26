﻿using System;
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
        public int id;
        public DashboardForm(int id)
        {
            InitializeComponent();
            this.id = id;
            label1.Text = "";
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
            this.Hide();
            prefrencesForm preferences = new prefrencesForm(id);
            preferences.Show();



        }

        private void btnDashboard_Load(object sender, EventArgs e)
        {
            
            List<float> totalSpendings = new List<float>();
            List<string> categoriesOfSpendings = new List<string>();
            float totalIncome = 0;
            float totalSpending = 0;
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
            string spendingSql = "SELECT amount, date, name, category FROM spending WHERE userId = @id order by date DESC";
            string incomeSql = "SELECT amount, date, description FROM income WHERE userId = @id";
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
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(incomeSql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    connection.Open();

                    MySqlDataReader incomeReader = command.ExecuteReader();
                    
                    while (incomeReader.Read())
                    {
                        float income = (float)incomeReader["amount"];
                        Console.WriteLine((float)income);
                        totalIncome += income;
                    }
                }
            }
            
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(spendingSql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    connection.Open();

                    MySqlDataReader spendingReader = command.ExecuteReader();
                   
                    while (spendingReader.Read())
                    {
                        float spending = (float)spendingReader["amount"];
                        string category = (string)spendingReader["category"];
                        Console.WriteLine((float) spending);
                        totalSpendings.Add(spending);
                        categoriesOfSpendings.Add(category);
                        totalSpending += spending;
                    }
                    float balance = totalIncome - totalSpending;
                    lblSpendings.Text = balance.ToString() + " $";
                }
            }
            
            Console.WriteLine("---------");
            int handleSize;
            if(totalSpendings.Count < 5)
            {
                handleSize = totalSpendings.Count;
            }
            else
            {
                handleSize = 5;
            }
            if(handleSize == 0)
            {
                lblSpended1.Text = "";
                lblSpended2.Text = "";
                lblSpended3.Text = "";
                lblSpended4.Text = "";
                lblSpended5.Text = "";
            }else if(handleSize == 1)
            {
                lblSpended1.Text = totalSpendings[0].ToString() + " - " + categoriesOfSpendings[0];
                lblSpended2.Text = "";
                lblSpended3.Text = "";
                lblSpended4.Text = "";
                lblSpended5.Text = "";
            }else if(handleSize == 2)
            {
                lblSpended1.Text = totalSpendings[0].ToString() + " - " + categoriesOfSpendings[0];
                lblSpended2.Text = totalSpendings[1].ToString() + " - " + categoriesOfSpendings[1];
                lblSpended3.Text = "";
                lblSpended4.Text = "";
                lblSpended5.Text = "";
            }else if(handleSize == 3)
            {
                lblSpended1.Text = totalSpendings[0].ToString() + " - " + categoriesOfSpendings[0];
                lblSpended2.Text = totalSpendings[1].ToString() + " - " + categoriesOfSpendings[1];
                lblSpended3.Text = totalSpendings[2].ToString() + " - " + categoriesOfSpendings[2];
                lblSpended4.Text = "";
                lblSpended5.Text = "";
            }else if(handleSize == 4)
            {
                lblSpended1.Text = totalSpendings[0].ToString() + " - " + categoriesOfSpendings[0];
                lblSpended2.Text = totalSpendings[1].ToString() + " - " + categoriesOfSpendings[1];
                lblSpended3.Text = totalSpendings[2].ToString() + " - " + categoriesOfSpendings[2];
                lblSpended4.Text = totalSpendings[3].ToString() + " - " + categoriesOfSpendings[3];
                lblSpended5.Text = "";
            }else if(handleSize == 5)
            {
                lblSpended1.Text = totalSpendings[0].ToString() + " - " + categoriesOfSpendings[0];
                lblSpended2.Text = totalSpendings[1].ToString() + " - " + categoriesOfSpendings[1];
                lblSpended3.Text = totalSpendings[2].ToString() + " - " + categoriesOfSpendings[2];
                lblSpended4.Text = totalSpendings[3].ToString() + " - " + categoriesOfSpendings[3];
                lblSpended5.Text = totalSpendings[4].ToString() + " - " + categoriesOfSpendings[4];
            }
            float div = (totalSpending) / (totalIncome);
            float spendingPrecentage = (float) (div * 100.0);
            Console.WriteLine(spendingPrecentage);
            if(spendingPrecentage >= 0.0 && spendingPrecentage <= 49.0)
            {
                lblSpendings.ForeColor = Color.FromArgb(68, 139, 0);
            }else if(spendingPrecentage >= 50.0 && spendingPrecentage <= 75.0)
            {
                lblSpendings.ForeColor = Color.FromArgb(255, 210, 0);
            }
            else
            {
                lblSpendings.ForeColor = Color.FromArgb(230, 24, 24);
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

        private void btnTotalspending_Click(object sender, EventArgs e)
        {
            this.Hide();
            Totalspendingmain totalspending = new Totalspendingmain(id);
            totalspending.Show();
        }

        private void btnAboutus_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutUsForm aboutusform = new AboutUsForm(id);
            aboutusform.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Logout logout = new Logout(id);
            logout.Show();
        }

        private void btnExpence_Click(object sender, EventArgs e)
        {
            this.Hide();
            Addexpense addexpense = new Addexpense(id);
            addexpense.Show();


        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Addincome addincome = new Addincome(id);
            addincome.Show();
        }
    }
}
