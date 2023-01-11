namespace TheSurmanProject.Pages {
    partial class PageCreateSurvey {
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
            this.lbxQuestions = new System.Windows.Forms.ListBox();
            this.btnQuestionAdd = new System.Windows.Forms.Button();
            this.btnQuestionRemove = new System.Windows.Forms.Button();
            this.btnAnswerRemove = new System.Windows.Forms.Button();
            this.labelSelectedQuestion = new System.Windows.Forms.Label();
            this.txtboxAnswer = new System.Windows.Forms.TextBox();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.txtboxQuestion = new System.Windows.Forms.TextBox();
            this.lbxAnswers = new System.Windows.Forms.ListBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAnswerAdd = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.txtbSurveyTitle = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxQuestions
            // 
            this.lbxQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxQuestions.FormattingEnabled = true;
            this.lbxQuestions.Location = new System.Drawing.Point(3, 122);
            this.lbxQuestions.Name = "lbxQuestions";
            this.lbxQuestions.Size = new System.Drawing.Size(395, 471);
            this.lbxQuestions.TabIndex = 0;
            this.lbxQuestions.SelectedIndexChanged += new System.EventHandler(this.lbxQuestions_SelectedIndexChanged);
            // 
            // btnQuestionAdd
            // 
            this.btnQuestionAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQuestionAdd.Location = new System.Drawing.Point(51, 17);
            this.btnQuestionAdd.Name = "btnQuestionAdd";
            this.btnQuestionAdd.Size = new System.Drawing.Size(64, 21);
            this.btnQuestionAdd.TabIndex = 3;
            this.btnQuestionAdd.Text = "Add";
            this.btnQuestionAdd.UseVisualStyleBackColor = true;
            this.btnQuestionAdd.Click += new System.EventHandler(this.btnQuestionAdd_Click);
            // 
            // btnQuestionRemove
            // 
            this.btnQuestionRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQuestionRemove.Location = new System.Drawing.Point(51, 73);
            this.btnQuestionRemove.Name = "btnQuestionRemove";
            this.btnQuestionRemove.Size = new System.Drawing.Size(64, 23);
            this.btnQuestionRemove.TabIndex = 4;
            this.btnQuestionRemove.Text = "Remove";
            this.btnQuestionRemove.UseVisualStyleBackColor = true;
            this.btnQuestionRemove.Click += new System.EventHandler(this.btnQuestionRemove_Click);
            // 
            // btnAnswerRemove
            // 
            this.btnAnswerRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAnswerRemove.Location = new System.Drawing.Point(53, 73);
            this.btnAnswerRemove.Name = "btnAnswerRemove";
            this.btnAnswerRemove.Size = new System.Drawing.Size(59, 23);
            this.btnAnswerRemove.TabIndex = 5;
            this.btnAnswerRemove.Text = "Remove";
            this.btnAnswerRemove.UseVisualStyleBackColor = true;
            this.btnAnswerRemove.Click += new System.EventHandler(this.btnAnswerRemove_Click);
            // 
            // labelSelectedQuestion
            // 
            this.labelSelectedQuestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSelectedQuestion.AutoSize = true;
            this.labelSelectedQuestion.Location = new System.Drawing.Point(174, 21);
            this.labelSelectedQuestion.Name = "labelSelectedQuestion";
            this.labelSelectedQuestion.Size = new System.Drawing.Size(47, 13);
            this.labelSelectedQuestion.TabIndex = 7;
            this.labelSelectedQuestion.Text = "Answers";
            // 
            // txtboxAnswer
            // 
            this.txtboxAnswer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxAnswer.Location = new System.Drawing.Point(76, 74);
            this.txtboxAnswer.Name = "txtboxAnswer";
            this.txtboxAnswer.Size = new System.Drawing.Size(242, 20);
            this.txtboxAnswer.TabIndex = 9;
            // 
            // labelQuestion
            // 
            this.labelQuestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(170, 21);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(54, 13);
            this.labelQuestion.TabIndex = 2;
            this.labelQuestion.Text = "Questions";
            // 
            // txtboxQuestion
            // 
            this.txtboxQuestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxQuestion.Location = new System.Drawing.Point(57, 74);
            this.txtboxQuestion.Name = "txtboxQuestion";
            this.txtboxQuestion.Size = new System.Drawing.Size(281, 20);
            this.txtboxQuestion.TabIndex = 11;
            // 
            // lbxAnswers
            // 
            this.lbxAnswers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxAnswers.FormattingEnabled = true;
            this.lbxAnswers.Location = new System.Drawing.Point(3, 122);
            this.lbxAnswers.Name = "lbxAnswers";
            this.lbxAnswers.Size = new System.Drawing.Size(395, 471);
            this.lbxAnswers.TabIndex = 12;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreate.Location = new System.Drawing.Point(1161, 616);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(123, 38);
            this.btnCreate.TabIndex = 13;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.lbxQuestions, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(573, 596);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btnQuestionAdd, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnQuestionRemove, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(404, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(166, 113);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.labelQuestion, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtboxQuestion, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(395, 113);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.Controls.Add(this.lbxAnswers, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(582, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(573, 596);
            this.tableLayoutPanel4.TabIndex = 15;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Controls.Add(this.btnAnswerAdd, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnAnswerRemove, 0, 1);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(404, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(166, 113);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // btnAnswerAdd
            // 
            this.btnAnswerAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAnswerAdd.Location = new System.Drawing.Point(53, 16);
            this.btnAnswerAdd.Name = "btnAnswerAdd";
            this.btnAnswerAdd.Size = new System.Drawing.Size(59, 23);
            this.btnAnswerAdd.TabIndex = 6;
            this.btnAnswerAdd.Text = "Add";
            this.btnAnswerAdd.UseVisualStyleBackColor = true;
            this.btnAnswerAdd.Click += new System.EventHandler(this.btnAnswerAdd_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Controls.Add(this.labelSelectedQuestion, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtboxAnswer, 0, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(395, 113);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.btnCreate, 2, 1);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 20);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1287, 669);
            this.tableLayoutPanel7.TabIndex = 16;
            // 
            // txtbSurveyTitle
            // 
            this.txtbSurveyTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtbSurveyTitle.Location = new System.Drawing.Point(0, 0);
            this.txtbSurveyTitle.Name = "txtbSurveyTitle";
            this.txtbSurveyTitle.Size = new System.Drawing.Size(1287, 20);
            this.txtbSurveyTitle.TabIndex = 13;
            // 
            // PageCreateSurvey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel7);
            this.Controls.Add(this.txtbSurveyTitle);
            this.Name = "PageCreateSurvey";
            this.Size = new System.Drawing.Size(1287, 689);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxQuestions;
        private System.Windows.Forms.Button btnQuestionAdd;
        private System.Windows.Forms.Button btnQuestionRemove;
        private System.Windows.Forms.Button btnAnswerRemove;
        private System.Windows.Forms.Label labelSelectedQuestion;
        private System.Windows.Forms.TextBox txtboxAnswer;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.TextBox txtboxQuestion;
        private System.Windows.Forms.ListBox lbxAnswers;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button btnAnswerAdd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TextBox txtbSurveyTitle;
    }
}
