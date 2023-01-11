namespace TheSurmanProject.Components {
    partial class SurveySum {
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
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.pboxThumbnail = new System.Windows.Forms.PictureBox();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxThumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(145, 20);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(76, 24);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "header";
            this.labelHeader.Click += new System.EventHandler(this.SurveySum_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labelUsername.Location = new System.Drawing.Point(434, 97);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelUsername.Size = new System.Drawing.Size(63, 15);
            this.labelUsername.TabIndex = 3;
            this.labelUsername.Text = "username";
            this.labelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelUsername.Click += new System.EventHandler(this.SurveySum_Click);
            // 
            // pboxThumbnail
            // 
            this.pboxThumbnail.Dock = System.Windows.Forms.DockStyle.Left;
            this.pboxThumbnail.Location = new System.Drawing.Point(20, 20);
            this.pboxThumbnail.Name = "pboxThumbnail";
            this.pboxThumbnail.Size = new System.Drawing.Size(94, 76);
            this.pboxThumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxThumbnail.TabIndex = 2;
            this.pboxThumbnail.TabStop = false;
            this.pboxThumbnail.Click += new System.EventHandler(this.SurveySum_Click);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCount.Location = new System.Drawing.Point(145, 44);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(81, 17);
            this.labelCount.TabIndex = 4;
            this.labelCount.Text = "0 questions";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(146, 83);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(91, 13);
            this.labelDate.TabIndex = 5;
            this.labelDate.Text = "01.01.2001 00:00";
            // 
            // SurveySum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.pboxThumbnail);
            this.Controls.Add(this.labelHeader);
            this.Name = "SurveySum";
            this.Padding = new System.Windows.Forms.Padding(20, 20, 0, 20);
            this.Size = new System.Drawing.Size(531, 116);
            this.Click += new System.EventHandler(this.SurveySum_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pboxThumbnail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.PictureBox pboxThumbnail;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelDate;
    }
}
