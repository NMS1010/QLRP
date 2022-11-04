use QLRP
go

create trigger trigger_check_DateSuatChieuPhim 
on SuatChieu after insert, update
as
begin
	declare @ThoiGianChieu date, @MaPhim int, @NgayKhoiChieu date, @NgayKetThuc date
	select @ThoiGianChieu = Ngay, @MaPhim = MaPhim from inserted

	select @NgayKetThuc = NgayKetThuc, @NgayKhoiChieu = NgayKhoiChieu
	from Phim
	where MaPhim = @MaPhim

	if (@ThoiGianChieu < @NgayKhoiChieu or @ThoiGianChieu > @NgayKetThuc)
	begin
		rollback tran
		Raiserror(N'Thời gian Suất chiếu phải lớn hơn hoặc bằng Ngày Khởi Chiếu và nhỏ hơn hoặc bằng Ngày Kết Thúc',16,1)
		return
	end
end
go

create trigger trigger_check_TimeSuatChieuPhim 
on SuatChieu after insert, update
as
begin
	declare @NgayChieu date, @GioChieu time, @MaPhim int, @MaPhong int, @count int
	select @NgayChieu = Ngay, @GioChieu = Gio, @MaPhim = MaPhim, @MaPhong = MaPhong from inserted

	select @count = count(*)
	from Phim inner join SuatChieu on Phim.MaPhim = SuatChieu.MaPhim inner join PhongChieu on SuatChieu.MaPhong = PhongChieu.MaPhong
	where PhongChieu.MaPhong = @MaPhong and (@NgayChieu = SuatChieu.Ngay and @GioChieu >= SuatChieu.Gio and @GioChieu <= dateadd(mi, Phim.ThoiLuong, convert(time, SuatChieu.Gio)))

	if(@count > 1)
	begin
		rollback tran
		raiserror(N'Thời gian chiếu trùng với suất chiếu khác của cùng Phòng chiếu',16,1)
		return
	end
end
go

--create trigger trigger_check_Luong 
--on NguoiDung_VaiTro after insert, update
--as
--begin
--	declare @Luong money, @count int, @isAdmin int, @MaND int
--	select @isAdmin = count(*) 
--	from inserted inner join VaiTro on inserted.MaVaiTro = VaiTro.MaVaiTro
--	where TenVaiTro = 'Admin'

--	select @Luong = Luong, @MaND = inserted.MaND 
--	from NguoiDung, inserted 
--	where NguoiDung.MaND = inserted.MaND


--	select @count = count(*)
--	from NguoiDung inner join NguoiDung_VaiTro on NguoiDung.MaND = NguoiDung_VaiTro.MaND
--		inner join VaiTro on NguoiDung_VaiTro.MaVaiTro = VaiTro.MaVaiTro
--	where (@isAdmin > 0 and TenVaiTro = 'Employee' and Luong >= @Luong) or (@isAdmin = 0 and TenVaiTro = 'Admin' and Luong <= @Luong) 

--	if(@count > 0)
--		begin
--			rollback tran
--			delete from NguoiDung where MaND = @MaND
--			raiserror(N'Lương người quản trị phải lớn hơn nhân viên',16,1)
--			return
--		end
--end
--go

--drop trigger trigger_check_Luong 
--create trigger trigger_check_TuoiMuaVe
--on Ve after update
--as
--begin
--	declare @MaKH int, @LuaTuoi int, @count int
--	select @MaKH = MaKH, @LuaTuoi = LuaTuoi from inserted inner join SuatChieu on inserted.MaSuatChieu = SuatChieu.MaSuatChieu
--			inner join Phim on SuatChieu.MaPhim = Phim.MaPhim

--	select @count = count(*)
--	from KhachHang
--	where maKH = @MaKH  and year(getdate()) - year(NgaySinh) >= @LuaTuoi 

--	if(@count = 0 and @MaKH is not null)
--	begin
--		rollback tran
--		raiserror(N'Không đủ tuổi để xem bộ phim này',16,1)
--		return
--	end
--end

