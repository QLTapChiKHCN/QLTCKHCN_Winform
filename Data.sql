CREATE DATABASE QL_TCKHCN;
GO

USE QL_TCKHCN;
GO

-- Tạo bảng NgonNgu
CREATE TABLE NgonNgu (
    MaNgonNgu varchar(10) PRIMARY KEY,
    TenNgonNgu nvarchar(50)
);
GO
-- Tạo bảng ChuyenMuc
CREATE TABLE ChuyenMuc (
    MaChuyenMuc varchar(10) PRIMARY KEY,
    TenChuyenMuc nvarchar(100)
);
GO
-- Tạo bảng SoTapChi
CREATE TABLE SoTapChi (
    MaSoTC varchar(10) PRIMARY KEY,
    TenSo nvarchar(100),
    AnhBia nvarchar(200),
    AnhBiaLocal nvarchar(200),
    NgayXuatBan date,
	TrangThai bit
);
GO
-- Tạo bảng HocVi
CREATE TABLE HocVi (
    MaHocVi varchar(10) PRIMARY KEY,
    TenHocVi nvarchar(50)
);
GO
-- Tạo bảng HocHam
CREATE TABLE HocHam (
    MaHocHam varchar(10) PRIMARY KEY,
    TenHocHam nvarchar(50)
);
GO
-- Tạo bảng VaiTro
CREATE TABLE VaiTro (
    MaVaiTro varchar(10) PRIMARY KEY,
    TenVaiTro nvarchar(50)
);
GO
-- Tạo bảng LoaiTacGia
CREATE TABLE LoaiTacGia (
    MaLTacGia varchar(10) PRIMARY KEY,
    TenLoai nvarchar(50)
);
GO
CREATE TABLE ChuyenNganh(
   MaChuyenNganh varchar(10) Primary key,
   TenChuyenNganh nvarchar(50)
);
Go
CREATE TABLE DonVi(
	MaDonVi varchar(10) primary key,
	TenDonVi nvarchar(50)
	);
Go
CREATE TABLE QuocGia(
	MaQG varchar(10) primary key,
	TenQG nvarchar(50)
	);
