using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace KotStudentApp.Views.LoginWindows
{
    /// <summary>
    /// Interaction logic for LoginScreen.xaml
    /// </summary>
    public partial class LoginScreen : UserControl
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        public void StartingAnimation()
        {
            EllipseGeometry geometry = new EllipseGeometry(new Point(this.ActualWidth / 2, this.ActualHeight / 2), 0, 0);
            this.Width = ActualWidth;
            this.Height = ActualHeight;

            int EllipseFinalWidth = (int) Utilities.MathFunctions.CalculatePitagoras(this.ActualWidth / 2, this.ActualHeight / 2);
            this.Clip = geometry;
            grdContent.Opacity = 0;

            Utilities.Animations.RadiusXAnimation(geometry, EllipseFinalWidth, TimeSpan.FromMilliseconds(600));
            Utilities.Animations.RadiusYAnimation(geometry, EllipseFinalWidth, TimeSpan.FromMilliseconds(600), ()=>
            {
                this.Clip = null;
                Utilities.Animations.OpacityAnimation(grdContent, 1, TimeSpan.FromMilliseconds(600));
            });

        }

        public void BrowserAnimation()
        {
            grdContent.Opacity = 1;
            Utilities.Animations.OpacityAnimation(grdContent, 0, TimeSpan.FromMilliseconds(600), () =>
            {
                grdContent.Visibility = Visibility.Collapsed;
                MainParent.MaxWidth = 800;
                MainParent.MaxHeight = 500;
                Utilities.Animations.WidthAnimation(MainParent, 800, TimeSpan.FromMilliseconds(600));
                Utilities.Animations.HeightAnimation(MainParent, 500, TimeSpan.FromMilliseconds(600), () =>
                {
                    wbClient.Opacity = 0;
                    wbClient.Visibility = Visibility.Visible;
                    Utilities.Animations.OpacityAnimation(wbClient, 1, TimeSpan.FromMilliseconds(600));
                });
            });
        }

        public void LoadingModelsAnimation()
        {
            Utilities.Animations.OpacityAnimation(wbClient, 0, TimeSpan.FromMilliseconds(600), () =>
            {
                wbClient.Visibility = Visibility.Collapsed;
                MainParent.MinWidth = 26;
                MainParent.MinHeight = 26;
                MainParent.Background = new SolidColorBrush(Colors.Transparent);
                Utilities.Animations.WidthAnimation(MainParent, 48, TimeSpan.FromMilliseconds(600));
                Utilities.Animations.HeightAnimation(MainParent, 48, TimeSpan.FromMilliseconds(600), () =>
                {
                    grdProgressBar.Opacity = 0;
                    grdProgressBar.Visibility = Visibility.Visible;
                    Utilities.Animations.OpacityAnimation(grdProgressBar, 1, TimeSpan.FromMilliseconds(600));
                });
            });
        }

        private void MainParent_Loaded(object sender, RoutedEventArgs e)
        {
            StartingAnimation();
        }

        private void btnFacebookLogin_Click(object sender, RoutedEventArgs e)
        {
            if(Properties.Settings.Default.OAuthToken!="")
            {
                LoadingModelsAnimation();
                SignIn(Properties.Settings.Default.OAuthToken);
            }
            else
            {
                BrowserAnimation();
                webBrowser.Navigate("https://www.facebook.com/dialog/oauth?client_id=388432308196913&redirect_uri=https://www.facebook.com/connect/login_success.html&display=popup&scope=public_profile+email+user_education_history&response_type=token");
                webBrowser.Navigating += WebBrowser_Navigating;
            }

        }

        private void WebBrowser_Navigating(object sender, System.Windows.Navigation.NavigatingCancelEventArgs e)
        {
            if (e.Uri.AbsoluteUri.Contains("#access_token="))
            {
                string[] _tokenSep = new string[] { "=", "&" };
                string access_token = ((e.Uri.AbsoluteUri).Split(_tokenSep, StringSplitOptions.None)[1]);
                SignIn(access_token);
            }
        }

        public async void SignIn(string access_token)
        {
            bool LoginStatus =  await StudentAPI.StudentAPI.SetSessionAsync("facebook", access_token);
            if (LoginStatus)
            {
                Properties.Settings.Default.OAuthToken = access_token;
                Properties.Settings.Default.Save();
                LoadingModelsAnimation();
            }
            else
            {
                
            }
        }
    }
}
