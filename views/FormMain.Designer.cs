namespace KH039.views
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItemBanHang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNhapHang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemQuanLyKhoHang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTimKiemDonHang = new System.Windows.Forms.ToolStripMenuItem();
            this.pContainer = new System.Windows.Forms.Panel();
            this.menuItemQuanLyKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemBanHang,
            this.menuItemNhapHang,
            this.menuItemQuanLyKhoHang,
            this.menuItemTimKiemDonHang,
            this.menuItemQuanLyKhachHang});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(816, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItemBanHang
            // 
            this.menuItemBanHang.Name = "menuItemBanHang";
            this.menuItemBanHang.Size = new System.Drawing.Size(71, 20);
            this.menuItemBanHang.Text = "Bán Hàng";
            this.menuItemBanHang.Click += new System.EventHandler(this.menuItemBanHang_Click);
            // 
            // menuItemNhapHang
            // 
            this.menuItemNhapHang.Name = "menuItemNhapHang";
            this.menuItemNhapHang.Size = new System.Drawing.Size(80, 20);
            this.menuItemNhapHang.Text = "Nhập Hàng";
            this.menuItemNhapHang.Click += new System.EventHandler(this.menuItemNhapHang_Click);
            // 
            // menuItemQuanLyKhoHang
            // 
            this.menuItemQuanLyKhoHang.Name = "menuItemQuanLyKhoHang";
            this.menuItemQuanLyKhoHang.Size = new System.Drawing.Size(118, 20);
            this.menuItemQuanLyKhoHang.Text = "Quản Lý Kho Hàng";
            this.menuItemQuanLyKhoHang.Click += new System.EventHandler(this.menuItemQuanLyKhoHang_Click);
            // 
            // menuItemTimKiemDonHang
            // 
            this.menuItemTimKiemDonHang.Name = "menuItemTimKiemDonHang";
            this.menuItemTimKiemDonHang.Size = new System.Drawing.Size(126, 20);
            this.menuItemTimKiemDonHang.Text = "Tìm Kiếm Đơn Hàng";
            this.menuItemTimKiemDonHang.Click += new System.EventHandler(this.menuItemTimKiemDonHang_Click);
            // 
            // pContainer
            // 
            this.pContainer.Location = new System.Drawing.Point(12, 27);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(792, 411);
            this.pContainer.TabIndex = 1;
            // 
            // menuItemQuanLyKhachHang
            // 
            this.menuItemQuanLyKhachHang.Name = "menuItemQuanLyKhachHang";
            this.menuItemQuanLyKhachHang.Size = new System.Drawing.Size(130, 20);
            this.menuItemQuanLyKhachHang.Text = "Quản Lý Khách Hàng";
            this.menuItemQuanLyKhachHang.Click += new System.EventHandler(this.menuItemQuanLyKhachHang_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 450);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Bán Hàng";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItemBanHang;
        private System.Windows.Forms.ToolStripMenuItem menuItemNhapHang;
        private System.Windows.Forms.ToolStripMenuItem menuItemQuanLyKhoHang;
        private System.Windows.Forms.ToolStripMenuItem menuItemTimKiemDonHang;
        private System.Windows.Forms.Panel pContainer;
        private System.Windows.Forms.ToolStripMenuItem menuItemQuanLyKhachHang;
    }
}