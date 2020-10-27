﻿using System;
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
                    loadDictionary(SkinEnum.Light);
                }
                return _resDictionary;

            }

        }

        private static void loadDictionary(SkinEnum light)
        {
            setResource(SkinKey.MainBackground,new SolidColorBrush(ColorFromHex("#FF0F0F0F")));
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