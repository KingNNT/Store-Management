﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StoreManagement.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class StoreManagementEntities : DbContext
    {
        public StoreManagementEntities()
            : base("name=StoreManagementEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<ChiTietDonBanHang> ChiTietDonBanHang { get; set; }
        public virtual DbSet<ChiTietTrangThaiDonHang> ChiTietTrangThaiDonHang { get; set; }
        public virtual DbSet<ChiTietTrangThaiNhapHang> ChiTietTrangThaiNhapHang { get; set; }
        public virtual DbSet<DanhMucSanPham> DanhMucSanPham { get; set; }
        public virtual DbSet<KhachHang> KhachHang { get; set; }
        public virtual DbSet<MaGiamGia> MaGiamGia { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCap { get; set; }
        public virtual DbSet<NhanVien> NhanVien { get; set; }
        public virtual DbSet<NhomKhachHang> NhomKhachHang { get; set; }
        public virtual DbSet<Permission> Permission { get; set; }
        public virtual DbSet<QuanLyBanHang> QuanLyBanHang { get; set; }
        public virtual DbSet<QuanLyHangTrongKho> QuanLyHangTrongKho { get; set; }
        public virtual DbSet<QuanLyKho> QuanLyKho { get; set; }
        public virtual DbSet<QuanLyNhapHang> QuanLyNhapHang { get; set; }
        public virtual DbSet<QuanLySanPham> QuanLySanPham { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
