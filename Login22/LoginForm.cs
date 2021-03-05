using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login22
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxLogin.Text))
            {
                errorProviderLogin.SetError(textBoxLogin, "Login empty!!!");
                return;
            }
            if (String.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                errorProviderPassword.SetError(textBoxPassword, "Password empty!!!");
                return;
            }
            if (Auth.CheckLogin(textBoxLogin.Text, textBoxPassword.Text))
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }


        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxLogin.Text))
            {
                errorProviderLogin.SetError(textBoxLogin, "Login empty!!!");
                return;
            }
            else
            {
                errorProviderLogin.Clear();
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                errorProviderPassword.SetError(textBoxPassword, "Password empty!!!");
                return;
            }
            else
            {
                errorProviderPassword.Clear();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            textBoxLogin.Focus();
        }
    }
}
