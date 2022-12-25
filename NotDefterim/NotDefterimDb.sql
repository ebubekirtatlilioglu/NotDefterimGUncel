use master
go

create database NotDefterimDb
go

use NotDefterimDb
go

CREATE TABLE Notlar
(
	Id INT PRIMARY KEY identity,
	Baslik NVARCHAR(100) NOT NULL,
	Icerik NVARCHAR(400) NOT NULL
);
GO

INSERT INTO Notlar VALUES 
( N'Alýþveriþ Listesi','Yað,Yumurta,su'),
( N'Ýþ Notlarým','SSMS Örnekler'),
( N'Güzel Sözler','Güzel Gören Güzel Düþünür'),
(N'Fatura Listesi','elektrik,su,doðalgaz');