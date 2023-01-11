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
using TheSurmanProject.Components;
using ServiceLayer;

namespace TheSurmanProject.Pages {
    public partial class PageSettings : UserControl {
        private ThemeBox selectedThemeBox;
        
        /// <summary>
        /// Constructor for PageSettings page
        /// </summary>
        public PageSettings() {
            InitializeComponent();
            AppTheme.ThemeChanged += Theme_Changed;
            SetupThemes();
            SetupLanguages();
            ApplyTheme();
        }

        /// <summary>
        /// Event listening for theme changes
        /// </summary>
        private void Theme_Changed(object sender, AppTheme theme) {
            ApplyTheme();
        }

        /// <summary>
        /// This method applies current theme to the controls.
        /// </summary>
        private void ApplyTheme() {
            AppTheme theme = AppTheme.CurrentTheme;
            panelThemes.BackColor = Color.FromArgb(50, theme.BaseColor);
        }

        /// <summary>
        /// This method fills themes to the ui
        /// </summary>
        private void SetupThemes() {
            int themes = 0;
            foreach (AppTheme theme in AppTheme.Themes) {
                if (theme == null) continue;
                ++themes;
                ThemeBox themeBox = new ThemeBox(theme);
                themeBox.Click += Theme_Selected;
                if(theme == AppTheme.CurrentTheme) {
                    themeBox.Selected = true;
                    selectedThemeBox = themeBox;
                }
                panelThemes.Controls.Add(themeBox);
                
            }
            gboxTheme.Text += "(" + themes + ")";
        }

        /// <summary>
        /// This method fills language to the ui
        /// </summary>
        private void SetupLanguages() {
            string[] languages = new string[0]; //boş array

            if(languages.Length == 0) {
                Label lbl = new Label();
                lbl.Text = "No language setting.";
                lbl.Width = 200;
                panelLanguages.Controls.Add(lbl);            }
        }

        /// <summary>
        /// Event listening for theme selection
        /// </summary>
        private void Theme_Selected(object sender, EventArgs e) {
            ThemeBox tb = (ThemeBox)sender;
            if (tb.Selected) return;

            selectedThemeBox.Selected = false;
            tb.Selected = true;

            selectedThemeBox.Invalidate();
            tb.Invalidate();

            selectedThemeBox = tb;
            AppTheme.SetTheme(tb.theme);
        }

        
    }
}
