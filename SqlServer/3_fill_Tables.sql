-- This project uses the following licenses:
-- MIT License
-- Copyright (c) 2018 Ricardo Mendoza 
-- Montréal Québec Canada

-- Repository : MVC_winapp_NationalBank_SqlServer > https://github.com/RicardoAMendoza/MVC_winapp_NationalBank_SqlServer.git
-- Project : prjWin_MVC_NationalBank_SqlServer_Rm
-- Instruction :
-- Copy and paste on SqlServer script and run it. That will create de data base

-- -----------------------------------------------------
-- 1. EXEC  sp_save_bank
-- -----------------------------------------------------
USE bd_NationalBank
GO

EXEC sp_save_bank
@aidbank =0,
@aname = "National Bank",
@acapital = 100000000,
@aaddress = "1000 Sherbroke" 

-- -----------------------------------------------------
-- 2. EXEC  sp_save_directorgeneral
-- -----------------------------------------------------
USE bd_NationalBank
GO

EXEC  sp_save_directorgeneral
@aiddirector = 0,
@aidbank = 1,
@adirectorNumber = "dir01",
@aname = "Patrick",
@alastName = "Dorre",
@aemail = "dorre@gmail.com",
@aimg = "dorre.png",
@asalary = 80000,
@asexe = 'M',
@aactive ="A" 

EXEC  sp_save_directorgeneral
@aiddirector = 0,
@aidbank = 1,
@adirectorNumber = "dir02",
@aname = "Fernand",
@alastName = "Bikatal-Bi-Tonye",
@aemail = "bikatal@gmail.com",
@aimg = "fernand.png",
@asalary = 90000,
@asexe = 'M',
@aactive ="A" 

EXEC  sp_save_directorgeneral
@aiddirector = 0,
@aidbank = 1,
@adirectorNumber = "dir03",
@aname = "Richard",
@alastName = "Saint-Vingt-Cent",
@aemail = "bikatal@gmail.com",
@aimg = "richard.png",
@asalary = 60000,
@asexe = 'M',
@aactive ="N" 

-- -----------------------------------------------------
-- 3. EXEC  sp_save_directoragencie
-- -----------------------------------------------------
USE bd_NationalBank
GO

EXEC  sp_save_directoragencie
@aiddirectorAgency = 0,
@adirectorNumber = "dir01",
@aname = "Patrick",
@alastName = "Dorre",
@aemail = "dorre@gmail.com",
@aimg = "dorre.png",
@asalary = 80000,
@asexe = 'M',
@aactive ="N" 

EXEC  sp_save_directoragencie
@aiddirectorAgency = 0,
@adirectorNumber = "dir02",
@aname = "Fernand",
@alastName = "Bikatal-Bi-Tonye",
@aemail = "bikatal@gmail.com",
@aimg = "fernand.png",
@asalary = 90000,
@asexe = 'M',
@aactive ="N" 

EXEC  sp_save_directoragencie
@aiddirectorAgency = 0,
@adirectorNumber = "dir03",
@aname = "Richard",
@alastName = "Saint-Vingt-Cent",
@aemail = "bikatal@gmail.com",
@aimg = "richard.png",
@asalary = 60000,
@asexe = 'M',
@aactive ="A" 

-- -----------------------------------------------------
-- 4. EXEC sp_save_agencies
-- -----------------------------------------------------
USE bd_NationalBank
GO

EXEC sp_save_agencies 
@aidagencies = 0,
@aagencyNumber = 'A1A1',
@aname = 'Rosemont NB',
@aaddress = '2727 Rosemont',
@aidbank = 1,
@aiddirectorAgency = 1

EXEC sp_save_agencies 
@aidagencies = 0,
@aagencyNumber = 'A2A2',
@aname = 'MontRoyal NB',
@aaddress = '3131 MontRoyal',
@aidbank = 1,
@aiddirectorAgency = 2

EXEC sp_save_agencies
@aidagencies = 0,
@aagencyNumber = 'A3A3',
@aname = 'Beaubien NB',
@aaddress = '247 Beaubien',
@aidbank = 1,
@aiddirectorAgency = 3

