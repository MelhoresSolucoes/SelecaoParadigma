CREATE TABLE [dbo].[Colaboradores]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nome] NVARCHAR(50) NOT NULL, 
    [Salario] DECIMAL(6) NOT NULL, 
    [DeptId] INT NOT NULL
)

GO
