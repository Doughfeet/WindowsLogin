namespace WindowsLogin
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
            this.TextboxUserName = new System.Windows.Forms.TextBox();
            this.TextboxPassword = new System.Windows.Forms.TextBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.UserName = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginWindow = new System.Windows.Forms.Panel();
            this.BtnNewUser = new System.Windows.Forms.Button();
            this.LoginWindow.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextboxUserName
            // 
            this.TextboxUserName.Location = new System.Drawing.Point(463, 36);
            this.TextboxUserName.Name = "TextboxUserName";
            this.TextboxUserName.Size = new System.Drawing.Size(415, 31);
            this.TextboxUserName.TabIndex = 0;
            this.TextboxUserName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TextboxPassword
            // 
            this.TextboxPassword.Location = new System.Drawing.Point(463, 87);
            this.TextboxPassword.Name = "TextboxPassword";
            this.TextboxPassword.Size = new System.Drawing.Size(415, 31);
            this.TextboxPassword.TabIndex = 1;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(463, 150);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(202, 42);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.Text = "E&XIT";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(676, 150);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(202, 42);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.Text = "LOGIN";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(323, 42);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(113, 25);
            this.UserName.TabIndex = 4;
            this.UserName.Text = "UserName";
            this.UserName.Click += new System.EventHandler(this.label1_Click);
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Location = new System.Drawing.Point(323, 93);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(106, 25);
            this.LabelPassword.TabIndex = 5;
            this.LabelPassword.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "LOGIN";
            // 
            // LoginWindow
            // 
            this.LoginWindow.BackColor = System.Drawing.Color.DodgerBlue;
            this.LoginWindow.Controls.Add(this.label3);
            this.LoginWindow.Location = new System.Drawing.Point(22, 21);
            this.LoginWindow.Name = "LoginWindow";
            this.LoginWindow.Size = new System.Drawing.Size(276, 241);
            this.LoginWindow.TabIndex = 7;
            // 
            // BtnNewUser
            // 
            this.BtnNewUser.Location = new System.Drawing.Point(463, 198);
            this.BtnNewUser.Name = "BtnNewUser";
            this.BtnNewUser.Size = new System.Drawing.Size(413, 43);
            this.BtnNewUser.TabIndex = 8;
            this.BtnNewUser.Text = "New user";
            this.BtnNewUser.UseVisualStyleBackColor = true;
            this.BtnNewUser.Click += new System.EventHandler(this.BtnNewUser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(926, 274);
            this.Controls.Add(this.BtnNewUser);
            this.Controls.Add(this.LoginWindow);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.TextboxPassword);
            this.Controls.Add(this.TextboxUserName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.LoginWindow.ResumeLayout(false);
            this.LoginWindow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextboxUserName;
        private System.Windows.Forms.TextBox TextboxPassword;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel LoginWindow;
        private System.Windows.Forms.Button BtnNewUser;
    }
}

