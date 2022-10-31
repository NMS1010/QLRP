use QLRP
go

--------------------Xác thực--------------
go 
create function func_Login(@username nvarchar(255), @password nvarchar(255))
returns int
as
begin
	declare @isSuccess int
	select @isSuccess = count(*)
	from NguoiDung
	where TenTaiKhoan = @username and MatKhau = @password
	return @isSuccess
end

go 
create proc proc_ChangePassword
@username nvarchar(255),
@password nvarchar(255),
@newpassword nvarchar(255)
as
begin
	declare @isSuccess int, @changeSuccess int
	
	set @isSuccess = dbo.func_Login(@username, @password)
	if(@isSuccess = 1)
	begin
		update NguoiDung set MatKhau = @newpassword where TenTaiKhoan = @username
		return 1
	end
	return -1
end
---------------------Ve-------------------
go
create proc proc_addTicket 
@viTriGhe char(3),
@MaSuatChieu int,
@TongGiaVe decimal
as
begin
	insert into Ve(ViTriGhe, TrangThai, MaSuatChieu, TongGia, MaKH, NgayMua) values(@ViTriGhe, '0', @MaSuatChieu, @TongGiaVe, null, null) 
end

go
create proc proc_buyTicket 
@MaKH char(3),
@MaVe int
as
begin
	update Ve set MaKH = @MaKH, NgayMua = getdate(), TrangThai = '1' 
	where MaVe = @MaVe
end

go
create function func_getTicketByShowTime(@MaSC int)
returns table as
return (
	select v.MaVe, v.MaSuatChieu, v.MaKH, v.NgayMua, v.TrangThai, v.ViTriGhe, v.TongGia
	from Ve v inner join SuatChieu sc on v.MaSuatChieu = sc.MaSuatChieu 
	where v.MaSuatChieu = @MaSC
)

go
create function func_getBoughtTicket(@MaSC int)
returns table as
return (
	select v.MaVe, v.MaSuatChieu, v.MaKH, v.NgayMua, v.TrangThai, v.ViTriGhe, v.TongGia
	from Ve v inner join SuatChieu sc on v.MaSuatChieu = sc.MaSuatChieu 
	where v.MaSuatChieu = @MaSC and v.TrangThai = '1'
)
go
create function func_getTicketByShowTimeId(@MaSC int)
returns table as
return (
	select v.MaVe, v.MaSuatChieu, v.MaKH, v.NgayMua, v.TrangThai, v.ViTriGhe, v.TongGia
	from Ve v inner join SuatChieu sc on v.MaSuatChieu = sc.MaSuatChieu 
	where v.MaSuatChieu = @MaSC
)
go
create proc proc_updateTicketPrice
@MaSuatChieu int, 
@TongGiaVe decimal
as 
begin
	update Ve set TongGia = @TongGiaVe
	where MaSuatChieu = @MaSuatChieu
end
go
create function func_getTicketIdBySeatName(@seatName char(3))
returns table as 
return(
	select MaVe
	from Ve
	where ViTriGhe = @seatName
)
--Khach hang
go
create proc proc_addCustomer 
@Ten nvarchar(255),
@GioiTinh nvarchar(4),
@NgaySinh date,
@DiaChi nvarchar(255),
@SoDienThoai varchar(10),
@MaLoaiKH int,
@Email nvarchar(255)
as
begin
	insert into KhachHang(Ten, GioiTinh, NgaySinh, DiaChi, SoDienThoai, MaLoaiKH, Email) 
	values(@Ten, @GioiTinh, @NgaySinh, @DiaChi, @SoDienThoai, @MaLoaiKH, @Email) 
