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
    public partial class Home_UserControl : UserControl
    {
        private static Home_UserControl instance = null;

        public static Home_UserControl Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Home_UserControl();
                }
                return instance;
            }
        }
        public Home_UserControl()
        {
            InitializeComponent();
        }
    }
}
