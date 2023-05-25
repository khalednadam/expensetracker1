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
    public partial class Logout : KryptonForm
    {
        public Logout()
        {
            InitializeComponent();
        }

        private void Logout_Load(object sender, EventArgs e)
        {

        }

        private void clickLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            KryptonForm LoginForm = new KryptonForm();
            LoginForm.ShowDialog();
            this.Close();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardForm dashboardForm = new DashboardForm(1);
            dashboardForm.Show();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Addincome addincome = new Addincome(1);
            addincome.Show();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Addexpense addexpense = new Addexpense(1);   
            addexpense.Show();
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Totalspending totalspending   = new Totalspending();
            totalspending.Show();
        }

        private void kryptonButton6_Click(object sender, EventArgs e)
        {
           this.Hide();
           prefrencesForm prefrencesForm = new prefrencesForm();
           prefrencesForm.Show();
        }

        private void kryptonButton7_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutUsForm aboutForm = new AboutUsForm();
            aboutForm.Show();
        }

        private void kryptonButton8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Logout logout = new Logout();
            logout.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
