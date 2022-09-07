namespace AikidoSystem
{
    partial class LoginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btvMaximize = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_M1 = new AikidoSystem.UI.Button_M();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_M2 = new AikidoSystem.UI.TextBox_M();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_M1 = new AikidoSystem.UI.TextBox_M();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btvMaximize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 91);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Lavender;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.Black;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 25;
            this.btnMinimize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMinimize.Location = new System.Drawing.Point(365, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(46, 30);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(357, 91);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = global::AikidoSystem.Properties.Resources.title_mb_1;
            this.pictureBox2.Location = new System.Drawing.Point(104, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(249, 91);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::AikidoSystem.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btvMaximize
            // 
            this.btvMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btvMaximize.BackColor = System.Drawing.Color.RoyalBlue;
            this.btvMaximize.FlatAppearance.BorderSize = 0;
            this.btvMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btvMaximize.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btvMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btvMaximize.IconColor = System.Drawing.Color.Lavender;
            this.btvMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btvMaximize.IconSize = 25;
            this.btvMaximize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btvMaximize.Location = new System.Drawing.Point(411, 0);
            this.btvMaximize.Name = "btvMaximize";
            this.btvMaximize.Size = new System.Drawing.Size(46, 30);
            this.btvMaximize.TabIndex = 4;
            this.btvMaximize.UseVisualStyleBackColor = false;
            this.btvMaximize.Click += new System.EventHandler(this.btvMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnClose.IconColor = System.Drawing.Color.Lavender;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 25;
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClose.Location = new System.Drawing.Point(457, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(46, 30);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.button_M1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox_M2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox_M1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(0, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(503, 515);
            this.panel2.TabIndex = 0;
            // 
            // button_M1
            // 
            this.button_M1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_M1.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.button_M1.BorderColor = System.Drawing.Color.Pink;
            this.button_M1.BorderRadius = 0;
            this.button_M1.BorderSize = 0;
            this.button_M1.FlatAppearance.BorderSize = 0;
            this.button_M1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_M1.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_M1.ForeColor = System.Drawing.Color.Lavender;
            this.button_M1.Location = new System.Drawing.Point(180, 328);
            this.button_M1.Name = "button_M1";
            this.button_M1.Size = new System.Drawing.Size(150, 40);
            this.button_M1.TabIndex = 4;
            this.button_M1.Text = "Вход";
            this.button_M1.TextColor = System.Drawing.Color.Lavender;
            this.button_M1.UseVisualStyleBackColor = false;
            this.button_M1.Click += new System.EventHandler(this.button_M1_Click);
            this.button_M1.MouseHover += new System.EventHandler(this.button_M1_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Парола";
            // 
            // textBox_M2
            // 
            this.textBox_M2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_M2.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.textBox_M2.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_M2.BorderRadius = 0;
            this.textBox_M2.BorderSize = 5;
            this.textBox_M2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_M2.ForeColor = System.Drawing.Color.DimGray;
            this.textBox_M2.Location = new System.Drawing.Point(130, 215);
            this.textBox_M2.Multiline = false;
            this.textBox_M2.Name = "textBox_M2";
            this.textBox_M2.Padding = new System.Windows.Forms.Padding(7);
            this.textBox_M2.PasswordChar = true;
            this.textBox_M2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBox_M2.PlaceholderText = "";
            this.textBox_M2.Size = new System.Drawing.Size(250, 31);
            this.textBox_M2.TabIndex = 2;
            this.textBox_M2.Texts = "";
            this.textBox_M2.UnderlinedStyle = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Потребителско име";
            // 
            // textBox_M1
            // 
            this.textBox_M1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_M1.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.textBox_M1.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_M1.BorderRadius = 0;
            this.textBox_M1.BorderSize = 5;
            this.textBox_M1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_M1.ForeColor = System.Drawing.Color.DimGray;
            this.textBox_M1.Location = new System.Drawing.Point(130, 107);
            this.textBox_M1.Multiline = false;
            this.textBox_M1.Name = "textBox_M1";
            this.textBox_M1.Padding = new System.Windows.Forms.Padding(7);
            this.textBox_M1.PasswordChar = false;
            this.textBox_M1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBox_M1.PlaceholderText = "";
            this.textBox_M1.Size = new System.Drawing.Size(250, 31);
            this.textBox_M1.TabIndex = 0;
            this.textBox_M1.Texts = "";
            this.textBox_M1.UnderlinedStyle = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 606);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btvMaximize;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Label label2;
        private UI.TextBox_M textBox_M2;
        private System.Windows.Forms.Label label1;
        private UI.TextBox_M textBox_M1;
        private UI.Button_M button_M1;
    }
}