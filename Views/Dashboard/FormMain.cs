using System;
using System.Drawing;
using System.Windows.Forms;

namespace StoreManagement.Views
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        #region function loadForms
        private void loadFormBanHang()
        {
            FormBanHang frmBanHang = new FormBanHang() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            this.pContainer.Controls.Clear();
            this.pContainer.Controls.Add(frmBanHang);
            frmBanHang.Show();
            this.resetBackgroundColorOfMenu();
            menuItemBanHang.BackColor = Color.Gray;
        }

        private void loadFormNhapHang()
        {
            FormNhapHang frmNhapHang = new FormNhapHang() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            this.pContainer.Controls.Clear();
            this.pContainer.Controls.Add(frmNhapHang);
            frmNhapHang.Show();
            this.resetBackgroundColorOfMenu();
            menuItemNhapHang.BackColor = Color.Gray;
        }

        private void loadFormQuanLyKhoHang()
        {
            FormQuanLyKhoHang frmQuanLyKhoHang = new FormQuanLyKhoHang() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            this.pContainer.Controls.Clear();
            this.pContainer.Controls.Add(frmQuanLyKhoHang);
            frmQuanLyKhoHang.Show();
            this.resetBackgroundColorOfMenu();
            menuItemQuanLyKhoHang.BackColor = Color.Gray;
        }

        private void loadFormTimKiemDonhang()
        {
            FormTimKiemDonhang frmTimKiemDonHang = new FormTimKiemDonhang() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            this.pContainer.Controls.Clear();
            this.pContainer.Controls.Add(frmTimKiemDonHang);
            frmTimKiemDonHang.Show();
            this.resetBackgroundColorOfMenu();
            menuItemTimKiemDonHang.BackColor = Color.Gray;
        }

        private void loadFormQuanLyKhachHang()
        {
            FormQuanLyKhachHang frmQuanLyKhachHang = new FormQuanLyKhachHang() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            this.pContainer.Controls.Clear();
            this.pContainer.Controls.Add(frmQuanLyKhachHang);
            frmQuanLyKhachHang.Show();
            this.resetBackgroundColorOfMenu();
            menuItemQuanLyKhachHang.BackColor = Color.Gray;
        }
        #endregion function loadForms

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.loadFormBanHang();
        }

        private void menuItemBanHang_Click(object sender, EventArgs e)
        {
            this.loadFormBanHang();
        }

        private void menuItemNhapHang_Click(object sender, EventArgs e)
        {
            this.loadFormNhapHang();
        }

        private void menuItemQuanLyKhoHang_Click(object sender, EventArgs e)
        {
            this.loadFormQuanLyKhoHang();
        }

        private void menuItemTimKiemDonHang_Click(object sender, EventArgs e)
        {
            this.loadFormTimKiemDonhang();
        }

        private void menuItemQuanLyKhachHang_Click(object sender, EventArgs e)
        {
            this.loadFormQuanLyKhachHang();
        }

        private void resetBackgroundColorOfMenu()
        {
            foreach (ToolStripMenuItem item in menuStrip.Items)
            {
                item.BackColor = Color.White;
            }
        }
    }
}