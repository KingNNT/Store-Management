USE [StoreManagement]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 20/08/2020 2:31:08 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[Username] [nvarchar](20) NOT NULL,
	[Password] [nchar](100) NOT NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Email] [varchar](100) NULL,
	[IDPermission] [int] NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [Pk_NguoiDung_id] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietDonBanHang]    Script Date: 20/08/2020 2:31:08 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDonBanHang](
	[MaDonHang] [int] NOT NULL,
	[MaSanPham] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[ThanhTien] [money] NOT NULL,
 CONSTRAINT [Pk_ChiTietDonBanHang_MaDonHang] PRIMARY KEY CLUSTERED 
(
	[MaDonHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietTrangThaiDonHang]    Script Date: 20/08/2020 2:31:08 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietTrangThaiDonHang](
	[MaTrangThaiDonHang] [int] IDENTITY(1,1) NOT NULL,
	[TenTrangThai] [nvarchar](max) NOT NULL,
 CONSTRAINT [Pk_ChiTietTrangThaiDonHang_id] PRIMARY KEY CLUSTERED 
(
	[MaTrangThaiDonHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietTrangThaiNhapHang]    Script Date: 20/08/2020 2:31:08 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietTrangThaiNhapHang](
	[MaDonHang] [int] NOT NULL,
	[MaSanPham] [int] NOT NULL,
	[SoLuongNhap] [int] NOT NULL,
	[ThanhTien] [money] NOT NULL,
 CONSTRAINT [Pk_ChiTietTrangThaiNhapHang_MaDonHang] PRIMARY KEY CLUSTERED 
(
	[MaDonHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanhMucSanPham]    Script Date: 20/08/2020 2:31:08 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhMucSanPham](
	[MaDanhMucSanPham] [int] IDENTITY(1,1) NOT NULL,
	[TenDanhMucSanPham] [nvarchar](50) NOT NULL,
 CONSTRAINT [Pk_DanhMucSanPham_id] PRIMARY KEY CLUSTERED 
(
	[MaDanhMucSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 20/08/2020 2:31:08 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKhachHang] [nvarchar](20) NOT NULL,
	[TenKhachHang] [nvarchar](20) NOT NULL,
	[MaNhomKhachHang] [int] NULL,
	[SoDienThoaiKhachHang] [nvarchar](20) NULL,
	[DiaChi] [nvarchar](20) NOT NULL,
	[EmailKhachHang] [nvarchar](50) NULL,
 CONSTRAINT [PK_QUANLYKHACHHANG] PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MaGiamGia]    Script Date: 20/08/2020 2:31:08 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MaGiamGia](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaCode] [nvarchar](20) NOT NULL,
	[GiamTheoPhanTram] [int] NOT NULL,
	[GiamTheoSoTien] [money] NOT NULL,
	[NgayTao] [datetime] NOT NULL,
	[NgayHetHan] [datetime] NOT NULL,
 CONSTRAINT [Pk_MaGiamGia_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 20/08/2020 2:31:08 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNhaCungCap] [int] IDENTITY(1,1) NOT NULL,
	[TenNhaCungCap] [nvarchar](50) NOT NULL,
	[DiaChiNhaCungCap] [nvarchar](100) NOT NULL,
	[SoDienThoaiNhaCungCap] [nvarchar](20) NOT NULL,
	[EmailNhaCungCap] [nvarchar](50) NULL,
 CONSTRAINT [Pk_NhaCungCap_MaNhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNhaCungCap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 20/08/2020 2:31:08 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [int] IDENTITY(1,1) NOT NULL,
	[TenNhanVien] [nvarchar](50) NOT NULL,
	[NgayThangNamSinh] [date] NOT NULL,
	[SoDienThoaiNhanVien] [nvarchar](20) NOT NULL,
	[EmailNhanVien] [nvarchar](20) NULL,
	[SoTheCanCuocNhanVien] [nvarchar](15) NOT NULL,
	[DiaChiThuongTru] [nvarchar](100) NOT NULL,
	[HinhDaiDienNhanVien] [nvarchar](max) NULL,
	[QueQuan] [nvarchar](max) NOT NULL,
 CONSTRAINT [Pk_NhanVien_MaNhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhomKhachHang]    Script Date: 20/08/2020 2:31:08 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhomKhachHang](
	[MaNhomKhachHang] [int] IDENTITY(1,1) NOT NULL,
	[TenNhomKhachHang] [nvarchar](50) NULL,
 CONSTRAINT [Pk_NhomKhachHang_MaNhomKhachHang] PRIMARY KEY CLUSTERED 
(
	[MaNhomKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permission]    Script Date: 20/08/2020 2:31:08 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permission](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NULL,
 CONSTRAINT [Pk_Permission_id] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuanLyBanHang]    Script Date: 20/08/2020 2:31:08 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuanLyBanHang](
	[MaDonHang] [int] NOT NULL,
	[TenKhachHang] [nvarchar](50) NOT NULL,
	[ThanhTien] [money] NOT NULL,
	[NgayTaoDon] [datetime] NOT NULL,
	[MaTrangThaiDonHang] [int] NOT NULL,
 CONSTRAINT [Pk_QuanLyBanHang_MaDonHang] PRIMARY KEY CLUSTERED 
(
	[MaDonHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuanLyHangTrongKho]    Script Date: 20/08/2020 2:31:08 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuanLyHangTrongKho](
	[MaSanPham] [nvarchar](20) NOT NULL,
	[SoLuongTonKho] [bigint] NOT NULL,
	[MaKho] [int] NOT NULL,
 CONSTRAINT [PK_QUANLYSANPHAM'] PRIMARY KEY CLUSTERED 
(
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuanLyKho]    Script Date: 20/08/2020 2:31:08 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuanLyKho](
	[MaKho] [int] IDENTITY(1,1) NOT NULL,
	[TenKho] [nvarchar](50) NULL,
	[DiaChiKho] [nvarchar](100) NULL,
	[DienTichKho] [int] NULL,
	[MaNhanVienQuanLy] [int] NOT NULL,
	[SucChuaHienTai] [int] NOT NULL,
 CONSTRAINT [Pk_QuanLyKho_MaKho] PRIMARY KEY CLUSTERED 
(
	[MaKho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuanLyNhapHang]    Script Date: 20/08/2020 2:31:08 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuanLyNhapHang](
	[MaDonHang] [int] NOT NULL,
	[NgayTaoDon] [datetime] NOT NULL,
	[MaNhaCungCap] [int] NOT NULL,
	[ThanhTien] [money] NOT NULL,
	[MaTrangThaiDonHang] [int] NULL,
 CONSTRAINT [Pk_QuanLyNhapHang_MaDonHang] PRIMARY KEY CLUSTERED 
(
	[MaDonHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuanLySanPham]    Script Date: 20/08/2020 2:31:08 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuanLySanPham](
	[MaSanPham] [int] IDENTITY(1,1) NOT NULL,
	[TenSanPham] [nvarchar](50) NOT NULL,
	[MaDanhMucSanPham] [int] NOT NULL,
	[GiaNhap] [money] NOT NULL,
	[GiaBan] [money] NOT NULL,
	[TrangThaiSanPham] [bit] NOT NULL,
 CONSTRAINT [Pk_QuanLySanPham_MaSanPham] PRIMARY KEY CLUSTERED 
(
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Account] ON 

INSERT [dbo].[Account] ([Username], [Password], [id], [Email], [IDPermission], [Status]) VALUES (N'admin', N'21232f297a57a5a743894a0e4a801fc3                                                                    ', 1, N'Dev.KingNNT@gmail.com', 1, 1)
SET IDENTITY_INSERT [dbo].[Account] OFF
GO
/****** Object:  Index [Unq_Account_IDPermission]    Script Date: 20/08/2020 2:31:08 CH ******/
ALTER TABLE [dbo].[Account] ADD  CONSTRAINT [Unq_Account_IDPermission] UNIQUE NONCLUSTERED 
(
	[IDPermission] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [Unq_ChiTietDonBanHang_MaSanPham]    Script Date: 20/08/2020 2:31:08 CH ******/
ALTER TABLE [dbo].[ChiTietDonBanHang] ADD  CONSTRAINT [Unq_ChiTietDonBanHang_MaSanPham] UNIQUE NONCLUSTERED 
(
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [Unq_ChiTietTrangThaiNhapHang_MaSanPham]    Script Date: 20/08/2020 2:31:08 CH ******/
ALTER TABLE [dbo].[ChiTietTrangThaiNhapHang] ADD  CONSTRAINT [Unq_ChiTietTrangThaiNhapHang_MaSanPham] UNIQUE NONCLUSTERED 
(
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [Unq_KhachHang_MaNhomKhachHang]    Script Date: 20/08/2020 2:31:08 CH ******/
ALTER TABLE [dbo].[KhachHang] ADD  CONSTRAINT [Unq_KhachHang_MaNhomKhachHang] UNIQUE NONCLUSTERED 
(
	[MaNhomKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [Unq_QuanLyBanHang_MaTrangThaiDonHang]    Script Date: 20/08/2020 2:31:08 CH ******/
ALTER TABLE [dbo].[QuanLyBanHang] ADD  CONSTRAINT [Unq_QuanLyBanHang_MaTrangThaiDonHang] UNIQUE NONCLUSTERED 
(
	[MaTrangThaiDonHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [Unq_QuanLyHangTrongKho_MaKho]    Script Date: 20/08/2020 2:31:08 CH ******/
ALTER TABLE [dbo].[QuanLyHangTrongKho] ADD  CONSTRAINT [Unq_QuanLyHangTrongKho_MaKho] UNIQUE NONCLUSTERED 
(
	[MaKho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [Unq_QuanLyKho_MaNhanVienQuanLy]    Script Date: 20/08/2020 2:31:08 CH ******/
ALTER TABLE [dbo].[QuanLyKho] ADD  CONSTRAINT [Unq_QuanLyKho_MaNhanVienQuanLy] UNIQUE NONCLUSTERED 
(
	[MaNhanVienQuanLy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [Unq_QuanLyNhapHang_MaNhaCungCap]    Script Date: 20/08/2020 2:31:08 CH ******/
ALTER TABLE [dbo].[QuanLyNhapHang] ADD  CONSTRAINT [Unq_QuanLyNhapHang_MaNhaCungCap] UNIQUE NONCLUSTERED 
(
	[MaNhaCungCap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [Unq_QuanLyNhapHang_MaTrangThaiDonHang]    Script Date: 20/08/2020 2:31:08 CH ******/
ALTER TABLE [dbo].[QuanLyNhapHang] ADD  CONSTRAINT [Unq_QuanLyNhapHang_MaTrangThaiDonHang] UNIQUE NONCLUSTERED 
(
	[MaTrangThaiDonHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [Unq_QuanLySanPham_MaDanhMucSanPham]    Script Date: 20/08/2020 2:31:08 CH ******/
ALTER TABLE [dbo].[QuanLySanPham] ADD  CONSTRAINT [Unq_QuanLySanPham_MaDanhMucSanPham] UNIQUE NONCLUSTERED 
(
	[MaDanhMucSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[MaGiamGia] ADD  CONSTRAINT [defo_MaGiamGia_GiamTheoPhanTram]  DEFAULT ((0)) FOR [GiamTheoPhanTram]
GO
ALTER TABLE [dbo].[MaGiamGia] ADD  CONSTRAINT [defo_MaGiamGia_GiamTheoSoTien]  DEFAULT ((0)) FOR [GiamTheoSoTien]
GO
ALTER TABLE [dbo].[MaGiamGia] ADD  CONSTRAINT [defo_MaGiamGia_NgayTao]  DEFAULT (sysdatetime()) FOR [NgayTao]
GO
ALTER TABLE [dbo].[MaGiamGia] ADD  CONSTRAINT [defo_MaGiamGia_NgayHetHan]  DEFAULT (sysdatetime()) FOR [NgayHetHan]
GO
ALTER TABLE [dbo].[QuanLyBanHang] ADD  CONSTRAINT [defo_QuanLyBanHang_NgayTaoDon]  DEFAULT (sysdatetime()) FOR [NgayTaoDon]
GO
ALTER TABLE [dbo].[QuanLyKho] ADD  CONSTRAINT [defo_QuanLyKho_SucChuaHienTai]  DEFAULT ((0)) FOR [SucChuaHienTai]
GO
ALTER TABLE [dbo].[QuanLyNhapHang] ADD  CONSTRAINT [defo_QuanLyNhapHang_NgayTaoDon]  DEFAULT (sysdatetime()) FOR [NgayTaoDon]
GO
ALTER TABLE [dbo].[ChiTietTrangThaiDonHang]  WITH CHECK ADD  CONSTRAINT [Fk_ChiTietTrangThaiDonHang_QuanLyBanHang] FOREIGN KEY([MaTrangThaiDonHang])
REFERENCES [dbo].[QuanLyBanHang] ([MaTrangThaiDonHang])
GO
ALTER TABLE [dbo].[ChiTietTrangThaiDonHang] CHECK CONSTRAINT [Fk_ChiTietTrangThaiDonHang_QuanLyBanHang]
GO
ALTER TABLE [dbo].[ChiTietTrangThaiDonHang]  WITH CHECK ADD  CONSTRAINT [Fk_ChiTietTrangThaiDonHang_QuanLyNhapHang] FOREIGN KEY([MaTrangThaiDonHang])
REFERENCES [dbo].[QuanLyNhapHang] ([MaTrangThaiDonHang])
GO
ALTER TABLE [dbo].[ChiTietTrangThaiDonHang] CHECK CONSTRAINT [Fk_ChiTietTrangThaiDonHang_QuanLyNhapHang]
GO
ALTER TABLE [dbo].[DanhMucSanPham]  WITH CHECK ADD  CONSTRAINT [Fk_DanhMucSanPham_QuanLySanPham] FOREIGN KEY([MaDanhMucSanPham])
REFERENCES [dbo].[QuanLySanPham] ([MaDanhMucSanPham])
GO
ALTER TABLE [dbo].[DanhMucSanPham] CHECK CONSTRAINT [Fk_DanhMucSanPham_QuanLySanPham]
GO
ALTER TABLE [dbo].[NhaCungCap]  WITH CHECK ADD  CONSTRAINT [Fk_NhaCungCap_QuanLyNhapHang] FOREIGN KEY([MaNhaCungCap])
REFERENCES [dbo].[QuanLyNhapHang] ([MaNhaCungCap])
GO
ALTER TABLE [dbo].[NhaCungCap] CHECK CONSTRAINT [Fk_NhaCungCap_QuanLyNhapHang]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [Fk_NhanVien_QuanLyKho] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[QuanLyKho] ([MaNhanVienQuanLy])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [Fk_NhanVien_QuanLyKho]
GO
ALTER TABLE [dbo].[NhomKhachHang]  WITH CHECK ADD  CONSTRAINT [Fk_NhomKhachHang_KhachHang] FOREIGN KEY([MaNhomKhachHang])
REFERENCES [dbo].[KhachHang] ([MaNhomKhachHang])
GO
ALTER TABLE [dbo].[NhomKhachHang] CHECK CONSTRAINT [Fk_NhomKhachHang_KhachHang]
GO
ALTER TABLE [dbo].[Permission]  WITH CHECK ADD  CONSTRAINT [Fk_Permission_Account] FOREIGN KEY([id])
REFERENCES [dbo].[Account] ([IDPermission])
GO
ALTER TABLE [dbo].[Permission] CHECK CONSTRAINT [Fk_Permission_Account]
GO
ALTER TABLE [dbo].[QuanLyBanHang]  WITH CHECK ADD  CONSTRAINT [Fk_QuanLyBanHang_ChiTietDonBanHang] FOREIGN KEY([MaDonHang])
REFERENCES [dbo].[ChiTietDonBanHang] ([MaDonHang])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[QuanLyBanHang] CHECK CONSTRAINT [Fk_QuanLyBanHang_ChiTietDonBanHang]
GO
ALTER TABLE [dbo].[QuanLyKho]  WITH CHECK ADD  CONSTRAINT [Fk_QuanLyKho_QuanLyHangTrongKho] FOREIGN KEY([MaKho])
REFERENCES [dbo].[QuanLyHangTrongKho] ([MaKho])
GO
ALTER TABLE [dbo].[QuanLyKho] CHECK CONSTRAINT [Fk_QuanLyKho_QuanLyHangTrongKho]
GO
ALTER TABLE [dbo].[QuanLyNhapHang]  WITH CHECK ADD  CONSTRAINT [Fk_QuanLyNhapHang_ChiTietTrangThaiNhapHang] FOREIGN KEY([MaDonHang])
REFERENCES [dbo].[ChiTietTrangThaiNhapHang] ([MaDonHang])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[QuanLyNhapHang] CHECK CONSTRAINT [Fk_QuanLyNhapHang_ChiTietTrangThaiNhapHang]
GO
ALTER TABLE [dbo].[QuanLySanPham]  WITH CHECK ADD  CONSTRAINT [Fk_QuanLySanPham_ChiTietDonBanHang] FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[ChiTietDonBanHang] ([MaSanPham])
GO
ALTER TABLE [dbo].[QuanLySanPham] CHECK CONSTRAINT [Fk_QuanLySanPham_ChiTietDonBanHang]
GO
ALTER TABLE [dbo].[QuanLySanPham]  WITH CHECK ADD  CONSTRAINT [Fk_QuanLySanPham_ChiTietTrangThaiNhapHang] FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[ChiTietTrangThaiNhapHang] ([MaSanPham])
GO
ALTER TABLE [dbo].[QuanLySanPham] CHECK CONSTRAINT [Fk_QuanLySanPham_ChiTietTrangThaiNhapHang]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Các quyền truy cập của tài khoản' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Permission'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tinh tren don vi m2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'QuanLyKho', @level2type=N'COLUMN',@level2name=N'DienTichKho'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tinh tren don vi %' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'QuanLyKho', @level2type=N'COLUMN',@level2name=N'SucChuaHienTai'
GO