EXEC sp_save_agencies 
@aidagencies = 0,
@aagencyNumber = 'A4A4',
@aname = 'Alexander NB',
@aaddress = '456 Alexander',
@aidbank = 1,
@aiddirectorAgency = 2

-- -----------------------------------------------------
-- 5. EXEC sp_save_area
-- -----------------------------------------------------
USE bd_NationalBank
GO

EXEC sp_save_area
@acodearea = [FIN],
@adescription = 'Finances'

EXEC sp_save_area
@acodearea = [INS],
@adescription = 'Insurances'

EXEC sp_save_area
@acodearea = [INV],
@adescription = 'Investments'

EXEC sp_save_area
@acodearea = [SAV],
@adescription = 'Savings'

-- -----------------------------------------------------
-- 6. EXEC sp_save_employee
-- -----------------------------------------------------

USE bd_NationalBank
GO

EXEC sp_save_employee 
@aidemployee  = 0,
@aemployeeNumber  = 'E1E1',
@aname  = 'Juan',
@alastName = 'Zamanego',
@aemail  = 'zamanego@gamil.com',
@aimg  = 'zamanego.png',
@ahiringDate  = '2017-02-23',
@asalary = 150000.99,
@asexe = 'M',
@aactive = 'A',
@aidagencies  = 1

EXEC sp_save_employee 
@aidemployee  = 0,
@aemployeeNumber  = 'E3E3',
@aname  = 'Cesar',
@alastName = 'Silva',
@aemail  = 'cesar@gmail.com',
@aimg  = 'silva.png',
@ahiringDate  = '2014-09-19',
@asalary = 150000.99,
@asexe = 'M',
@aactive = 'A',
@aidagencies  = 2

EXEC [dbo].[sp_save_employee] 
@aidemployee  = 0,
@aemployeeNumber  = 'E4E4',
@aname  = 'Ana',
@alastName = 'Fernandez',
@aemail  = 'fernandez@gmail.com',
@aimg  = 'fernandez.png',
@ahiringDate  = '2013-11-15',
@asalary = 150000.99,
@asexe = 'F',
@aactive = 'A',
@aidagencies  = 3

EXEC [dbo].[sp_save_employee]  
@aidemployee  = 0,
@aemployeeNumber  = 'E2E2',
@aname  = 'Rauoul',
@alastName = 'Nguiya',
@aemail  = 'raoul@gmail.com',
@aimg  = 'nguiya.png',
@ahiringDate  = '2013-03-23',
@asalary = 150000.99,
@asexe = 'M',
@aactive = 'A',
@aidagencies  = 4

EXEC [dbo].[sp_save_employee]  
@aidemployee  = 0,
@aemployeeNumber  = 'E5E5',
@aname  = 'Maria',
@alastName = 'Houda',
@aemail  = 'maria@google.com',
@aimg  = 'houda.png',
@ahiringDate  = '2012-01-01',
@asalary = 150000.99,
@asexe = 'F',
@aactive = 'A',
@aidagencies  = 1

EXEC [dbo].[sp_save_employee]  
@aidemployee  = 0,
@aemployeeNumber  = 'E6E6',
@aname  = 'Maria',
@alastName = 'Arteaga',
@aemail  = 'arteaga@gmail.com',
@aimg  = 'arteaga.png',
@ahiringDate  = '2011-02-03',
@asalary = 150000.99,
@asexe = 'F',
@aactive = 'A',
@aidagencies  = 2

EXEC [dbo].[sp_save_employee]  
@aidemployee  = 0,
@aemployeeNumber  = 'E7E7',
@aname  = 'Maria',
@alastName = 'Madany',
@aemail  = 'madany@google.com',
@aimg  = 'madany.png',
@ahiringDate  = '2015-08-10',
@asalary = 100000.99,
@asexe = 'F',
@aactive = 'A',
@aidagencies  = 3

