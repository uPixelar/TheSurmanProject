
namespace TheSurmanProject.Pages {
    partial class Signup {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.signupButton = new System.Windows.Forms.Button();
            this.signupUsername = new System.Windows.Forms.TextBox();
            this.signupPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.signupConfirmPassword = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.yesAccount = new System.Windows.Forms.Label();
            this.showPassword = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // signupButton
            // 
            this.signupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.signupButton.Location = new System.Drawing.Point(8, 303);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(129, 39);
            this.signupButton.TabIndex = 1;
            this.signupButton.Text = "Sign-up";
            this.signupButton.UseVisualStyleBackColor = true;
            this.signupButton.Click += new System.EventHandler(this.signupButton_Click);
            // 
            // signupUsername
            // 
            this.signupUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.signupUsername.Location = new System.Drawing.Point(5, 76);
            this.signupUsername.Name = "signupUsername";
            this.signupUsername.Size = new System.Drawing.Size(222, 32);
            this.signupUsername.TabIndex = 2;
            // 
            // signupPassword
            // 
            this.signupPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.signupPassword.Location = new System.Drawing.Point(5, 150);
            this.signupPassword.Name = "signupPassword";
            this.signupPassword.PasswordChar = '*';
            this.signupPassword.Size = new System.Drawing.Size(222, 32);
            this.signupPassword.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(0, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(0, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(3, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Confirm Password";
            // 
            // signupConfirmPassword
            // 
            this.signupConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.signupConfirmPassword.Location = new System.Drawing.Point(5, 232);
            this.signupConfirmPassword.Name = "signupConfirmPassword";
            this.signupConfirmPassword.PasswordChar = '*';
            this.signupConfirmPassword.Size = new System.Drawing.Size(222, 32);
            this.signupConfirmPassword.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1343, 737);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.yesAccount);
            this.panel1.Controls.Add(this.showPassword);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.signupPassword);
            this.panel1.Controls.Add(this.signupUsername);
            this.panel1.Controls.Add(this.signupConfirmPassword);
            this.panel1.Controls.Add(this.signupButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(524, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 494);
            this.panel1.TabIndex = 0;
            // 
            // yesAccount
            // 
            this.yesAccount.AutoSize = true;
            this.yesAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yesAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yesAccount.Location = new System.Drawing.Point(5, 354);
            this.yesAccount.Name = "yesAccount";
            this.yesAccount.Size = new System.Drawing.Size(167, 13);
            this.yesAccount.TabIndex = 9;
            this.yesAccount.Text = "Already have an account? Log-in.";
            this.yesAccount.Click += new System.EventHandler(this.yesAccount_Click);
            // 
            // showPassword
            // 
            this.showPassword.AutoSize = true;
            this.showPassword.Location = new System.Drawing.Point(6, 270);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(107, 17);
            this.showPassword.TabIndex = 8;
            this.showPassword.Text = "Show Passwords";
            this.showPassword.UseVisualStyleBackColor = true;
            this.showPassword.CheckedChanged += new System.EventHandler(this.showPassword_CheckedChanged);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Signup";
            this.Size = new System.Drawing.Size(1343, 737);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button signupButton;
        private System.Windows.Forms.TextBox signupUsername;
        private System.Windows.Forms.TextBox signupPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox signupConfirmPassword;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox showPassword;
        private System.Windows.Forms.Label yesAccount;
    }
}
