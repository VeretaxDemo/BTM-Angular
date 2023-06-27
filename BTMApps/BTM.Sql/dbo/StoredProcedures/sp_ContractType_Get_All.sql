CREATE PROCEDURE [dbo].[sp_ContractType_Get_All]
AS
BEGIN
    SET NOCOUNT ON;
	SELECT [Id]
      ,[ContractCategoryId]
      ,[Title]
      ,[Description]
  FROM [dbo].[ContractTypes]
END
RETURN 0
