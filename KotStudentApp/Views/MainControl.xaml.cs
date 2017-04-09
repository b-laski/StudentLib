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

namespace KotStudentApp.Views
{
    /// <summary>
    /// Interaction logic for MainControl.xaml
    /// </summary>
    public partial class MainControl : UserControl
    {

        public MainControl()
        {
            InitializeComponent();
        }

        public void LoadAll()
        {
            ToolBar.LoadAll();
        }

        private void ToolBar_OpenCloseMenu(object sender, Enums.OpenCloseStatus e)
        {
            if (e == Enums.OpenCloseStatus.Open)
            {
                grdMenu.OpenMenu();
            }
            else if (e == Enums.OpenCloseStatus.Close)
            {
                grdMenu.CloseMenu();
            }
        }

        private void ToolBar_OpenProfilControl()
        {

        }
    }
}
