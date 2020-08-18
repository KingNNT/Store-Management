using StoreManagement.models;
using System;
using System.Data;
using System.Windows.Forms;

namespace StoreManagement.views
{
    public partial class FormNhapHang : Form
    {
        public FormNhapHang()
        {
            InitializeComponent();
        }

        private string tableName = @"[StoreManagement-LTKK].[dbo].[QUANLYSANPHAM]";
        private DataSet ds = new DataSet();
        private Database db = new Database();

        private void showData()
        {
            string field = "Visible";
            db.getData(ds, tableName, field);
            grv.DataSource = null;
            grv.DataSource = ds.Tables[tableName].DefaultView;
        }

        private void updateData()
        {
            db.updateData(ds, tableName);
            MessageBox.Show("Lưu Thành Công", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.showData();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            this.showData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.checkValueBeforeDelete() == false)
            {
                return;
            }
            this.updateData();
            this.deleteDataTableQUANLYSANPHAM();
        }

        private void FormNhapHang_Load(object sender, EventArgs e)
        {
            this.showData();
        }

        private bool checkValueBeforeDelete()
        {
            int indexCol = 3;
            for (int i = 0; i < grv.Rows.Count - 1; i++)
            {
                string strValue = grv.Rows[i].Cells[indexCol].Value.ToString();
                try
                {
                    int value = Convert.ToInt32(strValue);
                    if (value < 0)
                    {
                        MessageBox.Show("Value can't be negative", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    else if (value != 0)
                    {
                        string tenSP = grv.Rows[i].Cells[0].Value.ToString();
                        if (grv.Rows[i].Cells[6].Value.ToString() == "False")
                        {
                            MessageBox.Show("Can't delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                        //if (tenSP == "")
                        //{
                        //    MessageBox.Show("Can't delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //    return false;
                        //}
                    }
                    else
                    {
                        //string tenSP = grv.Rows[i].Cells[0].Value.ToString();
                        //if (tenSP == "")
                        //{
                        //    for (int j = 0; j < grv.Columns.Count; j++)
                        //    {
                        //        grv.Rows[i].Cells[0].Value = null;
                        //    }
                        //    return true;
                        //}
                    }
                }
                catch (Exception ex)
                {
                }
            }
            return true;
        }

        private void deleteDataTableQUANLYSANPHAM()
        {
            db.deleteDataTableQUANLYSANPHAM();
        }
    }
}