﻿Create database BookStore
go
use BookStore
go
Create table Publisher
(
	PublisherId int identity primary key,
	PublisherName nvarchar(200),
	Phone varchar(30),
	Address nvarchar(200)
)
go
Create table Category
(
	CategoryId int identity primary key,
	CategoryName nvarchar(100)
)
go
Create table Book
(
	BookId varchar(10) primary key,
	Title nvarchar(200) not null,
	Author nvarchar(100),
	Release int,
	Price float,
	Description ntext,
	Picture nvarchar(100),
	PublisherId int foreign key references Publisher(PublisherId),
	CategoryId int foreign key references Category(CategoryId)
)
go
Create table Account
(
	AccountId varchar(36) primary key,
	Username varchar(64) not null,
	Password varchar(256),
	FullName nvarchar(100),
	Picture varchar(512),
	Email varchar(64),
	Address nvarchar(512),
	Phone varchar(64),
	IsAdmin bit,
	Active bit
)
go
Create table OrderBook
(
	OrderId varchar(16) primary key,
	OrderDate datetime,
	AccountId varchar(36) foreign key references Account(AccountId),
	ReceiveAddress nvarchar(512),
	ReceivePhone varchar(64),
	OrderReceive datetime,
	Note nvarchar(512),
	Status varchar(16)
)
Create table OrderDetail
(
	OrderDetailId int identity primary key,
	OrderId varchar(16) foreign key references OrderBook(OrderId),
	BookId varchar(10) foreign key references Book(BookId),
	Quantity int,
	Price int,
	TotalMoney as Quantity*Price
)
go
insert into Publisher values(N'Nhà xuất bản trẻ','098746533',N'Hà Nội')
insert into Publisher values(N'Nhà xuất bản kim đồng','096833435',N'Hà Nội')
insert into Publisher values(N'Nhà xuất bản tri thức','097987653',N'Hà Nội')
insert into Publisher values(N'Nhà xuất bản giáo dục','091956464',N'Hà Nội')
insert into Publisher values(N'Nhà xuất bản lao động','091956464',N'Hà Nội')

insert into Category values(N'Sách kinh tế')
insert into Category values(N'Sách tin học')
insert into Category values(N'Sách thiếu nhi')
insert into Category values(N'Sách nấu ăn')
insert into Category values(N'Sách văn học')



insert Book values('P67934',N'Đường Đến Thành Công Của Jack Ma',N'Brad Schepp, Debra Schepp',2015,250000,N'chưa có mô tả','images/books/P67934.jpg',5,1)
insert Book values('P68050',N'Đừng Bao Giờ Đi Ăn Một Mình',N'Tahl Raz, Keith Ferrazzi',2016,95000,N'chưa có mô tả','images/books/P68050.jpg',1,1)
insert Book values('P68066',N'Vô Thường',N'Nguyễn Bảo Trung',2016,75000,N'chưa có mô tả','images/books/P68066.jpg',5,5)
insert Book values('P68009',N'Siêu Mèo Capoo',N'Á Lạp',2016,5800,N'chưa có mô tả','images/books/P68009.jpg',2,3)
insert Book values('P67842',N'Shin - Cậu Bé Bút Chì',N'Yoshito Usui ',2016,18000,N'chưa có mô tả','images/books/P67842.jpg',2,3)
insert Book values('P67848',N'Chie - Cô Bé Hạt Tiêu',N'Etsumi Haruki',2016,28000,N'chưa có mô tả','images/books/P67848.jpg',2,3)
insert Book values('P63952',N'Kung Fu Panda',N'Ngọc Linh',2016,28500,N'chưa có mô tả','images/books/P63952.jpg',2,3)
insert Book values('P68102',N'Dạy Con Làm Giàu - Tập 9: Những Bí Mật Về Tiền Bạc Mà Bạn Không Học Ở Nhà Trường!',N'Robert T. Kiyosaki',2015,32000,N'chưa có mô tả','images/books/P68102.jpg',1,1)
insert Book values('P68101',N'Dạy Con Làm Giàu - Tập 8: Để Có Những Đồng Tiền Tích Cực',N'Robert T. Kiyosaki',2015,32000,N'chưa có mô tả','images/books/P68101.jpg',1,1)
insert Book values('P67957',N'36 Kế Trong Kinh Doanh Hiện Đại',N'Lan Bercu',2016,95000,N'chưa có mô tả','images/books/P67957.jpg',1,1)
insert Book values('P67821',N'Mật Mã Champa - Phát Hành Dự Kiến',N'Giản Tư Hải',2016,113000,N'chưa có mô tả','images/books/P67821.jpg',1,5)
insert Book values('P67687',N'Vui buồn trong hộp',N'Đoàn Bảo Châu',2015,250000,N'chưa có mô tả','images/books/P67687.jpg',1,5)

insert into Account values(NEWID(),'admin',lower(CONVERT(VARCHAR(32), HashBytes('md5', 'admin123456'), 2)),N'Lại Đức Chung','images/accounts/chunngld.jpg','chungld.hanam@gmail.com','Hà Nam','0968018161',1,1)
insert into Account values(NEWID(),'member01',lower(CONVERT(VARCHAR(32), HashBytes('md5', 'member01123456'), 2)),N'Nguyễn Thị Hòa','images/members/hoant.jpg','baohoa@gmail.com','Hà Nam','0968018162',0,1)
insert into OrderBook values('20200526102704','2020-05-26','37BFD99C-648C-402C-8B01-56C46E58B3F5','Hà Nam','0968018162',getdate(),N'Giao hàng giờ hành chính','New')
insert into OrderDetail(OrderId,BookId,Quantity,Price) values('20200526102704','P68050',2,95000)
insert into OrderDetail(OrderId,BookId,Quantity,Price) values('20200526102704','P67934',2,250000)
insert into OrderDetail(OrderId,BookId,Quantity,Price) values('20200526102704','P68102',1,32000)