EXEC [dbo].[sp_save_employee]  
@aidemployee  = 0,
@aemployeeNumber  = 'E8E8',
@aname  = 'Roseely',
@alastName = 'Brand',
@aemail  = 'brand@gmail.com',
@aimg  = 'brand.png',
@ahiringDate  = '2012-05-13',
@asalary = 150000.99,
@asexe = 'F',
@aactive = 'A',
@aidagencies  = 4

EXEC [dbo].[sp_save_employee]  
@aidemployee  = 0,
@aemployeeNumber  = 'E10E10',
@aname  = 'Esmeralda',
@alastName = 'Mafogue',
@aemail  = 'esmeralda@gmail.com',
@aimg  = 'mafogue.png',
@ahiringDate  = '2000-09-02',
@asalary = 150000.99,
@asexe = 'F',
@aactive = 'A',
@aidagencies  = 1

EXEC [dbo].[sp_save_employee] 
@aidemployee  = 0,
@aemployeeNumber  = 'E9E9',
@aname  = 'Silvayn',
@alastName = 'Trudeau',
@aemail  = 'trudeau@gmail.com',
@aimg  = 'trudeau.png',
@ahiringDate  = '2012-04-21',
@asalary = 150000.99,
@asexe = 'M',
@aactive = 'A',
@aidagencies  = 2

EXEC [dbo].[sp_save_employee]  
@aidemployee  = 0,
@aemployeeNumber  = 'E11E11',
@aname  = 'Brack',
@alastName = 'Obama',
@aemail  = 'obama@gamil.com',
@aimg  = 'brand.png',
@ahiringDate  = '1999-01-12',
@asalary = 150000.99,
@asexe = 'M',
@aactive = 'A',
@aidagencies  = 3

EXEC [dbo].[sp_save_employee] 
@aidemployee  = 0,
@aemployeeNumber  = 'E12E12',
@aname  = 'Benoit',
@alastName = 'Fracoise',
@aemail  = 'benoit@gmail.com',
@aimg  = 'francoise.png',
@ahiringDate  = '1998-04-03',
@asalary = 150000.99,
@asexe = 'M',
@aactive = 'A',
@aidagencies  = 4

EXEC [dbo].[sp_save_employee] 
@aidemployee  = 0,
@aemployeeNumber  = 'E13E13',
@aname  = 'Helena',
@alastName = 'Gonzalez',
@aemail  = 'gonzalez@google.com',
@aimg  = 'gonzalez.png',
@ahiringDate  = '2015-08-10',
@asalary = 150000.99,
@asexe = 'F',
@aactive = 'A',
@aidagencies  = 1

-- -----------------------------------------------------
-- 7. EXEC sp_save_employ_area
-- -----------------------------------------------------

Exec sp_save_employ_area
@aidemployee = 1,
@acodearea = 'FIN'

Exec sp_save_employ_area
@aidemployee = 2,
@acodearea = 'FIN'

Exec sp_save_employ_area
@aidemployee = 3,
@acodearea = 'FIN'

Exec sp_save_employ_area
@aidemployee = 4,
@acodearea = 'FIN'

Exec sp_save_employ_area
@aidemployee = 5,
@acodearea = 'INS'

Exec sp_save_employ_area
@aidemployee = 6,
@acodearea = 'INS'

Exec sp_save_employ_area
@aidemployee = 7,
@acodearea = 'INS'

Exec sp_save_employ_area
@aidemployee = 8,
@acodearea = 'INV'

Exec sp_save_employ_area
@aidemployee = 9,
@acodearea = 'INV'

Exec sp_save_employ_area
@aidemployee  = 10,
@acodearea = 'INV'

Exec sp_save_employ_area
@aidemployee  = 11,
@acodearea = 'SAV'

Exec sp_save_employ_area
@aidemployee = 12,
@acodearea = 'SAV'

Exec sp_save_employ_area
@aidemployee = 13,
@acodearea = 'SAV'

-- -----------------------------------------------------
-- 8. EXEC sp_save_client
-- -----------------------------------------------------

USE bd_NationalBank
GO

