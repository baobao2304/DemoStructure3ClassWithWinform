drop database DBGhiDanh
create database DBGhiDanh
use DBGhiDanh
create table MonHoc
(
	maMonHoc nvarchar(100) primary key,
	tenMonHoc nvarchar(100)
)
create table GhiDanh
(
	maGhiDanh nvarchar(100) primary key,
	hoVaTen nvarchar(100),
	ngaySinh date,
	gioiTinh nvarchar(100),
	dienThoai nvarchar(100),
	email nvarchar(100),
	maMonHoc nvarchar(100),
	buoiHoc int,
	thiXepLop bit,
	Constraint FK_GhiDanh_MonHoc foreign key (maMonHoc) references MonHoc(maMonHoc)
)

insert into monhoc values ('TKUD',N'Thống kê ứng dụng');
insert into monhoc values ('CNLM',N'Công nghệ lên men');
insert into monhoc values ('LTW',N'Lập trình web');
insert into monhoc values ('CTDL',N'Cấu trúc dữ liệu');
insert into monhoc values ('NLM',N'Nguyên lý máy');

go
insert into GhiDanh values('TFL1',N'Pham  Le ','11/07/1994',N'Nam','0123457789','byew11@gmail.com','CTDL',2,1)
insert into GhiDanh values('TFL2',N' Van Le Bao','12/07/1999',N'Nam','0123636789','byew1122@gmail.com','CTDL',2,1)
insert into GhiDanh values('TFL3',N'Pham Van Le ','8/08/1998',N'Nam','0123456789','byew1df@gmail.com','NLM',2,1)
insert into GhiDanh values('TFL4',N'Pham Van  Bao','1/09/1996',N'Nam','0123456789','byewsdf11@gmail.com','CNLM',2,1)
insert into GhiDanh values('TFL5',N'Pham  Le Bao','3/04/1995',N'Nam','0123456789','byew1sdf1@gmail.com','NLM',2,1)

select * from MonHoc
select * from GhiDanh