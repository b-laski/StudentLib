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
    /// Interaction logic for Profile.xaml
    /// </summary>
    public partial class Profile : UserControl
    {

        public Profile()
        {
            InitializeComponent();

            btnMoreOptions.AddHandler(MouseDownEvent, new MouseButtonEventHandler(BtnMoreOption_Click), true);
            btnSignOut.AddHandler(MouseDownEvent, new MouseButtonEventHandler(btnSignOut_MouseDown), true);
        }

        public void SetUser()
        {
            var user = StudentAPI.StudentAPI.GetUserObject();
            userNameBlock.Text = user.FirstName;

            if(user.Photo != "")
            {
                var uri = new Uri(user.Photo);
                imageBox.Source = new BitmapImage(uri);
                imageBox.Visibility = Visibility.Visible;
            }
            else
            {
                Grid g = new Grid();
                TextBlock tb = new TextBlock();
                Ellipse e = new Ellipse();
                e.Width = 26;
                e.Height = 26;
                e.Fill = new SolidColorBrush(Colors.Black);

                tb.Text = user.FirstName.Substring(0, 1);
                tb.HorizontalAlignment = HorizontalAlignment.Center;
                tb.VerticalAlignment = VerticalAlignment.Center;
                tb.TextAlignment = TextAlignment.Center;
                
                g.Children.Add(e);
                g.Children.Add(tb);

                g.Width = 26;
                g.Height = 26;

                viewBox.Child = g;

            }


        }

        private void BtnMoreOption_Click(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                MoreOptionsContextMenu.IsOpen = true;
            }
        }

        private void btnSignOut_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Libs.LogOut.DeleteEveryCookie(new Uri("https://login.facebook.com/login.php"));
            Libs.LogOut.DeleteEveryCookie(new Uri("https://ssl.facebook.com/desktopapp.php"));
            MessageBox.Show("XD");
        }
    }
}
