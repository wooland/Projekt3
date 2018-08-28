USE MASTER
GO

DROP DATABASE [BAT]
GO

CREATE DATABASE [BAT]
GO

USE [BAT]
GO

--DROP TABLE [UserInChat]
--GO

--DROP TABLE [BatMessage]
--GO

--DROP TABLE [BatUsers]
--GO

--DROP TABLE [BatChat]
--GO

CREATE TABLE [BatUsers] (
[UID] int identity PRIMARY KEY,
[Name] varchar (max),
[Password] varchar (max))

CREATE TABLE [BatChat] (
[CID] int identity PRIMARY KEY,
[Header] varchar(max))

CREATE TABLE [BatMessage] (
[MID] int identity PRIMARY KEY,
UserID int FOREIGN KEY REFERENCES [BatUsers]([UID]),
ChatID int FOREIGN KEY REFERENCES [BatChat]([CID]),
[MessageText]varchar(max),
[Entered] DATETIME)

CREATE TABLE [UserInChat] (
[UICID] int identity PRIMARY KEY,
UserID int FOREIGN KEY REFERENCES [BatUsers]([UID]),
ChatID int FOREIGN KEY REFERENCES [BatChat]([CID]))

INSERT INTO [BatUsers] ([Name], [Password])
VALUES ('BatMan','BBBB'), 
('Robin', 'RRRR')	

INSERT INTO [BatChat] ([Header])
VALUES ('Test Chat')

INSERT INTO [UserInChat] (UserID, ChatID)
VALUES (1, 1), (2, 1)

INSERT INTO [BatMessage] (UserID, ChatID, [MessageText])
VALUES (1, 1, 'BatMan Test'),(2, 1, 'Robin Test')