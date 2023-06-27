/*
Post-Deployment Script Template
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.
 Use SQLCMD syntax to include a file in the post-deployment script.
 Example:      :r .\myfile.sql
 Use SQLCMD syntax to reference a variable in the post-deployment script.
 Example:      :setvar TableName MyTable
               SELECT * FROM [$(TableName)]
--------------------------------------------------------------------------------------
*/

IF EXISTS (SELECT 1 FROM sys.server_principals WHERE name = 'TestUser')
BEGIN
    DROP LOGIN TestUser;
END

USE [btm_angular];

CREATE LOGIN TestUser WITH PASSWORD = 'ThisU$erAccountShouldNotBe4vailableInProduction';
GRANT SELECT ON [dbo].[btm_angular] TO TestUser;
--GRANT SELECT, INSERT, UPDATE, DELETE ON [dbo].[YourTable] TO TestUser;


--USE [btm_angular];
CREATE USER TestUser FOR LOGIN TestUser;