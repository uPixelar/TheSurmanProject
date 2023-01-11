namespace TheSurmanProject.Pages {
    partial class PageSettings {
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
            this.gboxTheme = new System.Windows.Forms.GroupBox();
            this.panelThemes = new System.Windows.Forms.FlowLayoutPanel();
            this.gboxLanguage = new System.Windows.Forms.GroupBox();
            this.panelLanguages = new System.Windows.Forms.FlowLayoutPanel();
            this.gboxTheme.SuspendLayout();
            this.gboxLanguage.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxTheme
            // 
            this.gboxTheme.AutoSize = true;
            this.gboxTheme.Controls.Add(this.panelThemes);
            this.gboxTheme.Dock = System.Windows.Forms.DockStyle.Top;
            this.gboxTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxTheme.Location = new System.Drawing.Point(0, 0);
            this.gboxTheme.Name = "gboxTheme";
            this.gboxTheme.Size = new System.Drawing.Size(945, 25);
            this.gboxTheme.TabIndex = 0;
            this.gboxTheme.TabStop = false;
            this.gboxTheme.Text = "Theme";
            // 
            // panelThemes
            // 
            this.panelThemes.AutoScroll = true;
            this.panelThemes.AutoSize = true;
            this.panelThemes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelThemes.Location = new System.Drawing.Point(3, 22);
            this.panelThemes.Name = "panelThemes";
            this.panelThemes.Size = new System.Drawing.Size(939, 0);
            this.panelThemes.TabIndex = 0;
            // 
            // gboxLanguage
            // 
            this.gboxLanguage.Controls.Add(this.panelLanguages);
            this.gboxLanguage.Dock = System.Windows.Forms.DockStyle.Top;
            this.gboxLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxLanguage.Location = new System.Drawing.Point(0, 25);
            this.gboxLanguage.Name = "gboxLanguage";
            this.gboxLanguage.Size = new System.Drawing.Size(945, 148);
            this.gboxLanguage.TabIndex = 1;
            this.gboxLanguage.TabStop = false;
            this.gboxLanguage.Text = "Language";
            // 
            // panelLanguages
            // 
            this.panelLanguages.AutoScroll = true;
            this.panelLanguages.AutoSize = true;
            this.panelLanguages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLanguages.Location = new System.Drawing.Point(3, 22);
            this.panelLanguages.Name = "panelLanguages";
            this.panelLanguages.Size = new System.Drawing.Size(939, 123);
            this.panelLanguages.TabIndex = 1;
            // 
            // PageSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.gboxLanguage);
            this.Controls.Add(this.gboxTheme);
            this.Name = "PageSettings";
            this.Size = new System.Drawing.Size(945, 680);
            this.gboxTheme.ResumeLayout(false);
            this.gboxTheme.PerformLayout();
            this.gboxLanguage.ResumeLayout(false);
            this.gboxLanguage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxTheme;
        private System.Windows.Forms.FlowLayoutPanel panelThemes;
        private System.Windows.Forms.GroupBox gboxLanguage;
        private System.Windows.Forms.FlowLayoutPanel panelLanguages;
    }
}
