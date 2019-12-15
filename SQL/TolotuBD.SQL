create database tolotuBD

use tolotuBD;

CREATE TABLE [estados] (
  [estadoId] tinyint PRIMARY KEY IDENTITY(1, 1),
  [estado] varchar(15)
)
GO

CREATE TABLE [Tipo_documento] (
  [Tipo_documentoId] tinyint PRIMARY KEY IDENTITY(1, 1),
  [tipo] char(30)
)
GO

CREATE TABLE [genero] (
  [generoId] tinyint PRIMARY KEY IDENTITY(1, 1),
  [genero] char(10)
)
GO

CREATE TABLE [roles] (
  [rolesId] tinyint PRIMARY KEY IDENTITY(1, 1),
  [rol] char(10)
)
GO

CREATE TABLE [usuario] (
  [documento] int PRIMARY KEY,
  [tipo_documento] tinyint,
  [usuario] varchar(20),
  [primer_nombre] varchar(20),
  [segundo_nombre] varchar(20),
  [primer_apellido] varchar(20),
  [segundo_apellido] varchar(20),
  [correo] varchar(60),
  [tel] varchar(20),
  [genero] tinyint,
  [fecha_nacimiento] datetime,
  [edad] tinyint,
  [estado] tinyint,
  [contrasenia] varchar(30),
  [rol] tinyint,
  [imagen] varchar(100)
)
GO

CREATE TABLE [baneados] (
  [baneoId] tinyint PRIMARY KEY IDENTITY(1, 1),
  [usuaID] int,
  [fecha_ban] date,
  [descripcion] varchar(150)
)
GO

CREATE TABLE [gustos] (
  [gustoId] tinyint PRIMARY KEY IDENTITY(1, 1),
  [nombre] varchar(25),
  [descripcion] varchar(225)
)
GO

CREATE TABLE [evento] (
  [eventoId] int PRIMARY KEY IDENTITY(1, 1),
  [nombre_evento] varchar(30),
  [descripcion_evento] varchar(255),
  [localicazion] nvarchar(255),
  [clasificacion] varchar(60),
  [imagen] varchar(255)
)
GO

CREATE TABLE [usugustos] (
  [usugustosId] tinyint PRIMARY KEY IDENTITY(1, 1),
  [gustoID] tinyint,
  [usuarioID] int
)
GO

CREATE TABLE [participantes] (
  [participantesId] int PRIMARY KEY IDENTITY(1, 1),
  [eventoID] int,
  [usuarioID] int
)
GO

CREATE TABLE [eveugusto] (
  [eveugustoId] tinyint PRIMARY KEY IDENTITY(1, 1),
  [eventoID] int,
  [gustoID] tinyint
)
GO

ALTER TABLE [usuario] ADD FOREIGN KEY ([tipo_documento]) REFERENCES [Tipo_documento] ([Tipo_documentoId])
GO
ALTER TABLE [usuario] ADD FOREIGN KEY ([genero]) REFERENCES [genero] ([generoId])
GO
ALTER TABLE [usuario] ADD FOREIGN KEY ([estado]) REFERENCES [estados] ([estadoId])
GO
ALTER TABLE [usuario] ADD FOREIGN KEY ([rol]) REFERENCES [roles] ([rolesId])
GO
ALTER TABLE [baneados] ADD FOREIGN KEY ([usuaID]) REFERENCES [usuario] ([documento])
GO
ALTER TABLE [usugustos] ADD FOREIGN KEY ([gustoID]) REFERENCES [gustos] ([gustoId])
GO
ALTER TABLE [usugustos] ADD FOREIGN KEY ([usuarioID]) REFERENCES [usuario] ([documento])
GO
ALTER TABLE [participantes] ADD FOREIGN KEY ([eventoID]) REFERENCES [evento] ([eventoId])
GO
ALTER TABLE [participantes] ADD FOREIGN KEY ([usuarioID]) REFERENCES [usuario] ([documento])
GO
ALTER TABLE [eveugusto] ADD FOREIGN KEY ([eventoID]) REFERENCES [evento] ([eventoId])
GO
ALTER TABLE [eveugusto] ADD FOREIGN KEY ([gustoID]) REFERENCES [gustos] ([gustoId])
GO

