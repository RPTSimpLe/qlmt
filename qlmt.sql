create database qlmt;
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
	foreign key (category_id) references category(id),
	
	
);
create table producer_product(
	id int identity(1,1) primary key,
	product_id int,
	foreign key (product_id) references product(id),
	producer_id int,
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