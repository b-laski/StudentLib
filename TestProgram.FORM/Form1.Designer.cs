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
            this.button2 = new System.Windows.Forms.Button();
            this.TestBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InfoBox
            // 
            this.InfoBox.FormattingEnabled = true;
            this.InfoBox.ItemHeight = 16;
            this.InfoBox.Location = new System.Drawing.Point(16, 15);
            this.InfoBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.Size = new System.Drawing.Size(1739, 356);
            this.InfoBox.TabIndex = 0;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(1764, 15);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(140, 28);
            this.btnSignIn.TabIndex = 1;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnLoadSession
            // 
            this.btnLoadSession.Location = new System.Drawing.Point(1764, 50);
            this.btnLoadSession.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoadSession.Name = "btnLoadSession";
            this.btnLoadSession.Size = new System.Drawing.Size(140, 28);
            this.btnLoadSession.TabIndex = 2;
            this.btnLoadSession.Text = "Load session";
            this.btnLoadSession.UseVisualStyleBackColor = true;
            this.btnLoadSession.Click += new System.EventHandler(this.btnLoadSession_Click);
            // 
            // btnLoadUser
            // 
            this.btnLoadUser.Location = new System.Drawing.Point(1764, 87);
            this.btnLoadUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoadUser.Name = "btnLoadUser";
            this.btnLoadUser.Size = new System.Drawing.Size(140, 28);
            this.btnLoadUser.TabIndex = 3;
            this.btnLoadUser.Text = "Show user!";
            this.btnLoadUser.UseVisualStyleBackColor = true;
            this.btnLoadUser.Click += new System.EventHandler(this.btnLoadUser_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(16, 448);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1888, 114);
            this.webBrowser1.TabIndex = 4;
            this.webBrowser1.Visible = false;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_FrameLoadStart);
            // 
            // btnLoadCollege
            // 
            this.btnLoadCollege.Location = new System.Drawing.Point(16, 379);
            this.btnLoadCollege.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoadCollege.Name = "btnLoadCollege";
            this.btnLoadCollege.Size = new System.Drawing.Size(100, 28);
            this.btnLoadCollege.TabIndex = 5;
            this.btnLoadCollege.Text = "Colleges";
            this.btnLoadCollege.UseVisualStyleBackColor = true;
            this.btnLoadCollege.Click += new System.EventHandler(this.btnLoadCollege_Click);
            // 
            // btnLoadDeparments
            // 
            this.btnLoadDeparments.Location = new System.Drawing.Point(124, 379);
            this.btnLoadDeparments.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoadDeparments.Name = "btnLoadDeparments";
            this.btnLoadDeparments.Size = new System.Drawing.Size(100, 28);
            this.btnLoadDeparments.TabIndex = 6;
            this.btnLoadDeparments.Text = "Departments";
            this.btnLoadDeparments.UseVisualStyleBackColor = true;
            this.btnLoadDeparments.Click += new System.EventHandler(this.btnLoadDeparments_Click);
            // 
            // btnLoadCategories
            // 
            this.btnLoadCategories.Location = new System.Drawing.Point(232, 379);
            this.btnLoadCategories.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoadCategories.Name = "btnLoadCategories";
            this.btnLoadCategories.Size = new System.Drawing.Size(100, 28);
            this.btnLoadCategories.TabIndex = 7;
            this.btnLoadCategories.Text = "Categories";
            this.btnLoadCategories.UseVisualStyleBackColor = true;
            this.btnLoadCategories.Click += new System.EventHandler(this.btnLoadCategories_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(340, 379);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // TestBox
            // 
            this.TestBox.Location = new System.Drawing.Point(14, 414);
            this.TestBox.Name = "TestBox";
            this.TestBox.Size = new System.Drawing.Size(208, 22);
            this.TestBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1914, 577);
            this.Controls.Add(this.TestBox);
            this.Controls.Add(this.button2);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TestBox;
    }
}

