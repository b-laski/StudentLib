using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestProgram.WPF.ViewModels
{
    /// <summary>
    /// Interaction logic for Portrait.xaml
    /// </summary>
    public partial class Portrait : UserControl
    {
        public delegate void MenuEventHundler(object sender, OpenMenuEnum type);
        public event MenuEventHundler OpenMenu;
        public enum OpenMenuEnum
        {
            Open,
            Close
        }

        public Portrait()
        {
            InitializeComponent();
        }

        public void SetupAll()
        {
            Profil.SetUser();
        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            if(btnMenu.IsChecked == true)
            {
                OpenMenu?.Invoke(sender, OpenMenuEnum.Open);
            }
            else
            {
                OpenMenu?.Invoke(sender, OpenMenuEnum.Close);
            }

        }
    }
}