exec sp_save_client
@aidclient = 0,
@aclientNumber  = 'C1C1',
@aname  = 'Bill',
@alastName  = 'Gates',
@aemail  = 'gates@microsoft.com',
@aimg  = 'gates.png',
@aaddress  = '3540 Masson',
@acardNumber = '123456',
@anip  = 'windows',
@asexe = 'M',
@aactive = 'A',
@aidagencies  = 1,
@aidemployee = 2

exec sp_save_client
@aidclient = 0,
@aclientNumber  = 'C2C2',
@aname  = 'Steve',
@alastName  = 'Jobs',
@aemail  = 'jobs@apple.com',
@aimg  = 'jobs.png',
@aaddress  = '148 Cousineau',
@acardNumber = '123457',
@anip  = 'windows',
@asexe = 'M',
@aactive = 'A',
@aidagencies  = 1,
@aidemployee = 3

exec sp_save_client
@aidclient = 0,
@aclientNumber  = 'C3C3',
@aname  = 'Oprah',
@alastName  = 'Winfreh',
@aemail  = 'oprah@google.com',
@aimg  = 'winfreh.png',
@aaddress  = '3030 Hochelaga',
@acardNumber = '123458',
@anip  = 'own',
@asexe = 'F',
@aactive = 'A',
@aidagencies  = 1,
@aidemployee = 4

exec sp_save_client
@aidclient = 0,
@aclientNumber  = 'C5C5',
@aname  = 'Salvador',
@alastName  = 'Dali',
@aemail  = 'dali@google.com',
@aimg  = 'dali.png',
@aaddress  = '1545 La Jounnesse',
@acardNumber = '123459',
@anip  = 'pintor',
@asexe = 'M',
@aactive = 'A',
@aidagencies  = 2,
@aidemployee = 5

exec sp_save_client
@aidclient = 0,
@aclientNumber  = 'C4C4',
@aname  = 'Rosa',
@alastName  = 'Huerta',
@aemail  = 'huerta@google.com',
@aimg  = 'huerta.png',
@aaddress  = '227 Belanger',
@acardNumber = '123469',
@anip  = 'unix',
@asexe = 'F',
@aactive = 'A',
@aidagencies  = 2,
@aidemployee = 6

exec sp_save_client
@aidclient = 0,
@aclientNumber  = 'C6C6',
@aname  = 'Wendy',
@alastName  = 'Savala',
@aemail  = 'savala@google.com',
@aimg  = 'savala.png',
@aaddress  = '3030 Hochelaga',
@acardNumber = '123479',
@anip  = 'cpp',
@asexe = 'F',
@aactive = 'A',
@aidagencies  = 2,
@aidemployee = 7

exec sp_save_client
@aidclient = 0,
@aclientNumber  = 'C7C7',
@aname  = 'Mark',
@alastName  = 'Zurembek',
@aemail  = 'mark@facebook.com',
@aimg  = 'zurembek.png',
@aaddress  = '616 Place Brazeau',
@acardNumber = '123489',
@anip  = 'facebook',
@asexe = 'F',
@aactive = 'A',
@aidagencies  = 3,
@aidemployee = 8

exec sp_save_client
@aidclient = 0,
@aclientNumber  = 'C8C8',
@aname  = 'Antonio',
@alastName  = 'Maya',
@aemail  = 'maya@facebook.com',
@aimg  = 'maya.png',
@aaddress  = '316 Chilpa',
@acardNumber = '123499',
@anip  = 'alfonso13',
@asexe = 'M',
@aactive = 'A',
@aidagencies  = 3,
@aidemployee = 9

exec sp_save_client
@aidclient = 0,
@aclientNumber  = 'C9C9',
@aname  = 'Itzel',
@alastName  = 'Alvaro',
@aemail  = 'itzel@facebook.com',
@aimg  = 'alvaro.png',
@aaddress  = '527 Alexander',
@acardNumber = '123599',
@anip  = 'quimica',
@asexe = 'M',
@aactive = 'A',
@aidagencies  = 3,
@aidemployee = 10

