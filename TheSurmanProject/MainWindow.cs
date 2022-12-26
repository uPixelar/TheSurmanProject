//This file holds winforms events and some configs

using System;
using System.Drawing;
using System.Windows.Forms;
using TheSurmanProject.Pages;

using ServiceLayer;

namespace TheSurmanProject {
    public partial class MainWindow : Form {
        
        private AppTheme theme = AppTheme.Themes.UPX;

        public MainWindow() {
            InitializeComponent();
            UserSystem.LoadUser();

            // [MainWindowMethods.cs]
            CodeFix();
            ApplyTheme();
            BuildUserUI();
        }

        private void MainWindow_Resize(object sender, EventArgs e) {
            AdjustForm();
        }

        #region Title Buttons
        private void btnClose_Click(object sender, EventArgs e) {
            Application.Exit();
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
        #endregion

        #region Menu Buttons
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

        private void btnLogin_Click(object sender, EventArgs e) {
            if (UserSystem.LoggedIn) {
                UserSystem.Logout();
                BuildUserUI();
            }
        }
        #endregion
    }
}