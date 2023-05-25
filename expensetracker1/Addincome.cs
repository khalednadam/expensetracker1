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
using System.Globalization;
using MySql.Data.MySqlClient;
namespace expensetracker1
{

    public partial class Addincome : KryptonForm
    {
        private MySqlConnection connection;
        private const string connectionString = "server=localhost;database=tracker;user=root;password=";
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
                string date = dateAddincome.Value.ToString();
                int userid = id;
                if(amount != 0)
                {
                    string Query = "insert into income(amount, description, date, userId) " +
                "values ( '" + amount + "','" + description + "', '" + date + "', '"+ id + "' )";
                    MySqlConnection MyConn2 = new MySqlConnection(connectionString);
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("Income added successfully.");
                }

            }catch(Exception err)
            {
                MessageBox.Show( "" + err);
            }
            
        }

        private void btnAddexpence_Click(object sender, EventArgs e)
        {
            this.Hide();
            Addexpense addexpense = new Addexpense();
            addexpense.Show();
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
    }
}
