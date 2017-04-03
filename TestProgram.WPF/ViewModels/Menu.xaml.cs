using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using StudentAPI.Models.API;

namespace TestProgram.WPF.ViewModels
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
            btnGroups.Foreground = (Brush)FindResource("PrimaryHueMidBrush");

            btnGroups.AddHandler(FrameworkElement.MouseDownEvent, new MouseButtonEventHandler(btnGroups_MouseDown), true);
            btnMessage.AddHandler(FrameworkElement.MouseDownEvent, new MouseButtonEventHandler(btnMessage_MouseDown), true);
            btnSettings.AddHandler(FrameworkElement.MouseDownEvent, new MouseButtonEventHandler(btnSettings_MouseDown), true);
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
            groupTextBlock.Opacity = 0;
            messageTextBlock.Opacity = 0;
            settingsTextBlock.Opacity = 0;
            Utilities.Animations.WidthAnimation(pnlMenu, targetOpenWidth, TimeSpan.FromMilliseconds(500));
            Utilities.Animations.WidthAnimation(separatorekXD, 186, TimeSpan.FromMilliseconds(500));
            Utilities.Animations.OpacityAnimation(groupTextBlock, 1, TimeSpan.FromMilliseconds(800));
            Utilities.Animations.OpacityAnimation(messageTextBlock, 1, TimeSpan.FromMilliseconds(800));
            Utilities.Animations.OpacityAnimation(settingsTextBlock, 1, TimeSpan.FromMilliseconds(800));
        }

        private void HideMenu(Grid pnlMenu)
        {
            groupTextBlock.Opacity = 1;
            messageTextBlock.Opacity = 1;
            settingsTextBlock.Opacity = 1;
            Utilities.Animations.WidthAnimation(pnlMenu, targetClosedWidth, TimeSpan.FromMilliseconds(500), () =>
            {
                hideTextBlocks();
            });
            Utilities.Animations.WidthAnimation(separatorekXD, 36, TimeSpan.FromMilliseconds(500));
            Utilities.Animations.OpacityAnimation(groupTextBlock, 0, TimeSpan.FromMilliseconds(300));
            Utilities.Animations.OpacityAnimation(messageTextBlock, 0, TimeSpan.FromMilliseconds(300));
            Utilities.Animations.OpacityAnimation(settingsTextBlock, 0, TimeSpan.FromMilliseconds(300));
        }

        private void showTextBlocks()
        {
            groupTextBlock.Visibility = Visibility.Visible;
            messageTextBlock.Visibility = Visibility.Visible;
            settingsTextBlock.Visibility = Visibility.Visible;
        }

        private void hideTextBlocks()
        {
            groupTextBlock.Visibility = Visibility.Collapsed;
            messageTextBlock.Visibility = Visibility.Collapsed;
            settingsTextBlock.Visibility = Visibility.Collapsed;
        }

        private void resetButton()
        {
            foreach (Button item in pnlButtonMenu.Children)
            {
                var bc = new BrushConverter();
                item.Foreground = (Brush)bc.ConvertFrom("#616161");
            }
        }

        private void btnGroups_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                MenuButtons?.Invoke(this, MenuList.Groups);
                resetButton();
                btnGroups.Foreground = (Brush)FindResource("PrimaryHueMidBrush");
            }
        }

        private void btnMessage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                MenuButtons?.Invoke(this, MenuList.Messages);
                resetButton();
                btnMessage.Foreground = (Brush)FindResource("PrimaryHueMidBrush");
            }
        }

        private void btnSettings_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                MenuButtons?.Invoke(this, MenuList.Settings);
                resetButton();
                btnSettings.Foreground = (Brush)FindResource("PrimaryHueMidBrush");
            }
        }
    }
}
