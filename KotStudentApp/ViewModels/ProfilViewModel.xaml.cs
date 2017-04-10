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
    /// Interaction logic for ProfilView.xaml
    /// </summary>
    public partial class ProfilView : UserControl
    {
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

        public ProfilView()
        {
            InitializeComponent();
        }

        public ProfilView(StudentAPI.Models.API.User _context) : this()
        {
            this.DataContext = _context;
            UpdateCover(_context);
        }

        private void UpdateCover(StudentAPI.Models.API.User _context)
        {
            if(ConvertedModel != null)
            {
                if (string.IsNullOrEmpty(_context.Photo))
                {
                    imgPhoto.Source = new BitmapImage(new Uri(@"D:\KotStudentLib\KotStudentApp\Images\icon-person1.png"));
                }
                else
                {
                    imgPhoto.Source = new BitmapImage(new Uri(_context.Photo));
                }

                if (string.IsNullOrEmpty(_context.Cover))
                {
                    imgCover.ImageSource = new BitmapImage(new Uri(@"D:\KotStudentLib\KotStudentApp\Images\cover.jpeg"));
                }
                else
                {
                    imgCover.ImageSource = new BitmapImage(new Uri(_context.Cover));
                }
            }
        }


    }
}
