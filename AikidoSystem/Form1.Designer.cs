namespace AikidoSystem
{
    partial class Form1
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
            this.button_M2 = new AikidoSystem.UI.Button_M();
            this.dateTimePicker_M1 = new AikidoSystem.UI.DateTimePicker_M();
            this.SuspendLayout();
            // 
            // button_M2
            // 
            this.button_M2.BackColor = System.Drawing.Color.Transparent;
            this.button_M2.BackgroundColor = System.Drawing.Color.Transparent;
            this.button_M2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.button_M2.BorderRadius = 0;
            this.button_M2.BorderSize = 3;
            this.button_M2.FlatAppearance.BorderSize = 0;
            this.button_M2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_M2.ForeColor = System.Drawing.Color.Black;
            this.button_M2.Location = new System.Drawing.Point(299, 173);
            this.button_M2.Name = "button_M2";
            this.button_M2.Size = new System.Drawing.Size(150, 40);
            this.button_M2.TabIndex = 1;
            this.button_M2.Text = "button_M2";
            this.button_M2.TextColor = System.Drawing.Color.Black;
            this.button_M2.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker_M1
            // 
            this.dateTimePicker_M1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dateTimePicker_M1.BorderSize = 0;
            this.dateTimePicker_M1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dateTimePicker_M1.Location = new System.Drawing.Point(248, 90);
            this.dateTimePicker_M1.MinimumSize = new System.Drawing.Size(0, 35);
            this.dateTimePicker_M1.Name = "dateTimePicker_M1";
            this.dateTimePicker_M1.Size = new System.Drawing.Size(200, 35);
            this.dateTimePicker_M1.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.dateTimePicker_M1.TabIndex = 2;
            this.dateTimePicker_M1.TextColor = System.Drawing.Color.White;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker_M1);
            this.Controls.Add(this.button_M2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UI.Button_M button_M2;
        private UI.DateTimePicker_M dateTimePicker_M1;
    }
}

