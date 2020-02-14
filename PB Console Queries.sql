/***Selecting UserID by day***/
SELECT UserID, TransactionTime 
FROM [ Biometrics].[dbo].[NGAC_SYSLOG] 
WHERE CAST(TransactionTime AS DATE) = '2015-05-19'

/*** Transaction Details for a day***/
SELECT *
FROM [ Biometrics].[dbo].[NGAC_SYSLOG] 
WHERE CAST(TransactionTime AS DATE) = '2015-05-19'

/***Transaction Header***/
SELECT DISTINCT CAST(TransactionTime AS DATE) AS Clock 
FROM [ Biometrics].[dbo].[NGAC_SYSLOG]
ORDER BY Clock ASC

/****Clock in and Clock out by ID***/
SELECT UserID, Min(TransactionTime) AS 'ClockIn', Max(TransactionTime) AS 'ClockOut'  
FROM [ Biometrics].[dbo].[NGAC_SYSLOG] 
WHERE (CAST(TransactionTime AS DATE) = '2015-05-19') AND UserID = '0001'
GROUP BY UserID



