-- This project uses the following licenses:
-- MIT License
-- Copyright (c) 2018 Ricardo Mendoza 
-- Montréal Québec Canada

-- Repository : MVC_winapp_NationalBank_SqlServer > https://github.com/RicardoAMendoza/MVC_winapp_NationalBank_SqlServer.git
-- Project : prjWin_MVC_NationalBank_SqlServer_Rm
-- Instruction :
-- Copy and paste on SqlServer script and run it. That will create de data base

-- -----------------------------------------------------
-- 1.- Procedure sp_save_bank
-- -----------------------------------------------------
USE bd_NationalBank
GO

Create PROC [dbo].[sp_save_bank]

 @aidbank int = NULL,
 @aname varchar(45)= NULL,
 @acapital DECIMAL(22,6)= NULL,
 @aaddress varchar(45)= NULL
 
AS
BEGIN

IF @aidbank = 0 
INSERT INTO tbank(name,capital,address)
VALUES (@aname,@acapital,@aaddress);
ELSE
UPDATE tbank 
SET name=@aname,capital=@acapital,address=@aaddress
WHERE idbank=@aidbank

END
GO

-- -----------------------------------------------------
-- 2.- sp_save_directorgeneral
-- -----------------------------------------------------
USE bd_NationalBank
GO

CREATE PROC sp_save_directorgeneral

 @aiddirector INT = NULL,
 @aidbank INT = NULL,
 @adirectorNumber varchar(45)= NULL,
 @aname varchar(45)= NULL,
 @alastName varchar(45)= NULL,
 @aemail varchar(45)= NULL,
 @aimg varchar(45)= NULL,
 @asalary DECIMAL(22,6)= NULL,
 @asexe varchar (1) = null,
 @aactive VARCHAR (1) = NULL

AS
BEGIN

IF @aiddirector = 0 
INSERT INTO tdirectorgeneral(idbank,directorNumber,name,lastName,email,img,salary,sexe,active)
VALUES (@aidbank,@adirectorNumber,@aname,@alastName,@aemail,@aimg,@asalary,@asexe,@aactive);
ELSE
UPDATE tdirectorgeneral 
SET idbank=@aidbank,directorNumber=@adirectorNumber,name=@aname,lastName=@alastName,email=@aemail,img=@aimg, salary=@asalary,sexe=@asexe,active=@aactive
WHERE iddirector=@aiddirector

END
GO

-- -----------------------------------------------------
-- 3.- sp_save_directoragencie
-- -----------------------------------------------------
USE bd_NationalBank
GO

Create PROC sp_save_directoragencie

 @aiddirectorAgency int = NULL,
 @adirectorNumber varchar(45)= NULL,
 @aname varchar(45)= NULL,
 @alastName varchar(45)= NULL,
 @aemail varchar(45)= NULL,
 @aimg varchar(45)= NULL,
 @asalary DECIMAL(22,6)= NULL,
 @asexe varchar (1) = null,
 @aactive varchar(1)= NULL

AS
BEGIN

IF @aiddirectorAgency = 0 
INSERT INTO tdirectoragency(directorNumber,name,lastName,email,img,salary,sexe,active)
VALUES (@adirectorNumber,@aname,@alastName,@aemail,@aimg,@asalary,@asexe,@aactive);
ELSE
UPDATE tdirectoragency 
SET directorNumber=@adirectorNumber,name=@aname,lastName=@alastName,email=@aemail,img=@aimg, salary=@asalary,sexe=@asexe,active=@aactive
WHERE iddirectorAgency=@aiddirectorAgency

END
GO

-- -----------------------------------------------------
-- 4.- sp_save_agencies
-- -----------------------------------------------------
USE bd_NationalBank
GO

CREATE PROCEDURE sp_save_agencies
@aidagencies int = NULL,
@aagencyNumber varchar(45)= NULL,
@aname varchar(45)= NULL,
@aaddress varchar(45)= NULL,
@aidbank int= NULL,
@aiddirectorAgency int = NULL

AS
BEGIN

