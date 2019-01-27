-- This project uses the following licenses:
-- MIT License
-- Copyright (c) 2018 Ricardo Mendoza 
-- Montréal Québec Canada

-- Repository : MVC_winapp_NationalBank_SqlServer > https://github.com/RicardoAMendoza/MVC_winapp_NationalBank_SqlServer.git
-- Project : prjWin_MVC_NationalBank_SqlServer_Rm
-- Instruction :
-- Copy and paste on SqlServer script and run it. That will create de data base

-- =============================================
-- Author:		Ricardo Mendoza
-- Create date: 3-12-2018
-- Name : qClients
-- Description:	View clients et agencies from bd_NationalBank
-- 1.- selectClients
-- =============================================
USE bd_NationalBank
GO

CREATE VIEW qClients
AS 
SELECT 
b.idclient AS idclient,
b.clientNumber AS 'Number',
case
WHEN b.sexe = 'M' THEN 'Sir'
WHEN b.sexe ='F' THEN 'Mrs'
END
AS 'Gender',
concat(b.name,' ', b.lastName) as 'Client',
b.address as 'Address',
b.email as 'E-mail',
b.img as img,
b.cardNumber as cardNumber,
b.nip as nip,
b.active as active,
b.idagencies as 'idagencies',
b.idemployee as idemployee,
a.name as 'Agency'
FROM tclient b INNER JOIN tagencies a on (b.idagencies=a.idagencies) 

-- =============================================
-- Author:		Ricardo Mendoza
-- Create date: 26-01-2018
-- Name : qClientAccounts
-- Description:	View clients ACCOUNTS from bd_NationalBank
-- 2.- selectClients
-- =============================================
USE bd_NationalBank
GO

CREATE VIEW qClientAccounts
AS 
SELECT
a.clientNumber as 'ID Client',
concat (a.name,' ', a.lastName) as Client,
h.employeeNumber as 'ID Employee',
concat(h.name,' ', h.lastName) as Employee,
h.hiringDate as [Hiring Date],
h.img as 'Photo',
-- ----------------------------------------
d.accountType as 'Type account',
c.number as 'Number',
-- taccounttype  --------------------------
d.interestRate as 'Interest', -- PaidAccount
d.comission as 'Comission',   -- UnPaidAccount
d.overdraft as 'Overdraft',   -- UnPaidAccount
-- taccount  ------------------------------
c.balance as 'Balance',
c.openDate as 'Open Date'
-- ----------------------------------------
FROM tclient a LEFT JOIN tclient_account b ON a.idclient=b.idclient 
LEFT JOIN taccounttype d ON b.idaccounttype = d.idaccounttype 
LEFT JOIN taccount c ON b.idaccount=c.idaccount
LEFT JOIN temployee h ON a.idemployee = h.idemployee

-- =============================================
-- Author:		Ricardo Mendoza
-- Create date: 26-01-2018
-- Name : qAgencies
-- Description:	View clients ACCOUNTS from bd_NationalBank
-- 3.- selectClients
-- =============================================
USE bd_NationalBank
GO

CREATE VIEW qAgencies
AS 
SELECT 
g.agencyNumber AS 'ID Agency',
g.name AS 'Agency',
g.address AS 'Address',
CASE
	WHEN h.sexe ='M' THEN 'Mr'
	WHEN h.sexe ='F' THEN 'Mrs'
END
AS Gender,
CONCAT(h.name, ' ', h.lastName) AS Employee,
h.img as 'Photo',
j.codearea AS 'ID Area',
j.description AS Area,
a.clientNumber as 'ID Client',
concat (a.name,' ', a.lastName) as Client,
-- ----------------------------------------
d.accountType as 'Type account',
c.number as 'Number',
-- taccounttype  --------------------------
d.interestRate as 'Interest', -- PaidAccount
d.comission as 'Comission',   -- UnPaidAccount
d.overdraft as 'Overdraft',   -- UnPaidAccount
-- taccount  ------------------------------
c.balance as 'Balance',
c.openDate as 'Open Date'
FROM tagencies g LEFT JOIN temployee h ON g.idagencies=h.idagencies
LEFT JOIN temploy_area i ON h.idemployee=i.idemployee
LEFT JOIN tarea j ON i.codearea=j.codearea
LEFT JOIN tclient a ON a.idagencies = g.idagencies
LEFT JOIN tclient_account b ON a.idclient=b.idclient 
LEFT JOIN taccounttype d ON b.idaccounttype = d.idaccounttype 
LEFT JOIN taccount c ON b.idaccount=c.idaccount