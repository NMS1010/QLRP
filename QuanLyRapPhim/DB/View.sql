use QLRP

-- Chi tiết Phim đang chiếu
go
create view view_chiTietPhimDangChieu as
select Phim.MaPhim, TenPhim, TenDienVien, TenLoai, ThoiLuong, LuaTuoi, NgayKhoiChieu, NgayKetThuc, DaoDienChinh
from Phim
		inner join (TheLoai inner join Phim_TheLoai on TheLoai.MaLoai = Phim_TheLoai.MaLoai)
					on Phim_TheLoai.MaPhim = Phim.MaPhim
		inner join (DienVien inner join Phim_DienVien on DienVien.MaDienVien = Phim_DienVien.MaDienVien)
					on Phim_DienVien.MaPhim = Phim.MaPhim
		inner join SuatChieu on Phim.MaPhim = SuatChieu.MaPhim
where SuatChieu.TrangThai = 1
-- View Vai trò người dùng
go
create view view_nguoiDung_VaiTro as
select NguoiDung.MaND, TenND, TenVaiTro, TenTaiKhoan, Matkhau
from NguoiDung
	inner join NguoiDung_VaiTro on NguoiDung.MaND = NguoiDung_VaiTro.MaND
	inner join VaiTro on VaiTro.MaVaiTro = NguoiDung_VaiTro.MaVaiTro
-- View Chi tiết phim
go
create view view_chiTietPhim as
select Phim.MaPhim, TenPhim, TenDienVien, TenLoai, ThoiLuong, LuaTuoi, NgayKhoiChieu, NgayKetThuc, DaoDienChinh
from Phim
		inner join (TheLoai inner join Phim_TheLoai on TheLoai.MaLoai = Phim_TheLoai.MaLoai)
					on Phim_TheLoai.MaPhim = Phim.MaPhim
		inner join (DienVien inner join Phim_DienVien on DienVien.MaDienVien = Phim_DienVien.MaDienVien)
					on Phim_DienVien.MaPhim = Phim.MaPhim
-- View Chi tiết khách hàng
go
create view view_chiTietKhachHang as
select maKH, Ten, GioiTinh, NgaySinh, DiaChi, SoDienThoai, TenLoaiKH, Email
from KhachHang inner join LoaiKH on KhachHang.MaLoaiKH = LoaiKH.MaLoaiKH

-- Chi tiết Suất chiếu
go 
create view view_chiTietSuatChieu as
select MaSuatChieu, Phim.MaPhim, TenPhim, SuatChieu.MaPhong, TenPhong, Ngay, Gio, LoaiMay, ThoiLuong, LuaTuoi, DaoDienChinh, SuatChieu.TrangThai
from SuatChieu
	inner join PhongChieu on SuatChieu.MaPhong = PhongChieu.MaPhong
	inner join MayChieu on MayChieu.MaMay = PhongChieu.MaMay
	inner join Phim on SuatChieu.MaPhim = Phim.MaPhim
-- View chi tiết hoá đơn
go

create view view_chiTietHoaDon as
select Ten, TenPhim, TenPhong, GioXuat, NgayXuat, TenKM, TongChiPhi
from HoaDon
		inner join KhuyenMai on HoaDon.MaKM = KhuyenMai.MaKM
		inner join KhachHang on HoaDon.MaKH = KhachHang.MaKH 
		inner join Ve on MaVe = Ve.MaVe
		inner join SuatChieu on Ve.MaSuatChieu = SuatChieu.MaSuatChieu
		inner join PhongChieu on SuatChieu.MaPhong = PhongChieu.MaPhong
		inner join Phim on SuatChieu.MaPhim = Phim.MaPhim
-- View chi tiết doanh thu theo phim
go
create view view_chiTietDoanhThuPhim as
select Phim.TenPhim, sum(GiaGhe) as TongDoanhThu
from Ve inner join SuatChieu on Ve.MaSuatChieu = SuatChieu.MaSuatChieu
		inner join PhongChieu on SuatChieu.MaPhong = PhongChieu.MaPhong
		inner join Phim on SuatChieu.MaPhim = Phim.MaPhim
		inner join PhongChieu_Ghe on PhongChieu.MaPhong = PhongChieu_Ghe.MaPhong
		inner join Ghe on PhongChieu_Ghe.MaGhe = Ghe.MaGhe
where Ve.TrangThai = 1
group by Phim.TenPhim


