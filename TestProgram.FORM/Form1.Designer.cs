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
            this.btnGroups = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumericBox)).BeginInit();
            this.SuspendLayout();
            // 
            // InfoBox
            // 
            this.InfoBox.FormattingEnabled = true;
            this.InfoBox.Location = new System.Drawing.Point(16, 15);
            this.InfoBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.Size = new System.Drawing.Size(939, 563);
            this.InfoBox.TabIndex = 0;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(964, 15);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(105, 23);
            this.btnSignIn.TabIndex = 1;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnLoadSession
            // 
            this.btnLoadSession.Location = new System.Drawing.Point(964, 46);
            this.btnLoadSession.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoadSession.Name = "btnLoadSession";
            this.btnLoadSession.Size = new System.Drawing.Size(105, 23);
            this.btnLoadSession.TabIndex = 2;
            this.btnLoadSession.Text = "Load session";
            this.btnLoadSession.UseVisualStyleBackColor = true;
            this.btnLoadSession.Click += new System.EventHandler(this.btnLoadSession_Click);
            // 
            // btnLoadUser
            // 
            this.btnLoadUser.Location = new System.Drawing.Point(964, 77);
            this.btnLoadUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoadUser.Name = "btnLoadUser";
            this.btnLoadUser.Size = new System.Drawing.Size(105, 23);
            this.btnLoadUser.TabIndex = 3;
            this.btnLoadUser.Text = "Show user!";
            this.btnLoadUser.UseVisualStyleBackColor = true;
            this.btnLoadUser.Click += new System.EventHandler(this.btnLoadUser_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(16, 656);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1053, 114);
            this.webBrowser1.TabIndex = 4;
            this.webBrowser1.Visible = false;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_FrameLoadStart);
            // 
            // btnLoadCollege
            // 
            this.btnLoadCollege.Location = new System.Drawing.Point(16, 593);
            this.btnLoadCollege.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoadCollege.Name = "btnLoadCollege";
            this.btnLoadCollege.Size = new System.Drawing.Size(75, 23);
            this.btnLoadCollege.TabIndex = 5;
            this.btnLoadCollege.Text = "Colleges";
            this.btnLoadCollege.UseVisualStyleBackColor = true;
            this.btnLoadCollege.Click += new System.EventHandler(this.btnLoadCollege_Click);
            // 
            // btnLoadDeparments
            // 
            this.btnLoadDeparments.Location = new System.Drawing.Point(16, 625);
            this.btnLoadDeparments.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoadDeparments.Name = "btnLoadDeparments";
            this.btnLoadDeparments.Size = new System.Drawing.Size(75, 23);
            this.btnLoadDeparments.TabIndex = 6;
            this.btnLoadDeparments.Text = "Departments";
            this.btnLoadDeparments.UseVisualStyleBackColor = true;
            this.btnLoadDeparments.Click += new System.EventHandler(this.btnLoadDeparments_Click);
            // 
            // btnLoadCategories
            // 
            this.btnLoadCategories.Location = new System.Drawing.Point(99, 593);
            this.btnLoadCategories.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoadCategories.Name = "btnLoadCategories";
            this.btnLoadCategories.Size = new System.Drawing.Size(75, 23);
            this.btnLoadCategories.TabIndex = 7;
            this.btnLoadCategories.Text = "Categories";
            this.btnLoadCategories.UseVisualStyleBackColor = true;
            this.btnLoadCategories.Click += new System.EventHandler(this.btnLoadCategories_Click);
            // 
            // btnCreateDepartment
            // 
            this.btnCreateDepartment.Location = new System.Drawing.Point(964, 137);
            this.btnCreateDepartment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateDepartment.Name = "btnCreateDepartment";
            this.btnCreateDepartment.Size = new System.Drawing.Size(105, 23);
            this.btnCreateDepartment.TabIndex = 8;
            this.btnCreateDepartment.Text = "CreateDepartment";
            this.btnCreateDepartment.UseVisualStyleBackColor = true;
            this.btnCreateDepartment.Click += new System.EventHandler(this.btnCreateDepartment_Click);
            // 
            // TestBox
            // 
            this.TestBox.Location = new System.Drawing.Point(612, 593);
            this.TestBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TestBox.Name = "TestBox";
            this.TestBox.Size = new System.Drawing.Size(158, 20);
            this.TestBox.TabIndex = 9;
            // 
            // NumericBox
            // 
            this.NumericBox.Location = new System.Drawing.Point(612, 618);
            this.NumericBox.Name = "NumericBox";
            this.NumericBox.Size = new System.Drawing.Size(158, 20);
            this.NumericBox.TabIndex = 10;
            // 
            // btnAddCollage
            // 
            this.btnAddCollage.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAddCollage.Location = new System.Drawing.Point(964, 107);
            this.btnAddCollage.Name = "btnAddCollage";
            this.btnAddCollage.Size = new System.Drawing.Size(105, 23);
            this.btnAddCollage.TabIndex = 11;
            this.btnAddCollage.Text = "CreateCollega";
            this.btnAddCollage.UseVisualStyleBackColor = true;
            this.btnAddCollage.Click += new System.EventHandler(this.btnAddCollage_Click);
            // 
            // btnCourses
            // 
            this.btnCourses.Location = new System.Drawing.Point(99, 623);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(75, 23);
            this.btnCourses.TabIndex = 12;
            this.btnCourses.Text = "Courses";
            this.btnCourses.UseVisualStyleBackColor = true;
            this.btnCourses.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnThreads
            // 
            this.btnThreads.Location = new System.Drawing.Point(181, 593);
            this.btnThreads.Name = "btnThreads";
            this.btnThreads.Size = new System.Drawing.Size(75, 23);
            this.btnThreads.TabIndex = 13;
            this.btnThreads.Text = "Threads";
            this.btnThreads.UseVisualStyleBackColor = true;
            this.btnThreads.Click += new System.EventHandler(this.btnThreads_Click);
            // 
            // btnCreateCategories
            // 
            this.btnCreateCategories.Location = new System.Drawing.Point(964, 168);
            this.btnCreateCategories.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateCategories.Name = "btnCreateCategories";
            this.btnCreateCategories.Size = new System.Drawing.Size(105, 23);
            this.btnCreateCategories.TabIndex = 14;
            this.btnCreateCategories.Text = "CreateCategories";
            this.btnCreateCategories.UseVisualStyleBackColor = true;
            this.btnCreateCategories.Click += new System.EventHandler(this.btnCreateThread_Click);
            // 
            // btnCreateCurse
            // 
            this.btnCreateCurse.Location = new System.Drawing.Point(964, 199);
            this.btnCreateCurse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateCurse.Name = "btnCreateCurse";
            this.btnCreateCurse.Size = new System.Drawing.Size(105, 23);
            this.btnCreateCurse.TabIndex = 15;
            this.btnCreateCurse.Text = "CreateCurse";
            this.btnCreateCurse.UseVisualStyleBackColor = true;
            this.btnCreateCurse.Click += new System.EventHandler(this.btnCreateCurse_Click);
            // 
            // btnCreateThread
            // 
            this.btnCreateThread.Location = new System.Drawing.Point(964, 230);
            this.btnCreateThread.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateThread.Name = "btnCreateThread";
            this.btnCreateThread.Size = new System.Drawing.Size(105, 23);
            this.btnCreateThread.TabIndex = 16;
            this.btnCreateThread.Text = "CreateThread";
            this.btnCreateThread.UseVisualStyleBackColor = true;
            this.btnCreateThread.Click += new System.EventHandler(this.btnCreateThread_Click_1);
            // 
            // btnCreatePost
            // 
            this.btnCreatePost.Location = new System.Drawing.Point(963, 261);
            this.btnCreatePost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreatePost.Name = "btnCreatePost";
            this.btnCreatePost.Size = new System.Drawing.Size(105, 23);
            this.btnCreatePost.TabIndex = 17;
            this.btnCreatePost.Text = "CreatePost";
            this.btnCreatePost.UseVisualStyleBackColor = true;
            this.btnCreatePost.Click += new System.EventHandler(this.btnCreatePost_Click);
            // 
            // TextCB
            // 
            this.TextCB.AutoSize = true;
            this.TextCB.Location = new System.Drawing.Point(775, 595);
            this.TextCB.Name = "TextCB";
            this.TextCB.Size = new System.Drawing.Size(126, 17);
            this.TextCB.TabIndex = 18;
            this.TextCB.Text = "Kontrolka True/False";
            this.TextCB.UseVisualStyleBackColor = true;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(993, 618);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 19;
            this.btnTest.Text = "TestButton";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnDeletePost
            // 
            this.btnDeletePost.Location = new System.Drawing.Point(964, 323);
            this.btnDeletePost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeletePost.Name = "btnDeletePost";
            this.btnDeletePost.Size = new System.Drawing.Size(105, 23);
            this.btnDeletePost.TabIndex = 20;
            this.btnDeletePost.Text = "Delete Post";
            this.btnDeletePost.UseVisualStyleBackColor = true;
            this.btnDeletePost.Click += new System.EventHandler(this.btnDeletePost_Click);
            // 
            // btnEditPost
            // 
            this.btnEditPost.Location = new System.Drawing.Point(963, 292);
            this.btnEditPost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditPost.Name = "btnEditPost";
            this.btnEditPost.Size = new System.Drawing.Size(105, 23);
            this.btnEditPost.TabIndex = 21;
            this.btnEditPost.Text = "EditPost";
            this.btnEditPost.UseVisualStyleBackColor = true;
            this.btnEditPost.Click += new System.EventHandler(this.btnEditPost_Click);
            // 
            // btnPosts
            // 
            this.btnPosts.Location = new System.Drawing.Point(181, 622);
            this.btnPosts.Name = "btnPosts";
            this.btnPosts.Size = new System.Drawing.Size(75, 23);
            this.btnPosts.TabIndex = 22;
            this.btnPosts.Text = "Posts";
            this.btnPosts.UseVisualStyleBackColor = true;
            this.btnPosts.Click += new System.EventHandler(this.btnPosts_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(964, 354);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Delete Post";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnCreateComment
            // 
            this.btnCreateComment.Location = new System.Drawing.Point(964, 385);
            this.btnCreateComment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateComment.Name = "btnCreateComment";
            this.btnCreateComment.Size = new System.Drawing.Size(105, 23);
            this.btnCreateComment.TabIndex = 24;
            this.btnCreateComment.Text = "Create Comment";
            this.btnCreateComment.UseVisualStyleBackColor = true;
            this.btnCreateComment.Click += new System.EventHandler(this.btnCreateComment_Click);
            // 
            // btnComments
            // 
            this.btnComments.Location = new System.Drawing.Point(262, 593);
            this.btnComments.Name = "btnComments";
            this.btnComments.Size = new System.Drawing.Size(75, 23);
            this.btnComments.TabIndex = 25;
            this.btnComments.Text = "Comments";
            this.btnComments.UseVisualStyleBackColor = true;
            this.btnComments.Click += new System.EventHandler(this.btnComments_Click);
            // 
            // btnMembers
            // 
            this.btnMembers.Location = new System.Drawing.Point(262, 622);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Size = new System.Drawing.Size(75, 23);
            this.btnMembers.TabIndex = 26;
            this.btnMembers.Text = "Members";
            this.btnMembers.UseVisualStyleBackColor = true;
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(964, 416);
            this.btnJoin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(105, 23);
            this.btnJoin.TabIndex = 27;
            this.btnJoin.Text = "Join to group";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // btnLeave
            // 
            this.btnLeave.Location = new System.Drawing.Point(964, 447);
            this.btnLeave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(105, 23);
            this.btnLeave.TabIndex = 28;
            this.btnLeave.Text = "Leave from group";
            this.btnLeave.UseVisualStyleBackColor = true;
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // btnGroups
            // 
            this.btnGroups.Location = new System.Drawing.Point(343, 593);
            this.btnGroups.Name = "btnGroups";
            this.btnGroups.Size = new System.Drawing.Size(75, 23);
            this.btnGroups.TabIndex = 29;
            this.btnGroups.Text = "MyGroups";
            this.btnGroups.UseVisualStyleBackColor = true;
            this.btnGroups.Click += new System.EventHandler(this.btnGroups_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 783);
            this.Controls.Add(this.btnGroups);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button btnGroups;
    }
}