exec sp_save_client
@aidclient = 0,
@aclientNumber  = 'C10C10',
@aname  = 'Fanny',
@alastName  = 'Santos',
@aemail  = 'santos@facebook.com',
@aimg  = 'santos.png',
@aaddress  = '333 Saint-Croax',
@acardNumber = '123699',
@anip  = 'veracruz',
@asexe = 'F',
@aactive = 'A',
@aidagencies  = 4,
@aidemployee = 11

exec sp_save_client
@aidclient = 0,
@aclientNumber  = 'C11C11',
@aname  = 'Manuel',
@alastName  = 'Brizuela',
@aemail  = 'brizuela@facebook.com',
@aimg  = 'brizuela.png',
@aaddress  = '148 Cousineau',
@acardNumber = '123799',
@anip  = 'construccion',
@asexe = 'M',
@aactive = 'A',
@aidagencies  = 4,
@aidemployee = 12

exec sp_save_client
@aidclient = 0,
@aclientNumber  = 'C12C12',
@aname  = 'Pedro',
@alastName  = 'Espana',
@aemail  = 'espana@facebook.com',
@aimg  = 'espana.png',
@aaddress  = '555 Tacherau',
@acardNumber = '123899',
@anip  = 'soldadura',
@asexe = 'M',
@aactive = 'A',
@aidagencies  = 4,
@aidemployee = 1

-- -----------------------------------------------------
-- 9. EXEC sp_save_account
-- -----------------------------------------------------
USE bd_NationalBank
GO

-- C1C1 ----------------------------
exec sp_save_account
@aidaccount  = 0,
@anumber = "UA1UA1",
@abalance = 2300,
@aopenDate  = '2016-08-17 23:59:59',
@aidemployee  = 1,
@aidagencies  = 1

exec sp_save_account
@aidaccount  = 0,
@anumber = "PA1PA1",
@abalance = 2999,
@aopenDate  = '2016-08-17 23:59:59',
@aidemployee  = 1,
@aidagencies  = 1

-- C2C2 ----------------------------
exec sp_save_account
@aidaccount  = 0,
@anumber = "UA2UA2",
@abalance = 2000,
@aopenDate  = '2018-12-17 23:59:59',
@aidemployee  = 2,
@aidagencies  = 1

exec sp_save_account
@aidaccount  = 0,
@anumber = "PA2PA2",
@abalance = 2999,
@aopenDate  = '2016-08-17 23:59:59',
@aidemployee  = 2,
@aidagencies  = 1

-- C3C3 ----------------------------
exec sp_save_account
@aidaccount  = 0,
@anumber = "UA3UA3",
@abalance = 4900,
@aopenDate  = '2011-09-17 23:59:59',
@aidemployee  = 3,
@aidagencies  = 1

exec sp_save_account
@aidaccount  = 0,
@anumber = "PA3PA3",
@abalance = 9999,
@aopenDate  = '2012-08-21 23:59:59',
@aidemployee  = 3,
@aidagencies  = 1

-- C4C4 ----------------------------
exec sp_save_account
@aidaccount  = 0,
@anumber = "UA4UA4",
@abalance = 19000,
@aopenDate  = '2013-02-17 23:59:59',
@aidemployee  = 4,
@aidagencies  = 2

exec sp_save_account
@aidaccount  = 0,
@anumber = "PA4PA4",
@abalance = 2399,
@aopenDate  = '2011-03-11 23:59:59',
@aidemployee  = 4,
@aidagencies  = 2

 -- C5C5 ----------------------------
exec sp_save_account
@aidaccount  = 0,
@anumber = "UA5UA5",
@abalance = 20000,
@aopenDate  = '2000-02-07 23:59:59',
@aidemployee  = 5,
@aidagencies  = 2

exec sp_save_account
@aidaccount  = 0,
@anumber = "PA5PA5",
@abalance = 2399,
@aopenDate  = '2000-03-02 23:59:59',
@aidemployee  = 5,
@aidagencies  = 2

-- C6C6 ----------------------------
exec sp_save_account
@aidaccount  = 0,
@anumber = "UA6UA6",
@abalance = 18000,
@aopenDate  = '2009-02-24 23:59:59',
@aidemployee  = 6,
@aidagencies  = 2

