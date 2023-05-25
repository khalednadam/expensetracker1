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
    public partial class Totalspending : KryptonForm
    {
        public Totalspending()
        {
            InitializeComponent();
        }

        private void Totalspending_Load(object sender, EventArgs e)
        {

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
            DashboardForm dashboardForm = new DashboardForm(1);
            dashboardForm.Show();
        }

        private void btnAddincome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Addincome addincome = new Addincome(1);
            addincome.Show();
        }

        private void btnAddexpence_Click(object sender, EventArgs e)
        {
            this.Hide();
            Addexpense addexpense = new Addexpense(1);
            addexpense.Show();
        }

        private void btnTotalspendings_Click(object sender, EventArgs e)
        {

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
