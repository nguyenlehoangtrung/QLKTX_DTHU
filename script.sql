USE [QLKTX]
GO
/****** Object:  Table [dbo].[DANGNHAP]    Script Date: 12/20/2021 11:31:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DANGNHAP](
	[MaNV] [nvarchar](10) NOT NULL,
	[MatKhau] [nvarchar](50) NULL,
 CONSTRAINT [PK_DANGNHAP] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOPDONG]    Script Date: 12/20/2021 11:31:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOPDONG](
	[MAHD] [nvarchar](10) NOT NULL,
	[MaNV] [nvarchar](10) NOT NULL,
	[MSSV] [nvarchar](10) NOT NULL,
	[MaPhong] [nvarchar](10) NOT NULL,
	[NgayBD] [datetime] NULL,
	[NgayKT] [datetime] NULL,
	[LoaiHD] [nvarchar](50) NULL,
	[NgayLap] [datetime] NULL,
	[SoTien] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 12/20/2021 11:31:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [nvarchar](10) NOT NULL,
	[HoTenNV] [nvarchar](50) NULL,
	[DiaChiNV] [nvarchar](50) NULL,
	[SDTNV] [nvarchar](50) NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHONG]    Script Date: 12/20/2021 11:31:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHONG](
	[MaPhong] [nvarchar](10) NOT NULL,
	[TenPhong] [nvarchar](50) NULL,
	[KichThuoc] [nvarchar](50) NULL,
	[DayPhong] [nvarchar](50) NULL,
	[LoaiGiuong] [nvarchar](50) NULL,
 CONSTRAINT [PK_PHONG] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SINHVIEN]    Script Date: 12/20/2021 11:31:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SINHVIEN](
	[MSSV] [nvarchar](10) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[NgaySinh] [datetime] NULL,
	[SDT] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
 CONSTRAINT [PK_SINHVIEN] PRIMARY KEY CLUSTERED 
(
	[MSSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DANGNHAP] ([MaNV], [MatKhau]) VALUES (N'NV001', N'123')
INSERT [dbo].[DANGNHAP] ([MaNV], [MatKhau]) VALUES (N'NV002', N'123')
INSERT [dbo].[DANGNHAP] ([MaNV], [MatKhau]) VALUES (N'NV003', N'123')
INSERT [dbo].[DANGNHAP] ([MaNV], [MatKhau]) VALUES (N'NV004', N'123')
INSERT [dbo].[DANGNHAP] ([MaNV], [MatKhau]) VALUES (N'NV005', N'123')
GO
INSERT [dbo].[HOPDONG] ([MAHD], [MaNV], [MSSV], [MaPhong], [NgayBD], [NgayKT], [LoaiHD], [NgayLap], [SoTien]) VALUES (N'1', N'NV001', N'SV001', N'100', CAST(N'2021-12-14T00:00:00.000' AS DateTime), CAST(N'2022-03-14T00:00:00.000' AS DateTime), N'Thuê phòng', CAST(N'2021-12-13T00:00:00.000' AS DateTime), N'240000')
INSERT [dbo].[HOPDONG] ([MAHD], [MaNV], [MSSV], [MaPhong], [NgayBD], [NgayKT], [LoaiHD], [NgayLap], [SoTien]) VALUES (N'2', N'NV001', N'SV002', N'101', CAST(N'2021-12-15T00:00:00.000' AS DateTime), CAST(N'2022-03-15T00:00:00.000' AS DateTime), N'Thuê phòng', CAST(N'2021-12-14T00:00:00.000' AS DateTime), N'240000')
INSERT [dbo].[HOPDONG] ([MAHD], [MaNV], [MSSV], [MaPhong], [NgayBD], [NgayKT], [LoaiHD], [NgayLap], [SoTien]) VALUES (N'3', N'NV001', N'SV003', N'101', CAST(N'2021-12-15T00:00:00.000' AS DateTime), CAST(N'2022-03-15T00:00:00.000' AS DateTime), N'Thuê phòng', CAST(N'2021-12-14T00:00:00.000' AS DateTime), N'240000')
INSERT [dbo].[HOPDONG] ([MAHD], [MaNV], [MSSV], [MaPhong], [NgayBD], [NgayKT], [LoaiHD], [NgayLap], [SoTien]) VALUES (N'4', N'NV001', N'SV004', N'102', CAST(N'2021-03-10T00:00:00.000' AS DateTime), CAST(N'2021-09-10T00:00:00.000' AS DateTime), N'Thuê phòng', CAST(N'2021-08-03T00:00:00.000' AS DateTime), N'480000')
INSERT [dbo].[HOPDONG] ([MAHD], [MaNV], [MSSV], [MaPhong], [NgayBD], [NgayKT], [LoaiHD], [NgayLap], [SoTien]) VALUES (N'5', N'NV002', N'SV005', N'103', CAST(N'2021-01-08T00:00:00.000' AS DateTime), CAST(N'2021-09-08T00:00:00.000' AS DateTime), N'Thuê phòng', CAST(N'2021-07-01T00:00:00.000' AS DateTime), N'640000')
INSERT [dbo].[HOPDONG] ([MAHD], [MaNV], [MSSV], [MaPhong], [NgayBD], [NgayKT], [LoaiHD], [NgayLap], [SoTien]) VALUES (N'6', N'NV005', N'SV006', N'103', CAST(N'2021-01-08T00:00:00.000' AS DateTime), CAST(N'2021-09-08T00:00:00.000' AS DateTime), N'Thuê phòng', CAST(N'2021-07-01T00:00:00.000' AS DateTime), N'640000')
GO
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTenNV], [DiaChiNV], [SDTNV]) VALUES (N'NV001', N'Trần Đình Chiến', N'Đồng Tháp', N'0234325632')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTenNV], [DiaChiNV], [SDTNV]) VALUES (N'NV002', N'Nguyễn Hòa Bình', N'Đồng Tháp', N'0981237569')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTenNV], [DiaChiNV], [SDTNV]) VALUES (N'NV003', N'Nguyễn Văn Hòa', N'Tiền Giang', N'0984523231')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTenNV], [DiaChiNV], [SDTNV]) VALUES (N'NV004', N'Lê Văn Đình', N'Bến Tre', N'0456783212')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTenNV], [DiaChiNV], [SDTNV]) VALUES (N'NV005', N'Lê Văn Linh', N'An Giang', N'0399994566')
GO
INSERT [dbo].[PHONG] ([MaPhong], [TenPhong], [KichThuoc], [DayPhong], [LoaiGiuong]) VALUES (N'100', N'A1', N'Nhỏ', N'A', N'Đơn')
INSERT [dbo].[PHONG] ([MaPhong], [TenPhong], [KichThuoc], [DayPhong], [LoaiGiuong]) VALUES (N'101', N'A2', N'Lớn', N'A', N'Tầng')
INSERT [dbo].[PHONG] ([MaPhong], [TenPhong], [KichThuoc], [DayPhong], [LoaiGiuong]) VALUES (N'102', N'B1', N'Nhỏ', N'B', N'Đơn')
INSERT [dbo].[PHONG] ([MaPhong], [TenPhong], [KichThuoc], [DayPhong], [LoaiGiuong]) VALUES (N'103', N'B2', N'Lớn', N'B', N'Tầng')
INSERT [dbo].[PHONG] ([MaPhong], [TenPhong], [KichThuoc], [DayPhong], [LoaiGiuong]) VALUES (N'104', N'A3', N'Lớn', N'A', N'Tầng')
GO
INSERT [dbo].[SINHVIEN] ([MSSV], [HoTen], [GioiTinh], [NgaySinh], [SDT], [DiaChi]) VALUES (N'SV001', N'Đặng Ngọc Bin', N'Nam', CAST(N'2000-02-29T00:00:00.000' AS DateTime), N'0866744002', N'Đồng Tháp')
INSERT [dbo].[SINHVIEN] ([MSSV], [HoTen], [GioiTinh], [NgaySinh], [SDT], [DiaChi]) VALUES (N'SV002', N'Nguyễn Lê Hoàng Trung', N'Nam', CAST(N'2000-08-25T00:00:00.000' AS DateTime), N'0343434343', N'Tiền Giang')
INSERT [dbo].[SINHVIEN] ([MSSV], [HoTen], [GioiTinh], [NgaySinh], [SDT], [DiaChi]) VALUES (N'SV003', N'Lê Duy Khang', N'Nam', CAST(N'2000-07-01T00:00:00.000' AS DateTime), N'0343434343', N'Bến Tre')
INSERT [dbo].[SINHVIEN] ([MSSV], [HoTen], [GioiTinh], [NgaySinh], [SDT], [DiaChi]) VALUES (N'SV004', N'Nguyễn Thị Hồng Ngọc', N'Nữ', CAST(N'2000-07-02T00:00:00.000' AS DateTime), N'0121212121', N'Đồng Tháp')
INSERT [dbo].[SINHVIEN] ([MSSV], [HoTen], [GioiTinh], [NgaySinh], [SDT], [DiaChi]) VALUES (N'SV005', N'Võ Thị Bích Trăm', N'Nữ', CAST(N'2000-12-19T00:00:00.000' AS DateTime), N'0898989898', N'Đồng Tháp')
INSERT [dbo].[SINHVIEN] ([MSSV], [HoTen], [GioiTinh], [NgaySinh], [SDT], [DiaChi]) VALUES (N'SV006', N'Phạm Nguyễn Thanh Duy', N'Nam', CAST(N'2000-01-09T00:00:00.000' AS DateTime), N'0898989898', N'Đồng Tháp')
INSERT [dbo].[SINHVIEN] ([MSSV], [HoTen], [GioiTinh], [NgaySinh], [SDT], [DiaChi]) VALUES (N'SV007', N'Nguyễn Minh Mẫn', N'Nam', CAST(N'2000-05-03T00:00:00.000' AS DateTime), N'0787878787', N'Đồng Tháp')
GO
ALTER TABLE [dbo].[HOPDONG]  WITH CHECK ADD  CONSTRAINT [FK_HOPDONG_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[HOPDONG] CHECK CONSTRAINT [FK_HOPDONG_NHANVIEN]
GO
ALTER TABLE [dbo].[HOPDONG]  WITH CHECK ADD  CONSTRAINT [FK_HOPDONG_PHONG] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[PHONG] ([MaPhong])
GO
ALTER TABLE [dbo].[HOPDONG] CHECK CONSTRAINT [FK_HOPDONG_PHONG]
GO
ALTER TABLE [dbo].[HOPDONG]  WITH CHECK ADD  CONSTRAINT [FK_HOPDONG_SINHVIEN] FOREIGN KEY([MSSV])
REFERENCES [dbo].[SINHVIEN] ([MSSV])
GO
ALTER TABLE [dbo].[HOPDONG] CHECK CONSTRAINT [FK_HOPDONG_SINHVIEN]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_DANGNHAP] FOREIGN KEY([MaNV])
REFERENCES [dbo].[DANGNHAP] ([MaNV])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_DANGNHAP]
GO
