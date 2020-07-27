USE [KH039-LTKK]
GO
/****** Object:  User [DESKTOP-KK3HOG2\KingN]    Script Date: 28/07/2020 12:14:18 SA ******/
CREATE USER [DESKTOP-KK3HOG2\KingN] FOR LOGIN [DESKTOP-KK3HOG2\KingN] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [KingNNT]    Script Date: 28/07/2020 12:14:18 SA ******/
CREATE USER [KingNNT] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[NGUOIDUNG]    Script Date: 28/07/2020 12:14:18 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NGUOIDUNG](
	[TaiKhoan] [nvarchar](20) NOT NULL,
	[MatKhau] [nchar](20) NOT NULL,
 CONSTRAINT [PK_NGUOIDUNG] PRIMARY KEY CLUSTERED 
(
	[TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QUANLYBANHANG]    Script Date: 28/07/2020 12:14:18 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QUANLYBANHANG](
	[MaDH] [nvarchar](20) NOT NULL,
	[MaSP] [nvarchar](20) NOT NULL,
	[TenSP] [nvarchar](20) NOT NULL,
	[SDTKH] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_QUANLYBANHANG] PRIMARY KEY CLUSTERED 
(
	[MaDH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QUANLYDONHANG]    Script Date: 28/07/2020 12:14:18 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QUANLYDONHANG](
	[MaDH] [nvarchar](20) NOT NULL,
	[NgayTaoDon] [date] NULL,
	[TenKH] [nvarchar](20) NULL,
	[TrangThaiDonHang] [nvarchar](20) NULL,
	[KhachPhaiTra] [bigint] NULL,
 CONSTRAINT [PK_QUANLYDONHANG] PRIMARY KEY CLUSTERED 
(
	[MaDH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QUANLYKHACHHANG]    Script Date: 28/07/2020 12:14:18 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QUANLYKHACHHANG](
	[MaKH] [nvarchar](20) NOT NULL,
	[TenKH] [nvarchar](20) NOT NULL,
	[NhomKH] [nvarchar](20) NULL,
	[SDTKH] [nvarchar](20) NOT NULL,
	[DiaChi] [nvarchar](20) NULL,
	[TrangThaiKH] [nvarchar](20) NULL,
 CONSTRAINT [PK_QUANLYKHACHHANG] PRIMARY KEY CLUSTERED 
(
	[SDTKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QUANLYKHOHANG]    Script Date: 28/07/2020 12:14:18 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QUANLYKHOHANG](
	[MaSP] [nvarchar](20) NOT NULL,
	[HangDangVe] [bigint] NULL,
	[TrangThaiNhapHang] [nvarchar](20) NULL,
	[NhapKho] [bigint] NULL,
	[DonGia] [bigint] NULL,
 CONSTRAINT [PK_QUANLYKHOHANG] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QUANLYSANPHAM]    Script Date: 28/07/2020 12:14:18 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QUANLYSANPHAM](
	[TenSP] [nvarchar](20) NOT NULL,
	[MaSP] [nvarchar](20) NULL,
	[DanhMucSP] [nvarchar](20) NULL,
	[Kho] [bigint] NULL,
	[GiaNhap] [bigint] NULL,
	[GiaBanLe] [bigint] NULL,
	[Visible] [bit] NULL,
 CONSTRAINT [PK_QUANLYSANPHAM'] PRIMARY KEY CLUSTERED 
(
	[TenSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[NGUOIDUNG] ([TaiKhoan], [MatKhau]) VALUES (N'admin', N'admin               ')
GO
INSERT [dbo].[QUANLYBANHANG] ([MaDH], [MaSP], [TenSP], [SDTKH]) VALUES (N'MDH001', N'MSP001', N'TenSP001', N'0000')
INSERT [dbo].[QUANLYBANHANG] ([MaDH], [MaSP], [TenSP], [SDTKH]) VALUES (N'MDH002', N'MSP002', N'TenSP002', N'1111')
INSERT [dbo].[QUANLYBANHANG] ([MaDH], [MaSP], [TenSP], [SDTKH]) VALUES (N'MDH003', N'MSP001', N'TenSP001', N'1111')
INSERT [dbo].[QUANLYBANHANG] ([MaDH], [MaSP], [TenSP], [SDTKH]) VALUES (N'MDH004', N'MSP001', N'TenSP001', N'1111')
INSERT [dbo].[QUANLYBANHANG] ([MaDH], [MaSP], [TenSP], [SDTKH]) VALUES (N'MDH005', N'MSP001', N'TenSP001', N'1111')
INSERT [dbo].[QUANLYBANHANG] ([MaDH], [MaSP], [TenSP], [SDTKH]) VALUES (N'MDH006', N'MSP001', N'TenSP001', N'1111')
INSERT [dbo].[QUANLYBANHANG] ([MaDH], [MaSP], [TenSP], [SDTKH]) VALUES (N'MDH007', N'MSP001', N'TenSP001', N'1111')
INSERT [dbo].[QUANLYBANHANG] ([MaDH], [MaSP], [TenSP], [SDTKH]) VALUES (N'MDH008', N'MSP001', N'TenSP001', N'1111')
INSERT [dbo].[QUANLYBANHANG] ([MaDH], [MaSP], [TenSP], [SDTKH]) VALUES (N'MDH009', N'MSP001', N'TenSP001', N'1111')
INSERT [dbo].[QUANLYBANHANG] ([MaDH], [MaSP], [TenSP], [SDTKH]) VALUES (N'MDH010', N'MSP001', N'TenSP001', N'1111')
INSERT [dbo].[QUANLYBANHANG] ([MaDH], [MaSP], [TenSP], [SDTKH]) VALUES (N'MDH011', N'MSP001', N'TenSP001', N'1111')
INSERT [dbo].[QUANLYBANHANG] ([MaDH], [MaSP], [TenSP], [SDTKH]) VALUES (N'MDH012', N'MSP001', N'TenSP001', N'1111')
INSERT [dbo].[QUANLYBANHANG] ([MaDH], [MaSP], [TenSP], [SDTKH]) VALUES (N'MDH013', N'MSP001', N'TenSP001', N'1111')
INSERT [dbo].[QUANLYBANHANG] ([MaDH], [MaSP], [TenSP], [SDTKH]) VALUES (N'MDH014', N'MSP001', N'TenSP001', N'1111')
INSERT [dbo].[QUANLYBANHANG] ([MaDH], [MaSP], [TenSP], [SDTKH]) VALUES (N'MDH015', N'MSP001', N'TenSP001', N'1111')
INSERT [dbo].[QUANLYBANHANG] ([MaDH], [MaSP], [TenSP], [SDTKH]) VALUES (N'MDH016', N'MSP001', N'TenSP001', N'1111')
INSERT [dbo].[QUANLYBANHANG] ([MaDH], [MaSP], [TenSP], [SDTKH]) VALUES (N'MDH017', N'MSP001', N'TenSP001', N'2222')
INSERT [dbo].[QUANLYBANHANG] ([MaDH], [MaSP], [TenSP], [SDTKH]) VALUES (N'MDH018', N'MSP001', N'TenSP001', N'1111')
INSERT [dbo].[QUANLYBANHANG] ([MaDH], [MaSP], [TenSP], [SDTKH]) VALUES (N'MDH019', N'MSP002', N'TenSP002', N'2222')
INSERT [dbo].[QUANLYBANHANG] ([MaDH], [MaSP], [TenSP], [SDTKH]) VALUES (N'MDH020', N'MSP001', N'TenSP001', N'1111')
INSERT [dbo].[QUANLYBANHANG] ([MaDH], [MaSP], [TenSP], [SDTKH]) VALUES (N'MDH021', N'MSP011', N'TenSP011', N'1111')
INSERT [dbo].[QUANLYBANHANG] ([MaDH], [MaSP], [TenSP], [SDTKH]) VALUES (N'MDH022', N'MSP011', N'TenSP011', N'6666')
INSERT [dbo].[QUANLYBANHANG] ([MaDH], [MaSP], [TenSP], [SDTKH]) VALUES (N'MDH023', N'MSP011', N'TenSP011', N'5555')
INSERT [dbo].[QUANLYBANHANG] ([MaDH], [MaSP], [TenSP], [SDTKH]) VALUES (N'MDH024', N'MSP011', N'TenSP011', N'4444')
INSERT [dbo].[QUANLYBANHANG] ([MaDH], [MaSP], [TenSP], [SDTKH]) VALUES (N'MDH025', N'MSP001', N'TenSP001', N'1111')
INSERT [dbo].[QUANLYBANHANG] ([MaDH], [MaSP], [TenSP], [SDTKH]) VALUES (N'MDH026', N'MSP001', N'TenSP001', N'5555')
INSERT [dbo].[QUANLYBANHANG] ([MaDH], [MaSP], [TenSP], [SDTKH]) VALUES (N'MDH027', N'MSP001', N'TenSP001', N'No Infomation')
INSERT [dbo].[QUANLYBANHANG] ([MaDH], [MaSP], [TenSP], [SDTKH]) VALUES (N'MDH028', N'MSP002', N'TenSP002', N'No Infomation')
INSERT [dbo].[QUANLYBANHANG] ([MaDH], [MaSP], [TenSP], [SDTKH]) VALUES (N'MDH029', N'MSP001', N'TenSP001', N'No Infomation')
INSERT [dbo].[QUANLYBANHANG] ([MaDH], [MaSP], [TenSP], [SDTKH]) VALUES (N'MDH030', N'MSP001', N'TenSP001', N'1111')
INSERT [dbo].[QUANLYBANHANG] ([MaDH], [MaSP], [TenSP], [SDTKH]) VALUES (N'MDH031', N'MSP001', N'TenSP001', N'No Infomation')
GO
INSERT [dbo].[QUANLYDONHANG] ([MaDH], [NgayTaoDon], [TenKH], [TrangThaiDonHang], [KhachPhaiTra]) VALUES (N'MDH001', CAST(N'2020-06-25' AS Date), N'Nguyen Van A', N'TTDH1', 50000)
INSERT [dbo].[QUANLYDONHANG] ([MaDH], [NgayTaoDon], [TenKH], [TrangThaiDonHang], [KhachPhaiTra]) VALUES (N'MDH002', CAST(N'2020-06-24' AS Date), N'Nguyen Van B', N'TTDH2', 100000)
INSERT [dbo].[QUANLYDONHANG] ([MaDH], [NgayTaoDon], [TenKH], [TrangThaiDonHang], [KhachPhaiTra]) VALUES (N'MDH003', CAST(N'2020-06-23' AS Date), N'TenSP002', N'TTDH003', 50000)
INSERT [dbo].[QUANLYDONHANG] ([MaDH], [NgayTaoDon], [TenKH], [TrangThaiDonHang], [KhachPhaiTra]) VALUES (N'MDH005', CAST(N'2020-06-25' AS Date), N'Nguyen Van B', N'Not Categorized', 6500)
INSERT [dbo].[QUANLYDONHANG] ([MaDH], [NgayTaoDon], [TenKH], [TrangThaiDonHang], [KhachPhaiTra]) VALUES (N'MDH006', CAST(N'2020-06-25' AS Date), N'Nguyen Van B', N'Not Categorized', 68500)
INSERT [dbo].[QUANLYDONHANG] ([MaDH], [NgayTaoDon], [TenKH], [TrangThaiDonHang], [KhachPhaiTra]) VALUES (N'MDH007', CAST(N'2020-06-25' AS Date), N'Nguyen Van B', N'Not Categorized', 18500)
INSERT [dbo].[QUANLYDONHANG] ([MaDH], [NgayTaoDon], [TenKH], [TrangThaiDonHang], [KhachPhaiTra]) VALUES (N'MDH008', CAST(N'2020-06-25' AS Date), N'Nguyen Van B', N'Not Categorized', 23500)
INSERT [dbo].[QUANLYDONHANG] ([MaDH], [NgayTaoDon], [TenKH], [TrangThaiDonHang], [KhachPhaiTra]) VALUES (N'MDH009', CAST(N'2020-06-25' AS Date), N'Nguyen Van B', N'Not Categorized', 41500)
INSERT [dbo].[QUANLYDONHANG] ([MaDH], [NgayTaoDon], [TenKH], [TrangThaiDonHang], [KhachPhaiTra]) VALUES (N'MDH010', CAST(N'2020-06-25' AS Date), N'Nguyen Van B', N'Not Categorized', -71000)
INSERT [dbo].[QUANLYDONHANG] ([MaDH], [NgayTaoDon], [TenKH], [TrangThaiDonHang], [KhachPhaiTra]) VALUES (N'MDH011', CAST(N'2020-06-25' AS Date), N'Nguyen Van B', N'Not Categorized', 6500)
INSERT [dbo].[QUANLYDONHANG] ([MaDH], [NgayTaoDon], [TenKH], [TrangThaiDonHang], [KhachPhaiTra]) VALUES (N'MDH012', CAST(N'2020-06-25' AS Date), N'Nguyen Van B', N'Not Categorized', 36500)
INSERT [dbo].[QUANLYDONHANG] ([MaDH], [NgayTaoDon], [TenKH], [TrangThaiDonHang], [KhachPhaiTra]) VALUES (N'MDH013', CAST(N'2020-06-25' AS Date), N'Nguyen Van B', N'Not Categorized', 3000)
INSERT [dbo].[QUANLYDONHANG] ([MaDH], [NgayTaoDon], [TenKH], [TrangThaiDonHang], [KhachPhaiTra]) VALUES (N'MDH014', CAST(N'2020-06-25' AS Date), N'Nguyen Van B', N'Not Categorized', 23500)
INSERT [dbo].[QUANLYDONHANG] ([MaDH], [NgayTaoDon], [TenKH], [TrangThaiDonHang], [KhachPhaiTra]) VALUES (N'MDH015', CAST(N'2020-06-25' AS Date), N'Nguyen Van B', N'Not Categorized', 9500)
INSERT [dbo].[QUANLYDONHANG] ([MaDH], [NgayTaoDon], [TenKH], [TrangThaiDonHang], [KhachPhaiTra]) VALUES (N'MDH016', CAST(N'2020-06-25' AS Date), N'Nguyen Van B', N'Not Categorized', 9500)
INSERT [dbo].[QUANLYDONHANG] ([MaDH], [NgayTaoDon], [TenKH], [TrangThaiDonHang], [KhachPhaiTra]) VALUES (N'MDH017', CAST(N'2020-06-25' AS Date), N'Nguyen Van C', N'Not Categorized', 383000)
INSERT [dbo].[QUANLYDONHANG] ([MaDH], [NgayTaoDon], [TenKH], [TrangThaiDonHang], [KhachPhaiTra]) VALUES (N'MDH018', CAST(N'2020-06-25' AS Date), N'Nguyen Van B', N'Not Categorized', 5500)
INSERT [dbo].[QUANLYDONHANG] ([MaDH], [NgayTaoDon], [TenKH], [TrangThaiDonHang], [KhachPhaiTra]) VALUES (N'MDH019', CAST(N'2020-06-25' AS Date), N'Nguyen Van C', N'Not Categorized', 28500)
INSERT [dbo].[QUANLYDONHANG] ([MaDH], [NgayTaoDon], [TenKH], [TrangThaiDonHang], [KhachPhaiTra]) VALUES (N'MDH020', CAST(N'2020-06-25' AS Date), N'Nguyen Van B', N'Not Categorized', 6500)
INSERT [dbo].[QUANLYDONHANG] ([MaDH], [NgayTaoDon], [TenKH], [TrangThaiDonHang], [KhachPhaiTra]) VALUES (N'MDH021', CAST(N'2020-06-25' AS Date), N'Nguyen Van B', N'Not Categorized', 2000)
INSERT [dbo].[QUANLYDONHANG] ([MaDH], [NgayTaoDon], [TenKH], [TrangThaiDonHang], [KhachPhaiTra]) VALUES (N'MDH022', CAST(N'2020-06-25' AS Date), N'Nguyen Van G', N'Not Categorized', 3000)
INSERT [dbo].[QUANLYDONHANG] ([MaDH], [NgayTaoDon], [TenKH], [TrangThaiDonHang], [KhachPhaiTra]) VALUES (N'MDH023', CAST(N'2020-06-25' AS Date), N'Nguyen Van F', N'Not Categorized', 0)
INSERT [dbo].[QUANLYDONHANG] ([MaDH], [NgayTaoDon], [TenKH], [TrangThaiDonHang], [KhachPhaiTra]) VALUES (N'MDH024', CAST(N'2020-06-25' AS Date), N'Nguyen Van E', N'Not Categorized', 23000)
INSERT [dbo].[QUANLYDONHANG] ([MaDH], [NgayTaoDon], [TenKH], [TrangThaiDonHang], [KhachPhaiTra]) VALUES (N'MDH025', CAST(N'2020-06-25' AS Date), N'Nguyen Van B', N'Not Categorized', 74000)
INSERT [dbo].[QUANLYDONHANG] ([MaDH], [NgayTaoDon], [TenKH], [TrangThaiDonHang], [KhachPhaiTra]) VALUES (N'MDH026', CAST(N'2020-06-25' AS Date), N'Nguyen Van F', N'Not Categorized', 60000)
INSERT [dbo].[QUANLYDONHANG] ([MaDH], [NgayTaoDon], [TenKH], [TrangThaiDonHang], [KhachPhaiTra]) VALUES (N'MDH027', CAST(N'2020-06-26' AS Date), N'No Infomation', N'Not Categorized', 27000)
INSERT [dbo].[QUANLYDONHANG] ([MaDH], [NgayTaoDon], [TenKH], [TrangThaiDonHang], [KhachPhaiTra]) VALUES (N'MDH028', CAST(N'2020-06-26' AS Date), N'No Infomation', N'Not Categorized', 36000)
INSERT [dbo].[QUANLYDONHANG] ([MaDH], [NgayTaoDon], [TenKH], [TrangThaiDonHang], [KhachPhaiTra]) VALUES (N'MDH029', CAST(N'2020-07-04' AS Date), N'No Infomation', N'Not Categorized', 90000)
INSERT [dbo].[QUANLYDONHANG] ([MaDH], [NgayTaoDon], [TenKH], [TrangThaiDonHang], [KhachPhaiTra]) VALUES (N'MDH030', CAST(N'2020-07-09' AS Date), N'Nguyen Van B', N'Not Categorized', 112500)
INSERT [dbo].[QUANLYDONHANG] ([MaDH], [NgayTaoDon], [TenKH], [TrangThaiDonHang], [KhachPhaiTra]) VALUES (N'MDH031', CAST(N'2020-07-09' AS Date), N'No Infomation', N'Not Categorized', 3375000)
GO
INSERT [dbo].[QUANLYKHACHHANG] ([MaKH], [TenKH], [NhomKH], [SDTKH], [DiaChi], [TrangThaiKH]) VALUES (N'MKH001', N'Nguyen Van A', N'NhomKH001', N'0000', N'Ha Noi', N'TrangThaiKH001')
INSERT [dbo].[QUANLYKHACHHANG] ([MaKH], [TenKH], [NhomKH], [SDTKH], [DiaChi], [TrangThaiKH]) VALUES (N'MKH002', N'Nguyen Van B', N'NhomKH002', N'1111', N'Ha Noi', N'TrangThaiKH001')
INSERT [dbo].[QUANLYKHACHHANG] ([MaKH], [TenKH], [NhomKH], [SDTKH], [DiaChi], [TrangThaiKH]) VALUES (N'MKH003', N'Nguyen Van C', N'NhomKH003', N'2222', N'Hai Phong', N'TrangThaiKH003')
INSERT [dbo].[QUANLYKHACHHANG] ([MaKH], [TenKH], [NhomKH], [SDTKH], [DiaChi], [TrangThaiKH]) VALUES (N'MKH004', N'Nguyen Van D', N'NhomKH004', N'3333', N'Quang Ninh', N'TrangThaiKH003')
INSERT [dbo].[QUANLYKHACHHANG] ([MaKH], [TenKH], [NhomKH], [SDTKH], [DiaChi], [TrangThaiKH]) VALUES (N'MKH005', N'Nguyen Van E', N'NhomKH002', N'4444', N'Ninh Binh', N'TrangThaiKH005')
INSERT [dbo].[QUANLYKHACHHANG] ([MaKH], [TenKH], [NhomKH], [SDTKH], [DiaChi], [TrangThaiKH]) VALUES (N'MKH006', N'Nguyen Van F', N'NhomKH001', N'5555', N'Nam Dinh', N'TrangThaiKH001')
INSERT [dbo].[QUANLYKHACHHANG] ([MaKH], [TenKH], [NhomKH], [SDTKH], [DiaChi], [TrangThaiKH]) VALUES (N'MKH007', N'Nguyen Van G', N'NhomKH001', N'6666', N'Thai Binh', N'TrangThaiKH001')
GO
INSERT [dbo].[QUANLYKHOHANG] ([MaSP], [HangDangVe], [TrangThaiNhapHang], [NhapKho], [DonGia]) VALUES (N'MSP001', 200, N'TTNH1', 0, 15000)
INSERT [dbo].[QUANLYKHOHANG] ([MaSP], [HangDangVe], [TrangThaiNhapHang], [NhapKho], [DonGia]) VALUES (N'MSP002', 300, N'TTNH2', 0, 20000)
INSERT [dbo].[QUANLYKHOHANG] ([MaSP], [HangDangVe], [TrangThaiNhapHang], [NhapKho], [DonGia]) VALUES (N'MSP003', 400, N'TTNH3', 0, 25000)
INSERT [dbo].[QUANLYKHOHANG] ([MaSP], [HangDangVe], [TrangThaiNhapHang], [NhapKho], [DonGia]) VALUES (N'MSP004', 300, N'TTNH4', 0, 25000)
INSERT [dbo].[QUANLYKHOHANG] ([MaSP], [HangDangVe], [TrangThaiNhapHang], [NhapKho], [DonGia]) VALUES (N'MSP005', 200, N'TTNH5', 0, 20000)
INSERT [dbo].[QUANLYKHOHANG] ([MaSP], [HangDangVe], [TrangThaiNhapHang], [NhapKho], [DonGia]) VALUES (N'MSP006', 100, N'TTNH6', 0, 12000)
INSERT [dbo].[QUANLYKHOHANG] ([MaSP], [HangDangVe], [TrangThaiNhapHang], [NhapKho], [DonGia]) VALUES (N'MSP007', 200, N'TTNH7', 0, 15000)
INSERT [dbo].[QUANLYKHOHANG] ([MaSP], [HangDangVe], [TrangThaiNhapHang], [NhapKho], [DonGia]) VALUES (N'MSP008', 120, N'TTNH8', 0, 13000)
INSERT [dbo].[QUANLYKHOHANG] ([MaSP], [HangDangVe], [TrangThaiNhapHang], [NhapKho], [DonGia]) VALUES (N'MSP009', 11, N'TTNH9', 0, 1500)
INSERT [dbo].[QUANLYKHOHANG] ([MaSP], [HangDangVe], [TrangThaiNhapHang], [NhapKho], [DonGia]) VALUES (N'MSP010', 20, N'TTNH10', 0, 20000)
INSERT [dbo].[QUANLYKHOHANG] ([MaSP], [HangDangVe], [TrangThaiNhapHang], [NhapKho], [DonGia]) VALUES (N'MSP011', 100, N'TTNH11', 0, 15000)
GO
INSERT [dbo].[QUANLYSANPHAM] ([TenSP], [MaSP], [DanhMucSP], [Kho], [GiaNhap], [GiaBanLe], [Visible]) VALUES (N'TenSP001', N'MSP001', N'DMSP001', 32, 10000, 15000, 1)
INSERT [dbo].[QUANLYSANPHAM] ([TenSP], [MaSP], [DanhMucSP], [Kho], [GiaNhap], [GiaBanLe], [Visible]) VALUES (N'TenSP002', N'MSP002', N'DMSP002', 80, 15000, 20000, 1)
INSERT [dbo].[QUANLYSANPHAM] ([TenSP], [MaSP], [DanhMucSP], [Kho], [GiaNhap], [GiaBanLe], [Visible]) VALUES (N'TenSP003', N'MSP003', N'DMSP003', 190, 16000, 25000, 1)
INSERT [dbo].[QUANLYSANPHAM] ([TenSP], [MaSP], [DanhMucSP], [Kho], [GiaNhap], [GiaBanLe], [Visible]) VALUES (N'TenSP004', N'MSP004', N'DMSP004', 160, 20000, 25000, 1)
INSERT [dbo].[QUANLYSANPHAM] ([TenSP], [MaSP], [DanhMucSP], [Kho], [GiaNhap], [GiaBanLe], [Visible]) VALUES (N'TenSP005', N'MSP005', N'Not Categories', 150, 20000, 0, 1)
INSERT [dbo].[QUANLYSANPHAM] ([TenSP], [MaSP], [DanhMucSP], [Kho], [GiaNhap], [GiaBanLe], [Visible]) VALUES (N'TenSP006', N'MSP006', N'Not Categories', 1230, 12000, 0, 1)
GO
