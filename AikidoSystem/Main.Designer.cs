namespace AikidoSystem
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btvMaximize = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.btnSeminars = new FontAwesome.Sharp.IconButton();
            this.btnDocs = new FontAwesome.Sharp.IconButton();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.btnGroups = new FontAwesome.Sharp.IconButton();
            this.btnTimetable = new FontAwesome.Sharp.IconButton();
            this.btnPayment = new FontAwesome.Sharp.IconButton();
            this.btnKartoteka = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelMenu.Controls.Add(this.iconButton1);
            this.panelMenu.Controls.Add(this.btnSeminars);
            this.panelMenu.Controls.Add(this.btnDocs);
            this.panelMenu.Controls.Add(this.iconButton6);
            this.panelMenu.Controls.Add(this.btnGroups);
            this.panelMenu.Controls.Add(this.btnTimetable);
            this.panelMenu.Controls.Add(this.btnPayment);
            this.panelMenu.Controls.Add(this.btnKartoteka);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Controls.Add(this.panel1);
            resources.ApplyResources(this.panelMenu, "panelMenu");
            this.panelMenu.Name = "panelMenu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMenu);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelTitleBar.Controls.Add(this.pictureBox2);
            this.panelTitleBar.Controls.Add(this.pictureBox1);
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btvMaximize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            resources.ApplyResources(this.panelTitleBar, "panelTitleBar");
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.LightSteelBlue;
            resources.ApplyResources(this.panelDesktop, "panelDesktop");
            this.panelDesktop.Name = "panelDesktop";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Image = global::AikidoSystem.Properties.Resources.title_mb_2;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::AikidoSystem.Properties.Resources.logo;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btnMinimize
            // 
            resources.ApplyResources(this.btnMinimize, "btnMinimize");
            this.btnMinimize.BackColor = System.Drawing.Color.Lavender;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.Black;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 25;
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btvMaximize
            // 
            resources.ApplyResources(this.btvMaximize, "btvMaximize");
            this.btvMaximize.BackColor = System.Drawing.Color.RoyalBlue;
            this.btvMaximize.FlatAppearance.BorderSize = 0;
            this.btvMaximize.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btvMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btvMaximize.IconColor = System.Drawing.Color.Lavender;
            this.btvMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btvMaximize.IconSize = 25;
            this.btvMaximize.Name = "btvMaximize";
            this.btvMaximize.UseVisualStyleBackColor = false;
            this.btvMaximize.Click += new System.EventHandler(this.btvMaximize_Click);
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnClose.IconColor = System.Drawing.Color.Lavender;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 25;
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSeminars
            // 
            resources.ApplyResources(this.btnSeminars, "btnSeminars");
            this.btnSeminars.FlatAppearance.BorderSize = 0;
            this.btnSeminars.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btnSeminars.IconChar = FontAwesome.Sharp.IconChar.PeopleLine;
            this.btnSeminars.IconColor = System.Drawing.Color.LightSteelBlue;
            this.btnSeminars.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSeminars.Name = "btnSeminars";
            this.btnSeminars.Tag = "Семинари";
            this.btnSeminars.UseVisualStyleBackColor = true;
            // 
            // btnDocs
            // 
            resources.ApplyResources(this.btnDocs, "btnDocs");
            this.btnDocs.FlatAppearance.BorderSize = 0;
            this.btnDocs.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btnDocs.IconChar = FontAwesome.Sharp.IconChar.Paperclip;
            this.btnDocs.IconColor = System.Drawing.Color.LightSteelBlue;
            this.btnDocs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDocs.Name = "btnDocs";
            this.btnDocs.Tag = "Документи";
            this.btnDocs.UseVisualStyleBackColor = true;
            this.btnDocs.Click += new System.EventHandler(this.btnDocs_Click);
            // 
            // iconButton6
            // 
            resources.ApplyResources(this.iconButton6, "iconButton6");
            this.iconButton6.FlatAppearance.BorderSize = 0;
            this.iconButton6.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.iconButton6.IconColor = System.Drawing.Color.LightSteelBlue;
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Tag = "Излизане";
            this.iconButton6.UseVisualStyleBackColor = true;
            this.iconButton6.Click += new System.EventHandler(this.iconButton6_Click);
            // 
            // btnGroups
            // 
            resources.ApplyResources(this.btnGroups, "btnGroups");
            this.btnGroups.FlatAppearance.BorderSize = 0;
            this.btnGroups.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btnGroups.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.btnGroups.IconColor = System.Drawing.Color.LightSteelBlue;
            this.btnGroups.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGroups.Name = "btnGroups";
            this.btnGroups.Tag = "Групи";
            this.btnGroups.UseVisualStyleBackColor = true;
            this.btnGroups.Click += new System.EventHandler(this.btnGroups_Click);
            // 
            // btnTimetable
            // 
            resources.ApplyResources(this.btnTimetable, "btnTimetable");
            this.btnTimetable.FlatAppearance.BorderSize = 0;
            this.btnTimetable.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btnTimetable.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.btnTimetable.IconColor = System.Drawing.Color.LightSteelBlue;
            this.btnTimetable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimetable.Name = "btnTimetable";
            this.btnTimetable.Tag = "График";
            this.btnTimetable.UseVisualStyleBackColor = true;
            this.btnTimetable.Click += new System.EventHandler(this.btnTimetable_Click);
            // 
            // btnPayment
            // 
            resources.ApplyResources(this.btnPayment, "btnPayment");
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btnPayment.IconChar = FontAwesome.Sharp.IconChar.MoneyBillAlt;
            this.btnPayment.IconColor = System.Drawing.Color.LightSteelBlue;
            this.btnPayment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Tag = "Членски внос";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnKartoteka
            // 
            resources.ApplyResources(this.btnKartoteka, "btnKartoteka");
            this.btnKartoteka.FlatAppearance.BorderSize = 0;
            this.btnKartoteka.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btnKartoteka.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.btnKartoteka.IconColor = System.Drawing.Color.LightSteelBlue;
            this.btnKartoteka.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKartoteka.Name = "btnKartoteka";
            this.btnKartoteka.Tag = "Картотеки";
            this.btnKartoteka.UseVisualStyleBackColor = true;
            this.btnKartoteka.Click += new System.EventHandler(this.btnKartoteka_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.MidnightBlue;
            resources.ApplyResources(this.btnHome, "btnHome");
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnHome.IconColor = System.Drawing.Color.LightSteelBlue;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.Name = "btnHome";
            this.btnHome.Tag = "Начало";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnMenu
            // 
            resources.ApplyResources(this.btnMenu, "btnMenu");
            this.btnMenu.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.ListDots;
            this.btnMenu.IconColor = System.Drawing.Color.Lavender;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // iconButton1
            // 
            resources.ApplyResources(this.iconButton1, "iconButton1");
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.iconButton1.IconColor = System.Drawing.Color.LightSteelBlue;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Tag = "Семинари";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "Main";
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton btnGroups;
        private FontAwesome.Sharp.IconButton btnTimetable;
        private FontAwesome.Sharp.IconButton btnPayment;
        private FontAwesome.Sharp.IconButton btnKartoteka;
        private FontAwesome.Sharp.IconButton btvMaximize;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton btnDocs;
        private FontAwesome.Sharp.IconButton btnSeminars;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}