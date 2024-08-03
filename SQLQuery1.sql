create database ProductDbRazorPage
go 
use ProductDbRazorPage
go
create table Products(
Id int primary key identity(1,1),
[Name] nvarchar(10) not null,
[Description] nvarchar(10) not null,
Price money not null,
Discount int default(0) not null
) 

select *from Products