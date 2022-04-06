USE ComplexFoodDB;

-- 1
SELECT * 
FROM Buyers
WHERE Sex = 'F'
ORDER BY LastName;

-- 2
SELECT COUNT(*) AS TOTAL_BUYERS_CONFIRMED
FROM Buyers
GROUP BY Confirmed
HAVING Confirmed = 1;


-- 3
SELECT AVG(Balance) AS AVERAGE_BALANCE
FROM Buyers
WHERE Balance > 0;


--4
SELECT B.Email, COUNT(*) AS COUPONS
FROM Buyers AS B
INNER JOIN Coupons AS C
ON B.ID = C.BuyerID
GROUP BY B.Email;

--5
SELECT * 
FROM Coupons
WHERE Type = 'Ten';

--6
SELECT * 
FROM Buyers
WHERE Sex = 'M' AND Balance > 400;

--7
SELECT B.Email, COUNT(*) AS COUPOUNS
FROM Buyers AS B
INNER JOIN Coupons AS C
ON B.ID = C.BuyerID
WHERE B.FirstName LIKE 'S%'
GROUP BY B.Email;

--8
SELECT *
FROM Buyers
WHERE Sex = 'F' AND Firstname LIKE 'A%';

--9
SELECT COUNT(*) AS TWENTY_COUPONS
FROM Coupons
GROUP BY Type
HAVING Type = 'Twenty';

--10
SELECT MAX(Balance) AS MAX_BALANCE
FROM Buyers;

