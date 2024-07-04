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