end
exec proc_addCustomer 'Sơn' , null , null, null ,null , 1 , null
go
create proc proc_updateCustomer 
@MaKH int,
@Ten nvarchar(255),
@GioiTinh nvarchar(4),
@NgaySinh date,
@DiaChi nvarchar(255),
@SoDienThoai varchar(10),
@MaLoaiKH int,
@Email nvarchar(255)
as
begin
	update KhachHang set Ten = @Ten, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, @DiaChi = DiaChi, @SoDienThoai = SoDienThoai, MaLoaiKH = @MaLoaiKH, Email = @Email
	where MaKH = @MaKH
end

go
create proc proc_deleteCustomer 
@MaKH int
as
begin
	delete from KhachHang where MaKH = @MaKH
end

go
create function func_getAllCustomer()
returns table 
as
	return (select *
	from KhachHang)

go
create function func_searchAllCustomer(@keyword nvarchar(255))
returns table 
as
	return(
		select *
		from KhachHang
		where Ten LIKE '%'+@keyword+'%' or GioiTinh LIKE '%'+@keyword+'%' or DiaChi LIKE '%'+@keyword+'%' or SoDienThoai LIKE '%'+@keyword+'%' or Email LIKE '%'+@keyword+'%'
			
	)

go
create proc proc_addServiceForCustomer
@MaDichVu int,
@MaKhachHang int
as
begin
	insert into KH_DV values(@MaKhachHang, @MaDichVu)
end


--Dịch vụ
go
create proc proc_addService
@TenDichVu nvarchar(255),
@Gia decimal
as
begin
	insert into DichVu(TenDichVu, Gia) 
	values(@TenDichVu, @Gia) 
end

go
create proc proc_updateService 
@TenDichVu nvarchar(255),
@MaDichVu int,
@Gia decimal
as
begin
	update DichVu set TenDichVu = @TenDichVu, Gia = @Gia
	where MaDichVu = @MaDichVu
end

go
create proc proc_deleteService 
@MaDichVu int
as
begin
	delete from DichVu where MaDichVu = @MaDichVu
end

go
create function func_getAllService()
returns table 
as
	return (select *
	from DichVu)

go
create function func_searchAllService(@keyword nvarchar(255))
returns table 
as
	return(
		select *
		from DichVu
		where TenDichVu LIKE '%'+@keyword+'%' or Gia LIKE '%'+@keyword+'%'
	)

--Khuyến mãi
go
create proc proc_addDiscount
@TenKM nvarchar(255),
@GiaTriKM float
as
begin
	insert into KhuyenMai(TenKM, GiaTriKM) 
	values(@TenKM, round(@GiaTriKM,3)) 
end

go
create proc proc_updateDiscount 
@TenKM nvarchar(255),
@MaKM int,
@GiaTriKM float
as
begin
	update KhuyenMai set TenKM = @TenKM, GiaTriKM = round(@GiaTriKM,3)
	where MaKM = @MaKM
end

go
create proc proc_deleteDiscount 
@MaKM int
as
begin
	delete from KhuyenMai where MaKM = @MaKM
end

go
create function func_getAllDiscount()
returns table 
as
	return (
		select *
		from KhuyenMai
	)

go
create function func_searchAllDiscount(@keyword nvarchar(255))
returns table 
as
	return(
		select *
		from KhuyenMai
		where TenKM LIKE '%'+@keyword+'%' or GiaTriKM LIKE '%'+@keyword+'%'
	)
--- Loại KH
go
create proc proc_addTypeCustomer
@TenLoaiKH nvarchar(255),
@GiamGia float
as
begin
	insert into LoaiKH(TenLoaiKH, GiamGia) 
	values(@TenLoaiKH, round(@GiamGia,3)) 
end

go
create proc proc_updateTypeCustomer 
@TenLoaiKH nvarchar(255),
@MaLoaiKH int,
@GiamGia float
as
begin
	update LoaiKH set TenLoaiKH = @TenLoaiKH, GiamGia = round(@GiamGia,3)
	where MaLoaiKH = @MaLoaiKH
end

