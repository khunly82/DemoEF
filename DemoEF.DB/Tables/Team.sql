﻿CREATE TABLE [dbo].[Team]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(50) NOT NULL UNIQUE,
	[Logo] VARBINARY(MAX) NULL,
	[MimeType] VARCHAR(100) NULL
)