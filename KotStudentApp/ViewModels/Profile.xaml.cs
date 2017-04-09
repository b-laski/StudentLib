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

namespace KotStudentApp.ViewModels
{
    /// <summary>
    /// Interaction logic for Profile.xaml
    /// </summary>
    public partial class Profile : UserControl
    {
        public Profile()
        {
            InitializeComponent();
        }

        public async void LoadPerson()
        {
            StudentAPI.Models.API.User user = await StudentAPI.StudentAPI.GetUserObjectAsync();
            firstNameProfil.Text = user.FirstName;

            if (user.Photo != "")
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
                e.Width = 48;
                e.Height = 48;
                e.Fill = new SolidColorBrush(Colors.White);

                tb.Text = user.FirstName.Substring(0, 1);
                tb.HorizontalAlignment = HorizontalAlignment.Center;
                tb.VerticalAlignment = VerticalAlignment.Center;
                tb.TextAlignment = TextAlignment.Center;
                tb.Foreground = new SolidColorBrush(Colors.Black);

                g.Children.Add(e);
                g.Children.Add(tb);

                g.Width = 48;
                g.Height = 48;

                viewBox.Child = g;
            }
        }
    }
}
