namespace TheSurmanProject.Pages {
    partial class BrowseSurveys {
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
            this.surveytbPanel = new System.Windows.Forms.TableLayoutPanel();
            this.surveyPanel = new System.Windows.Forms.Panel();
            this.surveyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // surveytbPanel
            // 
            this.surveytbPanel.AutoSize = true;
            this.surveytbPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.surveytbPanel.ColumnCount = 1;
            this.surveytbPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.surveytbPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.surveytbPanel.Location = new System.Drawing.Point(0, 0);
            this.surveytbPanel.Name = "surveytbPanel";
            this.surveytbPanel.RowCount = 1;
            this.surveytbPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.surveytbPanel.Size = new System.Drawing.Size(890, 0);
            this.surveytbPanel.TabIndex = 0;
            // 
            // surveyPanel
            // 
            this.surveyPanel.AutoScroll = true;
            this.surveyPanel.Controls.Add(this.surveytbPanel);
            this.surveyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.surveyPanel.Location = new System.Drawing.Point(0, 0);
            this.surveyPanel.Name = "surveyPanel";
            this.surveyPanel.Size = new System.Drawing.Size(890, 642);
            this.surveyPanel.TabIndex = 0;
            // 
            // BrowseSurveys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.surveyPanel);
            this.Name = "BrowseSurveys";
            this.Size = new System.Drawing.Size(890, 642);
            this.surveyPanel.ResumeLayout(false);
            this.surveyPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel surveytbPanel;
        private System.Windows.Forms.Panel surveyPanel;
    }
}
