USE [master]
GO
/****** Object:  Database [VentasCapas]    Script Date: 14/11/2025 05:31:41 p. m. ******/
CREATE DATABASE [VentasCapas]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'VentasCapas', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\VentasCapas.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'VentasCapas_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\VentasCapas_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [VentasCapas] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VentasCapas].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [VentasCapas] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [VentasCapas] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [VentasCapas] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [VentasCapas] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [VentasCapas] SET ARITHABORT OFF 
GO
ALTER DATABASE [VentasCapas] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [VentasCapas] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [VentasCapas] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [VentasCapas] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [VentasCapas] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [VentasCapas] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [VentasCapas] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [VentasCapas] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [VentasCapas] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [VentasCapas] SET  DISABLE_BROKER 
GO
ALTER DATABASE [VentasCapas] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [VentasCapas] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [VentasCapas] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [VentasCapas] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [VentasCapas] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [VentasCapas] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [VentasCapas] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [VentasCapas] SET RECOVERY FULL 
GO
ALTER DATABASE [VentasCapas] SET  MULTI_USER 
GO
ALTER DATABASE [VentasCapas] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [VentasCapas] SET DB_CHAINING OFF 
GO
ALTER DATABASE [VentasCapas] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [VentasCapas] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [VentasCapas] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [VentasCapas] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'VentasCapas', N'ON'
GO
ALTER DATABASE [VentasCapas] SET QUERY_STORE = ON
GO
ALTER DATABASE [VentasCapas] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [VentasCapas]
GO
/****** Object:  Table [dbo].[cliente]    Script Date: 14/11/2025 05:31:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cliente](
	[id_cliente] [smallint] IDENTITY(1,1) NOT NULL,
	[entidad] [varchar](100) NULL,
	[ruc] [char](11) NULL,
	[direccion] [varchar](100) NULL,
	[contacto] [varchar](50) NULL,
	[correo] [varchar](50) NULL,
	[area] [varchar](50) NULL,
	[telefono] [varchar](20) NULL,
	[observacion] [varchar](100) NULL,
	[ciudad] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[producto]    Script Date: 14/11/2025 05:31:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[producto](
	[id_producto] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](100) NOT NULL,
	[precio_unitario] [money] NOT NULL,
 CONSTRAINT [PK_producto] PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 14/11/2025 05:31:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[dni] [char](8) NULL,
	[clave] [varchar](100) NULL,
	[rol] [varchar](20) NULL,
	[apellidos_nombres] [varchar](60) NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_usuario] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[venta]    Script Date: 14/11/2025 05:31:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[venta](
	[id_venta] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NOT NULL,
	[id_cliente] [smallint] NOT NULL,
	[serie] [varchar](6) NULL,
	[numero] [varchar](6) NULL,
	[tipo_comprobante] [char](1) NULL,
	[igv] [decimal](18, 2) NULL,
 CONSTRAINT [PK_venta] PRIMARY KEY CLUSTERED 
(
	[id_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[venta_detalle]    Script Date: 14/11/2025 05:31:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[venta_detalle](
	[id_venta] [int] NOT NULL,
	[id_producto] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[precio_unitario] [money] NOT NULL,
 CONSTRAINT [PK_venta_detalle] PRIMARY KEY CLUSTERED 
(
	[id_venta] ASC,
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[cliente] ON 
GO
INSERT [dbo].[cliente] ([id_cliente], [entidad], [ruc], [direccion], [contacto], [correo], [area], [telefono], [observacion], [ciudad]) VALUES (1, N'Marco A. Morales', N'21212313232', N'direccion', N'contacto', N'correo', N'area', N'telefono', N'observacion', N'ciudad')
GO
INSERT [dbo].[cliente] ([id_cliente], [entidad], [ruc], [direccion], [contacto], [correo], [area], [telefono], [observacion], [ciudad]) VALUES (2, N'Mario Robelo', N'23123131311', N'direccion', N'contacto', N'correo', N'area', N'telefono', N'observacion', N'ciudad')
GO
INSERT [dbo].[cliente] ([id_cliente], [entidad], [ruc], [direccion], [contacto], [correo], [area], [telefono], [observacion], [ciudad]) VALUES (5, N'Empresa 01', N'12345678901', N'Dirección Empresa 01', N'Contacto Empresa 01', N'Empresa 01@hotmail.com', N'Area Empresa 01', N'Teléfono Empresa 01', N'Ciudad Empresa 01', N'Observación Empresa')
GO
INSERT [dbo].[cliente] ([id_cliente], [entidad], [ruc], [direccion], [contacto], [correo], [area], [telefono], [observacion], [ciudad]) VALUES (6, N'Empresa 02', N'01234567891', N'Empresa 02', N'Empresa 02', N'Empresa 02', N'Empresa 02', N'Empresa 02', N'Empresa 02', N'Empresa 02')
GO
INSERT [dbo].[cliente] ([id_cliente], [entidad], [ruc], [direccion], [contacto], [correo], [area], [telefono], [observacion], [ciudad]) VALUES (7, N'Empresa 03', N'01234567892', N'Empresa 03', N'Empresa 03', N'Empresa 03', N'Empresa 03', N'Empresa 03', N'Empresa 03', N'Empresa 03')
GO
SET IDENTITY_INSERT [dbo].[cliente] OFF
GO
SET IDENTITY_INSERT [dbo].[producto] ON 
GO
INSERT [dbo].[producto] ([id_producto], [descripcion], [precio_unitario]) VALUES (1, N'Producto 1', 10.2500)
GO
INSERT [dbo].[producto] ([id_producto], [descripcion], [precio_unitario]) VALUES (2, N'Producto 2', 100.1000)
GO
INSERT [dbo].[producto] ([id_producto], [descripcion], [precio_unitario]) VALUES (3, N'Producto 3', 1.3000)
GO
INSERT [dbo].[producto] ([id_producto], [descripcion], [precio_unitario]) VALUES (5, N'Producto 4', 3.3300)
GO
SET IDENTITY_INSERT [dbo].[producto] OFF
GO
SET IDENTITY_INSERT [dbo].[usuario] ON 
GO
INSERT [dbo].[usuario] ([id_usuario], [dni], [clave], [rol], [apellidos_nombres], [activo]) VALUES (1, N'usuario ', N'123456', N'Administrador', N'Nombre completo', 1)
GO
INSERT [dbo].[usuario] ([id_usuario], [dni], [clave], [rol], [apellidos_nombres], [activo]) VALUES (2, N'mll     ', N'1234', N'Administrador', N'Mario López López', 1)
GO
INSERT [dbo].[usuario] ([id_usuario], [dni], [clave], [rol], [apellidos_nombres], [activo]) VALUES (3, N'jlp     ', N'123456', N'Administrador', N'Juanito López Pérez', 1)
GO
INSERT [dbo].[usuario] ([id_usuario], [dni], [clave], [rol], [apellidos_nombres], [activo]) VALUES (4, N'mmorales', N'123456', N'Administrador', N'Marco A. Morales', 1)
GO
INSERT [dbo].[usuario] ([id_usuario], [dni], [clave], [rol], [apellidos_nombres], [activo]) VALUES (5, N'flp     ', N'1234', N'Administrador', N'Fulanito López Pérez', 1)
GO
SET IDENTITY_INSERT [dbo].[usuario] OFF
GO
SET IDENTITY_INSERT [dbo].[venta] ON 
GO
INSERT [dbo].[venta] ([id_venta], [fecha], [id_cliente], [serie], [numero], [tipo_comprobante], [igv]) VALUES (5, CAST(N'2025-11-11' AS Date), 1, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[venta] ([id_venta], [fecha], [id_cliente], [serie], [numero], [tipo_comprobante], [igv]) VALUES (6, CAST(N'2025-11-11' AS Date), 1, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[venta] ([id_venta], [fecha], [id_cliente], [serie], [numero], [tipo_comprobante], [igv]) VALUES (8, CAST(N'2025-11-11' AS Date), 2, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[venta] ([id_venta], [fecha], [id_cliente], [serie], [numero], [tipo_comprobante], [igv]) VALUES (9, CAST(N'2025-11-12' AS Date), 5, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[venta] ([id_venta], [fecha], [id_cliente], [serie], [numero], [tipo_comprobante], [igv]) VALUES (10, CAST(N'2025-11-11' AS Date), 7, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[venta] ([id_venta], [fecha], [id_cliente], [serie], [numero], [tipo_comprobante], [igv]) VALUES (11, CAST(N'2025-11-11' AS Date), 1, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[venta] ([id_venta], [fecha], [id_cliente], [serie], [numero], [tipo_comprobante], [igv]) VALUES (13, CAST(N'2025-11-12' AS Date), 2, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[venta] ([id_venta], [fecha], [id_cliente], [serie], [numero], [tipo_comprobante], [igv]) VALUES (14, CAST(N'2025-11-13' AS Date), 2, N'000001', N'000001', N'F', CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[venta] ([id_venta], [fecha], [id_cliente], [serie], [numero], [tipo_comprobante], [igv]) VALUES (15, CAST(N'2025-11-13' AS Date), 5, N'000001', N'000002', N'F', CAST(0.18 AS Decimal(18, 2)))
GO
INSERT [dbo].[venta] ([id_venta], [fecha], [id_cliente], [serie], [numero], [tipo_comprobante], [igv]) VALUES (16, CAST(N'2025-11-13' AS Date), 6, N'000001', N'000003', N'F', CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[venta] ([id_venta], [fecha], [id_cliente], [serie], [numero], [tipo_comprobante], [igv]) VALUES (17, CAST(N'2025-11-13' AS Date), 2, N'000001', N'000001', N'B', CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[venta] ([id_venta], [fecha], [id_cliente], [serie], [numero], [tipo_comprobante], [igv]) VALUES (18, CAST(N'2025-11-13' AS Date), 1, N'000001', N'000004', N'F', CAST(0.18 AS Decimal(18, 2)))
GO
INSERT [dbo].[venta] ([id_venta], [fecha], [id_cliente], [serie], [numero], [tipo_comprobante], [igv]) VALUES (19, CAST(N'2025-11-14' AS Date), 1, N'000001', N'000005', N'F', CAST(0.18 AS Decimal(18, 2)))
GO
INSERT [dbo].[venta] ([id_venta], [fecha], [id_cliente], [serie], [numero], [tipo_comprobante], [igv]) VALUES (20, CAST(N'2025-11-14' AS Date), 1, N'000001', N'000006', N'F', CAST(0.18 AS Decimal(18, 2)))
GO
INSERT [dbo].[venta] ([id_venta], [fecha], [id_cliente], [serie], [numero], [tipo_comprobante], [igv]) VALUES (21, CAST(N'2025-11-14' AS Date), 1, N'000001', N'000007', N'F', CAST(0.18 AS Decimal(18, 2)))
GO
INSERT [dbo].[venta] ([id_venta], [fecha], [id_cliente], [serie], [numero], [tipo_comprobante], [igv]) VALUES (22, CAST(N'2025-11-14' AS Date), 1, N'000001', N'000008', N'F', CAST(0.18 AS Decimal(18, 2)))
GO
INSERT [dbo].[venta] ([id_venta], [fecha], [id_cliente], [serie], [numero], [tipo_comprobante], [igv]) VALUES (23, CAST(N'2025-11-14' AS Date), 1, N'000001', N'000009', N'F', CAST(0.18 AS Decimal(18, 2)))
GO
INSERT [dbo].[venta] ([id_venta], [fecha], [id_cliente], [serie], [numero], [tipo_comprobante], [igv]) VALUES (24, CAST(N'2025-11-14' AS Date), 1, N'000001', N'000010', N'F', CAST(0.18 AS Decimal(18, 2)))
GO
INSERT [dbo].[venta] ([id_venta], [fecha], [id_cliente], [serie], [numero], [tipo_comprobante], [igv]) VALUES (25, CAST(N'2025-11-14' AS Date), 1, N'000001', N'000011', N'F', CAST(0.18 AS Decimal(18, 2)))
GO
INSERT [dbo].[venta] ([id_venta], [fecha], [id_cliente], [serie], [numero], [tipo_comprobante], [igv]) VALUES (26, CAST(N'2025-11-14' AS Date), 2, N'000001', N'000012', N'F', CAST(0.18 AS Decimal(18, 2)))
GO
SET IDENTITY_INSERT [dbo].[venta] OFF
GO
INSERT [dbo].[venta_detalle] ([id_venta], [id_producto], [cantidad], [precio_unitario]) VALUES (5, 1, 1, 10.2500)
GO
INSERT [dbo].[venta_detalle] ([id_venta], [id_producto], [cantidad], [precio_unitario]) VALUES (6, 1, 1, 10.2500)
GO
INSERT [dbo].[venta_detalle] ([id_venta], [id_producto], [cantidad], [precio_unitario]) VALUES (8, 2, 0, 100.1000)
GO
INSERT [dbo].[venta_detalle] ([id_venta], [id_producto], [cantidad], [precio_unitario]) VALUES (8, 3, 100, 1.3000)
GO
INSERT [dbo].[venta_detalle] ([id_venta], [id_producto], [cantidad], [precio_unitario]) VALUES (8, 5, 51, 3.3300)
GO
INSERT [dbo].[venta_detalle] ([id_venta], [id_producto], [cantidad], [precio_unitario]) VALUES (9, 1, 7, 10.2500)
GO
INSERT [dbo].[venta_detalle] ([id_venta], [id_producto], [cantidad], [precio_unitario]) VALUES (9, 2, 25, 100.1000)
GO
INSERT [dbo].[venta_detalle] ([id_venta], [id_producto], [cantidad], [precio_unitario]) VALUES (9, 3, 100, 1.3000)
GO
INSERT [dbo].[venta_detalle] ([id_venta], [id_producto], [cantidad], [precio_unitario]) VALUES (9, 5, 51, 3.3300)
GO
INSERT [dbo].[venta_detalle] ([id_venta], [id_producto], [cantidad], [precio_unitario]) VALUES (10, 2, 26, 100.1000)
GO
INSERT [dbo].[venta_detalle] ([id_venta], [id_producto], [cantidad], [precio_unitario]) VALUES (11, 1, 1, 10.2500)
GO
INSERT [dbo].[venta_detalle] ([id_venta], [id_producto], [cantidad], [precio_unitario]) VALUES (13, 1, 1, 10.2500)
GO
INSERT [dbo].[venta_detalle] ([id_venta], [id_producto], [cantidad], [precio_unitario]) VALUES (13, 2, 1, 100.1000)
GO
INSERT [dbo].[venta_detalle] ([id_venta], [id_producto], [cantidad], [precio_unitario]) VALUES (14, 1, 1, 10.2500)
GO
INSERT [dbo].[venta_detalle] ([id_venta], [id_producto], [cantidad], [precio_unitario]) VALUES (14, 2, 1, 100.1000)
GO
INSERT [dbo].[venta_detalle] ([id_venta], [id_producto], [cantidad], [precio_unitario]) VALUES (15, 3, 1, 1.3000)
GO
INSERT [dbo].[venta_detalle] ([id_venta], [id_producto], [cantidad], [precio_unitario]) VALUES (15, 5, 4, 3.3300)
GO
INSERT [dbo].[venta_detalle] ([id_venta], [id_producto], [cantidad], [precio_unitario]) VALUES (16, 1, 100, 10.2500)
GO
INSERT [dbo].[venta_detalle] ([id_venta], [id_producto], [cantidad], [precio_unitario]) VALUES (16, 2, 100, 100.1000)
GO
INSERT [dbo].[venta_detalle] ([id_venta], [id_producto], [cantidad], [precio_unitario]) VALUES (16, 3, 100, 1.3000)
GO
INSERT [dbo].[venta_detalle] ([id_venta], [id_producto], [cantidad], [precio_unitario]) VALUES (16, 5, 100, 3.3300)
GO
INSERT [dbo].[venta_detalle] ([id_venta], [id_producto], [cantidad], [precio_unitario]) VALUES (17, 3, 100, 1.3000)
GO
INSERT [dbo].[venta_detalle] ([id_venta], [id_producto], [cantidad], [precio_unitario]) VALUES (18, 2, 100, 100.1000)
GO
INSERT [dbo].[venta_detalle] ([id_venta], [id_producto], [cantidad], [precio_unitario]) VALUES (19, 1, 5, 10.2500)
GO
INSERT [dbo].[venta_detalle] ([id_venta], [id_producto], [cantidad], [precio_unitario]) VALUES (19, 2, 10, 100.1000)
GO
INSERT [dbo].[venta_detalle] ([id_venta], [id_producto], [cantidad], [precio_unitario]) VALUES (20, 1, 1, 10.2500)
GO
INSERT [dbo].[venta_detalle] ([id_venta], [id_producto], [cantidad], [precio_unitario]) VALUES (21, 1, 1, 10.2500)
GO
INSERT [dbo].[venta_detalle] ([id_venta], [id_producto], [cantidad], [precio_unitario]) VALUES (22, 1, 1, 10.2500)
GO
INSERT [dbo].[venta_detalle] ([id_venta], [id_producto], [cantidad], [precio_unitario]) VALUES (23, 1, 1, 10.2500)
GO
INSERT [dbo].[venta_detalle] ([id_venta], [id_producto], [cantidad], [precio_unitario]) VALUES (24, 1, 1, 10.2500)
GO
INSERT [dbo].[venta_detalle] ([id_venta], [id_producto], [cantidad], [precio_unitario]) VALUES (25, 1, 100, 10.2500)
GO
INSERT [dbo].[venta_detalle] ([id_venta], [id_producto], [cantidad], [precio_unitario]) VALUES (25, 2, 100, 100.1000)
GO
INSERT [dbo].[venta_detalle] ([id_venta], [id_producto], [cantidad], [precio_unitario]) VALUES (25, 3, 100, 1.3000)
GO
INSERT [dbo].[venta_detalle] ([id_venta], [id_producto], [cantidad], [precio_unitario]) VALUES (25, 5, 100, 3.3300)
GO
INSERT [dbo].[venta_detalle] ([id_venta], [id_producto], [cantidad], [precio_unitario]) VALUES (26, 1, 1, 10.2500)
GO
INSERT [dbo].[venta_detalle] ([id_venta], [id_producto], [cantidad], [precio_unitario]) VALUES (26, 2, 1, 100.1000)
GO
INSERT [dbo].[venta_detalle] ([id_venta], [id_producto], [cantidad], [precio_unitario]) VALUES (26, 3, 1, 1.3000)
GO
INSERT [dbo].[venta_detalle] ([id_venta], [id_producto], [cantidad], [precio_unitario]) VALUES (26, 5, 1, 3.3300)
GO
ALTER TABLE [dbo].[usuario] ADD  CONSTRAINT [DF_usuario_activo]  DEFAULT ((1)) FOR [activo]
GO
ALTER TABLE [dbo].[venta]  WITH CHECK ADD  CONSTRAINT [FK_venta_cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[cliente] ([id_cliente])
GO
ALTER TABLE [dbo].[venta] CHECK CONSTRAINT [FK_venta_cliente]
GO
ALTER TABLE [dbo].[venta_detalle]  WITH CHECK ADD  CONSTRAINT [FK_venta_detalle_producto] FOREIGN KEY([id_producto])
REFERENCES [dbo].[producto] ([id_producto])
GO
ALTER TABLE [dbo].[venta_detalle] CHECK CONSTRAINT [FK_venta_detalle_producto]
GO
ALTER TABLE [dbo].[venta_detalle]  WITH CHECK ADD  CONSTRAINT [FK_venta_detalle_venta] FOREIGN KEY([id_venta])
REFERENCES [dbo].[venta] ([id_venta])
GO
ALTER TABLE [dbo].[venta_detalle] CHECK CONSTRAINT [FK_venta_detalle_venta]
GO
/****** Object:  StoredProcedure [dbo].[sp_cliente_actualizar]    Script Date: 14/11/2025 05:31:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_cliente_actualizar]
	@entidad varchar(100),
	@ruc char(11),
	@direccion varchar(100),
	@contacto varchar(50),
	@correo varchar(50),
	@area varchar(50),
	@telefono varchar(20),
	@observacion varchar(100),
	@ciudad varchar(20),
	@id_cliente smallint
AS
	Update cliente 
	Set
		entidad = @entidad,
		ruc = @ruc,
		direccion = @direccion,
		contacto = @contacto,
		correo = @correo,
		area = @area,
		telefono = @telefono,
		observacion = @observacion,
		ciudad = @ciudad
	Where 
		id_cliente = @id_cliente
GO
/****** Object:  StoredProcedure [dbo].[sp_cliente_buscar_por_entidad]    Script Date: 14/11/2025 05:31:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_cliente_buscar_por_entidad]
	@entidad varchar(100)
AS
BEGIN
	SELECT id_cliente, entidad, ruc from cliente where entidad like CONCAT('%', @entidad, '%')
END
GO
/****** Object:  StoredProcedure [dbo].[sp_cliente_buscar_por_id]    Script Date: 14/11/2025 05:31:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_cliente_buscar_por_id]
	@id_cliente smallint
AS
BEGIN
	SELECT * from cliente
	Where id_cliente = @id_cliente
END
GO
/****** Object:  StoredProcedure [dbo].[sp_cliente_eliminar]    Script Date: 14/11/2025 05:31:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_cliente_eliminar]
	@id_cliente int
AS
	Delete from cliente
	Where id_cliente = @id_cliente
GO
/****** Object:  StoredProcedure [dbo].[sp_cliente_insertar]    Script Date: 14/11/2025 05:31:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_cliente_insertar]
	@entidad varchar(100),
	@ruc char(11),
	@direccion varchar(100),
	@contacto varchar(50),
	@correo varchar(50),
	@area varchar(50),
	@telefono varchar(20),
	@observacion varchar(100),
	@ciudad varchar(20),
	@id_cliente smallint out
AS
	Insert into cliente 
	(
		entidad,
		ruc,
		direccion,
		contacto,
		correo,
		area,
		telefono,
		observacion,
		ciudad
	)
	Values
	(
		@entidad,
		@ruc,
		@direccion,
		@contacto,
		@correo,
		@area,
		@telefono,
		@observacion,
		@ciudad
	)
	Set @id_cliente = SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[sp_producto_buscar_por_descripcion]    Script Date: 14/11/2025 05:31:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_producto_buscar_por_descripcion]
	@cadena varchar(100)
AS
BEGIN
	Select id_producto, descripcion, precio_unitario from producto
	Where descripcion Like CONCAT('%', @cadena, '%')
END
GO
/****** Object:  StoredProcedure [dbo].[sp_producto_buscar_por_id]    Script Date: 14/11/2025 05:31:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_producto_buscar_por_id]
AS
BEGIN
	Select * from producto
END
GO
/****** Object:  StoredProcedure [dbo].[sp_usuario_actualizar_clave]    Script Date: 14/11/2025 05:31:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_usuario_actualizar_clave]
	@clave varchar(100),
	@id_usuario int
AS
BEGIN
	Update usuario
	Set 
		clave = @clave
	Where
		id_usuario = @id_usuario
END
GO
/****** Object:  StoredProcedure [dbo].[sp_usuario_buscar_por_dni]    Script Date: 14/11/2025 05:31:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_usuario_buscar_por_dni]
	@dni varchar(8)
AS
BEGIN
	SELECT id_usuario, dni, clave, rol, apellidos_nombres
	FROM usuario
	WHERE usuario.dni = @dni and usuario.activo = 1
END
GO
/****** Object:  StoredProcedure [dbo].[sp_usuario_buscar_por_id]    Script Date: 14/11/2025 05:31:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_usuario_buscar_por_id]
	@id_usuario int
AS
BEGIN
	SELECT dni, clave, rol, apellidos_nombres
	From usuario
	Where id_usuario = @id_usuario and activo = 1
END
GO
/****** Object:  StoredProcedure [dbo].[sp_usuario_insertar]    Script Date: 14/11/2025 05:31:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_usuario_insertar]
	@dni char(8),
	@clave varchar(100),
	@rol varchar(20),
	@apellidos_nombres varchar(60),
	@id_usuario int out
AS
BEGIN
	Insert into Usuario 
	(
		dni,
		clave,
		rol,
		apellidos_nombres
	)
	Values
	(
		@dni,
		@clave,
		@rol,
		@apellidos_nombres
	)
	Set @id_usuario = SCOPE_IDENTITY()
END
GO
/****** Object:  StoredProcedure [dbo].[sp_venta_detalle_insertar]    Script Date: 14/11/2025 05:31:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_venta_detalle_insertar]
	@id_venta int,
	@id_producto int,
	@cantidad int,
	@precio_unitario money
AS
BEGIN
	Insert into venta_detalle (id_venta, id_producto, cantidad, precio_unitario) 
	Values (@id_venta, @id_producto, @cantidad, @precio_unitario)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_venta_generar_serie_numero_comprobante]    Script Date: 14/11/2025 05:31:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_venta_generar_serie_numero_comprobante]
    @tipo_comprobante CHAR(1)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @maximo_serie INT;
    DECLARE @maximo_numero INT;

    -- obtener la máxima serie (interpretada como entero) para el tipo dado
    SELECT TOP (1) @maximo_serie = TRY_CONVERT(INT, serie)
    FROM Venta
    WHERE tipo_comprobante = @tipo_comprobante
      AND TRY_CONVERT(INT, serie) IS NOT NULL
    ORDER BY TRY_CONVERT(INT, serie) DESC;

    IF @maximo_serie IS NULL
    BEGIN
        SET @maximo_serie = 0;
    END

    -- sobre esa serie, obtener el máximo número (interpretado como entero)
    SELECT @maximo_numero = ISNULL(
        MAX(TRY_CONVERT(INT, numero)), 0)
    FROM Venta
    WHERE tipo_comprobante = @tipo_comprobante
      AND TRY_CONVERT(INT, serie) = @maximo_serie
      AND TRY_CONVERT(INT, numero) IS NOT NULL;

    SELECT @maximo_numero AS maximo_numero, @maximo_serie AS maximo_serie;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_venta_generar_serie_numero_comprobante_SegunElVideo]    Script Date: 14/11/2025 05:31:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[sp_venta_generar_serie_numero_comprobante_SegunElVideo]
	@tipo_comprobante char(1)
AS
BEGIN
	Select 
		ISNULL(max(convert(int, numero)), 0) As maximo_numero,
		ISNULL(max(convert(int, serie)), 0) As maximo_serie
	From 
		Venta
	Where 
		serie = 
		(
			Select max(convert(int, serie))
			From venta
			Where tipo_comprobante = @tipo_comprobante
		)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_venta_insertar]    Script Date: 14/11/2025 05:31:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_venta_insertar]
	@fecha	date,
	@id_cliente smallint,
	@serie varchar(6),
	@numero varchar(6),
	@tipo_comprobante char(1),
	@igv decimal(18,2),
	@id_venta int out
AS
BEGIN
	Insert into venta (fecha, id_cliente, serie, numero, tipo_comprobante, igv) 
	Values (@fecha, @id_cliente, @serie, @numero, @tipo_comprobante, @igv)
	Set @id_venta = SCOPE_IDENTITY()
END
GO
USE [master]
GO
ALTER DATABASE [VentasCapas] SET  READ_WRITE 
GO
