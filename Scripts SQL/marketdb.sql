USE [master]
GO
/****** Object:  Database [marketdb]    Script Date: 14/01/2020 21:42:25 ******/
CREATE DATABASE [marketdb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'marketdb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\marketdb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'marketdb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\marketdb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [marketdb] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [marketdb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [marketdb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [marketdb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [marketdb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [marketdb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [marketdb] SET ARITHABORT OFF 
GO
ALTER DATABASE [marketdb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [marketdb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [marketdb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [marketdb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [marketdb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [marketdb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [marketdb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [marketdb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [marketdb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [marketdb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [marketdb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [marketdb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [marketdb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [marketdb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [marketdb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [marketdb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [marketdb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [marketdb] SET RECOVERY FULL 
GO
ALTER DATABASE [marketdb] SET  MULTI_USER 
GO
ALTER DATABASE [marketdb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [marketdb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [marketdb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [marketdb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [marketdb] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'marketdb', N'ON'
GO
ALTER DATABASE [marketdb] SET QUERY_STORE = OFF
GO
USE [marketdb]
GO
/****** Object:  Table [dbo].[categorias]    Script Date: 14/01/2020 21:42:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[categorias](
	[id] [int] NOT NULL,
	[nombre_categoria] [nvarchar](50) NOT NULL,
	[detalle_categoria] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_categorias] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Guia]    Script Date: 14/01/2020 21:42:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Guia](
	[id] [int] NOT NULL,
	[id_local] [int] NOT NULL,
	[id_transportista] [int] NOT NULL,
	[id_orden_pedido] [int] NOT NULL,
	[fecha_salida] [date] NOT NULL,
	[pvp] [money] NOT NULL,
	[total_items_despachados] [int] NOT NULL,
 CONSTRAINT [PK_Guia] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[local]    Script Date: 14/01/2020 21:42:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[local](
	[id] [int] NOT NULL,
	[direccion] [nvarchar](50) NOT NULL,
	[ciudad] [nvarchar](50) NOT NULL,
	[telefono] [nvarchar](50) NOT NULL,
	[fax] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_local] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orden_compra]    Script Date: 14/01/2020 21:42:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orden_compra](
	[id] [int] NOT NULL,
	[id_proveedor] [int] NOT NULL,
	[fecha_ingreso] [date] NOT NULL,
	[fecha_emision] [date] NOT NULL,
	[estado] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_orden_compra] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orden_pedido]    Script Date: 14/01/2020 21:42:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orden_pedido](
	[id] [int] NOT NULL,
	[numero_pedido] [nvarchar](50) NOT NULL,
	[fecha_pedido] [date] NOT NULL,
	[cantidad_items_solicitada] [int] NOT NULL,
 CONSTRAINT [PK_orden_pedido] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[producto]    Script Date: 14/01/2020 21:42:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[producto](
	[id] [int] NOT NULL,
	[id_categoria] [int] NOT NULL,
	[id_proveedor] [int] NOT NULL,
	[stock_actual] [int] NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[unidad_medida] [nvarchar](50) NOT NULL,
	[precio_proveedor] [money] NOT NULL,
	[costo_iva] [money] NOT NULL,
	[precio_venta] [money] NOT NULL,
	[utilidad] [money] NOT NULL,
	[stock_minimo] [int] NOT NULL,
 CONSTRAINT [PK_producto] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[proveedor]    Script Date: 14/01/2020 21:42:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[proveedor](
	[id] [int] NOT NULL,
	[codigo_proveedor] [nvarchar](50) NOT NULL,
	[nombre_proveedor] [nvarchar](50) NOT NULL,
	[representante] [nvarchar](50) NOT NULL,
	[direccion] [nvarchar](50) NOT NULL,
	[ciudad] [nvarchar](50) NOT NULL,
	[telefono] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_proveedor] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rel_compra_producto]    Script Date: 14/01/2020 21:42:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rel_compra_producto](
	[id_compra] [int] NULL,
	[id_producto] [int] NULL,
	[cantidad_solicitada] [int] NULL,
	[cantidad_recibida] [int] NULL,
	[precio_compra] [money] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rel_pedido_producto]    Script Date: 14/01/2020 21:42:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rel_pedido_producto](
	[id_pedido] [int] NOT NULL,
	[id_producto] [int] NOT NULL,
	[cantidad_solicitada] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[transportista]    Script Date: 14/01/2020 21:42:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[transportista](
	[id] [int] NOT NULL,
	[cedula] [nvarchar](50) NOT NULL,
	[nombre] [nchar](10) NOT NULL,
	[direccion] [nchar](10) NOT NULL,
	[telefono] [nchar](10) NOT NULL,
 CONSTRAINT [PK_transportista] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Guia]  WITH CHECK ADD  CONSTRAINT [FK_Guia_local] FOREIGN KEY([id_local])
REFERENCES [dbo].[local] ([id])
GO
ALTER TABLE [dbo].[Guia] CHECK CONSTRAINT [FK_Guia_local]
GO
ALTER TABLE [dbo].[Guia]  WITH CHECK ADD  CONSTRAINT [FK_Guia_orden_pedido] FOREIGN KEY([id_orden_pedido])
REFERENCES [dbo].[orden_pedido] ([id])
GO
ALTER TABLE [dbo].[Guia] CHECK CONSTRAINT [FK_Guia_orden_pedido]
GO
ALTER TABLE [dbo].[Guia]  WITH CHECK ADD  CONSTRAINT [FK_Guia_transportista] FOREIGN KEY([id_transportista])
REFERENCES [dbo].[transportista] ([id])
GO
ALTER TABLE [dbo].[Guia] CHECK CONSTRAINT [FK_Guia_transportista]
GO
ALTER TABLE [dbo].[producto]  WITH CHECK ADD  CONSTRAINT [FK_producto_categorias] FOREIGN KEY([id_categoria])
REFERENCES [dbo].[categorias] ([id])
GO
ALTER TABLE [dbo].[producto] CHECK CONSTRAINT [FK_producto_categorias]
GO
ALTER TABLE [dbo].[producto]  WITH CHECK ADD  CONSTRAINT [FK_producto_proveedor] FOREIGN KEY([id_proveedor])
REFERENCES [dbo].[proveedor] ([id])
GO
ALTER TABLE [dbo].[producto] CHECK CONSTRAINT [FK_producto_proveedor]
GO
ALTER TABLE [dbo].[rel_compra_producto]  WITH CHECK ADD  CONSTRAINT [FK_rel_compra_producto_orden_compra] FOREIGN KEY([id_compra])
REFERENCES [dbo].[orden_compra] ([id])
GO
ALTER TABLE [dbo].[rel_compra_producto] CHECK CONSTRAINT [FK_rel_compra_producto_orden_compra]
GO
ALTER TABLE [dbo].[rel_compra_producto]  WITH CHECK ADD  CONSTRAINT [FK_rel_compra_producto_producto] FOREIGN KEY([id_producto])
REFERENCES [dbo].[producto] ([id])
GO
ALTER TABLE [dbo].[rel_compra_producto] CHECK CONSTRAINT [FK_rel_compra_producto_producto]
GO
ALTER TABLE [dbo].[rel_pedido_producto]  WITH CHECK ADD  CONSTRAINT [FK_rel_pedido_producto_orden_pedido] FOREIGN KEY([id_pedido])
REFERENCES [dbo].[orden_pedido] ([id])
GO
ALTER TABLE [dbo].[rel_pedido_producto] CHECK CONSTRAINT [FK_rel_pedido_producto_orden_pedido]
GO
ALTER TABLE [dbo].[rel_pedido_producto]  WITH CHECK ADD  CONSTRAINT [FK_rel_pedido_producto_producto] FOREIGN KEY([id_producto])
REFERENCES [dbo].[producto] ([id])
GO
ALTER TABLE [dbo].[rel_pedido_producto] CHECK CONSTRAINT [FK_rel_pedido_producto_producto]
GO
USE [master]
GO
ALTER DATABASE [marketdb] SET  READ_WRITE 
GO
