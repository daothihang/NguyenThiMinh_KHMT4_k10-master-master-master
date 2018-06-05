use master 
go
if(exists (select * from sysdatabases where name ='QuanLyHocSinh'))
		  drop database QuanLyHocSinh
go
create database QuanLyHocSinh
on primary(
	name='QuanLyHocSinh_dat',
	filename='D:\QuanLyHoaSinh.mdf',
	size = 5MB,
	maxsize = 50MB,
	filegrowth = 10%
)
log on(
	name='QuanLyHocSinh_log',
	filename='D:\QuanLyHoaSinh.ldf',
	size = 2MB,
	maxsize = 10MB,
	filegrowth = 5%
)
use QuanLyHocSinh
go
create table CanBoGiaovien(
	MaCanBoGiaoVien nvarchar(20) not null primary key,
	HoTen nvarchar(50) not null,
	DiaChi nvarchar(30) not null,
	SoDienThoai int not null,
	TaiKhoan nvarchar(20) not null,
	MatKhau nvarchar(20) not null,
	LoaiTaiKhoan nvarchar(20) not null
	)

create table Lop(
	MaLop nvarchar(20) not null primary key,
	TenLop nvarchar(20) not null,
	NienKhoa nvarchar(10) not null,
	SiSo int not null,
	GiaoVienChuNhiem nvarchar(20) not null,
	constraint FK foreign key(GiaoVienChuNhiem) references CanBoGiaoVien(MaCanBoGiaoVien),
)

create table HoSoHocSinh(
	MaHocSinh nvarchar(20) not null primary key,
	HoTen nvarchar(50) not null,
	NgaySinh nvarchar(20) not null,
	GioiTinh nvarchar(4) not null,
	DiaChi nvarchar(30) not null,
	DiemVaoTruong int not null,
	HoTenBoMe nvarchar(50) not null,
	SoDienThoai int not null,
	MaLop nvarchar(20),
	constraint FK1 foreign key(MaLop) references Lop(MaLop),
)


create table MonHoc(
	MaMon nvarchar(20) not null primary key,
	TenMon nvarchar(20) not null,
	SoTiet int not null
)

create table Diem(
	MaHocSinh nvarchar(20) not null,
    MaMonHoc nvarchar(20) not null ,
	DiemTB_Ky1 float not null,
	DiemTB_Ky2 float not null,
	constraint PK primary key(MaHocSinh,MaMonHoc),
	constraint FK2 foreign key(MaHocSinh) references HoSoHocSinh(MaHocSinh),
	constraint FK3 foreign key(MaMonHoc) references MonHoc(MaMon)
)


create table PhanCongGiangDay(
	MaLop nvarchar(20) not null,
	MaMon  nvarchar(20) not null,
	MaCanBoGiaoVien nvarchar(20) not null,
	NgayPhanCong nvarchar(20) not null,
	constraint PK2 primary key(MaLop,MaMon,MaCanBoGiaoVien),
	constraint FK4 foreign key(MaMon) references MonHoc(MaMon),
	constraint FK5 foreign key(MaCanBoGiaoVien) references CanBoGiaoVien(MaCanBoGiaoVien),
	constraint FK6 foreign key(MaLop) references Lop(MaLop)
)
insert into CanBoGiaovien values(N'admin',N'Tran Van Toan',N'Nam Dinh',016273,N'19256',N'admin',N'admin')
insert into CanBoGiaovien values(N'GV01',N'Nguyen Van An',N'Ha Noi',09806,N'12345',N'11111',N'GV')
insert into CanBoGiaovien values(N'GV02',N'Nguyen Thi Lua',N'Hai Duong',07286,N'13579',N'22222',N'GV')




insert into Lop values(N'L01',N'CNTT',N'2015-2019',80,N'GV02')
insert into Lop values(N'L02',N'Dien Tu',N'2015-2019',55,N'GV01')
insert into Lop values(N'L03',N'Ke Toan',N'2015-2019',60,N'GV02')


insert into HoSoHocSinh values(N'HS01',N'Pham Ngoc Anh',N'20/01/1997',N'Nu',N'Hai Phong',22,N'Pham Van Nam',016723,N'L02')
insert into HoSoHocSinh values(N'HS02',N'Tran Thi Lan',N'16/03/1997',N'Nu',N'Thai Binh',21,N'Tran Van Duong',09635,N'L03')
insert into HoSoHocSinh values(N'HS03',N'Dao Ngoc Huy',N'02/05/1996',N'Nam',N'Ninh Binh',20,N'Dao Ngoc Hai',086352,N'L01')



insert into MonHoc values(N'M01',N'Lap trinh can ban',45)
insert into MonHoc values(N'M02',N'Nguyen ly ke toan',45)
insert into MonHoc values(N'M03',N'Toi uu hoa',45)


insert into Diem values(N'HS03',N'M01',7.5,7.0)
insert into Diem values(N'HS01',N'M02',7.0,7.2)
insert into Diem values(N'HS02',N'M03',8.0,8.3)


insert into PhanCongGiangDay values(N'L01',N'M01',N'GV02',N'15/09/2018')
insert into PhanCongGiangDay values(N'L02',N'M03',N'GV02',N'15/09/2018')
insert into PhanCongGiangDay values(N'L03',N'M02',N'GV01',N'15/09/2018')

select *from PhanCongGiangDay
select *from Diem
select *from CanBoGiaoVien
select *from Lop
select *from HoSoHocSinh
select *from MonHoc