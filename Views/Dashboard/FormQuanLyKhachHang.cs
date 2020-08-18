using StoreManagement.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace StoreManagement.Views
{
    public partial class FormQuanLyKhachHang : Form
    {
        public FormQuanLyKhachHang()
        {
            InitializeComponent();
        }

        private string tableName = @"[StoreManagement-LTKK].[dbo].[QUANLYKHACHHANG]";
        private DataSet ds = new DataSet();
        private Database db = new Database();

        private void showData()
        {
            db.getData(ds, tableName);
            grv.DataSource = null;
            grv.DataSource = ds.Tables[tableName].DefaultView;
        }

        private void updateData()
        {
            db.updateData(ds, tableName);
            MessageBox.Show("Lưu Thành Công", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.showData();
        }

        private void FormQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            this.showData();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            this.showData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.updateData();
        }
    }
}