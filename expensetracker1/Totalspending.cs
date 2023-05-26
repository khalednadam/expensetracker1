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
            string clothingSql = "SELECT amount FROM spending WHERE category = @category AND userId = @id";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(clothingSql, connection))
                {
                    command.Parameters.AddWithValue("@category", "Clothing");
                    command.Parameters.AddWithValue("@id", id);
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
            // For food
            float totalFood = 0;
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
            string foodSql = "SELECT amount FROM spending WHERE category = @category AND userId = @id";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(foodSql, connection))
                {
                    command.Parameters.AddWithValue("@category", "Food & Restaurants");
                    command.Parameters.AddWithValue("@id", id);
                    connection.Open();

                    MySqlDataReader foodReader = command.ExecuteReader();

                    while (foodReader.Read())
                    {
                        float food = (float)foodReader["amount"];
                        Console.WriteLine((float)food);
                        totalFood += food;
                    }

                    label10.Text = totalFood.ToString() + " $";
                }
            }
            // For travel
            float totalTravel = 0;
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
            string TravelSql = "SELECT amount FROM spending WHERE category = @category AND userId = @id";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(TravelSql, connection))
                {
                    command.Parameters.AddWithValue("@category", "Travel");
                    command.Parameters.AddWithValue("@id", id);
                    connection.Open();

                    MySqlDataReader TravelReader = command.ExecuteReader();

                    while (TravelReader.Read())
                    {
                        float travel = (float)TravelReader["amount"];
                        Console.WriteLine((float)travel);
                        totalTravel += travel;
                    }

                    label37.Text = totalTravel.ToString() + " $";
                }
            }
            // For Entertainment
            float totalEntertainment = 0;
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
            string EntertainmentSql = "SELECT amount FROM spending WHERE category = @category AND userId = @id";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(EntertainmentSql, connection))
                {
                    command.Parameters.AddWithValue("@category", "Entertainment");
                    command.Parameters.AddWithValue("@id", id);
                    connection.Open();

                    MySqlDataReader EntertainmentReader = command.ExecuteReader();

                    while (EntertainmentReader.Read())
                    {
                        float Entertainment = (float)EntertainmentReader["amount"];
                        Console.WriteLine((float)Entertainment);
                        totalEntertainment += Entertainment;
                    }

                    label19.Text = totalEntertainment.ToString() + " $";
                }
            }
            // For Groceries
            float totalGroceries = 0;
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
            string GroceriesSql = "SELECT amount FROM spending WHERE category = @category AND userId = @id";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(GroceriesSql, connection))
                {
                    command.Parameters.AddWithValue("@category", "Groceries");
                    command.Parameters.AddWithValue("@id", id);
                    connection.Open();

                    MySqlDataReader GroceriesReader = command.ExecuteReader();

                    while (GroceriesReader.Read())
                    {
                        float Groceries = (float)GroceriesReader["amount"];
                        Console.WriteLine((float)Groceries);
                        totalGroceries += Groceries;
                    }
                    label13.Text = totalGroceries.ToString() + " $";
                }
            }

            // For Utilities
            float totalUtilities = 0;
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
            string UtilitiesSql = "SELECT amount FROM spending WHERE category = @category AND userId = @id";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(UtilitiesSql, connection))
                {
                    command.Parameters.AddWithValue("@category", "Utilities");
                    command.Parameters.AddWithValue("@id", id);
                    connection.Open();

                    MySqlDataReader UtilitiesReader = command.ExecuteReader();

                    while (UtilitiesReader.Read())
                    {
                        float Utilities = (float)UtilitiesReader["amount"];
                        Console.WriteLine((float)Utilities);
                        totalUtilities += Utilities;
                    }
                    label25.Text = totalUtilities.ToString() + " $";
                }
            }
            // For 'Health and Wellness'
            float totalHealthandWellness = 0;
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
            string HealthandWellnessSql = "SELECT amount FROM spending WHERE category = @category AND userId = @id";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(HealthandWellnessSql, connection))
                {
                    command.Parameters.AddWithValue("@category", "Health and Wellness");
                    command.Parameters.AddWithValue("@id", id);
                    connection.Open();

                    MySqlDataReader HealthandWellnessReader = command.ExecuteReader();

                    while (HealthandWellnessReader.Read())
                    {
                        float HealthandWellness = (float)HealthandWellnessReader["amount"];
                        Console.WriteLine((float)HealthandWellness);
                        totalHealthandWellness += HealthandWellness;
                    }
                    label22.Text = totalHealthandWellness.ToString() + " $";
                }
            }
            // For Transportation
            float totalTransportation = 0;
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
            string TransportationSql = "SELECT amount FROM spending WHERE category = @category AND userId = @id";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(TransportationSql, connection))
                {
                    command.Parameters.AddWithValue("@category", "Transportation");
                    command.Parameters.AddWithValue("@id", id);
                    connection.Open();

                    MySqlDataReader TransportationReader = command.ExecuteReader();

                    while (TransportationReader.Read())
                    {
                        float Transportation = (float)TransportationReader["amount"];
                        Console.WriteLine((float)Transportation);
                        totalTransportation += Transportation;
                    }

                    label28.Text = totalTransportation.ToString() + " $";
                }
            }
            // For Personal Care
            float totalPersonalCare = 0;
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
            string PersonalCareSql = "SELECT amount FROM spending WHERE category = @category AND userId = @id";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(PersonalCareSql, connection))
                {
                    command.Parameters.AddWithValue("@category", "Personal Care");
                    command.Parameters.AddWithValue("@id", id);
                    connection.Open();

                    MySqlDataReader PersonalCareReader = command.ExecuteReader();

                    while (PersonalCareReader.Read())
                    {
                        float PersonalCare = (float)PersonalCareReader["amount"];
                        Console.WriteLine((float)PersonalCare);
                        totalPersonalCare += PersonalCare;
                    }
                    label40.Text = totalPersonalCare.ToString() + " $";
                }
            }
            // For Housing
            float totalHousing = 0;
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
            string HousingSql = "SELECT amount FROM spending WHERE category = @category AND userId = @id";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(HousingSql, connection))
                {
                    command.Parameters.AddWithValue("@category", "Housing");
                    command.Parameters.AddWithValue("@id", id);
                    connection.Open();

                    MySqlDataReader HousingReader = command.ExecuteReader();

                    while (HousingReader.Read())
                    {
                        float Housing = (float)HousingReader["amount"];
                        Console.WriteLine((float)Housing);
                        totalHousing += Housing;
                    }

                    label16.Text = totalEntertainment.ToString() + " $";
                }
            }
            // For Other
            float totalOther = 0;
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
            string OtherSql = "SELECT amount FROM spending WHERE category = @category AND userId = @id";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(OtherSql, connection))
                {
                    command.Parameters.AddWithValue("@category", "Other");
                    command.Parameters.AddWithValue("@id", id);
                    connection.Open();

                    MySqlDataReader OtherReader = command.ExecuteReader();

                    while (OtherReader.Read())
                    {
                        float Other = (float)OtherReader["amount"];
                        Console.WriteLine((float)Other);
                        totalOther += Other;
                    }
                    label34.Text = totalOther.ToString() + " $";
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

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Totalspending_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
