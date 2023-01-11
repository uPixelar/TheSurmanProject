using DataAccess;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheSurmanProject.Components {
    public partial class SurveySum : UserControl {
        public tb_surveys survey;
        public EventHandler SurveySelect;
        public SurveySum(tb_surveys _survey) {
            survey = _survey;
            InitializeComponent();
            ApplyTheme();
            labelUsername.Text = survey.tb_users.username;
            labelHeader.Text = survey.title;
            labelCount.Text = $"{survey.tb_questions.Count} questions";
            labelDate.Text = survey.createdAt.ToString();
        }

        private void ApplyTheme() {
            AppTheme theme = AppTheme.CurrentTheme;
            BackColor = theme.BaseColor;
            labelCount.ForeColor = theme.BaseTextColor;
            labelDate.ForeColor = theme.BaseTextColor;
            labelHeader.ForeColor = theme.BaseTextColor;
        }

        private void SurveySum_Click(object sender, EventArgs e) {
            SurveySelect(this, EventArgs.Empty);
        }
    }
}
