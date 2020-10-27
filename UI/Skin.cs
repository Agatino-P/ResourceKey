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
            switch (skinEnum)
            {
                case SkinEnum.Light:
                setResource(SkinKey.MainBackground, new SolidColorBrush(ColorFromHex("#FFFFFF00")));
                    break;
                case SkinEnum.Dark:
                setResource(SkinKey.MainBackground, new SolidColorBrush(ColorFromHex("#FF0F0F0F")));
                    break;
                case SkinEnum.Red:
                    setResource(SkinKey.MainBackground, new SolidColorBrush(ColorFromHex("#FFFF0000")));
                    break;
                default:
                    break;
            }
            if (skinEnum == SkinEnum.Light)
            {
            }
            if (skinEnum == SkinEnum.Dark)
            {
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
