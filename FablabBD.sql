CREATE DATABASE FablabBD
GO
USE FablabBD
GO

CREATE TABLE Usuarios
(
	Id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	Usuario NVARCHAR(10) NOT NULL,
	[Password] NVARCHAR(MAX) NOT NULL
);
CREATE TABLE Proveedores
(
    Id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
    Nombres NVARCHAR(50) NOT NULL,
	Apellidos NVARCHAR(50) NOT NULL,
    Direccion NVARCHAR(200) NOT NULL,
    NumTelefono NVARCHAR(9) NOT NULL,
	CorreoElectronico NVARCHAR(100) NOT NULL
);

CREATE TABLE TipoMaterial
(
	Id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	NombreTipo NVARCHAR(50) NOT NULL,
	Descripcion NVARCHAR(250) NOT NULL
);

CREATE TABLE Materiales
(
    Id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
    NombreMaterial NVARCHAR(20) NOT NULL,
	X NVARCHAR(20) NOT NULL,
	Y NVARCHAR(20) NOT NULL,
	Z NVARCHAR(20) NOT NULL,
	IdTipoMaterial INT NOT NULL FOREIGN KEY REFERENCES TipoMaterial(Id) ON DELETE CASCADE ON UPDATE CASCADE,
	Precio MONEY NOT NULL
);

