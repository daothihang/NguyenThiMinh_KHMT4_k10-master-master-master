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
	DiemTB_Ky1 float,
	DiemTB_Ky2 float,
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


insert into CanBoGiaovien values(N'admin',N'Tran Van Toan',N'Nam Dinh',0162735896,N'TranVanToan',N'admin',N'admin')
insert into CanBoGiaovien values(N'GV01',N'Nguyen Van An',N'Ha Noi',098066452,N'NguyenVanAn',N'11111',N'GV')
insert into CanBoGiaovien values(N'GV02',N'Le Thi Lua',N'Hai Duong',0728696248,N'LeThiLua',N'22222',N'GV')
insert into CanBoGiaovien values(N'GV03',N'Nguyen Van Duong',N'Ha Nam',0980621458,N'NguyenVanDuong',N'33333',N'GV')
insert into CanBoGiaovien values(N'GV04',N'Pham Thi Huong',N'Hai Duong',0728673214,N'PhamThiHuong',N'44444',N'GV')




insert into Lop values(N'L01',N'12A1',N'2015-2019',5,N'GV03')
insert into Lop values(N'L02',N'12A2',N'2015-2019',5,N'GV01')
insert into Lop values(N'L03',N'12A3',N'2015-2019',5,N'GV02')
insert into Lop values(N'L04',N'12A4',N'2015-2019',5,N'GV04')


insert into HoSoHocSinh values(N'HS01',N'Pham Ngoc Anh',N'20/01/1997',N'Nu',N'Thai Binh',22,N'Pham Van Nam',0167158923,N'L01')
insert into HoSoHocSinh values(N'HS02',N'Tran Thi Lan',N'16/03/1997',N'Nu',N'Thai Binh',21,N'Tran Van Duong',0963257855,N'L01')
insert into HoSoHocSinh values(N'HS03',N'Dao Ngoc Huy',N'02/05/1996',N'Nam',N'Thai Binh',20,N'Dao Ngoc Hai',0863458752,N'L01')
insert into HoSoHocSinh values(N'HS04',N'Le Ngoc Son',N'02/08/1997',N'Nam',N'Thai Binh',22,N'Le Ngoc Nam',0167179523,N'L01')
insert into HoSoHocSinh values(N'HS05',N'Vu Thi Ngoc',N'08/07/1997',N'Nu',N'Thai Binh',19,N'Vu Van Dai',0969637855,N'L01')


insert into HoSoHocSinh values(N'HS06',N'Nguyen Duc Manh',N'06/05/1997',N'Nam',N'Thai Binh',22,N'Nguyen Duc Trong',0973452541,N'L02')
insert into HoSoHocSinh values(N'HS07',N'Dinh Thanh Son',N'03/09/1997',N'Nam',N'Thai Binh',23,N'Dinh Thanh Tuan',0828892541,N'L02')
insert into HoSoHocSinh values(N'HS08',N'Vu Thi Nhan',N'09/02/1997',N'Nu',N'Thai Binh',20,N'Nguyen Duc Hiep',0867896541,N'L02')
insert into HoSoHocSinh values(N'HS09',N'Le Thanh Thu',N'05/11/1997',N'Nu',N'Thai Binh',20,N'Le Thanh Nam',0963452541,N'L02')
insert into HoSoHocSinh values(N'HS10',N'Tran Phuong Nam',N'06/10/1997',N'Nam',N'Thai Binh',22,N'Tran Phuong Tuan',0863452541,N'L02')

insert into HoSoHocSinh values(N'HS11',N'Nguyen Trung Kien',N'20/03/1997',N'Nam',N'Thai Binh',19,N'Nguyen Trung Toan',0164655723,N'L03')
insert into HoSoHocSinh values(N'HS12',N'Bui Thai Hoang',N'21/03/1997',N'Nam',N'Thai Binh',21,N'Bui Thai Chinh',0945698635,N'L03')
insert into HoSoHocSinh values(N'HS13',N'Le Thi Thanh Thu',N'12/09/1997',N'Nu',N'Thai Binh',24,N'Le Van Hai',0863521254,N'L03')
insert into HoSoHocSinh values(N'HS14',N'Trinh Van Tu',N'25/03/1997',N'Nam',N'Thai Binh',23,N'Trinh Van Son',0963152345,N'L03')
insert into HoSoHocSinh values(N'HS15',N'Vu Duy Huy',N'15/04/1997',N'Nam',N'Thai Binh',20,N'Vu Duy Khanh',0876386352,N'L03')


insert into HoSoHocSinh values(N'HS16',N'Pham Ngoc Diep',N'24/03/1997',N'Nu',N'Thai Binh',22,N'Pham Van Bac',0167754223,N'L04')
insert into HoSoHocSinh values(N'HS17',N'Tran Cao Thang',N'16/08/1997',N'Nam',N'Thai Binh',24.5,N'Tran Van Duong',0963124565,N'L04')
insert into HoSoHocSinh values(N'HS18',N'Le Thi Tra My',N'26/09/1996',N'Nu',N'Thai Binh',25,N'Le Van Bach',0863777952,N'L04')
insert into HoSoHocSinh values(N'HS19',N'Pham Hai Yen',N'10/01/1997',N'Nu',N'Thai Binh',22.25,N'Pham Van Hung',01699923723,N'L04')
insert into HoSoHocSinh values(N'HS20',N'Hoang Thanh Mai',N'28/12/1997',N'Nu',N'Thai Binh',28,N'Hoang The Hiep',0964566835,N'L04')


insert into MonHoc values(N'M01',N'Toan',45)
insert into MonHoc values(N'M02',N'Van',45)
insert into MonHoc values(N'M03',N'Anh',45)