exec sp_save_account
@aidaccount  = 0,
@anumber = "PA6PA6",
@abalance = 15000,
@aopenDate  = '2009-02-24 23:59:59',
@aidemployee  = 6,
@aidagencies  = 2

-- C7C7 ----------------------------
exec sp_save_account
@aidaccount  = 0,
@anumber = "UA7UA7",
@abalance = 13000,
@aopenDate  = '2010-04-21 23:59:59',
@aidemployee  = 7,
@aidagencies  = 3

exec sp_save_account
@aidaccount  = 0,
@anumber = "PA74PA7",
@abalance = 7000,
@aopenDate  = '2010-04-21 23:59:59',
@aidemployee  = 7,
@aidagencies  = 3

-- C8C8 ----------------------------
exec sp_save_account
@aidaccount  = 0,
@anumber = "UA8UA8",
@abalance = 9000,
@aopenDate  = '2013-04-26 23:59:59',
@aidemployee  = 8,
@aidagencies  = 3

exec sp_save_account
@aidaccount  = 0,
@anumber = "PA84PA8",
@abalance = 15000,
@aopenDate  = '2013-04-26 23:59:59',
@aidemployee  = 8,
@aidagencies  = 3

-- C9C9 ----------------------------
exec sp_save_account
@aidaccount  = 0,
@anumber = "UA9UA9",
@abalance = 18000,
@aopenDate  = '2006-03-30 23:59:59',
@aidemployee  = 9,
@aidagencies  = 3

exec sp_save_account
@aidaccount  = 0,
@anumber = "PA9PA9",
@abalance = 14000,
@aopenDate  = '2006-03-30 23:59:59',
@aidemployee  = 9,
@aidagencies  = 3

-- C10C10 ----------------------------
exec sp_save_account
@aidaccount  = 0,
@anumber = "UA10UA10",
@abalance = 9000,
@aopenDate  = '2007-03-21 23:59:59',
@aidemployee  = 10,
@aidagencies  = 4

exec sp_save_account
@aidaccount  = 0,
@anumber = "PA10PA10",
@abalance = 7000,
@aopenDate  = '2007-03-21 23:59:59',
@aidemployee  = 10,
@aidagencies  = 4

-- C11C11 ----------------------------
exec sp_save_account
@aidaccount  = 0,
@anumber = "UA11UA11",
@abalance = 2300,
@aopenDate  = '1998-01-21 23:59:59',
@aidemployee  = 11,
@aidagencies  = 4

exec sp_save_account
@aidaccount  = 0,
@anumber = "PA11PA11",
@abalance = 700,
@aopenDate  = '1998-01-21 23:59:59',
@aidemployee  = 11,
@aidagencies  = 4

-- C12C12 ----------------------------
exec sp_save_account
@aidaccount  = 0,
@anumber = "UA12UA12",
@abalance = 21000,
@aopenDate  = '1996-01-15 23:59:59',
@aidemployee  = 12,
@aidagencies  = 4

exec sp_save_account
@aidaccount  = 0,
@anumber = "P12PA12",
@abalance = 16000,
@aopenDate  = '1996-01-15 23:59:59',
@aidemployee  = 12,
@aidagencies  = 4

-- -----------------------------------------------------
-- 10. EXEC sp_save_accounttype
-- -----------------------------------------------------
USE bd_NationalBank
GO

 exec sp_save_accounttype
 @aidaccounttype = 0,
 @aaccountType = UnPaidAccount,
 @acomission = 0.12,
 @aoverdraft = 2000,
 @ainterestRate = 0
 
 exec sp_save_accounttype
 @aidaccounttype = 0,
 @aaccountType = PaidAccount,
 @acomission = 0,
 @aoverdraft = 0,
 @ainterestRate = 0.15
 
-- -----------------------------------------------------
-- 11. EXEC sp_save_client_account
-- -----------------------------------------------------
USE bd_NationalBank
GO

-- C1C1 ----------------------------
exec sp_save_client_account
@aidaccounttype = 1,
@aidclient = 1,
@aidaccount = 1

exec sp_save_client_account
@aidaccounttype = 2,
@aidclient = 1,
@aidaccount = 2

