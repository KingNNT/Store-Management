using StoreManagement.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace StoreManagement.Views
{
    public partial class FormTimKiemDonhang : Form
    {
        public FormTimKiemDonhang()
        {
            InitializeComponent();
        }

        private string tableName = @"[StoreManagement-LTKK].[dbo].[QUANLYDONHANG]";
        private DataSet ds = new DataSet();
    }
}