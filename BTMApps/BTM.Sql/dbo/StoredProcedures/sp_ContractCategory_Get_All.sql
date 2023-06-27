CREATE PROCEDURE [dbo].[sp_ContractCategory_Get_All]
AS
BEGIN
    SET NOCOUNT ON;
	SELECT [Id]
      ,[Title]
      ,[Description]
      ,[SpecialConsiderations]
  FROM [dbo].[ContractCategory]
END
RETURN 0
