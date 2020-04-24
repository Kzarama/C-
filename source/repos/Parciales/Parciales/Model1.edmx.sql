
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/20/2019 16:35:37
-- Generated from EDMX file: C:\Users\zaram\source\repos\Parciales\Parciales\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Parciales];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_EstudianteParcial]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Parciales] DROP CONSTRAINT [FK_EstudianteParcial];
GO
IF OBJECT_ID(N'[dbo].[FK_ParcialCurso]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Parciales] DROP CONSTRAINT [FK_ParcialCurso];
GO
IF OBJECT_ID(N'[dbo].[FK_CursoMateria]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Cursos] DROP CONSTRAINT [FK_CursoMateria];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Estudiantes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Estudiantes];
GO
IF OBJECT_ID(N'[dbo].[Parciales]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Parciales];
GO
IF OBJECT_ID(N'[dbo].[Cursos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cursos];
GO
IF OBJECT_ID(N'[dbo].[Materias]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Materias];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Estudiantes'
CREATE TABLE [dbo].[Estudiantes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Parciales'
CREATE TABLE [dbo].[Parciales] (
    [Numero] int  NOT NULL,
    [Nota] float  NOT NULL,
    [EstudianteId] int  NOT NULL,
    [CursoMateriaId] int  NOT NULL,
    [CursoGrupo] int  NOT NULL,
    [CursoAñoSem] int  NOT NULL
);
GO

-- Creating table 'Cursos'
CREATE TABLE [dbo].[Cursos] (
    [Grupo] int  NOT NULL,
    [AñoSem] int  NOT NULL,
    [MateriaId] int  NOT NULL
);
GO

-- Creating table 'Materias'
CREATE TABLE [dbo].[Materias] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Estudiantes'
ALTER TABLE [dbo].[Estudiantes]
ADD CONSTRAINT [PK_Estudiantes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Numero], [EstudianteId], [CursoMateriaId], [CursoGrupo], [CursoAñoSem] in table 'Parciales'
ALTER TABLE [dbo].[Parciales]
ADD CONSTRAINT [PK_Parciales]
    PRIMARY KEY CLUSTERED ([Numero], [EstudianteId], [CursoMateriaId], [CursoGrupo], [CursoAñoSem] ASC);
GO

-- Creating primary key on [Grupo], [AñoSem] in table 'Cursos'
ALTER TABLE [dbo].[Cursos]
ADD CONSTRAINT [PK_Cursos]
    PRIMARY KEY CLUSTERED ([Grupo], [AñoSem] ASC);
GO

-- Creating primary key on [Id] in table 'Materias'
ALTER TABLE [dbo].[Materias]
ADD CONSTRAINT [PK_Materias]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [EstudianteId] in table 'Parciales'
ALTER TABLE [dbo].[Parciales]
ADD CONSTRAINT [FK_EstudianteParcial]
    FOREIGN KEY ([EstudianteId])
    REFERENCES [dbo].[Estudiantes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EstudianteParcial'
CREATE INDEX [IX_FK_EstudianteParcial]
ON [dbo].[Parciales]
    ([EstudianteId]);
GO

-- Creating foreign key on [CursoGrupo], [CursoAñoSem] in table 'Parciales'
ALTER TABLE [dbo].[Parciales]
ADD CONSTRAINT [FK_ParcialCurso]
    FOREIGN KEY ([CursoGrupo], [CursoAñoSem])
    REFERENCES [dbo].[Cursos]
        ([Grupo], [AñoSem])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ParcialCurso'
CREATE INDEX [IX_FK_ParcialCurso]
ON [dbo].[Parciales]
    ([CursoGrupo], [CursoAñoSem]);
GO

-- Creating foreign key on [MateriaId] in table 'Cursos'
ALTER TABLE [dbo].[Cursos]
ADD CONSTRAINT [FK_CursoMateria]
    FOREIGN KEY ([MateriaId])
    REFERENCES [dbo].[Materias]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CursoMateria'
CREATE INDEX [IX_FK_CursoMateria]
ON [dbo].[Cursos]
    ([MateriaId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------