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

namespace AikidoSystem
{
    public partial class Main : Form
    {
        private int borderSize = 4;
        public Main()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.MidnightBlue;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112,0xf012,0);
        }
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
                    this.Padding = new Padding(0,8,8,0);
                    break;
                case FormWindowState.Normal:
                    if(this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize); 
                    break;

            }
                
        }
        private void CollapseMenu()
        {
            if (this.panelMenu.Width > 150) //Collapse menu
            {
                panelMenu.Width = 100;
                //pictureBox1.Visible = false;
                btnMenu.Dock = DockStyle.Top;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            { //Expand menu
                panelMenu.Width = 173;
                //pictureBox1.Visible = true;
                btnMenu.Dock = DockStyle.None;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text =menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btvMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm.loginForm.ShowDialog();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (!panelDesktop.Controls.Contains(Home_UserControl.Instance))
            {
                panelDesktop.Controls.Add(Home_UserControl.Instance);
                Home_UserControl.Instance.Dock = DockStyle.Fill;
            }

            Home_UserControl.Instance.BringToFront();
            Home_UserControl.Instance.Focus();
            menuChange(btnHome);
            btnHome.BackColor = Color.RoyalBlue;
        }

        private void btnKartoteka_Click(object sender, EventArgs e)
        {
            if (!panelDesktop.Controls.Contains(Kartoteka_UserControl.Instance))
            {
                panelDesktop.Controls.Add(Kartoteka_UserControl.Instance);
                Kartoteka_UserControl.Instance.Dock = DockStyle.Fill;
            }

            Kartoteka_UserControl.Instance.BringToFront();
            Kartoteka_UserControl.Instance.Focus();
            menuChange(btnKartoteka);
            btnKartoteka.BackColor = Color.RoyalBlue;
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (!panelDesktop.Controls.Contains(Payment_UserControl.Instance))
            {
                panelDesktop.Controls.Add(Payment_UserControl.Instance);
                Payment_UserControl.Instance.Dock = DockStyle.Fill;
            }

            Payment_UserControl.Instance.BringToFront();
            Payment_UserControl.Instance.Focus();
            menuChange(btnPayment);
            btnPayment.BackColor = Color.RoyalBlue;
        }

        private void btnTimetable_Click(object sender, EventArgs e)
        {
            if (!panelDesktop.Controls.Contains(Timetable_UserControl.Instance))
            {
                panelDesktop.Controls.Add(Timetable_UserControl.Instance);
                Timetable_UserControl.Instance.Dock = DockStyle.Fill;
            }

            Timetable_UserControl.Instance.BringToFront();
            Timetable_UserControl.Instance.Focus();
            menuChange(btnTimetable);
            btnTimetable.BackColor = Color.RoyalBlue;
        }

        private void btnGroups_Click(object sender, EventArgs e)
        {
            if (!panelDesktop.Controls.Contains(Groups_UserControl.Instance))
            {
                panelDesktop.Controls.Add(Groups_UserControl.Instance);
                Groups_UserControl.Instance.Dock = DockStyle.Fill;
            }

            Groups_UserControl.Instance.BringToFront();
            Groups_UserControl.Instance.Focus();
            menuChange(btnGroups);
            btnGroups.BackColor = Color.RoyalBlue;
            
        }

        private void btnDocs_Click(object sender, EventArgs e)
        {
            if (!panelDesktop.Controls.Contains(Documents_UserControl.Instance))
            {
                panelDesktop.Controls.Add(Documents_UserControl.Instance);
                Documents_UserControl.Instance.Dock = DockStyle.Fill;
            }

            Documents_UserControl.Instance.BringToFront();
            Documents_UserControl.Instance.Focus();
            menuChange(btnDocs);
            btnDocs.BackColor = Color.RoyalBlue;
            

        }
        private void menuChange(Button btn)
        {
            foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
            {
                if(menuButton!= btn)
                menuButton.BackColor = Color.MidnightBlue;
            }


            System.GC.Collect();
        }
    }
}