IF @aidagencies = 0 
INSERT INTO tagencies(agencyNumber,name,address,idbank,iddirectorAgency)
VALUES (@aagencyNumber,@aname,@aaddress,@aidbank,@aiddirectorAgency);
-- SELECT 
-- MAX(idagencies)
-- INTO @aidagencies FROM
-- tagencies;
ELSE
UPDATE tagencies 
SET  agencyNumber = @aagencyNumber , name = @aname, address = @aaddress, idbank = @aidbank, iddirectorAgency = @aiddirectorAgency
WHERE idagencies = @aidagencies

END
GO

-- -----------------------------------------------------
-- 5.- sp_save_area
-- -----------------------------------------------------
USE bd_NationalBank
GO

CREATE proc sp_save_area
@acodearea varchar(45) = NULL,
@adescription varchar (45) = null

AS
BEGIN
DECLARE @valid INT;
--select count(*) into @valid from tarea where codearea = @acodearea

set @valid = (SELECT COUNT(*) FROM tarea WHERE codearea = @acodearea);

if @valid = 0
insert into tarea (codearea, description) values(@acodearea,@adescription);
else
Update tarea set description = @adescription where codearea = @acodearea
END
GO

-- -----------------------------------------------------
-- 6.- sp_save_employee
-- -----------------------------------------------------
USE bd_NationalBank
GO

CREATE PROCEDURE sp_save_employee
@aidemployee int = null,
@aemployeeNumber varchar (45) = null,
@aname varchar (45) = null,
@alastName varchar (45) = null,
@aemail varchar (45) = null,
@aimg varchar (45) = null,
@ahiringDate date = null,
@asalary DECIMAL(22,6)= null,
@asexe varchar (1) = null,
@aactive varchar (1) = null,
@aidagencies int = null

AS
Begin

IF @aidemployee = 0
INSERT INTO temployee (employeeNumber, name, lastName, email, img, hiringDate,salary,sexe,active,idagencies)
VALUES (@aemployeeNumber, @aname, @alastName, @aemail, @aimg, @ahiringDate,@asalary,@asexe,@aactive,@aidagencies);
ELSE
UPDATE temployee 
SET employeeNumber=@aemployeeNumber,name=@aname,lastName=@alastName,email=@aemail,img=@aimg,hiringDate=@ahiringDate,salary=@asalary,sexe=@asexe,active=@aactive,idagencies=@aidagencies
WHERE idemployee = @aidemployee;
END 
GO

-- -----------------------------------------------------
-- 7.- sp_save_employ_area
-- -----------------------------------------------------

USE bd_NationalBank
GO

CREATE PROCEDURE sp_save_employ_area
@aidemployee int = null,
@acodearea varchar (3)

AS
BEGIN
 DECLARE @valid int;

 SET @valid = (SELECT COUNT (*) FROM temploy_area WHERE idemployee = @aidemployee);
 IF @valid = 0
--IF @aidemployee = 0
INSERT INTO temploy_area (idemployee, codearea) values (@aidemployee, @acodearea);
ELSE 
UPDATE temploy_area SET idemployee = @aidemployee, codearea = @acodearea WHERE idemployee = @aidemployee;
END
GO

-- -----------------------------------------------------
-- 8.- sp__save_client
-- -----------------------------------------------------

USE bd_NationalBank
GO

CREATE PROCEDURE [dbo].[sp_save_client]
@aidclient int = null,
@aclientNumber varchar(45) = null,
@aname varchar(45) = null,
@alastName varchar(45) = null,
@aemail varchar(45) = null,
@aimg varchar(45) = null,
@aaddress varchar(45) = null,
@acardNumber varchar(45) = null,
@anip varchar(45) = null,
@asexe varchar (1) = null,
@aactive varchar (1) = null,
@aidagencies int = null,
@aidemployee int = null

AS
BEGIN

IF @aidclient = 0
INSERT INTO tclient(clientNumber,name,lastName,email,img,address,cardNumber,nip,sexe,active,idagencies,idemployee)
VALUES (@aclientNumber,@aname,@alastName,@aemail,@aimg,@aaddress,@acardNumber,@anip,@asexe,@aactive,@aidagencies,@aidemployee);
-- SELECT 
-- MAX(idclient)
-- INTO @aidclient FROM
-- tclient;
ELSE
UPDATE tclient 
SET clientNumber = @aclientNumber , name = @aname , lastName = @alastName ,
    email = @aemail , img = @aimg , address = @aaddress , cardNumber = @acardNumber,
	nip=@anip,sexe=@asexe,active=@aactive,
	idagencies = @aidagencies, idemployee = @aidemployee
