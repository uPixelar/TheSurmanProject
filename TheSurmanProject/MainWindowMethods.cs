//This file holds custom methods written

using DataAccess;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheSurmanProject.Pages;

namespace TheSurmanProject {
    partial class MainWindow {
        
        /// <summary>
        /// Fixes some ui materials with code
        /// </summary>
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

        /// <summary>
        /// Clears page section in main window
        /// </summary>
        public void ClearPage() {
            if (currentPage == null) return;
            currentPage = null;
            panelContent.Controls.Clear();
        }

        /// <summary>
        /// Opens usercontrol object in page section
        /// </summary>
        /// <param name="page">UserControl object</param>
        private void OpenPage(UserControl page) {
            if (currentPage != null && page.GetType() == currentPage.GetType()) return;

            ClearPage();

            page.Dock = DockStyle.Fill;
            page.BackColor = AppTheme.CurrentTheme.SecondaryColor;
            panelContent.Controls.Add(page);
            currentPage = page;
        }

        /// <summary>
        /// Initialize FillSurvey page with spesific survey id
        /// </summary>
        /// <param name="surveyId">Id of the survey to be filled</param>
        public void ViewSurvey(int surveyId) {
            OpenPage(new PageFillSurvey(surveyId));
        }

        /// <summary>
        /// This method applies current theme to the main window controls.
        /// </summary>
        private void ApplyTheme() {
            AppTheme theme = AppTheme.CurrentTheme;
            //Color1
            panelTitleBar.BackColor = theme.BaseColor;
            this.BackColor = theme.BaseColor;
            panelMenu.BackColor = theme.BaseColor;


            //Color2
            panelView.BackColor = theme.BackgroundColor;


            //Color3
            labelTitle.ForeColor = theme.BaseTextColor;
            btnClose.BackColor = theme.SecondaryColor;
            btnMaximize.BackColor = theme.SecondaryColor;
            btnMinimize.BackColor = theme.SecondaryColor;

            //Color4
            btnAdministration.BackColor = theme.MidColor;
            btnBrowseSurveys.BackColor = theme.MidColor;
            btnCreateSurvey.BackColor = theme.MidColor;
            btnLogin.BackColor = theme.MidColor;
            btnMySurveys.BackColor = theme.MidColor;
            btnNotifications.BackColor = theme.MidColor;
            btnProfile.BackColor = theme.MidColor;
            btnSettings.BackColor = theme.MidColor;
            if(currentPage!= null)
                currentPage.BackColor = theme.SecondaryColor;
        }

        /// <summary>
        /// This method changes mainwindow ui according to user group(guest/user/admin)
        /// </summary>
        private void BuildUserUI() {
            btnNotifications.Hide();//Yetişmedi

            if (!UserSystem.LoggedIn) {//Guest
                btnAdministration.Hide();
                btnProfile.Hide();
                btnCreateSurvey.Hide();
                btnMySurveys.Hide();
                btnLogin.Text = "Login";
                return;
            }

            tb_users user = UserSystem.CurrentUser;

            //Reset changes made for guest
            btnProfile.Show();
            btnCreateSurvey.Show();
            btnMySurveys.Show();
            btnAdministration.Show();
            btnLogin.Text = "Logout";

            //If user is not admin, hide admin button
            if (!UserSystem.IsAdmin)
                btnAdministration.Hide();

            btnProfile.Text = user.username;

        }
    }
}
