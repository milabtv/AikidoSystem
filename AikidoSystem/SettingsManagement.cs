using AikidoSystem.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Hashing;

namespace AikidoSystem
{
    public partial class SettingsManagement : Form
    {
        private DatabaseManager databaseManager = new DatabaseManager();
        private int borderSize = 4;

        private string title;
        private string insBtn;
        private string editBtn;
        private string delBtn;
        private string labelName;
        private string labelDetails;
        private string labelQuery;
        private bool toggleView;
        private string status;

        public SettingsManagement()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.MidnightBlue;
            databaseManager = databaseManager.Instance;

        }

        public string Title { get => title; set => title = value; }
        public string InsBtn { get => insBtn; set => insBtn = value; }
        public string EditBtn { get => editBtn; set => editBtn = value; }
        public string DelBtn { get => delBtn; set => delBtn = value; }
        public string LabelName { get => labelName; set => labelName = value; }
        public string LabelDetails { get => labelDetails; set => labelDetails = value; }
        public string LabelQuery { get => labelQuery; set => labelQuery = value; }
        public bool ToggleView { get => toggleView; set => toggleView = value; }
        public string Status { get => status; set => status = value; }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SettingsManagement_Load(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.BackColor = Color.Lavender;
            dataGridView1.DefaultCellStyle.ForeColor = Color.MidnightBlue;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.MidnightBlue;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.CornflowerBlue;
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.CornflowerBlue;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.MidnightBlue;

            label15.Text = title;
            label1.Text = labelName;
            label3.Text = LabelDetails;
            label2.Text = LabelQuery;
            button_M3.Text = insBtn;
            button_M1.Text = editBtn;
            button_M2.Text = delBtn;
            if (toggleView) panel5.Visible = true;
            else panel5.Visible = false;
            label15.Left = (this.Width - label15.Width) / 2;
            switch (status)
            {
                case "account":
                    
                    DataTable dt = new DataTable();
                    dt = databaseManager.SelectAccounts();
                    dataGridView1.DataSource = dt;
                    break;
                case "payment":
                    
                    dt = databaseManager.SelectPaymentType();
                    dataGridView1.DataSource = dt;
                    break;
                case "hall":
                    
                    dt = databaseManager.SelectHalls();
                    dataGridView1.DataSource = dt;
                    break;
                case "levels":
                    
                    dt = databaseManager.SelectLevels();
                    dataGridView1.DataSource = dt;
                    break;
            }
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;


            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right
            if (m.Msg == WM_NCHITTEST)
            {
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)
                {
                    if ((int)m.Result == HTCLIENT)
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32());
                        Point clientPoint = this.PointToClient(screenPoint);
                        if (clientPoint.Y <= resizeAreaSize)
                        {
                            if (clientPoint.X <= resizeAreaSize)
                                m.Result = (IntPtr)HTTOPLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))
                                m.Result = (IntPtr)HTTOP;
                            else
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize))
                        {
                            if (clientPoint.X <= resizeAreaSize)
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))
                                m.Result = (IntPtr)HTBOTTOM;
                            else
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }

            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            base.WndProc(ref m);

        }

        private void Main_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(0, 8, 8, 0);
                    break;
                case FormWindowState.Normal:
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;

            }

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            databaseManager.Dispose();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void button_M3_Click(object sender, EventArgs e)
        {
            
            switch (status)
            {
                
                case "account":
                    DataTable dt = new DataTable();
                    bool flag = false;
                    Account account = new Account();
                     flag = true;
                    
                    account.Username = textBox_M1.Texts;
                    byte[] str = Encoding.Unicode.GetBytes(textBox_M2.Texts);
                    account.Password = XxHash64.Hash(str).ToString();
                    if (toggle1.Checked)
                        account.Access = "admin";
                    else account.Access = "trainer";
                    while (flag)
                    {
                        if (databaseManager.InsertAccount(account))
                        {
                            flag = false;
                            MessageBox.Show("Акаунта беше създаден");
                            dt = new DataTable();
                            dt = databaseManager.SelectAccounts();
                            dataGridView1.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("Акаунта НЕ беше създаден");
                            break;

                        }
                    }
                    

                    break;
                    
                case "payment":

                    PaymentType paymentType = new PaymentType();
                    flag = true;

                    paymentType.TypeName = textBox_M1.Texts;
                    
                    paymentType.Price = double.Parse(textBox_M2.Texts);
                    
                    while (flag)
                    {
                        if (databaseManager.InsertPaymentType(paymentType))
                        {
                            flag = false;
                            MessageBox.Show("Записа беше създаден");
                            dt = new DataTable();
                            dt = databaseManager.SelectPaymentType();
                            dataGridView1.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("Записа НЕ беше създаден");
                            break;

                        }
                    }
                   
                   
                    break;
                case "hall":
                    Hall hall = new Hall();
                    flag = true;

                    hall.Name = textBox_M1.Texts;
                    hall.Address = textBox_M2.Texts;

                   
                    while (flag)
                    {
                        if (databaseManager.InsertHalls(hall))
                        {
                            flag = false;
                            MessageBox.Show("Записа беше създаден");
                            dt = new DataTable();
                            dt = databaseManager.SelectHalls();
                            dataGridView1.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("Записа НЕ беше създаден");
                            break;

                        }
                    }
                    
                    break;
                case "levels":
                    KyuLevels level = new KyuLevels();
                    flag = true;

                    level.Name = textBox_M1.Texts;
                    level.LevelType = textBox_M2.Texts;

                    while (flag)
                    {
                        if (databaseManager.InsertLevels(level))
                        {
                            flag = false;
                            MessageBox.Show("Записа беше създаден"); 
                            dt = new DataTable();
                             dt = databaseManager.SelectLevels();
                            dataGridView1.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("Записа НЕ беше създаден");
                            break;

                        }
                    }
                   
                    
                    break;



            }
        }

        private void button_M1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            bool flag = false;
            switch (status)
            {
                
                case "account":
                    Account account1 = new Account();
                    Account account2 = new Account();
                    flag = true;

                    account1.Username = textBox_M1.Texts;
                    byte[] str = Encoding.Unicode.GetBytes(textBox_M2.Texts);
                    account1.Password = XxHash64.Hash(str).ToString();
                    if (toggle1.Checked)
                        account1.Access = "admin";
                    else account1.Access = "trainer";
                    account2.Username = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    
                    while (flag)
                    {
                        if (databaseManager.UpdateAccount(account1,account2))
                        {
                            flag = false;
                            MessageBox.Show("Записа беше обновен");
                        }
                        else
                        {
                            MessageBox.Show("Записа НЕ беше обновен");
                            break;

                        }
                    }                    
                    dt = databaseManager.SelectAccounts();
                    dataGridView1.DataSource = dt;
                    break;
                case "payment":
                    PaymentType paymentType = new PaymentType();
                    PaymentType pay = new PaymentType();
                    flag = true;

                    paymentType.TypeName = textBox_M1.Texts;
                    paymentType.Price = double.Parse(textBox_M2.Texts);
                    pay.TypeName = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                    while (flag)
                    {
                        if (databaseManager.UpdatePaymentType(paymentType, pay))
                        {
                            flag = false;
                            MessageBox.Show("Записа беше обновен");
                        }
                        else
                        {
                            MessageBox.Show("Записа НЕ беше обновен");
                            break;

                        }
                    }
                    dt = databaseManager.SelectPaymentType();
                    dataGridView1.DataSource = dt;
                    break;
                case "hall":
                    Hall hall = new Hall();
                    Hall h = new Hall();
                    flag = true;

                    hall.Name = textBox_M1.Texts;
                    hall.Address = textBox_M2.Texts;
                    h.Name = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                    while (flag)
                    {
                        if (databaseManager.UpdateHalls(hall, h))
                        {
                            flag = false;
                            MessageBox.Show("Записа беше обновен");
                        }
                        else
                        {
                            MessageBox.Show("Записа НЕ беше обновен");
                            break;

                        }
                    }
                    dt = databaseManager.SelectHalls();
                    dataGridView1.DataSource = dt;
                    break;
                case "levels":
                    KyuLevels level = new KyuLevels();
                    KyuLevels l = new KyuLevels();
                    flag = true;

                    level.Name = textBox_M1.Texts;
                    level.LevelType = textBox_M2.Texts;
                    l.Name = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                    while (flag)
                    {
                        if (databaseManager.UpdateLevels(level, l))
                        {
                            flag = false;
                            MessageBox.Show("Записа беше обновен");
                        }
                        else
                        {
                            MessageBox.Show("Записа НЕ беше обновен");
                            break;

                        }
                    }
                    dt = databaseManager.SelectLevels();
                    dataGridView1.DataSource = dt;
                    break;



            }
        }

        private void button_M2_Click(object sender, EventArgs e)
        {
            switch (status)
            {
                case "account":
                    Account account = new Account();
                    
                    account.Username = dataGridView1.CurrentRow.Cells[0].Value.ToString();                    
                    //byte[] str = Encoding.Unicode.GetBytes(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                    //account.Password = XxHash64.Hash(str).ToString();

                    if (databaseManager.DeleteAccount(account))
                    {
                        DataTable dt = new DataTable();
                        dt = databaseManager.SelectAccounts();
                        dataGridView1.DataSource = dt;
                    }
                    else MessageBox.Show("Акаунтът не е изтрит!");
                    

                    break;
                case "payment":
                    PaymentType payType = new PaymentType();

                    payType.TypeName = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    //byte[] str = Encoding.Unicode.GetBytes(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                    //account.Password = XxHash64.Hash(str).ToString();

                    if (databaseManager.DeletePaymentType(payType))
                    {
                        DataTable dt = new DataTable();
                        dt = databaseManager.SelectPaymentType();
                        dataGridView1.DataSource = dt;
                    }
                    else MessageBox.Show("Записът не е изтрит!");
                    
                    break;
                case "hall":
                    Hall hall = new Hall();

                    hall.Name = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    //byte[] str = Encoding.Unicode.GetBytes(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                    //account.Password = XxHash64.Hash(str).ToString();

                    if (databaseManager.DeleteHalls(hall))
                    {
                        DataTable dt = new DataTable();
                        dt = databaseManager.SelectHalls();
                        dataGridView1.DataSource = dt;
                    }
                    else MessageBox.Show("Записът не е изтрит!");
                    break;
                case "levels":
                    KyuLevels level = new KyuLevels();

                    level.Name = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    //byte[] str = Encoding.Unicode.GetBytes(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                    //account.Password = XxHash64.Hash(str).ToString();

                    if (databaseManager.DeleteLevels(level))
                    {
                        DataTable dt = new DataTable();
                        dt = databaseManager.SelectLevels();
                        dataGridView1.DataSource = dt;
                    }
                    else MessageBox.Show("Записът не е изтрит!");
                    break;



            }
        }
    }
}
