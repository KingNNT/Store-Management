using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KH039.models;

namespace KH039.views
{
    public partial class FormTimKiemDonhang : Form
    {
        public FormTimKiemDonhang()
        {
            InitializeComponent();
        }
        private string tableName = @"[KH039-LTKK].[dbo].[QUANLYDONHANG]";
        DataSet ds = new DataSet();
        Database db = new Database();
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
