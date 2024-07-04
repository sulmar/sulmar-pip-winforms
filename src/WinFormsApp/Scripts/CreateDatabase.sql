create database InspectorsDb

go

use InspectorsDb

go

create table Inspectors(
	InspectorId int primary key identity(1,1),
	Number nvarchar(10) NOT NULL,
	FirstName nvarchar(50) NOT NULL,
	LastName nvarchar(50) NOT NULL,
	Department nvarchar(10) NOT NULL,
	Year int NOT NULL
)

go


use InspectorsDb

insert into Inspectors(Number, FirstName, LastName, Department, Year)
values 
	('001', 'John', 'Smith', 'S01', 2024),
	('002', 'Mark', 'Sipder', 'S02', 2024),
	('003', 'Mariah', 'Buterfly', 'S01', 2024),
	('004', 'Bob', 'Liberty', 'S02', 2024)

go



create table Users(
	UserId int primary key identity(1,1),
	Username nvarchar(20) NOT NULL,
)

go

create table Documents(
	DocumentId int primary key identity(1,1),
	Title nvarchar(50) NOT NULL,
	UserFk nvarchar(10) NOT NULL,
	AcceptDate DateTime2 NOT NULL
)

go


use InspectorsDb

insert into Users(Username)
values 
	('marcin'),
	('michal'),
	('damian')

go

use InspectorsDb

insert into Documents(Title, UserFk, AcceptDate)
values 
	('Doc_1/1/24', 'michal', '2024-01-01'),
	('Doc_2/1/24', 'michal', '2024-01-01'),
	('Doc_3/1/24', 'michal', '2024-01-02'),
	('Doc_1/2/23', 'damian', '2023-02-01'),
	('Doc_2/2/23', 'michal', '2024-02-02'),
	('Doc_3/2/23', 'michal', '2024-03-30'),
	('Doc_5/5/24', 'marcin', '2024-05-01'),
	('Doc_6/5/24', 'marcin', '2024-05-01'),
	('Doc_7/5/24', 'marcin', '2024-05-02')

go