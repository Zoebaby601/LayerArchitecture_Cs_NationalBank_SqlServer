-- This project uses the following licenses:
-- MIT License
-- Copyright (c) 2018 Ricardo Mendoza 
-- Montréal Québec Canada

-- Repository : MVC_winapp_NationalBank_SqlServer > https://github.com/RicardoAMendoza/MVC_winapp_NationalBank_SqlServer.git
-- Project : prjWin_MVC_NationalBank_SqlServer_Rm
-- Instruction :
-- Copy and paste on SqlServer script and run it. That will create de data base

-- -----------------------------------------------------
-- Data base bd_aspcrud_examen
-- -----------------------------------------------------
CREATE DATABASE bd_NationalBank
Go
-- -----------------------------------------------------
-- Tables 
-- -----------------------------------------------------

USE bd_NationalBank
Go
-- -----------------------------------------------------
-- 1.- Table `bd_NationalBank`.`tbank`
-- -----------------------------------------------------
CREATE TABLE tbank
(
idbank INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
name VARCHAR (45) NULL DEFAULT NULL,
capital DECIMAL(22,6) NULL DEFAULT NULL,
address VARCHAR (45) NULL DEFAULT NULL,
)

-- -----------------------------------------------------
-- 2.- Table `bd_NationalBank`.`tdirectorgeneral`
-- -----------------------------------------------------
CREATE TABLE tdirectorgeneral
(
iddirector INT NOT NULL IDENTITY (1,1), -- auto increment
idbank INT NOT NULL,
directorNumber VARCHAR (45) NULL DEFAULT NULL,
name VARCHAR (45) NULL DEFAULT NULL,
lastName VARCHAR (45) NULL DEFAULT NULL,
email VARCHAR (45) NULL DEFAULT NULL,
img VARCHAR (45) NULL DEFAULT NULL,
salary DECIMAL(22,6) NULL DEFAULT NULL,
sexe VARCHAR (1) NULL DEFAULT NULL,
active VARCHAR (1) NULL DEFAULT NULL,
PRIMARY KEY (iddirector, idbank),
--- REFERNCES
CONSTRAINT Relation_a_tbank FOREIGN KEY (idbank) REFERENCES tbank(idbank)
-- DECIMAL(22,6)
-- Precision is the number of digits in a number. 
-- Scale is the number of digits to the right of the DECIMAL point in a number.
-- For example, the number 123.45 
-- has a precision of 5 and a scale of 2.
)

-- -----------------------------------------------------
-- 3.- Table `bd_NationalBank`.`tdirectoragency`
-- -----------------------------------------------------
CREATE TABLE tdirectoragency
(
iddirectorAgency INT IDENTITY (1,1) not NULL PRIMARY KEY,
directorNumber VARCHAR (45) NULL DEFAULT NULL,
name VARCHAR(45) NULL DEFAULT NULL,
lastName VARCHAR(45) NULL DEFAULT NULL,
email VARCHAR(45) NULL DEFAULT NULL,
img VARCHAR (45) NULL DEFAULT NULL,
salary DECIMAL(22,6) NULL DEFAULT NULL,
sexe VARCHAR (1) NULL DEFAULT NULL,
active VARCHAR (1),
)

-- -----------------------------------------------------
-- 4.- Table `bd_NationalBank`.`tagencies`
-- -----------------------------------------------------
CREATE TABLE tagencies
(
idagencies INT IDENTITY (1,1) not NULL PRIMARY KEY,
agencyNumber VARCHAR (45) NULL DEFAULT NULL,
name VARCHAR (45)  NULL DEFAULT NULL,
address VARCHAR (45) NULL DEFAULT NULL,
idbank INT not NULL,
iddirectorAgency INT not NULL,
--- REFERNCES
CONSTRAINT Relation_a_tbank_2 FOREIGN KEY (idbank) REFERENCES tbank(idbank),
CONSTRAINT Relation_a_tdirectoragency FOREIGN KEY (iddirectorAgency) REFERENCES tdirectoragency(iddirectorAgency) 
)

-- -----------------------------------------------------
-- 5.- Table `bd_NationalBank`.`tarea`
-- -----------------------------------------------------
CREATE TABLE tarea
(
codearea VARCHAR (3) not NULL PRIMARY KEY,
description VARCHAR (45) NULL DEFAULT NULL,
) 

-- -----------------------------------------------------
-- 6.- Table `bd_NationalBank`.`temployee`
-- -----------------------------------------------------
CREATE TABLE temployee
(
idemployee INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
employeeNumber VARCHAR(45) NULL DEFAULT NULL,
name VARCHAR (45) NULL DEFAULT NULL,
lastName VARCHAR (45) NULL DEFAULT NULL,
email VARCHAR (45) NULL DEFAULT NULL,
img VARCHAR (45) NULL DEFAULT NULL,
hiringDate DATE NULL DEFAULT NULL,
salary DECIMAL(22,6) NULL DEFAULT NULL,
sexe VARCHAR (1) NULL DEFAULT NULL,
active VARCHAR (1) NULL DEFAULT NULL,
idagencies INT NOT NULL,
--- REFERNCES
CONSTRAINT Relation_a_tagencies FOREIGN KEY (idagencies) REFERENCES tagencies(idagencies)
)

