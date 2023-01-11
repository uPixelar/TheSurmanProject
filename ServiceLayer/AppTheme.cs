using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ServiceLayer {
    public class AppTheme {
        public Color BaseColor;
        public Color BackgroundColor;
        public Color SecondaryColor;
        public Color MidColor;
        public Color BaseTextColor;

        /// <summary>
        /// This enum holds default theme indexes created by developers
        /// </summary>
        public enum DefaultThemes {
            Ytekinos,
            UPX,
            blackthornj
        }

        /// <summary>
        /// This method sets the theme to the given enum DefaultThemes
        /// </summary>
        /// <param name="theme">Enum for DefaultThemes</param>
        public static void SetTheme(DefaultThemes theme) {
            SetTheme((int)theme);
        }

        /// <summary>
        /// This methods sets theme to the given AppTheme object
        /// </summary>
        /// <param name="theme">Theme object to set</param>
        public static void SetTheme(AppTheme theme) {
            for(int i=0; i<Themes.Length; i++) {
                if (Themes[i] == theme) {
                    SetTheme(i);
                    return;
                }
            }
        }

        /// <summary>
        /// This eventhandler handles theme change events
        /// </summary>
        public static EventHandler<AppTheme> ThemeChanged;

        /// <summary>
        /// This value holds current themes index
        /// </summary>
        private static int CurrentThemeId;

        /// <summary>
        /// This array holds themes
        /// </summary>
        public static AppTheme[] Themes = new AppTheme[] {
            new AppTheme(Color.FromArgb(4, 111, 140), Color.FromArgb(35, 35, 35), Color.FromArgb(214, 214, 214), Color.FromArgb(68, 68, 68), Color.FromArgb(255, 255, 255)),
            new AppTheme(Color.FromArgb(136, 0, 21), Color.FromArgb(35, 35, 35), Color.FromArgb(214, 214, 214), Color.FromArgb(68, 68, 68), Color.FromArgb(255, 255, 255)),
            new AppTheme(Color.DarkGray, Color.FromArgb(225, 225, 225), Color.FromArgb(170, 150, 255), Color.FromArgb(72, 61, 139), Color.FromArgb(20, 20, 20)),
            new AppTheme(Color.Blue, Color.DarkGray, Color.LightSlateGray, Color.HotPink, Color.FromArgb(255, 255, 255)),//blackthornj
            null//user theme
        };

        /// <summary>
        /// Consturctor of AppTheme
        /// </summary>
        public AppTheme(Color baseColor, Color backgroundColor, Color secondaryColor, Color midColor, Color baseTextColor) {
            BaseColor = baseColor;
            BackgroundColor = backgroundColor;
            SecondaryColor = secondaryColor;
            MidColor = midColor;
            BaseTextColor = baseTextColor;
        }

        /// <summary>
        /// This getter returns current theme
        /// </summary>
        public static AppTheme CurrentTheme {
            get => Themes[CurrentThemeId];
        }

        /// <summary>
        /// This methods sets theme to theme at given index
        /// </summary>
        /// <param name="themeId">Index of theme to set</param>
        public static void SetTheme(int themeId) {
            CurrentThemeId = themeId;
            SaveTheme();
            ThemeChanged(CurrentTheme, CurrentTheme);
        }

        /// <summary>
        /// This method saves current theme id to UserSettings
        /// </summary>
        private static void SaveTheme() {
            Properties.UserSettings us = Properties.UserSettings.Default;
            us.themeId = CurrentThemeId;
            us.Save();
        }

        /// <summary>
        /// This method loads current theme id from UserSettings
        /// </summary>
        public static void LoadTheme() {
            Properties.UserSettings us = Properties.UserSettings.Default;
            SetTheme(us.themeId);
        }
    }
}
