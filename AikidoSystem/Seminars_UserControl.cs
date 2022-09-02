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
    public partial class Seminars_UserControl : UserControl
    {
        private static Seminars_UserControl instance = null;

        public static Seminars_UserControl Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Seminars_UserControl();
                }
                return instance;
            }
        }
        public Seminars_UserControl()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

       
        private void editSeminar_Click(object sender, EventArgs e)
        {
            SeminarDetails seminar = new SeminarDetails("Редактиране на Семинар");
            seminar.Show();
        }

        private void deleteSeminar_Click(object sender, EventArgs e)
        {

        }

        private void addSeminar_Click(object sender, EventArgs e)
        {
            SeminarDetails seminar = new SeminarDetails("Въвеждане на Семинар");
            seminar.Show();
        }
    }
}
