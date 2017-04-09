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

namespace KotStudentApp.Views.MainControlWindows
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : UserControl
    {
        public delegate void MenuEventHundler(object sender, MenuList e);
        public event MenuEventHundler MenuButtons;
        public enum MenuList
        {
            Groups,
            Messages,
            Settings
        }

        private int targetClosedWidth = 48;
        private int targetOpenWidth = 200;

        public Menu()
        {
            InitializeComponent();

            targetClosedWidth = (int)this.MinWidth;
            targetOpenWidth = (int)this.MaxWidth;
            pnlMenu.Width = targetClosedWidth;
            btnDashboard.Foreground = (Brush)FindResource("SecondaryAccentBrush");

            btnDashboard.AddHandler(FrameworkElement.MouseDownEvent, new MouseButtonEventHandler(btnDashboard_MouseDown), true);
            btnGroups.AddHandler(FrameworkElement.MouseDownEvent, new MouseButtonEventHandler(btnGroups_MouseDown), true);
        }

        public void OpenMenu()
        {
            showTextBlocks();
            ShowMenu(pnlMenu);
        }

        public void CloseMenu()
        {
            HideMenu(pnlMenu);
        }

        private void ShowMenu(Grid pnlMenu)
        {
            dashboardTextBlock.Opacity = 0;
            groupsTextBlock.Opacity = 0;
            Utilities.Animations.WidthAnimation(pnlMenu, targetOpenWidth, TimeSpan.FromMilliseconds(500));
            Utilities.Animations.WidthAnimation(separatorekXD, 186, TimeSpan.FromMilliseconds(500));
            Utilities.Animations.OpacityAnimation(dashboardTextBlock, 1, TimeSpan.FromMilliseconds(800));
            Utilities.Animations.OpacityAnimation(groupsTextBlock, 1, TimeSpan.FromMilliseconds(800));
        }

        private void HideMenu(Grid pnlMenu)
        {
            dashboardTextBlock.Opacity = 1;
            groupsTextBlock.Opacity = 1;
            Utilities.Animations.WidthAnimation(pnlMenu, targetClosedWidth, TimeSpan.FromMilliseconds(500), () =>
            {
                hideTextBlocks();
            });
            Utilities.Animations.WidthAnimation(separatorekXD, 36, TimeSpan.FromMilliseconds(500));
            Utilities.Animations.OpacityAnimation(dashboardTextBlock, 0, TimeSpan.FromMilliseconds(800));
            Utilities.Animations.OpacityAnimation(groupsTextBlock, 0, TimeSpan.FromMilliseconds(800));
        }

        private void showTextBlocks()
        {
            dashboardTextBlock.Visibility = Visibility.Visible;
            groupsTextBlock.Visibility = Visibility.Visible;
        }

        private void hideTextBlocks()
        {
            dashboardTextBlock.Visibility = Visibility.Collapsed;
            groupsTextBlock.Visibility = Visibility.Collapsed;
        }

        private void resetButton()
        {
            foreach (Button item in pnlButtonMenu.Children)
            {
                var bc = new BrushConverter();
                item.Foreground = (Brush)bc.ConvertFrom("#616161");
            }
        }

        private void btnDashboard_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                MenuButtons?.Invoke(this, MenuList.Groups);
                resetButton();
                btnDashboard.Foreground = (Brush)FindResource("SecondaryAccentBrush");
            }
        }

        private void btnGroups_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                MenuButtons?.Invoke(this, MenuList.Messages);
                resetButton();
                btnGroups.Foreground = (Brush)FindResource("SecondaryAccentBrush");
            }
        }
    }
}
