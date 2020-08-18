using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoreManagement.views;

namespace StoreManagement.views
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

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
            menuItemBanHang.BackColor = Color.White;
            menuItemNhapHang.BackColor = Color.White;
            menuItemQuanLyKhoHang.BackColor = Color.White;
            menuItemTimKiemDonHang.BackColor = Color.White;
            menuItemQuanLyKhachHang.BackColor = Color.White;
        }
    }
}
