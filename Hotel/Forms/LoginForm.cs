using System;
using System.Windows.Forms;
using Hotel.Data_Access_Layer;
using Hotel.Models;

namespace Hotel.Forms
{
    public partial class LoginForm : Form
    {
        public static User CurrentUser { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var u = DbRepository.GetUser(tbLogin.Text.Trim(), tbPwd.Text);
            if (u == null)
            {
                MessageBox.Show("Неверный логин/пароль");
                return;
            }
            CurrentUser = u;
            DialogResult = DialogResult.OK;
        }
    }
}