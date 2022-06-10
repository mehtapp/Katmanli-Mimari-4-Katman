
--Category

alter proc CategoryList
as begin
Select * from [dbo].[Categories]
end


create proc AddCategory
@CategoryName varchar(100)
as begin
insert into [dbo].[Categories](CategoryName) values (@CategoryName)
end
exec AddCategory 'Soba'

create proc UpdateCategory
@CategoryId varchar(36),
@CategoryName varchar(100)
as begin
Update [dbo].[Categories] set CategoryName=@CategoryName where CategoryId=@CategoryId
end

create proc DeleteCategory
@CategoryId varchar(36)
as begin 
Delete from [dbo].[Categories] where CategoryId=@CategoryId
end


--Customer

create proc CustomerList
as begin 
Select * from Customers
end

alter proc AddCustomer
@NameSurname varchar(100),
@adress varchar(100),
@mail varchar(100),
@phone varchar(100)
as begin 
insert into [dbo].[Customers](CustomerNameSurname, CustomerAdress, CustomerMail, CustomerPhone) 
values (@NameSurname, @adress, @mail, @phone)
end

alter proc UpdateCustomer
@custId int,
@NameSurname varchar(100),
@adress varchar(100),
@mail varchar(100),
@phone varchar(100)
as begin
Update [dbo].[Customers] set CustomerNameSurname=@NameSurname, CustomerAdress=@adress, CustomerMail=@mail, CustomerPhone=@phone where CustomerId= @custId
end

create proc DelCustomer
@custId int
as begin
delete from [dbo].[Customers] where CustomerId=@custId
end


 --Product
alter proc ProductList
as begin 
Select * from Products
end

alter proc AddProduct
@productName varchar(100),
@unitPrice money,
@catId varchar(36)
as begin 
insert into [dbo].[Products] (ProductName, UnitPrice, CategoryId) values (@productName, @unitPrice, @catId)
end

alter proc UpdateProduct
@productId int,
@productName varchar(100),
@unitPrice money,
@catId varchar(36)
as begin 
Update [dbo].[Products] set ProductName=@productName, UnitPrice=@unitPrice, CategoryId=@catId where ProductId=@productId
end

create proc DelProduct
@productId int
as begin 
Delete from [dbo].[Products] where ProductId=@productId
end

--Employee
alter proc findEmployeeId
@userName varchar(50)
as begin
Select employeeId from Employees where userName=@userName
end

create proc LoginEmployee
@userName varchar(50),
@password varchar(50)
as begin
Select * from [dbo].[Employees] where userName=@userName and password=@password
end

create proc AddEmployee
@nameSurname varchar(100),
@userName varchar(50),
@password varchar(50)
as begin 
insert into [dbo].[Employees] (nameSurname,userName, password) values (@nameSurname, @userName, @password)
end

--Order

create proc OrderList
as begin
Select * from [dbo].[Orders]
end

create proc AddOrder
@ProductId int,
@CustomerId int,
@OrderDate date,
@DeliveryDate date,
@Quantity int, 
@TotalPrice money,
@DeliveryStatus varchar(50),
@employeeId int
as begin
insert into [dbo].[Orders](ProductId, CustomerId, OrderDate, DeliveryDate, Quantity, TotalPrice, DeliveryStatus, employeeId) 
values(@ProductId, @CustomerId, @OrderDate, @DeliveryDate, @Quantity, @TotalPrice, @DeliveryStatus, @employeeId)
end

alter proc UpdateOrder
@OrderId int,
@ProductId int,
@CustomerId int,
@DeliveryDate date,
@Quantity int, 
@TotalPrice money,
@DeliveryStatus varchar(50),
@employeeId int
as begin
update [dbo].[Orders] set ProductId=@ProductId, CustomerId=@CustomerId, DeliveryDate=@DeliveryDate, Quantity=@Quantity, TotalPrice=@TotalPrice,
DeliveryStatus=@DeliveryStatus, employeeId=@employeeId where OrderId= @OrderId
end


create proc DeleteOrder
@OrderId int
as begin
Delete from [dbo].[Orders] where OrderId=@OrderId
end

