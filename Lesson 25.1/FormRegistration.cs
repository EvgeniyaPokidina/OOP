using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_17
{
    public partial class FormRegistration : Form
    {
        private UserRegistration userRegistration;
        public FormRegistration()
        {
            InitializeComponent();
            userRegistration = new UserRegistration();
            buttonReg.Enabled = false;
        }


        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox)!.Text.Length < 6)
            {
                labelWarning.Text = "Длина пароля должна быть больше 7 символов";
                return;
            }
            labelWarning.Text = "";
        }

        private void textBoxPasswordRepeat_TextChanged(object sender, EventArgs e)
        {
            string text = (sender as TextBox)!.Text;
            if (text != textBoxPassword.Text)
            {
                labelPasswordWarning.Text = "Пароли должны совпадать";
                return;
            }
            labelPasswordWarning.Text = "";
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            string? pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
            if (!Regex.IsMatch((sender as TextBox)!.Text, pattern,
                    RegexOptions.IgnoreCase))
            {
                labelEmailWarning.Text = "Не соответствует email";
                return;
            }
            labelEmailWarning.Text = "";
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            if (userRegistration.ExistUser(textBoxLogin.Text))
            {
                MessageBox.Show("Пользователь с таким логином существует!");
                return;
            }
            int id = userRegistration.Users.Count + 1;
            User user = new User();
            user.Id = id;
            user.UserName = textBoxLogin.Text;
            user.FirstName = textBoxFirstName.Text;
            user.SecondName = textBoxLastName.Text;
            user.Email = textBoxEmail.Text;
            user.RegistrationDate = DateTime.Now;
            user.BirthDate = dateTimePickerBirth.Value;
            user.Role = comboBoxRole.SelectedItem.ToString();
            user.Password = userRegistration.Hash(textBoxPassword.Text);
            userRegistration.RegisterUser(user);
            userRegistration.SerializeUsersToJson(userRegistration.Users);
            this.Close();
        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBoxLogin.Text!=""&&
                textBoxFirstName.Text!=""&&
                textBoxLastName.Text!="" && 
                textBoxPassword.Text.Length>=6&&
                textBoxPasswordRepeat.Text.Length >= 6 &&
                textBoxPassword.Text == textBoxPasswordRepeat.Text &&
                comboBoxRole.SelectedIndex != -1)
            {
                buttonReg.Enabled = true;

            }
        }
    }
}
