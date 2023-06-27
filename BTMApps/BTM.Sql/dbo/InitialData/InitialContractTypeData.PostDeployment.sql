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
-- Insert Contract Types

/* Static Defense */
INSERT INTO [dbo].[ContractTypes] ([Id], [ContractCategoryId], [Title], [Description])
     VALUES
           ('e7095bfb-dbc8-430d-a750-3f488a9ef188', '8e3fbe07-4c84-4ec0-b7d7-f70bcf5a7fdf', 'Garrison Duty', 'Strictly speaking garrisons are found on uncontested worlds with enough strategic significance and potential for trouble to warrant the presence of combat troops. In theory such worlds are low risk stations where combat or civil disorder are not expected. Because of this, a unit hired for garrison duty is not likely to see action, and probably will not receive good pay or other benefits. Because House units are more loyal, less cautious, and certainly less expensive to maintain in the field that are mercenaries, House leaders often employ mercenaries for garrison duty to free up House troops for front line duty.');

INSERT INTO [dbo].[ContractTypes] ([Id], [ContractCategoryId], [Title], [Description])
     VALUES
           ('79cc7ca9-7425-426f-8a44-d18dc6685476', '8e3fbe07-4c84-4ec0-b7d7-f70bcf5a7fdf', 'Security Duty', 'One step removed from garrison duty is security duty, in which the unit is hired to provide security for some target believed threatened by hostile forces. Where garrisons usually watch over a whole planet, a security mission might revolve around the protection of a single installation, supply convoy, or other limited target. Non BattleMech mercenaries (infantry for example) are sometimes hired to serve as marines on exposed JumpShips or commercial transports, or to act as bodyguards for dignitaries and the like.');

INSERT INTO [dbo].[ContractTypes] ([Id], [ContractCategoryId], [Title], [Description])
     VALUES
           ('a94eea05-e266-4d54-b2c9-d6af03d803aa', '8e3fbe07-4c84-4ec0-b7d7-f70bcf5a7fdf', 'Cadre Duty', 'As a cadre force, the mercenaries must organize and train new recruits or militia forces. It is often easy duty, in which even low ranking mercenaries have temporary authority while training the recruits. Though usually a low-risk assignment and never paying particularly well, cadre duty becomes dangerous if recruit forces are suddenly thrust into combat before their training is complete.');

/* Static Defense */
INSERT INTO [dbo].[ContractTypes] ([Id], [ContractCategoryId], [Title], [Description])
     VALUES
           ('7c2fca17-7f54-4d5c-b24b-d1d349e47f17', '4090af08-d2e1-484a-a983-bee4133d5374', 'Riot Duty', 'Mercenaries are frequently hired for riot duty, the suppression of a smoldering or active rebellion on a world under the employer''s control. The duty is unglamorous, very difficult and dangerous, but, like garrison and security duty, it does not pay well. Although few rebels can stand up to high-tech mercenaries in battle, the threat of terrorism and general insurgency fills a merc''s every hour with danger. Employers usually stipulate that mercs are to do the least possible damage to targets of strategic or economic value, complicating the mercenaries position. In addition, an employer might unleash mercenaries on a rebellious planet while keeping House units clear not only of violence, but of all involvement. After the mercenaries quell the riot, the employer steps in, blames the mercenaries for exceeding their authority, and so becomes a savior rather than an oppressor. Meanwhile the mercenaries are sent packing in disgrace.');

INSERT INTO [dbo].[ContractTypes] ([Id], [ContractCategoryId], [Title], [Description])
     VALUES
           ('337563ef-fa5b-4508-8a3f-189b48c2dbfe', '4090af08-d2e1-484a-a983-bee4133d5374', 'Seige Campaign', 'In many instances an aggressor will implement a policy of siege warfare rather than a true offensive. Sieges are conducted on a planet-wide scale to reduce enemy forces on the planet without the need for pitched battles. In a siege campaign, troops wage a war of maneuver in which most battles are minor skirmishes rather than major clashes. Aerospace superiority is exerted to deny off-planet supplies and reinforcements.\n
            Most mercenaries favor siege campaigns. There is little danger of taking heavy casualties and the campaign is long enough to guarantee steady employment. Like most operations undertaken in the face of an enemy, pay tends to be good and there are plenty of opportunities for independent operations without excessive employer involvement. Periodically, such campaigns go awry and lead to major battles, but on the whole, a siege campaign is the mercenary''s idea of a perfect ticket.');

/* Combat Campaign */
INSERT INTO [dbo].[ContractTypes] ([Id], [ContractCategoryId], [Title], [Description])
     VALUES
           ('8c4114b1-ce0a-40ef-ba1a-7584a9a86d8c', '5ed826d5-d496-4a73-a889-58d98dfc935e', 'Offensive Campaign', 'Taking up where a planetary assault leaves off, an offensive campaign is an attack against hostile forces on a contested planet. Sometimes this sort of attack develops directly from a planetary assault, but it usually involves additional troops reinforcing or replacing those in the first landings. In some cases, a planet''s defenders declare an offensive campaign against enemies who occupy a portion of the planet. Not quite as lucrative (or risky) as a planetary assault, this kind of campaign still pays well. As with it''s defensive counterpart, it is sometimes marred by the excessive dependence of mercenary elements on outsiders who can let them down.');

INSERT INTO [dbo].[ContractTypes] ([Id], [ContractCategoryId], [Title], [Description])
     VALUES
           ('ec25d77b-8964-4b91-ae96-9adb4aea5fe0', '5ed826d5-d496-4a73-a889-58d98dfc935e', 'Defensive Campaign', 'An employer begins a defensive campaign when he discovers enemy intentions to invade or escalate hostilities on a world. Mercenaries and household troops are deployed to stiffen resistance against the assault. As active fighting is likely, pay is fairly good, but mercenaries often find themselves faced with too much employer interference in their operations. The unit runs the risk of being cut off or overrun if the attacker proves successful and the mercenaries must rely heavily on people they do not know and cannot control.');

GO


