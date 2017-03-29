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

namespace TestProgram.WPF.ViewModels.LoginWindow
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : UserControl
    {
        public delegate void LoginButtonHundler(object sender, string _url);
        public event LoginButtonHundler LoginButtonClick;
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void btnFacebookLogin_Click(object sender, RoutedEventArgs e)
        {
            LoginButtonClick?.Invoke(this, "https://www.facebook.com/dialog/oauth?client_id=388432308196913&redirect_uri=https://www.facebook.com/connect/login_success.html&display=popup&scope=public_profile+email+user_education_history&response_type=token");
        }
    }
}
