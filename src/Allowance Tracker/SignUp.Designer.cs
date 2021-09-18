
namespace Allowance_Tracker
{
    partial class SignUp
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
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.userNameBox = new System.Windows.Forms.TextBox();
            this.signUpButton = new System.Windows.Forms.Button();
            this.hidePassword = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.errorBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // passwordBox
            // 
            this.passwordBox.AccessibleName = "emailLogin";
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.passwordBox.Location = new System.Drawing.Point(68, 237);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(248, 30);
            this.passwordBox.TabIndex = 1;
            this.passwordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // userNameBox
            // 
            this.userNameBox.AccessibleName = "emailLogin";
            this.userNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.userNameBox.Location = new System.Drawing.Point(68, 158);
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(248, 30);
            this.userNameBox.TabIndex = 2;
            this.userNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // signUpButton
            // 
            this.signUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.signUpButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.signUpButton.Location = new System.Drawing.Point(124, 296);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(137, 32);
            this.signUpButton.TabIndex = 8;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // hidePassword
            // 
            this.hidePassword.AutoSize = true;
            this.hidePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.hidePassword.ForeColor = System.Drawing.Color.DodgerBlue;
            this.hidePassword.Location = new System.Drawing.Point(148, 273);
            this.hidePassword.Name = "hidePassword";
            this.hidePassword.Size = new System.Drawing.Size(97, 17);
            this.hidePassword.TabIndex = 11;
            this.hidePassword.Text = "Hide Password";
            this.hidePassword.UseVisualStyleBackColor = true;
            this.hidePassword.CheckedChanged += new System.EventHandler(this.hidePassword_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.AccessibleName = "emailLogin";
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBox2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.textBox2.Location = new System.Drawing.Point(12, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(360, 31);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "Sign Up";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.AccessibleName = "emailLogin";
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.textBox3.Location = new System.Drawing.Point(12, 129);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(360, 23);
            this.textBox3.TabIndex = 13;
            this.textBox3.Text = "Username";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.AccessibleName = "";
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.textBox5.Location = new System.Drawing.Point(12, 208);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(360, 23);
            this.textBox5.TabIndex = 14;
            this.textBox5.Text = "Password:";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // errorBox
            // 
            this.errorBox.AccessibleName = "error";
            this.errorBox.BackColor = System.Drawing.Color.White;
            this.errorBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.errorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.errorBox.ForeColor = System.Drawing.Color.Crimson;
            this.errorBox.Location = new System.Drawing.Point(12, 347);
            this.errorBox.Multiline = true;
            this.errorBox.Name = "errorBox";
            this.errorBox.ReadOnly = true;
            this.errorBox.Size = new System.Drawing.Size(360, 60);
            this.errorBox.TabIndex = 15;
            this.errorBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.errorBox);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.hidePassword);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.userNameBox);
            this.Controls.Add(this.passwordBox);
            this.MaximumSize = new System.Drawing.Size(400, 500);
            this.MinimumSize = new System.Drawing.Size(400, 500);
            this.Name = "SignUp";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox userNameBox;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.CheckBox hidePassword;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox errorBox;
    }
}