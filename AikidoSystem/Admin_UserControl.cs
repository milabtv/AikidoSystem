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
    public partial class Admin_UserControl : UserControl
    {
        private static Admin_UserControl instance = null;

        public static Admin_UserControl Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Admin_UserControl();
                }
                return instance;
            }
        }
        public Admin_UserControl()
        {
            InitializeComponent();
        }

        private void acountSettings_Click(object sender, EventArgs e)
        {
            SettingsManagement frm = new SettingsManagement();
            frm.Title = "Акаунти на клуба";
            frm.InsBtn = "Регистрирай нов";
            frm.EditBtn = "Редактирай";
            frm.DelBtn = "Изтрий";
            frm.LabelName = "Потребителско име";
            frm.LabelDetails = "Парола";
            frm.LabelQuery = "Акаунти в системата";
            frm.ToggleView = true;
            frm.Status = "account";
            frm.Show();
            
        }

        private void paymentSettings_Click(object sender, EventArgs e)
        {
            SettingsManagement frm = new SettingsManagement();
            frm.Title = "Видове членски внос";
            frm.InsBtn = "Добави нов";
            frm.EditBtn = "Редактирай";
            frm.DelBtn = "Изтрий";
            frm.LabelName = "Вид на членския внос";
            frm.LabelDetails = "Сума";
            frm.LabelQuery = "Въведени в системата";
            frm.ToggleView = false;
            frm.Status = "payment";
            frm.Show();

        }

        private void hallSettings_Click(object sender, EventArgs e)
        {
            SettingsManagement frm = new SettingsManagement();
            frm.Title = "Зали на клуба";
            frm.InsBtn = "Въведи нова";
            frm.EditBtn = "Редактирай";
            frm.DelBtn = "Изтрии";
            frm.LabelName = "Име на залата";
            frm.LabelDetails = "Адрес на залата";
            frm.LabelQuery = "Зали въведени в системата";
            frm.ToggleView = false;
            frm.Status = "hall";
            frm.Show();

        }

        private void levelSettings_Click(object sender, EventArgs e)
        {
            SettingsManagement frm = new SettingsManagement();
            frm.Title = "Степени";
            frm.InsBtn = "Въведи нова";
            frm.EditBtn = "Редактирай";
            frm.DelBtn = "Изтрий";
            frm.LabelName = "Име на степента";
            frm.LabelDetails = "Тип на степента";
            frm.LabelQuery = "Степени в системата";
            frm.ToggleView = false;
            frm.Status = "levels";
            frm.Show();
        }
    }
}
