namespace TheSurmanProject.Components {
    partial class QuestionSet {
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
            this.labelQuestion = new System.Windows.Forms.Label();
            this.panelAnswers = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // labelQuestion
            // 
            this.labelQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestion.Location = new System.Drawing.Point(0, 0);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.labelQuestion.Size = new System.Drawing.Size(801, 31);
            this.labelQuestion.TabIndex = 0;
            this.labelQuestion.Text = "The Question";
            this.labelQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelAnswers
            // 
            this.panelAnswers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAnswers.Location = new System.Drawing.Point(0, 31);
            this.panelAnswers.Name = "panelAnswers";
            this.panelAnswers.Padding = new System.Windows.Forms.Padding(10);
            this.panelAnswers.Size = new System.Drawing.Size(801, 441);
            this.panelAnswers.TabIndex = 1;
            // 
            // QuestionSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelAnswers);
            this.Controls.Add(this.labelQuestion);
            this.Name = "QuestionSet";
            this.Size = new System.Drawing.Size(801, 472);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Panel panelAnswers;
    }
}
