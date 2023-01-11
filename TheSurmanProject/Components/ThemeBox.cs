using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using ServiceLayer;
namespace TheSurmanProject.Components {
    /// <summary>
    /// Class <c>ThemeBox</c> holds theme data for settings page. Displays the colors of the theme in a square.
    /// </summary>
    public partial class ThemeBox : UserControl {
        private bool selected = false;
        public bool Selected { get => selected; set => selected = value; }
        public AppTheme theme;
        Color[] colors;

        /// <summary>
        /// Constructor for ThemeBox
        /// </summary>
        /// <param name="_theme">Theme to illustrate</param>
        public ThemeBox(AppTheme _theme) {
            InitializeComponent();
            theme = _theme;
            colors = new Color[] {theme.BaseColor, theme.BackgroundColor, theme.SecondaryColor, theme.MidColor, theme.BaseTextColor};
        }

        protected override void OnPaint(PaintEventArgs e) {
            Brush brush;
            float width = (float)Width / colors.Length;
            for(int i=0; i<colors.Length; i++) {
                brush = new SolidBrush(colors[i]);

                e.Graphics.FillRectangle(brush, new Rectangle((int)(i * width), 0, (int)width, Height));
            }

            ControlPaint.DrawBorder(e.Graphics, DisplayRectangle, selected ? Color.Red : Color.Black, ButtonBorderStyle.Solid);

            base.OnPaint(e);
        }
    }
}
