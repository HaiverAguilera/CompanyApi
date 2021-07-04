create database Companies
GO
create table Company(
	Id int primary key identity (1, 1) not null,
	IdentificationType varchar(50) not null,
	IdentificationNumber int  not null,
	CompanyName varchar(50) not null,
	FirstName varchar(50) not null,
	SecondName varchar(50),
	FirstLastName varchar(50) not null,
	SecondLastName varchar(50),
	Email varchar(50) not null,
	AuthorizeCellPhoneMessages bit,
	AuthorizeEmailMessages bit
)
GO
insert into Company values
(
'NIT',
900674336,
'Sony',
'Dereck',
'Alexander',
'Gonzalez',
'Aguilera',
'hnaguilera0310@gmail.com',
0,
1
)
GO
insert into Company values
(
'NIT',
811033098,
'Walmart',
'Haiver',
'Nicolás',
'Aguilera',
'Gómez',
'hnaguilera0310@gmail.com',
1,
0
)