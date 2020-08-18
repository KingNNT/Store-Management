using StoreManagement.Models;
using System;
using System.Windows.Forms;

namespace StoreManagement.Views
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string passWord = txtPassWord.Text;
            string passWordHash = Securities.CreateMD5(passWord);

            using (StoreManagementEntities ef = new StoreManagementEntities())
            {
                foreach (var acc in ef.Account)
                {
                    string usernameFromDB = acc.Username.Trim();
                    string passWordFromDB = acc.Password.Trim();

                    if (userName == usernameFromDB && passWordHash == passWordFromDB)
                    {
                        this.Hide();
                        FormMain frmMain = new FormMain();
                        frmMain.Show();

                        //MessageBox.Show("Login Successful.", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        notifyIconLogin.BalloonTipIcon = ToolTipIcon.Info;
                        notifyIconLogin.BalloonTipTitle = "Infomation";
                        notifyIconLogin.BalloonTipText = "Login Successful";

                        notifyIconLogin.ShowBalloonTip(3000);
                        return;
                    }
                }
                MessageBox.Show("Please, Check username and password again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want exit program ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void notifyIconLogin_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }
    }
}