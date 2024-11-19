namespace Lesson_17
{
    partial class FormAuthorization
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
            buttonEnter = new Button();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            linkLabelRegistration = new LinkLabel();
            SuspendLayout();
            // 
            // buttonEnter
            // 
            buttonEnter.Location = new Point(128, 163);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(75, 23);
            buttonEnter.TabIndex = 0;
            buttonEnter.Text = "OK";
            buttonEnter.UseVisualStyleBackColor = true;
            buttonEnter.Click += buttonEnter_Click;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(45, 35);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.PlaceholderText = "Введите логин";
            textBoxLogin.Size = new Size(285, 23);
            textBoxLogin.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(48, 81);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.PlaceholderText = "Введите пароль";
            textBoxPassword.Size = new Size(282, 23);
            textBoxPassword.TabIndex = 2;
            // 
            // linkLabelRegistration
            // 
            linkLabelRegistration.AutoSize = true;
            linkLabelRegistration.Location = new Point(53, 117);
            linkLabelRegistration.Name = "linkLabelRegistration";
            linkLabelRegistration.Size = new Size(119, 15);
            linkLabelRegistration.TabIndex = 3;
            linkLabelRegistration.TabStop = true;
            linkLabelRegistration.Text = "Зарегистрироавться";
            linkLabelRegistration.LinkClicked += linkLabelRegistration_LinkClicked;
            // 
            // FormAuthorization
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 230);
            Controls.Add(linkLabelRegistration);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(buttonEnter);
            Name = "FormAuthorization";
            Text = "FormAuthorization";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEnter;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private LinkLabel linkLabelRegistration;
    }
}