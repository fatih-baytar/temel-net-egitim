USE Okul

--SELECT Id as No FROM  Ogrenci
--SELECT * FROM Ogrenci
--WHERE Age>35 AND Lastname = 'BAYTAR'

--SELECT * FROM Ogrenci 
--WHERE Lastname LIKE '%TA%'
SELECT * FROM Ogrenci
--INSERT INTO Ogrenci (Firstname,Lastname,Age) VALUES ('Ahmet','Arık',36)

UPDATE Ogrenci SET Lastname = 'ARIK' 
WHERE Id=6

DELETE FROM Ogrenci 
WHERE Id=6



SELECT * From Ogrenci WHERE SinifId IN (SELECT Id FROM Sinif WHERE SinifAd = 'B')

SELECT Id FROM Sinif WHERE SinifAd = 'B'

SELECT O.*,S.SinifAd,S.Kapasite, S.AktifMi From Ogrenci as O
INNER JOIN Sinif as S 
ON O.SinifId = S.Id
WHERE S.SinifAd = 'B'