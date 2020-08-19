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
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            this.checkOut();
        }
        #endregion Event Form

        #region
        private void setDefault()
        {
            btnCreateBill.Enabled = false;
            btnCheckOut.Enabled = false;
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
            try
            {
                int sum = 0;
                foreach (DataGridViewRow row in grvSoldProduct.Rows)
                {
                    sum += Convert.ToInt32(row.Cells["colThanhTienSoldProduct"].Value.ToString());
                }
                txtTongTien.Text = sum.ToString();
                txtTienPhaiTra.Text = (Convert.ToInt32(txtTongTien.Text) - Convert.ToInt32(txtChietKhau.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkOut()
        {
            txtTraLai.Text = (Convert.ToInt32(txtKhachDua.Text) - Convert.ToInt32(txtTienPhaiTra.Text)).ToString();
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

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            this.createBill();
        }

        private void txtChietKhau_TextChanged(object sender, EventArgs e)
        {
            if (txtChietKhau.Text != string.Empty)
            {
                btnCreateBill.Enabled = true;
            }
            else
            {
                btnCreateBill.Enabled = false;
            }
        }
        private void txtKhachDua_TextChanged(object sender, EventArgs e)
        {
            if (txtKhachDua.Text != string.Empty)
            {
                btnCheckOut.Enabled = true;
            }
            else
            {
                btnCheckOut.Enabled = false;
            }
        }
    }


}