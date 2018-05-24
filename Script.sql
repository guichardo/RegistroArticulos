CREATE DATABASE ArticulosDb
GO
USE ArticulosDb
GO

CREATE TABLE Articulos
(
	ID int primary key identity(1, 1),
	FechaVencimiento datetime,
	Descripcion varchar(max),
	precio int,
	Existencia varchar(max),
	CantidadCotizada int	

);
