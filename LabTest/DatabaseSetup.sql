-- ==============================================================
-- SQL Server Database Schema Setup: Category & Item Management
-- ==============================================================

IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'LabTestDB')
BEGIN
    CREATE DATABASE [LabTestDB];
END
GO

USE [LabTestDB];
GO

-- 1. Create Parent Table: tblcategories
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblcategories]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[tblcategories] (
        [CategoryID]    INT IDENTITY(1,1) NOT NULL,
        [CategoryName]  NVARCHAR(100) NOT NULL,
        [CategoryImage] NVARCHAR(500) NULL,
        [Status]        NVARCHAR(20) NOT NULL CONSTRAINT [DF_tblcategories_Status] DEFAULT ('Active'),
        CONSTRAINT [PK_tblcategories] PRIMARY KEY CLUSTERED ([CategoryID] ASC)
    );
END
GO

-- 2. Create Child Table: tblitems
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblitems]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[tblitems] (
        [ItemID]       INT IDENTITY(1,1) NOT NULL,
        [ItemName]     NVARCHAR(150) NOT NULL,
        [CategoryID]   INT NOT NULL,
        [Description]  NVARCHAR(MAX) NULL,
        [UnitPrice]    DECIMAL(18,2) NOT NULL CONSTRAINT [DF_tblitems_UnitPrice] DEFAULT (0.00),
        [ItemImage]    NVARCHAR(500) NULL,
        [Status]       NVARCHAR(20) NOT NULL CONSTRAINT [DF_tblitems_Status] DEFAULT ('Active'),
        CONSTRAINT [PK_tblitems] PRIMARY KEY CLUSTERED ([ItemID] ASC),
        CONSTRAINT [FK_tblitems_tblcategories] FOREIGN KEY ([CategoryID]) 
            REFERENCES [dbo].[tblcategories] ([CategoryID]) 
            ON UPDATE CASCADE 
            ON DELETE CASCADE
    );
END
GO

-- Index for FK performance
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = N'IX_tblitems_CategoryID' AND object_id = OBJECT_ID(N'[dbo].[tblitems]'))
BEGIN
    CREATE NONCLUSTERED INDEX [IX_tblitems_CategoryID] 
    ON [dbo].[tblitems] ([CategoryID] ASC);
END
GO

-- 3. Seed Sample Data (Optional verification records)
IF NOT EXISTS (SELECT TOP 1 1 FROM [dbo].[tblcategories])
BEGIN
    SET IDENTITY_INSERT [dbo].[tblcategories] ON;

    INSERT INTO [dbo].[tblcategories] ([CategoryID], [CategoryName], [CategoryImage], [Status])
    VALUES 
    (1, N'Beverages', N'', N'Active'),
    (2, N'Bakery & Pastries', N'', N'Active'),
    (3, N'Electronics', N'', N'Active'),
    (4, N'Office Supplies', N'', N'Active');

    SET IDENTITY_INSERT [dbo].[tblcategories] OFF;
END
GO

IF NOT EXISTS (SELECT TOP 1 1 FROM [dbo].[tblitems])
BEGIN
    SET IDENTITY_INSERT [dbo].[tblitems] ON;

    INSERT INTO [dbo].[tblitems] ([ItemID], [ItemName], [CategoryID], [Description], [UnitPrice], [ItemImage], [Status])
    VALUES 
    (1, N'Espresso Roast Whole Beans', 1, N'Rich and dark roast blend from Arabica beans (500g bag).', 14.50, N'', N'Active'),
    (2, N'Organic Matcha Green Tea', 1, N'Ceremonial grade Japanese green tea powder (100g).', 22.00, N'', N'Active'),
    (3, N'Artisan Butter Croissant', 2, N'Freshly baked flaky pastry with 100% French cultured butter.', 3.75, N'', N'Active'),
    (4, N'Sourdough Country Loaf', 2, N'Naturally fermented traditional rustic bread with crisp crust.', 6.50, N'', N'Active'),
    (5, N'Wireless Noise-Cancelling Headphones', 3, N'Over-ear Bluetooth headphones with 30-hour battery life.', 149.99, N'', N'Active'),
    (6, N'Mechanical Keyboard RGB', 3, N'Compact tenkeyless mechanical gaming keyboard with brown switches.', 79.50, N'', N'Active');

    SET IDENTITY_INSERT [dbo].[tblitems] OFF;
END
GO
