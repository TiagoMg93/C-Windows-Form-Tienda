USE [master]
GO
/****** Object:  Database [Tienda]    Script Date: 25/10/2021 20:55:29 ******/
CREATE DATABASE [Tienda]
GO
ALTER DATABASE [Tienda] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Tienda].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Tienda] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Tienda] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Tienda] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Tienda] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Tienda] SET ARITHABORT OFF 
GO
ALTER DATABASE [Tienda] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Tienda] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Tienda] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Tienda] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Tienda] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Tienda] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Tienda] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Tienda] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Tienda] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Tienda] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Tienda] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Tienda] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Tienda] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Tienda] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Tienda] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Tienda] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Tienda] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Tienda] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Tienda] SET  MULTI_USER 
GO
ALTER DATABASE [Tienda] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Tienda] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Tienda] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Tienda] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Tienda] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Tienda] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Tienda] SET QUERY_STORE = OFF
GO
USE [Tienda]
GO
/****** Object:  Table [dbo].[Articulo]    Script Date: 25/10/2021 20:55:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Articulo](
	[Código] [int] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Precio] [float] NOT NULL,
	[Costo] [float] NOT NULL,
	[Marca] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Articulo] PRIMARY KEY CLUSTERED 
(
	[Código] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Buscar]    Script Date: 25/10/2021 20:55:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Buscar](
	[Busqueda] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Descuento]    Script Date: 25/10/2021 20:55:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Descuento](
	[Código] [int] NOT NULL,
	[Descuento] [int] NULL,
 CONSTRAINT [PK_Descuento] PRIMARY KEY CLUSTERED 
(
	[Código] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Historial]    Script Date: 25/10/2021 20:55:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Historial](
	[Código] [int] NOT NULL,
	[Unidades_Vendidas] [int] NOT NULL,
	[Ventas_Totales] [bigint] NOT NULL,
	[Costo_Total] [bigint] NOT NULL,
 CONSTRAINT [PK_Historial] PRIMARY KEY CLUSTERED 
(
	[Código] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 25/10/2021 20:55:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedor](
	[Código] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Proveedor] [nvarchar](50) NOT NULL,
	[Contacto] [bigint] NOT NULL,
 CONSTRAINT [PK_Proveedor] PRIMARY KEY CLUSTERED 
(
	[Código] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 25/10/2021 20:55:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Indice] [int] NOT NULL,
	[Usuario] [nvarchar](50) NOT NULL,
	[Contraseña] [nvarchar](50) NOT NULL,
	[Administrador] [bit] NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Articulo] ([Código], [Nombre], [Precio], [Costo], [Marca]) VALUES (1, N'Bolsa de leche', 3600, 2150, N'Colanta')
GO
INSERT [dbo].[Articulo] ([Código], [Nombre], [Precio], [Costo], [Marca]) VALUES (2, N'Huevo', 400, 200, N'Granja Manuela')
GO
INSERT [dbo].[Articulo] ([Código], [Nombre], [Precio], [Costo], [Marca]) VALUES (3, N'Paquete de arepas x 10', 6200, 3450, N'Doña Paisa')
GO
INSERT [dbo].[Articulo] ([Código], [Nombre], [Precio], [Costo], [Marca]) VALUES (4, N'Rollo de papel higienico', 1200, 650, N'Familia')
GO
INSERT [dbo].[Articulo] ([Código], [Nombre], [Precio], [Costo], [Marca]) VALUES (5, N'Gaseosa 3.125L', 6000, 4150, N'Manzana Postobón')
GO
INSERT [dbo].[Buscar] ([Busqueda]) VALUES (N'2 - Huevo - Granja Manuela')
GO
INSERT [dbo].[Descuento] ([Código], [Descuento]) VALUES (1, 10)
GO
INSERT [dbo].[Descuento] ([Código], [Descuento]) VALUES (2, 10)
GO
INSERT [dbo].[Descuento] ([Código], [Descuento]) VALUES (3, 5)
GO
INSERT [dbo].[Descuento] ([Código], [Descuento]) VALUES (4, 0)
GO
INSERT [dbo].[Descuento] ([Código], [Descuento]) VALUES (5, 5)
GO
INSERT [dbo].[Historial] ([Código], [Unidades_Vendidas], [Ventas_Totales], [Costo_Total]) VALUES (1, 19, 65520, 40850)
GO
INSERT [dbo].[Historial] ([Código], [Unidades_Vendidas], [Ventas_Totales], [Costo_Total]) VALUES (2, 32, 10530, 6400)
GO
INSERT [dbo].[Historial] ([Código], [Unidades_Vendidas], [Ventas_Totales], [Costo_Total]) VALUES (3, 5, 27550, 17250)
GO
INSERT [dbo].[Historial] ([Código], [Unidades_Vendidas], [Ventas_Totales], [Costo_Total]) VALUES (4, 5, 6000, 3250)
GO
INSERT [dbo].[Historial] ([Código], [Unidades_Vendidas], [Ventas_Totales], [Costo_Total]) VALUES (5, 2, 11100, 8300)
GO
INSERT [dbo].[Proveedor] ([Código], [Cantidad], [Proveedor], [Contacto]) VALUES (1, 13, N'Colanta', 1298937)
GO
INSERT [dbo].[Proveedor] ([Código], [Cantidad], [Proveedor], [Contacto]) VALUES (2, 50, N'Carmensa', 139038)
GO
INSERT [dbo].[Proveedor] ([Código], [Cantidad], [Proveedor], [Contacto]) VALUES (3, 41, N'Fabiola', 908873)
GO
INSERT [dbo].[Proveedor] ([Código], [Cantidad], [Proveedor], [Contacto]) VALUES (4, 40, N'Familia', 5231092)
GO
INSERT [dbo].[Proveedor] ([Código], [Cantidad], [Proveedor], [Contacto]) VALUES (5, 34, N'Postobón', 4120098)
GO
INSERT [dbo].[Usuario] ([Indice], [Usuario], [Contraseña], [Administrador]) VALUES (1, N'ADMIN', N'102938', 1)
GO
INSERT [dbo].[Usuario] ([Indice], [Usuario], [Contraseña], [Administrador]) VALUES (2, N'PAOLAMRT82', N'QWERTYUIOP', 0)
GO
INSERT [dbo].[Usuario] ([Indice], [Usuario], [Contraseña], [Administrador]) VALUES (3, N'BAYRONLQW95', N'ZXCVBNM', 0)
GO
INSERT [dbo].[Usuario] ([Indice], [Usuario], [Contraseña], [Administrador]) VALUES (4, N'WILDERHP', N'123456', 0)
GO
ALTER TABLE [dbo].[Descuento]  WITH CHECK ADD  CONSTRAINT [FK_Descuento_Articulo] FOREIGN KEY([Código])
REFERENCES [dbo].[Articulo] ([Código])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Descuento] CHECK CONSTRAINT [FK_Descuento_Articulo]
GO
ALTER TABLE [dbo].[Historial]  WITH CHECK ADD  CONSTRAINT [FK_Historial_Articulo] FOREIGN KEY([Código])
REFERENCES [dbo].[Articulo] ([Código])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Historial] CHECK CONSTRAINT [FK_Historial_Articulo]
GO
ALTER TABLE [dbo].[Proveedor]  WITH CHECK ADD  CONSTRAINT [FK_Proveedor_Articulo] FOREIGN KEY([Código])
REFERENCES [dbo].[Articulo] ([Código])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Proveedor] CHECK CONSTRAINT [FK_Proveedor_Articulo]
GO
USE [master]
GO
ALTER DATABASE [Tienda] SET  READ_WRITE 
GO
