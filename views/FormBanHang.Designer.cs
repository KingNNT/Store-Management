namespace KH039.views
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFindTenSanPham = new System.Windows.Forms.TextBox();
            this.btnFindSanPham = new System.Windows.Forms.Button();
            this.txtFindPhoneNumBerKhachHang = new System.Windows.Forms.TextBox();
            this.btnFindPhoneNumberKhachHang = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grvSanPham = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grvKhachHang = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.txtTienTraLai = new System.Windows.Forms.TextBox();
            this.txtKhachPhaiTra = new System.Windows.Forms.TextBox();
            this.txtChietKhau = new System.Windows.Forms.TextBox();
            this.txtKhachDua = new System.Windows.Forms.TextBox();
            this.txtSoHoaDon = new System.Windows.Forms.TextBox();
            this.btnClearProduct = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvSanPham)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvKhachHang)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Mã Sản Phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập Số Điện Thoại Khách Hàng";
            // 
            // txtFindTenSanPham
            // 
            this.txtFindTenSanPham.Location = new System.Drawing.Point(125, 6);
            this.txtFindTenSanPham.Name = "txtFindTenSanPham";
            this.txtFindTenSanPham.Size = new System.Drawing.Size(228, 20);
            this.txtFindTenSanPham.TabIndex = 2;
            // 
            // btnFindSanPham
            // 
            this.btnFindSanPham.Location = new System.Drawing.Point(359, 4);
            this.btnFindSanPham.Name = "btnFindSanPham";
            this.btnFindSanPham.Size = new System.Drawing.Size(117, 23);
            this.btnFindSanPham.TabIndex = 3;
            this.btnFindSanPham.Text = "Tìm Kiếm Sản Phẩm";
            this.btnFindSanPham.UseVisualStyleBackColor = true;
            this.btnFindSanPham.Click += new System.EventHandler(this.btnFindSanPham_Click);
            // 
            // txtFindPhoneNumBerKhachHang
            // 
            this.txtFindPhoneNumBerKhachHang.Location = new System.Drawing.Point(185, 183);
            this.txtFindPhoneNumBerKhachHang.Name = "txtFindPhoneNumBerKhachHang";
            this.txtFindPhoneNumBerKhachHang.Size = new System.Drawing.Size(256, 20);
            this.txtFindPhoneNumBerKhachHang.TabIndex = 4;
            // 
            // btnFindPhoneNumberKhachHang
            // 
            this.btnFindPhoneNumberKhachHang.Location = new System.Drawing.Point(447, 181);
            this.btnFindPhoneNumberKhachHang.Name = "btnFindPhoneNumberKhachHang";
            this.btnFindPhoneNumberKhachHang.Size = new System.Drawing.Size(209, 23);
            this.btnFindPhoneNumberKhachHang.TabIndex = 5;
            this.btnFindPhoneNumberKhachHang.Text = "Tìm Kiếm Số Điện Thoại Khách Hàng";
            this.btnFindPhoneNumberKhachHang.UseVisualStyleBackColor = true;
            this.btnFindPhoneNumberKhachHang.Click += new System.EventHandler(this.btnFindPhoneNumberKhachHang_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grvSanPham);
            this.panel1.Location = new System.Drawing.Point(15, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 142);
            this.panel1.TabIndex = 6;
            // 
            // grvSanPham
            // 
            this.grvSanPham.AllowUserToAddRows = false;
            this.grvSanPham.AllowUserToDeleteRows = false;
            this.grvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvSanPham.Location = new System.Drawing.Point(0, 0);
            this.grvSanPham.Name = "grvSanPham";
            this.grvSanPham.Size = new System.Drawing.Size(773, 142);
            this.grvSanPham.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grvKhachHang);
            this.panel2.Location = new System.Drawing.Point(15, 211);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(773, 126);
            this.panel2.TabIndex = 7;
            // 
            // grvKhachHang
            // 
            this.grvKhachHang.AllowUserToAddRows = false;
            this.grvKhachHang.AllowUserToDeleteRows = false;
            this.grvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvKhachHang.Location = new System.Drawing.Point(0, 0);
            this.grvKhachHang.Name = "grvKhachHang";
            this.grvKhachHang.ReadOnly = true;
            this.grvKhachHang.Size = new System.Drawing.Size(773, 126);
            this.grvKhachHang.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tổng Tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Khách Đưa";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(79, 15);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(137, 20);
            this.txtTongTien.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Chiết Khấu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(452, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Số Hóa Đơn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(452, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tiền Trả Lại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(222, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Khách Phải Trả";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnTinhTien);
            this.panel3.Controls.Add(this.btnThanhToan);
            this.panel3.Controls.Add(this.txtTienTraLai);
            this.panel3.Controls.Add(this.txtKhachPhaiTra);
            this.panel3.Controls.Add(this.txtChietKhau);
            this.panel3.Controls.Add(this.txtKhachDua);
            this.panel3.Controls.Add(this.txtSoHoaDon);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtTongTien);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(15, 343);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(773, 95);
            this.panel3.TabIndex = 15;
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(695, 14);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(75, 20);
            this.btnTinhTien.TabIndex = 21;
            this.btnTinhTien.Text = "Tính Tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(695, 45);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(75, 20);
            this.btnThanhToan.TabIndex = 20;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // txtTienTraLai
            // 
            this.txtTienTraLai.Location = new System.Drawing.Point(522, 45);
            this.txtTienTraLai.Name = "txtTienTraLai";
            this.txtTienTraLai.Size = new System.Drawing.Size(137, 20);
            this.txtTienTraLai.TabIndex = 19;
            // 
            // txtKhachPhaiTra
            // 
            this.txtKhachPhaiTra.Location = new System.Drawing.Point(309, 45);
            this.txtKhachPhaiTra.Name = "txtKhachPhaiTra";
            this.txtKhachPhaiTra.Size = new System.Drawing.Size(137, 20);
            this.txtKhachPhaiTra.TabIndex = 18;
            // 
            // txtChietKhau
            // 
            this.txtChietKhau.Location = new System.Drawing.Point(309, 15);
            this.txtChietKhau.Name = "txtChietKhau";
            this.txtChietKhau.Size = new System.Drawing.Size(137, 20);
            this.txtChietKhau.TabIndex = 17;
            this.txtChietKhau.TextChanged += new System.EventHandler(this.txtChietKhau_TextChanged);
            // 
            // txtKhachDua
            // 
            this.txtKhachDua.Location = new System.Drawing.Point(79, 45);
            this.txtKhachDua.Name = "txtKhachDua";
            this.txtKhachDua.Size = new System.Drawing.Size(137, 20);
            this.txtKhachDua.TabIndex = 16;
            this.txtKhachDua.TextChanged += new System.EventHandler(this.txtKhachDua_TextChanged);
            // 
            // txtSoHoaDon
            // 
            this.txtSoHoaDon.Location = new System.Drawing.Point(522, 15);
            this.txtSoHoaDon.Name = "txtSoHoaDon";
            this.txtSoHoaDon.Size = new System.Drawing.Size(137, 20);
            this.txtSoHoaDon.TabIndex = 15;
            // 
            // btnClearProduct
            // 
            this.btnClearProduct.Location = new System.Drawing.Point(482, 3);
            this.btnClearProduct.Name = "btnClearProduct";
            this.btnClearProduct.Size = new System.Drawing.Size(174, 23);
            this.btnClearProduct.TabIndex = 16;
            this.btnClearProduct.Text = "Làm Mới Danh Sách Sản Phẩm";
            this.btnClearProduct.UseVisualStyleBackColor = true;
            this.btnClearProduct.Click += new System.EventHandler(this.btnClearProduct_Click);
            // 
            // FormBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClearProduct);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnFindPhoneNumberKhachHang);
            this.Controls.Add(this.txtFindPhoneNumBerKhachHang);
            this.Controls.Add(this.btnFindSanPham);
            this.Controls.Add(this.txtFindTenSanPham);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormBanHang";
            this.Text = "Bán Hàng";
            this.Load += new System.EventHandler(this.FormBanHang_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvSanPham)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvKhachHang)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFindTenSanPham;
        private System.Windows.Forms.Button btnFindSanPham;
        private System.Windows.Forms.TextBox txtFindPhoneNumBerKhachHang;
        private System.Windows.Forms.Button btnFindPhoneNumberKhachHang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtKhachPhaiTra;
        private System.Windows.Forms.TextBox txtChietKhau;
        private System.Windows.Forms.TextBox txtKhachDua;
        private System.Windows.Forms.TextBox txtSoHoaDon;
        private System.Windows.Forms.TextBox txtTienTraLai;
        private System.Windows.Forms.DataGridView grvSanPham;
        private System.Windows.Forms.DataGridView grvKhachHang;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnClearProduct;
        private System.Windows.Forms.Button btnTinhTien;
    }
}