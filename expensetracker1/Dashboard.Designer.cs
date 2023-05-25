
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
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
            this.label3.Location = new System.Drawing.Point(17, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "Welcome,";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Anek Bangla Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 45);
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
            this.panel1.Location = new System.Drawing.Point(-11, -15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 734);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnLogout
            // 
            this.btnLogout.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Command;
            this.btnLogout.Location = new System.Drawing.Point(83, 490);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnLogout.Size = new System.Drawing.Size(309, 64);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Values.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAboutus
            // 
            this.btnAboutus.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Command;
            this.btnAboutus.Location = new System.Drawing.Point(83, 435);
            this.btnAboutus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAboutus.Name = "btnAboutus";
            this.btnAboutus.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnAboutus.Size = new System.Drawing.Size(309, 64);
            this.btnAboutus.TabIndex = 10;
            this.btnAboutus.Values.Text = "About Us";
            this.btnAboutus.Click += new System.EventHandler(this.btnAboutus_Click);
            // 
            // btnPrefrences
            // 
            this.btnPrefrences.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Command;
            this.btnPrefrences.Location = new System.Drawing.Point(83, 377);
            this.btnPrefrences.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrefrences.Name = "btnPrefrences";
            this.btnPrefrences.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnPrefrences.Size = new System.Drawing.Size(309, 64);
            this.btnPrefrences.TabIndex = 9;
            this.btnPrefrences.Values.Text = "Preferences";
            this.btnPrefrences.Click += new System.EventHandler(this.kryptonButton6_Click);
            // 
            // btnTotalspending
            // 
            this.btnTotalspending.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Command;
            this.btnTotalspending.Location = new System.Drawing.Point(83, 321);
            this.btnTotalspending.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTotalspending.Name = "btnTotalspending";
            this.btnTotalspending.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnTotalspending.Size = new System.Drawing.Size(309, 64);
            this.btnTotalspending.TabIndex = 7;
            this.btnTotalspending.Values.Text = "Total Spending";
            this.btnTotalspending.Click += new System.EventHandler(this.btnTotalspending_Click);
            // 
            // btnAddexpence
            // 
            this.btnAddexpence.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Command;
            this.btnAddexpence.Location = new System.Drawing.Point(83, 266);
            this.btnAddexpence.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddexpence.Name = "btnAddexpence";
            this.btnAddexpence.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnAddexpence.Size = new System.Drawing.Size(309, 64);
            this.btnAddexpence.TabIndex = 6;
            this.btnAddexpence.Values.Text = "Add Expense";
            this.btnAddexpence.Click += new System.EventHandler(this.btnAddexpence_Click);
            // 
            // btnAddincome
            // 
            this.btnAddincome.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Command;
            this.btnAddincome.Location = new System.Drawing.Point(83, 207);
            this.btnAddincome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddincome.Name = "btnAddincome";
            this.btnAddincome.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnAddincome.Size = new System.Drawing.Size(309, 64);
            this.btnAddincome.TabIndex = 5;
            this.btnAddincome.Values.Text = "Add Income";
            this.btnAddincome.Click += new System.EventHandler(this.btnAddincome_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Command;
            this.btnDashboard.Location = new System.Drawing.Point(83, 150);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnDashboard.Size = new System.Drawing.Size(309, 64);
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
            this.label2.Font = new System.Drawing.Font("Anek Bangla", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(302, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 63);
            this.label2.TabIndex = 12;
            this.label2.Text = "Dashboard";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Anek Bangla", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(305, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 45);
            this.label4.TabIndex = 13;
            this.label4.Text = "Spendings This Month";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Anek Bangla SemiExpanded ExtraB", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(299, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 103);
            this.label5.TabIndex = 14;
            this.label5.Text = "703.34$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Anek Bangla", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(309, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 45);
            this.label6.TabIndex = 15;
            this.label6.Text = "Last 5 expences ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Anek Bangla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(309, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 39);
            this.label7.TabIndex = 16;
            this.label7.Text = "$10.00 - clothing";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Anek Bangla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(310, 477);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 39);
            this.label8.TabIndex = 17;
            this.label8.Text = "$34.47 - Groceries";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Anek Bangla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(310, 438);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 39);
            this.label9.TabIndex = 18;
            this.label9.Text = "$400.00 - Housing";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Anek Bangla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(310, 397);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(202, 39);
            this.label10.TabIndex = 19;
            this.label10.Text = "$3.70 - Transportation";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Anek Bangla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(310, 353);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 39);
            this.label11.TabIndex = 20;
            this.label11.Text = "$30.40 - Food";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Anek Bangla SemiBold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(784, 224);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(325, 91);
            this.label12.TabIndex = 21;
            this.label12.Text = "20% Groceries";
            this.label12.Click += new System.EventHandler(this.label12_Click_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Anek Bangla SemiBold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(784, 143);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(297, 91);
            this.label13.TabIndex = 22;
            this.label13.Text = "70% Housing";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Anek Bangla SemiBold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(784, 488);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(420, 91);
            this.label14.TabIndex = 23;
            this.label14.Text = "2%  Transportation";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Anek Bangla SemiBold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.label15.Location = new System.Drawing.Point(784, 397);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(274, 91);
            this.label15.TabIndex = 24;
            this.label15.Text = "3% Clothing";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Anek Bangla SemiBold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.label16.Location = new System.Drawing.Point(784, 306);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(228, 91);
            this.label16.TabIndex = 25;
            this.label16.Text = "10% Food";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // btnIncome
            // 
            this.btnIncome.Location = new System.Drawing.Point(696, 642);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.Size = new System.Drawing.Size(141, 61);
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
            this.btnExpence.Location = new System.Drawing.Point(500, 642);
            this.btnExpence.Name = "btnExpence";
            this.btnExpence.Size = new System.Drawing.Size(141, 61);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1236, 727);
            this.Controls.Add(this.btnExpence);
            this.Controls.Add(this.btnIncome);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnIncome;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnExpence;
    }
}