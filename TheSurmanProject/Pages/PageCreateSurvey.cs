using DataAccess;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheSurmanProject.Components;
using TheSurmanProject.Pages;


namespace TheSurmanProject.Pages {
    public partial class PageCreateSurvey : UserControl {
        tb_questions currentQuestion {
            get {
                if (lbxQuestions.SelectedItem == null) 
                    return null;

                return (tb_questions)lbxQuestions.SelectedItem;
            }
        }

        tb_answers currentAnswer {
            get {
                if (lbxAnswers.SelectedItem == null)
                    return null;

                return (tb_answers)lbxAnswers.SelectedItem;
            }
        }

        public PageCreateSurvey() {
            InitializeComponent();
            SetUp();
        }

        void SetUp() {
            lbxQuestions.DisplayMember = "text";
            lbxAnswers.DisplayMember = "text";
            DisableAnswers();
        }

        void DisableAnswers() {
            ClearAnswers();
            btnAnswerAdd.Enabled = false;
            btnAnswerRemove.Enabled = false;
            txtboxAnswer.Enabled = false;
            lbxAnswers.Enabled = false;
            btnQuestionRemove.Enabled = false;
        }
        void EnableAnswers() {
            btnAnswerAdd.Enabled = true;
            btnAnswerRemove.Enabled = true;
            txtboxAnswer.Enabled = true;
            lbxAnswers.Enabled = true;
            btnQuestionRemove.Enabled = true;
        }

        void ClearAnswers() {
            lbxAnswers.Items.Clear();
            txtboxAnswer.Text = "";
        }

        void LoadAnswers() {
            ClearAnswers();
            foreach (tb_answers answer in currentQuestion.tb_answers) {
                lbxAnswers.Items.Add(answer);
            }
        }

        void Error(string message) {
            MessageBox.Show(message, "Hey there!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #region Events
        void btnQuestionAdd_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtboxQuestion.Text)) {
                Error("Question field cannot be empty!");
                return;
            }

            tb_questions question = new tb_questions();
            question.text = txtboxQuestion.Text;
            txtboxQuestion.Text = "";

            lbxQuestions.Items.Add(question);
        }

        void btnAnswerAdd_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtboxAnswer.Text)) {
                Error("Answer field cannot be empty!");
                return;
            }

            tb_answers answer = new tb_answers();
            answer.text = txtboxAnswer.Text;
            txtboxAnswer.Text = "";
            lbxAnswers.Items.Add(answer);
            currentQuestion.tb_answers.Add(answer);
        }

        void lbxQuestions_SelectedIndexChanged(object sender, EventArgs e) {
            if (currentQuestion == null) {
                DisableAnswers();
                return;
            }
                
            EnableAnswers();
            LoadAnswers();
        }

        void btnQuestionRemove_Click(object sender, EventArgs e) {
            lbxQuestions.Items.Remove(currentQuestion);
            DisableAnswers();
        }

        private void btnAnswerRemove_Click(object sender, EventArgs e) {
            if (currentAnswer == null) {
                Error("No answer selected!");
                return;
            }
            tb_answers answer = (tb_answers)lbxAnswers.SelectedItem;
            lbxAnswers.Items.Remove(answer);
            currentQuestion.tb_answers.Remove(answer);
        }

        private void btnCreate_Click(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(txtbSurveyTitle.Text)) {
                Error("Survey title cannot be empty!");
                return;
            }

            if (lbxQuestions.Items.Count == 0) {
                Error("Questions cannot be empty!");
                return;
            }

            tb_surveys survey = new tb_surveys() {
                title = txtbSurveyTitle.Text,
                userId = UserSystem.CurrentUser.userId,
            };

            foreach (tb_questions question in lbxQuestions.Items) {
                if(question.tb_answers.Count == 0) {
                    Error($"A question has no answers.\nQuestion: '{question.text}'");
                    return;
                }
                survey.tb_questions.Add(question);
            }
            SurveyManager.SaveSurvey(survey);
            Program.mainWindow.ViewSurvey(survey.surveyId);
        }
        #endregion
    }

}
