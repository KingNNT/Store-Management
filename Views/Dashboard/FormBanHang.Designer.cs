namespace StoreManagement.Views
{
    partial class FormBanHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBanHang));
            this.pnDepot = new System.Windows.Forms.Panel();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.cbxCategoriesProduct = new System.Windows.Forms.ComboBox();
            this.quanLyKhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.cbxNameProduct = new System.Windows.Forms.ComboBox();
            this.cbxIDProduct = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.grvSanPham = new System.Windows.Forms.DataGridView();
            this.MaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DanhMucSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongTonKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnSell = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCreateBill = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtIDBill = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.txtTraLai = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtKhachDua = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtChietKhau = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTienPhaiTra = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnSoldProduct = new System.Windows.Forms.Panel();
            this.grvSoldProduct = new System.Windows.Forms.DataGridView();
            this.colIDSoldProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNameSoldProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaBanSoldProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumSell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTienSoldProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAddressCustom = new System.Windows.Forms.TextBox();
            this.txtPhoneNumberCustom = new System.Windows.Forms.TextBox();
            this.txtNameCustom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnDepot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhoBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvSanPham)).BeginInit();
            this.pnSell.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnSoldProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvSoldProduct)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDepot
            // 
            this.pnDepot.Controls.Add(this.btnShowAll);
            this.pnDepot.Controls.Add(this.cbxCategoriesProduct);
            this.pnDepot.Controls.Add(this.label15);
            this.pnDepot.Controls.Add(this.cbxNameProduct);
            this.pnDepot.Controls.Add(this.cbxIDProduct);
            this.pnDepot.Controls.Add(this.label2);
            this.pnDepot.Controls.Add(this.label1);
            this.pnDepot.Controls.Add(this.panel4);
            this.pnDepot.Location = new System.Drawing.Point(13, 13);
            this.pnDepot.Name = "pnDepot";
            this.pnDepot.Size = new System.Drawing.Size(761, 436);
            this.pnDepot.TabIndex = 0;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(663, 4);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(95, 23);
            this.btnShowAll.TabIndex = 8;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // cbxCategoriesProduct
            // 
            this.cbxCategoriesProduct.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.quanLyKhoBindingSource, "DanhMucSanPham", true));
            this.cbxCategoriesProduct.DataSource = this.quanLyKhoBindingSource;
            this.cbxCategoriesProduct.DisplayMember = "DanhMucSanPham";
            this.cbxCategoriesProduct.FormattingEnabled = true;
            this.cbxCategoriesProduct.Location = new System.Drawing.Point(535, 4);
            this.cbxCategoriesProduct.Name = "cbxCategoriesProduct";
            this.cbxCategoriesProduct.Size = new System.Drawing.Size(121, 21);
            this.cbxCategoriesProduct.TabIndex = 7;
            this.cbxCategoriesProduct.ValueMember = "DanhMucSanPham";
            this.cbxCategoriesProduct.SelectedIndexChanged += new System.EventHandler(this.cbxCategoriesProduct_SelectedIndexChanged);
            this.cbxCategoriesProduct.TextChanged += new System.EventHandler(this.cbxCategoriesProduct_TextChanged);
            // 
            // quanLyKhoBindingSource
            // 
            this.quanLyKhoBindingSource.DataSource = typeof(StoreManagement.Models.QuanLyKho);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(420, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Danh Mục Sản Phẩm";
            // 
            // cbxNameProduct
            // 
            this.cbxNameProduct.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.quanLyKhoBindingSource, "TenSanPham", true));
            this.cbxNameProduct.DataSource = this.quanLyKhoBindingSource;
            this.cbxNameProduct.DisplayMember = "TenSanPham";
            this.cbxNameProduct.FormattingEnabled = true;
            this.cbxNameProduct.Location = new System.Drawing.Point(293, 4);
            this.cbxNameProduct.Name = "cbxNameProduct";
            this.cbxNameProduct.Size = new System.Drawing.Size(121, 21);
            this.cbxNameProduct.TabIndex = 5;
            this.cbxNameProduct.ValueMember = "TenSanPham";
            this.cbxNameProduct.SelectedIndexChanged += new System.EventHandler(this.cbxNameProduct_SelectedIndexChanged);
            this.cbxNameProduct.TextChanged += new System.EventHandler(this.cbxNameProduct_TextChanged);
            // 
            // cbxIDProduct
            // 
            this.cbxIDProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxIDProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxIDProduct.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.quanLyKhoBindingSource, "MaSanPham", true));
            this.cbxIDProduct.DataSource = this.quanLyKhoBindingSource;
            this.cbxIDProduct.DisplayMember = "MaSanPham";
            this.cbxIDProduct.FormattingEnabled = true;
            this.cbxIDProduct.Location = new System.Drawing.Point(82, 3);
            this.cbxIDProduct.Name = "cbxIDProduct";
            this.cbxIDProduct.Size = new System.Drawing.Size(121, 21);
            this.cbxIDProduct.TabIndex = 4;
            this.cbxIDProduct.ValueMember = "MaSanPham";
            this.cbxIDProduct.SelectedIndexChanged += new System.EventHandler(this.cbxIDProduct_SelectedIndexChanged);
            this.cbxIDProduct.TextChanged += new System.EventHandler(this.cbxIDProduct_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Sản Phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Sản Phẩm";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.grvSanPham);
            this.panel4.Location = new System.Drawing.Point(4, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(754, 403);
            this.panel4.TabIndex = 0;
            // 
            // grvSanPham
            // 
            this.grvSanPham.AllowUserToAddRows = false;
            this.grvSanPham.AllowUserToDeleteRows = false;
            this.grvSanPham.AutoGenerateColumns = false;
            this.grvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSanPham,
            this.TenSanPham,
            this.DanhMucSanPham,
            this.SoLuongTonKho,
            this.GiaNhap,
            this.GiaBan});
            this.grvSanPham.DataSource = this.quanLyKhoBindingSource;
            this.grvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvSanPham.Location = new System.Drawing.Point(0, 0);
            this.grvSanPham.Name = "grvSanPham";
            this.grvSanPham.ReadOnly = true;
            this.grvSanPham.Size = new System.Drawing.Size(754, 403);
            this.grvSanPham.TabIndex = 0;
            this.grvSanPham.DoubleClick += new System.EventHandler(this.grvSanPham_DoubleClick);
            // 
            // MaSanPham
            // 
            this.MaSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaSanPham.DataPropertyName = "MaSanPham";
            this.MaSanPham.HeaderText = "Mã Sản Phẩm";
            this.MaSanPham.Name = "MaSanPham";
            this.MaSanPham.ReadOnly = true;
            // 
            // TenSanPham
            // 
            this.TenSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenSanPham.DataPropertyName = "TenSanPham";
            this.TenSanPham.HeaderText = "Tên Sản Phẩm";
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.ReadOnly = true;
            // 
            // DanhMucSanPham
            // 
            this.DanhMucSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DanhMucSanPham.DataPropertyName = "DanhMucSanPham";
            this.DanhMucSanPham.HeaderText = "Danh Mục";
            this.DanhMucSanPham.Name = "DanhMucSanPham";
            this.DanhMucSanPham.ReadOnly = true;
            // 
            // SoLuongTonKho
            // 
            this.SoLuongTonKho.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoLuongTonKho.DataPropertyName = "SoLuongTonKho";
            this.SoLuongTonKho.HeaderText = "Số Lượng Tồn Kho";
            this.SoLuongTonKho.Name = "SoLuongTonKho";
            this.SoLuongTonKho.ReadOnly = true;
            // 
            // GiaNhap
            // 
            this.GiaNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GiaNhap.DataPropertyName = "GiaNhap";
            this.GiaNhap.HeaderText = "Giá Nhập";
            this.GiaNhap.Name = "GiaNhap";
            this.GiaNhap.ReadOnly = true;
            // 
            // GiaBan
            // 
            this.GiaBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GiaBan.DataPropertyName = "GiaBan";
            this.GiaBan.HeaderText = "Giá Bán";
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.ReadOnly = true;
            // 
            // pnSell
            // 
            this.pnSell.Controls.Add(this.groupBox3);
            this.pnSell.Controls.Add(this.groupBox2);
            this.pnSell.Controls.Add(this.groupBox1);
            this.pnSell.Location = new System.Drawing.Point(780, 13);
            this.pnSell.Name = "pnSell";
            this.pnSell.Size = new System.Drawing.Size(592, 436);
            this.pnSell.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCreateBill);
            this.groupBox3.Controls.Add(this.btnPrint);
            this.groupBox3.Controls.Add(this.txtIDBill);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.btnCheckOut);
            this.groupBox3.Controls.Add(this.txtTraLai);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtKhachDua);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtChietKhau);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtTienPhaiTra);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtTongTien);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(4, 300);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(585, 133);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin Thanh Toán";
            // 
            // btnCreateBill
            // 
            this.btnCreateBill.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateBill.Image")));
            this.btnCreateBill.Location = new System.Drawing.Point(473, 23);
            this.btnCreateBill.Name = "btnCreateBill";
            this.btnCreateBill.Size = new System.Drawing.Size(50, 50);
            this.btnCreateBill.TabIndex = 17;
            this.btnCreateBill.UseVisualStyleBackColor = true;
            this.btnCreateBill.Click += new System.EventHandler(this.btnCreateBill_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(529, 23);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(50, 50);
            this.btnPrint.TabIndex = 16;
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // txtIDBill
            // 
            this.txtIDBill.Location = new System.Drawing.Point(86, 23);
            this.txtIDBill.Name = "txtIDBill";
            this.txtIDBill.ReadOnly = true;
            this.txtIDBill.Size = new System.Drawing.Size(294, 20);
            this.txtIDBill.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Mã Hoá Đơn";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckOut.Image")));
            this.btnCheckOut.Location = new System.Drawing.Point(529, 79);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(50, 50);
            this.btnCheckOut.TabIndex = 13;
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // txtTraLai
            // 
            this.txtTraLai.Location = new System.Drawing.Point(271, 103);
            this.txtTraLai.Name = "txtTraLai";
            this.txtTraLai.ReadOnly = true;
            this.txtTraLai.Size = new System.Drawing.Size(109, 20);
            this.txtTraLai.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(191, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Trả Lại";
            // 
            // txtKhachDua
            // 
            this.txtKhachDua.Location = new System.Drawing.Point(86, 103);
            this.txtKhachDua.Name = "txtKhachDua";
            this.txtKhachDua.Size = new System.Drawing.Size(99, 20);
            this.txtKhachDua.TabIndex = 10;
            this.txtKhachDua.TextChanged += new System.EventHandler(this.txtKhachDua_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 106);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Khách Đưa";
            // 
            // txtChietKhau
            // 
            this.txtChietKhau.Location = new System.Drawing.Point(271, 51);
            this.txtChietKhau.Name = "txtChietKhau";
            this.txtChietKhau.Size = new System.Drawing.Size(109, 20);
            this.txtChietKhau.TabIndex = 8;
            this.txtChietKhau.TextChanged += new System.EventHandler(this.txtChietKhau_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(191, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Chiết Khấu";
            // 
            // txtTienPhaiTra
            // 
            this.txtTienPhaiTra.Location = new System.Drawing.Point(86, 77);
            this.txtTienPhaiTra.Name = "txtTienPhaiTra";
            this.txtTienPhaiTra.ReadOnly = true;
            this.txtTienPhaiTra.Size = new System.Drawing.Size(294, 20);
            this.txtTienPhaiTra.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Tiền Phải Trả";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(86, 51);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(99, 20);
            this.txtTongTien.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Tổng Tiền";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pnSoldProduct);
            this.groupBox2.Location = new System.Drawing.Point(3, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(580, 181);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Sản Phẩm";
            // 
            // pnSoldProduct
            // 
            this.pnSoldProduct.Controls.Add(this.grvSoldProduct);
            this.pnSoldProduct.Location = new System.Drawing.Point(7, 23);
            this.pnSoldProduct.Name = "pnSoldProduct";
            this.pnSoldProduct.Size = new System.Drawing.Size(567, 152);
            this.pnSoldProduct.TabIndex = 0;
            // 
            // grvSoldProduct
            // 
            this.grvSoldProduct.AllowUserToAddRows = false;
            this.grvSoldProduct.AllowUserToDeleteRows = false;
            this.grvSoldProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvSoldProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDSoldProduct,
            this.colNameSoldProduct,
            this.colGiaBanSoldProduct,
            this.colNumSell,
            this.colThanhTienSoldProduct});
            this.grvSoldProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvSoldProduct.Location = new System.Drawing.Point(0, 0);
            this.grvSoldProduct.Name = "grvSoldProduct";
            this.grvSoldProduct.Size = new System.Drawing.Size(567, 152);
            this.grvSoldProduct.TabIndex = 0;
            this.grvSoldProduct.SelectionChanged += new System.EventHandler(this.grvSoldProduct_SelectionChanged);
            // 
            // colIDSoldProduct
            // 
            this.colIDSoldProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colIDSoldProduct.HeaderText = "Mã Sản Phẩm";
            this.colIDSoldProduct.Name = "colIDSoldProduct";
            this.colIDSoldProduct.ReadOnly = true;
            // 
            // colNameSoldProduct
            // 
            this.colNameSoldProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNameSoldProduct.HeaderText = "Tên Sản Phẩm";
            this.colNameSoldProduct.Name = "colNameSoldProduct";
            this.colNameSoldProduct.ReadOnly = true;
            // 
            // colGiaBanSoldProduct
            // 
            this.colGiaBanSoldProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGiaBanSoldProduct.HeaderText = "Giá Bán";
            this.colGiaBanSoldProduct.Name = "colGiaBanSoldProduct";
            this.colGiaBanSoldProduct.ReadOnly = true;
            // 
            // colNumSell
            // 
            this.colNumSell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNumSell.HeaderText = "Số Lượng bán";
            this.colNumSell.Name = "colNumSell";
            // 
            // colThanhTienSoldProduct
            // 
            this.colThanhTienSoldProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colThanhTienSoldProduct.HeaderText = "Thành Tiền";
            this.colThanhTienSoldProduct.Name = "colThanhTienSoldProduct";
            this.colThanhTienSoldProduct.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAddressCustom);
            this.groupBox1.Controls.Add(this.txtPhoneNumberCustom);
            this.groupBox1.Controls.Add(this.txtNameCustom);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(4, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Khách Hàng";
            // 
            // txtAddressCustom
            // 
            this.txtAddressCustom.Location = new System.Drawing.Point(101, 69);
            this.txtAddressCustom.Name = "txtAddressCustom";
            this.txtAddressCustom.Size = new System.Drawing.Size(472, 20);
            this.txtAddressCustom.TabIndex = 7;
            // 
            // txtPhoneNumberCustom
            // 
            this.txtPhoneNumberCustom.Location = new System.Drawing.Point(101, 43);
            this.txtPhoneNumberCustom.Name = "txtPhoneNumberCustom";
            this.txtPhoneNumberCustom.Size = new System.Drawing.Size(472, 20);
            this.txtPhoneNumberCustom.TabIndex = 6;
            // 
            // txtNameCustom
            // 
            this.txtNameCustom.Location = new System.Drawing.Point(101, 17);
            this.txtNameCustom.Name = "txtNameCustom";
            this.txtNameCustom.Size = new System.Drawing.Size(472, 20);
            this.txtNameCustom.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Địa Chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Số Điện Thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tên Khách Hàng";
            // 
            // FormBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 461);
            this.Controls.Add(this.pnSell);
            this.Controls.Add(this.pnDepot);
            this.Name = "FormBanHang";
            this.Text = "Bán Hàng";
            this.Load += new System.EventHandler(this.FormBanHang_Load);
            this.pnDepot.ResumeLayout(false);
            this.pnDepot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhoBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvSanPham)).EndInit();
            this.pnSell.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.pnSoldProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvSoldProduct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnDepot;
        private System.Windows.Forms.Panel pnSell;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grvSanPham;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAddressCustom;
        private System.Windows.Forms.TextBox txtPhoneNumberCustom;
        private System.Windows.Forms.TextBox txtNameCustom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtTienPhaiTra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtChietKhau;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTraLai;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtKhachDua;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.TextBox txtIDBill;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.BindingSource quanLyKhoBindingSource;
        private System.Windows.Forms.ComboBox cbxNameProduct;
        private System.Windows.Forms.ComboBox cbxIDProduct;
        private System.Windows.Forms.ComboBox cbxCategoriesProduct;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn DanhMucSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongTonKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.Panel pnSoldProduct;
        private System.Windows.Forms.DataGridView grvSoldProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDSoldProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNameSoldProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaBanSoldProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumSell;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTienSoldProduct;
        private System.Windows.Forms.Button btnCreateBill;
    }
}