go
-- Tạo bảng NguoiDung
CREATE TABLE NguoiDung (
    MaNguoiDung varchar(10) PRIMARY KEY,
    MaHocVi varchar(10) FOREIGN KEY REFERENCES HocVi(MaHocVi),
    MaHocHam varchar(10) FOREIGN KEY REFERENCES HocHam(MaHocHam),
    MaDonVi varchar(10) FOREIGN KEY REFERENCES DonVi(MaDonVi),
    MaChuyenNganh varchar(10) FOREIGN KEY REFERENCES ChuyenNganh(MaChuyenNganh),
    MaQG varchar(10) FOREIGN KEY REFERENCES QuocGia(MaQG),
    TenDangNhap varchar(50),
    MatKhau varchar(100),
    HoTen nvarchar(100),
    Email varchar(100),
    CCCD varchar(12),
    SoDienThoai varchar(15),
    DiaChi nvarchar(200),
    GioiTinh nvarchar(10)
);
GO
-- Tạo bảng NguoiDung_VaiTro
CREATE TABLE NguoiDung_VaiTro (
    MaNguoiDung varchar(10),
    MaVaiTro varchar(10),
    PRIMARY KEY (MaNguoiDung, MaVaiTro),
    FOREIGN KEY (MaNguoiDung) REFERENCES NguoiDung(MaNguoiDung),
    FOREIGN KEY (MaVaiTro) REFERENCES VaiTro(MaVaiTro)
);		
GO
-- Tạo bảng BaiViet
CREATE TABLE BaiViet (
    MaBaiBao char(10) PRIMARY KEY,
    MaNgonNgu varchar(10) FOREIGN KEY REFERENCES NgonNgu(MaNgonNgu) NOT NULL,
    MaSoTC varchar(10) FOREIGN KEY REFERENCES SoTapChi(MaSoTC),
    MaChuyenMuc varchar(10) FOREIGN KEY REFERENCES ChuyenMuc(MaChuyenMuc),
    TieuDe nvarchar(200),
    TenBaiBao nvarchar(300),
	TenBaiBaoTiengAnh varchar(300),
	TomTat nvarchar(Max),
	TomTatTiengAnh varchar(Max),
    NgayXetDuyet date,
    NgayGui date,
    TuKhoa nvarchar(200),
	TuKhoaTiengAnh nvarchar(200),
    FileBaiViet nvarchar(255),
    TrangThai nvarchar(50)
);
-- Tạo bảng ChiTietBaiViet
CREATE TABLE ChiTietBaiViet (
    MaBaiBao char(10),
    MaNguoiDung varchar(10),
    MaLTacGia varchar(10),
    PRIMARY KEY (MaBaiBao, MaNguoiDung, MaLTacGia),
    FOREIGN KEY (MaBaiBao) REFERENCES BaiViet(MaBaiBao),
    FOREIGN KEY (MaNguoiDung) REFERENCES NguoiDung(MaNguoiDung),
    FOREIGN KEY (MaLTacGia) REFERENCES LoaiTacGia(MaLTacGia)
);
GO
-- Tạo bảng ChiTietPhanBien
CREATE TABLE ChiTietPhanBien (
    MaChiTietPhanBien INT IDENTITY(1,1) PRIMARY KEY,
    MaBaiBao char(10),
    MaNguoiDung varchar(10),
    KetQuaPhanBien nvarchar(50),
    YKienPhanBien ntext,
    NgayNhan date,
    NgayHetHan date,
    NgayTraKetQua date null,
    FilePhanBien varchar(255),
    FOREIGN KEY (MaBaiBao) REFERENCES BaiViet(MaBaiBao),
    FOREIGN KEY (MaNguoiDung) REFERENCES NguoiDung(MaNguoiDung)
);
CREATE TABLE LichSuSoDuyetBaiViet(
	MaBaiBao char(10),
	MaNguoiDung varchar(10),
	NgayGuiYeuCau date,
	NgayChinhSua date,
	NoiDungChinhSua nvarchar(500),
	PRIMARY KEY(MaBaiBao, MaNguoiDung, NgayGuiYeuCau),
	FOREIGN KEY (MaBaiBao) REFERENCES BaiViet(MaBaiBao),
	FOREIGN KEY (MaNguoiDung) REFERENCES NguoiDung(MaNguoiDung)
)
Go
CREATE TABLE PhanHoi(
	MaBaiBao char(10),
	MaNguoiDung varchar(10),
	NgayGui date,
	NoiDung nvarchar(500),
	FileBienSoan varchar(255),
	PRIMARY KEY(MaBaiBao, MaNguoiDung, NgayGui),
	FOREIGN KEY (MaBaiBao) REFERENCES BaiViet(MaBaiBao),
	FOREIGN KEY (MaNguoiDung) REFERENCES NguoiDung(MaNguoiDung)
	)
Go
-- Tạo bảng LichSuChonNguoiPhanBien
CREATE TABLE LichSuChonNguoiPhanBien (
    MaLichSuChonPhanBien INT IDENTITY(1,1) PRIMARY KEY,
    MaNguoiDung varchar(10),
    MaBaiBao char(10),
    NgayGuiYeuCau date,	
    TrangThai nvarchar(50),
    TrangThaiTBT nvarchar(50),
    FOREIGN KEY (MaNguoiDung) REFERENCES NguoiDung(MaNguoiDung),
    FOREIGN KEY (MaBaiBao) REFERENCES BaiViet(MaBaiBao)
);
GO

