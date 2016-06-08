using System;
using System.Drawing;
namespace Test.Forms
{
    partial class logIn
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
            this.nicknameText = new System.Windows.Forms.TextBox();
            this.nickname = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.linkRegistration = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // nicknameText
            // 
            this.nicknameText.Location = new System.Drawing.Point(70, 29);
            this.nicknameText.Name = "nicknameText";
            this.nicknameText.Size = new System.Drawing.Size(210, 20);
            this.nicknameText.TabIndex = 0;
            // 
            // nickname
            // 
            this.nickname.AutoSize = true;
            this.nickname.Location = new System.Drawing.Point(135, 10);
            this.nickname.Name = "nickname";
            this.nickname.Size = new System.Drawing.Size(73, 15);
            this.nickname.TabIndex = 1;
            this.nickname.Text = "Псевдоним";
            this.nickname.Click += new System.EventHandler(this.label1_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(145, 58);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(51, 15);
            this.password.TabIndex = 2;
            this.password.Text = "Парола";
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(70, 76);
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '*';
            this.passwordText.Size = new System.Drawing.Size(210, 20);
            this.passwordText.TabIndex = 3;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(130, 106);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(90, 27);
            this.submit.TabIndex = 4;
            this.submit.Text = "Вписване";
            this.submit.UseVisualStyleBackColor = true;
            // 
            // linkRegistration
            // 
            this.linkRegistration.AutoSize = true;
            this.linkRegistration.Location = new System.Drawing.Point(85, 136);
            this.linkRegistration.Name = "linkRegistration";
            this.linkRegistration.Size = new System.Drawing.Size(180, 15);
            this.linkRegistration.TabIndex = 5;
            this.linkRegistration.TabStop = true;
            this.linkRegistration.Text = "Регистрирай се за нов акаунт";
            this.linkRegistration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRegistration_LinkClicked);
            // 
            // logIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(350, 160);
            this.Controls.Add(this.linkRegistration);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.password);
            this.Controls.Add(this.nickname);
            this.Controls.Add(this.nicknameText);
            this.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.Name = "logIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вписване";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nicknameText;
        private System.Windows.Forms.Label nickname;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.LinkLabel linkRegistration;
    }
}