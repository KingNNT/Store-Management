using StoreManagement.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace StoreManagement.Views
{
    public partial class FormBanHang : Form
    {
        public FormBanHang()
        {
            InitializeComponent();
            this.setDefault();
        }

        private DataSet dsSanPham = new DataSet();
        private DataSet dsKhachHang = new DataSet();
        private Database db = new Database();

        private void btnFindSanPham_Click(object sender, EventArgs e)
        {
            btnTinhTien.Enabled = true;
            //TODO:
            string tableName = @"[StoreManagement-LTKK].[dbo].[QUANLYSANPHAM]";
            this.findSanPham(tableName);
        }

        private void btnFindPhoneNumberKhachHang_Click(object sender, EventArgs e)
        {
            string tableName = @"[StoreManagement-LTKK].[dbo].[QUANLYKHACHHANG]";
            this.findKhachHang(tableName);
        }

        private void findKhachHang(string tableName)
        {
            string field = "SDTKH";
            string value = txtFindPhoneNumBerKhachHang.Text;
            db.findData(dsKhachHang, tableName, field, value);
            grvKhachHang.DataSource = null;
            grvKhachHang.DataSource = dsKhachHang.Tables[tableName].DefaultView;
        }

        private void findSanPham(string tableName)
        {
            string field = "MaSP";
            string value = txtFindTenSanPham.Text;
            db.findDataSanPham(dsSanPham, tableName, field, value);
            //grvSanPham.DataSource = null;
            grvSanPham.DataSource = dsSanPham.Tables[tableName].DefaultView;
        }

        private void btnClearProduct_Click(object sender, EventArgs e)
        {
            dsSanPham.Reset();
            grvSanPham.DataSource = null;
        }

        private void setDefault()
        {
            btnTinhTien.Enabled = false;
            btnThanhToan.Enabled = false;
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            this.tinhTong();
            this.showMaHD();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            this.thanhToan();
            this.createBill();
        }

        private void tinhTong()
        {
            try
            {
                string tableName = @"[StoreManagement-LTKK].[dbo].[QUANLYSANPHAM]";

                for (int i = 0; i < grvSanPham.Rows.Count; i++)
                {
                    int SoLuong = 0;
                    if (grvSanPham.Rows[i].Cells[0].Value == null)
                    {
                        MessageBox.Show("Kiểm tra lại Số Lượng nhập", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        SoLuong = Convert.ToInt32(grvSanPham.Rows[i].Cells[0].Value.ToString());
                    }
                    int GiaBan = Convert.ToInt32(grvSanPham.Rows[i].Cells[5].Value.ToString());
                    grvSanPham.Rows[i].Cells[1].Value = SoLuong * GiaBan;
                }

                //int sum = Convert.ToInt32(dsSanPham.Tables[tableName].Compute("SUM(GiaBanLe)", string.Empty));
                int sum = 0;
                for (int i = 0; i < grvSanPham.Rows.Count; i++)
                {
                    int temp = Convert.ToInt32(grvSanPham.Rows[i].Cells[1].Value.ToString());
                    sum += temp;
                }

                txtTongTien.Text = sum.ToString();
                double chietKhau = 0.1;
                txtChietKhau.Text = (sum * chietKhau).ToString();
                txtKhachPhaiTra.Text = (sum - (sum * chietKhau)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void thanhToan()
        {
            txtTienTraLai.Text = (Convert.ToDouble(txtKhachDua.Text) - Convert.ToDouble(txtKhachPhaiTra.Text)).ToString();
        }

        private void txtKhachDua_TextChanged(object sender, EventArgs e)
        {
            if (txtKhachDua.Text == "")
            {
                btnThanhToan.Enabled = false;
            }
            else
            {
                btnThanhToan.Enabled = true;
            }
        }

        private void FormBanHang_Load(object sender, EventArgs e)
        {
            this.addColWhenBuyProducts();
        }

        private void showMaHD()
        {
            txtSoHoaDon.Text = this.createMaHD(db.getLastRecord());
        }

        private string createMaHD(string maHD)
        {
            string result = "";
            string part1 = maHD[0].ToString() + maHD[1].ToString() + maHD[2].ToString();
            string part2 = maHD[3].ToString() + maHD[4].ToString() + maHD[5].ToString();
            int value = Convert.ToInt32(part2) + 1;
            return part1 + value.ToString("D3");
        }

        private void createBill()
        {
            string TenSP = grvSanPham.Rows[0].Cells[2].Value.ToString();
            string MaSP = grvSanPham.Rows[0].Cells[3].Value.ToString();
            string TenKH = "";
            string SDTKH = "";
            if (grvKhachHang.DataSource == null)
            {
                //MessageBox.Show("Không có thông tin khách hàng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return;
                TenKH = SDTKH = "No Infomation";
            }
            else
            {
                TenKH = grvKhachHang.Rows[0].Cells[1].Value.ToString();
                SDTKH = grvKhachHang.Rows[0].Cells[3].Value.ToString();
            }

            string TrangThaiDH = "Not Categorized";
            db.insertDataToTableQuanLyBanHang(txtSoHoaDon.Text, MaSP, TenSP, SDTKH);
            db.insertDataToTableQuanLyDonHang(txtSoHoaDon.Text, DateTime.Now, TenKH, TrangThaiDH, Convert.ToInt32(txtKhachPhaiTra.Text));

            for (int i = 0; i < grvSanPham.Rows.Count; i++)
            {
                string TenSPTrongGio = grvSanPham.Rows[i].Cells[2].Value.ToString();
                int SoLuongTonTruoc = db.getSoLuongTonQuanLySanPham(TenSPTrongGio);
                int SoLuongMua = 0;
                if (grvSanPham.Rows[i].Cells[0].Value != null)
                {
                    SoLuongMua = Convert.ToInt32(grvSanPham.Rows[i].Cells[0].Value.ToString());
                }
                else
                {
                    MessageBox.Show("Kiểm tra lại Số Lượng nhập", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int SoLuongTonSau = SoLuongTonTruoc - SoLuongMua;
                db.updateDataQuanLySanPham(SoLuongTonSau, TenSPTrongGio);
            }

            MessageBox.Show("Create Bill Successfully", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void addColWhenBuyProducts()
        {
            grvSanPham.Columns.Add("SoLuong", "SoLuong");
            grvSanPham.Columns.Add("ThanhTien", "ThanhTien");
        }

        private void txtChietKhau_TextChanged(object sender, EventArgs e)
        {
            if (txtChietKhau.Text == "")
            {
                txtChietKhau.Text = "0";
            }
            int chietKhau = Convert.ToInt32(txtChietKhau.Text);
            int khachPhaiTra = Convert.ToInt32(txtTongTien.Text) - chietKhau;
            txtKhachPhaiTra.Text = khachPhaiTra.ToString();
        }
    }
}