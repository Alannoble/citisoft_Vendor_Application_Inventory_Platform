CREATE TABLE [dbo].[product]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [softwareName] NVARCHAR(50) NOT NULL, 
    [typeOfSoftware] NVARCHAR(50) NOT NULL, 
    [description] NVARCHAR(50) NOT NULL
)