INSERT INTO [estados] ([estado]) VALUES
('Activo'),
('Inactivo'),
('Reportado'),
('Baneado');
GO

INSERT INTO [Tipo_documento] ([tipo]) VALUES
('Cedula de ciudadania'),
('Pasaporte'),
('Registro civil');
GO

INSERT INTO [genero] ([genero]) VALUES
('Hombre'),
('Mujer'),
('Otro');
GO

INSERT INTO [roles] ([rol]) VALUES
('Admin'),
('Usuario');
GO

CREATE PROCEDURE [Consulta]
@documento varchar(50),
@outputs varchar(50) output
AS    
BEGIN
  DECLARE @document_INT int = CONVERT(INT, @documento)
  SELECT * FROM [Tipo_documento] WHERE [Tipo_documentoId]=@document_INT
  SET @outputs = (SELECT [tipo] FROM [Tipo_documento] WHERE [Tipo_documentoId]=@document_INT)
END
GO


CREATE PROCEDURE [HayTipoDocumento]
@nombre_documento varchar(50),
@result tinyint output
AS    
BEGIN
  DECLARE @output varchar(50)
  SET @output = (SELECT [Tipo_documentoId] FROM [Tipo_documento] WHERE [tipo]=@nombre_documento)
  IF @output > 0
  BEGIN
    SET @result = (SELECT [Tipo_documentoId] FROM [Tipo_documento] WHERE [tipo]=@nombre_documento)
  END
  ELSE
  BEGIN
    SET @result = 0
  END
END
GO

CREATE PROCEDURE [HayGenero]
@nombre_genero varchar(50),
@result tinyint output
AS    
BEGIN
  DECLARE @output varchar(50)
  SET @output = (SELECT [generoID] FROM [genero] WHERE [genero]=@nombre_genero)
  IF @output > 0
  BEGIN
    SET @result = (SELECT [generoID] FROM [genero] WHERE [genero]=@nombre_genero)
  END
  ELSE
  BEGIN
    SET @result = 0
  END
END
GO

CREATE PROCEDURE [HayRol]
@nombre_rol varchar(50),
@result tinyint output
AS    
BEGIN
  DECLARE @output varchar(50)
  SET @output = (SELECT [rolesID] FROM [roles] WHERE [rol]=@nombre_rol)
  IF @output > 0
  BEGIN
    SET @result = (SELECT [rolesID] FROM [roles] WHERE [rol]=@nombre_rol)
  END
  ELSE
  BEGIN
    SET @result = 0
  END
END
GO

CREATE PROCEDURE [HayEstado]
@nombre_estado varchar(50),
@result tinyint output
AS    
BEGIN
  DECLARE @output varchar(50)
  SET @output = (SELECT [estadoID] FROM [estados] WHERE [estado]=@nombre_estado)
  IF @output > 0
  BEGIN
    SET @result = (SELECT [estadoID] FROM [estados] WHERE [estado]=@nombre_estado)
  END
  ELSE
  BEGIN
    SET @result = 0
  END
END
GO

CREATE PROCEDURE [HayUsuario]
@usuario varchar(50),
@result tinyint output
AS    
BEGIN
  DECLARE @output varchar(50)
  SET @output = (SELECT [documento] FROM [usuario] WHERE [usuario]=@usuario)
  IF @output > 0
  BEGIN
    SET @result = 1
  END
  ELSE
  BEGIN
    SET @result = 0
  END
END
GO

CREATE PROCEDURE [AgregarUsuario]
@Numero_Documento int,
@tipo_documento tinyint,
@usuario varchar(20),
@primer_nombre varchar(20),
@segundo_nombre varchar(20),
@primer_apellido varchar(20),
@segundo_apellido varchar(20),
@correo varchar (60),
@tel varchar(20),
@genero tinyint,
@fecha_nacimiento datetime,
@edad tinyint,
@estado tinyint,
@contrasenia varchar(30),
@rol tinyint,
@imagen varchar(100)
AS    
BEGIN
  INSERT INTO usuario VALUES (@Numero_Documento, @tipo_documento, @usuario, @primer_nombre, @segundo_nombre, @primer_apellido, @segundo_apellido, @correo, @tel, @genero, @fecha_nacimiento, @edad, @estado, @contrasenia, @rol, @imagen)
END
GO

