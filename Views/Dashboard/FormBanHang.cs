using StoreManagement.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace StoreManagement.Views
{
    public partial class FormBanHang : Form
    {
        public FormBanHang()
        {
            InitializeComponent();
        }

        StoreManagementEntities ef = new StoreManagementEntities();

        #region Event Form
        private void FormBanHang_Load(object sender, EventArgs e)
        {
            this.setDefault();
            this.showDataFromKho();

            this.bindingDataToCbx();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            this.tinhTong();
            this.showMaHD();
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            this.createBill();
        }
        #endregion Event Form

        #region
        private void setDefault()
        {
            btnThanhToan.Enabled = false;
            btnPrint.Enabled = false;

            this.loadSetting();
        }

        private void loadSetting()
        {
            int pnDepotFindWithItem = Properties.FormBanHang.Default.pnDepotFindWithItem;
            if (pnDepotFindWithItem == 1)
            {
                cbxIDProduct.Enabled = true;
                cbxNameProduct.Enabled = false;
            }
            else if (pnDepotFindWithItem == 2)
            {
                cbxIDProduct.Enabled = false;
                cbxNameProduct.Enabled = true;
            }
        }

        private void showDataFromKho()
        {
            grvSanPham.DataSource = ef.QuanLyKho.ToList();
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

                //txtTongTien.Text = sum.ToString();
                //double chietKhau = 0.1;
                //txtChietKhau.Text = (sum * chietKhau).ToString();
                //txtKhachPhaiTra.Text = (sum - (sum * chietKhau)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showMaHD()
        {
            //txtSoHoaDon.Text = this.createMaHD(db.getLastRecord());
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
            //if (grvKhachHang.DataSource == null)
            //{
            //    //MessageBox.Show("Không có thông tin khách hàng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    //return;
            //    TenKH = SDTKH = "No Infomation";
            //}
            //else
            //{
            //    TenKH = grvKhachHang.Rows[0].Cells[1].Value.ToString();
            //    SDTKH = grvKhachHang.Rows[0].Cells[3].Value.ToString();
            //}

            string TrangThaiDH = "Not Categorized";
            //db.insertDataToTableQuanLyBanHang(txtSoHoaDon.Text, MaSP, TenSP, SDTKH);
            //db.insertDataToTableQuanLyDonHang(txtSoHoaDon.Text, DateTime.Now, TenKH, TrangThaiDH, Convert.ToInt32(txtKhachPhaiTra.Text));

            for (int i = 0; i < grvSanPham.Rows.Count; i++)
            {
                string TenSPTrongGio = grvSanPham.Rows[i].Cells[2].Value.ToString();
                //int SoLuongTonTruoc = db.getSoLuongTonQuanLySanPham(TenSPTrongGio);
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

                //int SoLuongTonSau = SoLuongTonTruoc - SoLuongMua;
                //db.updateDataQuanLySanPham(SoLuongTonSau, TenSPTrongGio);
            }

            MessageBox.Show("Create Bill Successfully", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Events Cbx

        private bool checkTextOfCbxEmpty()
        {
            return (cbxIDProduct.Text == string.Empty && cbxNameProduct.Text == string.Empty && cbxCategoriesProduct.Text == string.Empty);
        }
        private void bindingDataToCbx()
        {
            cbxIDProduct.DataSource = ef.QuanLyKho.ToList();
            cbxNameProduct.DataSource = ef.QuanLyKho.ToList();
            cbxCategoriesProduct.DataSource = ef.QuanLyKho.ToList();
        }
        #region Events CbxIDProduct
        private void cbxIDProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            grvSanPham.DataSource = ef.QuanLyKho.Where(x => x.MaSanPham == cbxIDProduct.SelectedValue.ToString()).ToList();
        }
        private void cbxIDProduct_TextChanged(object sender, EventArgs e)
        {
            if (checkTextOfCbxEmpty())
            {
                this.showDataFromKho();
            }
        }
        #endregion Events CbxIDProduct
        #region Events CbxNameProduct
        private void cbxNameProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            grvSanPham.DataSource = ef.QuanLyKho.Where(x => x.TenSanPham == cbxNameProduct.SelectedValue.ToString()).ToList();
        }

        private void cbxNameProduct_TextChanged(object sender, EventArgs e)
        {
            if (checkTextOfCbxEmpty())
            {
                this.showDataFromKho();
            }
        }
        #endregion Events CbxNameProduct
        #region Event CbxCategoriesProduct
        private void cbxCategoriesProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            grvSanPham.DataSource = ef.QuanLyKho.Where(x => x.DanhMucSanPham == cbxCategoriesProduct.SelectedValue.ToString()).ToList();
        }
        private void cbxCategoriesProduct_TextChanged(object sender, EventArgs e)
        {
            if (checkTextOfCbxEmpty())
            {
                this.showDataFromKho();
            }
        }
        #endregion Event CbxCategoriesProduct

        #endregion Events Cbx

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            this.showDataFromKho();
        }

        private void grvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grvSanPham_DoubleClick(object sender, EventArgs e)
        {
            this.fillInfoProductFromKho();
        }
        private void fillInfoProductFromKho()
        {
            if (grvSanPham.CurrentRow.Index != -1)
            {
                string IDProduct = grvSanPham.CurrentRow.Cells["MaSanPham"].Value.ToString();
                string nameProduct = grvSanPham.CurrentRow.Cells["TenSanPham"].Value.ToString();
                string giaBanSoldProduct = grvSanPham.CurrentRow.Cells["GiaBan"].Value.ToString();
                grvSoldProduct.Rows.Add(IDProduct, nameProduct, giaBanSoldProduct, string.Empty, string.Empty);
            }
        }

        private void numSoLuongBan_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tinhTien()
        {

        }

        private void grvSoldProduct_SelectionChanged(object sender, EventArgs e)
        {
            this.updateColumnThanhTienAtGridViewSoldProduct();
        }

        private void updateColumnThanhTienAtGridViewSoldProduct()
        {
            string soLuongBan = grvSoldProduct.CurrentRow.Cells["colNumSell"].Value.ToString();

            if (soLuongBan != string.Empty)
            {
                int intSoLuongBan = Convert.ToInt32(soLuongBan);
                int giaBan = Convert.ToInt32(grvSoldProduct.CurrentRow.Cells["colGiaBanSoldProduct"].Value.ToString());
                int thanhTien = intSoLuongBan * giaBan;
                grvSoldProduct.CurrentRow.Cells["colThanhTienSoldProduct"].Value = thanhTien;
            }
        }
    }


}