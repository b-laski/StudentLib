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
    /// Interaction logic for TopBar.xaml
    /// </summary>
    public partial class TopBar : UserControl
    {
        public delegate void MenuButtonHundler(object sender, TopBarButtons type);
        public event MenuButtonHundler TopBarButtonClick;
        public enum TopBarButtons
        {
            Minimalization,
            Maximalization,
            Close
        }
        public TopBar()
        {
            InitializeComponent();
        }

        private void btnMinimalization_Click(object sender, RoutedEventArgs e)
        {
            TopBarButtonClick?.Invoke(sender, TopBarButtons.Minimalization);
        }

        private void btnMaximalization_Click(object sender, RoutedEventArgs e)
        {
            TopBarButtonClick?.Invoke(sender, TopBarButtons.Maximalization);
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            TopBarButtonClick?.Invoke(sender, TopBarButtons.Close);
        }
    }
}
