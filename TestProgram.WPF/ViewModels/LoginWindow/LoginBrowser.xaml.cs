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
    /// Interaction logic for LoginBrowser.xaml
    /// </summary>
    public partial class LoginBrowser : UserControl
    {
        public delegate void LoginStatusEventHundler(object sender, LoginStatusEnum e);
        public event LoginStatusEventHundler LoginStatus;
        public enum LoginStatusEnum
        {
            Succes,
            Fail
        }

        public LoginBrowser()
        {
            InitializeComponent();
        }

        public void SetAdress(string _url)
        {
            WebClient.Navigate(new Uri(_url));
            WebClient.Navigating += WebClient_Navigating;
        }

        private void WebClient_Navigating(object sender, NavigatingCancelEventArgs e)
        {
            if (e.Uri.AbsoluteUri.Contains("access_token"))
            {
                string[] _tokenSep = new string[] { "=", "&" };
                string access_token = ((e.Uri.AbsoluteUri).Split(_tokenSep, StringSplitOptions.None)[1]);
                SignIn(access_token);
            }
        }

        public void SignIn(string access_token)
        {
            bool flaga = StudentAPI.StudentAPI.SetSession("facebook", access_token);
            if (flaga)
                LoginStatus?.Invoke(this, LoginStatusEnum.Succes);
            else
                LoginStatus?.Invoke(this, LoginStatusEnum.Fail);
        }
    }
}
