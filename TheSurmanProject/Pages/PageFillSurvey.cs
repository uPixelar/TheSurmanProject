using DataAccess;
using TheSurmanProject.Components;
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
    public partial class PageFillSurvey : UserControl {
        /// <summary>
        /// This object holds survey to be filled
        /// </summary>
        tb_surveys survey;

        /// <summary>
        /// This <c>QuestionSet</c> array holds questionset objects for every questions
        /// </summary>
        QuestionSet[] questions;

        /// <summary>
        /// This value holds current question's index
        /// </summary>
        int currentQuestion = 0;

        /// <summary>
        /// This getter return current <c>QuestionSet</c>
        /// </summary>
        QuestionSet questionSet {
            get {
                return questions[currentQuestion];
            }
        }

        /// <summary>
        /// Constructor of PageFillSurvey
        /// </summary>
        /// <param name="surveyId">Id of the survey to be filled</param>
        public PageFillSurvey(int surveyId) {
            InitializeComponent();
            ApplyTheme();
            Setup(surveyId);
        }
        
        /// <summary>
        /// This methods sets up <c>QuestionsSet</c>'s.
        /// </summary>
        /// <param name="surveyId">Id of the survey to be filled</param>
        void Setup(int surveyId) {
            surmanEntities entities = new surmanEntities();
            survey = entities.tb_surveys.Find(surveyId);

            questions = new QuestionSet[survey.tb_questions.Count];
            int i = 0;
            foreach(tb_questions question in survey.tb_questions) {
                questions[i++] = new QuestionSet(question) { Dock = DockStyle.Top};
            }
            labelTitle.Text = survey.title;
            SetQuestion(0);
        }

        /// <summary>
        /// Changes current question to selected index
        /// </summary>
        /// <param name="index">Question index in array</param>
        void SetQuestion(int index) {
            currentQuestion = index;

            if (index == 0)
                btnLeft.Enabled = false;
            else btnLeft.Enabled = true;

            if (index == questions.Length - 1)
                btnRight.Text = "Complete";
            else btnRight.Text = "Next";

            panelQuestion.Controls.Clear();
            panelQuestion.Controls.Add(questionSet);
        }

        /// <summary>
        /// This method saves answers to the database
        /// </summary>
        void SaveSurvey() {
            surmanEntities entities = new surmanEntities();
            for(int i=0; i<questions.Length; ++i) {
                QuestionSet set = questions[i];

                if(set.selected == null) {
                    MessageBox.Show($"A question is unanswered.\nQuestion: {set.question.text}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    SetQuestion(i);
                    return;
                }

                entities.tb_userAnswers.Add(new tb_userAnswers() {
                    answerId = set.selected.answerId,
                    userId = UserSystem.CurrentUser.userId
                });
            }
            entities.SaveChanges();
            Program.mainWindow.ClearPage();
            MessageBox.Show("You have completed the survey!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Event listening for click of the button at right
        /// </summary>
        private void btnRight_Click(object sender, EventArgs e) {
            if(currentQuestion +1 == questions.Length) {
                SaveSurvey();
                return;
            }

            SetQuestion(currentQuestion + 1);
        }

        /// <summary>
        /// Event listening for click of the button at left
        /// </summary>
        private void btnLeft_Click(object sender, EventArgs e) {
            SetQuestion(currentQuestion - 1);
        }

        /// <summary>
        /// This method applies current theme to the controls in page.
        /// </summary>
        void ApplyTheme() {
            AppTheme theme = AppTheme.CurrentTheme;
            labelTitle.ForeColor = theme.BaseTextColor;
            labelTitle.BackColor = theme.BaseColor;
            panelButtons.BackColor = theme.MidColor;
        }
    }
}
