using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Windows;
using UI;

namespace MainApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSwap_Click(object sender, RoutedEventArgs e)
        {

            
            SkinEnum[] skinEnums = (SkinEnum[])Enum.GetValues(typeof(SkinEnum));
            LinkedList<SkinEnum> linkedList = new LinkedList<SkinEnum>(skinEnums);
            LinkedListNode<SkinEnum> listNode = linkedList.Find(Skin.ActualSkin);
            SkinEnum next = listNode.Next!=null?listNode.Next.Value: linkedList.First.Value;

            Skin.LoadSkin(next);
        }
    }
}
