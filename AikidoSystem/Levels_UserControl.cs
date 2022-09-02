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
    public partial class Levels_UserControl : UserControl
    {
        private static Levels_UserControl instance = null;

        public static Levels_UserControl Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Levels_UserControl();
                }
                return instance;
            }
        }
        public Levels_UserControl()
        {
            InitializeComponent();
        }

        private void addExam_Click(object sender, EventArgs e)
        {
            Exams exam = new Exams("Въвеждане на изпити");
            exam.Show();
        }

        private void editExam_Click(object sender, EventArgs e)
        {
            Exams exam = new Exams("Редактиране на изпити");
            exam.Show();
        }
    }
}
