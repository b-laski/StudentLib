using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProgram.FORM
{
    public partial class AddCollage : UserControl
    {
        public delegate void ButtonEventHundler(object sender, CloseForm type);
        public event ButtonEventHundler Buttons;

        public enum CloseForm
        { 
            close
        }
        public AddCollage()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            Buttons?.Invoke(sender, CloseForm.close);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Buttons?.Invoke(sender, CloseForm.close);
        }
    }
}
