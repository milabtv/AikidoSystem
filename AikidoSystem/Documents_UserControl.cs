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
    public partial class Documents_UserControl : UserControl
    {
        private static Documents_UserControl instance = null;

        public static Documents_UserControl Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Documents_UserControl();
                }
                return instance;
            }
        }
        public Documents_UserControl()
        {
            InitializeComponent();
        }
    }
}
