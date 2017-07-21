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
    public partial class UserWindow : Form
    {
        public UserWindow(StudentAPI.Models.API.User user)
        {
            InitializeComponent();
            LoadAll(user);
        }

        private void LoadAll(StudentAPI.Models.API.User user)
        {
            nameBox.Text = user.Name;
            firstNameBox.Text = user.FirstName;
            middleNameBox.Text = user.MiddleName;
            lastNameBox.Text = user.LastName;
            emailBox.Text = user.Email;
            birthdayBox.Text = user.Birthday.ToString();
            genderComboBox.Text = user.Gender;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(middleNameBox.Text))
                middleNameBox.Text = "null";
            StudentAPI.StudentAPI.EditProfile(nameBox.Text, firstNameBox.Text, middleNameBox.Text, lastNameBox.Text, genderComboBox.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
