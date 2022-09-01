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
    public partial class Groups_UserControl : UserControl
    {
        private static Groups_UserControl instance = null;

        public static Groups_UserControl Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Groups_UserControl();
                }
                return instance;
            }
        }
        public Groups_UserControl()
        {
            InitializeComponent();
        }
    }
}