go
create proc proc_deleteTypeCustomer 
@MaLoaiKH int
as
begin
	delete from LoaiKH where MaLoaiKH = @MaLoaiKH
end

go
create function func_getAllTypeCustomer()
returns table 
as
	return (
		select *
		from LoaiKH
	)

go
create function func_searchAllTypeCustomer(@keyword nvarchar(255))
returns table 
as
	return(
		select *
		from LoaiKH
		where TenLoaiKH LIKE '%'+@keyword+'%' or GiamGia LIKE '%'+@keyword+'%'
	)


----------------------------
------------ Dien vien ------------
-- Add
go
create proc proc_add_Actor
@TenDienVien nvarchar(255)
as 
begin 
	insert into DienVien(TenDienVien) values(@TenDienVien)
end

-- Update
go
create proc proc_update_Actor
@MaDienVien int,
@TenDienVien nvarchar(255)
as
begin 
	update DienVien set TenDienVien = @TenDienVien
	where MaDienVien = @MaDienVien
end

-- Delete
go
create proc proc_delete_Actor
@MaDienVien int
as
begin 
	delete from DienVien
	where MaDienVien = @MaDienVien
end

-- function DienVien
go
create function func_getActor()
returns Table as
return (
	select * from DienVien
);

-- search Dienvien
go
create function func_searchActor(@key nvarchar(255))
returns table as
return (
	select * from DienVien
	where TenDienVien LIKE '%'+@key+'%'
)
go
create function func_getActorByName(@name nvarchar(255))
returns table as
return (
	select top 1 *
	from DienVien
	where TenDienVien = @name
)
go
------------ Ghe ------------
-- Add
go 
create proc proc_addChair
@GiaGhe decimal,
@LoaiGhe char(1)
as
begin 
	insert into Ghe(GiaGhe, LoaiGhe) values(@GiaGhe, @LoaiGhe)
end

-- Update 
go 
create proc proc_updateChair
@MaGhe int,
@GiaGhe decimal,
@LoaiGhe char(1)
as
begin 
	update Ghe set GiaGhe = @GiaGhe, LoaiGhe = @LoaiGhe
	where MaGhe = @MaGhe
end

-- Delete
go
create proc proc_deleteChair
@MaGhe int
as
begin 
	delete Ghe
	where MaGhe = @MaGhe
end

-- Function
go
create function func_getChair()
returns table as
return (
	select * from Ghe	
)

------------ Phong Chieu ------------
-- Add
go 
create proc proc_addCinemaRoom 
@TenPhong char(255), 
@SoCot int,
@SoHang int, 
@TongSoGhe int,
@TrangThai int,
@MaMay int
as
begin
	insert into PhongChieu(TenPhong, SoCot, SoHang, TongSoGhe, TrangThai, MaMay) values(@TenPhong, @SoCot, @SoHang, @TongSoGhe, @TrangThai, @MaMay)
end

-- Update 
go
create proc proc_updateCinemaRoom 
@MaPhong int,
@TenPhong char(255), 
@SoCot int,
@SoHang int, 
@TrangThai char(1),
@MaMay int
as
begin
	update PhongChieu set TenPhong = @TenPhong, SoCot = @SoCot, SoHang = @SoHang, TrangThai = @TrangThai, MaMay = @MaMay, TongSoGhe = @SoCot * @SoHang
	where MaPhong = @MaPhong
end
-- Delete
go
create proc proc_deleteCinemaRoom 
@MaPhong int
as
begin
	delete PhongChieu
	where MaPhong = @MaPhong
end

-- Function
go
create function func_getCinemaRoom ()
returns table as
return (
	select * from PhongChieu
)
go
create function func_getRoomByName(@TenPhong nvarchar(255))
returns table as
return (
	select top 1 *
	from PhongChieu
	where TenPhong = @TenPhong
)
go
create proc proc_addCinemaRoomChair
@MaPhong int, 
@MaGhe int, 
@SoLuong int
as
begin
	insert into PhongChieu_Ghe(MaPhong, MaGhe, SoLuong) values (@MaPhong, @MaGhe, @SoLuong)
