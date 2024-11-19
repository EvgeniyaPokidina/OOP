using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_17
{
    public partial class FormAuthorization : Form
    {
        private UserAuthentification userAutorization;
        public static FormAuthorization? instance;
        public FormAuthorization()
        {
            InitializeComponent();
            instance = this;
            userAutorization = new UserAuthentification();
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            if (userAutorization.Users != null)
            {
                foreach (User s in userAutorization.Users)
                {
                    source.Add(s.UserName!);
                }
                textBoxLogin.AutoCompleteCustomSource = source;
                textBoxLogin.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                textBoxLogin.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
        }

        private void linkLabelRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegistration formRegistration = new FormRegistration();
            formRegistration.Show();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (userAutorization.AuthentificationUser(textBoxLogin.Text, textBoxPassword.Text))
            {
                FormArticles formArticles = new FormArticles();
                formArticles.Show();
                this.Hide();
            }
        }
    }
}
