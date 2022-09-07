namespace AikidoSystem
{
    partial class Admin_UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.levelSettings = new FontAwesome.Sharp.IconButton();
            this.panel8 = new System.Windows.Forms.Panel();
            this.paymentSettings = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.hallSettings = new FontAwesome.Sharp.IconButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.acountSettings = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 512);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(58, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(734, 434);
            this.panel2.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(367, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(367, 434);
            this.panel4.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.levelSettings);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 217);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(367, 217);
            this.panel7.TabIndex = 3;
            // 
            // levelSettings
            // 
            this.levelSettings.BackColor = System.Drawing.Color.CornflowerBlue;
            this.levelSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.levelSettings.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelSettings.ForeColor = System.Drawing.Color.Lavender;
            this.levelSettings.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.levelSettings.IconColor = System.Drawing.Color.Lavender;
            this.levelSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.levelSettings.IconSize = 82;
            this.levelSettings.Location = new System.Drawing.Point(42, 32);
            this.levelSettings.Name = "levelSettings";
            this.levelSettings.Size = new System.Drawing.Size(283, 146);
            this.levelSettings.TabIndex = 3;
            this.levelSettings.Text = "Степени";
            this.levelSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.levelSettings.UseMnemonic = false;
            this.levelSettings.UseVisualStyleBackColor = false;
            this.levelSettings.Click += new System.EventHandler(this.levelSettings_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.paymentSettings);
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(367, 217);
            this.panel8.TabIndex = 2;
            // 
            // paymentSettings
            // 
            this.paymentSettings.BackColor = System.Drawing.Color.CornflowerBlue;
            this.paymentSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.paymentSettings.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentSettings.ForeColor = System.Drawing.Color.Lavender;
            this.paymentSettings.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.paymentSettings.IconColor = System.Drawing.Color.Lavender;
            this.paymentSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.paymentSettings.IconSize = 82;
            this.paymentSettings.Location = new System.Drawing.Point(42, 35);
            this.paymentSettings.Name = "paymentSettings";
            this.paymentSettings.Size = new System.Drawing.Size(283, 146);
            this.paymentSettings.TabIndex = 1;
            this.paymentSettings.Text = "Членски внос";
            this.paymentSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.paymentSettings.UseVisualStyleBackColor = false;
            this.paymentSettings.Click += new System.EventHandler(this.paymentSettings_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(367, 434);
            this.panel3.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.hallSettings);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 217);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(367, 217);
            this.panel6.TabIndex = 1;
            // 
            // hallSettings
            // 
            this.hallSettings.BackColor = System.Drawing.Color.CornflowerBlue;
            this.hallSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hallSettings.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hallSettings.ForeColor = System.Drawing.Color.Lavender;
            this.hallSettings.IconChar = FontAwesome.Sharp.IconChar.Building;
            this.hallSettings.IconColor = System.Drawing.Color.Lavender;
            this.hallSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.hallSettings.IconSize = 82;
            this.hallSettings.Location = new System.Drawing.Point(42, 32);
            this.hallSettings.Name = "hallSettings";
            this.hallSettings.Size = new System.Drawing.Size(283, 146);
            this.hallSettings.TabIndex = 2;
            this.hallSettings.Text = "Зали";
            this.hallSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.hallSettings.UseVisualStyleBackColor = false;
            this.hallSettings.Click += new System.EventHandler(this.hallSettings_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.acountSettings);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(367, 217);
            this.panel5.TabIndex = 0;
            // 
            // acountSettings
            // 
            this.acountSettings.BackColor = System.Drawing.Color.CornflowerBlue;
            this.acountSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.acountSettings.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acountSettings.ForeColor = System.Drawing.Color.Lavender;
            this.acountSettings.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.acountSettings.IconColor = System.Drawing.Color.Lavender;
            this.acountSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.acountSettings.IconSize = 82;
            this.acountSettings.Location = new System.Drawing.Point(42, 35);
            this.acountSettings.Name = "acountSettings";
            this.acountSettings.Size = new System.Drawing.Size(283, 146);
            this.acountSettings.TabIndex = 0;
            this.acountSettings.Text = "Акаунти";
            this.acountSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.acountSettings.UseVisualStyleBackColor = false;
            this.acountSettings.Click += new System.EventHandler(this.acountSettings_Click);
            // 
            // Admin_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Admin_UserControl";
            this.Size = new System.Drawing.Size(851, 512);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton acountSettings;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton levelSettings;
        private FontAwesome.Sharp.IconButton paymentSettings;
        private System.Windows.Forms.Panel panel6;
        private FontAwesome.Sharp.IconButton hallSettings;
    }
}