end
go
create proc proc_deleteCinemaRoomChairByRoomId
@MaPhong int
as
begin
	delete from PhongChieu_Ghe where MaPhong = @MaPhong
end
-- Search by name room
go
create function func_searchRoomByName (@key nvarchar(255))
returns table as
return (
	select * from PhongChieu
	where TenPhong LIKE '%'+@key+'%'
)
go

create function func_getTypeChairIdByRoomId(@MaPhong int)
returns table as
return (
	select * 
	from PhongChieu_Ghe
	where MaPhong = @MaPhong
)
go

create function func_getRoomByRoomId(@MaPhong int)
returns table as
return (
	select * 
	from PhongChieu
	where MaPhong = @MaPhong
)
go

create function func_getSeatPriceByRoomId(@MaPhong int)
returns table as
return (
	select GiaGhe
	from PhongChieu_Ghe inner join Ghe on PhongChieu_Ghe.MaGhe = Ghe.MaGhe
	where MaPhong = @MaPhong
)
go

create function func_getProjectorPriceByRoomId(@MaPhong int)
returns table as
return (
	select Gia
	from PhongChieu inner join MayChieu on PhongChieu.MaMay = MayChieu.MaMay
	where MaPhong = @MaPhong
)
go
------------ May Chieu ------------
-- Add 
go
create proc proc_addProjector
@LoaiMay char(255),
@Gia decimal
as
begin 
	insert into MayChieu(LoaiMay, Gia) values(@LoaiMay, @Gia)
end

-- Update
go
create proc proc_updateProjector
@MaMay int,
@LoaiMay char(255),
@Gia decimal
as
begin 
	update MayChieu set LoaiMay = @LoaiMay, Gia = @Gia
	where LoaiMay = @LoaiMay
end

-- Delete
go 
create proc proc_deleteProjector
@MaMay int
as
begin 
	delete MayChieu
	where MaMay = @MaMay
end

-- Function
go
create function func_getProjector()
returns table as
return (
	select * from MayChieu
)

------------ Suat Chieu ------------
-- Add
go 
create proc proc_addShowtimes
@Gio time,
@Ngay date,
@TrangThai char(1),
@MaPhim int,
@MaPhong int
as
begin
	insert into SuatChieu(Gio, Ngay, TrangThai, MaPhim, MaPhong) values(@Gio, @Ngay, @TrangThai, @MaPhim, @MaPhong)
end

-- Update
go 
create proc proc_updateShowtimes
@MaSuatChieu int,
@Gio time,
@Ngay date,
@TrangThai char(1),
@MaPhim int,
@MaPhong int
as
begin
	update SuatChieu set Gio = @Gio, Ngay = @Ngay, TrangThai = @TrangThai, MaPhim = @MaPhim, MaPhong = @MaPhong
	where MaSuatChieu = @MaSuatChieu
end

-- Delete
go 
create proc proc_deleteShowtimes
@MaSuatChieu int
as
begin
	delete SuatChieu
	where MaSuatChieu = @MaSuatChieu
end

-- Function
go
create function func_getShowtimes()
returns table as
return (
	select * from view_chiTietSuatChieu
)
go

create function func_getShowtimesByFilm(@filmId int)
returns table as
return (
	select MaSuatChieu, SuatChieu.MaPhim, SuatChieu.MaPhong, Gio, Ngay, PhongChieu.TenPhong, Phim.TenPhim, SuatChieu.TrangThai, LoaiMay, SoCot, SoHang
	from SuatChieu inner join Phim on SuatChieu.MaPhim = Phim.MaPhim
		inner join PhongChieu on SuatChieu.MaPhong = PhongChieu.MaPhong
		inner join MayChieu on PhongChieu.MaMay = MayChieu.MaMay
	where Phim.MaPhim = @filmId
)

