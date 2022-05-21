 IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'SimpleMathOperationsDb')
  BEGIN
    CREATE DATABASE SimpleMathOperationsDb
    END
    GO
       USE [SimpleMathOperationsDb]
    GO

IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [MathOperations] (
    [Id] int NOT NULL IDENTITY,
    [Number1] float NOT NULL,
    [Number2] float NOT NULL,
    [Result] float NOT NULL,
    [Operator] int NOT NULL,
    CONSTRAINT [PK_MathOperations] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220520173713_InitialMigration', N'6.0.5');
GO

COMMIT;
GO

