USE [master]
GO
/****** Object:  Database [CursosOnline]    Script Date: 27/06/2020 23:38:36 ******/
CREATE DATABASE [CursosOnline]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CursosOnline', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\CursosOnline.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CursosOnline_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\CursosOnline_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [CursosOnline] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CursosOnline].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CursosOnline] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CursosOnline] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CursosOnline] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CursosOnline] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CursosOnline] SET ARITHABORT OFF 
GO
ALTER DATABASE [CursosOnline] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CursosOnline] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CursosOnline] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CursosOnline] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CursosOnline] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CursosOnline] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CursosOnline] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CursosOnline] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CursosOnline] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CursosOnline] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CursosOnline] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CursosOnline] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CursosOnline] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CursosOnline] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CursosOnline] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CursosOnline] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CursosOnline] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CursosOnline] SET RECOVERY FULL 
GO
ALTER DATABASE [CursosOnline] SET  MULTI_USER 
GO
ALTER DATABASE [CursosOnline] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CursosOnline] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CursosOnline] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CursosOnline] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CursosOnline] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'CursosOnline', N'ON'
GO
ALTER DATABASE [CursosOnline] SET QUERY_STORE = OFF
GO
USE [CursosOnline]
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 27/06/2020 23:38:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorias](
	[Id_Categoria] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](150) NULL,
 CONSTRAINT [PK_Categorias] PRIMARY KEY CLUSTERED 
(
	[Id_Categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cursos]    Script Date: 27/06/2020 23:38:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cursos](
	[Id_Curso] [int] NOT NULL,
	[Nombre_Curso] [varchar](1200) NULL,
	[Modalidad] [int] NULL,
	[Duracion] [varchar](500) NULL,
	[Tipo_Curso] [int] NULL,
	[Categoria] [int] NULL,
	[Linea_carrera] [int] NULL,
	[Estado] [varchar](50) NULL,
 CONSTRAINT [PK_Cursos] PRIMARY KEY CLUSTERED 
(
	[Id_Curso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Genero]    Script Date: 27/06/2020 23:38:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Genero](
	[TipoGenero] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_Genero] PRIMARY KEY CLUSTERED 
(
	[TipoGenero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Linea_Carrera]    Script Date: 27/06/2020 23:38:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Linea_Carrera](
	[Id_Linea_Carrera] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](150) NULL,
 CONSTRAINT [PK_Linea_Carrera] PRIMARY KEY CLUSTERED 
(
	[Id_Linea_Carrera] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Modalidades]    Script Date: 27/06/2020 23:38:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Modalidades](
	[Id_Modalidad] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](150) NULL,
 CONSTRAINT [PK_Modalidades] PRIMARY KEY CLUSTERED 
(
	[Id_Modalidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personas]    Script Date: 27/06/2020 23:38:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personas](
	[Numero_Identificacion] [bigint] NOT NULL,
	[Rol] [int] NULL,
	[Nombres] [varchar](250) NULL,
	[Apellidos] [varchar](250) NULL,
	[Genero] [int] NULL,
	[LugarNacimiento] [varchar](250) NULL,
	[Edad] [int] NULL,
	[Hobbies] [varchar](3000) NULL,
	[Estado] [varchar](50) NULL,
 CONSTRAINT [PK_Personas] PRIMARY KEY CLUSTERED 
(
	[Numero_Identificacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personas_Cursos]    Script Date: 27/06/2020 23:38:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personas_Cursos](
	[Id_Persona] [bigint] NULL,
	[Id_Curso] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 27/06/2020 23:38:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[Id_Rol] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](150) NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[Id_Rol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipos_De_Curso]    Script Date: 27/06/2020 23:38:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipos_De_Curso](
	[Id_Tipo_Curso] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](150) NULL,
 CONSTRAINT [PK_Tipos_De_Curso] PRIMARY KEY CLUSTERED 
