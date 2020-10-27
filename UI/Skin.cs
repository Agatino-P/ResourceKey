using System;
using System.Windows;
using System.Windows.Media;

namespace UI
{
    public class Skin
    {
        [ThreadStatic]
        private static ResourceDictionary _resDictionary;

        internal static ResourceDictionary ResDictionary
        {
            get
            {
                if (_resDictionary == null)
                {
                    _resDictionary = new ResourceDictionary();
                    LoadSkin(SkinEnum.Dark);
                }
                return _resDictionary;

            }

        }

        public static SkinEnum  ActualSkin { get; set; } = SkinEnum.Light;

        public static void LoadSkin(SkinEnum skinEnum)
        {
            ActualSkin = skinEnum;
            //Common
            setResource(SkinKey.MainForeground, Brushes.Green);
            //Specific
            if (skinEnum == SkinEnum.Light)
            {
                setResource(SkinKey.MainBackground, new SolidColorBrush(ColorFromHex("#FFFFFF00")));
            }
            if (skinEnum == SkinEnum.Dark)
            {
                setResource(SkinKey.MainBackground, new SolidColorBrush(ColorFromHex("#FF0F0F0F")));
            }

        }

        private static void setResource(SkinKey themeKey, object resource)
        {
            ResDictionary[themeKey] = resource;
        }

        internal static Color ColorFromHex(string colorHex)
        {
            return (Color?)ColorConverter.ConvertFromString(colorHex) ?? Colors.Transparent;
        }
    }
}
