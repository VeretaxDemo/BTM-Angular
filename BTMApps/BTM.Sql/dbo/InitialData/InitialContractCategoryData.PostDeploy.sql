/*
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be executed before the build script.
 Use SQLCMD syntax to include a file in the pre-deployment script.
 Example:      :r .\myfile.sql
 Use SQLCMD syntax to reference a variable in the pre-deployment script.
 Example:      :setvar TableName MyTable
               SELECT * FROM [$(TableName)]
--------------------------------------------------------------------------------------
*/
-- Insert Contract Categories
INSERT INTO [dbo].[ContractCategory] ([Id], [Title], [Description], [SpecialConsiderations])
VALUES ('8e3fbe07-4c84-4ec0-b7d7-f70bcf5a7fdf', 'Static Defense', 'This category includes Garrison, Cadre and Security Duty, all fairly low risk. low pay, long service operations that are dull and inglorious.', '');

INSERT INTO [dbo].[ContractCategory] ([Id], [Title], [Description], [SpecialConsiderations])
VALUES ('4090af08-d2e1-484a-a983-bee4133d5374', 'Territorial Campaign', 'Missions in this class are more concerned with the need to protect or seize territorial objectives than they are with battle. Specifically this category includes Riot Duty and Siege Campaigns. Though dangerous, these operations do not provide a great deal of pay. Service length is average .', '');

INSERT INTO [dbo].[ContractCategory] ([Id], [Title], [Description], [SpecialConsiderations])
VALUES ('5ed826d5-d496-4a73-a889-58d98dfc935e', 'Combat Campaign', 'Units given this class of mission will undertake either Offensive or Defensive Campaigns. These are considered a standard type of mission, with moderate length, hazard and numeration.', '');

INSERT INTO [dbo].[ContractCategory] ([Id], [Title], [Description], [SpecialConsiderations])
VALUES ('d94c4ae8-a28f-4e2d-b0c6-e077b11c0d41', 'Minor Raid', 'This category includes both Recon and Objective Raids, which tend to be short and dangerous (though not as much as a Major Raid). They offer higher rates of pay than less strenuous duties.', '');

INSERT INTO [dbo].[ContractCategory] ([Id], [Title], [Description], [SpecialConsiderations])
VALUES ('457c7f74-cd54-4292-9d5c-0073776b1100', 'Territorial Campaign', 'Missions in this class are more concerned with the need to protect or seize territorial objectives than they are with battle. Specifically this category includes Riot Duty and Siege Campaigns. Though dangerous, these operations do not provide a great deal of pay. Service length is average .', '');

INSERT INTO [dbo].[ContractCategory] ([Id], [Title], [Description], [SpecialConsiderations])
VALUES ('da81f582-e795-485f-a692-902716162c81', 'Invasion', 'This category denotes operations that require units to move against a world where enemy forces are in control of the approaches and some or all of the surface. It specifically includes Planetary Assaults and Relief Duty. Duty is short but hazardous and well-paying.', '');

INSERT INTO [dbo].[ContractCategory] ([Id], [Title], [Description], [SpecialConsiderations])
VALUES ('e95cef9c-f11e-4e25-a7c1-56d950472c98', 'Major Raid', 'Major Raids are Diversionary and Guerrilla Warfare assignments. They tend to take longer than ordinary raids and are high-paying missions (because they are so dangerous).', '');

INSERT INTO [dbo].[ContractCategory] ([Id], [Title], [Description], [SpecialConsiderations])
VALUES ('fd5e18e3-27dd-425a-bd43-1782257880bc', 'Black Market Minor', 'This is not an official category and the MRBC does allow listings of these types of contracts but they sometimes they are under the guise of another contract type and the deals are done behind closed doors between the employer and mercenary unit.', '');

INSERT INTO [dbo].[ContractCategory] ([Id], [Title], [Description], [SpecialConsiderations])
VALUES ('bd2af4b5-7b54-4b3f-a39b-04e46fce1028', 'Black Market Major', 'This is not an official category and the MRBC does allow listings of these types of contracts but they sometimes they are under the guise of another contract type and the deals are done behind closed doors between the employer and mercenary unit.', '');
