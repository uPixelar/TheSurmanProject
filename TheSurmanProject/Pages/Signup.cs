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
    public partial class Signup : UserControl {
        public Signup() {
            InitializeComponent();
        }
        public EventHandler yesAccountEvent;

        private void yesAccount_Click(object sender, EventArgs e) {
            yesAccountEvent.Invoke(sender, e);
        }

        private void signupButton_Click(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(signupUsername.Text) || String.IsNullOrEmpty(signupPassword.Text) || String.IsNullOrEmpty(signupConfirmPassword.Text)) {
                MessageBox.Show("One or more of the text boxes are empty.");
                return;
            }
            if (signupPassword.Text != signupConfirmPassword.Text) {
                MessageBox.Show("Password is not the same as the confirmation.");
                return;
            }
            bool result = UserSystem.Register(signupUsername.Text, signupPassword.Text);
            if (result) {
                userLoggedin(sender, e);
            } else MessageBox.Show("Account could not register.");

        }

        private void showPassword_CheckedChanged(object sender, EventArgs e) {
            signupPassword.PasswordChar = showPassword.Checked ? '\0' : '*';
            signupConfirmPassword.PasswordChar = showPassword.Checked ? '\0' : '*';
        }

        public EventHandler userLoggedin;


    }
}
