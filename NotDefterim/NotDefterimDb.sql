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
( N'Al��veri� Listesi','Ya�,Yumurta,su'),
( N'�� Notlar�m','SSMS �rnekler'),
( N'G�zel S�zler','G�zel G�ren G�zel D���n�r'),
(N'Fatura Listesi','elektrik,su,do�algaz');