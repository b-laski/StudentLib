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
        public delegate void Load_User();
        public event Load_User LoaUser;

        public ToolBar()
        {
            InitializeComponent();
        }

        public void LoadAll()
        {
            profile.LoadPerson();
        }
    }
}
