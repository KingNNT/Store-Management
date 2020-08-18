using System;
using System.Windows.Forms;

namespace StoreManagement.Views
{
    public partial class FormControl : Form
    {
        public FormControl()
        {
            InitializeComponent();
        }

        private void FormControl_Load(object sender, EventArgs e)
        {
            this.loadFormLogin();
        }

        private void loadFormLogin()
        {
            FormLogin frmLogin = new FormLogin() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            this.pnControl.Controls.Clear();
            this.pnControl.Controls.Add(frmLogin);
            frmLogin.Show();
        }

        private void loadFormMain()
        {
            FormMain frmMain = new FormMain() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            this.pnControl.Controls.Clear();
            this.pnControl.Controls.Add(frmMain);
            frmMain.Show();
        }
    }
}