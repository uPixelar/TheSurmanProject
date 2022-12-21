using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceLayer;
using TheSurmanProject.Pages;

namespace TheSurmanProject {
    public partial class MainWindow : Form {
        //Fields
        private int borderSize = 2;
        private AppTheme theme = AppTheme.Themes.UPX;

        public MainWindow() {
            InitializeComponent();
            CodeFix();
            ApplyTheme();
            UserSystem userSystem = new UserSystem();
        }

        private void CodeFix() {
            //Config
            int menuButtonMargin = 5;

            //Common variables
            Control.ControlCollection controls;
            int to = 0;

            //Menu Top FlowLayout
            controls = flowMenuTop.Controls;
            to = controls.Count - 1;
            for (int i = 0; i < to; ++i) {
                controls[i].Margin = new Padding(0, 0, 0, menuButtonMargin);
            }

            //Menu Bottom FlowLayout
            controls = flowMenuBottom.Controls;
            to = controls.Count;
            for (int i = 1; i < to; ++i) {
                controls[i].Margin = new Padding(0, menuButtonMargin, 0, 0);
            }
        }

        private void ApplyTheme() {
            //Color1
            panelTitleBar.BackColor = theme.color1;
            this.BackColor = theme.color1;
            panelMenu.BackColor = theme.color1;


            //Color2
            panelView.BackColor = theme.color2;


            //Color3
            labelTitle.ForeColor = theme.color3;
            btnClose.BackColor = theme.color3;
            btnMaximize.BackColor = theme.color3;
            btnMinimize.BackColor = theme.color3;
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e) {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Overridden methods
        protected override void WndProc(ref Message m) {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;

            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right
            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>
            if (m.Msg == WM_NCHITTEST) { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          
                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        } else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                          {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        } else {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }

            //Remove border and title bar
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1) return;
            
            base.WndProc(ref m);
        }

        //Private methods
        private void AdjustForm() {
            switch (this.WindowState) {

                case FormWindowState.Maximized: //Maximized form (After)
                    this.Padding = new Padding(8, 8, 8, 0);
                    this.panelTitleBar.Padding = Padding.Empty;
                    break;

                case FormWindowState.Normal: //Restored form (After)
                    if (this.Padding.Top != borderSize) {
                        this.Padding = new Padding(borderSize);
                        this.panelTitleBar.Padding = new Padding(0, 0, 0, borderSize);
                    }
                    break;
            }
        }

        //Event methods
        private void btnClose_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void MainWindow_Resize(object sender, EventArgs e) {
            AdjustForm();
        }

        private void btnMinimize_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e) {
            if (this.WindowState == FormWindowState.Normal) {
                this.WindowState = FormWindowState.Maximized;
            } else {
                this.WindowState = FormWindowState.Normal;
                if (Location.Y < 0) Location = new Point(Location.X, 0);
            }
        }

        private void btnBrowseSurveys_Click(object sender, EventArgs e) {
            panelContent.Controls.Clear();
            Control page = new BrowseSurveys();
            page.Dock = DockStyle.Fill;
            page.BackColor = theme.color3;
            panelContent.Controls.Add(page);
        }

        private void btnMySurveys_Click(object sender, EventArgs e) {
            panelContent.Controls.Clear();
            Control page = new MySurveys();
            page.Dock = DockStyle.Fill;
            page.BackColor = theme.color3;
            panelContent.Controls.Add(page);
        }
    }
}