-- C2C2 ----------------------------
exec sp_save_client_account
@aidaccounttype = 1,
@aidclient = 2,
@aidaccount = 3

exec sp_save_client_account
@aidaccounttype = 2,
@aidclient = 2,
@aidaccount = 4

-- C3C3 ----------------------------
exec sp_save_client_account
@aidaccounttype = 1,
@aidclient = 3,
@aidaccount = 5

exec sp_save_client_account
@aidaccounttype = 2,
@aidclient = 3,
@aidaccount = 6

-- C4C4 ----------------------------
exec sp_save_client_account
@aidaccounttype = 1,
@aidclient = 4,
@aidaccount = 7

exec sp_save_client_account
@aidaccounttype = 2,
@aidclient = 4,
@aidaccount = 8

 -- C5C5 ----------------------------
exec sp_save_client_account
@aidaccounttype = 1,
@aidclient = 5,
@aidaccount = 9

exec sp_save_client_account
@aidaccounttype = 2,
@aidclient = 5,
@aidaccount = 10

-- C6C6 ----------------------------
exec sp_save_client_account
@aidaccounttype = 1,
@aidclient = 6,
@aidaccount = 11

exec sp_save_client_account
@aidaccounttype = 2,
@aidclient = 6,
@aidaccount = 12

-- C7C7 ----------------------------
exec sp_save_client_account
@aidaccounttype = 1,
@aidclient = 7,
@aidaccount = 13

exec sp_save_client_account
@aidaccounttype = 2,
@aidclient = 7,
@aidaccount = 14

-- C8C8 ----------------------------
exec sp_save_client_account
@aidaccounttype = 1,
@aidclient = 8,
@aidaccount = 15

exec sp_save_client_account
@aidaccounttype = 2,
@aidclient = 8,
@aidaccount = 16

-- C9C9 ----------------------------
exec sp_save_client_account
@aidaccounttype = 1,
@aidclient = 9,
@aidaccount = 17

exec sp_save_client_account
@aidaccounttype = 2,
@aidclient = 9,
@aidaccount = 18

-- C10C10 ----------------------------
exec sp_save_client_account
@aidaccounttype = 1,
@aidclient = 10,
@aidaccount = 19

exec sp_save_client_account
@aidaccounttype = 2,
@aidclient = 10,
@aidaccount = 20

-- C11C11 ----------------------------
exec sp_save_client_account
@aidaccounttype = 1,
@aidclient = 11,
@aidaccount = 21

exec sp_save_client_account
@aidaccounttype = 2,
@aidclient = 11,
@aidaccount = 22

-- C12C12 ----------------------------
exec sp_save_client_account
@aidaccounttype = 1,
@aidclient = 12,
@aidaccount = 23

exec sp_save_client_account
@aidaccounttype = 2,
@aidclient = 12,
@aidaccount = 24


-- -----------------------------------------------------
-- 12. EXEC sp_save_admin
-- -----------------------------------------------------
USE bd_NationalBank
GO

EXEC [dbo].[sp_save_admin] 
@aidadmin  = 0,
@aadminNumber = 'Ad01',
@aname = 'Andy',
@alastName = 'Garcia',
@aemail = 'garcia@teccart.qc.ca',
@aimg = 'andy.png',
@apassword = 'sql',
@asexe = 'M',
@aactive = 'A'

EXEC [dbo].[sp_save_admin] 
@aidadmin  = 0,
@aadminNumber = 'Ad02',
@aname = 'Ricardo',
@alastName = 'Mendoza',
@aemail = 'omnimtv@gmail.com',
@aimg = 'ricardo.png',
@apassword = 'omni',
@asexe = 'M',
@aactive = 'A'

EXEC [dbo].[sp_save_admin] 
@aidadmin  = 0,
@aadminNumber = 'Ad03',
@aname = 'Ricker',
@alastName = 'Alcindor',
@aemail = 'rickers@teccart.qc.ca',
@aimg = 'rickers.png',
@apassword = 'database',
@asexe = 'M',
@aactive = 'A'

