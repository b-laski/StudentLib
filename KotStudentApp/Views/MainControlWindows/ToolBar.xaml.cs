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
    /// Interaction logic for ToolBar.xaml
    /// </summary>
    public partial class ToolBar : UserControl
    {
        public delegate void OpenMenuHundler(object sender, Enums.OpenCloseStatus e);
        public event OpenMenuHundler OpenCloseMenu;

        public delegate void Action();
        public event Action ShowProfile;

        ViewModels.Profile profile = null;

        public ToolBar()
        {
            InitializeComponent();
        }

        public async void LoadControls()
        {
            profile = new ViewModels.Profile(await StudentAPI.StudentAPI.GetUserObjectAsync());
            grdProfilPanel.Children.Add(profile);

            profile.ContextButtonClicked += Profile_ContextButtonClicked;
        }

        private void Profile_ContextButtonClicked(object sender, ViewModels.Profile.SelectedOption e)
        {
            if(e == ViewModels.Profile.SelectedOption.Profile)
            {
                ShowProfile?.Invoke();
            }
        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            if (btnMenu.IsChecked == true)
            {
                OpenCloseMenu?.Invoke(sender, Enums.OpenCloseStatus.Open);
            }
            else
            {
                OpenCloseMenu?.Invoke(sender, Enums.OpenCloseStatus.Close);
            }
        }


    }
}
