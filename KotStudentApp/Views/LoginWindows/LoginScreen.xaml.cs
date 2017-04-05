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

        private void MainParent_Loaded(object sender, RoutedEventArgs e)
        {
            StartingAnimation();
        }
    }
}
