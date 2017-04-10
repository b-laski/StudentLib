using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProgram.FORM
{
    public partial class Form1 : Form
    {
        private string clientID = "388432308196913";
        string access_token;
        public Form1()
        {
            InitializeComponent();
            webBrowser1.Visible = true;
            //test(access_token);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string OAuthURL = $"https://www.facebook.com/dialog/oauth?client_id={clientID}&redirect_uri=https://www.facebook.com/connect/login_success.html&display=popup&scope=public_profile+email+user_education_history&response_type=token";
            webBrowser1.Navigate(OAuthURL);
        }

        private void webBrowser1_FrameLoadStart(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webBrowser1.Url.AbsoluteUri.Contains("access_token"))
            {
                string[] _tokenSep = new string[] { "=", "&" };
                access_token = ((webBrowser1.Url.AbsoluteUri).Split(_tokenSep, StringSplitOptions.None)[1]);
                //MessageBox.Show(access_token);
                webBrowser1.Visible = false;
                SignIn(access_token);
            }
            //MessageBox.Show(access_token);
        }

        private void SignIn(string access_token)
        {
            bool flaga = StudentAPI.StudentAPI.SetSession("facebook", access_token);
            if(flaga)
                MessageBox.Show("Succes login");
            else
                MessageBox.Show("Fail login");
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (webBrowser1.Visible == true)
                webBrowser1.Visible = false;
            else
                webBrowser1.Visible = true;
        }

        private void btnLoadSession_Click(object sender, EventArgs e)
        {
            InfoBox.Items.Clear();
            InfoBox.Items.Add($"ID: {StudentAPI.StudentAPI.GetSessionID()} Token: {StudentAPI.StudentAPI.GetSessionToken()}");
        }

        private void btnLoadUser_Click(object sender, EventArgs e)
        {
            InfoBox.Items.Clear();
            InfoBox.Items.Add($"ID: {StudentAPI.StudentAPI.GetUserObject().ToString()}");
        }

        private async void btnLoadCollege_Click(object sender, EventArgs e)
        {
            InfoBox.Items.Clear();
            var list = await StudentAPI.StudentAPI.GetCollegeListAsync(TestBox.Text);

            foreach(var item in list)
            {
                InfoBox.Items.Add(item);
            }
        }

        private async void btnLoadDeparments_Click(object sender, EventArgs e)
        {
            InfoBox.Items.Clear();
            var list = await StudentAPI.StudentAPI.GetDepartmentListAsync((int)NumericBox.Value);
            if (list != null)
            {
                foreach (var item in list)
                {
                    InfoBox.Items.Add(item);
                }
            }
            else
            {
                InfoBox.Items.Add("Niema wydzialow!");
            }
        }

        private async void btnLoadCategories_Click(object sender, EventArgs e)
        {
            InfoBox.Items.Clear();
            var list = await StudentAPI.StudentAPI.GetCategoriesListAsync((int)NumericBox.Value);
            if(list!=null)
            {
                foreach(var item in list)
                {
                    InfoBox.Items.Add(item);
                }
            }
            else
            {
                InfoBox.Items.Add("Niema wydzialow!");
            }

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            InfoBox.Items.Clear();
            var list = await StudentAPI.StudentAPI.GetCoursesListAsync((int)NumericBox.Value);
            if (list != null)
            {
                foreach (var item in list)
                {
                    InfoBox.Items.Add(item);
                }
            }
            else
            {
                InfoBox.Items.Add("Niema wydzialow!");
            }
        }

        private void btnCreateThread_Click(object sender, EventArgs e)
        {
            StudentAPI.StudentAPI.CreateCategorie(TestBox.Text, (int)NumericBox.Value);
        }

        private void btnCreateDepartment_Click(object sender, EventArgs e)
        {
            StudentAPI.StudentAPI.CreateDepartment(TestBox.Text, (int)NumericBox.Value, "Test wydział");
        }

        private void btnCreateCurse_Click(object sender, EventArgs e)
        {
            StudentAPI.StudentAPI.CreateCurses(TestBox.Text, (int)NumericBox.Value);
        }

        private void btnAddCollage_Click(object sender, EventArgs e)
        {
            var list = new List<string>();

            list.Add("Test1");
            list.Add("Test2");
            list.Add("Test3");

            StudentAPI.StudentAPI.CreateCollege(TestBox.Text, list, "Testowy opis uczelni!");
        }

        private void btnCreateThread_Click_1(object sender, EventArgs e)
        {
            StudentAPI.StudentAPI.CreateThread((int)NumericBox.Value, TestBox.Text, TextCB.Checked);
        }

        private void btnCreatePost_Click(object sender, EventArgs e)
        {
            StudentAPI.StudentAPI.CreatePost((int)NumericBox.Value, TestBox.Text);
        }

        private async void btnThreads_Click(object sender, EventArgs e)
        {
            InfoBox.Items.Clear();
            var list = await StudentAPI.StudentAPI.GetThreadsListAsync((int)NumericBox.Value);
            if (list != null)
            {
                foreach (var item in list)
                {
                    InfoBox.Items.Add(item);
                }
            }
            else
            {
                InfoBox.Items.Add("Niema wydzialow!");
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEditPost_Click(object sender, EventArgs e)
        {
            StudentAPI.StudentAPI.EditPost((int)NumericBox.Value, TestBox.Text);
        }

        private void btnDeletePost_Click(object sender, EventArgs e)
        {
            StudentAPI.StudentAPI.DeletePost((int)NumericBox.Value);
        }
    }
}
