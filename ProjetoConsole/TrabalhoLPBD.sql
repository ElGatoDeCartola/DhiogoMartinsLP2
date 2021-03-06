USE [master]
GO
/****** Object:  Database [LPBD]    Script Date: 06/02/2018 15:20:21 ******/
CREATE DATABASE [LPBD]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LPBD', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\LPBD.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'LPBD_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\LPBD_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [LPBD] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LPBD].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LPBD] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LPBD] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LPBD] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LPBD] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LPBD] SET ARITHABORT OFF 
GO
ALTER DATABASE [LPBD] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LPBD] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LPBD] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LPBD] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LPBD] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LPBD] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LPBD] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LPBD] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LPBD] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LPBD] SET  DISABLE_BROKER 
GO
ALTER DATABASE [LPBD] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LPBD] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LPBD] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LPBD] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LPBD] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LPBD] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LPBD] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LPBD] SET RECOVERY FULL 
GO
ALTER DATABASE [LPBD] SET  MULTI_USER 
GO
ALTER DATABASE [LPBD] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LPBD] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LPBD] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LPBD] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [LPBD] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'LPBD', N'ON'
GO
USE [LPBD]
GO
/****** Object:  Table [dbo].[Carro]    Script Date: 06/02/2018 15:20:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carro](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Modelo] [nvarchar](50) NULL,
	[Potencia] [int] NULL,
	[Marca] [nvarchar](50) NULL,
	[Cor] [nvarchar](50) NULL,
	[Preço] [int] NULL,
	[Porta] [int] NULL,
	[Cambio] [nvarchar](50) NULL,
	[Traçao] [nvarchar](50) NULL,
	[Quilometro] [int] NULL,
 CONSTRAINT [PK_Carro] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Funcionario]    Script Date: 06/02/2018 15:20:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Funcionario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](50) NULL,
	[Cpf] [nvarchar](50) NULL,
	[Endereço] [nvarchar](50) NULL,
	[Sexo] [nvarchar](50) NULL,
	[Salario] [int] NULL,
 CONSTRAINT [PK_Funcionario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Vendas]    Script Date: 06/02/2018 15:20:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vendas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Modelo] [nvarchar](50) NULL,
	[Potencia] [int] NULL,
	[Marca] [nvarchar](50) NULL,
	[Cor] [nvarchar](50) NULL,
	[Preço] [int] NULL,
	[Porta] [int] NULL,
	[Cambio] [nvarchar](50) NULL,
	[Traçao] [nvarchar](50) NULL,
	[Quilometro] [int] NULL,
 CONSTRAINT [PK_Vendas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Carro] ON 

INSERT [dbo].[Carro] ([Id], [Modelo], [Potencia], [Marca], [Cor], [Preço], [Porta], [Cambio], [Traçao], [Quilometro]) VALUES (1, N'Focus', 100, N'Ford', N'Azul', 16800, 4, N'Manual', N'Traseir', 90)
INSERT [dbo].[Carro] ([Id], [Modelo], [Potencia], [Marca], [Cor], [Preço], [Porta], [Cambio], [Traçao], [Quilometro]) VALUES (2, N'Hilux', 300, N'Toyota', N'Preto', 90000, 4, N'Automatico', N'4x4', 10000)
INSERT [dbo].[Carro] ([Id], [Modelo], [Potencia], [Marca], [Cor], [Preço], [Porta], [Cambio], [Traçao], [Quilometro]) VALUES (3, N'Model S 70D', 500, N'Tesla', N'Prata', 700000, 4, N'Automatico', N'Traseiro', 0)
INSERT [dbo].[Carro] ([Id], [Modelo], [Potencia], [Marca], [Cor], [Preço], [Porta], [Cambio], [Traçao], [Quilometro]) VALUES (4, N'Cayman S', 500, N'Porsche', N'Amarelo', 300000, 2, N'Automatico', N'Traseiro', 0)
INSERT [dbo].[Carro] ([Id], [Modelo], [Potencia], [Marca], [Cor], [Preço], [Porta], [Cambio], [Traçao], [Quilometro]) VALUES (5, N'Mustang', 400, N'Ford', N'Azul', 320000, 2, N'Automatico', N'Traseiro', 0)
INSERT [dbo].[Carro] ([Id], [Modelo], [Potencia], [Marca], [Cor], [Preço], [Porta], [Cambio], [Traçao], [Quilometro]) VALUES (6, N'Range Rover Evoqe', 300, N'Land Rover', N'Preto', 150000, 4, N'Automatico', N'4x4', 20000)
INSERT [dbo].[Carro] ([Id], [Modelo], [Potencia], [Marca], [Cor], [Preço], [Porta], [Cambio], [Traçao], [Quilometro]) VALUES (7, N'Onix', 200, N'Chevrolet', N'Vermelho', 50000, 4, N'Automatico', N'4x4', 30000)
INSERT [dbo].[Carro] ([Id], [Modelo], [Potencia], [Marca], [Cor], [Preço], [Porta], [Cambio], [Traçao], [Quilometro]) VALUES (8, N'Gol', 130, N'Volkswagen', N'Preto', 15000, 2, N'Manual', N'Traseiro', 120000)
INSERT [dbo].[Carro] ([Id], [Modelo], [Potencia], [Marca], [Cor], [Preço], [Porta], [Cambio], [Traçao], [Quilometro]) VALUES (9, N'Uno', 100, N'Fiat', N'Branco', 20000, 4, N'Manual', N'Traseiro', 230000)
INSERT [dbo].[Carro] ([Id], [Modelo], [Potencia], [Marca], [Cor], [Preço], [Porta], [Cambio], [Traçao], [Quilometro]) VALUES (10, N'Chevette', 100, N'Chevrolet', N'Marrom', 10000, 4, N'Manual', N'Traseiro', 130400)
INSERT [dbo].[Carro] ([Id], [Modelo], [Potencia], [Marca], [Cor], [Preço], [Porta], [Cambio], [Traçao], [Quilometro]) VALUES (11, N'Aventador', 700, N'Lamborghini', N'Laranja', 37000000, 2, N'Automatico', N'Traseiro', 0)
INSERT [dbo].[Carro] ([Id], [Modelo], [Potencia], [Marca], [Cor], [Preço], [Porta], [Cambio], [Traçao], [Quilometro]) VALUES (12, N'Fusca', 80, N'Volkswagen', N'Branco', 10000, 2, N'Manual', N'Traseiro', 140540)
INSERT [dbo].[Carro] ([Id], [Modelo], [Potencia], [Marca], [Cor], [Preço], [Porta], [Cambio], [Traçao], [Quilometro]) VALUES (13, N'Renegade', 300, N'Jeep', N'Branco', 70000, 4, N'Automatico', N'4x4', 0)
INSERT [dbo].[Carro] ([Id], [Modelo], [Potencia], [Marca], [Cor], [Preço], [Porta], [Cambio], [Traçao], [Quilometro]) VALUES (14, N'458 Italia', 650, N'Ferrari', N'Vermelho', 1300000, 2, N'Automatico', N'Traseiro', 0)
INSERT [dbo].[Carro] ([Id], [Modelo], [Potencia], [Marca], [Cor], [Preço], [Porta], [Cambio], [Traçao], [Quilometro]) VALUES (15, N'Palio', 130, N'Fiat', N'Prata', 17900, 4, N'Manual', N'Traseiro', 90000)
SET IDENTITY_INSERT [dbo].[Carro] OFF
SET IDENTITY_INSERT [dbo].[Funcionario] ON 

INSERT [dbo].[Funcionario] ([Id], [Nome], [Cpf], [Endereço], [Sexo], [Salario]) VALUES (3, N'Igor Rodrigues', N'123455676', N'Beira da praia', N'M', 90000000)
INSERT [dbo].[Funcionario] ([Id], [Nome], [Cpf], [Endereço], [Sexo], [Salario]) VALUES (4, N'Rafael Cezar', N'987654321', N'Disney World', N'M', 3000000)
INSERT [dbo].[Funcionario] ([Id], [Nome], [Cpf], [Endereço], [Sexo], [Salario]) VALUES (5, N'Dhiogo Martins', N'3324323435', N'Palacio do Planalto', N'M', 12000000)
INSERT [dbo].[Funcionario] ([Id], [Nome], [Cpf], [Endereço], [Sexo], [Salario]) VALUES (6, N'Dhiego Martins', N'12345678900', N'Rua de Curicica', N'G', 0)
INSERT [dbo].[Funcionario] ([Id], [Nome], [Cpf], [Endereço], [Sexo], [Salario]) VALUES (7, N'Fracesco Ve Ana', N'53245125512', N'CPII', N'M', 200)
SET IDENTITY_INSERT [dbo].[Funcionario] OFF
USE [master]
GO
ALTER DATABASE [LPBD] SET  READ_WRITE 
GO
