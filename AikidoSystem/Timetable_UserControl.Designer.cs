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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox_M1 = new AikidoSystem.UI.ComboBox_M();
            this.button_M1 = new AikidoSystem.UI.Button_M();
            this.button_M2 = new AikidoSystem.UI.Button_M();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(69, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(703, 362);
            this.dataGridView1.TabIndex = 0;
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
            this.comboBox_M1.Location = new System.Drawing.Point(470, 41);
            this.comboBox_M1.MinimumSize = new System.Drawing.Size(200, 30);
            this.comboBox_M1.Name = "comboBox_M1";
            this.comboBox_M1.Padding = new System.Windows.Forms.Padding(2);
            this.comboBox_M1.Size = new System.Drawing.Size(302, 30);
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
            this.button_M1.Location = new System.Drawing.Point(69, 41);
            this.button_M1.Name = "button_M1";
            this.button_M1.Size = new System.Drawing.Size(151, 30);
            this.button_M1.TabIndex = 2;
            this.button_M1.Text = "Покажи";
            this.button_M1.TextColor = System.Drawing.Color.Lavender;
            this.button_M1.UseVisualStyleBackColor = false;
            // 
            // button_M2
            // 
            this.button_M2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_M2.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.button_M2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.button_M2.BorderRadius = 0;
            this.button_M2.BorderSize = 0;
            this.button_M2.FlatAppearance.BorderSize = 0;
            this.button_M2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_M2.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_M2.ForeColor = System.Drawing.Color.Lavender;
            this.button_M2.Location = new System.Drawing.Point(263, 41);
            this.button_M2.Name = "button_M2";
            this.button_M2.Size = new System.Drawing.Size(151, 30);
            this.button_M2.TabIndex = 3;
            this.button_M2.Text = "Притирай";
            this.button_M2.TextColor = System.Drawing.Color.Lavender;
            this.button_M2.UseVisualStyleBackColor = false;
            // 
            // Timetable_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.button_M2);
            this.Controls.Add(this.button_M1);
            this.Controls.Add(this.comboBox_M1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Timetable_UserControl";
            this.Size = new System.Drawing.Size(851, 512);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private UI.ComboBox_M comboBox_M1;
        private UI.Button_M button_M1;
        private UI.Button_M button_M2;
    }
}