WHERE idclient = @aidclient 

END
GO

-- -----------------------------------------------------
-- 9.- sp_save_account
-- -----------------------------------------------------

USE bd_NationalBank
GO

CREATE PROC [dbo].[sp_save_account]

 @aidaccount int = NULL,
 @anumber varchar(45)= NULL,
 @abalance decimal(22,6)= NULL,
 @aopenDate date = NULL,
 @aidemployee int = NULL,
 @aidagencies int = NULL

AS
BEGIN

IF @aidaccount = 0 
  INSERT INTO taccount (number,balance,openDate,idemployee,idagencies)
  VALUES (@anumber,@abalance,@aopenDate,@aidemployee,@aidagencies);
ELSE
  UPDATE taccount 
   SET number = @anumber, balance = @abalance ,openDate = @aopenDate, idemployee = @aidemployee, idagencies = @aidagencies
  WHERE idaccount = @aidaccount
END
GO

-- -----------------------------------------------------
-- 10.- sp_save_accounttype
-- -----------------------------------------------------

USE bd_NationalBank
GO

CREATE procedure [dbo].[sp_save_accounttype]

@aidaccounttype int = null,
@aaccountType varchar (45) = null,
@acomission decimal (22,6) = null,
@aoverdraft decimal (22,6) = null,
@ainterestRate decimal (22,6) = null

as
begin

if @aidaccounttype = 0
 insert into taccounttype (accountType, comission, overdraft, interestRate) 
 values (@aaccountType, @acomission, @aoverdraft, @ainterestRate);
else
 update taccounttype set accountType = @aaccountType, comission = @acomission, overdraft = @aoverdraft, interestRate = @ainterestRate
 where idaccounttype = @aidaccounttype
end
GO

-- -----------------------------------------------------
-- 11.- sp_save_client_account
-- -----------------------------------------------------

USE bd_NationalBank
GO

CREATE proc [dbo].[sp_save_client_account]

@aidaccounttype int = null,
@aidclient int = null,
@aidaccount int = null

AS
BEGIN
  DECLARE @valid int;
    set @valid =(select COUNT (*) FROM tclient_account WHERE idaccounttype = @aidaccounttype AND idclient = @aidclient);
  IF @valid = 0
  --IF @aidaccounttype =0 && @aidclient = 0
    INSERT INTO tclient_account (idaccounttype, idclient, idaccount )
	VALUES (@aidaccounttype,  @aidclient, @aidaccount );
 ELSE 	
   UPDATE tclient_account SET  idaccount = @aidaccount 
   WHERE idaccounttype = @aidaccounttype AND idclient = @aidclient;
 END
 GO
 
 -- -----------------------------------------------------
-- 12.- sp_save_admin
-- -----------------------------------------------------

USE bd_NationalBank
GO

CREATE PROC [dbo].[sp_save_admin]

 @aidadmin int = NULL,
 @aadminNumber varchar(45)= NULL,
 @aname varchar(45)= NULL,
 @alastName varchar(45)= NULL,
 @aemail varchar(45)= NULL,
 @aimg varchar(45)= NULL,
 @apassword varchar(45)= NULL,
 @asexe varchar(1)= NULL,
 @aactive varchar(1)= NULL

AS
BEGIN

IF @aidadmin = 0 
INSERT INTO tadmin (adminNumber,name,lastName,img,email,password,sexe,active)
VALUES (@aadminNumber,@aname,@alastName,@aimg,@aemail,@apassword,@asexe,@aactive);
ELSE
UPDATE tadmin 
SET adminNumber=@aadminNumber,name=@aname,lastName=@alastName,img=@aimg,email=@aemail,password=@apassword,sexe=@asexe,active=@aactive
WHERE idadmin=@aidadmin

END
GO

