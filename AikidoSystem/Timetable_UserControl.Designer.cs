namespace AikidoSystem
{
    partial class Timetable_UserControl
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
            this.comboBox_M1 = new AikidoSystem.UI.ComboBox_M();
            this.button_M1 = new AikidoSystem.UI.Button_M();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deletePractice = new AikidoSystem.UI.Button_M();
            this.addPractice = new AikidoSystem.UI.Button_M();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_M1
            // 
            this.comboBox_M1.BackColor = System.Drawing.Color.Lavender;
            this.comboBox_M1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.comboBox_M1.BorderSize = 2;
            this.comboBox_M1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboBox_M1.ForeColor = System.Drawing.Color.DimGray;
            this.comboBox_M1.IconColor = System.Drawing.Color.MidnightBlue;
            this.comboBox_M1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.comboBox_M1.ListTextColor = System.Drawing.Color.DimGray;
            this.comboBox_M1.Location = new System.Drawing.Point(262, 40);
            this.comboBox_M1.MinimumSize = new System.Drawing.Size(200, 30);
            this.comboBox_M1.Name = "comboBox_M1";
            this.comboBox_M1.Padding = new System.Windows.Forms.Padding(2);
            this.comboBox_M1.Size = new System.Drawing.Size(522, 30);
            this.comboBox_M1.TabIndex = 1;
            this.comboBox_M1.Texts = "";
            this.comboBox_M1.OnSelectedIndexChanged += new System.EventHandler(this.comboBox_M1_OnSelectedIndexChanged);
            // 
            // button_M1
            // 
            this.button_M1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_M1.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.button_M1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.button_M1.BorderRadius = 0;
            this.button_M1.BorderSize = 0;
            this.button_M1.FlatAppearance.BorderSize = 0;
            this.button_M1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_M1.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_M1.ForeColor = System.Drawing.Color.Lavender;
            this.button_M1.Location = new System.Drawing.Point(48, 40);
            this.button_M1.Name = "button_M1";
            this.button_M1.Size = new System.Drawing.Size(151, 30);
            this.button_M1.TabIndex = 2;
            this.button_M1.Text = "Покажи";
            this.button_M1.TextColor = System.Drawing.Color.Lavender;
            this.button_M1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.deletePractice);
            this.panel1.Controls.Add(this.addPractice);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.comboBox_M1);
            this.panel1.Controls.Add(this.button_M1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 512);
            this.panel1.TabIndex = 4;
            // 
            // deletePractice
            // 
            this.deletePractice.BackColor = System.Drawing.Color.RoyalBlue;
            this.deletePractice.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.deletePractice.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.deletePractice.BorderRadius = 0;
            this.deletePractice.BorderSize = 0;
            this.deletePractice.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.deletePractice.FlatAppearance.BorderSize = 0;
            this.deletePractice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletePractice.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePractice.ForeColor = System.Drawing.Color.Lavender;
            this.deletePractice.Location = new System.Drawing.Point(205, 454);
            this.deletePractice.Name = "deletePractice";
            this.deletePractice.Size = new System.Drawing.Size(151, 30);
            this.deletePractice.TabIndex = 19;
            this.deletePractice.Text = "Изтрий";
            this.deletePractice.TextColor = System.Drawing.Color.Lavender;
            this.deletePractice.UseVisualStyleBackColor = false;
            this.deletePractice.Click += new System.EventHandler(this.deletePractice_Click);
            // 
            // addPractice
            // 
            this.addPractice.BackColor = System.Drawing.Color.RoyalBlue;
            this.addPractice.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.addPractice.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addPractice.BorderRadius = 0;
            this.addPractice.BorderSize = 0;
            this.addPractice.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.addPractice.FlatAppearance.BorderSize = 0;
            this.addPractice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPractice.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPractice.ForeColor = System.Drawing.Color.Lavender;
            this.addPractice.Location = new System.Drawing.Point(48, 454);
            this.addPractice.Name = "addPractice";
            this.addPractice.Size = new System.Drawing.Size(151, 30);
            this.addPractice.TabIndex = 17;
            this.addPractice.Text = "Добави тренировка";
            this.addPractice.TextColor = System.Drawing.Color.Lavender;
            this.addPractice.UseVisualStyleBackColor = false;
            this.addPractice.Click += new System.EventHandler(this.addPractice_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(736, 334);
            this.dataGridView1.TabIndex = 5;
            // 
            // Timetable_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.panel1);
            this.Name = "Timetable_UserControl";
            this.Size = new System.Drawing.Size(851, 512);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private UI.ComboBox_M comboBox_M1;
        private UI.Button_M button_M1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private UI.Button_M deletePractice;
        private UI.Button_M addPractice;
    }
}
