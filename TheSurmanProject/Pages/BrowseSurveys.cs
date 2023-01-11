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
using TheSurmanProject.Components;
using ServiceLayer;
using System.Diagnostics;

namespace TheSurmanProject.Pages {
    public partial class BrowseSurveys : UserControl {
        public EventHandler SurveyClick;
        public BrowseSurveys() {
            InitializeComponent();
            FillSurveys();
        }
        public void FillSurveys() {
            surveytbPanel.RowCount = 0;
            List<tb_surveys> surveys = SurveyManager.getSurveys();
            foreach (tb_surveys survey in surveys) {
                AddSurvey(survey);
            }
        }
        private void AddSurvey(tb_surveys survey) {
            SurveySum comp = new SurveySum(survey);
            surveytbPanel.RowCount++;
            surveytbPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, comp.Height));
            surveytbPanel.Controls.Add(comp);
            comp.Dock = DockStyle.Fill;
            comp.SurveySelect += Survey_Clicked;
        }
        private void Survey_Clicked(object sender, EventArgs e) {
            SurveyClick(sender, e);
        }
    }
}
