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

namespace KotStudentApp.ViewModels
{
    /// <summary>
    /// Interaction logic for Profile.xaml
    /// </summary>
    public partial class Profile : UserControl
    {
        public delegate void ContextMenuHundler(object sender, SelectedOption e);
        public event ContextMenuHundler ContextButtonClicked;
        public enum SelectedOption
        {
            Profile,
            Message,
            Settings,
            Logout
        }

        public StudentAPI.Models.API.User ConvertedModel
        {
            get
            {
                if (this.DataContext != null)
                    return (StudentAPI.Models.API.User)
                        this.DataContext;
                else return null;
            }
        }

        public Profile()
        {
            InitializeComponent();
        }

        public Profile(StudentAPI.Models.API.User _content) : this()
        {
            this.DataContext = _content;
            UpdatePhoto(_content);
        }

        private void UpdatePhoto(StudentAPI.Models.API.User _content)
        {
            if (ConvertedModel != null)
            {
                if(string.IsNullOrEmpty(_content.Photo))
                {
                    imgProfil.ImageSource = new BitmapImage(new Uri(@"D:/KotStudentLib/KotStudentApp/Images/icon-person1.png"));
                }
                else
                {
                    imgProfil.ImageSource = new BitmapImage(new Uri(_content.Photo));
                }
            }
        }

        #region ContextMenu

        private void itemProfil_Click(object sender, RoutedEventArgs e)
        {
            ContextButtonClicked?.Invoke(sender, SelectedOption.Profile);
        }

        private void itemMessage_Click(object sender, RoutedEventArgs e)
        {
            ContextButtonClicked?.Invoke(sender, SelectedOption.Message);
        }

        private void itemSettings_Click(object sender, RoutedEventArgs e)
        {
            ContextButtonClicked?.Invoke(sender, SelectedOption.Settings);
        }

        private void itemLogout_Click(object sender, RoutedEventArgs e)
        {
            //ContextButtonClicked?.Invoke(sender, SelectedOption.Logout);
        }

        #endregion

    }
}
