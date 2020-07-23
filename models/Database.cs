using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace KH039.models
{
    class Database
    {
        private string str_conn = @"Data Source=localhost;Initial Catalog=KH039-LTKK;Integrated Security=True";


        public bool login(string txtUsr, string txtPwd)
        {
            try
            {
                SqlConnection conn = new SqlConnection(str_conn);
                conn.Open();
                string query = @"SELECT* FROM [KH039-LTKK].[dbo].[NGUOIDUNG] WHERE TaiKhoan = @usr AND MatKhau = @pwd";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(new SqlParameter("usr", txtUsr));
                command.Parameters.Add(new SqlParameter("pwd", txtPwd));

                SqlDataReader data = command.ExecuteReader();
                //conn.Close();
                if (data.Read() == true)
                {
                    conn.Close();
                    return true;
                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public void getData(DataSet ds, string tableName)
        {
            try
            {
                SqlConnection conn = new SqlConnection(str_conn);
                string query = @"SELECT* FROM " + tableName;
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                ds.Reset();
                da.Fill(ds, tableName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void getData(DataSet ds, string tableName, string field)
        {
            try
            {
                SqlConnection conn = new SqlConnection(str_conn);
                string query = @"SELECT* FROM " + tableName + "WHERE " + field + " = 1";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                ds.Reset();
                da.Fill(ds, tableName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void updateData(DataSet ds, string tableName)
        {
            try
            {
                SqlConnection conn = new SqlConnection(str_conn);
                string query = @"SELECT * FROM " + tableName;
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                SqlCommandBuilder cmdbd = new SqlCommandBuilder(da);
                da.Update(ds, tableName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void findData(DataSet ds, string tableName, string field, string value)
        {
            try
            {
                SqlConnection conn = new SqlConnection(str_conn);
                string query = @"SELECT* FROM " + tableName + "WHERE " + field + " = '" + value + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                ds.Reset();
                da.Fill(ds, tableName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void findDataSanPham(DataSet ds, string tableName, string field, string value)
        {
            try
            {
                SqlConnection conn = new SqlConnection(str_conn);
                string query = @"SELECT [TenSP], [MaSP], [DanhMucSP], [GiaBanLe] FROM " + tableName + "WHERE " + field + " = '" + value + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                //ds.Reset();
                da.Fill(ds, tableName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void insertDataToTableQuanLyBanHang(string MaDH, string MaSP, string TenSP, string SDTKH)
        {
            try
            {
                SqlConnection conn = new SqlConnection(str_conn);
                conn.Open();
                string query = @"INSERT INTO [KH039-LTKK].[dbo].[QUANLYBANHANG] (MaDH, MaSP, TenSP, SDTKH) VALUES ('" + MaDH + "', '" + MaSP + "', '" + TenSP + "', '" + SDTKH + "')";
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {

            }

        }

        public void insertDataToTableQuanLyDonHang(string MaDH, DateTime NgayTaoDon, string TenKH, string TrangThaiDH, int KhachHangPhaiTra)
        {
            try
            {
                SqlConnection conn = new SqlConnection(str_conn);
                conn.Open();
                string query = @"INSERT INTO [KH039-LTKK].[dbo].[QUANLYDONHANG] (MaDH, NgayTaoDon, TenKH, TrangThaiDonHang, KhachPhaiTra) VALUES ('" + MaDH + "', '" + NgayTaoDon.Date.ToString("yyyy-MM-dd") + "', '" + TenKH + "', '" + TrangThaiDH + "', " + KhachHangPhaiTra + ")";
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {

            }

        }

        public void updateDataQuanLySanPham(int value, string TenSP)
        {
            SqlConnection conn = new SqlConnection(str_conn);
            conn.Open();
            string query = @"UPDATE dbo.QUANLYSANPHAM SET Kho = '" + value + "' WHERE TenSP = '" + TenSP + "'";
            SqlCommand command = new SqlCommand(query, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void updateDataQuanLySanPhamWithMaSanPham(int value, string MaSP)
        {
            SqlConnection conn = new SqlConnection(str_conn);
            conn.Open();
            string query = @"UPDATE dbo.QUANLYSANPHAM SET Kho = '" + value + "' WHERE MaSP = '" + MaSP + "'";
            SqlCommand command = new SqlCommand(query, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public int getSoLuongTonQuanLySanPham(string TenSP)
        {
            int strData = 0;
            try
            {
                SqlConnection conn = new SqlConnection(str_conn);
                conn.Open();
                string query = @"SELECT [Kho] FROM [KH039-LTKK].[dbo].[QUANLYSANPHAM] WHERE TenSP = '" + TenSP + "'";
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader data = command.ExecuteReader();
                //conn.Close();
                if (data.Read() == true)
                {
                    strData = Convert.ToInt32(data.GetInt64(0));
                }
                conn.Close();
            }
            catch (Exception ex)
            {

            }

            return strData;
        }


        public int getSoLuongTonQuanLySanPhamWithMaSP(string MaSP)
        {
            int strData = 0;
            try
            {
                SqlConnection conn = new SqlConnection(str_conn);
                conn.Open();
                string query = @"SELECT [Kho] FROM [KH039-LTKK].[dbo].[QUANLYSANPHAM] WHERE MaSP = '" + MaSP + "'";
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader data = command.ExecuteReader();
                //conn.Close();
                if (data.Read() == true)
                {
                    strData = Convert.ToInt32(data.GetInt64(0));
                }
                conn.Close();
            }
            catch (Exception ex)
            {

            }

            return strData;
        }

        public string getLastRecord()
        {
            string strData = "";
            try
            {
                SqlConnection conn = new SqlConnection(str_conn);
                conn.Open();
                string query = @"SELECT TOP 1 MaDH FROM [KH039-LTKK].[dbo].[QUANLYBANHANG] ORDER BY MaDH DESC";
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader data = command.ExecuteReader();
                if (data.Read() == true)
                {
                    strData = data.GetString(0);
                }
                conn.Close();
            }
            catch (Exception ex)
            {

            }

            return strData;
        }

        public void insertDataTableQUANLYSANPHAM (string TenSP, string MaSP, string DanhMucSP, int Kho, int GiaNhap, int GiaBan, int Visiable)
        {
            SqlConnection conn = new SqlConnection(str_conn);
            conn.Open();
            string query = @"INSERT INTO [KH039-LTKK].[dbo].[QUANLYSANPHAM] (TenSP, MaSP, DanhMucSP, Kho, GiaNhap, GiaBanLe, Visible) VALUES ('" + TenSP + "', '" + MaSP + "', '" + DanhMucSP + "', " + Kho + ", " + GiaNhap + ", " + GiaBan + ", " + Visiable + ")";
            SqlCommand command = new SqlCommand(query, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public bool checkMaSPQUANLYSANPHAM (string MaSP)
        {
            SqlConnection conn = new SqlConnection(str_conn);
            conn.Open();
            string query = @"SELECT * FROM [KH039-LTKK].[dbo].[QUANLYSANPHAM] WHERE MaSP = '" + MaSP + "'";
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader data = command.ExecuteReader();
            //conn.Close();
            if (data.Read() == true)
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
        }

        public void deleteDataTableQUANLYSANPHAM ()
        {
            SqlConnection conn = new SqlConnection(str_conn);
            conn.Open();
            string query = @"DELETE FROM [KH039-LTKK].[dbo].[QUANLYSANPHAM] WHERE Visible = 0";
            SqlCommand command = new SqlCommand(query, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}