go

-- Search by name room
go
create function func_searchShowtimes (@key varchar(255))
returns table
return (
	select * from view_chiTietSuatChieu
	where Gio LIKE '%'+@key+'%' or Ngay LIKE '%'+@key+'%' or TenPhim LIKE '%'+@key+'%' or TenPhong LIKE '%'+@key+'%'
)

-------------------------------------------------------

-- NGUOIDUNG
go
create proc proc_addUser
@TenND nvarchar(255),
@GioiTinh nvarchar(4),
@NgaySinh date,
@SDT varchar(20),
@CCCD varchar(20),
@Email varchar(255),
@TenTaiKhoan nvarchar(255),
@MatKhau nvarchar(255),
@Luong decimal
as 
begin
	insert into NguoiDung(TenND, GioiTinh, NgaySinh, SDT, CCCD, Email, TenTaiKhoan, MatKhau, Luong)
		values (@TenND, @GioiTinh, @NgaySinh, @SDT, @CCCD, @Email, @TenTaiKhoan, @MatKhau, @Luong)
end
go

create proc proc_updateUser 
	@MaND int,
	@TenND nvarchar(255),
@GioiTinh nvarchar(4),
@NgaySinh date,
@SDT varchar(20),
@CCCD varchar(20),
@Email varchar(255),
@TenTaiKhoan nvarchar(255),
@Matkhau nvarchar(255),
@Luong decimal
as 
begin
	update NguoiDung Set TenND = @TenND, GioiTinh = @GioiTinh, 
		NgaySinh = @NgaySinh, SDT = @SDT, CCCD = @CCCD, Email = @Email, 
		TenTaiKhoan = @TenTaiKhoan, MatKhau = @MatKhau, Luong = @Luong 
	where MaND = @MaND
end
go

create proc proc_deleteUser
@MaND int
as 
begin 
	delete from NguoiDung where MaND = @MaND
end
go

create function func_getAllUser()
returns table as
return (
    select *
    from NguoiDung
);
go
create function func_getUserByUserName(@username nvarchar(255))
returns table as
return (
	select top 1 *
	from NguoiDung
	where TenTaiKhoan = @username
)
go

create function func_searchUser(@Keyword nvarchar(255)) 
returns table as
return (
    select *
    from NguoiDung
	where TenND LIKE '%'+@Keyword+'%' or GioiTinh LIKE '%'+@Keyword+'%' or SDT LIKE '%'+@Keyword+'%' or CCCD LIKE '%'+@Keyword+'%' or Email LIKE '%'+@Keyword+'%' or 
		TenTaiKhoan LIKE '%'+@Keyword+'%' or MatKhau LIKE '%'+@Keyword+'%' or Luong LIKE '%'+@Keyword+'%'
);
go

-- NguoiDung - VaiTro
create proc proc_addUserRole
@MaND int,
@MaVaiTro int
as 
begin
	insert into NguoiDung_VaiTro(MaND, MaVaiTro)
		values (@MaND, @MaVaiTro)
end
go

create proc proc_deleteUserRolebyUserId
@MaND int
as 
begin
	delete from NguoiDung_VaiTro where MaND = @MaND
end
go

create function func_getRoleIdByUserId(@userId int)
returns table
as
return (
	select MaVaiTro
	from NguoiDung_VaiTro
	where MaND = @userId
)
go
create function func_getRoleNameByUsername(@username nvarchar(255))
returns table
as
return (
	select TenVaiTro
	from NguoiDung_VaiTro inner join NguoiDung on NguoiDung_VaiTro.MaND = NguoiDung.MaND
		inner join VaiTro on NguoiDung_VaiTro.MaVaiTro = VaiTro.MaVaiTro
	where TenTaiKhoan = @username
)
go


