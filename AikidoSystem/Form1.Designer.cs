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
            this.button_M1 = new AikidoSystem.UI.Button_M();
            this.SuspendLayout();
            // 
            // button_M1
            // 
            this.button_M1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button_M1.FlatAppearance.BorderSize = 0;
            this.button_M1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_M1.ForeColor = System.Drawing.Color.White;
            this.button_M1.Location = new System.Drawing.Point(403, 192);
            this.button_M1.Name = "button_M1";
            this.button_M1.Size = new System.Drawing.Size(150, 40);
            this.button_M1.TabIndex = 0;
            this.button_M1.Text = "button_M1";
            this.button_M1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_M1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UI.Button_M button_M1;
    }
}

