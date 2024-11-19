namespace Lesson_17
{
    partial class FormRegistration
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
            textBoxLogin = new TextBox();
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            textBoxEmail = new TextBox();
            textBoxPassword = new TextBox();
            textBoxPasswordRepeat = new TextBox();
            dateTimePickerBirth = new DateTimePicker();
            buttonReg = new Button();
            labelWarning = new Label();
            labelPasswordWarning = new Label();
            labelEmailWarning = new Label();
            comboBoxRole = new ComboBox();
            SuspendLayout();
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(45, 34);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.PlaceholderText = "Введите логин";
            textBoxLogin.Size = new Size(264, 23);
            textBoxLogin.TabIndex = 0;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(45, 80);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.PlaceholderText = "Введите имя";
            textBoxFirstName.Size = new Size(263, 23);
            textBoxFirstName.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(45, 123);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.PlaceholderText = "Введите фамилию";
            textBoxLastName.Size = new Size(263, 23);
            textBoxLastName.TabIndex = 2;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(45, 165);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.PlaceholderText = "Введите адрес эл.почты";
            textBoxEmail.Size = new Size(261, 23);
            textBoxEmail.TabIndex = 3;
            textBoxEmail.TextChanged += textBoxEmail_TextChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(42, 214);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.PlaceholderText = "Введите пароль";
            textBoxPassword.Size = new Size(262, 23);
            textBoxPassword.TabIndex = 4;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            // 
            // textBoxPasswordRepeat
            // 
            textBoxPasswordRepeat.Location = new Point(42, 266);
            textBoxPasswordRepeat.Name = "textBoxPasswordRepeat";
            textBoxPasswordRepeat.PasswordChar = '*';
            textBoxPasswordRepeat.PlaceholderText = "Подтвердите пароль";
            textBoxPasswordRepeat.Size = new Size(263, 23);
            textBoxPasswordRepeat.TabIndex = 5;
            textBoxPasswordRepeat.TextChanged += textBoxPasswordRepeat_TextChanged;
            // 
            // dateTimePickerBirth
            // 
            dateTimePickerBirth.Location = new Point(43, 307);
            dateTimePickerBirth.Name = "dateTimePickerBirth";
            dateTimePickerBirth.Size = new Size(262, 23);
            dateTimePickerBirth.TabIndex = 6;
            // 
            // buttonReg
            // 
            buttonReg.Location = new Point(79, 390);
            buttonReg.Name = "buttonReg";
            buttonReg.Size = new Size(174, 43);
            buttonReg.TabIndex = 7;
            buttonReg.Text = "Зарегистрироваться";
            buttonReg.UseVisualStyleBackColor = true;
            buttonReg.Click += buttonReg_Click;
            // 
            // labelWarning
            // 
            labelWarning.AutoSize = true;
            labelWarning.BackColor = Color.White;
            labelWarning.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelWarning.ForeColor = Color.Red;
            labelWarning.Location = new Point(46, 229);
            labelWarning.Name = "labelWarning";
            labelWarning.Size = new Size(0, 17);
            labelWarning.TabIndex = 8;
            // 
            // labelPasswordWarning
            // 
            labelPasswordWarning.AutoSize = true;
            labelPasswordWarning.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPasswordWarning.ForeColor = Color.Red;
            labelPasswordWarning.Location = new Point(43, 291);
            labelPasswordWarning.Name = "labelPasswordWarning";
            labelPasswordWarning.Size = new Size(0, 21);
            labelPasswordWarning.TabIndex = 9;
            // 
            // labelEmailWarning
            // 
            labelEmailWarning.AutoSize = true;
            labelEmailWarning.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmailWarning.ForeColor = Color.Red;
            labelEmailWarning.Location = new Point(46, 192);
            labelEmailWarning.Name = "labelEmailWarning";
            labelEmailWarning.Size = new Size(0, 17);
            labelEmailWarning.TabIndex = 10;
            // 
            // comboBoxRole
            // 
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "Автор", "Читатель" });
            comboBoxRole.Location = new Point(44, 343);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(260, 23);
            comboBoxRole.TabIndex = 11;
            comboBoxRole.SelectedIndexChanged += comboBoxRole_SelectedIndexChanged;
            // 
            // FormRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 460);
            Controls.Add(comboBoxRole);
            Controls.Add(labelEmailWarning);
            Controls.Add(labelPasswordWarning);
            Controls.Add(labelWarning);
            Controls.Add(buttonReg);
            Controls.Add(dateTimePickerBirth);
            Controls.Add(textBoxPasswordRepeat);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(textBoxLogin);
            Name = "FormRegistration";
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxLogin;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private TextBox textBoxEmail;
        private TextBox textBoxPassword;
        private TextBox textBoxPasswordRepeat;
        private DateTimePicker dateTimePickerBirth;
        private Button buttonReg;
        private Label labelWarning;
        private Label labelPasswordWarning;
        private Label labelEmailWarning;
        public ComboBox comboBoxRole;
    }
}