CREATE PROCEDURE [IniciarSesion]
@usuario varchar(30),
@contrasenia varchar(30),
@result int out,
@Numero_Documento int out,
@tipo_documento varchar(60) out,
@primer_nombre varchar(20) out,
@segundo_nombre varchar(20) out,
@primer_apellido varchar(20) out,
@segundo_apellido varchar(20) out,
@correo varchar(60) out,
@tel varchar(20) out,
@genero varchar(60) out,
@fecha_nacimiento datetime out,
@edad tinyint out,
@estado varchar(60) out,
@rol varchar(60) out,
@imagen varchar(100) out
AS    
BEGIN
  DECLARE @output varchar(50)
  SET @output = (SELECT [documento] FROM [usuario] WHERE [usuario]=@usuario AND [contrasenia]=@contrasenia)
  IF @output > 0
  BEGIN
    SET @result = 1
    SET @Numero_Documento = (SELECT [documento] FROM [usuario] WHERE [usuario]=@usuario AND [contrasenia]=@contrasenia)
	SET @tipo_documento = (SELECT tipo.[tipo] FROM [usuario] usu JOIN [Tipo_documento] tipo ON tipo.[Tipo_documentoId] = usu.[tipo_documento] WHERE [usuario]=@usuario AND [contrasenia]=@contrasenia)
    SET @primer_nombre = (SELECT [primer_nombre] FROM [usuario] WHERE [usuario]=@usuario AND [contrasenia]=@contrasenia)
	SET @segundo_nombre = (SELECT [segundo_nombre] FROM [usuario] WHERE [usuario]=@usuario AND [contrasenia]=@contrasenia)
    SET @primer_apellido = (SELECT [primer_apellido] FROM [usuario] WHERE [usuario]=@usuario AND [contrasenia]=@contrasenia)
    SET @segundo_apellido = (SELECT [segundo_apellido] FROM [usuario] WHERE [usuario]=@usuario AND [contrasenia]=@contrasenia)
    SET @correo = (SELECT [correo] FROM [usuario] WHERE [usuario]=@usuario AND [contrasenia]=@contrasenia)
    SET @tel = (SELECT [tel] FROM [usuario] WHERE [usuario]=@usuario AND [contrasenia]=@contrasenia)
    SET @genero = (SELECT genero.[genero] FROM [usuario] usu JOIN [genero] genero ON genero.[generoId] = usu.[genero] WHERE [usuario]=@usuario AND [contrasenia]=@contrasenia)
    SET @fecha_nacimiento = (SELECT [fecha_nacimiento] FROM [usuario] WHERE [usuario]=@usuario AND [contrasenia]=@contrasenia)
    SET @edad = (SELECT [edad] FROM [usuario] WHERE [usuario]=@usuario AND [contrasenia]=@contrasenia)
    SET @estado = (SELECT estado.[estado] FROM [usuario] usu JOIN [estados] estado ON estado.[estadoId] = usu.[estado] WHERE [usuario]=@usuario AND [contrasenia]=@contrasenia)
    SET @rol = (SELECT rol.rol FROM [usuario] usu JOIN [roles] rol ON rol.[rolesId] = usu.[rol] WHERE [usuario]=@usuario AND [contrasenia]=@contrasenia)
    SET @imagen = (SELECT [imagen] FROM [usuario] WHERE [usuario]=@usuario AND [contrasenia]=@contrasenia)
  END
  ELSE
  BEGIN
    SET @result = 0
  END
END
GO

INSERT INTO [usuario] VALUES
(12321356, 1, 'AdminTest', 'Karen', '', 'Alga', '', 'correotest@gmail.com', '3208976534', 2, '1996-12-12', 23, 1, 'test', 1, 'test.png');
GO

INSERT INTO [evento] VALUES
('Monserrate', 'Esta es la descripcion del pase por Monserrate.', 'Bogotá', 'Sexy', 'https://www.grancolombiatours.com/wp-content/uploads/2019/05/2-bogota-monserrate-1.jpg');
GO

INSERT INTO [participantes] VALUES
(1, 12321356)
GO

SELECT eve.* FROM [participantes] par JOIN [evento] eve ON par.[eventoID] = eve.[eventoId] WHERE [usuarioId] = 12321356;

SELECT * FROM evento

SELECT * FROM [participantes]

SELECT * FROM usuario

