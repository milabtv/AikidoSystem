using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AikidoSystem
{
    public partial class Payment_UserControl : UserControl
    {
        private static Payment_UserControl instance = null;

        public static Payment_UserControl Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Payment_UserControl();
                }
                return instance;
            }
        }
        public Payment_UserControl()
        {
            InitializeComponent();
            
        }
               
        private void addPayment_Click_1(object sender, EventArgs e)
        {
            Payment payment = new Payment("Добавяне на членски внос");
            payment.State = "add";
            payment.Show();
            
        }

        private void editPayment_Click_1(object sender, EventArgs e)
        {
            Payment payment = new Payment("Редактиране на членски внос");
            payment.State = "edit";
            payment.Show();
        }

        private void deletePayment_Click_1(object sender, EventArgs e)
        {

        }

        private void showKartoteka_Click(object sender, EventArgs e)
        {

        }

        private void Payment_UserControl_Load(object sender, EventArgs e)
        {
            DatabaseManager database = new DatabaseManager();
            database = database.Instance;

            DataTable dt = database.SelectPayment(textBox_M1.Texts);
        }
    }
}
