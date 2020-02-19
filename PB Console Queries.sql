﻿/***Selecting UserID by day***/
SELECT UserID, TransactionTime 
FROM NGAC_SYSLOG
WHERE CAST(TransactionTime AS DATE) = ''

/*** Transaction Details for a day***/
SELECT *
FROM NGAC_SYSLOG
WHERE CAST(TransactionTime AS DATE) = ''

/***Transaction Header***/
SELECT DISTINCT CAST(TransactionTime AS DATE) AS Clock 
FROM NGAC_SYSLOG
ORDER BY Clock ASC

/****Clock in and Clock out by ID***/
SELECT UserID, Min(TransactionTime) AS 'ClockIn', Max(TransactionTime) AS 'ClockOut'  
FROM NGAC_SYSLOG
WHERE (CAST(TransactionTime AS DATE) = '') AND UserID = '
GROUP BY UserID



