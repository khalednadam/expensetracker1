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
                string date = dateexpense.Value.ToString();
                string category = drpbtnCategory.Values.Text.ToString();
                
                int userid = id;
                if (amount != 0)
                {
                    string Query = "insert into spending(amount, description, date, category, userId) " +
                "values ( '" + amount + "','" + description + "', '" + date + "', '" + category + "',  '" + id + "' )";
                    MySqlConnection MyConn2 = new MySqlConnection(connectionString);
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("Expense added successfully.");
                    txtamount.Text = "";
                    txtDiscription.Text = "";
                    drpbtnCategory.Text = "";
                    // TODO: Fix category dropdown

                    
                }

            }
            catch (Exception err)
            {
                MessageBox.Show("" + err);
            }
        }
    }
}