-- VAITRO
create proc proc_addRole
@TenVaiTro nvarchar(255)
as 
begin
	insert into VaiTro(TenVaiTro)
		values (@TenVaiTro)
end
go

create proc proc_updateRole
@MaVaiTro int,
@TenVaiTro nvarchar(255)
as 
begin
		update VaiTro Set TenVaiTro = @TenVaiTro 
		where MaVaiTro = @MaVaiTro
end
go

create function func_getAllRole()
returns table as
return (
    select *
    from VaiTro
);
go

create function func_searchRole(@TenVaiTro nvarchar(255)) 
returns table as
return (
    select *
    from VaiTro
	where TenVaiTro LIKE '%'+@TenVaiTro+'%'
);
go

create function func_getRoleByName(@name nvarchar(255))
returns table as
return (
	select top 1 *
	from VaiTro
	where TenVaiTro = @name
)
go
-- QUYEN
create proc proc_addPermission
@TenQuyen nvarchar(255)
as 
begin
	insert into Quyen(TenQuyen)
		values (@TenQuyen)
end
go

create proc proc_updatePermission
@MaQuyen int,
@TenQuyen nvarchar(255)
as 
begin
		update Quyen Set TenQuyen = @TenQuyen 
		where MaQuyen = @MaQuyen
end
go

create function func_getAllPermission()
returns table as
return (
    select *
    from Quyen
);
go

create function func_searchPermission(@TenQuyen nvarchar(255)) 
returns table as
return (
    select *
    from Quyen
	where TenQuyen LIKE '%'+@TenQuyen+'%'
);
go

-- VaiTro - Quyen
create proc proc_addRolePermission
@MaVaiTro int,
@MaQuyen int
as 
begin
	insert into VaiTro_Quyen(MaVaiTro, MaQuyen)
		values (@MaVaiTro, @MaQuyen)
end
go

create proc proc_deleteRolePermissionbyRoleId
@MaVaiTro int
as 
begin
	delete from VaiTro_Quyen where MaVaiTro = @MaVaiTro
end
go


-- PHIM
create proc proc_addFilm
@ThoiLuong float,
@TenPhim nvarchar(255),
@LuaTuoi int,
@NgayKhoiChieu date,
@NgayKetThuc date,
@DaoDienChinh nvarchar(255)
as 
begin
	insert into Phim(ThoiLuong, TenPhim, LuaTuoi, NgayKhoiChieu, NgayKetThuc, DaoDienChinh)
		values (@ThoiLuong, @TenPhim, @LuaTuoi, @NgayKhoiChieu, @NgayKetThuc, @DaoDienChinh)
end
go

create proc proc_updateFilm
@MaPhim int,
@ThoiLuong float,
@TenPhim nvarchar(255),
@LuaTuoi int,
@NgayKhoiChieu date,
@NgayKetThuc date,
@DaoDienChinh nvarchar(255)
as 
begin
	update Phim Set ThoiLuong = @ThoiLuong, TenPhim = @TenPhim, 
		LuaTuoi = @LuaTuoi, NgayKhoiChieu = @NgayKhoiChieu, NgayKetThuc = @NgayKetThuc, DaoDienChinh = @DaoDienChinh 
	where MaPhim = @MaPhim
end
go

create proc proc_deleteFilm
@MaPhim int
as 
begin 
	delete from Phim where MaPhim = @MaPhim
end
go

create function func_getAllFilm()
returns table as
return (
    select *
    from Phim
);
go

create function func_searchFilm(@Keyword nvarchar(255)) 
returns table as
return (
    select *
    from Phim
	where ThoiLuong LIKE '%'+@Keyword+'%' or TenPhim LIKE '%'+@Keyword+'%' or 
		LuaTuoi LIKE '%'+@Keyword+'%' or NgayKhoiChieu LIKE '%'+@Keyword+'%' or NgayKetThuc LIKE '%'+@Keyword+'%' or DaoDienChinh LIKE '%'+@Keyword+'%'
);
go

