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

        public delegate void OpenProfileHundler();
        public event OpenProfileHundler OpenProfilControl;

        public ToolBar()
        {
            InitializeComponent();
        }

        public void LoadAll()
        {
            profile.LoadPerson();
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

        private void profile_ContextButtonClicked(object sender, ViewModels.Profile.SelectedOption e)
        {
            if(e == ViewModels.Profile.SelectedOption.Profile)
            {
                OpenProfilControl?.Invoke();
            }
        }
    }
}
