create database [E-Commerce Database];

use [E-Commerce Database];
go;

create table [c.Currencies] (
	Id tinyint primary key,
	Symbol varchar(5) not null,
	Name varchar(20) not null,
	Issuer varchar(20)
);

create table [c.Categories] (
	Id tinyint primary key,
	Name varchar(10) not null
);

create table [c.Gender] (
	Id tinyint primary key,
	name varchar(5) not null
);

create table [d.Products] (
	Id bigint primary key,
	Name varchar(50) not null,
	Description varchar(5000) not null,
	Price smallmoney,
	CurrencyId tinyint foreign key references [c.Currencies](Id),
	Discount decimal(5,2),
	QuantityAvailable smallint,
	SalesAmount smallint not null,
	Rate decimal(2,1),
	Visits int not null,
	CategoryId tinyint foreign key references [c.Categories](Id),
	GenderId tinyint foreign key references [c.Gender](Id),
	CreationDate datetime not null
);

create table [d.Images] (
	Id bigint primary key
);

create table [d.Reviews] (
	Id bigint identity(1,1) primary key
);

create table [d.Commentaries] (
	Id bigint identity(1,1) primary key
);