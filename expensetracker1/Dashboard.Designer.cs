
namespace expensetracker1
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAboutus = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnPrefrences = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnTotalspending = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAddexpence = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAddincome = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnDashboard = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSpendings = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSpended1 = new System.Windows.Forms.Label();
            this.lblSpended5 = new System.Windows.Forms.Label();
            this.lblSpended4 = new System.Windows.Forms.Label();
            this.lblSpended3 = new System.Windows.Forms.Label();
            this.lblSpended2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnIncome = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnExpence = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Welcome,";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Anek Bangla Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Khaled Nadam";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(209)))));
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnAboutus);
            this.panel1.Controls.Add(this.btnPrefrences);
            this.panel1.Controls.Add(this.btnTotalspending);
            this.panel1.Controls.Add(this.btnAddexpence);
            this.panel1.Controls.Add(this.btnAddincome);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-8, -12);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 596);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnLogout
            // 
            this.btnLogout.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Command;
            this.btnLogout.Location = new System.Drawing.Point(62, 398);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnLogout.Size = new System.Drawing.Size(232, 52);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Values.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAboutus
            // 
            this.btnAboutus.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Command;
            this.btnAboutus.Location = new System.Drawing.Point(62, 353);
            this.btnAboutus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAboutus.Name = "btnAboutus";
            this.btnAboutus.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnAboutus.Size = new System.Drawing.Size(232, 52);
            this.btnAboutus.TabIndex = 10;
            this.btnAboutus.Values.Text = "About Us";
            this.btnAboutus.Click += new System.EventHandler(this.btnAboutus_Click);
            // 
            // btnPrefrences
            // 
            this.btnPrefrences.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Command;
            this.btnPrefrences.Location = new System.Drawing.Point(62, 306);
            this.btnPrefrences.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrefrences.Name = "btnPrefrences";
            this.btnPrefrences.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnPrefrences.Size = new System.Drawing.Size(232, 52);
            this.btnPrefrences.TabIndex = 9;
            this.btnPrefrences.Values.Text = "Preferences";
            this.btnPrefrences.Click += new System.EventHandler(this.kryptonButton6_Click);
            // 
            // btnTotalspending
            // 
            this.btnTotalspending.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Command;
            this.btnTotalspending.Location = new System.Drawing.Point(62, 261);
            this.btnTotalspending.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTotalspending.Name = "btnTotalspending";
            this.btnTotalspending.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnTotalspending.Size = new System.Drawing.Size(232, 52);
            this.btnTotalspending.TabIndex = 7;
            this.btnTotalspending.Values.Text = "Total Spending";
            this.btnTotalspending.Click += new System.EventHandler(this.btnTotalspending_Click);
            // 
            // btnAddexpence
            // 
            this.btnAddexpence.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Command;
            this.btnAddexpence.Location = new System.Drawing.Point(62, 216);
            this.btnAddexpence.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddexpence.Name = "btnAddexpence";
            this.btnAddexpence.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnAddexpence.Size = new System.Drawing.Size(232, 52);
            this.btnAddexpence.TabIndex = 6;
            this.btnAddexpence.Values.Text = "Add Expense";
            this.btnAddexpence.Click += new System.EventHandler(this.btnAddexpence_Click);
            // 
            // btnAddincome
            // 
            this.btnAddincome.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Command;
            this.btnAddincome.Location = new System.Drawing.Point(62, 168);
            this.btnAddincome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddincome.Name = "btnAddincome";
            this.btnAddincome.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnAddincome.Size = new System.Drawing.Size(232, 52);
            this.btnAddincome.TabIndex = 5;
            this.btnAddincome.Values.Text = "Add Income";
            this.btnAddincome.Click += new System.EventHandler(this.btnAddincome_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Command;
            this.btnDashboard.Location = new System.Drawing.Point(62, 122);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnDashboard.Size = new System.Drawing.Size(232, 52);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Values.Text = "Dashboard";
            this.btnDashboard.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.ButtonSpecs.FormClose.Image = global::expensetracker1.Properties.Resources.close;
            this.kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImagePressed = global::expensetracker1.Properties.Resources.close;
            this.kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImageTracking = global::expensetracker1.Properties.Resources.close;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(226, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 30);
            this.label2.TabIndex = 12;
            this.label2.Text = "Dashboard";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(229, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Spendings This Month";
            // 
            // lblSpendings
            // 
            this.lblSpendings.AutoSize = true;
            this.lblSpendings.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpendings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(0)))));
            this.lblSpendings.Location = new System.Drawing.Point(224, 110);
            this.lblSpendings.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpendings.Name = "lblSpendings";
            this.lblSpendings.Size = new System.Drawing.Size(185, 51);
            this.lblSpendings.TabIndex = 14;
            this.lblSpendings.Text = "703.34$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(232, 210);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Last 5 expenses ";
            // 
            // lblSpended1
            // 
            this.lblSpended1.AutoSize = true;
            this.lblSpended1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpended1.ForeColor = System.Drawing.Color.Black;
            this.lblSpended1.Location = new System.Drawing.Point(232, 255);
            this.lblSpended1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpended1.Name = "lblSpended1";
            this.lblSpended1.Size = new System.Drawing.Size(126, 20);
            this.lblSpended1.TabIndex = 16;
            this.lblSpended1.Text = "$10.00 - clothing";
            // 
            // lblSpended5
            // 
            this.lblSpended5.AutoSize = true;
            this.lblSpended5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpended5.ForeColor = System.Drawing.Color.Black;
            this.lblSpended5.Location = new System.Drawing.Point(232, 388);
            this.lblSpended5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpended5.Name = "lblSpended5";
            this.lblSpended5.Size = new System.Drawing.Size(140, 20);
            this.lblSpended5.TabIndex = 17;
            this.lblSpended5.Text = "$34.47 - Groceries";
            // 
            // lblSpended4
            // 
            this.lblSpended4.AutoSize = true;
            this.lblSpended4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpended4.ForeColor = System.Drawing.Color.Black;
            this.lblSpended4.Location = new System.Drawing.Point(232, 356);
            this.lblSpended4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpended4.Name = "lblSpended4";
            this.lblSpended4.Size = new System.Drawing.Size(139, 20);
            this.lblSpended4.TabIndex = 18;
            this.lblSpended4.Text = "$400.00 - Housing";
            // 
            // lblSpended3
            // 
            this.lblSpended3.AutoSize = true;
            this.lblSpended3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpended3.ForeColor = System.Drawing.Color.Black;
            this.lblSpended3.Location = new System.Drawing.Point(232, 323);
            this.lblSpended3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpended3.Name = "lblSpended3";
            this.lblSpended3.Size = new System.Drawing.Size(165, 20);
            this.lblSpended3.TabIndex = 19;
            this.lblSpended3.Text = "$3.70 - Transportation";
            // 
            // lblSpended2
            // 
            this.lblSpended2.AutoSize = true;
            this.lblSpended2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpended2.ForeColor = System.Drawing.Color.Black;
            this.lblSpended2.Location = new System.Drawing.Point(232, 287);
            this.lblSpended2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpended2.Name = "lblSpended2";
            this.lblSpended2.Size = new System.Drawing.Size(108, 20);
            this.lblSpended2.TabIndex = 20;
            this.lblSpended2.Text = "$30.40 - Food";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(588, 182);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(285, 44);
            this.label12.TabIndex = 21;
            this.label12.Text = "20% Groceries";
            this.label12.Click += new System.EventHandler(this.label12_Click_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(588, 116);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(256, 44);
            this.label13.TabIndex = 22;
            this.label13.Text = "70% Housing";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(588, 396);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(359, 44);
            this.label14.TabIndex = 23;
            this.label14.Text = "2%  Transportation";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.label15.Location = new System.Drawing.Point(588, 323);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(236, 44);
            this.label15.TabIndex = 24;
            this.label15.Text = "3% Clothing";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.label16.Location = new System.Drawing.Point(588, 249);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(200, 44);
            this.label16.TabIndex = 25;
            this.label16.Text = "10% Food";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // btnIncome
            // 
            this.btnIncome.Location = new System.Drawing.Point(537, 522);
            this.btnIncome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.Size = new System.Drawing.Size(154, 50);
            this.btnIncome.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(4)))), ((int)(((byte)(64)))));
            this.btnIncome.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(4)))), ((int)(((byte)(64)))));
            this.btnIncome.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(4)))), ((int)(((byte)(64)))));
            this.btnIncome.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(4)))), ((int)(((byte)(64)))));
            this.btnIncome.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnIncome.StateCommon.Border.Rounding = 10;
            this.btnIncome.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnIncome.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnIncome.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnIncome.TabIndex = 27;
            this.btnIncome.Values.Text = "Add Income";
            this.btnIncome.Click += new System.EventHandler(this.btnIncome_Click);
            // 
            // btnExpence
            // 
            this.btnExpence.Location = new System.Drawing.Point(357, 522);
            this.btnExpence.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExpence.Name = "btnExpence";
            this.btnExpence.Size = new System.Drawing.Size(156, 50);
            this.btnExpence.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(4)))), ((int)(((byte)(64)))));
            this.btnExpence.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(4)))), ((int)(((byte)(64)))));
            this.btnExpence.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(4)))), ((int)(((byte)(64)))));
            this.btnExpence.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(4)))), ((int)(((byte)(64)))));
            this.btnExpence.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnExpence.StateCommon.Border.Rounding = 10;
            this.btnExpence.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnExpence.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnExpence.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnExpence.TabIndex = 28;
            this.btnExpence.Values.Text = "Add Expence";
            this.btnExpence.Click += new System.EventHandler(this.btnExpence_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(927, 591);
            this.Controls.Add(this.btnExpence);
            this.Controls.Add(this.btnIncome);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblSpended2);
            this.Controls.Add(this.lblSpended3);
            this.Controls.Add(this.lblSpended4);
            this.Controls.Add(this.lblSpended5);
            this.Controls.Add(this.lblSpended1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSpendings);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DashboardForm";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 10;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.btnDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnDashboard;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnPrefrences;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnTotalspending;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnAddexpence;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnAddincome;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnLogout;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnAboutus;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSpendings;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSpended1;
        private System.Windows.Forms.Label lblSpended5;
        private System.Windows.Forms.Label lblSpended4;
        private System.Windows.Forms.Label lblSpended3;
        private System.Windows.Forms.Label lblSpended2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnIncome;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnExpence;
    }
}