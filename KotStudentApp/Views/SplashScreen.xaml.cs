using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Utilities;


namespace KotStudentApp.Views
{
    /// <summary>
    /// Interaction logic for SplashScreen.xaml
    /// </summary>
    public partial class SplashScreen : UserControl
    {
        public delegate void StartLoading(object sender, EventArgs e);
        public event StartLoading StartLoad;
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void loginScreen_isLogin(object sender, LoginWindows.LoginScreen.LoginTypes e)
        {
            if(e == LoginWindows.LoginScreen.LoginTypes.Succes)
            {
                StartLoad.Invoke(sender, EventArgs.Empty);
            }
        }
    }
}
