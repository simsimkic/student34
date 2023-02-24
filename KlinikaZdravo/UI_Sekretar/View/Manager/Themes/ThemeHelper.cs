using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Aplikacija.Themes
{
    public static class ThemeHelper
    {
        private static bool isThemeLight;

        public static void SetTheme(bool isLightTheme)
        {
            isThemeLight = isLightTheme;
        }

        public static Brush getPozadina()
        {
            if (isThemeLight)
            {
                return Brushes.SkyBlue;
            }
            else
            {
                return Brushes.SteelBlue;
            }
        }
    }
}
