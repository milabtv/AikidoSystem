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

       

        private void editGroup_Click(object sender, EventArgs e)
        {
            GroupsDetails group = new GroupsDetails("Редактиране на група");
            group.Show();

        }

        private void addGroup_Click(object sender, EventArgs e)
        {
            GroupsDetails group = new GroupsDetails("Въвеждане на група");
            group.Show();
        }
    }
}
