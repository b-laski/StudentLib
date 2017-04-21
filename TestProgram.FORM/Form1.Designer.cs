namespace TestProgram.FORM
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InfoBox = new System.Windows.Forms.ListBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnLoadSession = new System.Windows.Forms.Button();
            this.btnLoadUser = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnLoadCollege = new System.Windows.Forms.Button();
            this.btnLoadDeparments = new System.Windows.Forms.Button();
            this.btnLoadCategories = new System.Windows.Forms.Button();
            this.btnCreateDepartment = new System.Windows.Forms.Button();
            this.TestBox = new System.Windows.Forms.TextBox();
            this.NumericBox = new System.Windows.Forms.NumericUpDown();
            this.btnAddCollage = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.btnThreads = new System.Windows.Forms.Button();
            this.btnCreateCategories = new System.Windows.Forms.Button();
            this.btnCreateCurse = new System.Windows.Forms.Button();
            this.btnCreateThread = new System.Windows.Forms.Button();
            this.btnCreatePost = new System.Windows.Forms.Button();
            this.TextCB = new System.Windows.Forms.CheckBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnDeletePost = new System.Windows.Forms.Button();
            this.btnEditPost = new System.Windows.Forms.Button();
            this.btnPosts = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCreateComment = new System.Windows.Forms.Button();
            this.btnComments = new System.Windows.Forms.Button();
            this.btnMembers = new System.Windows.Forms.Button();
            this.btnJoin = new System.Windows.Forms.Button();
            this.btnLeave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumericBox)).BeginInit();
            this.SuspendLayout();
            // 
            // InfoBox
            // 
            this.InfoBox.FormattingEnabled = true;
            this.InfoBox.ItemHeight = 16;
            this.InfoBox.Location = new System.Drawing.Point(21, 18);
            this.InfoBox.Margin = new System.Windows.Forms.Padding(5);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.Size = new System.Drawing.Size(1251, 692);
            this.InfoBox.TabIndex = 0;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(1285, 18);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(5);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(140, 28);
            this.btnSignIn.TabIndex = 1;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnLoadSession
            // 
            this.btnLoadSession.Location = new System.Drawing.Point(1285, 57);
            this.btnLoadSession.Margin = new System.Windows.Forms.Padding(5);
            this.btnLoadSession.Name = "btnLoadSession";
            this.btnLoadSession.Size = new System.Drawing.Size(140, 28);
            this.btnLoadSession.TabIndex = 2;
            this.btnLoadSession.Text = "Load session";
            this.btnLoadSession.UseVisualStyleBackColor = true;
            this.btnLoadSession.Click += new System.EventHandler(this.btnLoadSession_Click);
            // 
            // btnLoadUser
            // 
            this.btnLoadUser.Location = new System.Drawing.Point(1285, 95);
            this.btnLoadUser.Margin = new System.Windows.Forms.Padding(5);
            this.btnLoadUser.Name = "btnLoadUser";
            this.btnLoadUser.Size = new System.Drawing.Size(140, 28);
            this.btnLoadUser.TabIndex = 3;
            this.btnLoadUser.Text = "Show user!";
            this.btnLoadUser.UseVisualStyleBackColor = true;
            this.btnLoadUser.Click += new System.EventHandler(this.btnLoadUser_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(21, 807);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(5);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(36, 31);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1404, 140);
            this.webBrowser1.TabIndex = 4;
            this.webBrowser1.Visible = false;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_FrameLoadStart);
            // 
            // btnLoadCollege
            // 
            this.btnLoadCollege.Location = new System.Drawing.Point(21, 730);
            this.btnLoadCollege.Margin = new System.Windows.Forms.Padding(5);
            this.btnLoadCollege.Name = "btnLoadCollege";
            this.btnLoadCollege.Size = new System.Drawing.Size(100, 28);
            this.btnLoadCollege.TabIndex = 5;
            this.btnLoadCollege.Text = "Colleges";
            this.btnLoadCollege.UseVisualStyleBackColor = true;
            this.btnLoadCollege.Click += new System.EventHandler(this.btnLoadCollege_Click);
            // 
            // btnLoadDeparments
            // 
            this.btnLoadDeparments.Location = new System.Drawing.Point(21, 769);
            this.btnLoadDeparments.Margin = new System.Windows.Forms.Padding(5);
            this.btnLoadDeparments.Name = "btnLoadDeparments";
            this.btnLoadDeparments.Size = new System.Drawing.Size(100, 28);
            this.btnLoadDeparments.TabIndex = 6;
            this.btnLoadDeparments.Text = "Departments";
            this.btnLoadDeparments.UseVisualStyleBackColor = true;
            this.btnLoadDeparments.Click += new System.EventHandler(this.btnLoadDeparments_Click);
            // 
            // btnLoadCategories
            // 
            this.btnLoadCategories.Location = new System.Drawing.Point(132, 730);
            this.btnLoadCategories.Margin = new System.Windows.Forms.Padding(5);
            this.btnLoadCategories.Name = "btnLoadCategories";
            this.btnLoadCategories.Size = new System.Drawing.Size(100, 28);
            this.btnLoadCategories.TabIndex = 7;
            this.btnLoadCategories.Text = "Categories";
            this.btnLoadCategories.UseVisualStyleBackColor = true;
            this.btnLoadCategories.Click += new System.EventHandler(this.btnLoadCategories_Click);
            // 
            // btnCreateDepartment
            // 
            this.btnCreateDepartment.Location = new System.Drawing.Point(1285, 169);
            this.btnCreateDepartment.Margin = new System.Windows.Forms.Padding(5);
            this.btnCreateDepartment.Name = "btnCreateDepartment";
            this.btnCreateDepartment.Size = new System.Drawing.Size(140, 28);
            this.btnCreateDepartment.TabIndex = 8;
            this.btnCreateDepartment.Text = "CreateDepartment";
            this.btnCreateDepartment.UseVisualStyleBackColor = true;
            this.btnCreateDepartment.Click += new System.EventHandler(this.btnCreateDepartment_Click);
            // 
            // TestBox
            // 
            this.TestBox.Location = new System.Drawing.Point(816, 730);
            this.TestBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TestBox.Name = "TestBox";
            this.TestBox.Size = new System.Drawing.Size(209, 22);
            this.TestBox.TabIndex = 9;
            // 
            // NumericBox
            // 
            this.NumericBox.Location = new System.Drawing.Point(816, 761);
            this.NumericBox.Margin = new System.Windows.Forms.Padding(4);
            this.NumericBox.Name = "NumericBox";
            this.NumericBox.Size = new System.Drawing.Size(211, 22);
            this.NumericBox.TabIndex = 10;
            // 
            // btnAddCollage
            // 
            this.btnAddCollage.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAddCollage.Location = new System.Drawing.Point(1285, 132);
            this.btnAddCollage.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCollage.Name = "btnAddCollage";
            this.btnAddCollage.Size = new System.Drawing.Size(140, 28);
            this.btnAddCollage.TabIndex = 11;
            this.btnAddCollage.Text = "CreateCollega";
            this.btnAddCollage.UseVisualStyleBackColor = true;
            this.btnAddCollage.Click += new System.EventHandler(this.btnAddCollage_Click);
            // 
            // btnCourses
            // 
            this.btnCourses.Location = new System.Drawing.Point(132, 767);
            this.btnCourses.Margin = new System.Windows.Forms.Padding(4);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(100, 28);
            this.btnCourses.TabIndex = 12;
            this.btnCourses.Text = "Courses";
            this.btnCourses.UseVisualStyleBackColor = true;
            this.btnCourses.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnThreads
            // 
            this.btnThreads.Location = new System.Drawing.Point(241, 730);
            this.btnThreads.Margin = new System.Windows.Forms.Padding(4);
            this.btnThreads.Name = "btnThreads";
            this.btnThreads.Size = new System.Drawing.Size(100, 28);
            this.btnThreads.TabIndex = 13;
            this.btnThreads.Text = "Threads";
            this.btnThreads.UseVisualStyleBackColor = true;
            this.btnThreads.Click += new System.EventHandler(this.btnThreads_Click);
            // 
            // btnCreateCategories
            // 
            this.btnCreateCategories.Location = new System.Drawing.Point(1285, 207);
            this.btnCreateCategories.Margin = new System.Windows.Forms.Padding(5);
            this.btnCreateCategories.Name = "btnCreateCategories";
            this.btnCreateCategories.Size = new System.Drawing.Size(140, 28);
            this.btnCreateCategories.TabIndex = 14;
            this.btnCreateCategories.Text = "CreateCategories";
            this.btnCreateCategories.UseVisualStyleBackColor = true;
            this.btnCreateCategories.Click += new System.EventHandler(this.btnCreateThread_Click);
            // 
            // btnCreateCurse
            // 
            this.btnCreateCurse.Location = new System.Drawing.Point(1285, 245);
            this.btnCreateCurse.Margin = new System.Windows.Forms.Padding(5);
            this.btnCreateCurse.Name = "btnCreateCurse";
            this.btnCreateCurse.Size = new System.Drawing.Size(140, 28);
            this.btnCreateCurse.TabIndex = 15;
            this.btnCreateCurse.Text = "CreateCurse";
            this.btnCreateCurse.UseVisualStyleBackColor = true;
            this.btnCreateCurse.Click += new System.EventHandler(this.btnCreateCurse_Click);
            // 
            // btnCreateThread
            // 
            this.btnCreateThread.Location = new System.Drawing.Point(1285, 283);
            this.btnCreateThread.Margin = new System.Windows.Forms.Padding(5);
            this.btnCreateThread.Name = "btnCreateThread";
            this.btnCreateThread.Size = new System.Drawing.Size(140, 28);
            this.btnCreateThread.TabIndex = 16;
            this.btnCreateThread.Text = "CreateThread";
            this.btnCreateThread.UseVisualStyleBackColor = true;
            this.btnCreateThread.Click += new System.EventHandler(this.btnCreateThread_Click_1);
            // 
            // btnCreatePost
            // 
            this.btnCreatePost.Location = new System.Drawing.Point(1284, 321);
            this.btnCreatePost.Margin = new System.Windows.Forms.Padding(5);
            this.btnCreatePost.Name = "btnCreatePost";
            this.btnCreatePost.Size = new System.Drawing.Size(140, 28);
            this.btnCreatePost.TabIndex = 17;
            this.btnCreatePost.Text = "CreatePost";
            this.btnCreatePost.UseVisualStyleBackColor = true;
            this.btnCreatePost.Click += new System.EventHandler(this.btnCreatePost_Click);
            // 
            // TextCB
            // 
            this.TextCB.AutoSize = true;
            this.TextCB.Location = new System.Drawing.Point(1033, 732);
            this.TextCB.Margin = new System.Windows.Forms.Padding(4);
            this.TextCB.Name = "TextCB";
            this.TextCB.Size = new System.Drawing.Size(162, 21);
            this.TextCB.TabIndex = 18;
            this.TextCB.Text = "Kontrolka True/False";
            this.TextCB.UseVisualStyleBackColor = true;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(1324, 761);
            this.btnTest.Margin = new System.Windows.Forms.Padding(4);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(100, 28);
            this.btnTest.TabIndex = 19;
            this.btnTest.Text = "TestButton";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnDeletePost
            // 
            this.btnDeletePost.Location = new System.Drawing.Point(1285, 398);
            this.btnDeletePost.Margin = new System.Windows.Forms.Padding(5);
            this.btnDeletePost.Name = "btnDeletePost";
            this.btnDeletePost.Size = new System.Drawing.Size(140, 28);
            this.btnDeletePost.TabIndex = 20;
            this.btnDeletePost.Text = "Delete Post";
            this.btnDeletePost.UseVisualStyleBackColor = true;
            this.btnDeletePost.Click += new System.EventHandler(this.btnDeletePost_Click);
            // 
            // btnEditPost
            // 
            this.btnEditPost.Location = new System.Drawing.Point(1284, 359);
            this.btnEditPost.Margin = new System.Windows.Forms.Padding(5);
            this.btnEditPost.Name = "btnEditPost";
            this.btnEditPost.Size = new System.Drawing.Size(140, 28);
            this.btnEditPost.TabIndex = 21;
            this.btnEditPost.Text = "EditPost";
            this.btnEditPost.UseVisualStyleBackColor = true;
            this.btnEditPost.Click += new System.EventHandler(this.btnEditPost_Click);
            // 
            // btnPosts
            // 
            this.btnPosts.Location = new System.Drawing.Point(241, 766);
            this.btnPosts.Margin = new System.Windows.Forms.Padding(4);
            this.btnPosts.Name = "btnPosts";
            this.btnPosts.Size = new System.Drawing.Size(100, 28);
            this.btnPosts.TabIndex = 22;
            this.btnPosts.Text = "Posts";
            this.btnPosts.UseVisualStyleBackColor = true;
            this.btnPosts.Click += new System.EventHandler(this.btnPosts_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1285, 436);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 28);
            this.button1.TabIndex = 23;
            this.button1.Text = "Delete Post";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnCreateComment
            // 
            this.btnCreateComment.Location = new System.Drawing.Point(1285, 474);
            this.btnCreateComment.Margin = new System.Windows.Forms.Padding(5);
            this.btnCreateComment.Name = "btnCreateComment";
            this.btnCreateComment.Size = new System.Drawing.Size(140, 28);
            this.btnCreateComment.TabIndex = 24;
            this.btnCreateComment.Text = "Create Comment";
            this.btnCreateComment.UseVisualStyleBackColor = true;
            this.btnCreateComment.Click += new System.EventHandler(this.btnCreateComment_Click);
            // 
            // btnComments
            // 
            this.btnComments.Location = new System.Drawing.Point(349, 730);
            this.btnComments.Margin = new System.Windows.Forms.Padding(4);
            this.btnComments.Name = "btnComments";
            this.btnComments.Size = new System.Drawing.Size(100, 28);
            this.btnComments.TabIndex = 25;
            this.btnComments.Text = "Comments";
            this.btnComments.UseVisualStyleBackColor = true;
            this.btnComments.Click += new System.EventHandler(this.btnComments_Click);
            // 
            // btnMembers
            // 
            this.btnMembers.Location = new System.Drawing.Point(349, 766);
            this.btnMembers.Margin = new System.Windows.Forms.Padding(4);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Size = new System.Drawing.Size(100, 28);
            this.btnMembers.TabIndex = 26;
            this.btnMembers.Text = "Members";
            this.btnMembers.UseVisualStyleBackColor = true;
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(1285, 512);
            this.btnJoin.Margin = new System.Windows.Forms.Padding(5);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(140, 28);
            this.btnJoin.TabIndex = 27;
            this.btnJoin.Text = "Join to group";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // btnLeave
            // 
            this.btnLeave.Location = new System.Drawing.Point(1285, 550);
            this.btnLeave.Margin = new System.Windows.Forms.Padding(5);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(140, 28);
            this.btnLeave.TabIndex = 28;
            this.btnLeave.Text = "Leave from group";
            this.btnLeave.UseVisualStyleBackColor = true;
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 964);
            this.Controls.Add(this.btnLeave);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.btnMembers);
            this.Controls.Add(this.btnComments);
            this.Controls.Add(this.btnCreateComment);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPosts);
            this.Controls.Add(this.btnEditPost);
            this.Controls.Add(this.btnDeletePost);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.TextCB);
            this.Controls.Add(this.btnCreatePost);
            this.Controls.Add(this.btnCreateThread);
            this.Controls.Add(this.btnCreateCurse);
            this.Controls.Add(this.btnCreateCategories);
            this.Controls.Add(this.btnThreads);
            this.Controls.Add(this.btnCourses);
            this.Controls.Add(this.btnAddCollage);
            this.Controls.Add(this.NumericBox);
            this.Controls.Add(this.TestBox);
            this.Controls.Add(this.btnCreateDepartment);
            this.Controls.Add(this.btnLoadCategories);
            this.Controls.Add(this.btnLoadDeparments);
            this.Controls.Add(this.btnLoadCollege);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnLoadUser);
            this.Controls.Add(this.btnLoadSession);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.InfoBox);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox InfoBox;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnLoadSession;
        private System.Windows.Forms.Button btnLoadUser;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnLoadCollege;
        private System.Windows.Forms.Button btnLoadDeparments;
        private System.Windows.Forms.Button btnLoadCategories;
        private System.Windows.Forms.Button btnCreateDepartment;
        private System.Windows.Forms.TextBox TestBox;
        private System.Windows.Forms.NumericUpDown NumericBox;
        private System.Windows.Forms.Button btnAddCollage;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Button btnThreads;
        private System.Windows.Forms.Button btnCreateCategories;
        private System.Windows.Forms.Button btnCreateCurse;
        private System.Windows.Forms.Button btnCreateThread;
        private System.Windows.Forms.Button btnCreatePost;
        private System.Windows.Forms.CheckBox TextCB;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnDeletePost;
        private System.Windows.Forms.Button btnEditPost;
        private System.Windows.Forms.Button btnPosts;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCreateComment;
        private System.Windows.Forms.Button btnComments;
        private System.Windows.Forms.Button btnMembers;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Button btnLeave;
    }
}

