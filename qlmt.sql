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
	product_id int,
	foreign key (product_id) references product(id),
	users_id int,
	foreign key (users_id) references users(id),
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

INSERT INTO options(ram, storage, quantity, importPrice, sellingPrice, product_id) VALUES ('100bg','100tb',11,15,55,2)
select * from options
create table role(
	id int identity(1,1) primary key,
	roles nvarchar(30)
);
		ALTER TABLE users
ADD role_id int,
FOREIGN KEY (role_id) REFERENCES role(id);

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
