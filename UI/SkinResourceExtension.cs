using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace UI
{
    public sealed class SkinResourceExtension : DynamicResourceExtension
    {
        public new SkinKey ResourceKey { 
            get => (SkinKey)base.ResourceKey;
            set { base.ResourceKey = value; } 
        }

        //this works
        //public new ThemeKey ResourceKey
        //{
        //    get
        //    {
        //        Enum.TryParse(base.ResourceKey.ToString(), out ThemeKey resourceKey);
        //        return resourceKey;
        //    }
        //    //set => base.ResourceKey = value.ToString();
        //    set => base.ResourceKey = value;
        //}
    }
}
