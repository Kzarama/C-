
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/08/2019 17:09:21
-- Generated from EDMX file: C:\Users\zaram\source\repos\proyec\proyec\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [muchos];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Estudiantes'
CREATE TABLE [dbo].[Estudiantes] (
    [CodEst] int IDENTITY(1,1) NOT NULL,
    [NomEst] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Materias'
CREATE TABLE [dbo].[Materias] (
    [CodMax] int IDENTITY(1,1) NOT NULL,
    [NomMat] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'EstudianteMaterias'
CREATE TABLE [dbo].[EstudianteMaterias] (
    [Estudiantes_CodEst] int  NOT NULL,
    [Materias_CodMax] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [CodEst] in table 'Estudiantes'
ALTER TABLE [dbo].[Estudiantes]
ADD CONSTRAINT [PK_Estudiantes]
    PRIMARY KEY CLUSTERED ([CodEst] ASC);
GO

-- Creating primary key on [CodMax] in table 'Materias'
ALTER TABLE [dbo].[Materias]
ADD CONSTRAINT [PK_Materias]
    PRIMARY KEY CLUSTERED ([CodMax] ASC);
GO

-- Creating primary key on [Estudiantes_CodEst], [Materias_CodMax] in table 'EstudianteMaterias'
ALTER TABLE [dbo].[EstudianteMaterias]
ADD CONSTRAINT [PK_EstudianteMaterias]
    PRIMARY KEY CLUSTERED ([Estudiantes_CodEst], [Materias_CodMax] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Estudiantes_CodEst] in table 'EstudianteMaterias'
ALTER TABLE [dbo].[EstudianteMaterias]
ADD CONSTRAINT [FK_EstudianteMaterias_Estudiante]
    FOREIGN KEY ([Estudiantes_CodEst])
    REFERENCES [dbo].[Estudiantes]
        ([CodEst])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Materias_CodMax] in table 'EstudianteMaterias'
ALTER TABLE [dbo].[EstudianteMaterias]
ADD CONSTRAINT [FK_EstudianteMaterias_Materias]
    FOREIGN KEY ([Materias_CodMax])
    REFERENCES [dbo].[Materias]
        ([CodMax])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EstudianteMaterias_Materias'
CREATE INDEX [IX_FK_EstudianteMaterias_Materias]
ON [dbo].[EstudianteMaterias]
    ([Materias_CodMax]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------