﻿create database [E-Commerce Database];
use [E-Commerce Database];

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
	Name varchar(5) not null
);

create table [d.Users] (
	Id int identity(1,1) primary key,
	UserName varchar(20) not null,
	FirstName varchar(20),
	LastName varchar(20),
	Email varchar(50) not null,
	Password varchar(250) not null
);

create table [d.Authors] (
	Id smallint identity(1,1) primary key,
	AuthorName varchar(20) not null,
	Presentation varchar(50),
	Email varchar(50) not null,
	Password varchar(250) not null
);

create table [d.Products] (
	Id bigint identity(1,1) primary key,
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
	Id bigint primary key,
	Src varchar(250) not null,
	Alt varchar(50),
	Width int not null,
	Heigth int not null
);

create table [d.Reviews] (
	Id bigint identity(1,1) primary key,
	Author varchar(20) not null,
	AuthorId smallint foreign key references [d.Authors](Id),
	Body varchar(5000) not null,
	Rate decimal(2,1) not null
);

create table [d.Commentaries] (
	Id bigint identity(1,1) primary key,
	UserName varchar(20) not null,
	Body varchar(5000) not null,
	IsEdited bit not null,
	Likes int not null,
	Dislikes int not null
);