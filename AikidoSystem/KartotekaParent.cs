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
    public partial class KartotekaParent : UserControl
    {
        public KartotekaParent()
        {
            InitializeComponent();
        }
        private static KartotekaParent instance = null;

        public static KartotekaParent Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new KartotekaParent();
                }
                return instance;
            }
        }
    }
}
