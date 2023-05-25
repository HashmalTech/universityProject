create database SIMS
use SIMS
create table Students (
	StudentId int identity primary key , 
	FirstName varchar(50) not null, 
	Lastname varchar(50) not null,
	Email varchar(50)
)
go
create procedure abcd as
select * from Students


select * from Students