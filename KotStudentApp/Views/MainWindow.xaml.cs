﻿using System;
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

namespace KotStudentApp
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

        private void TitleBar_TopBarButtonClick(object sender, TitleBar.TopBarButtons type)
        {
            switch (type)
            {
                case TitleBar.TopBarButtons.Minimalization:
                    WindowState = WindowState.Minimized;
                    break;
                case TitleBar.TopBarButtons.Maximalization:
                    if (WindowState == WindowState.Maximized)
                        WindowState = WindowState.Normal;
                    else
                        WindowState = WindowState.Maximized;
                    break;
                case TitleBar.TopBarButtons.Close:
                    //var result = MessageBox.Show("Are you sure?", "Exit", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    //if (result == MessageBoxResult.Yes)
                    this.Close();
                    break;
            }
        }

        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }

        }

        private void SplashScreen_StartLoad(object sender, EventArgs e)
        {
            MainControl.LoadAll();
            Utilities.Animations.OpacityAnimation(SplashScreen, 0, TimeSpan.FromMilliseconds(600), () =>
            {
                SplashScreen.Visibility = Visibility.Collapsed;
                MainControl.Opacity = 0;
                MainControl.Visibility = Visibility.Visible;
                Utilities.Animations.OpacityAnimation(MainControl, 1, TimeSpan.FromMilliseconds(600));
            });
        }
    }
}
