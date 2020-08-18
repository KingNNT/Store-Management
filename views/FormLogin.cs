using StoreManagement.models;
using System;
using System.Windows.Forms;

namespace StoreManagement.views
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            if (db.login(txtUserName.Text, txtPassWord.Text) == true)
            {
                FormMain frmMain = new FormMain();
                this.Hide();
                frmMain.Show();
                MessageBox.Show("Login Successful", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Login Failed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}