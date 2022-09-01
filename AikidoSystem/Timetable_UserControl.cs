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
    public partial class Timetable_UserControl : UserControl
    {
        private static Timetable_UserControl instance = null;

        public static Timetable_UserControl Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Timetable_UserControl();
                }
                return instance;
            }
        }
        public Timetable_UserControl()
        {
            InitializeComponent();
        }

        private void comboBox_M1_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addPractice_Click(object sender, EventArgs e)
        {

        }

        private void editPractice_Click(object sender, EventArgs e)
        {

        }

        private void deletePractice_Click(object sender, EventArgs e)
        {

        }
    }
}
