using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace UI
{
    public sealed class SkinResourceDictionary : ResourceDictionary
    {
        public SkinResourceDictionary()
        {
            MergedDictionaries.Add(Skin.ResDictionary);
        }
    }
}
