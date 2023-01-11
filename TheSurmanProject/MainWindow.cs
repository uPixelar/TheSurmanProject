//This file holds winforms events and some configs

using System;
using System.Drawing;
using System.Windows.Forms;
using TheSurmanProject.Pages;
using ServiceLayer;
using TheSurmanProject.Components;

namespace TheSurmanProject {
    public partial class MainWindow : Form {
        /// <summary>
        /// Object that holds current page open.
        /// </summary>
        private UserControl currentPage;

        /// <summary>
        /// Entry point of main window
        /// </summary>
        public MainWindow() {
            InitializeComponent();
            AppTheme.ThemeChanged += Theme_Changed;

            UserSystem.LoadUser();
            AppTheme.LoadTheme();
            
            // [MainWindowMethods.cs]
            CodeFix();
            BuildUserUI();
        }
        
        #region Title Bar Buttons
        /// <summary>
        /// Event listening for close button
        /// </summary>
        private void btnClose_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        /// <summary>
        /// Event listening for minimize button
        /// </summary>
        private void btnMinimize_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Event listening for maximize button
        /// </summary>
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

        /// <summary>
        /// Event listening for browse surveys button click
        /// </summary>
        private void btnBrowseSurveys_Click(object sender, EventArgs e) {
            BrowseSurveys page = new BrowseSurveys();
            page.SurveyClick += Survey_Clicked;
            OpenPage(page);
        }

        /// <summary>
        /// Event listening for my survey button click
        /// </summary>
        private void btnMySurveys_Click(object sender, EventArgs e) {
            OpenPage(new MySurveys());
        }

        /// <summary>
        /// Event listening for login/logout button click
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e) {
            if (UserSystem.LoggedIn) {
                UserSystem.Logout();
                BuildUserUI();
                return;
            }
            PageLogin page = new PageLogin();
            page.userLoggedin += userLoggedin;
            page.noAccountEvent += noaccount_Click;
            OpenPage(page);

        }

        /// <summary>
        /// Event listening for settings button click
        /// </summary>
        private void btnSettings_Click(object sender, EventArgs e) {
            OpenPage(new PageSettings());
        }

        /// <summary>
        /// Event listening for create survey button click
        /// </summary>
        private void btnCreateSurvey_Click(object sender, EventArgs e) {
            OpenPage(new PageCreateSurvey());
        }
        #endregion

        /// <summary>
        /// Event listening for no account label click
        /// </summary>
        private void noaccount_Click(object sender, EventArgs e) {
            Signup page = new Signup();
            page.userLoggedin += userLoggedin;
            page.yesAccountEvent += btnLogin_Click;
            OpenPage(page);

        }

        /// <summary>
        /// Event listening for login event in login/register form
        /// </summary>
        private void userLoggedin(object sender, EventArgs e) {
            ClearPage();
            BuildUserUI();
        }

        /// <summary>
        /// Event listening for survey click in Browse Surveys page
        /// </summary>
        private void Survey_Clicked(object sender, EventArgs e) {
            if (!UserSystem.LoggedIn) {
                MessageBox.Show("Please login to fill surveys and create your owns!", "Login Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SurveySum sum = (SurveySum)sender;

            PageFillSurvey page = new PageFillSurvey(sum.survey.surveyId);
            OpenPage(page);
        }

        /// <summary>
        /// Event listening for theme changes, applies new theme to the main window when triggered.
        /// </summary>
        private void Theme_Changed(object sender, AppTheme _theme) {
            ApplyTheme();
        }
    }
}