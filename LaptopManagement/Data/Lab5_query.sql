CREATE USER [BLuBin\builu] FOR LOGIN [BLuBin\builu];

USE master;
GO
ALTER DATABASE LaptopDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
GO
DROP DATABASE LaptopDB;

DROP TABLE Laptop;

CREATE DATABASE LaptopDB;

CREATE TABLE Laptop (
    LaptopID nchar(20) PRIMARY KEY,
    LaptopName nvarchar(50),
    LaptopType nvarchar(50),
    ProductDate datetime,
    Processor nvarchar(50),
    HDD nvarchar(50),
    RAM nvarchar(50),
    Price int,
    ImageName nvarchar(50)
);

INSERT INTO laptop (LaptopID, LaptopName, LaptopType, ProductDate, Processor, HDD, RAM, Price, ImageName)
VALUES 
('LT001', 'Dell XPS 13', 'Dell', '2022-10-01', 'Intel Core i7-1165G7', '512GB SSD', '16GB RAM', 1200, 'dell-xps-13.jpg'),
('LT002', 'HP Spectre x360', 'HP', '2022-05-01', 'Intel Core i5-1135G7', '256GB SSD', '8GB RAM', 1000, 'hp-spectre-x360.jpg'),
('LT003', 'Lenovo ThinkPad X1 Carbon', 'Lenovo', '2022-09-01', 'Intel Core i7-11610U', '1TB SSD', '16GB RAM', 1300, 'lenovo-thinkpad-x1-carbon.jpg'),
('LT004', 'Asus ROG Zephyrus G14', 'Asus', '2022-07-01', 'AMD Ryzen 9 5900HS', '1TB SSD', '32GB RAM', 1500, 'asus-rog-zephyrus-g14.jpg'),
('LT005', 'MacBook Air M2', 'Apple', '2022-11-01', 'Apple M2', '512GB SSD', '16GB RAM', 1700, 'macbook-air-m2.jpg'),
('LT006', 'Acer Predator Helios 300', 'Acer', '2022-06-01', 'Intel Core i7-11800H', '1TB HDD', '16GB RAM', 1100, 'acer-predator-helios-300.jpg'),
('LT007', 'Microsoft Surface Laptop 4', 'Microsoft', '2022-08-01', 'Intel Core i5-1135G7', '256GB SSD', '8GB RAM', 1200, 'microsoft-surface-laptop-4.jpg');

CREATE TABLE Customer (
    CustomerID NVARCHAR(50) PRIMARY KEY,
    CustomerName NVARCHAR(100),
    Birthday DATETIME,
    Sex NVARCHAR(10),
);

CREATE TABLE Roles (
    RoleID INT PRIMARY KEY,
    RoleName NVARCHAR(50) NOT NULL
);

CREATE TABLE [User](
    UserName NVARCHAR(50) PRIMARY KEY,
    Password NVARCHAR(50),
    CustomerID NVARCHAR(50) FOREIGN KEY REFERENCES Customer(CustomerID),
	RoleID INT FOREIGN KEY REFERENCES Roles(RoleID)
);

CREATE TABLE Cart (
    CartID INT PRIMARY KEY IDENTITY,
    UserName NVARCHAR(50) FOREIGN KEY REFERENCES [User](UserName),
    LaptopID NCHAR(20) FOREIGN KEY REFERENCES Laptop(LaptopID),
    CONSTRAINT FK_Cart_User FOREIGN KEY (UserName) REFERENCES [User](UserName),
    CONSTRAINT FK_Cart_Laptop FOREIGN KEY (LaptopID) REFERENCES Laptop(LaptopID)
);

INSERT INTO Roles (RoleID, RoleName) VALUES ('1','ADMIN')
INSERT INTO Roles (RoleID, RoleName) VALUES ('2','USER')