-- =============================================
-- Author:		Ricardo Mendoza
-- Create date: 3-12-2018
-- Description:	Select agencies from bd_NationalBank
-- 13.- selectAgencies
-- =============================================
USE bd_NationalBank
GO
CREATE PROCEDURE selectAgencies
AS 
BEGIN
SELECT 
b.idagencies as idagencies,
b.agencyNumber as 'Number',
b.name as 'Agency',
b.address as 'Address',
b.idbank as 'idbank',
b.idbank as iddirectorAgency
FROM tagencies b ORDER BY name
END
GO 

-- =============================================
-- Author:		Ricardo Mendoza
-- Create date: 3-12-2018
-- Description:	Select admins from bd_NationalBank
-- 14.- selectAdmins
-- =============================================
USE [bd_NationalBank]
GO
CREATE PROCEDURE selectAdmins
AS 
BEGIN
SELECT 
b.idadmin as idadmin,
b.adminNumber as'Number',
b.name as 'Name',
b.lastName as 'Last Name',
b.email as 'Email',
b.img as img,
b.password as 'Password',
b.sexe as sexe,
b.active as active
FROM tadmin b ORDER BY name
END
GO

-- =============================================
-- Author:		Ricardo Mendoza
-- Create date: 3-12-2018
-- Description:	Select Directors from bd_NationalBank
-- 15.- selectDirectors
-- =============================================
USE [bd_NationalBank]
GO
CREATE PROCEDURE selectDirectors
AS 
BEGIN
SELECT 
b.iddirector as iddirector,
b.idbank as idbank,
b.directorNumber as'Number',
b.name as 'Name',
b.lastName as 'Last Name',
b.email as 'Email',
b.img as img,
b.salary as 'salary',
b.sexe as sexe,
b.active as active
FROM tdirectorgeneral b ORDER BY name
END
GO

-- =============================================
-- Author:		Ricardo Mendoza
-- Create date: 3-12-2018
-- Description:	Select Directors Agency from bd_NationalBank
-- 16.- selectDirectorsAgency
-- =============================================
USE [bd_NationalBank]
GO
CREATE PROCEDURE selectDirectorsAgency
AS 
BEGIN
SELECT 
b.iddirectorAgency as iddirectorAgency,
--b.idbank as idbank,
b.directorNumber as'Number',
b.name as 'Name',
b.lastName as 'Last Name',
b.email as 'Email',
b.img as img,
b.salary as 'salary',
b.sexe as sexe,
b.active as active
FROM tdirectoragency b ORDER BY name
END
GO



-- =============================================
-- Author:		Ricardo Mendoza
-- Create date: 18-12-2018
-- Description:	Select employees from bd_NationalBank
-- .- selectEmployees
-- =============================================
USE bd_NationalBank
GO

CREATE PROCEDURE selectEmployees
AS 
BEGIN
SELECT 
b.idemployee as idemployee,
b.employeeNumber as 'Number',
b.name as 'Name',
b.lastName as [Last Name],
b.email as 'Email',
b.img as 'img',
b.hiringDate as 'Hiring Date',
b.salary as 'salary',
b.sexe as 'sexe',
b.active as active,
b.idagencies as idagencies
FROM temployee b ORDER BY name
END
GO 

-- =============================================
-- Author:		Ricardo Mendoza
-- Create date: 3-12-2018
-- Description:	Select clients from bd_NationalBank
-- 15.- selectClients
-- =============================================
USE bd_NationalBank
GO

CREATE PROCEDURE selectClients
AS 
BEGIN
SELECT 
b.idclient AS idclient,
b.clientNumber AS 'Number',
b.name As Name,
b.lastName As [Last Name],
--case
--WHEN b.sexe = 'M' THEN 'Sir'
--WHEN b.sexe ='F' THEN 'Mrs'
--END
--AS 'Gender',
--concat(b.name,' ', b.lastName) as 'Client',
b.email as 'Email',
b.img as Img,
b.address as 'Address',
b.cardNumber as [Card Number],
b.nip as Nip,
b.sexe as 'Sexe',
b.active as Active,
b.idagencies as 'idagencies',
b.idemployee as idemployee
FROM tclient b ORDER BY name
END
GO 

