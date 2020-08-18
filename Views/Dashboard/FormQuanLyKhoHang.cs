using StoreManagement.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace StoreManagement.Views
{
    public partial class FormQuanLyKhoHang : Form
    {
        public FormQuanLyKhoHang()
        {
            InitializeComponent();
        }

        private string tableName = @"[StoreManagement-LTKK].[dbo].[QUANLYKHOHANG]";
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

        private void findData()
        {
            string field = "MaSP";
            string value = txtFind.Text;
            db.findData(ds, tableName, field, value);
            grv.DataSource = null;
            grv.DataSource = ds.Tables[tableName].DefaultView;
        }

        private void FormQuanLyKhoHang_Load(object sender, EventArgs e)
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
            this.UpdateHangTonQuanLySanPham();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            this.findData();
        }

        private void UpdateHangTonQuanLySanPham()
        {
            for (int i = 0; i < grv.Rows.Count; i++)
            {
                if (grv.Rows[i].Cells[3].Value != null)
                {
                    string maSP = grv.Rows[i].Cells[0].Value.ToString();
                    int nhapKHo = Convert.ToInt32(grv.Rows[i].Cells[3].Value.ToString());
                    if (nhapKHo != 0)
                    {
                        int hangTon = db.getSoLuongTonQuanLySanPhamWithMaSP(maSP);
                        int hangSauNhap = hangTon + nhapKHo;
                        if (db.checkMaSPQUANLYSANPHAM(maSP) == true)
                        {
                            db.updateDataQuanLySanPhamWithMaSanPham(hangSauNhap, maSP);
                        }
                        else
                        {
                            Random rand = new Random();
                            double doubleRand = rand.NextDouble();
                            string strRand = doubleRand.ToString("f3");
                            string TenSP = "Name Product-" + strRand;
                            string DanhMucSP = "Not Categories";
                            int GiaNhap = Convert.ToInt32(grv.Rows[i].Cells[4].Value.ToString());
                            int GiaBan = 0;
                            int Visiable = 1;
                            db.insertDataTableQUANLYSANPHAM(TenSP, maSP, DanhMucSP, hangSauNhap, GiaNhap, GiaBan, Visiable);
                        }
                    }
                }
            }
        }
    }
}