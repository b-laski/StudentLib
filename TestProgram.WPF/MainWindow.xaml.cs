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
using System.Windows.Threading;

namespace TestProgram.WPF
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

        #region TopBar

        private void TopBar_TopBarButtonClick(object sender, ViewModels.TopBar.TopBarButtons type)
        {
            switch(type)
            {
                case ViewModels.TopBar.TopBarButtons.Minimalization:
                    WindowState = WindowState.Minimized;
                    break;
                case ViewModels.TopBar.TopBarButtons.Maximalization:
                    if (WindowState == WindowState.Maximized)
                        WindowState = WindowState.Normal;
                    else
                        WindowState = WindowState.Maximized;
                    break;
                case ViewModels.TopBar.TopBarButtons.Close:
                    var result = MessageBox.Show("Are you sure?", "Exit", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if(result == MessageBoxResult.Yes)
                        this.Close();
                    break;
            }
        }

        private void TopBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }


        #endregion

        #region LoginButtons

        private void loginWindow_LoginButtonClick(object sender, string _url)
        {
            loginWindow.Visibility = Visibility.Collapsed;
            webClient.Visibility = Visibility.Visible;
            webClient.SetAdress(_url);
            webClient.LoginStatus += (s, e) => {
                if (e == ViewModels.LoginWindow.LoginBrowser.LoginStatusEnum.Succes)
                {
                    MessageBox.Show("OK");
                    webClient.Visibility = Visibility.Collapsed;
                }
                else
                {
                    MessageBox.Show("FAIL");
                    webClient.Visibility = Visibility.Collapsed;
                    loginWindow.Visibility = Visibility.Visible;
                }

            };
        }

        #endregion

    }
}
