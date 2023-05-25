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
    public partial class Totalspendingmain : KryptonForm
    {
        public int id;
        public Totalspendingmain(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Totalspendingmain_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click_1(object sender, EventArgs e)
        {

        }

        private void kryptonPalette1_PalettePaint(object sender, PaletteLayoutEventArgs e)
        {

        }

        private void btnSpendingdetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            Totalspending totalspending = new Totalspending(id);
            totalspending.Show();
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

        private void btnPrefrences_Click(object sender, EventArgs e)
        {
            this.Hide();
            prefrencesForm prefrencesForm = new prefrencesForm(id);
            prefrencesForm.Show();
        }

        private void btnTotalspending_Click(object sender, EventArgs e)
        {

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
    }
}
