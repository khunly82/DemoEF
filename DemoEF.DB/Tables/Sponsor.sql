﻿CREATE TABLE [dbo].[Sponsor]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Name] VARCHAR(50) NOT NULL,
	[Logo] VARBINARY(MAX) NOT NULL,
	[MimeType] VARCHAR(50) NOT NULL
)