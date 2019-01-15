-- =============================================
-- Author:		Ricardo Mendoza
-- Create date: 3-12-2018
-- Description:	View clients et agencies from bd_NationalBank
-- 15.- selectClients
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