-- -----------------------------------------------------
-- 7.- Table `bd_NationalBank`.`temploy_area`
-- -----------------------------------------------------
CREATE TABLE temploy_area
(
idemployee INT NOT NULL,
codearea VARCHAR (3) NOT NULL,
PRIMARY KEY (idemployee,codearea),
--- REFERNCES
CONSTRAINT Relation_a_temployee FOREIGN KEY (idemployee) REFERENCES temployee(idemployee),
CONSTRAINT Relation_a_tarea FOREIGN KEY (codearea) REFERENCES tarea(codearea)
)

-- -----------------------------------------------------
-- 8.- Table `bd_NationalBank`.`tclient`
-- -----------------------------------------------------
CREATE TABLE tclient
(
idclient INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
clientNumber VARCHAR (45) NULL DEFAULT NULL,
name VARCHAR (45) NULL DEFAULT NULL,
lastName VARCHAR (45) NULL DEFAULT NULL,
email VARCHAR (45) NULL DEFAULT NULL,
img VARCHAR (45) NULL DEFAULT NULL,
address VARCHAR (45) NULL DEFAULT NULL,
cardNumber VARCHAR (45) NULL DEFAULT NULL,
nip VARCHAR (45) NULL DEFAULT NULL,
sexe VARCHAR (1) NULL DEFAULT NULL,
active VARCHAR (1) NULL DEFAULT NULL,
idagencies INT NOT NULL,
idemployee INT NOT NULL,
--- REFERNCES
CONSTRAINT Relation_a_tagencies_2 FOREIGN KEY (idagencies) REFERENCES tagencies(idagencies),
CONSTRAINT Relation_a_temployee_2 FOREIGN KEY (idemployee) REFERENCES temployee(idemployee)
)

-- -----------------------------------------------------
-- 9.- Table `bd_NationalBank`.`taccount`
-- -----------------------------------------------------
CREATE TABLE taccount
(
idaccount INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
number VARCHAR (45) NULL DEFAULT NULL,
balance DECIMAL (22,6) NULL DEFAULT NULL,
openDate DATETIME NULL DEFAULT NULL,
idemployee INT NOT NULL,
idagencies INT NOT NULL,
)

-- -----------------------------------------------------
-- 10.- Table `bd_NationalBank`.`taccounttype`
-- -----------------------------------------------------
CREATE TABLE taccounttype
(
idaccounttype INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
accountType VARCHAR (45) NULL DEFAULT NULL,
comission DECIMAL(22,6) NULL DEFAULT NULL,
overdraft DECIMAL (22,6) NULL DEFAULT NULL,
interestRate DECIMAL (22,6) NULL DEFAULT NULL,
)

-- -----------------------------------------------------
-- 11.- Table `bd_NationalBank`.`tclient_account`
-- -----------------------------------------------------
CREATE TABLE tclient_account
(
idaccounttype INT NOT NULL,
idclient INT NOT NULL,
idaccount INT NOT NULL,
PRIMARY KEY (idaccounttype,idclient),
--- REFERNCES
CONSTRAINT Relation_a_taccount_2 FOREIGN KEY (idaccount) REFERENCES taccount(idaccount),
CONSTRAINT Relation_a_taccounttype  FOREIGN KEY (idaccounttype) REFERENCES taccounttype(idaccounttype),
CONSTRAINT Relation_a_tclient FOREIGN KEY (idclient) REFERENCES tclient(idclient)
)

-- -----------------------------------------------------
-- 12.- Table `bd_NationalBank`.`tadmin`
-- -----------------------------------------------------
CREATE TABLE tadmin
(
idadmin INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
adminNumber VARCHAR (45) NULL DEFAULT NULL,
name VARCHAR(45) NULL DEFAULT NULL,
lastName VARCHAR(45) NULL DEFAULT NULL,
email VARCHAR(45) NULL DEFAULT NULL,
img VARCHAR(45) NULL DEFAULT NULL,
password VARCHAR(45) NULL DEFAULT NULL,
sexe VARCHAR (1) NULL DEFAULT NULL,
active VARCHAR (1) NULL DEFAULT NULL,
)

-- -----------------------------------------------------
-- 13.- Table `bd_NationalBank`.`ttransaction`
-- -----------------------------------------------------

CREATE TABLE ttransaction
(
idtransaction INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
balance DECIMAL(22,6) NULL DEFAULT NULL,
transactionDate DATETIME NULL DEFAULT NULL,
comission DECIMAL (22,6) NULL DEFAULT NULL,
overdraft DECIMAL (22,6) NULL DEFAULT NULL,
interestRate DECIMAL (22,6) NULL DEFAULT NULL,
idaccount INT NOT NULL,
idclient INT NOT NULL,
idemployee INT NOT NULL,
idagencies INT NOT NULL,
--- REFERNCES
CONSTRAINT Relation_a_taccount FOREIGN KEY (idaccount) REFERENCES taccount(idaccount)
)