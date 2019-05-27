USE MASTER
IF NOT EXISTS(
	SELECT name
	from sys.databases
	where name = 'EDMExercise')
CREATE DATABASE EDMExercise
go

USE EDMExercise
GO

IF OBJECT_ID( 'dbo.StudentClass', 'U') IS NOT NULL
DROP TABLE dbo.StudentClass
GO

CREATE TABLE StudentClass
(
	ClassId int NOT NULL PRIMARY KEY,
	ClassValue VARCHAR(50),
	Teacher VARCHAR(50)
	)
GO

INSERT INTO StudentClass (ClassId, ClassValue)
VALUES
	(4, '4th grade'),
	(5, '5th grade')

IF OBJECT_ID( 'dbo.Students', 'U') IS NOT NULL
DROP TABLE dbo.Students
GO

CREATE TABLE Students(
	StudentID INT NOT NULL IDENTITY PRIMARY KEY,
	Name VARCHAR(50),
	Class INT FOREIGN KEY REFERENCES StudentClass,
	HobbyID INT FOREIGN KEY REFERENCES Hobbies
	)
GO

CREATE TABLE Hobbies(
	HobbyID INT NOT NULL IDENTITY PRIMARY KEY,
	HobbyName VARCHAR(50),
	HobbyPrice float,
	)
GO

INSERT INTO Hobbies (HobbyName, HobbyPrice)
VALUES
	('Badminton', 202.7),
	('Roning', 500.2)
GO

INSERT INTO Students (Name, Class, HobbyID)
VALUES
	('Kim', 4, 1),
	('Laura', 4, 1),
	('Keith',4, 2),
	('Agetha', 5, 2),
	('Steve', 5, 2)
GO