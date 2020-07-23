using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KH039.models;

namespace KH039.views
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