-- =============================================
-- Author:		Ricardo Mendoza
-- Create date: 3-12-2018
-- Description:	Select clients by Agency from bd_NationalBank
-- 15.- selectqClientByAgency
-- =============================================
USE bd_NationalBank
GO

CREATE PROCEDURE selectqClientByAgency
@aAgency VARCHAR(45) = null
AS
BEGIN
SELECT * FROM qClients WHERE @aAgency = Agency
END
GO 

-- =============================================
-- Author:		Ricardo Mendoza
-- Create date: 3-12-2018
-- Description:	Select clients by Agency from bd_NationalBank
-- 16.- selectqClientByClientNumber
-- =============================================
USE bd_NationalBank
GO

CREATE PROCEDURE selectqClientByNumber
@aNumber VARCHAR(45) = null
AS
BEGIN
SELECT * FROM qClients WHERE @aNumber = Number
END
GO

-- =============================================
-- Author:		Ricardo Mendoza
-- Create date: 26-01-2019
-- Description:	Select client account by client name from bd_NationalBank
-- 17.- selectAccountByClient
-- =============================================
USE bd_NationalBank
GO

CREATE PROCEDURE selectAccountByClientandAccountType
@aaccountType VARCHAR(45) = null, -- 'PaidAccount'
@alastName VARCHAR(45) = null
AS
DECLARE @valid FLOAT; -- IMPORTANT REMARKS THE DECIMALS
SET @valid = (select comission from taccounttype where accountType = @aaccountType); -- 'PaidAccount' comission = 0 
BEGIN
IF @valid = 0 -- 'PaidAccount' comission = 0 
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
	d.interestRate as 'Interest', -- 'PaidAccount' comission = 0 
	-- taccount  ------------------------------
	c.balance as 'Balance',
	c.openDate as 'Open Date'
	FROM tclient a LEFT JOIN tclient_account b ON a.idclient=b.idclient 
	LEFT JOIN taccounttype d ON b.idaccounttype = d.idaccounttype 
	LEFT JOIN taccount c ON b.idaccount=c.idaccount
	LEFT JOIN temployee h ON a.idemployee = h.idemployee
	WHERE a.lastName = @alastName  AND d.accountType = @aaccountType
ELSE
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
	d.comission as 'Comission',   -- UnPaidAccount
	-- NOTE : comission NEVER CAN BE 0
    d.overdraft as 'Overdraft',   -- UnPaidAccount
	-- taccount  ------------------------------
	c.balance as 'Balance',
	c.openDate as 'Open Date'
	FROM tclient a LEFT JOIN tclient_account b ON a.idclient=b.idclient 
	LEFT JOIN taccounttype d ON b.idaccounttype = d.idaccounttype 
	LEFT JOIN taccount c ON b.idaccount=c.idaccount
	LEFT JOIN temployee h ON a.idemployee = h.idemployee
	WHERE a.lastName = @alastName  AND d.accountType = @aaccountType
END
GO

--Exec selectAccountByClient
--@alastName = 'Winfreh',
--@aaccountType   = 'UnPaidAccount'

-- =============================================
-- Author:		Ricardo Mendoza
-- Create date: 26-01-2019
-- Description:	Select accounts by client name from bd_NationalBank
-- 18.- selectAccountByClient
-- =============================================
CREATE PROCEDURE selectAccountsByClient
@alastName VARCHAR(45) = null
AS
BEGIN
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
	-- NOTE : comission NEVER CAN BE 0
	d.comission as 'Comission',   -- UnPaidAccount
    d.overdraft as 'Overdraft',   -- UnPaidAccount
	-- taccount  ------------------------------
	c.balance as 'Balance',
	c.openDate as 'Open Date'
	FROM tclient a LEFT JOIN tclient_account b ON a.idclient=b.idclient 
	LEFT JOIN taccounttype d ON b.idaccounttype = d.idaccounttype 
	LEFT JOIN taccount c ON b.idaccount=c.idaccount
	LEFT JOIN temployee h ON a.idemployee = h.idemployee
	WHERE a.lastName = @alastName
END
GO

-- Exec selectAccountsByClient
-- @alastName = 'Winfreh'