USE [QuanLyST]
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 18/5/2024 6:52:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[maChucVu] [nvarchar](30) NOT NULL,
	[tenChucVu] [nvarchar](50) NOT NULL,
	[moTa] [nvarchar](100) NULL,
 CONSTRAINT [PK_ChucVu] PRIMARY KEY CLUSTERED 
(
	[maChucVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 18/5/2024 6:52:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[maHD] [nvarchar](30) NOT NULL,
	[maNV] [nvarchar](30) NOT NULL,
	[maKH] [nvarchar](30) NOT NULL,
	[ngayLap] [date] NOT NULL,
	[ghiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[maHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDonChiTiet]    Script Date: 18/5/2024 6:52:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonChiTiet](
	[maSP] [nvarchar](30) NOT NULL,
	[soLuong] [int] NOT NULL,
	[donGia] [money] NOT NULL,
	[maHD] [nvarchar](30) NOT NULL,
	[thanhTien] [money] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 18/5/2024 6:52:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[maKH] [nvarchar](30) NOT NULL,
	[tenKH] [nvarchar](50) NOT NULL,
	[ngaySinh] [date] NOT NULL,
	[email] [nvarchar](60) NOT NULL,
	[dienThoai] [nvarchar](50) NOT NULL,
	[diaChi] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK__CUSTOMER__CD65CB857F60ED59] PRIMARY KEY CLUSTERED 
(
	[maKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhuyenMai]    Script Date: 18/5/2024 6:52:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhuyenMai](
	[maKM] [nvarchar](30) NOT NULL,
	[phanTramKhuyenMai] [float] NOT NULL,
	[ngayBatDau] [date] NOT NULL,
	[ngayKetthuc] [date] NOT NULL,
	[maKH] [nvarchar](30) NOT NULL,
	[moTa] [nvarchar](100) NULL,
 CONSTRAINT [PK__DISCOUNT__80B6FFA8117F9D94] PRIMARY KEY CLUSTERED 
(
	[maKM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiSanPham]    Script Date: 18/5/2024 6:52:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSanPham](
	[maLoaiSP] [nvarchar](30) NOT NULL,
	[tenLoaiSP] [nvarchar](50) NOT NULL,
	[moTa] [nvarchar](100) NULL,
 CONSTRAINT [PK__CATEGORI__D54EE9B4164452B1] PRIMARY KEY CLUSTERED 
(
	[maLoaiSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 18/5/2024 6:52:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[maNhaCC] [nvarchar](30) NOT NULL,
	[tenNhaCC] [nvarchar](50) NOT NULL,
	[diaChi] [nvarchar](50) NOT NULL,
	[dienThoai] [nvarchar](15) NOT NULL,
	[email] [nvarchar](60) NOT NULL,
 CONSTRAINT [PK__STOCK__E86668621DE57479] PRIMARY KEY CLUSTERED 
(
	[maNhaCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 18/5/2024 6:52:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[maNV] [nvarchar](30) NOT NULL,
	[hoTen] [nvarchar](50) NOT NULL,
	[ngaySinh] [date] NOT NULL,
	[gioiTinh] [nvarchar](5) NOT NULL,
	[dienThoai] [nvarchar](15) NOT NULL,
	[maChucVu] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK__ORDERS__465962290CBAE877] PRIMARY KEY CLUSTERED 
(
	[maNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 18/5/2024 6:52:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[maPhieuNhap] [nvarchar](30) NOT NULL,
	[maNCC] [nvarchar](30) NOT NULL,
	[maNV] [nvarchar](30) NOT NULL,
	[ngayNhap] [date] NOT NULL,
 CONSTRAINT [PK_PhieuNhap] PRIMARY KEY CLUSTERED 
(
	[maPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhapChiTiet]    Script Date: 18/5/2024 6:52:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhapChiTiet](
	[maSP] [nvarchar](30) NOT NULL,
	[soLuong] [int] NOT NULL,
	[donGia] [money] NOT NULL,
	[maPhieuNhap] [nvarchar](30) NOT NULL,
	[thanhTien] [money] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 18/5/2024 6:52:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[maSP] [nvarchar](30) NOT NULL,
	[tenSP] [varchar](60) NOT NULL,
	[maLoaiSP] [nvarchar](30) NOT NULL,
	[soLuongTon] [int] NOT NULL,
	[mauSac] [nvarchar](10) NULL,
	[ngaySX] [date] NOT NULL,
	[ngayHH] [date] NOT NULL,
	[maThuongHieu] [nvarchar](30) NOT NULL,
	[donGia] [money] NOT NULL,
	[kichThuoc] [nvarchar](30) NOT NULL,
	[moTa] [nvarchar](100) NULL,
 CONSTRAINT [PK__PRODUCT__47027DF521B6055D] PRIMARY KEY CLUSTERED 
(
	[maSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 18/5/2024 6:52:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[taiKhoan] [nvarchar](60) NOT NULL,
	[matKhau] [nvarchar](60) NOT NULL,
	[maChucVu] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[taiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThuongHieu]    Script Date: 18/5/2024 6:52:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThuongHieu](
	[maThuongHieu] [nvarchar](30) NOT NULL,
	[tenThuongHieu] [varchar](255) NOT NULL,
	[quocGia] [nvarchar](30) NOT NULL,
	[moTa] [nvarchar](100) NULL,
 CONSTRAINT [PK__BRANDS__5E5A8E271A14E395] PRIMARY KEY CLUSTERED 
(
	[maThuongHieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChucVu] ([maChucVu], [tenChucVu], [moTa]) VALUES (N'001', N'Quản lý', N'Chịu trách nhiệm quản lý toàn bộ hoạt động')
INSERT [dbo].[ChucVu] ([maChucVu], [tenChucVu], [moTa]) VALUES (N'002', N'Nhân viên', N'Thực hiện các nhiệm vụ theo chỉ đạo cụ thể')
INSERT [dbo].[ChucVu] ([maChucVu], [tenChucVu], [moTa]) VALUES (N'003', N'Nhân viên', N'aaa')
GO
INSERT [dbo].[HoaDon] ([maHD], [maNV], [maKH], [ngayLap], [ghiChu]) VALUES (N'HD1', N'NV1', N'KH1', CAST(N'2024-05-04' AS Date), N'')
INSERT [dbo].[HoaDon] ([maHD], [maNV], [maKH], [ngayLap], [ghiChu]) VALUES (N'HD2', N'NV2', N'KH2', CAST(N'2024-05-06' AS Date), N'')
INSERT [dbo].[HoaDon] ([maHD], [maNV], [maKH], [ngayLap], [ghiChu]) VALUES (N'HD3', N'NV1', N'KH2', CAST(N'2024-11-05' AS Date), N'')
GO
INSERT [dbo].[HoaDonChiTiet] ([maSP], [soLuong], [donGia], [maHD], [thanhTien]) VALUES (N'SP1', 2, 10000.0000, N'HD1', 20000.0000)
INSERT [dbo].[HoaDonChiTiet] ([maSP], [soLuong], [donGia], [maHD], [thanhTien]) VALUES (N'SP2', 1, 10000.0000, N'HD1', 10000.0000)
INSERT [dbo].[HoaDonChiTiet] ([maSP], [soLuong], [donGia], [maHD], [thanhTien]) VALUES (N'SP3', 5, 10000.0000, N'HD2', 30000.0000)
GO
INSERT [dbo].[KhachHang] ([maKH], [tenKH], [ngaySinh], [email], [dienThoai], [diaChi]) VALUES (N'KH1', N'Đinh Quang Trọng', CAST(N'2003-10-29' AS Date), N'quangtrongg03@gmail.com', N'0352581845', N'Yên Định, Thanh Hóa')
INSERT [dbo].[KhachHang] ([maKH], [tenKH], [ngaySinh], [email], [dienThoai], [diaChi]) VALUES (N'KH2', N'Đinh Quang Trong', CAST(N'2003-10-29' AS Date), N'qua', N'0352', N'yyy')
GO
INSERT [dbo].[KhuyenMai] ([maKM], [phanTramKhuyenMai], [ngayBatDau], [ngayKetthuc], [maKH], [moTa]) VALUES (N'KM001', 20, CAST(N'2014-06-01' AS Date), CAST(N'2024-08-31' AS Date), N'KH1', N'Khuyến mãi hè 2024 - Giảm giá 20% cho tất cả sản phẩm mùa hè')
INSERT [dbo].[KhuyenMai] ([maKM], [phanTramKhuyenMai], [ngayBatDau], [ngayKetthuc], [maKH], [moTa]) VALUES (N'KM002', 10, CAST(N'2023-12-15' AS Date), CAST(N'2023-12-31' AS Date), N'KH2', N'Sinh nhật cửa hàng - Tặng quà cho khách hàng vào ngày sinh nhật')
INSERT [dbo].[KhuyenMai] ([maKM], [phanTramKhuyenMai], [ngayBatDau], [ngayKetthuc], [maKH], [moTa]) VALUES (N'KM003', 50, CAST(N'2023-06-03' AS Date), CAST(N'2023-06-18' AS Date), N'KH1', N'Black Friday Sale - Giảm giá đặc biệt vào ngày Black Friday')
INSERT [dbo].[KhuyenMai] ([maKM], [phanTramKhuyenMai], [ngayBatDau], [ngayKetthuc], [maKH], [moTa]) VALUES (N'KM004', 10, CAST(N'2024-05-05' AS Date), CAST(N'2024-09-05' AS Date), N'KH2', N'Giảm giá 10% cho tất cả sản phẩm mùa hè')
INSERT [dbo].[KhuyenMai] ([maKM], [phanTramKhuyenMai], [ngayBatDau], [ngayKetthuc], [maKH], [moTa]) VALUES (N'KM005', 20, CAST(N'2024-01-02' AS Date), CAST(N'2024-01-28' AS Date), N'KH1', N'Ưu đãi đặc biệt dành cho mùa lễ hội, giảm giá 20% cho các sản phẩm được chọn lọc')
GO
INSERT [dbo].[LoaiSanPham] ([maLoaiSP], [tenLoaiSP], [moTa]) VALUES (N'L1', N'Điện', N'Loại sản phẩm điện tử')
INSERT [dbo].[LoaiSanPham] ([maLoaiSP], [tenLoaiSP], [moTa]) VALUES (N'L2', N'Dịch vụ', N'Dịch vụ giao hàng, khu vui chơi trẻ em, gửi xe, ...')
INSERT [dbo].[LoaiSanPham] ([maLoaiSP], [tenLoaiSP], [moTa]) VALUES (N'L3', N'Phụ kiện', N'Phụ kiện điện tử')
INSERT [dbo].[LoaiSanPham] ([maLoaiSP], [tenLoaiSP], [moTa]) VALUES (N'L4', N'Quần áo', N'Đồ nam, nữ')
INSERT [dbo].[LoaiSanPham] ([maLoaiSP], [tenLoaiSP], [moTa]) VALUES (N'L5', N'Sách', N'Các loại sách, truyện, tài liệu')
INSERT [dbo].[LoaiSanPham] ([maLoaiSP], [tenLoaiSP], [moTa]) VALUES (N'L6', N'Thiết bị', N'Đồ gia dụng, làm bếp, ...')
INSERT [dbo].[LoaiSanPham] ([maLoaiSP], [tenLoaiSP], [moTa]) VALUES (N'L7', N'Hàng tiêu dùng', N'Sử dụng hàng ngày: kem đánh răng, khăn,...')
INSERT [dbo].[LoaiSanPham] ([maLoaiSP], [tenLoaiSP], [moTa]) VALUES (N'L8', N'Thực phẩm', N'Thực phẩm tươi sống, đóng hôp, rau củ, đồ ăn nhanh, ...')
GO
INSERT [dbo].[NhaCungCap] ([maNhaCC], [tenNhaCC], [diaChi], [dienThoai], [email]) VALUES (N'NCC1', N'ABC Company', N'Yên Định, Thanh Hóa', N'0123 456 789', N'abc@example.com')
INSERT [dbo].[NhaCungCap] ([maNhaCC], [tenNhaCC], [diaChi], [dienThoai], [email]) VALUES (N'NCC2', N'XYZ Supply', N'Yên Định, Thanh Hóa', N'0352581845', N'quangtrongg03@gmail.com')
INSERT [dbo].[NhaCungCap] ([maNhaCC], [tenNhaCC], [diaChi], [dienThoai], [email]) VALUES (N'NCC3', N'LMN Corp', N'Yên Định, Thanh Hóa', N'0387168478', N'2121050483@student.humg.edu.vn')
GO
INSERT [dbo].[NhanVien] ([maNV], [hoTen], [ngaySinh], [gioiTinh], [dienThoai], [maChucVu]) VALUES (N'NV1', N'Nguyễn Văn A', CAST(N'1990-05-15' AS Date), N'Nam', N'0123456789', N'002')
INSERT [dbo].[NhanVien] ([maNV], [hoTen], [ngaySinh], [gioiTinh], [dienThoai], [maChucVu]) VALUES (N'NV2', N' Trần Thị B', CAST(N'1988-12-20' AS Date), N'Nữ', N'0987654321', N'001')
GO
INSERT [dbo].[PhieuNhap] ([maPhieuNhap], [maNCC], [maNV], [ngayNhap]) VALUES (N'PN1', N'NCC1', N'NV1', CAST(N'2024-05-01' AS Date))
INSERT [dbo].[PhieuNhap] ([maPhieuNhap], [maNCC], [maNV], [ngayNhap]) VALUES (N'PN2', N'NCC1', N'NV2', CAST(N'2024-05-02' AS Date))
INSERT [dbo].[PhieuNhap] ([maPhieuNhap], [maNCC], [maNV], [ngayNhap]) VALUES (N'PN3', N'NCC3', N'NV1', CAST(N'2024-05-03' AS Date))
GO
INSERT [dbo].[PhieuNhapChiTiet] ([maSP], [soLuong], [donGia], [maPhieuNhap], [thanhTien]) VALUES (N'SP1', 3, 10000.0000, N'PN1', 30000.0000)
INSERT [dbo].[PhieuNhapChiTiet] ([maSP], [soLuong], [donGia], [maPhieuNhap], [thanhTien]) VALUES (N'SP2', 1, 50000.0000, N'PN1', 50000.0000)
INSERT [dbo].[PhieuNhapChiTiet] ([maSP], [soLuong], [donGia], [maPhieuNhap], [thanhTien]) VALUES (N'SP3', 3, 10000.0000, N'PN1', 30000.0000)
INSERT [dbo].[PhieuNhapChiTiet] ([maSP], [soLuong], [donGia], [maPhieuNhap], [thanhTien]) VALUES (N'SP2', 1, 10000.0000, N'PN2', 10000.0000)
GO
INSERT [dbo].[SanPham] ([maSP], [tenSP], [maLoaiSP], [soLuongTon], [mauSac], [ngaySX], [ngayHH], [maThuongHieu], [donGia], [kichThuoc], [moTa]) VALUES (N'SP1', N'Kem dánh rang PS', N'L7', 4, N'', CAST(N'2003-10-01' AS Date), CAST(N'2026-10-01' AS Date), N'TH007', 10000.0000, N'Nh?', N'')
INSERT [dbo].[SanPham] ([maSP], [tenSP], [maLoaiSP], [soLuongTon], [mauSac], [ngaySX], [ngayHH], [maThuongHieu], [donGia], [kichThuoc], [moTa]) VALUES (N'SP2', N'Thân dông dât viêt', N'L5', 2, N'', CAST(N'1999-02-02' AS Date), CAST(N'2222-02-02' AS Date), N'TH009', 10000.0000, N'Nh?', N'')
INSERT [dbo].[SanPham] ([maSP], [tenSP], [maLoaiSP], [soLuongTon], [mauSac], [ngaySX], [ngayHH], [maThuongHieu], [donGia], [kichThuoc], [moTa]) VALUES (N'SP3', N'Samsung Galaxy S11', N'L1', 7, N'', CAST(N'2020-02-02' AS Date), CAST(N'2222-02-02' AS Date), N'TH001', 10000.0000, N'Nhỏ', N'')
INSERT [dbo].[SanPham] ([maSP], [tenSP], [maLoaiSP], [soLuongTon], [mauSac], [ngaySX], [ngayHH], [maThuongHieu], [donGia], [kichThuoc], [moTa]) VALUES (N'SP4', N'ss', N'L1', 1, N'', CAST(N'2020-02-02' AS Date), CAST(N'2222-02-02' AS Date), N'TH001', 10000.0000, N'Nhỏ', N'')
GO
INSERT [dbo].[TaiKhoan] ([taiKhoan], [matKhau], [maChucVu]) VALUES (N'admin', N'123', N'001')
INSERT [dbo].[TaiKhoan] ([taiKhoan], [matKhau], [maChucVu]) VALUES (N'NhanVien', N'123', N'002')
GO
INSERT [dbo].[ThuongHieu] ([maThuongHieu], [tenThuongHieu], [quocGia], [moTa]) VALUES (N'TH001', N'Samsung', N'Hàn Quốc', N'Thương hiệu nổi tiếng')
INSERT [dbo].[ThuongHieu] ([maThuongHieu], [tenThuongHieu], [quocGia], [moTa]) VALUES (N'TH002', N'Apple', N'Mỹ', N'')
INSERT [dbo].[ThuongHieu] ([maThuongHieu], [tenThuongHieu], [quocGia], [moTa]) VALUES (N'TH003', N'Adidas', N'Đức', N'Thương hiệu thời trang thể thao')
INSERT [dbo].[ThuongHieu] ([maThuongHieu], [tenThuongHieu], [quocGia], [moTa]) VALUES (N'TH004', N'Nike', N'Mỹ', N'Thương hiệu thể thao hàng đầu')
INSERT [dbo].[ThuongHieu] ([maThuongHieu], [tenThuongHieu], [quocGia], [moTa]) VALUES (N'TH005', N'Sony', N'Nhật Bản', N'Chuyên sản xuất đò điện tử và giải trí')
INSERT [dbo].[ThuongHieu] ([maThuongHieu], [tenThuongHieu], [quocGia], [moTa]) VALUES (N'Th006', N'Vinamilk', N'Việt Nam', N'Chuyên sản xuất sữa')
INSERT [dbo].[ThuongHieu] ([maThuongHieu], [tenThuongHieu], [quocGia], [moTa]) VALUES (N'TH007', N'Unilever', N'Hà Lan', N'Tập đoàn tiêu dùng toàn cầu')
INSERT [dbo].[ThuongHieu] ([maThuongHieu], [tenThuongHieu], [quocGia], [moTa]) VALUES (N'TH008', N'Panasonic', N'Nhật Bản', N'Nổi tiếng với các thiết bị điện tử gia dụng và công nghệ')
INSERT [dbo].[ThuongHieu] ([maThuongHieu], [tenThuongHieu], [quocGia], [moTa]) VALUES (N'TH009', N'Kim Ðông', N'Việt Nam', N'Nhà xuất bản sách')
INSERT [dbo].[ThuongHieu] ([maThuongHieu], [tenThuongHieu], [quocGia], [moTa]) VALUES (N'TH010', N'Zara', N'Tây Ban Nha', N'Thương hiệu thời trang')
INSERT [dbo].[ThuongHieu] ([maThuongHieu], [tenThuongHieu], [quocGia], [moTa]) VALUES (N'TH011', N'Ray-Ban', N'Mỹ ', N'Thương hiệu kính mắt hàng đầu')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__CUSTOMER__AB6E6164023D5A04]    Script Date: 18/5/2024 6:52:11 PM ******/
ALTER TABLE [dbo].[KhachHang] ADD  CONSTRAINT [UQ__CUSTOMER__AB6E6164023D5A04] UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UC_MaPN]    Script Date: 18/5/2024 6:52:11 PM ******/
ALTER TABLE [dbo].[PhieuNhap] ADD  CONSTRAINT [UC_MaPN] UNIQUE NONCLUSTERED 
(
	[maPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([maKH])
REFERENCES [dbo].[KhachHang] ([maKH])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([maNV])
REFERENCES [dbo].[NhanVien] ([maNV])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO
ALTER TABLE [dbo].[HoaDonChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonChiTiet_HoaDon1] FOREIGN KEY([maHD])
REFERENCES [dbo].[HoaDon] ([maHD])
GO
ALTER TABLE [dbo].[HoaDonChiTiet] CHECK CONSTRAINT [FK_HoaDonChiTiet_HoaDon1]
GO
ALTER TABLE [dbo].[KhuyenMai]  WITH CHECK ADD  CONSTRAINT [FK_KhuyenMai_KhachHang] FOREIGN KEY([maKH])
REFERENCES [dbo].[KhachHang] ([maKH])
GO
ALTER TABLE [dbo].[KhuyenMai] CHECK CONSTRAINT [FK_KhuyenMai_KhachHang]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_ChucVu] FOREIGN KEY([maChucVu])
REFERENCES [dbo].[ChucVu] ([maChucVu])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_ChucVu]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_NhaCungCap] FOREIGN KEY([maNCC])
REFERENCES [dbo].[NhaCungCap] ([maNhaCC])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NhaCungCap]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_NhanVien] FOREIGN KEY([maNV])
REFERENCES [dbo].[NhanVien] ([maNV])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NhanVien]
GO
ALTER TABLE [dbo].[PhieuNhapChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhapChiTiet_PhieuNhap] FOREIGN KEY([maPhieuNhap])
REFERENCES [dbo].[PhieuNhap] ([maPhieuNhap])
GO
ALTER TABLE [dbo].[PhieuNhapChiTiet] CHECK CONSTRAINT [FK_PhieuNhapChiTiet_PhieuNhap]
GO
ALTER TABLE [dbo].[PhieuNhapChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhapChiTiet_SanPham] FOREIGN KEY([maSP])
REFERENCES [dbo].[SanPham] ([maSP])
GO
ALTER TABLE [dbo].[PhieuNhapChiTiet] CHECK CONSTRAINT [FK_PhieuNhapChiTiet_SanPham]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_LoaiSanPham] FOREIGN KEY([maLoaiSP])
REFERENCES [dbo].[LoaiSanPham] ([maLoaiSP])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_LoaiSanPham]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_ThuongHieu] FOREIGN KEY([maThuongHieu])
REFERENCES [dbo].[ThuongHieu] ([maThuongHieu])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_ThuongHieu]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_ChucVu] FOREIGN KEY([maChucVu])
REFERENCES [dbo].[ChucVu] ([maChucVu])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_ChucVu]
GO
ALTER TABLE [dbo].[PhieuNhapChiTiet]  WITH CHECK ADD  CONSTRAINT [CK_PhieuNhapChiTiet] CHECK  (([thanhTien]=[soLuong]*[donGia]))
GO
ALTER TABLE [dbo].[PhieuNhapChiTiet] CHECK CONSTRAINT [CK_PhieuNhapChiTiet]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'thanhTien=donGia*soLuong' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PhieuNhapChiTiet', @level2type=N'COLUMN',@level2name=N'thanhTien'
GO
