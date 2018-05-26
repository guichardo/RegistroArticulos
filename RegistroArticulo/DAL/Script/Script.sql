CREATE DATABASE ArticulosDb
GO
USE ArticulosDb
GO

CREATE TABLE Articulos
(
	ArticuloID int primary key identity(1, 1),
	FechaVencimiento datetime,
	Descripcion varchar(max),
	precio varchar(max),
	CantidadCotizada int	

);

