﻿create database qlmt;
use qlmt;
create table category(
	id int identity(1,1) primary key,
	code varchar(10),
	nameCategory nvarchar(25),

);
create table producer(
	id int identity(1,1) primary key,
	code varchar(10),
	nameProducer nvarchar(25),
	);

create table users(
	id int identity(1,1) primary key,
	fullname nvarchar(30),
	username nvarchar(30),
	gender nvarchar(30),
	pass nvarchar(30),
	phone nvarchar(10),
	birthday date,
	address nvarchar(255),
	email varchar(255),
		);
ALTER TABLE users
ADD role_id int,
FOREIGN KEY (role_id) REFERENCES role(id);
create table customers(
	id int identity(1,1) primary key,
	fullname nvarchar(30),
	phone nvarchar(10),
	addres nvarchar(255),

);
-- INSERT INTO customers (fullname, phone, addres) VALUES (N'abc', '02164354','5 sdsdfsdf sdvsdfsd')
-- select * from customers
create table product(
	id int identity(1,1) primary key,
	nameProduct nvarchar(30),
	years int,
	descriptions text,
	warranty nvarchar(30),
	category_id int,
	producer_id int,
	foreign key (category_id) references category(id),
	foreign key (producer_id) references producer(id),
);
create table images(
	id int identity(1,1) primary key,
	url varchar(500),
	product_id int,
	foreign key (product_id) references product(id),
);
create table options(
	id int identity(1,1) primary key,
	ram varchar(50),
	storage varchar(50),
	quantity bigint,
	importPrice bigint,
	sellingPrice bigint,
	product_id int,
	foreign key (product_id) references product(id),
)
--INSERT INTO options(ram, storage, quantity, importPrice, sellingPrice, product_id) VALUES ('100bg','100tb',11,15,55,2)
--select * from options
--select id from options where ram =  '1' and storage = '1' and sellingPrice= '1'
create table bill(
	id varchar(50) primary key,
	customer_id int,
	created_at date,
	foreign key (customer_id) references customers(id),
)
create table detailBill(
	id int identity(1,1) primary key,
	quantity bigint,
	price bigint,
	bill_id varchar(50),
	options_id int,
	foreign key (options_id) references options(id),
	foreign key (bill_id) references bill(id)
)
--insert into bill (id,customer_id) values ('HD001',2)
-- insert into detailBill (quantity,price,bill_id,options_id) values (55,8,'HD004',9)
--select * from bill
--select * from detailBill
create table incomeStatistics(
	id int identity(1,1) primary key,
	nameProduct nvarchar(100),
	nameOptions nvarchar(100),
	sellQuantity int,
	sellPrice bigint,
	created_at date,
)
create table expense_statistics(
	id int identity(1,1) primary key,
	nameProduct nvarchar(100),
	nameOptions nvarchar(100),
	importQuantity int,
	importPrice bigint,
	created_at date,
)
create table role(
	id int identity(1,1) primary key,
	roles nvarchar(30)
);

INSERT INTO role (roles) VALUES ('ADMIN'), ('USER');
-- drop function findCategoryId
create function findCategoryId(@nameCategory nvarchar(30))
returns int
as
begin
	return (select category.id from category where category.nameCategory = @nameCategory)
end

-- drop function findCProducerId
create function findCProducerId(@nameProducer nvarchar(30))
returns int
as
begin
	return (select producer.id from producer where producer.nameProducer = @nameProducer)
end

-- chạy từng lệnh create
--drop proc sp_insert_product
create proc sp_insert_product
	@nameProduct nvarchar(30),
	@years int,
	@descriptions text,
	@warranty nvarchar(30),
	@nameCategory nvarchar(30),
	@nameProducer nvarchar(30)
as
begin
	declare @categoryId int
		set @categoryId = dbo.findCategoryId(@nameCategory)
	declare @producerId int
		set @producerId = dbo.findCProducerId(@nameProducer)
	insert into product(nameProduct,years,descriptions,warranty,category_id,producer_id)
	values(@nameProduct,@years,@descriptions,@warranty,@categoryId,@producerId)

--	PRINT 'categoryId: ' + CAST(@categoryId AS nvarchar)
--	PRINT 'producerId: ' + CAST(@producerId AS nvarchar)
end

--insert into category(code,nameCategory) values (11,'category1')
--insert into producer(code,nameProducer) values (11,'prodcer1')

--select * from category
--select * from producer

--exec sp_insert_product N'lenovo tuf f15',2020,'sđâsdsad',N'4 tháng',N'category1',N'prodcer1'
--select * from product

-- drop proc sp_update_product
create proc sp_update_product
	@id bigint,
	@nameProduct nvarchar(30),
	@years int,
	@descriptions text,
	@warranty nvarchar(30),
	@nameCategory nvarchar(30),
	@nameProducer nvarchar(30)
