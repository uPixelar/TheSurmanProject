using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheSurmanProject.Components {
    public partial class QuestionSet : UserControl {
        /// <summary>
        /// This object holds QuestionSet's question object
        /// </summary>
        public tb_questions question;

        /// <summary>
        /// This object holds lastly selected answers object
        /// </summary>
        public tb_answers selected;


        /// <summary>
        /// Constructor of QuestionSet
        /// </summary>
        /// <param name="_question">Question to fill</param>
        public QuestionSet(tb_questions _question) {
            question = _question;
            InitializeComponent();
            labelQuestion.Text = question.text;
            foreach (tb_answers answer in question.tb_answers) {
                AnswerRadio radio = new AnswerRadio(answer) { Text = answer.text, Dock = DockStyle.Top };
                radio.CheckedChanged += AnswerChecked;
                panelAnswers.Controls.Add(radio);
            }
        }

        /// <summary>
        /// Event listening for answers to be checked
        /// </summary>
        void AnswerChecked(object sender, EventArgs e) {
            AnswerRadio radio = (AnswerRadio)sender;
            selected = radio.answer;
        }
    }
}
