namespace WindowsLogin
{
    partial class Registration
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
            this.BtnAddUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextboxUserName
            // 
            this.TextboxUserName.Location = new System.Drawing.Point(355, 134);
            this.TextboxUserName.Name = "TextboxUserName";
            this.TextboxUserName.Size = new System.Drawing.Size(317, 31);
            this.TextboxUserName.TabIndex = 0;
            // 
            // TextboxPassword
            // 
            this.TextboxPassword.Location = new System.Drawing.Point(355, 215);
            this.TextboxPassword.Name = "TextboxPassword";
            this.TextboxPassword.Size = new System.Drawing.Size(317, 31);
            this.TextboxPassword.TabIndex = 1;
            // 
            // BtnAddUser
            // 
            this.BtnAddUser.Location = new System.Drawing.Point(449, 280);
            this.BtnAddUser.Name = "BtnAddUser";
            this.BtnAddUser.Size = new System.Drawing.Size(223, 72);
            this.BtnAddUser.TabIndex = 2;
            this.BtnAddUser.Text = "ADD USER";
            this.BtnAddUser.UseVisualStyleBackColor = true;
            this.BtnAddUser.Click += new System.EventHandler(this.BtnAddUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "USERNAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "PASSWORD";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1230, 806);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAddUser);
            this.Controls.Add(this.TextboxPassword);
            this.Controls.Add(this.TextboxUserName);
            this.Name = "Registration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextboxUserName;
        private System.Windows.Forms.TextBox TextboxPassword;
        private System.Windows.Forms.Button BtnAddUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}