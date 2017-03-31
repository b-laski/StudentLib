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

namespace TestProgram.WPF.ViewModels
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : UserControl
    {

        public StudentAPI.Models.API.Collage.College ConvertModel
        {
            get
            {
                if (this.DataContext != null)
                    return (StudentAPI.Models.API.Collage.College)this.DataContext;
                else return null;
            }
        }

        public Menu()
        {
            InitializeComponent();
        }

        public Menu(List<StudentAPI.Models.API.Collage.College> _content) : this()
        {
            this.DataContext = _content;
        }
    }
}
