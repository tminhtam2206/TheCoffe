CREATE DATABASE DB_TheCoffeHouse
GO

USE DB_TheCoffeHouse
GO

CREATE TABLE Account
(
	Username CHAR(20) PRIMARY KEY,
	Pass CHAR(300) NOT NULL,
	DisplayName NVARCHAR(15) NOT NULL,
	TypeAccount int NOT NULL,
	Avatar IMAGE NULL
)
GO

CREATE TABLE Actions
(
	IdAction INT IDENTITY(1,1) PRIMARY KEY,
	Username CHAR(20) NOT NULL,
	Action NVARCHAR(50) NOT NULL,
	CurrTime CHAR(19) NOT NULL

	FOREIGN KEY(Username) REFERENCES dbo.Account(Username)
)
GO

CREATE TABLE TableFood
(
	IdTable INT IDENTITY(1,1) PRIMARY KEY,
	NameTable NVARCHAR(8) NOT NULL,
	Status NVARCHAR(9) NOT NULL
)
GO



CREATE PROC USP_Login
@userName CHAR(100), @passWord CHAR(1000)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE Username = @userName AND Pass = @passWord AND TypeAccount != 2
END
GO

INSERT INTO dbo.Account VALUES  ('admin', '1962026656160185351301320480154111117132155', N'Admin Đại Đế', 0, NULL);
INSERT INTO dbo.Account VALUES  ('tuan', '1962026656160185351301320480154111117132155', N'Admin Đại Đế', 1, NULL);
GO