---Insert dữ liệu
INSERT INTO NgonNgu (MaNgonNgu, TenNgonNgu) VALUES
('NN01', N'Tiếng Việt'),
('NN02', N'English')
go
INSERT INTO ChuyenMuc (MaChuyenMuc, TenChuyenMuc) VALUES
('CM01', N'KHOA HỌC - CÔNG NGHỆ'),
('CM02', N'QUẢN LÝ KINH TẾ')
INSERT INTO HocVi (MaHocVi, TenHocVi) VALUES
('HV01', N'Cử nhân'),
('HV02', N'Kỹ sư'),
('HV03', N'Thạc sĩ'),
('HV04', N'Tiến sĩ')
INSERT INTO HocHam (MaHocHam, TenHocHam) VALUES
('HH01', N'Giáo sư'),
('HH02', N'Phó giáo sư');
INSERT INTO VaiTro (MaVaiTro, TenVaiTro) VALUES
('VT01', N'Biên tập viên'),
('VT02', N'Tổng biên tập'),
('VT03', N'Tác giả'),
('VT04', N'Phản biện')
INSERT INTO ChuyenNganh (MaChuyenNganh, TenChuyenNganh) VALUES
('CN01', N'Công nghệ thông tin'),
('CN02', N'Y học'),
('CN03', N'Giáo dục'),
('CN04', N'Khoa học xã hội'),
('CN05', N'Văn hóa nghệ thuật');

-- Dữ liệu cho bảng DonVi
INSERT INTO DonVi (MaDonVi, TenDonVi) VALUES
('DV01', N'Trường Đại học'),
('DV02', N'Bệnh viện'),
('DV03', N'Trường Cao đẳng');

-- Dữ liệu cho bảng QuocGia
INSERT INTO QuocGia (MaQG, TenQG) VALUES
('VN', N'Việt Nam'),
('US', N'Hoa Kỳ');

-- pass của user1 là pass1, user2 là pass2, user3 trở đi là pass3
INSERT INTO NguoiDung (MaNguoiDung, MaHocVi, MaHocHam, MaDonVi, MaChuyenNganh, MaQG, TenDangNhap, MatKhau, HoTen, Email, CCCD, SoDienThoai, DiaChi, GioiTinh) VALUES
('ND01', 'HV01', 'HH02', 'DV01', 'CN01', 'VN', 'user1', 'a722c63db8ec8625af6cf71cb8c2d939', N'Nguyễn Văn A', 'a@example.com', '123456789012', '0123456789', N'Hà Nội', N'Nam'),
('ND02', 'HV02', 'HH01', 'DV02', 'CN02', 'VN', 'user2', 'c1572d05424d0ecb2a65ec6a82aeacbf', N'Trần Thị B', 'b@example.com', '123456789013', '0123456788', N'Hồ Chí Minh', N'Nữ'),
('ND03', 'HV03', 'HH02', 'DV01', 'CN03', 'VN', 'user3', '$2y$10$9avnS2fYg7YHsFGcmq/5yOp72dSi3ty8Tfe02ETjog286rugZxWE', N'Lê Văn C', 'c@example.com', '123456789014', '0123456787', N'Đà Nẵng', N'Nam'),
('ND04', 'HV04', 'HH01', 'DV03', 'CN04', 'VN', 'user4', '$2y$10$9avnS2fYg7YHsFGcmq/5yOp72dSi3ty8Tfe02ETjog286rugZxWE', N'Phạm Thị D', 'd@example.com', '123456789015', '0123456786', N'Hải Phòng', N'Nữ'),
('ND05', 'HV01', 'HH02', 'DV01', 'CN05', 'VN', 'user5', '$2y$10$9avnS2fYg7YHsFGcmq/5yOp72dSi3ty8Tfe02ETjog286rugZxWE', N'Nguyễn Văn E', 'e@example.com', '123456789016', '0123456785', N'Cần Thơ', N'Nam');


INSERT INTO NguoiDung_VaiTro (MaNguoiDung, MaVaiTro) VALUES
('ND01', 'VT01'),  -- Nguyễn Văn A là Biên tập viên
('ND02', 'VT02'),  -- Trần Thị B là Tổng biên tập
('ND03', 'VT03'),  -- Lê Văn C là Tác giả
('ND03', 'VT04'),  -- Lê Văn C là Người phản biện
('ND05', 'VT04'),  -- Nguyễn Văn E là Người phản biện
('ND05', 'VT03'),
('ND04', 'VT03'),
('ND04', 'VT04');

