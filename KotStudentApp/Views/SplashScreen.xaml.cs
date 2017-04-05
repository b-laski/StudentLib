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

namespace KotStudentApp.Views
{
    /// <summary>
    /// Interaction logic for SplashScreen.xaml
    /// </summary>
    public partial class SplashScreen : UserControl
    {
        public SplashScreen()
        {
            InitializeComponent();
            icon.Source = new BitmapImage(new Uri("http://materialdesignblog.com/wp-content/uploads/2015/04/387b93c8b66379c32e1cc2b98dcf5197.png"));
        }
    }
}
