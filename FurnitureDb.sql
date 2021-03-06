USE [master]
GO
/****** Object:  Database [FurnitureDB]    Script Date: 10.06.2022 11:35:16 ******/
CREATE DATABASE [FurnitureDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FurnitureDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\FurnitureDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'FurnitureDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\FurnitureDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [FurnitureDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FurnitureDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FurnitureDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FurnitureDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FurnitureDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FurnitureDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FurnitureDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [FurnitureDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FurnitureDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FurnitureDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FurnitureDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FurnitureDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FurnitureDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FurnitureDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FurnitureDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FurnitureDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FurnitureDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FurnitureDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FurnitureDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FurnitureDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FurnitureDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FurnitureDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FurnitureDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FurnitureDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FurnitureDB] SET RECOVERY FULL 
GO
ALTER DATABASE [FurnitureDB] SET  MULTI_USER 
GO
ALTER DATABASE [FurnitureDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FurnitureDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FurnitureDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FurnitureDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [FurnitureDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [FurnitureDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'FurnitureDB', N'ON'
GO
ALTER DATABASE [FurnitureDB] SET QUERY_STORE = OFF
GO
USE [FurnitureDB]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 10.06.2022 11:35:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryId] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
	[CategoryName] [varchar](100) NULL,
 CONSTRAINT [PK_Categories_1] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 10.06.2022 11:35:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerId] [int] IDENTITY(1,1) NOT NULL,
	[CustomerNameSurname] [varchar](100) NULL,
	[CustomerAdress] [varchar](100) NULL,
	[CustomerMail] [varchar](100) NULL,
	[CustomerPhone] [char](11) NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 10.06.2022 11:35:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[employeeId] [int] IDENTITY(1,1) NOT NULL,
	[nameSurname] [varchar](100) NULL,
	[userName] [varchar](50) NOT NULL,
	[password] [varchar](50) NULL,
 CONSTRAINT [PK_Employees_1] PRIMARY KEY CLUSTERED 
(
	[employeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 10.06.2022 11:35:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderId] [int] IDENTITY(1,1) NOT NULL,
	[ProductID] [int] NULL,
	[CustomerId] [int] NULL,
	[OrderDate] [date] NULL,
	[DeliveryDate] [date] NULL,
	[Quantity] [int] NULL,
	[TotalPrice] [money] NULL,
	[DeliveryStatus] [varchar](50) NULL,
	[employeeId] [int] NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 10.06.2022 11:35:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [varchar](100) NULL,
	[UnitPrice] [money] NULL,
	[CategoryId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (N'4a540ccc-0806-4d7b-9da6-fae49f086918', N'Baza')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (N'5292468c-8fea-4230-a925-47cb36f740c5', N'Gardolap')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (N'53dd174b-69c0-4d69-93e5-4d6c2cc895ef', N'Oturma Odası')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (N'6b5fad3d-a4b0-4631-90bb-e22c9be06976', N'Pike')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (N'ce83d656-eb38-4dbd-8e95-b420ba102db6', N'Tost Makinesi')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (N'b85f0af5-6b08-469d-9947-84bd05b72696', N'Ütü')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (N'a4b2e420-d7e5-4c54-a711-16e7850b59b7', N'Yatak Odası')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (N'8a4ddff9-6acc-4e03-b63c-57cab2b94dda', N'Yemek Odası')
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([CustomerId], [CustomerNameSurname], [CustomerAdress], [CustomerMail], [CustomerPhone]) VALUES (3, N'İrem nur', N'İstanbul/Ümraniye', N'busra1@gmail.com', N'05557590938')
INSERT [dbo].[Customers] ([CustomerId], [CustomerNameSurname], [CustomerAdress], [CustomerMail], [CustomerPhone]) VALUES (4, N'Ali Şencan', N'Şişli', N'ali@gmail.com', N'02549894566')
INSERT [dbo].[Customers] ([CustomerId], [CustomerNameSurname], [CustomerAdress], [CustomerMail], [CustomerPhone]) VALUES (20, N'Arda', N'Beylikdüzü', N'ardakara@gmail.com', N'05491111111')
INSERT [dbo].[Customers] ([CustomerId], [CustomerNameSurname], [CustomerAdress], [CustomerMail], [CustomerPhone]) VALUES (21, N'Yeliz Öztürk', N'Bağcılar', N'y@hotmail.com', N'02121212121')
INSERT [dbo].[Customers] ([CustomerId], [CustomerNameSurname], [CustomerAdress], [CustomerMail], [CustomerPhone]) VALUES (22, N'Zeynep Kısa', N'Şirinevler', N'zeynep@hotmail.com', N'02464646464')
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
SET IDENTITY_INSERT [dbo].[Employees] ON 

INSERT [dbo].[Employees] ([employeeId], [nameSurname], [userName], [password]) VALUES (1, N'mehtap demir', N'm', N'm')
INSERT [dbo].[Employees] ([employeeId], [nameSurname], [userName], [password]) VALUES (2, N'Çetin Can', N'cetin011', N'123')
INSERT [dbo].[Employees] ([employeeId], [nameSurname], [userName], [password]) VALUES (3, N'ali', N'alican', N'ali123')
INSERT [dbo].[Employees] ([employeeId], [nameSurname], [userName], [password]) VALUES (6, N'Figen Saygılı', N'figen96', N'figfigfig')
SET IDENTITY_INSERT [dbo].[Employees] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([OrderId], [ProductID], [CustomerId], [OrderDate], [DeliveryDate], [Quantity], [TotalPrice], [DeliveryStatus], [employeeId]) VALUES (67, 33, 3, CAST(N'2022-05-15' AS Date), CAST(N'2022-12-12' AS Date), 1, 2.0000, N'Sipariş Hazırlanıyor', 1)
INSERT [dbo].[Orders] ([OrderId], [ProductID], [CustomerId], [OrderDate], [DeliveryDate], [Quantity], [TotalPrice], [DeliveryStatus], [employeeId]) VALUES (70, 44, 3, CAST(N'2022-05-15' AS Date), CAST(N'2022-11-11' AS Date), 1, 234.0000, N'Sipariş Hazırlanıyor', 1)
INSERT [dbo].[Orders] ([OrderId], [ProductID], [CustomerId], [OrderDate], [DeliveryDate], [Quantity], [TotalPrice], [DeliveryStatus], [employeeId]) VALUES (71, 45, 4, CAST(N'2022-05-15' AS Date), CAST(N'2022-11-11' AS Date), 2, 20546.0000, N'Sipariş Hazırlanıyor', 1)
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ProductId], [ProductName], [UnitPrice], [CategoryId]) VALUES (33, N'Başlıklı Baza', 2000.0000, N'4a540ccc-0806-4d7b-9da6-fae49f086918')
INSERT [dbo].[Products] ([ProductId], [ProductName], [UnitPrice], [CategoryId]) VALUES (42, N'2000watt Ütü', 2000.0000, N'5292468c-8fea-4230-a925-47cb36f740c5')
INSERT [dbo].[Products] ([ProductId], [ProductName], [UnitPrice], [CategoryId]) VALUES (44, N'Arzum Tost Makinesi', 1234.0000, N'ce83d656-eb38-4dbd-8e95-b420ba102db6')
INSERT [dbo].[Products] ([ProductId], [ProductName], [UnitPrice], [CategoryId]) VALUES (45, N'Asya Yatak Odası Takımı', 18.0000, N'a4b2e420-d7e5-4c54-a711-16e7850b59b7')
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [uq_Categories_Name]    Script Date: 10.06.2022 11:35:17 ******/
ALTER TABLE [dbo].[Categories] ADD  CONSTRAINT [uq_Categories_Name] UNIQUE NONCLUSTERED 
(
	[CategoryName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [uq_CustomersMail]    Script Date: 10.06.2022 11:35:17 ******/
ALTER TABLE [dbo].[Customers] ADD  CONSTRAINT [uq_CustomersMail] UNIQUE NONCLUSTERED 
(
	[CustomerMail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [uq_CustomersPhone]    Script Date: 10.06.2022 11:35:17 ******/
ALTER TABLE [dbo].[Customers] ADD  CONSTRAINT [uq_CustomersPhone] UNIQUE NONCLUSTERED 
(
	[CustomerPhone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [uq_EmployeesUserName]    Script Date: 10.06.2022 11:35:17 ******/
ALTER TABLE [dbo].[Employees] ADD  CONSTRAINT [uq_EmployeesUserName] UNIQUE NONCLUSTERED 
(
	[userName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Categories] ADD  CONSTRAINT [DF_Categories_CategoryId]  DEFAULT (newid()) FOR [CategoryId]
GO
ALTER TABLE [dbo].[Orders] ADD  CONSTRAINT [DF_Orders_OrderDate]  DEFAULT (getdate()) FOR [OrderDate]
GO
ALTER TABLE [dbo].[Orders] ADD  CONSTRAINT [DF_Orders_DeliveryDate]  DEFAULT ('11.11.1999') FOR [DeliveryDate]
GO
ALTER TABLE [dbo].[Orders] ADD  CONSTRAINT [DF_Orders_DeliveryStatus]  DEFAULT ('Sipariş Hazırlanıyor') FOR [DeliveryStatus]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Customers1] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([CustomerId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Customers1]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Employees] FOREIGN KEY([employeeId])
REFERENCES [dbo].[Employees] ([employeeId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Employees]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Products]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([CategoryId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [CK_Orders_Quantity] CHECK  (([Quantity]<=(2) AND [Quantity]>=(0)))
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [CK_Orders_Quantity]
GO
/****** Object:  StoredProcedure [dbo].[AddCategory]    Script Date: 10.06.2022 11:35:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AddCategory]
@CategoryName varchar(100)
as begin
insert into [dbo].[Categories](CategoryName) values (@CategoryName)
end
GO
/****** Object:  StoredProcedure [dbo].[AddCustomer]    Script Date: 10.06.2022 11:35:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AddCustomer]
@NameSurname varchar(100),
@adress varchar(100),
@mail varchar(100),
@phone varchar(100)
as begin 
insert into [dbo].[Customers](CustomerNameSurname, CustomerAdress, CustomerMail, CustomerPhone) 
values (@NameSurname, @adress, @mail, @phone)
end
GO
/****** Object:  StoredProcedure [dbo].[AddEmployee]    Script Date: 10.06.2022 11:35:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AddEmployee]
@nameSurname varchar(100),
@userName varchar(50),
@password varchar(50)
as begin 
insert into [dbo].[Employees] (nameSurname,userName, password) values (@nameSurname, @userName, @password)
end
GO
/****** Object:  StoredProcedure [dbo].[AddOrder]    Script Date: 10.06.2022 11:35:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AddOrder]
@ProductId int,
@CustomerId int,
@DeliveryDate date,
@Quantity int, 
@TotalPrice money,
@DeliveryStatus varchar(50),
@employeeId int
as begin
insert into [dbo].[Orders](ProductID, CustomerId, DeliveryDate, Quantity, TotalPrice, DeliveryStatus, employeeId) 
values(@ProductId, @CustomerId, @DeliveryDate, @Quantity, @TotalPrice, @DeliveryStatus, @employeeId)
end
GO
/****** Object:  StoredProcedure [dbo].[AddProduct]    Script Date: 10.06.2022 11:35:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AddProduct]
@productName varchar(100),
@unitPrice money,
@catId varchar(36)
as begin 
insert into [dbo].[Products] (ProductName, UnitPrice, CategoryId) values (@productName, @unitPrice, @catId)
end
GO
/****** Object:  StoredProcedure [dbo].[CategoryList]    Script Date: 10.06.2022 11:35:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[CategoryList]
as begin
Select * from [dbo].[Categories]
end
GO
/****** Object:  StoredProcedure [dbo].[CustomerList]    Script Date: 10.06.2022 11:35:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[CustomerList]
as begin 
Select * from Customers
end
GO
/****** Object:  StoredProcedure [dbo].[DelCustomer]    Script Date: 10.06.2022 11:35:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DelCustomer]
@custId int
as begin
delete from [dbo].[Customers] where CustomerId=@custId
end
GO
/****** Object:  StoredProcedure [dbo].[DeleteCategory]    Script Date: 10.06.2022 11:35:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteCategory]
@CategoryId varchar(36)
as begin 
Delete from [dbo].[Categories] where CategoryId=@CategoryId
end
GO
/****** Object:  StoredProcedure [dbo].[DeleteOrder]    Script Date: 10.06.2022 11:35:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[DeleteOrder]
@OrderId int
as begin
Delete from [dbo].[Orders] where OrderId=@OrderId
end
GO
/****** Object:  StoredProcedure [dbo].[DelProduct]    Script Date: 10.06.2022 11:35:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DelProduct]
@productId int
as begin 
Delete from [dbo].[Products] where ProductId=@productId
end
GO
/****** Object:  StoredProcedure [dbo].[EmployeeList]    Script Date: 10.06.2022 11:35:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[EmployeeList]
as begin
Select * from Employees
end
GO
/****** Object:  StoredProcedure [dbo].[LoginEmployee]    Script Date: 10.06.2022 11:35:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LoginEmployee]
@userName varchar(50),
@password varchar(50)
as begin
Select * from [dbo].[Employees] where userName=@userName and password=@password
end
GO
/****** Object:  StoredProcedure [dbo].[OrderList]    Script Date: 10.06.2022 11:35:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[OrderList]
as begin
Select * from [dbo].[Orders]
end
GO
/****** Object:  StoredProcedure [dbo].[ProductList]    Script Date: 10.06.2022 11:35:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ProductList]
as begin 
Select * from Products
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateCategory]    Script Date: 10.06.2022 11:35:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdateCategory]
@CategoryId varchar(36),
@CategoryName varchar(100)
as begin
Update [dbo].[Categories] set CategoryName=@CategoryName where CategoryId=@CategoryId
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateCustomer]    Script Date: 10.06.2022 11:35:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[UpdateCustomer]
@custId int,
@NameSurname varchar(100),
@adress varchar(100),
@mail varchar(100),
@phone varchar(100)
as begin
Update [dbo].[Customers] set CustomerNameSurname=@NameSurname, CustomerAdress=@adress, CustomerMail=@mail, CustomerPhone=@phone where CustomerId= @custId
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateOrder]    Script Date: 10.06.2022 11:35:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[UpdateOrder]
@OrderId int,
@ProductId int,
@CustomerId int,
@DeliveryDate date,
@Quantity int, 
@TotalPrice money,
@DeliveryStatus varchar(50),
@employeeId int
as begin
update [dbo].[Orders] set ProductID=@ProductId, CustomerId=@CustomerId, DeliveryDate=@DeliveryDate, Quantity=@Quantity, TotalPrice=@TotalPrice,
DeliveryStatus=@DeliveryStatus, employeeId=@employeeId where OrderId= @OrderId
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateProduct]    Script Date: 10.06.2022 11:35:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[UpdateProduct]
@productId int,
@productName varchar(100),
@unitPrice money,
@catId varchar(36)
as begin 
Update [dbo].[Products] set ProductName=@productName, UnitPrice=@unitPrice, CategoryId=@catId where ProductId=@productId
end
GO
USE [master]
GO
ALTER DATABASE [FurnitureDB] SET  READ_WRITE 
GO
