//This file holds custom methods written

using DataAccess;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheSurmanProject {
    partial class MainWindow {
        //UI fixes with coding
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

        //Apply the theme
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

        //UI fix for different user groups
        private void BuildUserUI() {
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
            if (!user.IsAdmin)
                btnAdministration.Hide();

            btnProfile.Text = user.username;

        }
    }
}
