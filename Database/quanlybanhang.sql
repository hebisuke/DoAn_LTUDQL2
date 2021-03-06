USE [master]
GO
/****** Object:  Database [QLBanHang]    Script Date: 15/6/2017 16:45:35 PM ******/
CREATE DATABASE [QLBanHang]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLBanHang', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QLBanHang.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLBanHang_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QLBanHang_log.ldf' , SIZE = 816KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLBanHang] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLBanHang].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLBanHang] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLBanHang] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLBanHang] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLBanHang] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLBanHang] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLBanHang] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLBanHang] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLBanHang] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLBanHang] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLBanHang] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLBanHang] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLBanHang] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLBanHang] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLBanHang] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLBanHang] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLBanHang] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLBanHang] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLBanHang] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLBanHang] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLBanHang] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLBanHang] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLBanHang] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLBanHang] SET RECOVERY FULL 
GO
ALTER DATABASE [QLBanHang] SET  MULTI_USER 
GO
ALTER DATABASE [QLBanHang] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLBanHang] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLBanHang] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLBanHang] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QLBanHang] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QLBanHang]
GO
/****** Object:  Table [dbo].[BanHang]    Script Date: 15/6/2017 16:45:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BanHang](
	[MaPhieuBanHang] [int] IDENTITY(1,1) NOT NULL,
	[MaKhachHang] [nchar](10) NULL,
	[NgayBan] [datetime] NULL,
	[NoCu] [nchar](15) NULL,
	[NoMoi] [nchar](15) NULL,
	[DieuKhoanThanhToan] [nvarchar](50) NULL,
	[HanThanhToan] [datetime] NULL,
	[MaNVBan] [nchar](10) NULL,
	[TongTien] [nchar](15) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SoDienThoai] [nchar](12) NULL,
	[SoHoaDonVAT] [nvarchar](50) NULL,
	[SoPhieuVietTay] [nvarchar](50) NULL,
	[HinhThucThanhToan] [nvarchar](50) NULL,
	[MaKhoXuat] [nchar](10) NULL,
 CONSTRAINT [PK_BanHang] PRIMARY KEY CLUSTERED 
(
	[MaPhieuBanHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BoPhan]    Script Date: 15/6/2017 16:45:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BoPhan](
	[MaBo] [nchar](10) NOT NULL,
	[TenBo] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
	[TinhTrangQL] [bit] NULL,
 CONSTRAINT [PK_BoPhan] PRIMARY KEY CLUSTERED 
(
	[MaBo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHiTietBanHang]    Script Date: 15/6/2017 16:45:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHiTietBanHang](
	[MaPhieuCT] [int] IDENTITY(1,1) NOT NULL,
	[MaBanHang] [int] NULL,
	[MaHang] [nchar](10) NULL,
	[Gia] [int] NULL,
	[Soluong] [int] NULL,
	[ThanhToan] [int] NULL,
 CONSTRAINT [PK_CHiTietBanHang] PRIMARY KEY CLUSTERED 
(
	[MaPhieuCT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietMuaHang]    Script Date: 15/6/2017 16:45:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietMuaHang](
	[MaPhieuCT] [int] IDENTITY(1,1) NOT NULL,
	[MaMuaHang] [int] NULL,
	[MaHang] [nchar](10) NULL,
	[Gia] [int] NULL,
	[SoLuong] [int] NULL,
	[ThanhToan] [int] NULL,
 CONSTRAINT [PK_ChiTietMuaHang] PRIMARY KEY CLUSTERED 
(
	[MaPhieuCT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DonViTinh]    Script Date: 15/6/2017 16:45:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonViTinh](
	[MaDV] [nchar](10) NOT NULL,
	[TenDV] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
	[TinhTrangQL] [int] NULL,
 CONSTRAINT [PK_DonViTinh] PRIMARY KEY CLUSTERED 
(
	[MaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HangHoa]    Script Date: 15/6/2017 16:45:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangHoa](
	[MaHang] [nchar](10) NOT NULL,
	[TenHang] [nvarchar](350) NULL,
	[MaDVT] [nchar](10) NULL,
	[XuatXu] [nvarchar](50) NULL,
	[Thue] [int] NULL,
	[ChietKhau] [int] NULL,
	[TonKhoToiThieu] [int] NULL,
	[TonKhoHienTai] [int] NULL,
	[MaNCC] [nchar](10) NULL,
	[GiaMua] [int] NULL,
	[GiaBanSi] [int] NULL,
	[GiaBanLe] [int] NULL,
	[MaKhoHang] [nchar](10) NULL,
	[MaNhomHang] [nchar](10) NULL,
	[MaSKU] [nchar](13) NULL,
 CONSTRAINT [PK_HangHoa] PRIMARY KEY CLUSTERED 
(
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 15/6/2017 16:45:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [nchar](10) NOT NULL,
	[TenKH] [nvarchar](64) NOT NULL,
	[LoaiKH] [int] NULL,
	[MaKhuVuc] [nchar](10) NOT NULL,
	[DiaChi] [nvarchar](450) NULL,
	[MST] [nchar](10) NULL,
	[DTBan] [nchar](20) NULL,
	[DTDD] [nchar](20) NULL,
	[Fax] [nchar](20) NULL,
	[Email] [nchar](50) NULL,
	[Website] [nchar](100) NULL,
	[STK] [nchar](25) NULL,
	[NganHang] [nvarchar](50) NULL,
	[GioiHanNo] [nchar](15) NULL,
	[NoHienTai] [nchar](15) NULL,
	[ChietKhau] [int] NULL,
	[NguoiLienHe] [nvarchar](64) NULL,
	[NickYM] [nchar](50) NULL,
	[NickSkype] [nchar](50) NULL,
	[TinhTrangQuanLy] [int] NULL,
	[GhiChu] [nvarchar](150) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhoHang]    Script Date: 15/6/2017 16:45:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhoHang](
	[MaKho] [nchar](10) NOT NULL,
	[TenKho] [nvarchar](64) NOT NULL,
	[NguoiLienHe] [nvarchar](64) NULL,
	[DiaChi] [nvarchar](350) NULL,
	[DTBan] [nchar](10) NULL,
	[DTDD] [nchar](11) NULL,
	[Fax] [nchar](10) NULL,
	[Email] [nchar](50) NULL,
	[NguoiQuanLy] [nvarchar](64) NULL,
	[DienGiai] [nvarchar](100) NULL,
	[TinhTrangQuanLy] [int] NULL,
 CONSTRAINT [PK_KhoHang] PRIMARY KEY CLUSTERED 
(
	[MaKho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhuVuc]    Script Date: 15/6/2017 16:45:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhuVuc](
	[MaKV] [nchar](10) NOT NULL,
	[TenKV] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_KhuVuc] PRIMARY KEY CLUSTERED 
(
	[MaKV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiKH]    Script Date: 15/6/2017 16:45:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiKH](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiKH] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiKH] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiTien]    Script Date: 15/6/2017 16:45:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiTien](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiTien] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiTien] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Mua_BanTam]    Script Date: 15/6/2017 16:45:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mua_BanTam](
	[MaPhieuCT] [int] IDENTITY(1,1) NOT NULL,
	[MaHang] [nchar](10) NULL,
	[SoLuong] [int] NULL,
	[Gia] [int] NULL,
	[ThanhTien] [int] NULL,
 CONSTRAINT [PK_Mua_BanTam] PRIMARY KEY CLUSTERED 
(
	[MaPhieuCT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MuaHang]    Script Date: 15/6/2017 16:45:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MuaHang](
	[MaPhieuMuaHang] [int] IDENTITY(1,1) NOT NULL,
	[MaNPP] [nchar](10) NULL,
	[NgayLap] [datetime] NULL,
	[MaLoaiTien] [int] NULL,
	[DieuKhoanThanhToan] [nvarchar](50) NULL,
	[HanThanhToan] [datetime] NULL,
	[TongTien] [nchar](15) NULL,
	[MaNV] [nchar](10) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SoDienThoai] [varchar](12) NULL,
	[SoHoaDonVAT] [varchar](50) NULL,
	[SoPhieuVietTay] [varchar](50) NULL,
	[MaNhapKho] [nchar](10) NULL,
	[HinhThucThanhToan] [nvarchar](50) NULL,
 CONSTRAINT [PK_MuaHang] PRIMARY KEY CLUSTERED 
(
	[MaPhieuMuaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 15/6/2017 16:45:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [nchar](10) NOT NULL,
	[TenNV] [nvarchar](350) NULL,
	[DocThan] [int] NULL,
	[ChucVu] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](350) NULL,
	[Email] [nvarchar](50) NULL,
	[DienThoai] [nchar](11) NULL,
	[DiDong] [nchar](11) NULL,
	[DienGiai] [nvarchar](50) NULL,
	[MaBP] [nchar](10) NULL,
	[MaNVQL] [nchar](10) NULL,
	[TinhTrangQL] [bit] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhaPhanPhoi]    Script Date: 15/6/2017 16:45:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaPhanPhoi](
	[MaNPP] [nchar](10) NOT NULL,
	[TenNPP] [nvarchar](64) NOT NULL,
	[MaKhuVuc] [nchar](10) NOT NULL,
	[DiaChi] [nvarchar](450) NULL,
	[MST] [nchar](10) NULL,
	[DTBan] [nchar](10) NULL,
	[DTDD] [nchar](11) NULL,
	[Fax] [nchar](10) NULL,
	[Email] [nchar](50) NULL,
	[Website] [nchar](50) NULL,
	[STK] [nchar](15) NULL,
	[NganHang] [nvarchar](50) NULL,
	[GioiHanNo] [nchar](15) NULL,
	[NoHienTai] [nchar](15) NULL,
	[ChietKhau] [int] NULL,
	[NguoiLienHe] [nvarchar](64) NULL,
	[ChucVu] [nvarchar](50) NULL,
	[TinhTrangQuanLy] [int] NULL,
	[GhiChu] [nvarchar](150) NULL,
 CONSTRAINT [PK_NhaPhanPhoi] PRIMARY KEY CLUSTERED 
(
	[MaNPP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhatKiHeThong]    Script Date: 15/6/2017 16:45:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhatKiHeThong](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaNV] [nchar](10) NULL,
	[MayTinh] [nchar](15) NULL,
	[ThoiGian] [datetime] NULL,
	[TenChucNang] [nvarchar](50) NULL,
	[HanhDong] [nvarchar](150) NULL,
 CONSTRAINT [PK_NhatKiHeThong] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhomHangHoa]    Script Date: 15/6/2017 16:45:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhomHangHoa](
	[MaNhom] [nchar](10) NOT NULL,
	[TenNhom] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
	[TinhTrangQL] [int] NULL,
 CONSTRAINT [PK_NhomHangHoa] PRIMARY KEY CLUSTERED 
(
	[MaNhom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TaiKhoanNguoiDung]    Script Date: 15/6/2017 16:45:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TaiKhoanNguoiDung](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaNV] [nchar](10) NULL,
	[TenTaiKhoan] [varchar](32) NULL,
	[MatKhau] [varchar](32) NULL,
	[MaVaiTro] [int] NULL,
	[DienGiai] [nvarchar](50) NULL,
	[TinhTrangQL] [int] NULL,
 CONSTRAINT [PK_TaiKhoanNguoiDung] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ThongTinToChucCaNhan]    Script Date: 15/6/2017 16:45:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongTinToChucCaNhan](
	[TenDonVi] [nvarchar](50) NULL,
	[DiaCHi] [nvarchar](350) NULL,
	[DTBan] [nchar](10) NULL,
	[DTDD] [nchar](11) NULL,
	[Fax] [nchar](10) NULL,
	[Website] [nchar](50) NULL,
	[Email] [nchar](50) NULL,
	[LinhVuc] [nvarchar](50) NULL,
	[MST] [nchar](15) NULL,
	[GPKD] [nchar](15) NULL,
	[Ma] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_ThongTinToChucCaNhan] PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThuTien]    Script Date: 15/6/2017 16:45:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThuTien](
	[MaPhieuThu] [nchar](10) NOT NULL,
	[NgayLap] [datetime] NULL,
	[DuNo] [nchar](15) NULL,
	[MaKH] [nchar](10) NULL,
	[SoTienTra] [nchar](15) NULL,
	[MaBanHang] [int] NULL,
	[idLoaiTien] [int] NULL,
 CONSTRAINT [PK_ThuTien] PRIMARY KEY CLUSTERED 
(
	[MaPhieuThu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[V_HangHoa]    Script Date: 15/6/2017 16:45:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_HangHoa]
AS
SELECT        dbo.HangHoa.MaHang, dbo.HangHoa.TenHang, dbo.DonViTinh.TenDV
FROM            dbo.HangHoa INNER JOIN
                         dbo.DonViTinh ON dbo.HangHoa.MaDVT = dbo.DonViTinh.MaDV

GO
/****** Object:  View [dbo].[V_KhoHang]    Script Date: 15/6/2017 16:45:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_KhoHang]
AS
SELECT        MaKho, TenKho
FROM            dbo.KhoHang

GO
/****** Object:  View [dbo].[V_NhanVien]    Script Date: 15/6/2017 16:45:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_NhanVien]
AS
SELECT        MaNV, TenNV
FROM            dbo.NhanVien

GO
/****** Object:  View [dbo].[V_NhaPhanPhoi]    Script Date: 15/6/2017 16:45:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_NhaPhanPhoi]
AS
SELECT        MaNPP, TenNPP
FROM            dbo.NhaPhanPhoi

GO
/****** Object:  View [dbo].[V_ThongTinLogin]    Script Date: 15/6/2017 16:45:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_ThongTinLogin]
AS
SELECT       dbo.TaiKhoanNguoiDung.TenTaiKhoan, dbo.TaiKhoanNguoiDung.MatKhau, dbo.NhanVien.TenNV, dbo.NhanVien.ChucVu, dbo.NhanVien.MaNV, dbo.TaiKhoanNguoiDung.id, dbo.NhanVien.MaBP
FROM            dbo.NhanVien INNER JOIN
                         dbo.TaiKhoanNguoiDung ON dbo.NhanVien.MaNV = dbo.TaiKhoanNguoiDung.MaNV


GO
SET IDENTITY_INSERT [dbo].[BanHang] ON 

INSERT [dbo].[BanHang] ([MaPhieuBanHang], [MaKhachHang], [NgayBan], [NoCu], [NoMoi], [DieuKhoanThanhToan], [HanThanhToan], [MaNVBan], [TongTien], [DiaChi], [SoDienThoai], [SoHoaDonVAT], [SoPhieuVietTay], [HinhThucThanhToan], [MaKhoXuat]) VALUES (1, N'KH0003    ', CAST(N'2017-06-15 00:37:14.390' AS DateTime), NULL, NULL, N'Thanh Toán Ngay', CAST(N'2017-06-24 00:00:00.000' AS DateTime), N'NV01      ', N'431235         ', N'12312', N'12312       ', N'213123', N'213123', N'Chuyển Khoản', N'K0002     ')
INSERT [dbo].[BanHang] ([MaPhieuBanHang], [MaKhachHang], [NgayBan], [NoCu], [NoMoi], [DieuKhoanThanhToan], [HanThanhToan], [MaNVBan], [TongTien], [DiaChi], [SoDienThoai], [SoHoaDonVAT], [SoPhieuVietTay], [HinhThucThanhToan], [MaKhoXuat]) VALUES (2, N'KH0003    ', CAST(N'2017-06-15 10:09:22.737' AS DateTime), NULL, NULL, N'Công Nợ', CAST(N'2017-06-30 00:00:00.000' AS DateTime), N'QL01      ', N'1488630        ', N'1313', N'13131       ', N'13131', N'13131', N'Tiền Mặt', N'K0002     ')
SET IDENTITY_INSERT [dbo].[BanHang] OFF
INSERT [dbo].[BoPhan] ([MaBo], [TenBo], [GhiChu], [TinhTrangQL]) VALUES (N'B001      ', N'Bán Hàng', NULL, NULL)
INSERT [dbo].[BoPhan] ([MaBo], [TenBo], [GhiChu], [TinhTrangQL]) VALUES (N'B002      ', N'Quản Lý', NULL, NULL)
INSERT [dbo].[BoPhan] ([MaBo], [TenBo], [GhiChu], [TinhTrangQL]) VALUES (N'B003      ', N'Admin', NULL, NULL)
SET IDENTITY_INSERT [dbo].[CHiTietBanHang] ON 

INSERT [dbo].[CHiTietBanHang] ([MaPhieuCT], [MaBanHang], [MaHang], [Gia], [Soluong], [ThanhToan]) VALUES (1, 1, N'H0003     ', NULL, 777, 431235)
INSERT [dbo].[CHiTietBanHang] ([MaPhieuCT], [MaBanHang], [MaHang], [Gia], [Soluong], [ThanhToan]) VALUES (2, 2, N'H0001     ', NULL, 66, 1488630)
SET IDENTITY_INSERT [dbo].[CHiTietBanHang] OFF
SET IDENTITY_INSERT [dbo].[ChiTietMuaHang] ON 

INSERT [dbo].[ChiTietMuaHang] ([MaPhieuCT], [MaMuaHang], [MaHang], [Gia], [SoLuong], [ThanhToan]) VALUES (3, 12, N'H0001     ', NULL, 222, 147999852)
SET IDENTITY_INSERT [dbo].[ChiTietMuaHang] OFF
INSERT [dbo].[DonViTinh] ([MaDV], [TenDV], [GhiChu], [TinhTrangQL]) VALUES (N'DV0001    ', N'cái', NULL, 1)
INSERT [dbo].[HangHoa] ([MaHang], [TenHang], [MaDVT], [XuatXu], [Thue], [ChietKhau], [TonKhoToiThieu], [TonKhoHienTai], [MaNCC], [GiaMua], [GiaBanSi], [GiaBanLe], [MaKhoHang], [MaNhomHang], [MaSKU]) VALUES (N'H0001     ', N'OPPO F3 ', N'DV0001    ', N'Trung Quốc', 5, 0, 10, 256, N'NPP001    ', 5490000, 6490000, 7490000, N'K0001     ', N'N001      ', NULL)
INSERT [dbo].[HangHoa] ([MaHang], [TenHang], [MaDVT], [XuatXu], [Thue], [ChietKhau], [TonKhoToiThieu], [TonKhoHienTai], [MaNCC], [GiaMua], [GiaBanSi], [GiaBanLe], [MaKhoHang], [MaNhomHang], [MaSKU]) VALUES (N'H0002     ', N'Samsung Galaxy J7 Prime', N'DV0001    ', N'Hàn Quốc', 5, 0, 10, 100, N'NPP001    ', 3990000, 4990000, 5990000, N'K0001     ', N'N001      ', NULL)
INSERT [dbo].[HangHoa] ([MaHang], [TenHang], [MaDVT], [XuatXu], [Thue], [ChietKhau], [TonKhoToiThieu], [TonKhoHienTai], [MaNCC], [GiaMua], [GiaBanSi], [GiaBanLe], [MaKhoHang], [MaNhomHang], [MaSKU]) VALUES (N'H0003     ', N'iPhone 6 32GB (2017)', N'DV0001    ', N'Mĩ', 5, 0, 20, 100, N'NPP001    ', 6999000, 7999000, 8999000, N'K0001     ', N'N001      ', NULL)
INSERT [dbo].[HangHoa] ([MaHang], [TenHang], [MaDVT], [XuatXu], [Thue], [ChietKhau], [TonKhoToiThieu], [TonKhoHienTai], [MaNCC], [GiaMua], [GiaBanSi], [GiaBanLe], [MaKhoHang], [MaNhomHang], [MaSKU]) VALUES (N'H0004     ', N'Samsung Galaxy J5 Prime', N'DV0001    ', N'Hàn Quốc', 5, 0, 20, 100, N'NPP001    ', 2690000, 3690000, 4690000, N'K0001     ', N'N001      ', NULL)
INSERT [dbo].[HangHoa] ([MaHang], [TenHang], [MaDVT], [XuatXu], [Thue], [ChietKhau], [TonKhoToiThieu], [TonKhoHienTai], [MaNCC], [GiaMua], [GiaBanSi], [GiaBanLe], [MaKhoHang], [MaNhomHang], [MaSKU]) VALUES (N'H0005     ', N'XXX', N'DV0001    ', N'Nhật Bản', 0, 0, 0, 100, N'NPP001    ', 12312312, 31231, 123123, N'K0002     ', N'N002      ', NULL)
INSERT [dbo].[HangHoa] ([MaHang], [TenHang], [MaDVT], [XuatXu], [Thue], [ChietKhau], [TonKhoToiThieu], [TonKhoHienTai], [MaNCC], [GiaMua], [GiaBanSi], [GiaBanLe], [MaKhoHang], [MaNhomHang], [MaSKU]) VALUES (N'H0006     ', N'OPPO F3 ', N'DV0001    ', N'Trung Quốc', 5, 0, 0, 0, N'NPP001    ', 0, 0, 0, N'K0002     ', N'N002      ', NULL)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [LoaiKH], [MaKhuVuc], [DiaChi], [MST], [DTBan], [DTDD], [Fax], [Email], [Website], [STK], [NganHang], [GioiHanNo], [NoHienTai], [ChietKhau], [NguoiLienHe], [NickYM], [NickSkype], [TinhTrangQuanLy], [GhiChu]) VALUES (N'KH0001    ', N'Nguyễn Văn A', 1, N'1         ', N' số 673 đường Nguyễn Hữu Thọ, xã Phước Kiển, huyện Nhà Bè, TP. Hồ Chí Minh.', N'700789559 ', N'84.8. 3781 6777     ', N'0868.188.184        ', N'84.64.383 8257      ', N' pvgas@pvgas.com.vn                               ', N' http://www.pvgas.com.vn                                                                            ', N'0491000005142            ', N'Sacombank', N'10000000       ', N'0              ', 0, N'Huỳnh Ngọc Thái', N'hngocthai@yahoo.com                               ', N'hngocthai@yahoo.com                               ', 1, N'')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [LoaiKH], [MaKhuVuc], [DiaChi], [MST], [DTBan], [DTDD], [Fax], [Email], [Website], [STK], [NganHang], [GioiHanNo], [NoHienTai], [ChietKhau], [NguoiLienHe], [NickYM], [NickSkype], [TinhTrangQuanLy], [GhiChu]) VALUES (N'KH0002    ', N'Nguyễn Thị B', 2, N'2         ', N'Bảo Lộc, Phường Thanh Châu, Thành phố Phủ Lý, Tỉnh Hà Nam', N'700789560 ', N'(+84) 0710 3 734 148', N'0868.188.185        ', N'(+84) 0710 3 734 147', N'c@gmail.com                                       ', N'http://www.panasonic.com                                                                            ', N'0491000005143            ', N'Vietinbank', N'10000000       ', N'0              ', 0, N'Phương Trang', N'ptrang@yahoo.com                                  ', N'ptrang@yahoo.com                                  ', 1, NULL)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [LoaiKH], [MaKhuVuc], [DiaChi], [MST], [DTBan], [DTDD], [Fax], [Email], [Website], [STK], [NganHang], [GioiHanNo], [NoHienTai], [ChietKhau], [NguoiLienHe], [NickYM], [NickSkype], [TinhTrangQuanLy], [GhiChu]) VALUES (N'KH0003    ', N'Nguyễn Hoàng C', 2, N'3         ', N'Phòng 402, Tòa nhà Nguyễn Hiếu, số 131 Trần Hưng Đạo, phường An Phú, quận Ninh Kiều, Thành phố Cần Thơ, Việt Nam', N'700789561 ', N'(+84) 0710 3 734 148', N'01296.851.104       ', N'(+84) 8170193       ', N'c@gmail.com                                       ', N'https://www.thegioididong.com                                                                       ', N' 0103758473              ', N'Agribank', N'10000000       ', N'0              ', 0, N'Hoài Thương', N'hthuong@yahoo.com                                 ', N'hthuong@yahoo.com                                 ', 1, NULL)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [LoaiKH], [MaKhuVuc], [DiaChi], [MST], [DTBan], [DTDD], [Fax], [Email], [Website], [STK], [NganHang], [GioiHanNo], [NoHienTai], [ChietKhau], [NguoiLienHe], [NickYM], [NickSkype], [TinhTrangQuanLy], [GhiChu]) VALUES (N'KH0004    ', N'Trần Văn T', 1, N'3         ', N'Tầng 6, ACB Tower, số 218 đường Bạch Đằng, phường Phước Ninh, quận Hải Châu, Thành phố Đà Nẵng, Việt Nam', N'700789562 ', N'18001593            ', N'01296.851.041       ', N'04 3795 0097        ', N't@gmail.com                                       ', N'http://hanhtrinh24h.com                                                                             ', N'1704206011777            ', N'Sacombank', N'10000000       ', N'0              ', 0, N'T', N't@gmail.com                                       ', N't@gmail.com                                       ', 1, NULL)
INSERT [dbo].[KhoHang] ([MaKho], [TenKho], [NguoiLienHe], [DiaChi], [DTBan], [DTDD], [Fax], [Email], [NguoiQuanLy], [DienGiai], [TinhTrangQuanLy]) VALUES (N'K0001     ', N'Kho 1', N'Thái', N'số 28 Nguyễn Thị Diệu, phường 6, quận 3, Thành phố Hồ Chí Minh', N'0839308980', N'01292847605', N'0839308982', N'kho1@gmail.com                                    ', N'Thái', N'Không', 1)
INSERT [dbo].[KhoHang] ([MaKho], [TenKho], [NguoiLienHe], [DiaChi], [DTBan], [DTDD], [Fax], [Email], [NguoiQuanLy], [DienGiai], [TinhTrangQuanLy]) VALUES (N'K0002     ', N'Kho 2', N'Hương', N'Lô 73 và 75, đường D, Khu Chế Xuất Sài Gòn - Linh Trung, Phường Linh Trung, Quận Thủ Đức, Thành phố Hồ Chí Minh', N'0837244492', N'01292847491', N'0837244491', N'kho2@gmail.com                                    ', N'Hương', N'Không', 1)
INSERT [dbo].[KhuVuc] ([MaKV], [TenKV], [GhiChu]) VALUES (N'1         ', N'TPHCM', NULL)
INSERT [dbo].[KhuVuc] ([MaKV], [TenKV], [GhiChu]) VALUES (N'2         ', N'Hà Nội', NULL)
INSERT [dbo].[KhuVuc] ([MaKV], [TenKV], [GhiChu]) VALUES (N'3         ', N'Hải Phòng', NULL)
INSERT [dbo].[KhuVuc] ([MaKV], [TenKV], [GhiChu]) VALUES (N'4         ', N'131', N'1414')
SET IDENTITY_INSERT [dbo].[LoaiKH] ON 

INSERT [dbo].[LoaiKH] ([ID], [TenLoaiKH]) VALUES (1, N'Đại Lý')
INSERT [dbo].[LoaiKH] ([ID], [TenLoaiKH]) VALUES (2, N'Khách Lẻ')
SET IDENTITY_INSERT [dbo].[LoaiKH] OFF
SET IDENTITY_INSERT [dbo].[LoaiTien] ON 

INSERT [dbo].[LoaiTien] ([id], [TenLoaiTien]) VALUES (1, N'Đồng')
SET IDENTITY_INSERT [dbo].[LoaiTien] OFF
SET IDENTITY_INSERT [dbo].[MuaHang] ON 

INSERT [dbo].[MuaHang] ([MaPhieuMuaHang], [MaNPP], [NgayLap], [MaLoaiTien], [DieuKhoanThanhToan], [HanThanhToan], [TongTien], [MaNV], [DiaChi], [SoDienThoai], [SoHoaDonVAT], [SoPhieuVietTay], [MaNhapKho], [HinhThucThanhToan]) VALUES (12, N'NPP001    ', CAST(N'2017-06-15 10:06:59.857' AS DateTime), NULL, N'Thanh Toán Ngay', CAST(N'2017-06-25 00:00:00.000' AS DateTime), N'147999852      ', N'QL01      ', N'131', N'1313', N'1313', N'1313', N'K0002     ', N'Chuyển Khoản')
SET IDENTITY_INSERT [dbo].[MuaHang] OFF
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [DocThan], [ChucVu], [DiaChi], [Email], [DienThoai], [DiDong], [DienGiai], [MaBP], [MaNVQL], [TinhTrangQL]) VALUES (N'AD01      ', N'Soái ADMIN', 1, N'Admin', N'Admin', N'Admin@admin', NULL, N'0900000000 ', NULL, N'B003      ', NULL, 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [DocThan], [ChucVu], [DiaChi], [Email], [DienThoai], [DiDong], [DienGiai], [MaBP], [MaNVQL], [TinhTrangQL]) VALUES (N'NV01      ', N'Nguyễn Thị C', 1, N'Bán Hàng', N'Khu công nghiệp Thăng Long, Đông Anh, Hà Nội, Việt Nam', N'c@yahoo.com', NULL, N'01296854715', NULL, N'B001      ', N'QL01      ', 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [DocThan], [ChucVu], [DiaChi], [Email], [DienThoai], [DiDong], [DienGiai], [MaBP], [MaNVQL], [TinhTrangQL]) VALUES (N'QL01      ', N'Nguyễn Văn A', 1, N'Quản Lý', N': 232/56 Hương Lộ 80, khu phố 2, Phường Bình Hưng Hòa B, Quận Bình Tân, Thành phố Hồ Chí Minh', N'a@yahoo.com', NULL, N'0938888888 ', NULL, N'B002      ', NULL, 1)
INSERT [dbo].[NhaPhanPhoi] ([MaNPP], [TenNPP], [MaKhuVuc], [DiaChi], [MST], [DTBan], [DTDD], [Fax], [Email], [Website], [STK], [NganHang], [GioiHanNo], [NoHienTai], [ChietKhau], [NguoiLienHe], [ChucVu], [TinhTrangQuanLy], [GhiChu]) VALUES (N'NPP001    ', N'FPT', N'1         ', N'Lô B6 Khu công nghiệp Thăng Long, Đông Anh, Hà Nội - Việt Nam', N'0700789559', N'0439515268', N'01296863104', N'0439515269', N'fpt@gmail.com                                     ', N'fpt.com                                           ', N'0251002486393  ', N'Sacombank', N'100000         ', N'0              ', 5, N'Phương', N'Quản Lý', 1, NULL)
SET IDENTITY_INSERT [dbo].[NhatKiHeThong] ON 

INSERT [dbo].[NhatKiHeThong] ([id], [MaNV], [MayTinh], [ThoiGian], [TenChucNang], [HanhDong]) VALUES (1, N'AD01      ', N'DESKTOP-DNT8O41', CAST(N'2017-06-11 00:00:00.000' AS DateTime), N'Nhật Ký Hệ Thống', N'Xem')
INSERT [dbo].[NhatKiHeThong] ([id], [MaNV], [MayTinh], [ThoiGian], [TenChucNang], [HanhDong]) VALUES (2, N'AD01      ', N'DESKTOP-DNT8O41', CAST(N'2017-06-11 00:00:00.000' AS DateTime), N'Hệ Thống', N'Đăng Nhập')
INSERT [dbo].[NhatKiHeThong] ([id], [MaNV], [MayTinh], [ThoiGian], [TenChucNang], [HanhDong]) VALUES (3, N'AD01      ', N'DESKTOP-T4L6QSJ', CAST(N'2017-06-14 23:41:07.650' AS DateTime), N'MuaHang', N'Làm mới')
INSERT [dbo].[NhatKiHeThong] ([id], [MaNV], [MayTinh], [ThoiGian], [TenChucNang], [HanhDong]) VALUES (4, N'AD01      ', N'DESKTOP-T4L6QSJ', CAST(N'2017-06-14 23:42:41.257' AS DateTime), N'MuaHang', N'Làm mới')
INSERT [dbo].[NhatKiHeThong] ([id], [MaNV], [MayTinh], [ThoiGian], [TenChucNang], [HanhDong]) VALUES (5, N'AD01      ', N'DESKTOP-T4L6QSJ', CAST(N'2017-06-15 00:43:08.613' AS DateTime), N'MuaHang', N'Làm mới')
INSERT [dbo].[NhatKiHeThong] ([id], [MaNV], [MayTinh], [ThoiGian], [TenChucNang], [HanhDong]) VALUES (6, N'AD01      ', N'DESKTOP-T4L6QSJ', CAST(N'2017-06-15 00:43:10.467' AS DateTime), N'banhang', N'Làm mới')
INSERT [dbo].[NhatKiHeThong] ([id], [MaNV], [MayTinh], [ThoiGian], [TenChucNang], [HanhDong]) VALUES (7, N'AD01      ', N'DESKTOP-T4L6QSJ', CAST(N'2017-06-15 00:43:23.347' AS DateTime), N'banhang', N'Làm mới')
INSERT [dbo].[NhatKiHeThong] ([id], [MaNV], [MayTinh], [ThoiGian], [TenChucNang], [HanhDong]) VALUES (8, N'AD01      ', N'DESKTOP-T4L6QSJ', CAST(N'2017-06-15 10:06:28.307' AS DateTime), N'MuaHang', N'Làm mới')
INSERT [dbo].[NhatKiHeThong] ([id], [MaNV], [MayTinh], [ThoiGian], [TenChucNang], [HanhDong]) VALUES (9, N'AD01      ', N'DESKTOP-T4L6QSJ', CAST(N'2017-06-15 10:07:01.557' AS DateTime), N'MuaHang', N'Làm mới')
INSERT [dbo].[NhatKiHeThong] ([id], [MaNV], [MayTinh], [ThoiGian], [TenChucNang], [HanhDong]) VALUES (10, N'AD01      ', N'DESKTOP-T4L6QSJ', CAST(N'2017-06-15 10:07:01.567' AS DateTime), N'Mua Hàng', N'Thêm Mua Hàng')
INSERT [dbo].[NhatKiHeThong] ([id], [MaNV], [MayTinh], [ThoiGian], [TenChucNang], [HanhDong]) VALUES (11, N'AD01      ', N'DESKTOP-T4L6QSJ', CAST(N'2017-06-15 10:08:51.867' AS DateTime), N'banhang', N'Làm mới')
INSERT [dbo].[NhatKiHeThong] ([id], [MaNV], [MayTinh], [ThoiGian], [TenChucNang], [HanhDong]) VALUES (12, N'AD01      ', N'DESKTOP-T4L6QSJ', CAST(N'2017-06-15 10:09:24.543' AS DateTime), N'banhang', N'Làm mới')
INSERT [dbo].[NhatKiHeThong] ([id], [MaNV], [MayTinh], [ThoiGian], [TenChucNang], [HanhDong]) VALUES (13, N'AD01      ', N'DESKTOP-T4L6QSJ', CAST(N'2017-06-15 10:09:24.583' AS DateTime), N'Bán Hàng', N'Bán Hàng')
INSERT [dbo].[NhatKiHeThong] ([id], [MaNV], [MayTinh], [ThoiGian], [TenChucNang], [HanhDong]) VALUES (14, N'AD01      ', N'DESKTOP-T4L6QSJ', CAST(N'2017-06-15 14:22:12.350' AS DateTime), N'MuaHang', N'Làm mới')
INSERT [dbo].[NhatKiHeThong] ([id], [MaNV], [MayTinh], [ThoiGian], [TenChucNang], [HanhDong]) VALUES (15, N'AD01      ', N'DESKTOP-T4L6QSJ', CAST(N'2017-06-15 14:27:50.910' AS DateTime), N'MuaHang', N'Làm mới')
INSERT [dbo].[NhatKiHeThong] ([id], [MaNV], [MayTinh], [ThoiGian], [TenChucNang], [HanhDong]) VALUES (16, N'AD01      ', N'DESKTOP-T4L6QSJ', CAST(N'2017-06-15 14:30:21.900' AS DateTime), N'MuaHang', N'Làm mới')
INSERT [dbo].[NhatKiHeThong] ([id], [MaNV], [MayTinh], [ThoiGian], [TenChucNang], [HanhDong]) VALUES (17, N'AD01      ', N'DESKTOP-T4L6QSJ', CAST(N'2017-06-15 14:43:07.073' AS DateTime), N'MuaHang', N'Làm mới')
INSERT [dbo].[NhatKiHeThong] ([id], [MaNV], [MayTinh], [ThoiGian], [TenChucNang], [HanhDong]) VALUES (18, N'AD01      ', N'DESKTOP-T4L6QSJ', CAST(N'2017-06-15 15:05:30.283' AS DateTime), N'MuaHang', N'Làm mới')
INSERT [dbo].[NhatKiHeThong] ([id], [MaNV], [MayTinh], [ThoiGian], [TenChucNang], [HanhDong]) VALUES (19, N'AD01      ', N'DESKTOP-T4L6QSJ', CAST(N'2017-06-15 15:10:56.517' AS DateTime), N'MuaHang', N'Làm mới')
SET IDENTITY_INSERT [dbo].[NhatKiHeThong] OFF
INSERT [dbo].[NhomHangHoa] ([MaNhom], [TenNhom], [GhiChu], [TinhTrangQL]) VALUES (N'N001      ', N'Điện Thoại', NULL, 1)
INSERT [dbo].[NhomHangHoa] ([MaNhom], [TenNhom], [GhiChu], [TinhTrangQL]) VALUES (N'N002      ', N'LapTop', NULL, 1)
SET IDENTITY_INSERT [dbo].[TaiKhoanNguoiDung] ON 

INSERT [dbo].[TaiKhoanNguoiDung] ([id], [MaNV], [TenTaiKhoan], [MatKhau], [MaVaiTro], [DienGiai], [TinhTrangQL]) VALUES (1, N'NV01      ', N'NhanVien01', N'123456', NULL, NULL, 1)
INSERT [dbo].[TaiKhoanNguoiDung] ([id], [MaNV], [TenTaiKhoan], [MatKhau], [MaVaiTro], [DienGiai], [TinhTrangQL]) VALUES (2, N'QL01      ', N'QuanLy01', N'123456', NULL, NULL, 1)
INSERT [dbo].[TaiKhoanNguoiDung] ([id], [MaNV], [TenTaiKhoan], [MatKhau], [MaVaiTro], [DienGiai], [TinhTrangQL]) VALUES (3, N'AD01      ', N'Admin', N'e3afed0047b08059d0fada10f400c1e5', NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[TaiKhoanNguoiDung] OFF
SET IDENTITY_INSERT [dbo].[ThongTinToChucCaNhan] ON 

INSERT [dbo].[ThongTinToChucCaNhan] ([TenDonVi], [DiaCHi], [DTBan], [DTDD], [Fax], [Website], [Email], [LinhVuc], [MST], [GPKD], [Ma]) VALUES (N'Phan Thanh Su', N'227 Nguyễn Văn Cừ Q5 TP.HCM', N'19006008  ', N'0989527499 ', N'0838489825', N'www.perfect.com                                   ', N'sales@perfect.com                                 ', N'Thương Mại', N' 2802457570    ', N'123456789      ', 1)
SET IDENTITY_INSERT [dbo].[ThongTinToChucCaNhan] OFF
ALTER TABLE [dbo].[BanHang]  WITH CHECK ADD  CONSTRAINT [FK_BanHang_KhachHang] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[BanHang] CHECK CONSTRAINT [FK_BanHang_KhachHang]
GO
ALTER TABLE [dbo].[BanHang]  WITH CHECK ADD  CONSTRAINT [FK_BanHang_KhoHang] FOREIGN KEY([MaKhoXuat])
REFERENCES [dbo].[KhoHang] ([MaKho])
GO
ALTER TABLE [dbo].[BanHang] CHECK CONSTRAINT [FK_BanHang_KhoHang]
GO
ALTER TABLE [dbo].[BanHang]  WITH CHECK ADD  CONSTRAINT [FK_BanHang_NhanVien] FOREIGN KEY([MaNVBan])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[BanHang] CHECK CONSTRAINT [FK_BanHang_NhanVien]
GO
ALTER TABLE [dbo].[CHiTietBanHang]  WITH CHECK ADD  CONSTRAINT [FK_CHiTietBanHang_BanHang] FOREIGN KEY([MaBanHang])
REFERENCES [dbo].[BanHang] ([MaPhieuBanHang])
GO
ALTER TABLE [dbo].[CHiTietBanHang] CHECK CONSTRAINT [FK_CHiTietBanHang_BanHang]
GO
ALTER TABLE [dbo].[CHiTietBanHang]  WITH CHECK ADD  CONSTRAINT [FK_CHiTietBanHang_HangHoa] FOREIGN KEY([MaHang])
REFERENCES [dbo].[HangHoa] ([MaHang])
GO
ALTER TABLE [dbo].[CHiTietBanHang] CHECK CONSTRAINT [FK_CHiTietBanHang_HangHoa]
GO
ALTER TABLE [dbo].[ChiTietMuaHang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietMuaHang_HangHoa] FOREIGN KEY([MaHang])
REFERENCES [dbo].[HangHoa] ([MaHang])
GO
ALTER TABLE [dbo].[ChiTietMuaHang] CHECK CONSTRAINT [FK_ChiTietMuaHang_HangHoa]
GO
ALTER TABLE [dbo].[ChiTietMuaHang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietMuaHang_MuaHang] FOREIGN KEY([MaMuaHang])
REFERENCES [dbo].[MuaHang] ([MaPhieuMuaHang])
GO
ALTER TABLE [dbo].[ChiTietMuaHang] CHECK CONSTRAINT [FK_ChiTietMuaHang_MuaHang]
GO
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD  CONSTRAINT [FK_HangHoa_DonViTinh] FOREIGN KEY([MaDVT])
REFERENCES [dbo].[DonViTinh] ([MaDV])
GO
ALTER TABLE [dbo].[HangHoa] CHECK CONSTRAINT [FK_HangHoa_DonViTinh]
GO
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD  CONSTRAINT [FK_HangHoa_KhoHang] FOREIGN KEY([MaKhoHang])
REFERENCES [dbo].[KhoHang] ([MaKho])
GO
ALTER TABLE [dbo].[HangHoa] CHECK CONSTRAINT [FK_HangHoa_KhoHang]
GO
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD  CONSTRAINT [FK_HangHoa_NhaPhanPhoi] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaPhanPhoi] ([MaNPP])
GO
ALTER TABLE [dbo].[HangHoa] CHECK CONSTRAINT [FK_HangHoa_NhaPhanPhoi]
GO
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD  CONSTRAINT [FK_HangHoa_NhomHangHoa] FOREIGN KEY([MaNhomHang])
REFERENCES [dbo].[NhomHangHoa] ([MaNhom])
GO
ALTER TABLE [dbo].[HangHoa] CHECK CONSTRAINT [FK_HangHoa_NhomHangHoa]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_KhuVuc] FOREIGN KEY([MaKhuVuc])
REFERENCES [dbo].[KhuVuc] ([MaKV])
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_KhachHang_KhuVuc]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_LoaiKH] FOREIGN KEY([LoaiKH])
REFERENCES [dbo].[LoaiKH] ([ID])
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_KhachHang_LoaiKH]
GO
ALTER TABLE [dbo].[MuaHang]  WITH CHECK ADD  CONSTRAINT [FK_MuaHang_KhoHang] FOREIGN KEY([MaNhapKho])
REFERENCES [dbo].[KhoHang] ([MaKho])
GO
ALTER TABLE [dbo].[MuaHang] CHECK CONSTRAINT [FK_MuaHang_KhoHang]
GO
ALTER TABLE [dbo].[MuaHang]  WITH CHECK ADD  CONSTRAINT [FK_MuaHang_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[MuaHang] CHECK CONSTRAINT [FK_MuaHang_NhanVien]
GO
ALTER TABLE [dbo].[MuaHang]  WITH CHECK ADD  CONSTRAINT [FK_MuaHang_NhaPhanPhoi] FOREIGN KEY([MaNPP])
REFERENCES [dbo].[NhaPhanPhoi] ([MaNPP])
GO
ALTER TABLE [dbo].[MuaHang] CHECK CONSTRAINT [FK_MuaHang_NhaPhanPhoi]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_BoPhan] FOREIGN KEY([MaBP])
REFERENCES [dbo].[BoPhan] ([MaBo])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_BoPhan]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_NhanVien] FOREIGN KEY([MaNVQL])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_NhanVien]
GO
ALTER TABLE [dbo].[NhaPhanPhoi]  WITH CHECK ADD  CONSTRAINT [FK_NhaPhanPhoi_KhuVuc] FOREIGN KEY([MaKhuVuc])
REFERENCES [dbo].[KhuVuc] ([MaKV])
GO
ALTER TABLE [dbo].[NhaPhanPhoi] CHECK CONSTRAINT [FK_NhaPhanPhoi_KhuVuc]
GO
ALTER TABLE [dbo].[NhatKiHeThong]  WITH CHECK ADD  CONSTRAINT [FK_NhatKiHeThong_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[NhatKiHeThong] CHECK CONSTRAINT [FK_NhatKiHeThong_NhanVien]
GO
ALTER TABLE [dbo].[TaiKhoanNguoiDung]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoanNguoiDung_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[TaiKhoanNguoiDung] CHECK CONSTRAINT [FK_TaiKhoanNguoiDung_NhanVien]
GO
ALTER TABLE [dbo].[ThuTien]  WITH CHECK ADD  CONSTRAINT [FK_ThuTien_BanHang] FOREIGN KEY([MaBanHang])
REFERENCES [dbo].[BanHang] ([MaPhieuBanHang])
GO
ALTER TABLE [dbo].[ThuTien] CHECK CONSTRAINT [FK_ThuTien_BanHang]
GO
ALTER TABLE [dbo].[ThuTien]  WITH CHECK ADD  CONSTRAINT [FK_ThuTien_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[ThuTien] CHECK CONSTRAINT [FK_ThuTien_KhachHang]
GO
ALTER TABLE [dbo].[ThuTien]  WITH CHECK ADD  CONSTRAINT [FK_ThuTien_LoaiTien] FOREIGN KEY([idLoaiTien])
REFERENCES [dbo].[LoaiTien] ([id])
GO
ALTER TABLE [dbo].[ThuTien] CHECK CONSTRAINT [FK_ThuTien_LoaiTien]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "HangHoa"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 216
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "DonViTinh"
            Begin Extent = 
               Top = 6
               Left = 254
               Bottom = 136
               Right = 424
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_HangHoa'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_HangHoa'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "KhoHang"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 223
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_KhoHang'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_KhoHang'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "NhanVien"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_NhanVien'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_NhanVien'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "NhaPhanPhoi"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 223
            End
            DisplayFlags = 280
            TopColumn = 2
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_NhaPhanPhoi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_NhaPhanPhoi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "NhanVien"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TaiKhoanNguoiDung"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_ThongTinLogin'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_ThongTinLogin'
GO
USE [master]
GO
ALTER DATABASE [QLBanHang] SET  READ_WRITE 
GO