INSERT INTO LoaiTacGia (MaLTacGia, TenLoai) VALUES
('LTG01', N'Tác giả chính'),
('LTG02', N'Hỗ trợ'),
('LTG03', N'Tác giả chính'),
('LTG04', N'Tác giả liên hệ'),
('LTG05', N'Thành viên'),
('LTG06', N'Thư ký');

-- trigger cập nhật ngày hết hạn
CREATE TRIGGER trg_SetNgayHetHan
ON ChiTietPhanBien
AFTER INSERT, UPDATE
AS
BEGIN
    UPDATE cp
    SET NgayHetHan = DATEADD(DAY, 10, i.NgayNhan)
    FROM ChiTietPhanBien cp
    JOIN inserted i ON cp.MaBaiBao = i.MaBaiBao AND cp.MaNguoiDung = i.MaNguoiDung
    WHERE i.NgayNhan IS NOT NULL;
END;
GO

-- Trigger cập nhật trạng thái nếu phản biện không trl 
CREATE TRIGGER trg_UpdateTrangThai
ON LichSuChonNguoiPhanBien
AFTER INSERT, UPDATE
AS
BEGIN
    -- Cập nhật TrangThai thành "Từ chối" nếu quá 3 ngày và vẫn là "Chờ phản hồi"
    UPDATE LichSuChonNguoiPhanBien
    SET TrangThai = N'Từ chối'
    WHERE TrangThai = N'Chờ phản hồi' 
      AND DATEDIFF(DAY, NgayGuiYeuCau, GETDATE()) > 3;
END;
GO

--trigger từ chối bài viết nếu quá hạn chỉnh sửa
CREATE OR ALTER TRIGGER trg_TuChoiBaiVietQuaHan
ON LichSuSoDuyetBaiViet
AFTER INSERT, UPDATE
AS
BEGIN
    -- Cập nhật trạng thái bài viết thành "Từ chối" 
    UPDATE BaiViet
    SET TrangThai = N'Từ chối'
    FROM BaiViet bv
    INNER JOIN LichSuSoDuyetBaiViet ls ON bv.MaBaiBao = ls.MaBaiBao
    WHERE 
        DATEDIFF(DAY, ls.NgayGuiYeuCau, GETDATE()) > 5  -- Quá 5 ngày từ ngày yêu cầu
        AND (
            ls.NgayChinhSua IS NULL  -- Chưa chỉnh sửa
            OR ls.NgayChinhSua < ls.NgayGuiYeuCau  -- Hoặc ngày chỉnh sửa cũ hơn ngày yêu cầu
        )
        AND bv.TrangThai = N'Chỉnh sửa';
END;
go
-- Trigger đồng ý duyệt phản biện nếu quá 3 ngày chưa
CREATE OR ALTER TRIGGER trg_DongYDuyetPhanBien_TBT
ON LichSuChonNguoiPhanBien
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @TriggerExecuted BIT;
    SET @TriggerExecuted = 0;

    -- Kiểm tra nếu trigger đã chạy
    IF (SELECT COUNT(*) FROM inserted) > 0
    BEGIN
        SET @TriggerExecuted = 1;
    END

    IF @TriggerExecuted = 1
    BEGIN
        -- Cập nhật trạng thái bên lịch sử chọn người phản biện TrangThaiTBT thành đồng ý 
        UPDATE LichSuChonNguoiPhanBien
        SET TrangThaiTBT = N'Đồng ý'
        FROM LichSuChonNguoiPhanBien ls
        WHERE 
            DATEDIFF(DAY, ls.NgayGuiYeuCau, GETDATE()) > 3  -- Quá 3 ngày từ ngày yêu cầu
            AND ls.TrangThaiTBT = N'Chờ duyệt';  -- Chưa duyệt
    END

    SET NOCOUNT OFF;
END;
GO
--------------------------------------------------------------------------------

select * from baiviet
select * from ChiTietBaiViet
select * from chitietphanbien
select * from LichSuChonNguoiPhanBien
select * from LichSuSoDuyetBaiViet
select * from PhanHoi
select * from sotapchi
select * from VaiTro
select * from NguoiDung_VaiTro
select * from NguoiDung
