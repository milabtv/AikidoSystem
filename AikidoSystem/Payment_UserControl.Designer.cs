namespace AikidoSystem
{
    partial class Payment_UserControl
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
            this.deletePayment = new AikidoSystem.UI.Button_M();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.editPayment = new AikidoSystem.UI.Button_M();
            this.showKartoteka = new AikidoSystem.UI.Button_M();
            this.addPayment = new AikidoSystem.UI.Button_M();
            this.textBox_M1 = new AikidoSystem.UI.TextBox_M();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.deletePayment);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.editPayment);
            this.panel1.Controls.Add(this.showKartoteka);
            this.panel1.Controls.Add(this.addPayment);
            this.panel1.Controls.Add(this.textBox_M1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 512);
            this.panel1.TabIndex = 18;
            // 
            // deletePayment
            // 
            this.deletePayment.BackColor = System.Drawing.Color.RoyalBlue;
            this.deletePayment.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.deletePayment.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.deletePayment.BorderRadius = 0;
            this.deletePayment.BorderSize = 0;
            this.deletePayment.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.deletePayment.FlatAppearance.BorderSize = 0;
            this.deletePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletePayment.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePayment.ForeColor = System.Drawing.Color.Lavender;
            this.deletePayment.Location = new System.Drawing.Point(362, 454);
            this.deletePayment.Name = "deletePayment";
            this.deletePayment.Size = new System.Drawing.Size(151, 30);
            this.deletePayment.TabIndex = 16;
            this.deletePayment.Text = "Изтрий";
            this.deletePayment.TextColor = System.Drawing.Color.Lavender;
            this.deletePayment.UseVisualStyleBackColor = false;
            this.deletePayment.Click += new System.EventHandler(this.deletePayment_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(736, 334);
            this.dataGridView1.TabIndex = 4;
            // 
            // editPayment
            // 
            this.editPayment.BackColor = System.Drawing.Color.RoyalBlue;
            this.editPayment.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.editPayment.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.editPayment.BorderRadius = 0;
            this.editPayment.BorderSize = 0;
            this.editPayment.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.editPayment.FlatAppearance.BorderSize = 0;
            this.editPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editPayment.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editPayment.ForeColor = System.Drawing.Color.Lavender;
            this.editPayment.Location = new System.Drawing.Point(205, 454);
            this.editPayment.Name = "editPayment";
            this.editPayment.Size = new System.Drawing.Size(151, 30);
            this.editPayment.TabIndex = 15;
            this.editPayment.Text = "Редактирай";
            this.editPayment.TextColor = System.Drawing.Color.Lavender;
            this.editPayment.UseVisualStyleBackColor = false;
            this.editPayment.Click += new System.EventHandler(this.editPayment_Click_1);
            // 
            // showKartoteka
            // 
            this.showKartoteka.BackColor = System.Drawing.Color.RoyalBlue;
            this.showKartoteka.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.showKartoteka.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.showKartoteka.BorderRadius = 0;
            this.showKartoteka.BorderSize = 0;
            this.showKartoteka.FlatAppearance.BorderSize = 0;
            this.showKartoteka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showKartoteka.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showKartoteka.ForeColor = System.Drawing.Color.Lavender;
            this.showKartoteka.Location = new System.Drawing.Point(48, 40);
            this.showKartoteka.Name = "showKartoteka";
            this.showKartoteka.Size = new System.Drawing.Size(151, 30);
            this.showKartoteka.TabIndex = 6;
            this.showKartoteka.Text = "Покажи";
            this.showKartoteka.TextColor = System.Drawing.Color.Lavender;
            this.showKartoteka.UseVisualStyleBackColor = false;
            this.showKartoteka.Click += new System.EventHandler(this.showKartoteka_Click);
            // 
            // addPayment
            // 
            this.addPayment.BackColor = System.Drawing.Color.RoyalBlue;
            this.addPayment.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.addPayment.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addPayment.BorderRadius = 0;
            this.addPayment.BorderSize = 0;
            this.addPayment.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.addPayment.FlatAppearance.BorderSize = 0;
            this.addPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPayment.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPayment.ForeColor = System.Drawing.Color.Lavender;
            this.addPayment.Location = new System.Drawing.Point(48, 454);
            this.addPayment.Name = "addPayment";
            this.addPayment.Size = new System.Drawing.Size(151, 30);
            this.addPayment.TabIndex = 14;
            this.addPayment.Text = "Добави Нов";
            this.addPayment.TextColor = System.Drawing.Color.Lavender;
            this.addPayment.UseVisualStyleBackColor = false;
            this.addPayment.Click += new System.EventHandler(this.addPayment_Click_1);
            // 
            // textBox_M1
            // 
            this.textBox_M1.BackColor = System.Drawing.Color.Lavender;
            this.textBox_M1.BorderColor = System.Drawing.Color.MidnightBlue;
            this.textBox_M1.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_M1.BorderRadius = 0;
            this.textBox_M1.BorderSize = 2;
            this.textBox_M1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_M1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBox_M1.Location = new System.Drawing.Point(214, 40);
            this.textBox_M1.Multiline = false;
            this.textBox_M1.Name = "textBox_M1";
            this.textBox_M1.Padding = new System.Windows.Forms.Padding(7);
            this.textBox_M1.PasswordChar = false;
            this.textBox_M1.PlaceholderColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_M1.PlaceholderText = "Търсене";
            this.textBox_M1.Size = new System.Drawing.Size(570, 31);
            this.textBox_M1.TabIndex = 7;
            this.textBox_M1.Texts = "";
            this.textBox_M1.UnderlinedStyle = false;
            // 
            // Payment_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.panel1);
            this.Name = "Payment_UserControl";
            this.Size = new System.Drawing.Size(851, 512);
            this.Load += new System.EventHandler(this.Payment_UserControl_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private UI.Button_M deletePayment;
        private System.Windows.Forms.DataGridView dataGridView1;
        private UI.Button_M editPayment;
        private UI.Button_M showKartoteka;
        private UI.Button_M addPayment;
        private UI.TextBox_M textBox_M1;
    }
}
