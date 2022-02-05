
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/25/2016 22:12:01
-- Generated from EDMX file: C:\Users\vinic\Desktop\ProjetoUniversidade\ProjetoUniversidade\Models\Modelo.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [BancoUniversidade];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_AlunoAluno_Turma]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Aluno_Turma] DROP CONSTRAINT [FK_AlunoAluno_Turma];
GO
IF OBJECT_ID(N'[dbo].[FK_CursoDisciplina]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Disciplina] DROP CONSTRAINT [FK_CursoDisciplina];
GO
IF OBJECT_ID(N'[dbo].[FK_DisciplinaTurma]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Turma] DROP CONSTRAINT [FK_DisciplinaTurma];
GO
IF OBJECT_ID(N'[dbo].[FK_ProfessorTurma]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Turma] DROP CONSTRAINT [FK_ProfessorTurma];
GO
IF OBJECT_ID(N'[dbo].[FK_TurmaAluno_Turma]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Aluno_Turma] DROP CONSTRAINT [FK_TurmaAluno_Turma];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Administrador]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Administrador];
GO
IF OBJECT_ID(N'[dbo].[Aluno]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Aluno];
GO
IF OBJECT_ID(N'[dbo].[Aluno_Turma]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Aluno_Turma];
GO
IF OBJECT_ID(N'[dbo].[Curso]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Curso];
GO
IF OBJECT_ID(N'[dbo].[Disciplina]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Disciplina];
GO
IF OBJECT_ID(N'[dbo].[Professor]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Professor];
GO
IF OBJECT_ID(N'[dbo].[Turma]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Turma];
GO
IF OBJECT_ID(N'[dbo].[Turno]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Turno];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Administrador'
CREATE TABLE [dbo].[Administrador] (
    [IdAdministrador] int IDENTITY(1,1) NOT NULL,
    [login] nvarchar(max)  NOT NULL,
    [senha] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Aluno'
CREATE TABLE [dbo].[Aluno] (
    [IdAluno] int IDENTITY(1,1) NOT NULL,
    [nomeAluno] nvarchar(max)  NOT NULL,
    [matriculaAluno] nvarchar(max)  NOT NULL,
    [cpfAluno] nvarchar(max)  NOT NULL,
    [telefoneAluno] nvarchar(max)  NOT NULL,
    [emailAluno] nvarchar(max)  NOT NULL,
    [senhaAluno] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Aluno_Turma'
CREATE TABLE [dbo].[Aluno_Turma] (
    [IdAluno_Turma] int IDENTITY(1,1) NOT NULL,
    [IdTurma] int  NOT NULL,
    [IdAluno] int  NOT NULL,
    [media] decimal(18,0)  NOT NULL,
    [faltas] int  NOT NULL
);
GO

-- Creating table 'Curso'
CREATE TABLE [dbo].[Curso] (
    [IdCurso] int IDENTITY(1,1) NOT NULL,
    [nomeCurso] nvarchar(max)  NOT NULL,
    [duracao] int  NOT NULL,
    [modalidade] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Disciplina'
CREATE TABLE [dbo].[Disciplina] (
    [IdDisciplina] int IDENTITY(1,1) NOT NULL,
    [nomeDisciplina] nvarchar(max)  NOT NULL,
    [codigoDisciplina] nvarchar(max)  NOT NULL,
    [numeroAulas] int  NOT NULL,
    [periodo] int  NOT NULL,
    [IdCurso] int  NOT NULL
);
GO

-- Creating table 'Professor'
CREATE TABLE [dbo].[Professor] (
    [IdProfessor] int IDENTITY(1,1) NOT NULL,
    [nomeProfessor] nvarchar(max)  NOT NULL,
    [matriculaProfessor] nvarchar(max)  NOT NULL,
    [cpfProfessor] nvarchar(max)  NOT NULL,
    [formacao] nvarchar(max)  NOT NULL,
    [telefoneProfessor] nvarchar(max)  NOT NULL,
    [emailProfessor] nvarchar(max)  NOT NULL,
    [senhaProfessor] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Turma'
CREATE TABLE [dbo].[Turma] (
    [IdTurma] int IDENTITY(1,1) NOT NULL,
    [codigoTurma] nvarchar(max)  NOT NULL,
    [IdDisciplina] int  NOT NULL,
    [IdProfessor] int  NOT NULL,
    [DiaSemana] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Turno'
CREATE TABLE [dbo].[Turno] (
    [IdTurno] int IDENTITY(1,1) NOT NULL,
    [descricaoTurno] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'CursoTurno1'
CREATE TABLE [dbo].[CursoTurno1] (
    [Curso_IdCurso] int  NOT NULL,
    [Turno_IdTurno] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdAdministrador] in table 'Administrador'
ALTER TABLE [dbo].[Administrador]
ADD CONSTRAINT [PK_Administrador]
    PRIMARY KEY CLUSTERED ([IdAdministrador] ASC);
GO

-- Creating primary key on [IdAluno] in table 'Aluno'
ALTER TABLE [dbo].[Aluno]
ADD CONSTRAINT [PK_Aluno]
    PRIMARY KEY CLUSTERED ([IdAluno] ASC);
GO

-- Creating primary key on [IdAluno_Turma] in table 'Aluno_Turma'
ALTER TABLE [dbo].[Aluno_Turma]
ADD CONSTRAINT [PK_Aluno_Turma]
    PRIMARY KEY CLUSTERED ([IdAluno_Turma] ASC);
GO

-- Creating primary key on [IdCurso] in table 'Curso'
ALTER TABLE [dbo].[Curso]
ADD CONSTRAINT [PK_Curso]
    PRIMARY KEY CLUSTERED ([IdCurso] ASC);
GO

-- Creating primary key on [IdDisciplina] in table 'Disciplina'
ALTER TABLE [dbo].[Disciplina]
ADD CONSTRAINT [PK_Disciplina]
    PRIMARY KEY CLUSTERED ([IdDisciplina] ASC);
GO

-- Creating primary key on [IdProfessor] in table 'Professor'
ALTER TABLE [dbo].[Professor]
ADD CONSTRAINT [PK_Professor]
    PRIMARY KEY CLUSTERED ([IdProfessor] ASC);
GO

-- Creating primary key on [IdTurma] in table 'Turma'
ALTER TABLE [dbo].[Turma]
ADD CONSTRAINT [PK_Turma]
    PRIMARY KEY CLUSTERED ([IdTurma] ASC);
GO

-- Creating primary key on [IdTurno] in table 'Turno'
ALTER TABLE [dbo].[Turno]
ADD CONSTRAINT [PK_Turno]
    PRIMARY KEY CLUSTERED ([IdTurno] ASC);
GO

-- Creating primary key on [Curso_IdCurso], [Turno_IdTurno] in table 'CursoTurno1'
ALTER TABLE [dbo].[CursoTurno1]
ADD CONSTRAINT [PK_CursoTurno1]
    PRIMARY KEY CLUSTERED ([Curso_IdCurso], [Turno_IdTurno] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdAluno] in table 'Aluno_Turma'
ALTER TABLE [dbo].[Aluno_Turma]
ADD CONSTRAINT [FK_AlunoAluno_Turma]
    FOREIGN KEY ([IdAluno])
    REFERENCES [dbo].[Aluno]
        ([IdAluno])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AlunoAluno_Turma'
CREATE INDEX [IX_FK_AlunoAluno_Turma]
ON [dbo].[Aluno_Turma]
    ([IdAluno]);
GO

-- Creating foreign key on [IdTurma] in table 'Aluno_Turma'
ALTER TABLE [dbo].[Aluno_Turma]
ADD CONSTRAINT [FK_TurmaAluno_Turma]
    FOREIGN KEY ([IdTurma])
    REFERENCES [dbo].[Turma]
        ([IdTurma])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TurmaAluno_Turma'
CREATE INDEX [IX_FK_TurmaAluno_Turma]
ON [dbo].[Aluno_Turma]
    ([IdTurma]);
GO

-- Creating foreign key on [IdCurso] in table 'Disciplina'
ALTER TABLE [dbo].[Disciplina]
ADD CONSTRAINT [FK_CursoDisciplina]
    FOREIGN KEY ([IdCurso])
    REFERENCES [dbo].[Curso]
        ([IdCurso])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CursoDisciplina'
CREATE INDEX [IX_FK_CursoDisciplina]
ON [dbo].[Disciplina]
    ([IdCurso]);
GO

-- Creating foreign key on [IdDisciplina] in table 'Turma'
ALTER TABLE [dbo].[Turma]
ADD CONSTRAINT [FK_DisciplinaTurma]
    FOREIGN KEY ([IdDisciplina])
    REFERENCES [dbo].[Disciplina]
        ([IdDisciplina])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DisciplinaTurma'
CREATE INDEX [IX_FK_DisciplinaTurma]
ON [dbo].[Turma]
    ([IdDisciplina]);
GO

-- Creating foreign key on [IdProfessor] in table 'Turma'
ALTER TABLE [dbo].[Turma]
ADD CONSTRAINT [FK_ProfessorTurma]
    FOREIGN KEY ([IdProfessor])
    REFERENCES [dbo].[Professor]
        ([IdProfessor])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProfessorTurma'
CREATE INDEX [IX_FK_ProfessorTurma]
ON [dbo].[Turma]
    ([IdProfessor]);
GO

-- Creating foreign key on [Curso_IdCurso] in table 'CursoTurno1'
ALTER TABLE [dbo].[CursoTurno1]
ADD CONSTRAINT [FK_CursoTurno1_Curso]
    FOREIGN KEY ([Curso_IdCurso])
    REFERENCES [dbo].[Curso]
        ([IdCurso])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Turno_IdTurno] in table 'CursoTurno1'
ALTER TABLE [dbo].[CursoTurno1]
ADD CONSTRAINT [FK_CursoTurno1_Turno]
    FOREIGN KEY ([Turno_IdTurno])
    REFERENCES [dbo].[Turno]
        ([IdTurno])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CursoTurno1_Turno'
CREATE INDEX [IX_FK_CursoTurno1_Turno]
ON [dbo].[CursoTurno1]
    ([Turno_IdTurno]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------