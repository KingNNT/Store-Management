using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoreManagement.models;

namespace StoreManagement.views
{
    public partial class FormQuanLyKhachHang : Form
    {
        public FormQuanLyKhachHang()
        {
            InitializeComponent();
        }
        private string tableName = @"[StoreManagement-LTKK].[dbo].[QUANLYKHACHHANG]";
        DataSet ds = new DataSet();
        Database db = new Database();

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
