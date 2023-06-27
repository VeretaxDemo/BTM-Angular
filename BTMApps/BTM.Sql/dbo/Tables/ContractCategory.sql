CREATE TABLE [dbo].[ContractCategory]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
    [Title] NVARCHAR(50) NULL,
    [Description] NVARCHAR(MAX) NULL,
    [SpecialConsiderations] NVARCHAR(255) NULL
)
