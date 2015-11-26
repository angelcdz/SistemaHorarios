USE [master]
GO

/****** Object:  Database [BDHORARIOS]    Script Date: 30/04/2015 15:23:41 ******/
CREATE DATABASE [BDHORARIOS]
 CONTAINMENT = NONE

ALTER DATABASE [BDHORARIOS] SET COMPATIBILITY_LEVEL = 120
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BDHORARIOS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [BDHORARIOS] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [BDHORARIOS] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [BDHORARIOS] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [BDHORARIOS] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [BDHORARIOS] SET ARITHABORT OFF 
GO

ALTER DATABASE [BDHORARIOS] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [BDHORARIOS] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [BDHORARIOS] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [BDHORARIOS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [BDHORARIOS] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [BDHORARIOS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [BDHORARIOS] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [BDHORARIOS] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [BDHORARIOS] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [BDHORARIOS] SET  DISABLE_BROKER 
GO

ALTER DATABASE [BDHORARIOS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [BDHORARIOS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [BDHORARIOS] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [BDHORARIOS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [BDHORARIOS] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [BDHORARIOS] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [BDHORARIOS] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [BDHORARIOS] SET RECOVERY FULL 
GO

ALTER DATABASE [BDHORARIOS] SET  MULTI_USER 
GO

ALTER DATABASE [BDHORARIOS] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [BDHORARIOS] SET DB_CHAINING OFF 
GO

ALTER DATABASE [BDHORARIOS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [BDHORARIOS] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [BDHORARIOS] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [BDHORARIOS] SET  READ_WRITE 
GO

USE BDHORARIOS
GO

CREATE TABLE MATERIA(
COD_MATERIA INT IDENTITY PRIMARY KEY,
NOME_MATERIA VARCHAR(50) NOT NULL
)
GO

CREATE TABLE PERIODO(
COD_PERIODO INT IDENTITY PRIMARY KEY,
NOME_PERIODO VARCHAR(20) NOT NULL
)
GO

CREATE TABLE CURSO(
COD_CURSO INT IDENTITY PRIMARY KEY,
NOME_CURSO VARCHAR(50) NOT NULL,
COD_PERIODO INT FOREIGN KEY REFERENCES PERIODO(COD_PERIODO)
)
GO

CREATE TABLE PROFESSOR(
COD_PROFESSOR INT IDENTITY PRIMARY KEY,
NOME_PROFESSOR VARCHAR(50) NOT NULL
)
GO

CREATE TABLE SEMESTRE(
COD_SEMESTRE INT IDENTITY PRIMARY KEY,
NUM_SEMESTRE INT NOT NULL
)

CREATE TABLE COMPOSICAO_CURSO(
COD_COMP_CURSO INT IDENTITY PRIMARY KEY,
COD_SEMESTRE INT FOREIGN KEY REFERENCES SEMESTRE(COD_SEMESTRE),
COD_CURSO INT FOREIGN KEY REFERENCES CURSO(COD_CURSO),
COD_MATERIA INT  FOREIGN KEY REFERENCES MATERIA(COD_MATERIA),
COD_PROFESSOR INT  FOREIGN KEY REFERENCES PROFESSOR(COD_PROFESSOR)
)
GO

CREATE TABLE DIA_SEMANA(
COD_DIA INT IDENTITY PRIMARY KEY,
NOME_DIA VARCHAR(50) NOT NULL,
)
GO

CREATE TABLE HORARIO(
COD_HORARIO INT IDENTITY PRIMARY KEY,
HORA_INICIAL TIME NOT NULL,
HORA_FINAL TIME NOT NULL,
COD_PERIODO INT FOREIGN KEY REFERENCES PERIODO(COD_PERIODO),
COD_DIA INT FOREIGN KEY REFERENCES DIA_SEMANA(COD_DIA)
)
GO

CREATE TABLE COMPOSICAO_HORARIO(
COD_COMP_HOR INT IDENTITY PRIMARY KEY,
COD_COMP_CURSO INT FOREIGN KEY REFERENCES COMPOSICAO_CURSO(COD_COMP_CURSO),
COD_HORARIO INT FOREIGN KEY REFERENCES HORARIO(COD_HORARIO)
)
GO

CREATE TABLE NIVEL_ACESSO(
COD_NIVEL INT IDENTITY PRIMARY KEY,
DESCRICAO VARCHAR(50),
CONSULTA BIT,
CADASTRO BIT,
ADMINISTRADOR BIT,
)
GO

CREATE TABLE USUARIO(
COD_USUARIO INT IDENTITY PRIMARY KEY,
LOGIN VARCHAR(20),
SENHA VARCHAR(50),
ULT_LOGIN DATETIME2,
NIVEL_ACESSO INT FOREIGN KEY REFERENCES NIVEL_ACESSO(COD_NIVEL)
)
GO

--Excluir todas as tabelas do BD
--EXEC sp_MSforeachtable 'drop table [?]'

--DROP TABLE USUARIO
--GO
--DROP TABLE NIVEL_ACESSO
--GO
--DROP TABLE COMPOSICAO_HORARIO
--GO
--DROP TABLE HORARIO
--GO
--DROP TABLE DIA_SEMANA
--GO
--DROP TABLE COMPOSICAO_CURSO
--GO
--DROP TABLE SEMESTRE
--GO
--DROP TABLE PROFESSOR
--GO
--DROP TABLE CURSO
--GO
--DROP TABLE PERIODO
--GO
--DROP TABLE MATERIA
--GO

INSERT INTO USUARIO(LOGIN,SENHA,ULT_LOGIN)
VALUES('angel','123456',DATETIMEFROMPARTS(2015,1,1,0,0,0,0))
INSERT INTO USUARIO(LOGIN,SENHA,ULT_LOGIN)
VALUES('amanda','123456',DATETIMEFROMPARTS(2015,2,2,0,0,0,0))
INSERT INTO USUARIO(LOGIN,SENHA,ULT_LOGIN)
VALUES('joselito','123456',DATETIMEFROMPARTS(2015,3,3,0,0,0,0))
INSERT INTO USUARIO(LOGIN,SENHA,ULT_LOGIN)
VALUES('bo�a','123456',DATETIMEFROMPARTS(2015,4,4,0,0,0,0))

INSERT INTO NIVEL_ACESSO(DESCRICAO, CONSULTA, CADASTRO, ADMINISTRADOR)
VALUES('ADMINISTRADOR', 1, 1, 1)
INSERT INTO NIVEL_ACESSO(DESCRICAO, CONSULTA, CADASTRO, ADMINISTRADOR)
VALUES('CONSULTAS', 1, 0, 0)
INSERT INTO NIVEL_ACESSO(DESCRICAO, CONSULTA, CADASTRO, ADMINISTRADOR)
VALUES('CADASTROS', 1, 1, 0)

UPDATE USUARIO SET NIVEL_ACESSO = 1 WHERE LOGIN = 'angel'
UPDATE USUARIO SET NIVEL_ACESSO = 1 WHERE LOGIN = 'amanda'
UPDATE USUARIO SET NIVEL_ACESSO = 2 WHERE LOGIN = 'joselito'
UPDATE USUARIO SET NIVEL_ACESSO = 3 WHERE LOGIN = 'bo�a'

INSERT INTO SEMESTRE
VALUES(1),(2),(3),(4),(5),(6)

INSERT INTO PERIODO
VALUES('MATUTINO'),('VESPERTINO'),('NOTURNO'),('EAD')

INSERT INTO MATERIA
VALUES('ORIENTA��O A OBJETOS'),('REDES DE COMPUTADORES'),('LINGUAGEM DE PROGRAMA��O'),('�LGEBRA BOLEANA'),('ENGENHARIA DE SOFTWARE I'),('ENGENHARIA DE SOFTWARE II'),('ENGENHARIA DE SOFTWARE III')

INSERT INTO DIA_SEMANA
VALUES('SEGUNDA-FEIRA'),
		('TER�A-FEIRA'),
		('QUARTA-FEIRA'),
		('QUINTA-FEIRA'),
		('SEXTA-FEIRA'),
		('S�BADO')


DECLARE @idDia INT
DECLARE melpal CURSOR FOR SELECT COD_DIA FROM DIA_SEMANA

OPEN melpal
FETCH NEXT FROM melpal INTO @idDia

WHILE @@FETCH_STATUS = 0
BEGIN

INSERT INTO HORARIO
VALUES(TIMEFROMPARTS(7,0,0,0,0),TIMEFROMPARTS(7,50,0,0,0),1,@idDia),
	  (TIMEFROMPARTS(7,50,0,0,0),TIMEFROMPARTS(8,40,0,0,0),1,@idDia),
	  (TIMEFROMPARTS(9,0,0,0,0),TIMEFROMPARTS(9,50,0,0,0),1,@idDia),
	  (TIMEFROMPARTS(9,50,0,0,0),TIMEFROMPARTS(10,40,0,0,0),1,@idDia),
	  (TIMEFROMPARTS(10,40,0,0,0),TIMEFROMPARTS(11,30,0,0,0),1,@idDia),
	  (TIMEFROMPARTS(11,30,0,0,0),TIMEFROMPARTS(12,20,0,0,0),1,@idDia),
	  (TIMEFROMPARTS(12,20,0,0,0),TIMEFROMPARTS(13,10,0,0,0),1,@idDia),
	  (TIMEFROMPARTS(13,20,0,0,0),TIMEFROMPARTS(14,10,0,0,0),2,@idDia),
	  (TIMEFROMPARTS(14,10,0,0,0),TIMEFROMPARTS(15,0,0,0,0),2,@idDia),
	  (TIMEFROMPARTS(15,0,0,0,0),TIMEFROMPARTS(15,50,0,0,0),2,@idDia),
	  (TIMEFROMPARTS(15,50,0,0,0),TIMEFROMPARTS(16,40,0,0,0),2,@idDia),
	  (TIMEFROMPARTS(16,50,0,0,0),TIMEFROMPARTS(17,40,0,0,0),2,@idDia),
	  (TIMEFROMPARTS(17,40,0,0,0),TIMEFROMPARTS(18,30,0,0,0),2,@idDia),
	  (TIMEFROMPARTS(19,0,0,0,0),TIMEFROMPARTS(19,50,0,0,0),3,@idDia),
	  (TIMEFROMPARTS(19,50,0,0,0),TIMEFROMPARTS(20,40,0,0,0),3,@idDia),
	  (TIMEFROMPARTS(20,50,0,0,0),TIMEFROMPARTS(21,40,0,0,0),3,@idDia),
	  (TIMEFROMPARTS(21,40,0,0,0),TIMEFROMPARTS(22,30,0,0,0),3,@idDia)

FETCH NEXT FROM melpal INTO @idDia
END

CLOSE melpal
DEALLOCATE melpal

INSERT INTO CURSO
VALUES('AN�LISE E DESENVOLVIMENTO DE SISTEMAS', 1),
	  ('AN�LISE E DESENVOLVIMENTO DE SISTEMAS', 3),
	  ('LOG�STICA', 1),
	  ('LOG�STICA', 3),
	  ('SISTEMAS PARA INTERNET', 2),
	  ('GEST�O EMPRESARIAL', 4),
	  ('GEST�O PORTU�RIA', 3)

CREATE TABLE LOG_EVENTS
(
	TRANSACTION_ID VARCHAR(36),
	OPERATION_NAME VARCHAR(200),
	TRANSACTION_STATUS VARCHAR(50),
	TRANSACTION_DATE DATETIME,
	ERROR_MESSAGE VARCHAR(500)
)
CREATE TABLE LOG_DETAILS
(
	TRANSACTION_ID VARCHAR(36),
	REQUEST_PARAMETER_NAME VARCHAR(100),
	REQUEST_PARAMETER_VALUE VARCHAR(200)
)