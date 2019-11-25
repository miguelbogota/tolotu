create database tolotuDB


use tolotuDB;

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

  [fecha_nacimiento] date,

  [edad] tinyint,

  [estado] tinyint,

  [contrasenia] varchar(30),

  [rol] tinyint,

  [imagen] image
  
 
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

  [descripcion] varchar
)


GO


CREATE TABLE [evento] (
  [eventoId] int PRIMARY KEY IDENTITY(1, 1),

  [nombre_evento] varchar(30),

  [localicazion] nvarchar(255),

  [clasificacion] varchar(60),

  [imagen] image
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


INSERT INTO [estados] ([estado]) VALUES ('Activo'),
('Inactivo'),
('Reportado'),
('Baneado');

INSERT INTO [Tipo_documento] ([tipo]) VALUES ('Cedula de ciudadania'),
('Pasaporte'),
('Registro civil');

INSERT INTO [genero] ([genero]) VALUES ('Hombre'),
('Mujer'),
('Otro');

INSERT INTO [roles] ([rol]) VALUES ('Admin'),
('Usuario');