CREATE TABLE CompraMateriales
(
    Id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
    IdMaterial INT NOT NULL FOREIGN KEY REFERENCES Materiales(Id) ON DELETE CASCADE ON UPDATE CASCADE,
    IdProveedor INT NOT NULL FOREIGN KEY REFERENCES Proveedores(Id) ON DELETE CASCADE ON UPDATE CASCADE,
    CantidadCompra NVARCHAR(20) NOT NULL,
    TotalPagar MONEY NOT NULL
);
CREATE TABLE Duraciones
(
	Id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	TiempoDiseno NVARCHAR(10) NOT NULL,
    TiempoFabricado NVARCHAR(10) NOT NULL,
    TiempoArmado NVARCHAR(10) NOT NULL
);
CREATE TABLE Estados
(
	Id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	NombreEstado NVARCHAR (50) NOT NULL,
	Detalle NVARCHAR (250) NOT NULL
);
CREATE TABLE Maquinarias
(
	Id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	Nombre NVARCHAR (50) NOT NULL,
	Marca NVARCHAR (50) NOT NULL,
	Detalle NVARCHAR (250) NOT NULL,
	IdEstado INT NOT NULL FOREIGN KEY REFERENCES Estados(Id) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE Categorias
(
	Id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	Nombre VARCHAR (50) NOT NULL
);

CREATE TABLE Prototipos
(
    Id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
    NombrePrototipo NVARCHAR(50) NOT NULL,
	IdCategoria INT NOT NULL FOREIGN KEY REFERENCES Categorias(Id) ON DELETE CASCADE ON UPDATE CASCADE,
    IdMaterial INT NOT NULL FOREIGN KEY REFERENCES Materiales(Id) ON DELETE CASCADE ON UPDATE CASCADE,
    X NVARCHAR(10) NOT NULL,
	Y NVARCHAR(10) NOT NULL,
	Z NVARCHAR(10) NOT NULL,
    Descripcion VARCHAR(MAX) NOT NULL,
    Imagen IMAGE NOT NULL,
	IdDuracion INT NOT NULL FOREIGN KEY REFERENCES Duraciones(Id) ON DELETE CASCADE ON UPDATE CASCADE,
	IdEstado INT NOT NULL FOREIGN KEY REFERENCES Estados(Id) ON DELETE CASCADE ON UPDATE CASCADE,
	IdMaquinaria INT NOT NULL FOREIGN KEY REFERENCES Maquinarias(Id) 
);

CREATE TABLE Autores
(
	Id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	Nombres NVARCHAR(20) NOT NULL,
	Apellidos NVARCHAR(20) NOT NULL,
	CorreElectronico NVARCHAR(100) NOT NULL,
	[Password] NVARCHAR(MAX) NOT NULL,
	FechaRegistro DATE NOT NULL
);
CREATE TABLE CreacionPrototipos
(
	Id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	IdAutorLider INT NOT NULL FOREIGN KEY REFERENCES Autores(Id) ON DELETE CASCADE ON UPDATE CASCADE,
	IdPrototipo INT NOT NULL FOREIGN KEY REFERENCES Prototipos(Id) ON DELETE CASCADE ON UPDATE CASCADE,
	IdUsuario INT NOT NULL FOREIGN KEY REFERENCES Usuarios(Id) ON UPDATE CASCADE,
	FechaCreacion DATE NOT NULL,
	NumeroAutoresEquipo INT NOT NULL,
	Nombres NVARCHAR(200) NULL
);
CREATE TABLE Clubs
(
	Id INT PRIMARY KEY NOT NULL IDENTITY (1,1),
	NombreClub  NVARCHAR (50) NOT NULL,
	Detalle NVARCHAR (250) NOT NULL 
);
CREATE TABLE InscripcionClubs
(
	Id INT PRIMARY KEY NOT NULL IDENTITY (1,1),
	IdAutor INT NOT NULL FOREIGN KEY REFERENCES Autores(Id) ON DELETE CASCADE ON UPDATE CASCADE,
	IdClub INT NOT NULL FOREIGN KEY REFERENCES Clubs(Id) ON DELETE CASCADE ON UPDATE CASCADE,
	FechaInscripcion DATE NOT NULL,
	Detalle NVARCHAR (250) NOT NULL

);
CREATE TABLE SolicitudProyectos
(
	Id INT PRIMARY KEY NOT NULL IDENTITY (1,1),
	TipoProyecto NVARCHAR(50) NOT NULL,
	Descripcion NVARCHAR(MAX) NOT NULL,
	Integrantes NVARCHAR(20) NOT NULL,
	Fecha DATE NOT NULL,
	Estado NVARCHAR(50) NOT NULL,
	IdAutor INT NOT NULL FOREIGN KEY REFERENCES Autores(Id) 
);
GO

--Procesos para mostrar todo de cada entidad

CREATE PROCEDURE SPObtenerTodoPrototipos
AS
Begin
SELECT *
FROM Prototipos
END
GO

CREATE PROCEDURE SPObtenerTodoMateriales
AS
BEGIN
SELECT *
FROM Materiales 
END
GO

CREATE PROCEDURE SPOtenerTodoProveedores
AS
BEGIN
SELECT *
FROM Proveedores 
END
GO

CREATE PROCEDURE SPObtenerTodoUsuarios
AS
BEGIN
SELECT *
FROM Usuarios 
END
GO

--Procesos para eliminar un registro de la entidad basado en su Id
CREATE PROCEDURE SPEliminarPrototipo
@Id INT
AS
BEGIN
DELETE FROM Prototipos
WHERE Id = @Id
END
GO

CREATE PROCEDURE SPEliminarMaterial
@Id INT
AS
BEGIN
DELETE FROM Materiales
WHERE Id = @Id
END
GO

CREATE PROCEDURE SPEliminarProveedores
@Id INT
AS
BEGIN
DELETE FROM Proveedores
WHERE Id = @Id
END
GO

CREATE PROCEDURE SPEliminarUsuarios
@Id INT
AS
BEGIN
DELETE FROM Usuarios
WHERE Id = @Id
END
GO

--Procesos para agregar nuevos registros a cada tabla
CREATE PROCEDURE spAgregarPrototipo
@NombrePrototipo NVARCHAR(30),
@IdCategoria INT,
@IdMaterial INT,
@X NVARCHAR(10),
@Y NVARCHAR(10),
@Z NVARCHAR(10),
@Descripcion VARCHAR(MAX),
@Imagen Image,
@IdDuracion INT,
@IdEstado INT,
@IdMaquinaria INT
AS
BEGIN
INSERT INTO Prototipos
VALUES(@NombrePrototipo, @IdCategoria, @IdMaterial, @X, @Y, @Z, @Descripcion, @Imagen, @IdDuracion, @IdEstado, @IdMaquinaria )
END
GO

CREATE PROCEDURE spAgregarMaterial
@NombreMaterial NVARCHAR(20),
@X NVARCHAR(20),
@Y NVARCHAR(20),
@Z NVARCHAR(20),
@IdTipoMaterial INT,
@Precio MONEY
AS
BEGIN
INSERT INTO Materiales
VALUES (@NombreMaterial, @X, @Y, @Z, @IdTipoMaterial, @Precio)
END
GO

CREATE PROCEDURE SPAgregarProveedor
@Nombres NVARCHAR(50),
@Apellidos NVARCHAR(50),
@Direccion NVARCHAR(100),
@NumTelefono NVARCHAR(9),
@CorreoElectronico NVARCHAR(200)
AS
BEGIN
INSERT INTO Proveedores
VALUES (@Nombres, @Apellidos, @Direccion, @NumTelefono, @CorreoElectronico)
END
GO

CREATE PROCEDURE SPAgregarUsuarios
@Usuario NVARCHAR(10),
@Pasword NVARCHAR(MAX)
AS
BEGIN
INSERT INTO Usuarios
VALUES (@Usuario, @Pasword)
END
GO

--Metodos para Actualizar un registro de las tablas basado en su Id
CREATE PROCEDURE spActualizarPrototipo
@NombrePrototipo NVARCHAR(30),
@IdCategoria INT, 
@IdMaterial INT,
@X NVARCHAR(10),
@Y NVARCHAR(10),
@Z NVARCHAR(10),
@Descripcion VARCHAR(MAX),
@IdDuracion INT,
@IdEstado INT,
@IdMaquinaria INT,
@Id INT
AS
BEGIN
UPDATE Prototipos
SET NombrePrototipo = @NombrePrototipo, IdCategoria = @IdCategoria, IdMaterial = @IdMaterial, X = @X, Y = @Y, Z = @Z,
Descripcion = @Descripcion, IdDuracion = @IdDuracion, IdEstado = @IdEstado, IdMaquinaria = @IdMaquinaria
WHERE Id = @Id
END
GO

CREATE PROCEDURE spActualizarMaterial
@NombreMaterial NVARCHAR(20),
@X NVARCHAR(20),
@Y NVARCHAR(20),
@Z NVARCHAR(20),
@IdTipoMaterial INT,
@Precio MONEY,
@Id INT
AS
BEGIN
UPDATE Materiales
SET NombreMaterial = @NombreMaterial, X = @X, Y = @Y, Z = @Z, IdTipoMaterial = @IdTipoMaterial,
Precio = @Precio
WHERE Id = @Id
END
GO

CREATE PROCEDURE SPActualizarProveedor
@Nombre NVARCHAR(50),
@Apellidos NVARCHAR(50),
@Direccion NVARCHAR(100),
@NumTelefono NVARCHAR(9),
@CorreoElectronico NVARCHAR(200),
@Id INT
AS
BEGIN
UPDATE Proveedores
SET Nombres = @Nombre, Apellidos = @Apellidos, Direccion = @Direccion, NumTelefono = @NumTelefono, CorreoElectronico = @CorreoElectronico
WHERE Id = @Id
END
GO

CREATE PROCEDURE SPActualizarUsuarios
@Usuario NVARCHAR(10),
@Pasword NVARCHAR(MAX),
@Id INT
AS
BEGIN
UPDATE Usuarios
SET Usuario = @Usuario, [Password] = @Pasword
WHERE Id = @Id
END
GO

CREATE PROCEDURE SPMostrarEstadosPrototipos
AS
BEGIN
SELECT * FROM Estados
WHERE Id in (1,2)
End
GO

CREATE PROCEDURE SPMostrarMAquinaria
AS
BEGIN
SELECT * 
FROM Maquinarias
END
GO

CREATE PROCEDURE SPGuardarDuracion
@TiempoDiseno NVARCHAR(10),
@TiempoFabricado NVARCHAR(10),
@TiempoArmado NVARCHAR(10)
AS
BEGIN
INSERT INTO Duraciones
VALUES (@TiempoDiseno, @TiempoFabricado, @TiempoArmado)
END
GO

CREATE PROCEDURE SPObtenerUltimoId
AS
BEGIN
SELECT TOP 1 ID
FROM duraciones
ORDER BY ID DESC
END
GO

CREATE PROCEDURE SPMostrarProto
AS
BEGIN
Select Prototipos.NombrePrototipo, Materiales.NombreMaterial, Maquinarias.Nombre, Estados.NombreEstado
From Prototipos
Inner Join Materiales on Prototipos.IdMaterial = Materiales.Id
Inner Join Maquinarias on Prototipos.IdMaquinaria = Maquinarias.Id
Inner Join Estados on Prototipos.IdEstado = Estados.Id
END
GO

CREATE PROCEDURE SPRegresarTipoMaterial
AS
BEGIN
select * 
from TipoMaterial
END
GO

CREATE PROCEDURE SPMostrarPorIdDuraciones
@Id int
AS
Begin
select * from Duraciones
where Id = @Id
END
GO

CREATE PROCEDURE SPMostrarPorIdMateriales
@Id int
AS
BEGIN
Select *
From Materiales
Where Id = @Id
END
GO

CREATE PROCEDURE SPMostrarPorIdEstados
@Id int
AS
BEGIN
Select *
From Estados
Where Id = @Id
END
GO

CREATE PROCEDURE SPMostrarPorIdMaquinaria
@Id int
AS
BEGIN
Select *
From Maquinarias
Where Id = @Id
END
GO

CREATE PROCEDURE SPActualizarDuraciones
@Disenado NVARCHAR(10),
@Fabricado NVARCHAR(10),
@Armado NVARCHAR(10),
@Id int
AS
BEGIN 
Update Duraciones
Set TiempoDiseno = @Disenado, TiempoFabricado = @Fabricado, TiempoArmado = @Armado
Where Id = @Id
END
GO

CREATE PROCEDURE SPLogin
@Usuario NVARCHAR(10),
@Contra NVARCHAR(MAX)
AS
BEGIN
Select * from Usuarios
Where Usuario = @Usuario and [Password] = @Contra
END
GO

CREATE PROCEDURE SPMostrarInfo
@NombrePrototipo NVARCHAR(30)
AS
BEGIN
SELECT Prototipos.NombrePrototipo, Materiales.NombreMaterial, Prototipos.X,
Prototipos.Y, Prototipos.Z, Prototipos.Descripcion, Duraciones.TiempoArmado, Duraciones.TiempoDiseno,
Duraciones.TiempoFabricado, Estados.NombreEstado, Maquinarias.Nombre, Prototipos.Imagen, Categorias.Nombre
from Prototipos
Inner Join Categorias on Prototipos.IdCategoria = Categorias.Id
Inner Join Materiales on Prototipos.IdMaterial = Materiales.Id
Inner Join Maquinarias on Prototipos.IdMaquinaria = Maquinarias.Id
Inner Join Estados on Prototipos.IdEstado = Estados.Id
Inner Join duraciones on Prototipos.IdDuracion = Duraciones.Id
Where NombrePrototipo = @NombrePrototipo
END
GO


CREATE PROCEDURE SPMostrarTipoId
@Id int
AS
BEGIN
Select * from TipoMaterial
where Id = @Id
END
GO


CREATE PROCEDURE SPAggMaquinaria
@Nombre NVARCHAR (50),
@Marca NVARCHAR (50),
@Detalle NVARCHAR (250),
@IdEstado INT
AS
BEGIN
INSERT INTO Maquinarias
VALUES (@Nombre, @Marca, @Detalle, @IdEstado)
END
GO

CREATE PROCEDURE SPListaEstados
AS
BEGIN
SELECT * FROM Estados
WHERE Id in (3,4,5,6)
END
GO

CREATE PROCEDURE SPActuMaquinaria
@Id Int,
@Nombre NVARCHAR (50),
@Marca NVARCHAR (50),
@Detalle NVARCHAR (250),
@IdEstado INT
AS
BEGIN
UPDATE Maquinarias
SET Nombre = @Nombre, Marca = @Marca, Detalle = @Detalle, IdEstado = @IdEstado
WHERE Id = @Id
END
GO

CREATE PROCEDURE SPEliminarMaquinaria 
@Id Int
AS
BEGIN
DELETE FROM Maquinarias
WHERE Id = @Id
END
GO

CREATE PROCEDURE SPListaProveedor
AS
BEGIN
SELECT * FROM Proveedores
END
GO

CREATE PROCEDURE SPAggProveedor
@Nombres NVARCHAR(50),
@Apellidos NVARCHAR(50),
@Direccion NVARCHAR(200),
@NumTelefono NVARCHAR(9),
@CorreoElectronico NVARCHAR(100)
AS
BEGIN
INSERT INTO Proveedores
VALUES (@Nombres, @Apellidos, @Direccion, @NumTelefono, @CorreoElectronico)
END
GO

CREATE PROCEDURE SPActuProveedores
@Id Int,
@Nombres NVARCHAR(50),
@Apellidos NVARCHAR(50),
@Direccion NVARCHAR(200),
@NumTelefono NVARCHAR(9),
@CorreoElectronico NVARCHAR(100)
AS
BEGIN
UPDATE Proveedores 
SET Nombres = @Nombres, Apellidos = @Apellidos, Direccion = @Direccion, NumTelefono = @NumTelefono, CorreoElectronico = @CorreoElectronico
WHERE Id = @Id
END 
GO

CREATE PROCEDURE SPEliminarProveedor 
@Id Int
AS
BEGIN
DELETE FROM Proveedores
WHERE Id = @Id
END
GO

CREATE PROCEDURE SPListaAutores
AS
BEGIN
SELECT * FROM Autores
END
GO

CREATE PROCEDURE SPAggAutor
@Nombres NVARCHAR(20),
@Apellidos NVARCHAR(20),
@CorreElectronico NVARCHAR(100),
@Contrasena NVARCHAR(MAX),
@FechaRegistro DATE
AS
BEGIN
INSERT INTO Autores
VALUES (@Nombres, @Apellidos, @CorreElectronico, @Contrasena, @FechaRegistro)
END
GO

CREATE PROCEDURE SPModiAutor
@Nombre NVARCHAR(20),
@Apellidos NVARCHAR(20),
@CorreElectronico NVARCHAR(100),
@Contrasena NVARCHAR(MAX),
@FechaRegistro DATE,
@Id INT
AS
BEGIN
UPDATE Autores
SET Nombres = @Nombre, Apellidos = @Apellidos, CorreElectronico = @CorreElectronico, [Password] = @Contrasena,
FechaRegistro = @FechaRegistro 
WHERE Id = @Id
END
GO

CREATE PROCEDURE SPEliminarAutor
@Id Int
AS
BEGIN
DELETE FROM Autores
WHERE Id = @Id
END
GO

CREATE PROCEDURE SPAddClubs
@NombreClub  NVARCHAR (50),
@Detalle NVARCHAR (250)
AS 
BEGIN
INSERT INTO Clubs
VALUES (@NombreClub, @Detalle)
END 
GO

CREATE PROCEDURE SPListaClubs
AS
BEGIN
SELECT * FROM Clubs
END
GO

CREATE PROCEDURE SPAddInscripcion
@IdAutor INT,
@IdClub INT,
@FechaInscripcion DATE,
@Detalle NVARCHAR (250)
AS
BEGIN
INSERT INTO InscripcionClubs
VALUES (@IdAutor, @IdClub, @FechaInscripcion, @Detalle)
END
GO

CREATE PROCEDURE SPListaInscripcion
AS 
BEGIN
SELECT * FROM InscripcionClubs
END
GO

CREATE PROCEDURE SPModiInscripcion
@Id INT,
@IdAutor INT,
@IdClub INT,
@FechaInscripcion DATE,
@Detalle NVARCHAR (250)
AS
BEGIN
UPDATE InscripcionClubs
SET IdAutor = @IdAutor, IdClub = @IdClub, FechaInscripcion = @FechaInscripcion, Detalle = @Detalle
WHERE Id = @Id
END
GO

CREATE PROCEDURE SPDeleteInscripcion
@Id INT
AS
BEGIN
DELETE FROM InscripcionClubs
WHERE Id = @Id
END
GO

CREATE PROCEDURE SPAddCreacion
@IdAutorLider INT,
@IdPrototipo INT,
@IdUsuario INT,
@FechaCreacion DATE,
@NumeroAutoresEquipo INT,
@Nombres NVARCHAR(200)
AS 
BEGIN
INSERT INTO CreacionPrototipos
VALUES (@IdAutorLider, @IdPrototipo, @IdUsuario, @FechaCreacion, @NumeroAutoresEquipo, @Nombres)
END
GO

CREATE PROCEDURE SPUltimoProto
AS
BEGIN
SELECT TOP 1 ID
FROM Prototipos
ORDER BY ID DESC
END
GO

CREATE PROCEDURE SPAddCompra
@IdMaterial INT,
@IdProveedor INT,
@CantidadCompra NVARCHAR(20),
@TotalPagar MONEY
AS
BEGIN 
INSERT INTO CompraMateriales
VALUES (@IdMaterial, @IdProveedor, @CantidadCompra, @TotalPagar)
END
GO

CREATE PROCEDURE SPModiCompra
@Id INT,
@IdMaterial INT,
@IdProveedor INT,
@CantidadCompra NVARCHAR(20),
@TotalPagar MONEY
AS
BEGIN 
UPDATE CompraMateriales
SET IdMaterial = @IdMaterial, IdProveedor = @IdProveedor, CantidadCompra = @CantidadCompra, TotalPagar = @TotalPagar
WHERE Id = @Id
END
GO

CREATE PROCEDURE SPDeleteCompra
@Id int
AS
BEGIN 
DELETE FROM CompraMateriales
WHERE Id = @Id
END
GO

CREATE PROCEDURE SPListaCompra
AS 
BEGIN
SELECT * FROM CompraMateriales
END
GO

CREATE PROCEDURE SPReporte
AS
BEGIN
SELECT A.Nombres + ' ' + A.Apellidos AS Autor,
COUNT(CP.IdPrototipo) AS CantidadPrototipos
FROM  Autores A
INNER JOIN CreacionPrototipos CP ON A.Id = CP.IdAutorLider
GROUP BY A.Nombres, A.Apellidos
ORDER BY CantidadPrototipos DESC;
END
GO

CREATE PROCEDURE SPMostrarInfoCat1
AS
BEGIN
SELECT Prototipos.Id, Prototipos.NombrePrototipo, Materiales.NombreMaterial, Prototipos.X,
Prototipos.Y, Prototipos.Z, Prototipos.Descripcion, Duraciones.TiempoArmado, Duraciones.TiempoDiseno,
Duraciones.TiempoFabricado, Estados.NombreEstado, Maquinarias.Nombre, Prototipos.Imagen, Categorias.Nombre
from Prototipos
Inner Join Categorias on Prototipos.IdCategoria = Categorias.Id
Inner Join Materiales on Prototipos.IdMaterial = Materiales.Id
Inner Join Maquinarias on Prototipos.IdMaquinaria = Maquinarias.Id
Inner Join Estados on Prototipos.IdEstado = Estados.Id
Inner Join duraciones on Prototipos.IdDuracion = Duraciones.Id
WHERE Prototipos.IdCategoria = 1
END
GO

CREATE PROCEDURE SPMostrarInfoCat2
AS
BEGIN
SELECT Prototipos.Id, Prototipos.NombrePrototipo, Materiales.NombreMaterial, Prototipos.X,
Prototipos.Y, Prototipos.Z, Prototipos.Descripcion, Duraciones.TiempoArmado, Duraciones.TiempoDiseno,
Duraciones.TiempoFabricado, Estados.NombreEstado, Maquinarias.Nombre, Prototipos.Imagen, Categorias.Nombre
from Prototipos
Inner Join Categorias on Prototipos.IdCategoria = Categorias.Id
Inner Join Materiales on Prototipos.IdMaterial = Materiales.Id
Inner Join Maquinarias on Prototipos.IdMaquinaria = Maquinarias.Id
Inner Join Estados on Prototipos.IdEstado = Estados.Id
Inner Join duraciones on Prototipos.IdDuracion = Duraciones.Id
WHERE Prototipos.IdCategoria = 2
END
GO

CREATE PROCEDURE SPMostrarInfoCat3
AS
BEGIN
SELECT Prototipos.Id, Prototipos.NombrePrototipo, Materiales.NombreMaterial, Prototipos.X,
Prototipos.Y, Prototipos.Z, Prototipos.Descripcion, Duraciones.TiempoArmado, Duraciones.TiempoDiseno,
Duraciones.TiempoFabricado, Estados.NombreEstado, Maquinarias.Nombre, Prototipos.Imagen, Categorias.Nombre
from Prototipos
Inner Join Categorias on Prototipos.IdCategoria = Categorias.Id
Inner Join Materiales on Prototipos.IdMaterial = Materiales.Id
Inner Join Maquinarias on Prototipos.IdMaquinaria = Maquinarias.Id
Inner Join Estados on Prototipos.IdEstado = Estados.Id
Inner Join duraciones on Prototipos.IdDuracion = Duraciones.Id
WHERE Prototipos.IdCategoria = 3
END
GO

ALTER PROCEDURE spAggSoliProyecto
@TipoProyecto NVARCHAR(50),
@Descripcion NVARCHAR(MAX),
@Integrantes NVARCHAR(20),
@Fecha DATE,
@Aprovado NVARCHAR(50),
@IdAutor INT
AS
BEGIN
INSERT INTO SolicitudProyectos Values
(@TipoProyecto, @Descripcion, @Integrantes,CAST(@Fecha as date), @Aprovado, @IdAutor)
END
GO

CREATE PROCEDURE spModiSoliProyecto
@Id INT,
@TipoProyecto NVARCHAR(50),
@Descripcion NVARCHAR(MAX),
@Integrantes NVARCHAR(20)
AS
BEGIN
UPDATE SolicitudProyectos
SET TipoProyecto = @TipoProyecto, Descripcion = @Descripcion, Integrantes = @Integrantes
WHERE Id = @Id
END
GO

CREATE PROCEDURE spDelSoliProyecto
@Id INT
AS
BEGIN
DELETE FROM SolicitudProyectos 
WHERE Id = @Id
END
GO

CREATE PROCEDURE spShowSoliProyecto
AS
BEGIN
SELECT * FROM SolicitudProyectos
END
GO

CREATE PROCEDURE spShowCategorias
AS
BEGIN
SELECT * FROM Categorias
END
GO


CREATE PROCEDURE spNewAutor
@Nombres NVARCHAR(20),
@Apellidos NVARCHAR(20),
@CorreElectronico NVARCHAR(100),
@Contrasena NVARCHAR(MAX),
@FechaRegistro DATE,
@Registrado BIT OUTPUT,
@Mensaje VARCHAR(100) OUTPUT
AS
BEGIN
	IF(NOT EXISTS(SELECT * FROM Autores WHERE CorreElectronico = @CorreElectronico))
	BEGIN
		INSERT INTO Autores
		VALUES (@Nombres, @Apellidos, @CorreElectronico, @Contrasena, @FechaRegistro)
		SET @Registrado = 1
		SET @Mensaje = 'Autor Registrado'
	END
	ELSE
		BEGIN
		SET @Registrado = 0
		SET @Mensaje = 'Correo actualmente registrado'
	END
END
GO

CREATE PROCEDURE spValidacion
@CorreElectronico NVARCHAR(100),
@Contrasena NVARCHAR(MAX)
AS
BEGIN
	if(EXISTS (SELECT * FROM Autores WHERE CorreElectronico = @CorreElectronico 
	and [Password] = @Contrasena))
		SELECT * FROM Autores WHERE CorreElectronico = @CorreElectronico and [Password] = @Contrasena
	ELSE
		SELECT '0'
END
GO

CREATE PROCEDURE spMostrarInfoSoli
@Id INT
AS
BEGIN 
SELECT * FROM SolicitudProyectos 
WHERE Id = @Id
END
GO

CREATE PROCEDURE spModiSoliAprobacion
@Id INT,
@Aprovado NVARCHAR(50)
AS
BEGIN
UPDATE SolicitudProyectos
SET Estado = @Aprovado
WHERE Id = @Id
END
GO

--todo de aqui para arriba esta ejecutado en el servidor porfavor anotar 
--los cambios que no se han reflejado en la base de datos y poder ser no modificar tablas 

Alter PROCEDURE spShowInscrip
@IdAutor INT
AS
BEGIN
SELECT 
    i.IdAutor,
    c.Id,
    c.NombreClub AS NombreClub,
    c.Detalle,
    i.FechaInscripcion
FROM 
    InscripcionClubs i
JOIN 
    Clubs c ON i.IdClub = c.Id
WHERE 
    i.IdAutor = @IdAutor
END