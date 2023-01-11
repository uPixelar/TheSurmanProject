namespace TheSurmanProject {
    partial class MainWindow {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.flowMenuTop = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMySurveys = new System.Windows.Forms.Button();
            this.btnCreateSurvey = new System.Windows.Forms.Button();
            this.btnBrowseSurveys = new System.Windows.Forms.Button();
            this.btnAdministration = new System.Windows.Forms.Button();
            this.flowMenuBottom = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNotifications = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panelView = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.flowMenuTop.SuspendLayout();
            this.flowMenuBottom.SuspendLayout();
            this.panelView.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(284, 30);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.panelContent.Size = new System.Drawing.Size(911, 610);
            this.panelContent.TabIndex = 2;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(111)))), ((int)(((byte)(140)))));
            this.panelMenu.Controls.Add(this.flowMenuTop);
            this.panelMenu.Controls.Add(this.flowMenuBottom);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(30, 30);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.panelMenu.Size = new System.Drawing.Size(254, 610);
            this.panelMenu.TabIndex = 1;
            // 
            // flowMenuTop
            // 
            this.flowMenuTop.AutoSize = true;
            this.flowMenuTop.Controls.Add(this.btnMySurveys);
            this.flowMenuTop.Controls.Add(this.btnCreateSurvey);
            this.flowMenuTop.Controls.Add(this.btnBrowseSurveys);
            this.flowMenuTop.Controls.Add(this.btnAdministration);
            this.flowMenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowMenuTop.Location = new System.Drawing.Point(10, 20);
            this.flowMenuTop.Name = "flowMenuTop";
            this.flowMenuTop.Size = new System.Drawing.Size(234, 212);
            this.flowMenuTop.TabIndex = 0;
            // 
            // btnMySurveys
            // 
            this.btnMySurveys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnMySurveys.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMySurveys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMySurveys.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMySurveys.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.btnMySurveys.Location = new System.Drawing.Point(0, 0);
            this.btnMySurveys.Margin = new System.Windows.Forms.Padding(0);
            this.btnMySurveys.Name = "btnMySurveys";
            this.btnMySurveys.Size = new System.Drawing.Size(234, 53);
            this.btnMySurveys.TabIndex = 3;
            this.btnMySurveys.Text = "My Surveys";
            this.btnMySurveys.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMySurveys.UseVisualStyleBackColor = false;
            this.btnMySurveys.Click += new System.EventHandler(this.btnMySurveys_Click);
            // 
            // btnCreateSurvey
            // 
            this.btnCreateSurvey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnCreateSurvey.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCreateSurvey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateSurvey.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateSurvey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.btnCreateSurvey.Location = new System.Drawing.Point(0, 53);
            this.btnCreateSurvey.Margin = new System.Windows.Forms.Padding(0);
            this.btnCreateSurvey.Name = "btnCreateSurvey";
            this.btnCreateSurvey.Size = new System.Drawing.Size(234, 53);
            this.btnCreateSurvey.TabIndex = 4;
            this.btnCreateSurvey.Text = "Create a Survey";
            this.btnCreateSurvey.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateSurvey.UseVisualStyleBackColor = false;
            this.btnCreateSurvey.Click += new System.EventHandler(this.btnCreateSurvey_Click);
            // 
            // btnBrowseSurveys
            // 
            this.btnBrowseSurveys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnBrowseSurveys.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBrowseSurveys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseSurveys.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseSurveys.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.btnBrowseSurveys.Location = new System.Drawing.Point(0, 106);
            this.btnBrowseSurveys.Margin = new System.Windows.Forms.Padding(0);
            this.btnBrowseSurveys.Name = "btnBrowseSurveys";
            this.btnBrowseSurveys.Size = new System.Drawing.Size(234, 53);
            this.btnBrowseSurveys.TabIndex = 5;
            this.btnBrowseSurveys.Text = "Browse Surveys";
            this.btnBrowseSurveys.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowseSurveys.UseVisualStyleBackColor = false;
            this.btnBrowseSurveys.Click += new System.EventHandler(this.btnBrowseSurveys_Click);
            // 
            // btnAdministration
            // 
            this.btnAdministration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnAdministration.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdministration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministration.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.btnAdministration.Location = new System.Drawing.Point(0, 159);
            this.btnAdministration.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdministration.Name = "btnAdministration";
            this.btnAdministration.Size = new System.Drawing.Size(234, 53);
            this.btnAdministration.TabIndex = 6;
            this.btnAdministration.Text = "Administration";
            this.btnAdministration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdministration.UseVisualStyleBackColor = false;
            // 
            // flowMenuBottom
            // 
            this.flowMenuBottom.AutoSize = true;
            this.flowMenuBottom.Controls.Add(this.btnNotifications);
            this.flowMenuBottom.Controls.Add(this.btnProfile);
            this.flowMenuBottom.Controls.Add(this.btnSettings);
            this.flowMenuBottom.Controls.Add(this.btnLogin);
            this.flowMenuBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowMenuBottom.Location = new System.Drawing.Point(10, 378);
            this.flowMenuBottom.Name = "flowMenuBottom";
            this.flowMenuBottom.Size = new System.Drawing.Size(234, 212);
            this.flowMenuBottom.TabIndex = 1;
            // 
            // btnNotifications
            // 
            this.btnNotifications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnNotifications.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotifications.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.btnNotifications.Location = new System.Drawing.Point(0, 0);
            this.btnNotifications.Margin = new System.Windows.Forms.Padding(0);
            this.btnNotifications.Name = "btnNotifications";
            this.btnNotifications.Size = new System.Drawing.Size(234, 53);
            this.btnNotifications.TabIndex = 4;
            this.btnNotifications.Text = "Notifications";
            this.btnNotifications.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotifications.UseVisualStyleBackColor = false;
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnProfile.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.btnProfile.Location = new System.Drawing.Point(0, 53);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(0);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(234, 53);
            this.btnProfile.TabIndex = 5;
            this.btnProfile.Text = "undefined";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.UseVisualStyleBackColor = false;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.btnSettings.Location = new System.Drawing.Point(0, 106);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(234, 53);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.btnLogin.Location = new System.Drawing.Point(0, 159);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(234, 53);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Log Out";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panelView
            // 
            this.panelView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panelView.Controls.Add(this.panelContent);
            this.panelView.Controls.Add(this.panelMenu);
            this.panelView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelView.Location = new System.Drawing.Point(0, 20);
            this.panelView.Name = "panelView";
            this.panelView.Padding = new System.Windows.Forms.Padding(30);
            this.panelView.Size = new System.Drawing.Size(1225, 670);
            this.panelView.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Location = new System.Drawing.Point(1205, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 18);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaximize.BackgroundImage")));
            this.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.Location = new System.Drawing.Point(1185, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(20, 18);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.BackgroundImage")));
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.Location = new System.Drawing.Point(1165, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 18);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(3, -1);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(79, 18);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "SURMAN";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(111)))), ((int)(((byte)(140)))));
            this.panelTitleBar.Controls.Add(this.labelTitle);
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.panelTitleBar.Size = new System.Drawing.Size(1225, 20);
            this.panelTitleBar.TabIndex = 0;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 690);
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.panelTitleBar);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.flowMenuTop.ResumeLayout(false);
            this.flowMenuBottom.ResumeLayout(false);
            this.panelView.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.FlowLayoutPanel flowMenuTop;
        private System.Windows.Forms.Button btnMySurveys;
        private System.Windows.Forms.Button btnCreateSurvey;
        private System.Windows.Forms.Button btnBrowseSurveys;
        private System.Windows.Forms.Button btnAdministration;
        private System.Windows.Forms.FlowLayoutPanel flowMenuBottom;
        private System.Windows.Forms.Button btnNotifications;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelTitleBar;
    }
}

