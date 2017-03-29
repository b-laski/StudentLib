using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProgram.FORM
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
            
        }

        public AddForm(int? info) : this()
        {
            switch(info)
            {
                case 1:
                  AddCollage UCAddCollage = new AddCollage();
                  UCAddCollage.Show();
                  break;
                case 2:
                  break;

                default:
                  Button btn = new Button();
                  btn.Width = 150;
                  btn.Height = 70;
                  btn.ForeColor = Color.Black;
                  btn.Text = "CLOSE";
                  this.Controls.Add(btn);
                  break;
             }
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }
    }
}