as
begin
	declare @categoryId int
		set @categoryId = dbo.findCategoryId(@nameCategory)
	declare @producerId int
		set @producerId = dbo.findCProducerId(@nameProducer)
	update product set nameProduct = @nameProduct,years = @years,descriptions = @descriptions,warranty = @warranty,
	category_id = @categoryId,producer_id = @producerId
	where id = @id
--	PRINT 'categoryId: ' + CAST(@categoryId AS nvarchar)
--	PRINT 'producerId: ' + CAST(@producerId AS nvarchar)
end

--exec sp_update_product 2,N'asus tuf f20',2020,'test',N'4 tháng',N'category1',N'prodcer1'
--select * from product
--select * from options 

create proc sp_select_product
	@nameProduct nvarchar(50),
	@nameCategory nvarchar(30),
	@nameProducer nvarchar(30)
as
begin

	SELECT 
		product.id AS [ID], 
		product.nameProduct AS [Tên sản phẩm],
		category.nameCategory AS [Loại], 
		producer.nameProducer AS [Hãng], 
		CASE 
			WHEN Sum(options.quantity) IS NULL THEN 0
			ELSE Sum(options.quantity)
		END AS [Tồn kho]
	FROM 
		product  
	JOIN 
		category ON category.id = product.category_id 
	JOIN 
		producer ON producer.id = product.producer_id  
	LEFT JOIN 
		options ON options.product_id = product.id
	where category.nameCategory like @nameCategory and producer.nameProducer like @nameProducer
	and product.nameProduct like @nameProduct
	GROUP BY 
		product.id, product.nameProduct, category.nameCategory, producer.nameProducer;
--	PRINT 'categoryId: ' + CAST(@categoryId AS nvarchar)
--	PRINT 'producerId: ' + CAST(@producerId AS nvarchar)
end
-- drop proc sp_select_bill
create proc sp_select_bill
	@id varchar(10),
	@tenKh varchar(20)
as
begin
	select bill.id as [MaHD],sum(detailBill.price) as [tongTien],
		customers.fullname as [tenkh], bill.created_at as [ngaytao]
	from bill
	join detailBill on detailBill.bill_id = bill.id
	join options on options.id = detailBill.options_id
	join product on options.product_id = product.id
	join customers on customers.id = bill.customer_id
	where bill.id like @id and customers.fullname like @tenkh
	Group by bill.id,product.nameProduct, customers.fullname ,bill.created_at
end
-- exec sp_select_bill '%44%' , '%%'
--select * from users
--select * from role
INSERT INTO users (fullname, username, pass, phone, gender, birthday, address, email, role_id) VALUES ('ltd', 'admin', 'employee', 'admin', 'nam', '2022-11-22', 'xc dfsdksf', 'bhdsfb@gmail.com', 1)
INSERT INTO users (fullname, username, pass, phone, gender, birthday, address, email, role_id) VALUES ('ltd', 'user', 'employee', 'user', 'nam', '2022-11-22', 'xc dfsdksf', 'bhdsfb@gmail.com', 2)
-- DELETE FROM bill WHERE id = 'HD062'
create proc sp_select_feature_bill
	@id varchar(10)
as
begin
	select top 1 bill.id as [MaHD],sum(detailBill.price) as [tongTien],
		customers.fullname as [tenkh],customers.phone as [dienthoai],customers.addres as [diachi], bill.created_at as [ngaytao]
	from bill
	join detailBill on detailBill.bill_id = bill.id
	join options on options.id = detailBill.options_id
	join product on options.product_id = product.id
	join customers on customers.id = bill.customer_id
	where bill.id = @id
	Group by bill.id,product.nameProduct, customers.fullname ,bill.created_at,customers.phone ,customers.addres 
	ORDER BY bill.created_at DESC
end

CREATE PROC sp_select_productById
    @idPro INT
AS
BEGIN
    DECLARE @tonKho BIGINT

    IF (SELECT SUM(options.quantity) FROM options WHERE product_id = @idPro) IS NULL
        SET @tonKho = 0
    ELSE
        SET @tonKho = (SELECT SUM(options.quantity) FROM options WHERE product_id = @idPro)

    SELECT 
        product.id AS [ID], 
        product.nameProduct AS [Tên sản phẩm],
        product.warranty AS [Bảo hành],
        product.descriptions AS [Mô tả],
        product.years AS [Năm sx],
        category.nameCategory AS [Loại], 
        producer.nameProducer AS [Hãng],
        @tonKho AS [Tồn kho]
    FROM 
        product
    JOIN 
        category ON category.id = product.category_id
    JOIN 
        producer ON producer.id = product.producer_id
    WHERE 
        product.id = @idPro
END
--exec sp_select_productById 24;
--select * from incomeStatistics
--delete from incomeStatistics where id = 9
--select * from expense_statistics