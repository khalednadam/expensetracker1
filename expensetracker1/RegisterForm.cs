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
namespace expensetracker1
{
    public partial class RegisterForm : KryptonForm
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

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
            string name = txtName.Text.ToString();
            string email = txtEmail.Text.ToString();
            string password = txtPassword.Text.ToString();
            string phoneNumber = txtNumber.Text.ToString();
            int spendingIds = 0;
            int incomeIds = 0;
            float yearlyGoal = 0;
            string currency = "SD";
            string myConnection = "datasource=localhost;port=3306;username=root";
            string Query = "insert into users(id, email, password, phoneNumber, name, spendingIds, incomeIds, yearlyGoad, currency) values ( '" + 1 + "', '" + email + "','" + password + "', '" + phoneNumber + "',  '" + name + "', '" + spendingIds +"','" + incomeIds + "', '"+ phoneNumber+ "',  '" + yearlyGoal +"', '" +currency+ "')";
    
        }
    }
}
