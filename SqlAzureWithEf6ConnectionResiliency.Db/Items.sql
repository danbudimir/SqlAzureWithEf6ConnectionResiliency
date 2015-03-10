CREATE TABLE [dbo].[Items]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Field1] VARCHAR(50) NULL, 
    [Field2] INT NULL DEFAULT 0, 
    [Field3] DATE NULL DEFAULT getdate()
)
