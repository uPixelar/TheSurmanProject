using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceLayer;

namespace TheSurmanProject.Pages {
    public partial class PageLogin : UserControl {
        public PageLogin() {
            InitializeComponent();
        }
        public EventHandler noAccountEvent;



        private void label3_Click(object sender, EventArgs e) {
            noAccountEvent(sender, e);
        }


        private void loginButton_Click(object sender, EventArgs e) {

            if (String.IsNullOrEmpty(loginUsername.Text) || String.IsNullOrEmpty(loginPassword.Text)) {
                MessageBox.Show("One or more of the text boxes are empty.");
                return;
            }
            bool result = UserSystem.Login(loginUsername.Text, loginPassword.Text);
            if (result) {
                userLoggedin(sender, e);
            } else MessageBox.Show("Username or password is incorrect.");
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e) {
            loginPassword.PasswordChar = showPassword.Checked ? '\0' : '*';
        }
        public EventHandler userLoggedin;
    }
}
