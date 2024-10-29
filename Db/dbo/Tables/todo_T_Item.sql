CREATE TABLE [dbo].[todo_T_Item]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Title] NVARCHAR(50) NOT NULL, 
    [Description] NVARCHAR(50) NULL, 
    [Status] BIT NULL
)
