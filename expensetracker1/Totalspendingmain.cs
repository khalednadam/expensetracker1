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
    }
}
