USE [SistemaRolPago]
GO
/****** Object:  Table [dbo].[Modulo]    Script Date: 6/8/2019 11:05:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Modulo](
	[IdeModulo] [nvarchar](50) NOT NULL,
	[IdeModuloPadre] [nvarchar](50) NULL,
	[NombreModulo] [nvarchar](50) NULL,
	[DescripcionModulo] [nvarchar](50) NULL,
	[IconoModulo] [nvarchar](50) NULL,
	[RutaModulo] [nvarchar](max) NULL,
	[EstadoModulo] [nvarchar](50) NULL,
 CONSTRAINT [PK_Modulo] PRIMARY KEY CLUSTERED 
(
	[IdeModulo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Perfil]    Script Date: 6/8/2019 11:05:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Perfil](
	[IdePerfil] [int] IDENTITY(1,1) NOT NULL,
	[NombrePerfil] [nvarchar](100) NULL,
 CONSTRAINT [PK_Perfil] PRIMARY KEY CLUSTERED 
(
	[IdePerfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Permiso]    Script Date: 6/8/2019 11:05:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permiso](
	[IdePerfil] [int] NOT NULL,
	[IdeRecurso] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_MiTabla] PRIMARY KEY CLUSTERED 
(
	[IdePerfil] ASC,
	[IdeRecurso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Recurso]    Script Date: 6/8/2019 11:05:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Recurso](
	[IdeRecurso] [nvarchar](10) NOT NULL,
	[IdeModulo] [nvarchar](50) NULL,
	[NombreRecurso] [nvarchar](50) NULL,
	[DescripcionRecurso] [nvarchar](50) NULL,
	[IconoRecurso] [nvarchar](50) NULL,
	[EstadoRecurso] [nvarchar](50) NULL,
 CONSTRAINT [PK_Recurso] PRIMARY KEY CLUSTERED 
(
	[IdeRecurso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 6/8/2019 11:05:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[IdeUsuario] [int] IDENTITY(1,1) NOT NULL,
	[IdeEmpleado] [int] NULL,
	[EstadoUsuario] [nvarchar](10) NULL,
	[IdePerfil] [int] NULL,
	[NombreUsuario] [nvarchar](30) NULL,
	[Clave] [nvarchar](max) NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[IdeUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[Modulo]  WITH CHECK ADD  CONSTRAINT [FK_Modulo_Modulo] FOREIGN KEY([IdeModuloPadre])
REFERENCES [dbo].[Modulo] ([IdeModulo])
GO
ALTER TABLE [dbo].[Modulo] CHECK CONSTRAINT [FK_Modulo_Modulo]
GO
ALTER TABLE [dbo].[Permiso]  WITH CHECK ADD  CONSTRAINT [FK_Permiso_Perfil] FOREIGN KEY([IdePerfil])
REFERENCES [dbo].[Perfil] ([IdePerfil])
GO
ALTER TABLE [dbo].[Permiso] CHECK CONSTRAINT [FK_Permiso_Perfil]
GO
ALTER TABLE [dbo].[Permiso]  WITH CHECK ADD  CONSTRAINT [FK_Permiso_Recurso] FOREIGN KEY([IdeRecurso])
REFERENCES [dbo].[Recurso] ([IdeRecurso])
GO
ALTER TABLE [dbo].[Permiso] CHECK CONSTRAINT [FK_Permiso_Recurso]
GO
ALTER TABLE [dbo].[Recurso]  WITH CHECK ADD  CONSTRAINT [FK_Recurso_Modulo] FOREIGN KEY([IdeModulo])
REFERENCES [dbo].[Modulo] ([IdeModulo])
GO
ALTER TABLE [dbo].[Recurso] CHECK CONSTRAINT [FK_Recurso_Modulo]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Empleados] FOREIGN KEY([IdeEmpleado])
REFERENCES [dbo].[Empleados] ([CodEmpleado])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_Empleados]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Perfil] FOREIGN KEY([IdePerfil])
REFERENCES [dbo].[Perfil] ([IdePerfil])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_Perfil]
GO
