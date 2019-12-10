create database tolotuBD

use tolotuBD;

CREATE TABLE [estados] (
  [estadoId] tinyint PRIMARY KEY IDENTITY(1, 1),
  [estado] varchar(15)
)

CREATE TABLE [Tipo_documento] (
  [Tipo_documentoId] tinyint PRIMARY KEY IDENTITY(1, 1),
  [tipo] char(30)
)

CREATE TABLE [genero] (
  [generoId] tinyint PRIMARY KEY IDENTITY(1, 1),
  [genero] char(10)
)

CREATE TABLE [roles] (
  [rolesId] tinyint PRIMARY KEY IDENTITY(1, 1),
  [rol] char(10)
)

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

CREATE TABLE [baneados] (
  [baneoId] tinyint PRIMARY KEY IDENTITY(1, 1),
  [usuaID] int,
  [fecha_ban] date,
  [descripcion] varchar(150)
)

CREATE TABLE [gustos] (
  [gustoId] tinyint PRIMARY KEY IDENTITY(1, 1),
  [nombre] varchar(25),
  [descripcion] varchar
)

CREATE TABLE [evento] (
  [eventoId] int PRIMARY KEY IDENTITY(1, 1),
  [nombre_evento] varchar(30),
  [localicazion] nvarchar(255),
  [clasificacion] varchar(60),
  [imagen] image
)

CREATE TABLE [usugustos] (
  [usugustosId] tinyint PRIMARY KEY IDENTITY(1, 1),
  [gustoID] tinyint,
  [usuarioID] int
)

CREATE TABLE [participantes] (
  [participantesId] int PRIMARY KEY IDENTITY(1, 1),
  [eventoID] int,
  [usuarioID] int
)

CREATE TABLE [eveugusto] (
  [eveugustoId] tinyint PRIMARY KEY IDENTITY(1, 1),
  [eventoID] int,
  [gustoID] tinyint
)

ALTER TABLE [usuario] ADD FOREIGN KEY ([tipo_documento]) REFERENCES [Tipo_documento] ([Tipo_documentoId])
ALTER TABLE [usuario] ADD FOREIGN KEY ([genero]) REFERENCES [genero] ([generoId])
ALTER TABLE [usuario] ADD FOREIGN KEY ([estado]) REFERENCES [estados] ([estadoId])
ALTER TABLE [usuario] ADD FOREIGN KEY ([rol]) REFERENCES [roles] ([rolesId])
ALTER TABLE [baneados] ADD FOREIGN KEY ([usuaID]) REFERENCES [usuario] ([documento])
ALTER TABLE [usugustos] ADD FOREIGN KEY ([gustoID]) REFERENCES [gustos] ([gustoId])
ALTER TABLE [usugustos] ADD FOREIGN KEY ([usuarioID]) REFERENCES [usuario] ([documento])
ALTER TABLE [participantes] ADD FOREIGN KEY ([eventoID]) REFERENCES [evento] ([eventoId])
ALTER TABLE [participantes] ADD FOREIGN KEY ([usuarioID]) REFERENCES [usuario] ([documento])
ALTER TABLE [eveugusto] ADD FOREIGN KEY ([eventoID]) REFERENCES [evento] ([eventoId])
ALTER TABLE [eveugusto] ADD FOREIGN KEY ([gustoID]) REFERENCES [gustos] ([gustoId])

INSERT INTO [estados] ([estado]) VALUES
('Activo'),
('Inactivo'),
('Reportado'),
('Baneado');

INSERT INTO [Tipo_documento] ([tipo]) VALUES
('Cedula de ciudadania'),
('Pasaporte'),
('Registro civil');

INSERT INTO [genero] ([genero]) VALUES
('Hombre'),
('Mujer'),
('Otro');

INSERT INTO [roles] ([rol]) VALUES
('Admin'),
('Usuario');

CREATE PROCEDURE [Consulta]
@documento varchar(50),
@outputs varchar(50) output
AS    
BEGIN
  DECLARE @document_INT int = CONVERT(INT, @documento)
  SELECT * FROM [Tipo_documento] WHERE [Tipo_documentoId]=@document_INT
  SET @outputs = (SELECT [tipo] FROM [Tipo_documento] WHERE [Tipo_documentoId]=@document_INT)
END


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

CREATE PROCEDURE [HayUsuario]
@documento int,
@result tinyint output
AS    
BEGIN
  DECLARE @output varchar(50)
  SET @output = (SELECT [usuario] FROM [usuario] WHERE [documento]=@documento)
  IF @output > 0
  BEGIN
    SET @result = 1
  END
  ELSE
  BEGIN
    SET @result = 0
  END
END

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