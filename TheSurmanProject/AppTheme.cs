using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheSurmanProject {
    internal class AppTheme {

        //Default themes
        public static class Themes {
            public static AppTheme Ytekinos = new AppTheme(Color.FromArgb(4, 111, 140), Color.FromArgb(35, 35, 35), Color.FromArgb(214, 214, 214), Color.FromArgb(68, 68, 68));
            public static AppTheme UPX = new AppTheme(Color.FromArgb(136, 0, 21), Color.FromArgb(35, 35, 35), Color.FromArgb(214, 214, 214), Color.FromArgb(68, 68, 68));
        }

        public Color color1;
        public Color color2;
        public Color color3;
        public Color color4;

        public AppTheme(Color _color1, Color _color2, Color _color3, Color _color4) {
            color1 = _color1;
            color2 = _color2;
            color3 = _color3;
            color4 = _color4;
        }

        public void SetTheme(Color _color1, Color _color2, Color _color3, Color _color4) {
            color1 = _color1;
            color2 = _color2;
            color3 = _color3;
            color4 = _color4;
        }

       
    }
}
