namespace AikidoSystem
{
    partial class Seminars_UserControl
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteSeminar = new AikidoSystem.UI.Button_M();
            this.editSeminar = new AikidoSystem.UI.Button_M();
            this.showKartoteka = new AikidoSystem.UI.Button_M();
            this.addSeminar = new AikidoSystem.UI.Button_M();
            this.textBox_M1 = new AikidoSystem.UI.TextBox_M();
            this.printKartoteka = new AikidoSystem.UI.Button_M();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.deleteSeminar);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.editSeminar);
            this.panel1.Controls.Add(this.showKartoteka);
            this.panel1.Controls.Add(this.addSeminar);
            this.panel1.Controls.Add(this.textBox_M1);
            this.panel1.Controls.Add(this.printKartoteka);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 512);
            this.panel1.TabIndex = 18;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // deleteSeminar
            // 
            this.deleteSeminar.BackColor = System.Drawing.Color.RoyalBlue;
            this.deleteSeminar.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.deleteSeminar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.deleteSeminar.BorderRadius = 0;
            this.deleteSeminar.BorderSize = 0;
            this.deleteSeminar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.deleteSeminar.FlatAppearance.BorderSize = 0;
            this.deleteSeminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSeminar.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSeminar.ForeColor = System.Drawing.Color.Lavender;
            this.deleteSeminar.Location = new System.Drawing.Point(362, 454);
            this.deleteSeminar.Name = "deleteSeminar";
            this.deleteSeminar.Size = new System.Drawing.Size(151, 30);
            this.deleteSeminar.TabIndex = 16;
            this.deleteSeminar.Text = "Изтрий";
            this.deleteSeminar.TextColor = System.Drawing.Color.Lavender;
            this.deleteSeminar.UseVisualStyleBackColor = false;
            this.deleteSeminar.Click += new System.EventHandler(this.deleteSeminar_Click);
            // 
            // editSeminar
            // 
            this.editSeminar.BackColor = System.Drawing.Color.RoyalBlue;
            this.editSeminar.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.editSeminar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.editSeminar.BorderRadius = 0;
            this.editSeminar.BorderSize = 0;
            this.editSeminar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.editSeminar.FlatAppearance.BorderSize = 0;
            this.editSeminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editSeminar.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editSeminar.ForeColor = System.Drawing.Color.Lavender;
            this.editSeminar.Location = new System.Drawing.Point(205, 454);
            this.editSeminar.Name = "editSeminar";
            this.editSeminar.Size = new System.Drawing.Size(151, 30);
            this.editSeminar.TabIndex = 15;
            this.editSeminar.Text = "Редактирай";
            this.editSeminar.TextColor = System.Drawing.Color.Lavender;
            this.editSeminar.UseVisualStyleBackColor = false;
            this.editSeminar.Click += new System.EventHandler(this.editSeminar_Click);
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
            // 
            // addSeminar
            // 
            this.addSeminar.BackColor = System.Drawing.Color.RoyalBlue;
            this.addSeminar.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.addSeminar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addSeminar.BorderRadius = 0;
            this.addSeminar.BorderSize = 0;
            this.addSeminar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.addSeminar.FlatAppearance.BorderSize = 0;
            this.addSeminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSeminar.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSeminar.ForeColor = System.Drawing.Color.Lavender;
            this.addSeminar.Location = new System.Drawing.Point(48, 454);
            this.addSeminar.Name = "addSeminar";
            this.addSeminar.Size = new System.Drawing.Size(151, 30);
            this.addSeminar.TabIndex = 14;
            this.addSeminar.Text = "Добави Участник";
            this.addSeminar.TextColor = System.Drawing.Color.Lavender;
            this.addSeminar.UseVisualStyleBackColor = false;
            this.addSeminar.Click += new System.EventHandler(this.addSeminar_Click);
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
            // printKartoteka
            // 
            this.printKartoteka.BackColor = System.Drawing.Color.RoyalBlue;
            this.printKartoteka.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.printKartoteka.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.printKartoteka.BorderRadius = 0;
            this.printKartoteka.BorderSize = 0;
            this.printKartoteka.FlatAppearance.BorderSize = 0;
            this.printKartoteka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printKartoteka.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printKartoteka.ForeColor = System.Drawing.Color.Lavender;
            this.printKartoteka.Location = new System.Drawing.Point(633, 454);
            this.printKartoteka.Name = "printKartoteka";
            this.printKartoteka.Size = new System.Drawing.Size(151, 30);
            this.printKartoteka.TabIndex = 13;
            this.printKartoteka.Text = "Притирай";
            this.printKartoteka.TextColor = System.Drawing.Color.Lavender;
            this.printKartoteka.UseVisualStyleBackColor = false;
            // 
            // Seminars_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Seminars_UserControl";
            this.Size = new System.Drawing.Size(851, 512);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UI.Button_M deleteSeminar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private UI.Button_M editSeminar;
        private UI.Button_M showKartoteka;
        private UI.Button_M addSeminar;
        private UI.TextBox_M textBox_M1;
        private UI.Button_M printKartoteka;
        private System.Windows.Forms.Panel panel1;
    }
}