(
	[Id_Tipo_Curso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categorias] ON 
GO
INSERT [dbo].[Categorias] ([Id_Categoria], [Descripcion]) VALUES (1, N'Finanzas')
GO
INSERT [dbo].[Categorias] ([Id_Categoria], [Descripcion]) VALUES (2, N'Administracion')
GO
INSERT [dbo].[Categorias] ([Id_Categoria], [Descripcion]) VALUES (3, N'Idiomas')
GO
INSERT [dbo].[Categorias] ([Id_Categoria], [Descripcion]) VALUES (4, N'Ingenieria')
GO
SET IDENTITY_INSERT [dbo].[Categorias] OFF
GO
INSERT [dbo].[Cursos] ([Id_Curso], [Nombre_Curso], [Modalidad], [Duracion], [Tipo_Curso], [Categoria], [Linea_carrera], [Estado]) VALUES (1, N'Matematicas Especiales', 1, N'6 Meses', 4, 4, 3, NULL)
GO
INSERT [dbo].[Cursos] ([Id_Curso], [Nombre_Curso], [Modalidad], [Duracion], [Tipo_Curso], [Categoria], [Linea_carrera], [Estado]) VALUES (32, N'Calculo Diferencial', 1, N'12 Meses', 4, 3, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Genero] ON 
GO
INSERT [dbo].[Genero] ([TipoGenero], [Descripcion]) VALUES (1, N'Masculino')
GO
INSERT [dbo].[Genero] ([TipoGenero], [Descripcion]) VALUES (2, N'Femenino')
GO
INSERT [dbo].[Genero] ([TipoGenero], [Descripcion]) VALUES (3, N'Otro')
GO
SET IDENTITY_INSERT [dbo].[Genero] OFF
GO
SET IDENTITY_INSERT [dbo].[Linea_Carrera] ON 
GO
INSERT [dbo].[Linea_Carrera] ([Id_Linea_Carrera], [Descripcion]) VALUES (1, N'Tecnico')
GO
INSERT [dbo].[Linea_Carrera] ([Id_Linea_Carrera], [Descripcion]) VALUES (2, N'Tecnologo')
GO
INSERT [dbo].[Linea_Carrera] ([Id_Linea_Carrera], [Descripcion]) VALUES (3, N'Profesional')
GO
INSERT [dbo].[Linea_Carrera] ([Id_Linea_Carrera], [Descripcion]) VALUES (4, N'Maestria')
GO
INSERT [dbo].[Linea_Carrera] ([Id_Linea_Carrera], [Descripcion]) VALUES (5, N'Doctorado')
GO
INSERT [dbo].[Linea_Carrera] ([Id_Linea_Carrera], [Descripcion]) VALUES (6, N'Especializacion')
GO
INSERT [dbo].[Linea_Carrera] ([Id_Linea_Carrera], [Descripcion]) VALUES (7, N'Investigacion')
GO
SET IDENTITY_INSERT [dbo].[Linea_Carrera] OFF
GO
SET IDENTITY_INSERT [dbo].[Modalidades] ON 
GO
INSERT [dbo].[Modalidades] ([Id_Modalidad], [Descripcion]) VALUES (1, N'Presencial')
GO
INSERT [dbo].[Modalidades] ([Id_Modalidad], [Descripcion]) VALUES (2, N'Virtual')
GO
INSERT [dbo].[Modalidades] ([Id_Modalidad], [Descripcion]) VALUES (3, N'Mixto')
GO
SET IDENTITY_INSERT [dbo].[Modalidades] OFF
GO
INSERT [dbo].[Personas] ([Numero_Identificacion], [Rol], [Nombres], [Apellidos], [Genero], [LugarNacimiento], [Edad], [Hobbies], [Estado]) VALUES (457638, NULL, N'Juan', N'Arizola', 2, N'Manizales', 45, N'Trapear', N'Activo')
GO
INSERT [dbo].[Personas] ([Numero_Identificacion], [Rol], [Nombres], [Apellidos], [Genero], [LugarNacimiento], [Edad], [Hobbies], [Estado]) VALUES (2345678, NULL, N'Vicentes', N'Hernandez', 1, NULL, NULL, N'Lavar losa', N'Borrado')
GO
INSERT [dbo].[Personas] ([Numero_Identificacion], [Rol], [Nombres], [Apellidos], [Genero], [LugarNacimiento], [Edad], [Hobbies], [Estado]) VALUES (9345875, 2, N'Camilin', N'García', 1, N'Tunja-Boyacá', 31, N'Barrer', NULL)
GO
INSERT [dbo].[Personas] ([Numero_Identificacion], [Rol], [Nombres], [Apellidos], [Genero], [LugarNacimiento], [Edad], [Hobbies], [Estado]) VALUES (9345876, 2, N'kamilin', N'García', 1, N'Tunja-Boyacá', 31, N'Barrer', NULL)
GO
INSERT [dbo].[Personas] ([Numero_Identificacion], [Rol], [Nombres], [Apellidos], [Genero], [LugarNacimiento], [Edad], [Hobbies], [Estado]) VALUES (66638475, NULL, N'Jose Nelson', N'Zapata', 1, N'Cartagena', 34, N'Cocinar pollo', NULL)
GO
INSERT [dbo].[Personas] ([Numero_Identificacion], [Rol], [Nombres], [Apellidos], [Genero], [LugarNacimiento], [Edad], [Hobbies], [Estado]) VALUES (123456789, NULL, N'prima', N'roca', 1, N'Medellin', 25, N'Lavar losa', NULL)
GO
INSERT [dbo].[Personas] ([Numero_Identificacion], [Rol], [Nombres], [Apellidos], [Genero], [LugarNacimiento], [Edad], [Hobbies], [Estado]) VALUES (1025507931, 1, N'Pepe', N'Rojas', 1, N'Rolo', 25, N'Planchar', NULL)
GO
INSERT [dbo].[Personas] ([Numero_Identificacion], [Rol], [Nombres], [Apellidos], [Genero], [LugarNacimiento], [Edad], [Hobbies], [Estado]) VALUES (1025888731, 2, N'Maria', N'Pajón', 2, N'Medellín-Antioquia', 21, N'Montar Bicicleta', NULL)
GO
INSERT [dbo].[Personas] ([Numero_Identificacion], [Rol], [Nombres], [Apellidos], [Genero], [LugarNacimiento], [Edad], [Hobbies], [Estado]) VALUES (1234598663, NULL, N'TestAngularName', N'TestAngularLastName', 1, NULL, NULL, N'Hacer Ejercicio', NULL)
GO
INSERT [dbo].[Personas_Cursos] ([Id_Persona], [Id_Curso]) VALUES (1025507931, 1)
GO
INSERT [dbo].[Personas_Cursos] ([Id_Persona], [Id_Curso]) VALUES (1025888731, 1)
GO
INSERT [dbo].[Personas_Cursos] ([Id_Persona], [Id_Curso]) VALUES (9345875, 1)
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 
GO
INSERT [dbo].[Roles] ([Id_Rol], [Descripcion]) VALUES (1, N'Profesor')
GO
INSERT [dbo].[Roles] ([Id_Rol], [Descripcion]) VALUES (2, N'Estudiante')
GO
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
SET IDENTITY_INSERT [dbo].[Tipos_De_Curso] ON 
GO
INSERT [dbo].[Tipos_De_Curso] ([Id_Tipo_Curso], [Descripcion]) VALUES (1, N'Certificacion')
GO
INSERT [dbo].[Tipos_De_Curso] ([Id_Tipo_Curso], [Descripcion]) VALUES (2, N'Seminario')
GO
INSERT [dbo].[Tipos_De_Curso] ([Id_Tipo_Curso], [Descripcion]) VALUES (3, N'Taller')
GO
INSERT [dbo].[Tipos_De_Curso] ([Id_Tipo_Curso], [Descripcion]) VALUES (4, N'Tradicional')
GO
SET IDENTITY_INSERT [dbo].[Tipos_De_Curso] OFF
GO
ALTER TABLE [dbo].[Cursos]  WITH CHECK ADD  CONSTRAINT [FK_Cursos_Categorias] FOREIGN KEY([Categoria])
REFERENCES [dbo].[Categorias] ([Id_Categoria])
GO
ALTER TABLE [dbo].[Cursos] CHECK CONSTRAINT [FK_Cursos_Categorias]
GO
ALTER TABLE [dbo].[Cursos]  WITH CHECK ADD  CONSTRAINT [FK_Cursos_Linea_Carrera] FOREIGN KEY([Linea_carrera])
REFERENCES [dbo].[Linea_Carrera] ([Id_Linea_Carrera])
GO
ALTER TABLE [dbo].[Cursos] CHECK CONSTRAINT [FK_Cursos_Linea_Carrera]
GO
ALTER TABLE [dbo].[Cursos]  WITH CHECK ADD  CONSTRAINT [FK_Cursos_Modalidades] FOREIGN KEY([Modalidad])
REFERENCES [dbo].[Modalidades] ([Id_Modalidad])
GO
ALTER TABLE [dbo].[Cursos] CHECK CONSTRAINT [FK_Cursos_Modalidades]
GO
ALTER TABLE [dbo].[Cursos]  WITH CHECK ADD  CONSTRAINT [FK_Cursos_Tipos_De_Curso] FOREIGN KEY([Tipo_Curso])
REFERENCES [dbo].[Tipos_De_Curso] ([Id_Tipo_Curso])
GO
ALTER TABLE [dbo].[Cursos] CHECK CONSTRAINT [FK_Cursos_Tipos_De_Curso]
GO
ALTER TABLE [dbo].[Personas]  WITH CHECK ADD  CONSTRAINT [FK_Personas_Genero] FOREIGN KEY([Genero])
REFERENCES [dbo].[Genero] ([TipoGenero])
GO
ALTER TABLE [dbo].[Personas] CHECK CONSTRAINT [FK_Personas_Genero]
GO
ALTER TABLE [dbo].[Personas]  WITH CHECK ADD  CONSTRAINT [FK_Personas_Roles] FOREIGN KEY([Rol])
REFERENCES [dbo].[Roles] ([Id_Rol])
GO
ALTER TABLE [dbo].[Personas] CHECK CONSTRAINT [FK_Personas_Roles]
GO
ALTER TABLE [dbo].[Personas_Cursos]  WITH CHECK ADD  CONSTRAINT [FK_Personas_Cursos_Cursos] FOREIGN KEY([Id_Curso])
REFERENCES [dbo].[Cursos] ([Id_Curso])
GO
ALTER TABLE [dbo].[Personas_Cursos] CHECK CONSTRAINT [FK_Personas_Cursos_Cursos]
GO
ALTER TABLE [dbo].[Personas_Cursos]  WITH CHECK ADD  CONSTRAINT [FK_Personas_Cursos_Personas] FOREIGN KEY([Id_Persona])
REFERENCES [dbo].[Personas] ([Numero_Identificacion])
GO
ALTER TABLE [dbo].[Personas_Cursos] CHECK CONSTRAINT [FK_Personas_Cursos_Personas]
GO
/****** Object:  StoredProcedure [dbo].[SP_K_MEANS]    Script Date: 27/06/2020 23:38:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_K_MEANS] 

AS BEGIN

SELECT Hobbies,Edad from Personas ORDER BY Personas.Edad
	

END

GO
/****** Object:  StoredProcedure [dbo].[SP_RANGO_PERSONAS_POR_EDAD]    Script Date: 27/06/2020 23:38:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_RANGO_PERSONAS_POR_EDAD] 

AS BEGIN

	
	SELECT 

	CASE 

	WHEN  Personas.Edad BETWEEN 0 AND 10 

	THEN 'MENORES DE 10 AÑOS' 

	WHEN Personas.Edad BETWEEN 11 AND 20 

	THEN 'ENTRE 11 Y 20 AÑOS' 

	WHEN Personas.Edad BETWEEN 21 AND 29 

	THEN 'ENTRE 21 Y 29 AÑOS' 

	WHEN Personas.Edad BETWEEN 30 AND 50 

	THEN 'ENTRE 30 Y 50 AÑOS' 

	WHEN Personas.Edad>50  

	THEN 'MAYORES DE 50 AÑOS' 

	END AS RANGO_DE_EDAD , COUNT(*) AS CANTIDAD

	FROM Personas GROUP BY Edad


END

GO
/****** Object:  StoredProcedure [dbo].[SP_RANGO_PERSONAS_POR_GENERO]    Script Date: 27/06/2020 23:38:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[SP_RANGO_PERSONAS_POR_GENERO]

AS

BEGIN

	SELECT 

	CASE 

	WHEN  Personas.Genero = 1

	THEN 'MASCULINO'
	
WHEN  Personas.Genero = 2

	THEN 'FEMENINO'
	
WHEN  Personas.Genero = 3

	THEN 'OTRO'
	

	END AS RANGO_DE_GENERO, COUNT(*) AS CANTIDAD

	FROM Personas GROUP BY Genero

END
GO
USE [master]
GO
ALTER DATABASE [CursosOnline] SET  READ_WRITE 
GO
