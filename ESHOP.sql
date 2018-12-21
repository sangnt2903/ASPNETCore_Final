
/****** Object:  Database [ESHOP]    Script Date: 12/21/2018 9:27:44 AM ******/
CREATE DATABASE [ESHOP]

ALTER DATABASE [ESHOP] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ESHOP].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ESHOP] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ESHOP] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ESHOP] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ESHOP] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ESHOP] SET ARITHABORT OFF 
GO
ALTER DATABASE [ESHOP] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ESHOP] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ESHOP] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ESHOP] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ESHOP] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ESHOP] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ESHOP] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ESHOP] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ESHOP] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ESHOP] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ESHOP] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ESHOP] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ESHOP] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ESHOP] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ESHOP] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ESHOP] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ESHOP] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ESHOP] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ESHOP] SET  MULTI_USER 
GO
ALTER DATABASE [ESHOP] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ESHOP] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ESHOP] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ESHOP] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [ESHOP] SET DELAYED_DURABILITY = DISABLED 
GO
USE [ESHOP]
GO
/****** Object:  Table [dbo].[BannerQC]    Script Date: 12/21/2018 9:27:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BannerQC](
	[MaQC] [int] IDENTITY(1,1) NOT NULL,
	[NoiDungQC] [nvarchar](200) NULL,
	[NgayTao] [datetime] NULL,
	[Hinh] [varchar](50) NULL,
	[NgayBatDau] [datetime] NULL,
	[NgayKetThucQC] [datetime] NULL,
 CONSTRAINT [PK_BannerQC] PRIMARY KEY CLUSTERED 
(
	[MaQC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BinhLuanSP]    Script Date: 12/21/2018 9:27:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BinhLuanSP](
	[MaBL] [int] IDENTITY(1,1) NOT NULL,
	[NoiDung] [nvarchar](100) NULL,
	[NgayBL] [datetime] NULL,
	[MaKH] [int] NULL,
	[MaHh] [int] NULL,
 CONSTRAINT [PK_BinhLuanSP] PRIMARY KEY CLUSTERED 
(
	[MaBL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietHD]    Script Date: 12/21/2018 9:27:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietHD](
	[MaCT] [int] IDENTITY(1,1) NOT NULL,
	[MaHD] [int] NOT NULL,
	[MaHH] [int] NOT NULL,
	[DonGia] [float] NOT NULL,
	[GiamGia] [float] NULL,
	[SoLuong] [int] NOT NULL,
	[KichCo] [varchar](5) NULL,
 CONSTRAINT [PK_ChiTietHD] PRIMARY KEY CLUSTERED 
(
	[MaCT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChiTietPhieuNhap]    Script Date: 12/21/2018 9:27:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietPhieuNhap](
	[MaPN] [int] NOT NULL,
	[MaHH] [int] NOT NULL,
	[KichCo] [char](5) NOT NULL,
	[SoLuongNhap] [int] NULL CONSTRAINT [DF_ChiTietPhieuNhap_SoLuongNhap]  DEFAULT ((0)),
	[DonGiaNhap] [float] NULL,
 CONSTRAINT [PK_ChiTietPhieuNhap_1] PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC,
	[MaHH] ASC,
	[KichCo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HangHoa]    Script Date: 12/21/2018 9:27:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HangHoa](
	[MaHH] [int] IDENTITY(1,1) NOT NULL,
	[TenHH] [nvarchar](60) NOT NULL,
	[MaLoai] [varchar](8) NOT NULL,
	[Hinh] [nvarchar](50) NOT NULL,
	[DonGia] [float] NOT NULL,
	[GiamGia] [float] NOT NULL,
	[MoTa] [nvarchar](max) NULL,
	[MaNCC] [nvarchar](50) NOT NULL,
	[SanPhamKho] [int] NULL,
 CONSTRAINT [PK__HangHoa__2725A6E407332647] PRIMARY KEY CLUSTERED 
(
	[MaHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 12/21/2018 9:27:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [int] IDENTITY(1,1) NOT NULL,
	[MaKH] [int] NOT NULL,
	[NgayDat] [datetime] NOT NULL,
	[NgayGiao] [datetime] NULL,
	[HoTen] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](60) NOT NULL,
	[SDT_nguoinhan] [varchar](20) NULL,
	[GhiChu] [nvarchar](50) NULL,
	[PhiVanChuyen] [float] NOT NULL,
	[MaTrangThai] [int] NOT NULL,
	[MaNV] [nvarchar](50) NULL,
	[TongTienHang] [float] NULL,
	[MaVoucher] [varchar](10) NULL,
	[TongThucThu] [float] NULL,
 CONSTRAINT [PK__HoaDon__2725A6E0959C19DB] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HoiDap]    Script Date: 12/21/2018 9:27:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoiDap](
	[MaHD] [int] IDENTITY(1,1) NOT NULL,
	[MaKH] [int] NOT NULL,
	[MaNV] [int] NULL,
	[CauHoi] [nvarchar](50) NOT NULL,
	[TraLoi] [nvarchar](50) NULL,
	[NgayDua] [date] NOT NULL,
	[TrangThaiTL] [bit] NOT NULL CONSTRAINT [DF_HoiDap_TrangThaiTL]  DEFAULT ((0)),
 CONSTRAINT [PK__HoiDap__2725A6E0D415BDE9] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 12/21/2018 9:27:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [int] IDENTITY(1,1) NOT NULL,
	[MatKhau] [nvarchar](50) NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](60) NULL,
	[DienThoai] [nvarchar](24) NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Hinh] [nvarchar](50) NULL,
	[LoaiKH] [bit] NULL,
	[TaiKhoan] [varchar](30) NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[NgaySinh] [datetime] NULL,
	[TrangThaiHD] [bit] NULL,
 CONSTRAINT [PK__KhachHan__2725CF1EA73C617F] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Loai]    Script Date: 12/21/2018 9:27:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Loai](
	[MaLoai] [varchar](8) NOT NULL,
	[GioiTinh] [bit] NOT NULL,
	[TenLoai] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Loai] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoaiTinTuc]    Script Date: 12/21/2018 9:27:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LoaiTinTuc](
	[LoaiTT] [varchar](6) NOT NULL,
	[TenTT] [nvarchar](30) NULL,
 CONSTRAINT [PK_LoaiTinTuc] PRIMARY KEY CLUSTERED 
(
	[LoaiTT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 12/21/2018 9:27:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [nvarchar](50) NOT NULL,
	[TenCongTy] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[DienThoai] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[MoTa] [nvarchar](max) NULL,
	[Hinh] [nchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 12/21/2018 9:27:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](50) NULL,
	[MaPQ] [int] NOT NULL,
	[TrangThaiHD] [bit] NULL,
 CONSTRAINT [PK__NhanVien__2725D70A11D9BA6E] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhanQuyen]    Script Date: 12/21/2018 9:27:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanQuyen](
	[MaPQ] [int] IDENTITY(1,1) NOT NULL,
	[Them] [bit] NOT NULL,
	[Sua] [bit] NOT NULL,
	[Xoa] [bit] NOT NULL,
	[Xem] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPQ] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuNhapHang]    Script Date: 12/21/2018 9:27:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhapHang](
	[MaPN] [int] IDENTITY(1,1) NOT NULL,
	[NgayNhap] [datetime] NOT NULL,
	[TongTien] [float] NULL,
 CONSTRAINT [PK_PhieuNhapHang] PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SanPham_Kho]    Script Date: 12/21/2018 9:27:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SanPham_Kho](
	[MaSP_Kho] [int] IDENTITY(1,1) NOT NULL,
	[MaHh] [int] NOT NULL,
	[KichCo] [char](5) NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_SanPham_Kho] PRIMARY KEY CLUSTERED 
(
	[MaSP_Kho] ASC,
	[MaHh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TB_ThongKe]    Script Date: 12/21/2018 9:27:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_ThongKe](
	[MaTB] [int] IDENTITY(1,1) NOT NULL,
	[ThoiGian] [datetime] NOT NULL,
	[SoTruyCap] [bigint] NOT NULL,
 CONSTRAINT [PK_TB_ThongKe] PRIMARY KEY CLUSTERED 
(
	[MaTB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TinTuc]    Script Date: 12/21/2018 9:27:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TinTuc](
	[MaTT] [int] IDENTITY(1,1) NOT NULL,
	[TieuDe] [nvarchar](100) NULL,
	[NoiDung] [text] NULL,
	[Hinh] [varchar](50) NULL,
	[NgayTao] [datetime] NULL,
	[MaNV] [int] NULL,
	[LoaiTT] [varchar](6) NULL,
	[TrangThai] [bit] NULL,
 CONSTRAINT [PK_TinTuc] PRIMARY KEY CLUSTERED 
(
	[MaTT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TrangThai]    Script Date: 12/21/2018 9:27:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrangThai](
	[MaTrangThai] [int] NOT NULL,
	[TenTrangThai] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTrangThai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Voucher]    Script Date: 12/21/2018 9:27:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Voucher](
	[MaVC] [nvarchar](10) NOT NULL,
	[NoiDung] [nvarchar](max) NULL,
	[NgayTao] [datetime] NULL,
	[NgayBatDau] [datetime] NULL,
	[NgayHetHan] [datetime] NULL,
	[GiamGia] [float] NULL,
	[TongTienDK] [bigint] NULL,
	[TrangThai] [bit] NULL CONSTRAINT [DF_Voucher_TrangThai]  DEFAULT ((0)),
 CONSTRAINT [PK_Voucher] PRIMARY KEY CLUSTERED 
(
	[MaVC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[YeuThich]    Script Date: 12/21/2018 9:27:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[YeuThich](
	[MaYT] [int] IDENTITY(1,1) NOT NULL,
	[MaHH] [int] NULL,
	[MaKH] [int] NULL,
	[NgayChon] [datetime] NULL,
	[DiemDanhGia] [float] NOT NULL CONSTRAINT [DF_YeuThich_DiemDanhGia]  DEFAULT ((5)),
	[MaBL] [int] NULL,
 CONSTRAINT [PK_YeuThich] PRIMARY KEY CLUSTERED 
(
	[MaYT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[BannerQC] ON 

INSERT [dbo].[BannerQC] ([MaQC], [NoiDungQC], [NgayTao], [Hinh], [NgayBatDau], [NgayKetThucQC]) VALUES (1, N'Đại khuyến mãi Flash Sales', CAST(N'2018-12-19 00:00:00.000' AS DateTime), N'banner1.jpg', CAST(N'2018-12-19 00:00:00.000' AS DateTime), CAST(N'2018-12-20 12:00:00.000' AS DateTime))
INSERT [dbo].[BannerQC] ([MaQC], [NoiDungQC], [NgayTao], [Hinh], [NgayBatDau], [NgayKetThucQC]) VALUES (2, N'Sự kiện khuyến mãi giáng sinh', CAST(N'2018-12-19 00:00:00.000' AS DateTime), N'banner4.jpg', CAST(N'2018-12-19 12:17:00.000' AS DateTime), CAST(N'2018-12-24 23:59:59.000' AS DateTime))
INSERT [dbo].[BannerQC] ([MaQC], [NoiDungQC], [NgayTao], [Hinh], [NgayBatDau], [NgayKetThucQC]) VALUES (3, N'Tiệc ưu đãi tết Tây', CAST(N'2018-12-24 23:59:59.000' AS DateTime), N'banner3.jpg', CAST(N'2018-12-19 00:00:00.000' AS DateTime), CAST(N'2018-12-31 23:59:59.000' AS DateTime))
INSERT [dbo].[BannerQC] ([MaQC], [NoiDungQC], [NgayTao], [Hinh], [NgayBatDau], [NgayKetThucQC]) VALUES (4, N'ESHOP', CAST(N'1975-01-01 00:00:00.000' AS DateTime), N'banner2.jpg', CAST(N'1975-01-01 00:00:00.000' AS DateTime), CAST(N'9999-12-31 00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[BannerQC] OFF
SET IDENTITY_INSERT [dbo].[BinhLuanSP] ON 

INSERT [dbo].[BinhLuanSP] ([MaBL], [NoiDung], [NgayBL], [MaKH], [MaHh]) VALUES (13, N'Vải đẹp ok', CAST(N'2018-12-03 13:26:04.810' AS DateTime), 6, 7)
INSERT [dbo].[BinhLuanSP] ([MaBL], [NoiDung], [NgayBL], [MaKH], [MaHh]) VALUES (14, N'hàng bị rách nách', CAST(N'2018-12-03 13:27:05.703' AS DateTime), 6, 7)
INSERT [dbo].[BinhLuanSP] ([MaBL], [NoiDung], [NgayBL], [MaKH], [MaHh]) VALUES (15, N'tạm được', CAST(N'2018-12-03 13:54:30.360' AS DateTime), 5, 7)
SET IDENTITY_INSERT [dbo].[BinhLuanSP] OFF
SET IDENTITY_INSERT [dbo].[ChiTietHD] ON 

INSERT [dbo].[ChiTietHD] ([MaCT], [MaHD], [MaHH], [DonGia], [GiamGia], [SoLuong], [KichCo]) VALUES (1, 3, 20, 300000, 0.2, 2, N'M')
INSERT [dbo].[ChiTietHD] ([MaCT], [MaHD], [MaHH], [DonGia], [GiamGia], [SoLuong], [KichCo]) VALUES (2, 3, 20, 300000, 0.2, 1, N'S')
INSERT [dbo].[ChiTietHD] ([MaCT], [MaHD], [MaHH], [DonGia], [GiamGia], [SoLuong], [KichCo]) VALUES (3, 3, 24, 300000, 0.2, 2, N'M')
INSERT [dbo].[ChiTietHD] ([MaCT], [MaHD], [MaHH], [DonGia], [GiamGia], [SoLuong], [KichCo]) VALUES (4, 4, 7, 350000, 0.15, 3, N'M')
INSERT [dbo].[ChiTietHD] ([MaCT], [MaHD], [MaHH], [DonGia], [GiamGia], [SoLuong], [KichCo]) VALUES (5, 4, 20, 300000, 0.2, 2, N'M')
INSERT [dbo].[ChiTietHD] ([MaCT], [MaHD], [MaHH], [DonGia], [GiamGia], [SoLuong], [KichCo]) VALUES (6, 5, 26, 110000, 0.2, 2, N'M')
INSERT [dbo].[ChiTietHD] ([MaCT], [MaHD], [MaHH], [DonGia], [GiamGia], [SoLuong], [KichCo]) VALUES (7, 5, 25, 300000, 0.2, 1, N'S')
INSERT [dbo].[ChiTietHD] ([MaCT], [MaHD], [MaHH], [DonGia], [GiamGia], [SoLuong], [KichCo]) VALUES (8, 5, 20, 300000, 0.2, 2, N'L')
INSERT [dbo].[ChiTietHD] ([MaCT], [MaHD], [MaHH], [DonGia], [GiamGia], [SoLuong], [KichCo]) VALUES (9, 6, 19, 320000, 0.2, 2, N'M')
INSERT [dbo].[ChiTietHD] ([MaCT], [MaHD], [MaHH], [DonGia], [GiamGia], [SoLuong], [KichCo]) VALUES (10, 6, 21, 300000, 0.2, 3, N'M')
INSERT [dbo].[ChiTietHD] ([MaCT], [MaHD], [MaHH], [DonGia], [GiamGia], [SoLuong], [KichCo]) VALUES (11, 7, 7, 350000, 0.15, 2, N'M')
INSERT [dbo].[ChiTietHD] ([MaCT], [MaHD], [MaHH], [DonGia], [GiamGia], [SoLuong], [KichCo]) VALUES (12, 7, 22, 300000, 0.2, 2, N'M')
INSERT [dbo].[ChiTietHD] ([MaCT], [MaHD], [MaHH], [DonGia], [GiamGia], [SoLuong], [KichCo]) VALUES (13, 8, 19, 320000, 0.2, 1, N'M')
INSERT [dbo].[ChiTietHD] ([MaCT], [MaHD], [MaHH], [DonGia], [GiamGia], [SoLuong], [KichCo]) VALUES (14, 8, 20, 300000, 0.2, 1, N'M')
INSERT [dbo].[ChiTietHD] ([MaCT], [MaHD], [MaHH], [DonGia], [GiamGia], [SoLuong], [KichCo]) VALUES (17, 10, 21, 300000, 0.2, 2, N'S')
INSERT [dbo].[ChiTietHD] ([MaCT], [MaHD], [MaHH], [DonGia], [GiamGia], [SoLuong], [KichCo]) VALUES (18, 10, 22, 300000, 0.2, 1, N'M')
INSERT [dbo].[ChiTietHD] ([MaCT], [MaHD], [MaHH], [DonGia], [GiamGia], [SoLuong], [KichCo]) VALUES (19, 11, 20, 300000, 0.2, 2, N'S')
INSERT [dbo].[ChiTietHD] ([MaCT], [MaHD], [MaHH], [DonGia], [GiamGia], [SoLuong], [KichCo]) VALUES (20, 11, 20, 300000, 0.2, 1, N'M')
INSERT [dbo].[ChiTietHD] ([MaCT], [MaHD], [MaHH], [DonGia], [GiamGia], [SoLuong], [KichCo]) VALUES (29, 19, 7, 350000, 0.15, 3, N'S')
INSERT [dbo].[ChiTietHD] ([MaCT], [MaHD], [MaHH], [DonGia], [GiamGia], [SoLuong], [KichCo]) VALUES (30, 20, 20, 300000, 0.2, 2, N'S')
INSERT [dbo].[ChiTietHD] ([MaCT], [MaHD], [MaHH], [DonGia], [GiamGia], [SoLuong], [KichCo]) VALUES (31, 20, 19, 320000, 0.2, 3, N'M')
INSERT [dbo].[ChiTietHD] ([MaCT], [MaHD], [MaHH], [DonGia], [GiamGia], [SoLuong], [KichCo]) VALUES (32, 22, 7, 350000, 0.15, 1, N'S')
SET IDENTITY_INSERT [dbo].[ChiTietHD] OFF
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaHH], [KichCo], [SoLuongNhap], [DonGiaNhap]) VALUES (13, 20, N'L    ', 30, 300000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaHH], [KichCo], [SoLuongNhap], [DonGiaNhap]) VALUES (13, 20, N'M    ', 0, 300000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaHH], [KichCo], [SoLuongNhap], [DonGiaNhap]) VALUES (13, 20, N'S    ', 20, 300000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaHH], [KichCo], [SoLuongNhap], [DonGiaNhap]) VALUES (14, 7, N'L    ', 35, 350000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaHH], [KichCo], [SoLuongNhap], [DonGiaNhap]) VALUES (14, 7, N'M    ', 20, 350000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaHH], [KichCo], [SoLuongNhap], [DonGiaNhap]) VALUES (14, 7, N'S    ', 20, 350000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaHH], [KichCo], [SoLuongNhap], [DonGiaNhap]) VALUES (14, 18, N'L    ', 20, 300000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaHH], [KichCo], [SoLuongNhap], [DonGiaNhap]) VALUES (14, 18, N'M    ', 60, 300000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaHH], [KichCo], [SoLuongNhap], [DonGiaNhap]) VALUES (14, 18, N'S    ', 10, 300000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaHH], [KichCo], [SoLuongNhap], [DonGiaNhap]) VALUES (15, 7, N'L    ', 20, 350000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaHH], [KichCo], [SoLuongNhap], [DonGiaNhap]) VALUES (15, 7, N'M    ', 15, 350000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaHH], [KichCo], [SoLuongNhap], [DonGiaNhap]) VALUES (15, 7, N'S    ', 20, 350000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaHH], [KichCo], [SoLuongNhap], [DonGiaNhap]) VALUES (16, 20, N'L    ', 20, 300000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaHH], [KichCo], [SoLuongNhap], [DonGiaNhap]) VALUES (16, 20, N'M    ', 10, 300000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaHH], [KichCo], [SoLuongNhap], [DonGiaNhap]) VALUES (16, 20, N'S    ', 10, 300000)
SET IDENTITY_INSERT [dbo].[HangHoa] ON 

INSERT [dbo].[HangHoa] ([MaHH], [TenHH], [MaLoai], [Hinh], [DonGia], [GiamGia], [MoTa], [MaNCC], [SanPhamKho]) VALUES (7, N'ÁO SƠ MI NAM DÀI TAY TRẮNG SMT16', N'ESAO001', N'so_mi_nam_16.jpg', 350000, 0.15, N'Sơ mi tay dài trắng phong cách tinh sảo', N'ESHOP', NULL)
INSERT [dbo].[HangHoa] ([MaHH], [TenHH], [MaLoai], [Hinh], [DonGia], [GiamGia], [MoTa], [MaNCC], [SanPhamKho]) VALUES (11, N'ÁO SƠ MI NAM DÀI TAY TRẮNG SMT12', N'ESAO001', N'so_mi_nam_012.jpg', 280000, 0.12, N'Sơ mi body hoa văn họa tiết tinh sảo', N'ESHOP', NULL)
INSERT [dbo].[HangHoa] ([MaHH], [TenHH], [MaLoai], [Hinh], [DonGia], [GiamGia], [MoTa], [MaNCC], [SanPhamKho]) VALUES (17, N'ÁO SƠ MI NAM DÀI TAY TRẮNG SMT12', N'ESAO001', N'so_mi_nam_01.jpg', 280000, 0, N'Sơ mi tay dài nam trắng phong cách', N'ESHOP', NULL)
INSERT [dbo].[HangHoa] ([MaHH], [TenHH], [MaLoai], [Hinh], [DonGia], [GiamGia], [MoTa], [MaNCC], [SanPhamKho]) VALUES (18, N'ÁO SƠ MI NAM DÀI TAY TRẮNG SMT0001', N'ESAO001', N'so_mi_nam_0001.jpg', 300000, 0.2, N'Áo sơ mi cổ cao trắng sang trọng quý phái', N'ESHOP', NULL)
INSERT [dbo].[HangHoa] ([MaHH], [TenHH], [MaLoai], [Hinh], [DonGia], [GiamGia], [MoTa], [MaNCC], [SanPhamKho]) VALUES (19, N'ÁO SƠ MI NAM DÀI TAY SỌC ĐEN TRẮNG SMT0004', N'ESAO001', N'ao_so_mi_0004.jpg', 320000, 0.2, N'Áo sơ mi sọc đen trắng sang trọng quý phái', N'ESHOP', NULL)
INSERT [dbo].[HangHoa] ([MaHH], [TenHH], [MaLoai], [Hinh], [DonGia], [GiamGia], [MoTa], [MaNCC], [SanPhamKho]) VALUES (20, N'ÁO SƠ MI NAM DÀI TAY ĐỎ SỌC SMT0006', N'ESAO001', N'ao_so_mi_0006.jpg', 300000, 0.2, N'Áo sơ mi cổ cao đỏ sọc sang trọng quý phái', N'ESHOP', NULL)
INSERT [dbo].[HangHoa] ([MaHH], [TenHH], [MaLoai], [Hinh], [DonGia], [GiamGia], [MoTa], [MaNCC], [SanPhamKho]) VALUES (21, N'ÁO SƠ MI NAM DÀI TAY XÁM SỌC ĐEN SMT0018', N'ESAO001', N'ao_so_mi_0018.jpg', 300000, 0.2, N'Áo sơ mi cổ cao xám đen sọc sang trọng quý phái', N'ESHOP', NULL)
INSERT [dbo].[HangHoa] ([MaHH], [TenHH], [MaLoai], [Hinh], [DonGia], [GiamGia], [MoTa], [MaNCC], [SanPhamKho]) VALUES (22, N'ÁO SƠ MI NAM DÀI TAY XANH SỌC ĐEN SMT0026', N'ESAO001', N'ao_so_mi_0026.jpg', 300000, 0.2, N'Áo sơ mi cổ cao xanh sọc sang trọng quý phái', N'ESHOP', NULL)
INSERT [dbo].[HangHoa] ([MaHH], [TenHH], [MaLoai], [Hinh], [DonGia], [GiamGia], [MoTa], [MaNCC], [SanPhamKho]) VALUES (23, N'ÁO SƠ MI NAM NGẮN TAY SMT0001', N'ESAO007', N'ao_so_mi_0001.jpg', 300000, 0.2, N'Áo sơ mi cổ cao đỏ sọc sang trọng quý phái', N'ESHOP', NULL)
INSERT [dbo].[HangHoa] ([MaHH], [TenHH], [MaLoai], [Hinh], [DonGia], [GiamGia], [MoTa], [MaNCC], [SanPhamKho]) VALUES (24, N'ÁO SƠ MI NAM NGẮN TAY HỌA TIẾT SMT0065', N'ESAO007', N'ao_so_mi_tay_ngan_0065.jpg', 300000, 0.2, N'Áo sơ mi ngắn xanh sang trọng quý phái', N'ESHOP', NULL)
INSERT [dbo].[HangHoa] ([MaHH], [TenHH], [MaLoai], [Hinh], [DonGia], [GiamGia], [MoTa], [MaNCC], [SanPhamKho]) VALUES (25, N'ÁO SƠ MI NAM NGẮN TAY SMT0069', N'ESAO007', N'ao_so_mi_tay_ngan_0069.jpg', 300000, 0.2, N'Áo sơ mi ngắn xanh sang trọng quý phái', N'ESHOP', NULL)
INSERT [dbo].[HangHoa] ([MaHH], [TenHH], [MaLoai], [Hinh], [DonGia], [GiamGia], [MoTa], [MaNCC], [SanPhamKho]) VALUES (26, N'ÁO THUN NAM NGẮN TAY SMT0005', N'ESAO011', N'ao_thun_nam_5.jpg', 110000, 0.2, N'Áo thun ngắn sang trọng quý phái', N'ESHOP', NULL)
INSERT [dbo].[HangHoa] ([MaHH], [TenHH], [MaLoai], [Hinh], [DonGia], [GiamGia], [MoTa], [MaNCC], [SanPhamKho]) VALUES (27, N'ÁO THUN NAM NGẮN TAY SMT0001', N'ESAO011', N'ao_thun_nam_01.jpg', 110000, 0.2, N'Áo thun ngắn sang trọng quý phái', N'ESHOP', NULL)
INSERT [dbo].[HangHoa] ([MaHH], [TenHH], [MaLoai], [Hinh], [DonGia], [GiamGia], [MoTa], [MaNCC], [SanPhamKho]) VALUES (28, N'ÁO THUN NAM NGẮN TAY SMT0010', N'ESAO011', N'ao_thun_nam_1.jpg', 110000, 0.2, N'Áo thun ngắn sang trọng quý phái', N'ESHOP', NULL)
INSERT [dbo].[HangHoa] ([MaHH], [TenHH], [MaLoai], [Hinh], [DonGia], [GiamGia], [MoTa], [MaNCC], [SanPhamKho]) VALUES (29, N'ÁO THUN NAM NGẮN TAY SMT0041', N'ESAO011', N'ao_thun_nam_41.jpg', 110000, 0.2, N'Áo thun ngắn sang trọng quý phái', N'ESHOP', NULL)
INSERT [dbo].[HangHoa] ([MaHH], [TenHH], [MaLoai], [Hinh], [DonGia], [GiamGia], [MoTa], [MaNCC], [SanPhamKho]) VALUES (30, N'ÁO THUN NAM NGẮN TAY SMT0073', N'ESAO011', N'ao_thun_nam_73.jpg', 110000, 0.2, N'Áo thun ngắn sang trọng quý phái', N'ESHOP', NULL)
SET IDENTITY_INSERT [dbo].[HangHoa] OFF
SET IDENTITY_INSERT [dbo].[HoaDon] ON 

INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [NgayDat], [NgayGiao], [HoTen], [DiaChi], [SDT_nguoinhan], [GhiChu], [PhiVanChuyen], [MaTrangThai], [MaNV], [TongTienHang], [MaVoucher], [TongThucThu]) VALUES (3, 5, CAST(N'2018-11-30 17:53:28.673' AS DateTime), NULL, N'Nguyễn Thanh Sang', N'Chánh Mỹ, Bình Dương', N'0971890712', N'Giao hàng đến văn phòng khu phố', 35000, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [NgayDat], [NgayGiao], [HoTen], [DiaChi], [SDT_nguoinhan], [GhiChu], [PhiVanChuyen], [MaTrangThai], [MaNV], [TongTienHang], [MaVoucher], [TongThucThu]) VALUES (4, 4, CAST(N'2018-11-30 19:20:53.203' AS DateTime), NULL, N'Nguyễn Thành Long', N'Chánh Mỹ, Bình Dương', N'0971890712', N'Giao hàng đến văn phòng khu phố', 35000, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [NgayDat], [NgayGiao], [HoTen], [DiaChi], [SDT_nguoinhan], [GhiChu], [PhiVanChuyen], [MaTrangThai], [MaNV], [TongTienHang], [MaVoucher], [TongThucThu]) VALUES (5, 4, CAST(N'2018-12-01 21:08:24.610' AS DateTime), NULL, N'Nguyễn Thanh Sang', N'Chánh Mỹ, Bình Dương', N'0971890712', N'Giao hàng đến văn phòng khu phố', 35000, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [NgayDat], [NgayGiao], [HoTen], [DiaChi], [SDT_nguoinhan], [GhiChu], [PhiVanChuyen], [MaTrangThai], [MaNV], [TongTienHang], [MaVoucher], [TongThucThu]) VALUES (6, 4, CAST(N'2018-12-01 21:37:24.947' AS DateTime), NULL, N'Nguyễn Thành Long', N'Chánh Mỹ, Bình Dương', N'0971890712', N'Giao hàng đến văn phòng khu phố', 35000, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [NgayDat], [NgayGiao], [HoTen], [DiaChi], [SDT_nguoinhan], [GhiChu], [PhiVanChuyen], [MaTrangThai], [MaNV], [TongTienHang], [MaVoucher], [TongThucThu]) VALUES (7, 6, CAST(N'2018-12-01 21:40:56.943' AS DateTime), NULL, N'Nguyễn Thành Long', N'Chánh Mỹ, Bình Dương', N'0971890712', N'Giao hàng đến văn phòng khu phố', 35000, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [NgayDat], [NgayGiao], [HoTen], [DiaChi], [SDT_nguoinhan], [GhiChu], [PhiVanChuyen], [MaTrangThai], [MaNV], [TongTienHang], [MaVoucher], [TongThucThu]) VALUES (8, 4, CAST(N'2018-12-01 21:45:14.087' AS DateTime), NULL, N'Nguyễn Thanh Sang', N'Chánh Mỹ, Bình Dương', N'0971890712', N'Giao hàng đến văn phòng khu phố', 35000, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [NgayDat], [NgayGiao], [HoTen], [DiaChi], [SDT_nguoinhan], [GhiChu], [PhiVanChuyen], [MaTrangThai], [MaNV], [TongTienHang], [MaVoucher], [TongThucThu]) VALUES (10, 4, CAST(N'2018-12-01 22:07:14.300' AS DateTime), NULL, N'Nguyễn Thanh Sang', N'Chánh Mỹ, Bình Dương', N'0971890712', N'Giao hàng đến văn phòng khu phố', 35000, 0, NULL, NULL, NULL, NULL)
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [NgayDat], [NgayGiao], [HoTen], [DiaChi], [SDT_nguoinhan], [GhiChu], [PhiVanChuyen], [MaTrangThai], [MaNV], [TongTienHang], [MaVoucher], [TongThucThu]) VALUES (11, 4, CAST(N'2018-12-01 22:10:41.587' AS DateTime), NULL, N'Nguyễn Thành Long', N'Chánh Mỹ, Bình Dương', N'0971890712', N'Giao hàng đến văn phòng khu phố', 35000, 0, NULL, NULL, NULL, NULL)
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [NgayDat], [NgayGiao], [HoTen], [DiaChi], [SDT_nguoinhan], [GhiChu], [PhiVanChuyen], [MaTrangThai], [MaNV], [TongTienHang], [MaVoucher], [TongThucThu]) VALUES (19, 4, CAST(N'2018-12-04 11:34:00.213' AS DateTime), NULL, N'Nguyễn Thành Long', N'Chánh Mỹ, Bình Dương', N'0971890712', N'Giao hàng đến văn phòng khu phố', 35000, 0, NULL, NULL, NULL, NULL)
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [NgayDat], [NgayGiao], [HoTen], [DiaChi], [SDT_nguoinhan], [GhiChu], [PhiVanChuyen], [MaTrangThai], [MaNV], [TongTienHang], [MaVoucher], [TongThucThu]) VALUES (20, 4, CAST(N'2018-12-20 13:50:15.093' AS DateTime), NULL, N'Nguyễn Thanh Sang', N'Chánh Mỹ, Bình Dương', N'0971890712', N'Giao hàng đến văn phòng khu phố', 35000, 0, NULL, 1248000, N'12dasjAdsB', 1158200)
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [NgayDat], [NgayGiao], [HoTen], [DiaChi], [SDT_nguoinhan], [GhiChu], [PhiVanChuyen], [MaTrangThai], [MaNV], [TongTienHang], [MaVoucher], [TongThucThu]) VALUES (22, 11, CAST(N'2018-12-20 21:57:30.273' AS DateTime), NULL, N'Đỗ Phúc Hậu', N'280 ADV', N'0904877306', NULL, 35000, 0, NULL, 297500, NULL, 332500)
SET IDENTITY_INSERT [dbo].[HoaDon] OFF
SET IDENTITY_INSERT [dbo].[HoiDap] ON 

INSERT [dbo].[HoiDap] ([MaHD], [MaKH], [MaNV], [CauHoi], [TraLoi], [NgayDua], [TrangThaiTL]) VALUES (3, 6, NULL, N'Cửa hàng phục vụ tốt', N'Cảm ơn bạn đả ủng hộ shop', CAST(N'2018-12-06' AS Date), 1)
INSERT [dbo].[HoiDap] ([MaHD], [MaKH], [MaNV], [CauHoi], [TraLoi], [NgayDua], [TrangThaiTL]) VALUES (4, 6, NULL, N'Ok', N'Cảm ơn bạn', CAST(N'2018-12-06' AS Date), 1)
INSERT [dbo].[HoiDap] ([MaHD], [MaKH], [MaNV], [CauHoi], [TraLoi], [NgayDua], [TrangThaiTL]) VALUES (5, 6, NULL, N'Shop phục vụ tận tình', N'Cảm ơn bạn đã ủng hộ shop', CAST(N'2018-12-06' AS Date), 1)
INSERT [dbo].[HoiDap] ([MaHD], [MaKH], [MaNV], [CauHoi], [TraLoi], [NgayDua], [TrangThaiTL]) VALUES (6, 6, NULL, N'Nhân Viên lịch sự', NULL, CAST(N'2018-12-06' AS Date), 0)
INSERT [dbo].[HoiDap] ([MaHD], [MaKH], [MaNV], [CauHoi], [TraLoi], [NgayDua], [TrangThaiTL]) VALUES (7, 6, NULL, N'Dịch vụ khách hàng ưu đãi tốt', NULL, CAST(N'2018-12-06' AS Date), 0)
INSERT [dbo].[HoiDap] ([MaHD], [MaKH], [MaNV], [CauHoi], [TraLoi], [NgayDua], [TrangThaiTL]) VALUES (8, 4, NULL, N'Rất thích ESHOP .', N'Cảm ơn bạn đả ủng hộ ESHOP', CAST(N'2018-12-06' AS Date), 1)
INSERT [dbo].[HoiDap] ([MaHD], [MaKH], [MaNV], [CauHoi], [TraLoi], [NgayDua], [TrangThaiTL]) VALUES (9, 4, NULL, N'Shop làm ăn chán', N'ESHOP xl vì những bất biện', CAST(N'2018-12-06' AS Date), 1)
SET IDENTITY_INSERT [dbo].[HoiDap] OFF
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([MaKH], [MatKhau], [HoTen], [DiaChi], [DienThoai], [Email], [Hinh], [LoaiKH], [TaiKhoan], [GioiTinh], [NgaySinh], [TrangThaiHD]) VALUES (4, N'c4ca4238a0b923820dcc509a6f75849b', N'Nguyễn Thanh Sang', N'Bình Dương', N'0971890712', N'sanglun2254@gmail.com', N'34441.png', 1, N'sangnt2', N'Nam', NULL, 1)
INSERT [dbo].[KhachHang] ([MaKH], [MatKhau], [HoTen], [DiaChi], [DienThoai], [Email], [Hinh], [LoaiKH], [TaiKhoan], [GioiTinh], [NgaySinh], [TrangThaiHD]) VALUES (5, N'c4ca4238a0b923820dcc509a6f75849b', N'Minh Cao', N'TPHCM', N'0971890712', N'minhcd@gmail.com', N'backg.jpg', 1, N'minhcd', N'Nam', NULL, 1)
INSERT [dbo].[KhachHang] ([MaKH], [MatKhau], [HoTen], [DiaChi], [DienThoai], [Email], [Hinh], [LoaiKH], [TaiKhoan], [GioiTinh], [NgaySinh], [TrangThaiHD]) VALUES (6, N'c4ca4238a0b923820dcc509a6f75849b', N'Nguyễn Thanh Sang', N'Bình Dương', N'0971890712', N'sanglun2254_1@gmail.com', N'long.jpg', 1, N'sangnt', N'Nam', NULL, 1)
INSERT [dbo].[KhachHang] ([MaKH], [MatKhau], [HoTen], [DiaChi], [DienThoai], [Email], [Hinh], [LoaiKH], [TaiKhoan], [GioiTinh], [NgaySinh], [TrangThaiHD]) VALUES (10, N'', N'anonymouse', N'Không có', N'', N'pinkwater98@gmail.com', N'anonymouse.jpg', 0, N'shanm', N'Nam', NULL, 1)
INSERT [dbo].[KhachHang] ([MaKH], [MatKhau], [HoTen], [DiaChi], [DienThoai], [Email], [Hinh], [LoaiKH], [TaiKhoan], [GioiTinh], [NgaySinh], [TrangThaiHD]) VALUES (11, NULL, N'Đỗ Phúc Hậu', N'280 ADV', N'0904877306', N'wanriky2998@gmail.com', NULL, 0, N'haudp', N'Nam', NULL, 1)
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
INSERT [dbo].[Loai] ([MaLoai], [GioiTinh], [TenLoai]) VALUES (N'ESAO001', 0, N'ÁO SƠ MI TAY DÀI')
INSERT [dbo].[Loai] ([MaLoai], [GioiTinh], [TenLoai]) VALUES (N'ESAO006', 1, N'ÁO SƠ MI TAY DÀI')
INSERT [dbo].[Loai] ([MaLoai], [GioiTinh], [TenLoai]) VALUES (N'ESAO007', 0, N'ÁO SƠ MI NGẮN TAY')
INSERT [dbo].[Loai] ([MaLoai], [GioiTinh], [TenLoai]) VALUES (N'ESAO008', 1, N'ÁO SƠ MI NGẮN TAY')
INSERT [dbo].[Loai] ([MaLoai], [GioiTinh], [TenLoai]) VALUES (N'ESAO009', 0, N'ÁO THUN DÀI TAY')
INSERT [dbo].[Loai] ([MaLoai], [GioiTinh], [TenLoai]) VALUES (N'ESAO010', 1, N'ÁO THUN DÀI TAY')
INSERT [dbo].[Loai] ([MaLoai], [GioiTinh], [TenLoai]) VALUES (N'ESAO011', 0, N'ÁO THUN NGẮN TAY')
INSERT [dbo].[Loai] ([MaLoai], [GioiTinh], [TenLoai]) VALUES (N'ESAO012', 1, N'ÁO THUN NGẮN TAY')
INSERT [dbo].[Loai] ([MaLoai], [GioiTinh], [TenLoai]) VALUES (N'ESAO013', 0, N'ÁO THUN BA LỖ')
INSERT [dbo].[Loai] ([MaLoai], [GioiTinh], [TenLoai]) VALUES (N'ESAO014', 1, N'ÁO THUN BA LỖ')
INSERT [dbo].[LoaiTinTuc] ([LoaiTT], [TenTT]) VALUES (N'TT_KM', N'Khuyến mãi')
INSERT [dbo].[LoaiTinTuc] ([LoaiTT], [TenTT]) VALUES (N'TT_QC', N'Quảng cáo')
INSERT [dbo].[LoaiTinTuc] ([LoaiTT], [TenTT]) VALUES (N'TT_REV', N'Review sản phẩm')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenCongTy], [Email], [DienThoai], [DiaChi], [MoTa], [Hinh]) VALUES (N'ESHOP', N'ESHOP', N'eshop@gmail.com', N'1654651326', N'TPHCM', N'Công ty thương mại', N'kenta.jpg                                         ')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenCongTy], [Email], [DienThoai], [DiaChi], [MoTa], [Hinh]) VALUES (N'KENTA', N'KENTA', N'kenta@gmail.com', N'653256565', N'TPHCM', N'Cửa hàng thời trang', N'kenta.jpg                                         ')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenCongTy], [Email], [DienThoai], [DiaChi], [MoTa], [Hinh]) VALUES (N'SENDO', N'SENDO', N'sendo@gmail.com', N'2356562323', N'TPHCM', N'Công ty thương mại điện tử', N'sendo.jpg                                         ')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenCongTy], [Email], [DienThoai], [DiaChi], [MoTa], [Hinh]) VALUES (N'YAME', N'YAME', N'yame@gmail.com', N'32565365323', N'BÌNH DƯƠNG', N'Cửa hàng may mặc thời trang ', N'yame.jpg                                          ')
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [Email], [MatKhau], [MaPQ], [TrangThaiHD]) VALUES (1, N'Admin', N'nv1@gmail.com', N'c4ca4238a0b923820dcc509a6f75849b', 1, 1)
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
SET IDENTITY_INSERT [dbo].[PhanQuyen] ON 

INSERT [dbo].[PhanQuyen] ([MaPQ], [Them], [Sua], [Xoa], [Xem]) VALUES (1, 1, 1, 1, 1)
SET IDENTITY_INSERT [dbo].[PhanQuyen] OFF
SET IDENTITY_INSERT [dbo].[PhieuNhapHang] ON 

INSERT [dbo].[PhieuNhapHang] ([MaPN], [NgayNhap], [TongTien]) VALUES (13, CAST(N'2018-12-18 01:12:59.063' AS DateTime), 15000000)
INSERT [dbo].[PhieuNhapHang] ([MaPN], [NgayNhap], [TongTien]) VALUES (14, CAST(N'2018-12-18 01:16:40.443' AS DateTime), 53250000)
INSERT [dbo].[PhieuNhapHang] ([MaPN], [NgayNhap], [TongTien]) VALUES (15, CAST(N'2018-12-20 08:30:07.050' AS DateTime), 19250000)
INSERT [dbo].[PhieuNhapHang] ([MaPN], [NgayNhap], [TongTien]) VALUES (16, CAST(N'2018-12-20 08:32:45.633' AS DateTime), 12000000)
SET IDENTITY_INSERT [dbo].[PhieuNhapHang] OFF
SET IDENTITY_INSERT [dbo].[SanPham_Kho] ON 

INSERT [dbo].[SanPham_Kho] ([MaSP_Kho], [MaHh], [KichCo], [SoLuong]) VALUES (1, 7, N'S    ', 66)
INSERT [dbo].[SanPham_Kho] ([MaSP_Kho], [MaHh], [KichCo], [SoLuong]) VALUES (2, 7, N'M    ', 86)
INSERT [dbo].[SanPham_Kho] ([MaSP_Kho], [MaHh], [KichCo], [SoLuong]) VALUES (3, 7, N'L    ', 105)
INSERT [dbo].[SanPham_Kho] ([MaSP_Kho], [MaHh], [KichCo], [SoLuong]) VALUES (4, 11, N'S    ', 2)
INSERT [dbo].[SanPham_Kho] ([MaSP_Kho], [MaHh], [KichCo], [SoLuong]) VALUES (5, 11, N'M    ', 3)
INSERT [dbo].[SanPham_Kho] ([MaSP_Kho], [MaHh], [KichCo], [SoLuong]) VALUES (6, 11, N'L    ', 0)
INSERT [dbo].[SanPham_Kho] ([MaSP_Kho], [MaHh], [KichCo], [SoLuong]) VALUES (7, 17, N'S    ', 100)
INSERT [dbo].[SanPham_Kho] ([MaSP_Kho], [MaHh], [KichCo], [SoLuong]) VALUES (8, 17, N'M    ', 100)
INSERT [dbo].[SanPham_Kho] ([MaSP_Kho], [MaHh], [KichCo], [SoLuong]) VALUES (9, 17, N'L    ', 100)
INSERT [dbo].[SanPham_Kho] ([MaSP_Kho], [MaHh], [KichCo], [SoLuong]) VALUES (10, 18, N'S    ', 110)
INSERT [dbo].[SanPham_Kho] ([MaSP_Kho], [MaHh], [KichCo], [SoLuong]) VALUES (11, 18, N'M    ', 160)
INSERT [dbo].[SanPham_Kho] ([MaSP_Kho], [MaHh], [KichCo], [SoLuong]) VALUES (12, 18, N'L    ', 120)
INSERT [dbo].[SanPham_Kho] ([MaSP_Kho], [MaHh], [KichCo], [SoLuong]) VALUES (13, 19, N'S    ', 100)
INSERT [dbo].[SanPham_Kho] ([MaSP_Kho], [MaHh], [KichCo], [SoLuong]) VALUES (14, 19, N'M    ', 97)
INSERT [dbo].[SanPham_Kho] ([MaSP_Kho], [MaHh], [KichCo], [SoLuong]) VALUES (15, 19, N'L    ', 100)
INSERT [dbo].[SanPham_Kho] ([MaSP_Kho], [MaHh], [KichCo], [SoLuong]) VALUES (16, 20, N'S    ', 110)
INSERT [dbo].[SanPham_Kho] ([MaSP_Kho], [MaHh], [KichCo], [SoLuong]) VALUES (17, 20, N'M    ', 111)
INSERT [dbo].[SanPham_Kho] ([MaSP_Kho], [MaHh], [KichCo], [SoLuong]) VALUES (18, 20, N'L    ', 120)
INSERT [dbo].[SanPham_Kho] ([MaSP_Kho], [MaHh], [KichCo], [SoLuong]) VALUES (19, 21, N'S    ', 100)
INSERT [dbo].[SanPham_Kho] ([MaSP_Kho], [MaHh], [KichCo], [SoLuong]) VALUES (20, 21, N'M    ', 100)
INSERT [dbo].[SanPham_Kho] ([MaSP_Kho], [MaHh], [KichCo], [SoLuong]) VALUES (21, 21, N'L    ', 100)
INSERT [dbo].[SanPham_Kho] ([MaSP_Kho], [MaHh], [KichCo], [SoLuong]) VALUES (22, 22, N'S    ', 100)
INSERT [dbo].[SanPham_Kho] ([MaSP_Kho], [MaHh], [KichCo], [SoLuong]) VALUES (23, 22, N'M    ', 100)
INSERT [dbo].[SanPham_Kho] ([MaSP_Kho], [MaHh], [KichCo], [SoLuong]) VALUES (24, 22, N'L    ', 100)
INSERT [dbo].[SanPham_Kho] ([MaSP_Kho], [MaHh], [KichCo], [SoLuong]) VALUES (25, 23, N'S    ', 100)
INSERT [dbo].[SanPham_Kho] ([MaSP_Kho], [MaHh], [KichCo], [SoLuong]) VALUES (26, 23, N'M    ', 100)
INSERT [dbo].[SanPham_Kho] ([MaSP_Kho], [MaHh], [KichCo], [SoLuong]) VALUES (27, 23, N'L    ', 100)
INSERT [dbo].[SanPham_Kho] ([MaSP_Kho], [MaHh], [KichCo], [SoLuong]) VALUES (28, 24, N'S    ', 100)
INSERT [dbo].[SanPham_Kho] ([MaSP_Kho], [MaHh], [KichCo], [SoLuong]) VALUES (29, 24, N'M    ', 100)
INSERT [dbo].[SanPham_Kho] ([MaSP_Kho], [MaHh], [KichCo], [SoLuong]) VALUES (30, 24, N'L    ', 100)
INSERT [dbo].[SanPham_Kho] ([MaSP_Kho], [MaHh], [KichCo], [SoLuong]) VALUES (31, 25, N'S    ', 100)
INSERT [dbo].[SanPham_Kho] ([MaSP_Kho], [MaHh], [KichCo], [SoLuong]) VALUES (32, 25, N'M    ', 100)
INSERT [dbo].[SanPham_Kho] ([MaSP_Kho], [MaHh], [KichCo], [SoLuong]) VALUES (33, 25, N'L    ', 100)
INSERT [dbo].[SanPham_Kho] ([MaSP_Kho], [MaHh], [KichCo], [SoLuong]) VALUES (34, 26, N'S    ', 100)
INSERT [dbo].[SanPham_Kho] ([MaSP_Kho], [MaHh], [KichCo], [SoLuong]) VALUES (35, 26, N'M    ', 100)
INSERT [dbo].[SanPham_Kho] ([MaSP_Kho], [MaHh], [KichCo], [SoLuong]) VALUES (36, 26, N'L    ', 100)
INSERT [dbo].[SanPham_Kho] ([MaSP_Kho], [MaHh], [KichCo], [SoLuong]) VALUES (37, 27, N'S    ', 100)
INSERT [dbo].[SanPham_Kho] ([MaSP_Kho], [MaHh], [KichCo], [SoLuong]) VALUES (38, 27, N'M    ', 100)
INSERT [dbo].[SanPham_Kho] ([MaSP_Kho], [MaHh], [KichCo], [SoLuong]) VALUES (39, 27, N'L    ', 100)
INSERT [dbo].[SanPham_Kho] ([MaSP_Kho], [MaHh], [KichCo], [SoLuong]) VALUES (40, 28, N'S    ', 100)
INSERT [dbo].[SanPham_Kho] ([MaSP_Kho], [MaHh], [KichCo], [SoLuong]) VALUES (41, 28, N'M    ', 100)
INSERT [dbo].[SanPham_Kho] ([MaSP_Kho], [MaHh], [KichCo], [SoLuong]) VALUES (42, 28, N'L    ', 100)
INSERT [dbo].[SanPham_Kho] ([MaSP_Kho], [MaHh], [KichCo], [SoLuong]) VALUES (43, 29, N'S    ', 100)
INSERT [dbo].[SanPham_Kho] ([MaSP_Kho], [MaHh], [KichCo], [SoLuong]) VALUES (44, 29, N'M    ', 100)
INSERT [dbo].[SanPham_Kho] ([MaSP_Kho], [MaHh], [KichCo], [SoLuong]) VALUES (45, 29, N'L    ', 100)
INSERT [dbo].[SanPham_Kho] ([MaSP_Kho], [MaHh], [KichCo], [SoLuong]) VALUES (46, 30, N'S    ', 100)
INSERT [dbo].[SanPham_Kho] ([MaSP_Kho], [MaHh], [KichCo], [SoLuong]) VALUES (47, 30, N'M    ', 100)
INSERT [dbo].[SanPham_Kho] ([MaSP_Kho], [MaHh], [KichCo], [SoLuong]) VALUES (48, 30, N'L    ', 100)
SET IDENTITY_INSERT [dbo].[SanPham_Kho] OFF
INSERT [dbo].[TrangThai] ([MaTrangThai], [TenTrangThai]) VALUES (0, N'Chờ xử lý')
INSERT [dbo].[TrangThai] ([MaTrangThai], [TenTrangThai]) VALUES (1, N'Đã xử lý')
INSERT [dbo].[Voucher] ([MaVC], [NoiDung], [NgayTao], [NgayBatDau], [NgayHetHan], [GiamGia], [TongTienDK], [TrangThai]) VALUES (N'12dasjAdsB', N'Giảm giá Noel', CAST(N'2018-12-19 00:00:00.000' AS DateTime), CAST(N'2018-12-20 00:00:00.000' AS DateTime), CAST(N'2018-12-24 00:00:00.000' AS DateTime), 0.1, 500000, 1)
INSERT [dbo].[Voucher] ([MaVC], [NoiDung], [NgayTao], [NgayBatDau], [NgayHetHan], [GiamGia], [TongTienDK], [TrangThai]) VALUES (N'g4oesHY8JY', N'Hè sôi động', CAST(N'2018-12-20 07:56:07.983' AS DateTime), CAST(N'2019-03-15 01:00:00.000' AS DateTime), CAST(N'2019-03-20 23:59:00.000' AS DateTime), 0.1, 250000, 1)
INSERT [dbo].[Voucher] ([MaVC], [NoiDung], [NgayTao], [NgayBatDau], [NgayHetHan], [GiamGia], [TongTienDK], [TrangThai]) VALUES (N'WYyGAhzxBI', N'Tết nguyên đán', CAST(N'2018-12-20 07:30:56.913' AS DateTime), CAST(N'2019-01-15 00:00:00.000' AS DateTime), CAST(N'2019-02-05 00:00:00.000' AS DateTime), 0.15, 1000000, 0)
SET IDENTITY_INSERT [dbo].[YeuThich] ON 

INSERT [dbo].[YeuThich] ([MaYT], [MaHH], [MaKH], [NgayChon], [DiemDanhGia], [MaBL]) VALUES (6, 7, 6, CAST(N'2018-12-03 13:26:05.043' AS DateTime), 5, 13)
INSERT [dbo].[YeuThich] ([MaYT], [MaHH], [MaKH], [NgayChon], [DiemDanhGia], [MaBL]) VALUES (7, 7, 6, CAST(N'2018-12-03 13:27:05.713' AS DateTime), 3, 14)
INSERT [dbo].[YeuThich] ([MaYT], [MaHH], [MaKH], [NgayChon], [DiemDanhGia], [MaBL]) VALUES (8, 7, 5, CAST(N'2018-12-03 13:54:30.573' AS DateTime), 3, 15)
SET IDENTITY_INSERT [dbo].[YeuThich] OFF
ALTER TABLE [dbo].[BinhLuanSP]  WITH CHECK ADD  CONSTRAINT [FK_BinhLuanSP_HangHoa] FOREIGN KEY([MaHh])
REFERENCES [dbo].[HangHoa] ([MaHH]) ON UPDATE CASCADE ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BinhLuanSP] CHECK CONSTRAINT [FK_BinhLuanSP_HangHoa]
GO
ALTER TABLE [dbo].[BinhLuanSP]  WITH CHECK ADD  CONSTRAINT [FK_BinhLuanSP_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH]) ON UPDATE CASCADE ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BinhLuanSP] CHECK CONSTRAINT [FK_BinhLuanSP_KhachHang]
GO
ALTER TABLE [dbo].[ChiTietHD]  WITH CHECK ADD  CONSTRAINT [FK__ChiTietHD__MaHD__25869641] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD]) ON UPDATE CASCADE ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietHD] CHECK CONSTRAINT [FK__ChiTietHD__MaHD__25869641]
GO
ALTER TABLE [dbo].[ChiTietHD]  WITH CHECK ADD  CONSTRAINT [FK__ChiTietHD__MaHH__267ABA7A] FOREIGN KEY([MaHH])
REFERENCES [dbo].[HangHoa] ([MaHH]) ON UPDATE CASCADE ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietHD] CHECK CONSTRAINT [FK__ChiTietHD__MaHH__267ABA7A]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_HangHoa] FOREIGN KEY([MaHH])
REFERENCES [dbo].[HangHoa] ([MaHH]) ON UPDATE CASCADE ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_HangHoa]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_PhieuNhapHang] FOREIGN KEY([MaPN])
REFERENCES [dbo].[PhieuNhapHang] ([MaPN]) ON UPDATE CASCADE ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_PhieuNhapHang]
GO
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD  CONSTRAINT [FK__HangHoa__MaNCC__15502E78] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC]) ON UPDATE CASCADE ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HangHoa] CHECK CONSTRAINT [FK__HangHoa__MaNCC__15502E78]
GO
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD  CONSTRAINT [FK_HangHoa_Loai] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[Loai] ([MaLoai]) ON UPDATE CASCADE ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HangHoa] ALTER COLUMN TenHH nvarchar(100)COLLATE SQL_Latin1_General_CP1_CI_AI NOT NULL
GO
ALTER TABLE [dbo].[HangHoa] CHECK CONSTRAINT [FK_HangHoa_Loai]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK__HoaDon__MaTrangT__1ED998B2] FOREIGN KEY([MaTrangThai])
REFERENCES [dbo].[TrangThai] ([MaTrangThai]) ON UPDATE CASCADE ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK__HoaDon__MaTrangT__1ED998B2]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH]) ON UPDATE CASCADE ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
ALTER TABLE [dbo].[HoiDap]  WITH CHECK ADD  CONSTRAINT [FK_HoiDap_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH]) ON UPDATE CASCADE ON DELETE CASCADE
GO
ALTER TABLE [dbo].[KhachHang] ALTER COLUMN HoTen nvarchar(100)COLLATE SQL_Latin1_General_CP1_CI_AI NOT NULL
GO
ALTER TABLE [dbo].[HoiDap] CHECK CONSTRAINT [FK_HoiDap_KhachHang]
GO
ALTER TABLE [dbo].[HoiDap]  WITH CHECK ADD  CONSTRAINT [FK_HoiDap_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV]) ON UPDATE CASCADE ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HoiDap] CHECK CONSTRAINT [FK_HoiDap_NhanVien]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK__NhanVien__MaPQ__1BFD2C07] FOREIGN KEY([MaPQ])
REFERENCES [dbo].[PhanQuyen] ([MaPQ]) ON UPDATE CASCADE ON DELETE CASCADE
GO

ALTER TABLE [dbo].[NhanVien] ALTER COLUMN HoTen nvarchar(100)COLLATE SQL_Latin1_General_CP1_CI_AI NOT NULL
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK__NhanVien__MaPQ__1BFD2C07]
GO
ALTER TABLE [dbo].[SanPham_Kho]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_Kho_HangHoa] FOREIGN KEY([MaHh])
REFERENCES [dbo].[HangHoa] ([MaHH]) ON UPDATE CASCADE ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SanPham_Kho] CHECK CONSTRAINT [FK_SanPham_Kho_HangHoa]
GO
ALTER TABLE [dbo].[TinTuc]  WITH CHECK ADD  CONSTRAINT [FK_TinTuc_LoaiTinTuc] FOREIGN KEY([LoaiTT])
REFERENCES [dbo].[LoaiTinTuc] ([LoaiTT]) ON UPDATE CASCADE ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TinTuc] CHECK CONSTRAINT [FK_TinTuc_LoaiTinTuc]
GO
ALTER TABLE [dbo].[TinTuc] ALTER COLUMN TieuDe nvarchar(100)COLLATE SQL_Latin1_General_CP1_CI_AI NOT NULL
GO
ALTER TABLE [dbo].[TinTuc]  WITH CHECK ADD  CONSTRAINT [FK_TinTuc_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV]) ON UPDATE CASCADE ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TinTuc] CHECK CONSTRAINT [FK_TinTuc_NhanVien]
GO
ALTER TABLE [dbo].[YeuThich]  WITH CHECK ADD  CONSTRAINT [FK_YeuThich_HangHoa] FOREIGN KEY([MaHH])
REFERENCES [dbo].[HangHoa] ([MaHH]) ON UPDATE CASCADE ON DELETE CASCADE
GO
ALTER TABLE [dbo].[YeuThich] CHECK CONSTRAINT [FK_YeuThich_HangHoa]
GO
ALTER TABLE [dbo].[YeuThich]  WITH CHECK ADD  CONSTRAINT [FK_YeuThich_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH]) ON UPDATE CASCADE ON DELETE CASCADE
GO
ALTER TABLE [dbo].[YeuThich] CHECK CONSTRAINT [FK_YeuThich_KhachHang]
GO
USE [master]
GO
ALTER DATABASE [ESHOP] SET  READ_WRITE 
GO
