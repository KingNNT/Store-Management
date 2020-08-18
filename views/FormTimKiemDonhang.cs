using StoreManagement.models;
using System;
using System.Data;
using System.Windows.Forms;

namespace StoreManagement.views
{
    public partial class FormTimKiemDonhang : Form
    {
        public FormTimKiemDonhang()
        {
            InitializeComponent();
        }

        private string tableName = @"[StoreManagement-LTKK].[dbo].[QUANLYDONHANG]";
        private DataSet ds = new DataSet();
        private Database db = new Database();

        private void btnFind_Click(object sender, EventArgs e)
        {
            this.findData();
        }

        private void FormTimKiemDonhang_Load(object sender, EventArgs e)
        {
            this.showData();
        }

        private void showData()
        {
            db.getData(ds, tableName);
            grv.DataSource = null;
            grv.DataSource = ds.Tables[tableName].DefaultView;
        }

        private void findData()
        {
            string field = "MaDH";
            string value = txtFind.Text;
            db.findData(ds, tableName, field, value);
            grv.DataSource = null;
            grv.DataSource = ds.Tables[tableName].DefaultView;
        }
    }
}