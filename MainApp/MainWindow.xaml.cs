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
            SkinEnum skin = (Skin.ActualSkin == SkinEnum.Light) ? SkinEnum.Dark : SkinEnum.Light;
            Skin.LoadSkin(skin);
        }
    }
}
