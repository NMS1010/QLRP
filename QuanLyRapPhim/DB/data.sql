use QLRP
go

declare @id int

exec proc_addRole 'Admin'
exec proc_addRole 'Nhân viên'

exec proc_addUser N'Nguyễn Minh Sơn', 'Nam', '2002-10-10', '0354964841' , '012345678991', 'minh1son@gmail.com' , 'nms11010' , 'nms1010' , '12345'

exec proc_addUserRole 1 , 1

exec proc_addUser N'Nguyễn Minh', 'Nam', '2002-10-10', '0354964840' , '012345678990', 'minhson@gmail.com' , 'nms1010' , 'nms1010' , '12345'

exec proc_addUserRole 2 , 2