create function func_getFilmByName(@name nvarchar(255))
returns table as
return (
	select top 1 *
	from Phim
	where TenPhim = @name
)
go
create function func_getFilmByDate(@date date)
returns table as
return (
	select *
	from Phim
	where NgayKhoiChieu < @date and @date < NgayKetThuc
)
go
use QLRP
go
create function func_getCategoryIdByFilmId(@FilmId int)
returns table
as
return (
	select MaLoai
	from Phim_TheLoai
	where MaPhim = @FilmId
)
go
create function func_getActorIdByFilmId(@FilmId int)
returns table
as
return (
	select MaDienVien
	from Phim_DienVien
	where MaPhim = @FilmId
)
go
create function func_searchAllProjector(@keyword nvarchar(255))
returns table 
as
	return(
		select *
		from MayChieu
		where LoaiMay LIKE '%'+@keyword+'%' or Gia LIKE '%'+@keyword+'%'
	)
go
-- THELOAI
create proc proc_addCategory
@TenLoai nvarchar(255)
as 
begin
	insert into TheLoai(TenLoai)
		values (@TenLoai)
end
go

create proc proc_updateCategory
@MaLoai int,
@TenLoai nvarchar(255)
as 
begin
		update TheLoai Set TenLoai = @TenLoai 
		where MaLoai = @MaLoai
end
go

create function func_getAllCategory()
returns table as
return (
    select *
    from TheLoai
);
go

create function func_searchCategory(@TenLoai nvarchar(255)) 
returns table as
return (
    select *
    from TheLoai
	where TenLoai LIKE '%'+@TenLoai+'%'
);
go
create function func_getCategoryByName(@name nvarchar(255))
returns table as
return (
	select top 1 *
	from TheLoai
	where TenLoai = @name
)
go
create proc proc_deleteCategory
@MaLoai int
as
begin 
	delete from TheLoai where MaLoai = @MaLoai
end
go
-- Phim - TheLoai
create proc proc_addFilmCategory
@MaPhim int,
@MaLoai int
as 
begin
	insert into Phim_TheLoai(MaPhim, MaLoai)
		values (@MaPhim, @MaLoai)
end
go

create proc proc_deleteFilmCategorybyFilmId
@MaPhim int
as 
begin
	delete from Phim_TheLoai where MaPhim = @MaPhim
end
go

-- Phim - DienVien
create proc proc_addFilmActor
@MaPhim int,
@MaDienVien int
as 
begin
	insert into Phim_DienVien(MaPhim, MaDienVien)
		values (@MaPhim, @MaDienVien)
end
go

create proc proc_deleteFilmActorbyFilmId
@MaPhim int
as 
begin
	delete from Phim_DienVien where MaPhim = @MaPhim
end
go

------Hoá đơn
create proc proc_addBill
@MaKH int, 
@MaKM int,
@GioXuat time,
@NgayXuat date,
@TongChiPhi decimal
as
begin
	insert into HoaDon(MaKH, MaKM, GioXuat, NgayXuat, TongChiPhi) 
	values (@MaKH, @MaKM, @GioXuat, @NgayXuat, @TongChiPhi)
end
go
create function func_searchBill(@key nvarchar(255)) 
returns table as
return (
    select *
    from view_chiTietHoaDon
	where Ten LIKE '%'+@key+'%' or TenPhim LIKE '%'+@key+'%' or TenPhong LIKE '%'+@key+'%'
);
go
create function func_getAllBill ()
returns table as
return (
	select * 
	from view_chiTietHoaDon
)
go

--- Doanh thu
create function func_getRevenueByFilm(@filmName nvarchar(255), @startDate date, @endDate date)
returns table as
return (
	select *
	from view_chiTietDoanhThuPhim
	where TenPhim = @filmName and NgayMua >= @startDate and NgayMua <= @endDate
)

