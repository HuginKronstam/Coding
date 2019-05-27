USE MASTER
IF NOT EXISTS(
	SELECT name
	from sys.databases
	where name = 'Dummy')
CREATE DATABASE Dummy
go

USE Dummy
GO

IF OBJECT_ID( 'dbo.Students', 'U') IS NOT NULL
DROP TABLE dbo.Students
GO

CREATE TABLE Students(
	StudentID INT NOT NULL IDENTITY PRIMARY KEY,
	Name VARCHAR(50),
	Class VARCHAR(50),
	Color VARCHAR(50)
	)
GO

INSERT INTO Students (Name, Class, Color)
VALUES
	('Kim', '4th grade', 'Blue'),
	('Laura', '4th grade','Yellow'),
	('Keith','4th grade','Purple'),
	('Agetha', '5th grade', 'green'),
	('Steve', '5th grade', 'Black')

GO