insert into Diem values(N'HS01',N'M01',7.0,7.2)
insert into Diem values(N'HS01',N'M02',6.8,7.2)
insert into Diem values(N'HS01',N'M03',7.0,8.0)


insert into Diem values(N'HS02',N'M01',7.7,7.0)
insert into Diem values(N'HS02',N'M02',6.5,8.0)
insert into Diem values(N'HS02',N'M03',8.0,8.3)

insert into Diem values(N'HS03',N'M01',8.2,9.0)
insert into Diem values(N'HS03',N'M02',9.5,8.0)
insert into Diem values(N'HS03',N'M03',8.0,7.8)

insert into Diem values(N'HS04',N'M01',5.6,4.8)
insert into Diem values(N'HS04',N'M02',5.2,6.2)
insert into Diem values(N'HS04',N'M03',4.2,6.8)


insert into Diem values(N'HS05',N'M01',8.2,7.8)
insert into Diem values(N'HS05',N'M02',5.5,6.5)
insert into Diem values(N'HS05',N'M03',7.7,8.3)

insert into Diem values(N'HS06',N'M01',6.5,7.0)
insert into Diem values(N'HS06',N'M02',7.3,8.0)
insert into Diem values(N'HS06',N'M03',6.5,7.3)

insert into Diem values(N'HS07',N'M01',8.3,7.0)
insert into Diem values(N'HS07',N'M02',6.3,7.0)
insert into Diem values(N'HS07',N'M03',5.6,6.3)


insert into Diem values(N'HS08',N'M01',7.5,7.0)
insert into Diem values(N'HS08',N'M02',7.0,7.2)
insert into Diem values(N'HS08',N'M03',8.0,8.3)

insert into Diem values(N'HS09',N'M01',7.0,7.0)
insert into Diem values(N'HS09',N'M02',8.0,7.2)
insert into Diem values(N'HS09',N'M03',8.0,8.5)

insert into Diem values(N'HS10',N'M01',8.0,7.0)
insert into Diem values(N'HS10',N'M02',8.5,7.5)
insert into Diem values(N'HS10',N'M03',8.2,8.5)

insert into Diem values(N'HS11',N'M01',8.0,7.2)
insert into Diem values(N'HS11',N'M02',8.0,7.9)
insert into Diem values(N'HS11',N'M03',8.2,8.6)

insert into Diem values(N'HS12',N'M01',8.0,7.8)
insert into Diem values(N'HS12',N'M02',8.5,7.0)
insert into Diem values(N'HS12',N'M03',8.2,8.1)

insert into Diem values(N'HS13',N'M01',8.0,8)
insert into Diem values(N'HS13',N'M02',8.5,6.5)
insert into Diem values(N'HS13',N'M03',8.2,7.0)

insert into Diem values(N'HS14',N'M01',8.0,6.2)
insert into Diem values(N'HS14',N'M02',8.5,7.4)
insert into Diem values(N'HS14',N'M03',7.0,8.3)

insert into Diem values(N'HS15',N'M01',8.0,7.7)
insert into Diem values(N'HS15',N'M02',8.5,7.9)
insert into Diem values(N'HS15',N'M03',8.2,8.5)

insert into Diem values(N'HS16',N'M01',7.5,8.0)
insert into Diem values(N'HS16',N'M02',7.9,6.2)
insert into Diem values(N'HS16',N'M03',8.7,8.3)

insert into Diem values(N'HS17',N'M01',8.5,8.0)
insert into Diem values(N'HS17',N'M02',7.2,6.2)
insert into Diem values(N'HS17',N'M03',8.2,7.9)

insert into Diem values(N'HS18',N'M01',5.5,6.0)
insert into Diem values(N'HS18',N'M02',4.9,5.2)
insert into Diem values(N'HS18',N'M03',8.7,8.4)

insert into Diem values(N'HS19',N'M01',6.9,7.0)
insert into Diem values(N'HS19',N'M02',8.9,9.0)
insert into Diem values(N'HS19',N'M03',7.7,8.0)

insert into Diem values(N'HS20',N'M01',5.5,5.0)
insert into Diem values(N'HS20',N'M02',7.2,6.2)
insert into Diem values(N'HS20',N'M03',8.1,8.1)


insert into PhanCongGiangDay values(N'L01',N'M01',N'GV01',N'15/09/2018')
insert into PhanCongGiangDay values(N'L01',N'M02',N'GV04',N'16/09/2018')
insert into PhanCongGiangDay values(N'L01',N'M03',N'GV02',N'18/09/2018')

insert into PhanCongGiangDay values(N'L02',N'M02',N'GV03',N'15/09/2018')
insert into PhanCongGiangDay values(N'L02',N'M02',N'GV02',N'18/09/2018')
insert into PhanCongGiangDay values(N'L02',N'M02',N'GV01',N'16/09/2018')

insert into PhanCongGiangDay values(N'L03',N'M01',N'GV01',N'15/09/2018')
insert into PhanCongGiangDay values(N'L03',N'M03',N'GV02',N'20/09/2018')
insert into PhanCongGiangDay values(N'L03',N'M02',N'GV04',N'17/09/2018')

insert into PhanCongGiangDay values(N'L04',N'M01',N'GV02',N'15/09/2018')
insert into PhanCongGiangDay values(N'L04',N'M03',N'GV04',N'16/09/2018')
insert into PhanCongGiangDay values(N'L04',N'M02',N'GV01',N'18/09/2018')

select *from PhanCongGiangDay
select *from Diem
select *from CanBoGiaoVien
select *from Lop
select *from HoSoHocSinh
select *from MonHoc