USE [master]
GO
CREATE DATABASE [QuanlyQuanAn]
GO
USE [QuanlyQuanAn]
GO

CREATE TABLE [dbo].[Khachhang](
	[MaKH] [nvarchar](50) NOT NULL primary key,
	[Holot] [nvarchar](100) NULL,
	[Ten] [nvarchar](50) NULL,
	[Ngaysinh] [datetime] NULL,
	[Diachi] [nvarchar](100) Null,
	[Gioitinh] [bit] NULL
 )

GO
INSERT [dbo].[Khachhang] ([MaKH], [Holot], [Ten], [Ngaysinh], [Gioitinh]) 
VALUES (N'sv007', N'', N'', CAST(N'2016-05-06 12:52:23.000' AS DateTime), 0);

INSERT [dbo].[Khachhang] ([MaKH], [Holot], [Ten], [Ngaysinh], [Gioitinh]) 
VALUES (N'sv01', N'Mai', N'Tới', CAST(N'2012-04-30 00:00:00.000' AS DateTime), 0);

INSERT [dbo].[Khachhang] ([MaKH], [Holot], [Ten], [Ngaysinh], [Gioitinh]) 
VALUES (N'sv02', N'Nguyễn Văn', N'Tèo', CAST(N'2012-03-30 00:00:00.000' AS DateTime), 0);

INSERT [dbo].[Khachhang] ([MaKH], [Holot], [Ten], [Ngaysinh], [Gioitinh]) 
VALUES (N'sv03', N'Đỗ', N'Mai', CAST(N'2012-02-20 00:00:00.000' AS DateTime), 1);

CREATE TABLE [dbo].[Hanghoa](
	[MaHH] [nvarchar](50) NOT NULL primary key,
	[TenHanghoa] [nvarchar](200) NULL,
	[GiaBan] [float] NULL,
	[Mota] [nvarchar](500) NULL,
	[ManhomHH] [nvarchar](50) NULL,
	[Mancc] [nvarchar](50) Not null
)
GO
INSERT [dbo].[Hanghoa] ([MaHH], [TenHanghoa], [GiaBan], [Mota],  [ManhomHH], [Mancc]) 
VALUES (N'sp001', N'Cocacola', 15000, N'Nước uống', N'nh002',N'ncc001');

INSERT [dbo].[Hanghoa] ([MaHH], [TenHanghoa], [GiaBan], [Mota],  [ManhomHH], [Mancc]) 
VALUES (N'sp002', N'Nước suối', 12000, NULL, N'nh002',N'ncc002');


GO
CREATE TABLE [dbo].[NhomHanghoa](
	[ManhomHH] [nvarchar](50) NOT NULL primary key,
	[TenNhomHanghoa] [nvarchar](200) NULL,
	[Ghichu] [nvarchar](500) NULL
)
GO

INSERT [dbo].[NhomHanghoa] ([ManhomHH], [TenNhomHanghoa], [Ghichu]) 
VALUES (N'nh001', N'Thức ăn', NULL);

INSERT [dbo].[NhomHanghoa] ([ManhomHH], [TenNhomHanghoa], [Ghichu]) 
VALUES (N'nh002', N'Nước uống', N'Không có cồn');
GO

CREATE TABLE [dbo].[Hoadon](
	[MaHD] [nvarchar](50) NOT NULL primary key,
	[MaNV] [nvarchar](50) not NULL,
	[MaKH] [nvarchar](50) Not null,
	[NgayHoadon] [datetime] NULL,
	[Tongtien] [float] NULL,
	[Ghichu] [nvarchar](200) NULL
)
GO
CREATE TABLE [dbo].[Nhanvien](
	[MaNV] [nvarchar](50) NOT NULL primary key,
	[Holot] [nvarchar](100) NULL,
	[Ten] [nvarchar](200) NULL,
	[Ngaysinh] [datetime] NULL,
	[NgayVaolam] [datetime] NULL
)
GO
CREATE TABLE [dbo].[CTHoadon](
	[MaCTHD] [nvarchar](50) NOT NULL,
	[MaHD] [nvarchar](50) NOT NULL,
	[MaHH] [nvarchar](50) NULL,
	[TenHanghoa] [nvarchar](200) NULL,
	[Soluong] [float] NULL,
	[Dongia] [float] NULL,
	[Ghichu] [nvarchar](200) NULL,
	primary key (MaCTHD, MaHD)
)
GO
CREATE TABLE [dbo].[Nhacc](
	[Mancc] [nvarchar](50) Not null primary key,
	[Tenncc] [nvarchar](100) not null,
	[Diachi] [nvarchar](200) null,
	[Mathang] [nvarchar](100) null
)
GO
ALTER TABLE dbo.Hoadon ADD FOREIGN KEY(MaNV) REFERENCES dbo.Nhanvien(MaNV)
ALTER TABLE dbo.Hoadon ADD FOREIGN KEY(MaKH) REFERENCES dbo.Khachhang(MaKH)
ALTER TABLE dbo.CTHoadon ADD FOREIGN KEY(MaHD) REFERENCES dbo.Hoadon(MaHD)
ALTER TABLE dbo.CTHoadon ADD FOREIGN KEY(MaHH) REFERENCES dbo.Hanghoa(MaHH)
ALTER TABLE dbo.Hanghoa ADD FOREIGN KEY(ManhomHH) REFERENCES dbo.NhomHanghoa(ManhomHH)
ALTER TABLE dbo.Hanghoa ADD FOREIGN KEY(Mancc) REFERENCES dbo.Nhacc(Mancc)