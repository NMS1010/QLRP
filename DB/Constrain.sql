use QLRP
go

--Constraint NguoiDung
alter table NguoiDung drop constraint IF EXISTS check_SDT_NguoiDung
alter table NguoiDung drop constraint IF EXISTS check_CCCD_NguoiDung
alter table NguoiDung drop constraint IF EXISTS check_Email_NguoiDung
alter table NguoiDung drop constraint IF EXISTS check_Luong_NguoiDung


alter table NguoiDung add constraint check_SDT_NguoiDung CHECK (SDT not like '%[^0-9]%' and (LEN(SDT) = 10))
alter table NguoiDung add constraint check_CCCD_NguoiDung CHECK (CCCD not like '%[^0-9]%' and (LEN(CCCD) = 12))
alter table NguoiDung add constraint check_Email_NguoiDung CHECK (Email LIKE '_%@__%.__%')
alter table NguoiDung add constraint check_Luong_NguoiDung CHECK (Luong > 0)



--Constraint Phim
alter table Phim drop constraint IF EXISTS check_ThoiLuong_Phim
alter table Phim drop constraint IF EXISTS check_LuaTuoi_Phim
alter table Phim drop constraint IF EXISTS check_NgayKhoiChieu_NgayKetThuc_Phim


alter table Phim add constraint check_ThoiLuong_Phim CHECK (ThoiLuong > 0)
alter table Phim add constraint check_LuaTuoi_Phim CHECK (LuaTuoi > 0)
alter table Phim add constraint check_NgayKhoiChieu_NgayKetThuc_Phim CHECK (NgayKhoiChieu < NgayKetThuc)


--Constraint PhongChieu
alter table PhongChieu drop constraint IF EXISTS check_TongSoGhe_PhongChieu

alter table PhongChieu add constraint check_TongSoGhe_PhongChieu CHECK (TongSoGhe = SoCot * SoHang)

--Constraint Ghe
alter table Ghe drop constraint IF EXISTS check_GiaGhe_Ghe

alter table Ghe add constraint check_GiaGhe_Ghe CHECK (GiaGhe > 0)

--Constraint PhongChieu_Ghe
alter table PhongChieu_Ghe drop constraint IF EXISTS check_SoLuong_PhongChieu_Ghe

alter table PhongChieu_Ghe add constraint check_SoLuong_PhongChieu_Ghe CHECK (SoLuong > 0)


--Constraint KhachHang
alter table KhachHang drop constraint IF EXISTS check_NgaySinh_KhachHang
alter table KhachHang drop constraint IF EXISTS check_SoDienThoai_KhachHang
alter table KhachHang drop constraint IF EXISTS check_Email_KhachHang


alter table KhachHang add constraint check_NgaySinh_KhachHang CHECK ((year(getdate()) - year(NgaySinh)) > 1)
alter table KhachHang add constraint check_SoDienThoai_KhachHang CHECK (SoDienThoai not like '%[^0-9]%' and (LEN(SoDienThoai) = 10))
alter table KhachHang add constraint check_Email_KhachHang CHECK (Email LIKE '_%@__%.__%')


--Constraint DichVu
alter table DichVu drop constraint IF EXISTS check_Gia_DichVu

alter table DichVu add constraint check_Gia_DichVu CHECK (Gia > 0)

--Constraint KhuyenMai
alter table KhuyenMai drop constraint IF EXISTS check_GiaTriKM_KhuyenMai

alter table KhuyenMai add constraint check_GiaTriKM_KhuyenMai CHECK (GiaTriKM > 0 and GiaTriKM <=1)

--Constraint LoaiKH
alter table LoaiKH add constraint check_GiamGia_LoaiKH CHECK (GiamGia >= 0 and GiamGia <=1)