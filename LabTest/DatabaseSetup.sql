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

-- ==============================================================
-- 4. Stored Procedures for Category Management
-- ==============================================================

-- 4.1 Get All Categories
CREATE OR ALTER PROCEDURE [dbo].[sp_GetAllCategories]
AS
BEGIN
    SET NOCOUNT ON;
    SELECT 
        CategoryID, 
        CategoryName, 
        Status, 
        CategoryImage 
    FROM [dbo].[tblcategories]
    ORDER BY CategoryID DESC;
END
GO

-- 4.2 Get Categories for Dropdown / Lookup ComboBox
CREATE OR ALTER PROCEDURE [dbo].[sp_GetCategoriesLookup]
AS
BEGIN
    SET NOCOUNT ON;
    SELECT 
        CategoryID, 
        CategoryName 
    FROM [dbo].[tblcategories]
    ORDER BY CategoryName ASC;
END
GO

-- 4.3 Insert Category
CREATE OR ALTER PROCEDURE [dbo].[sp_InsertCategory]
    @CategoryName   NVARCHAR(100),
    @CategoryImage  NVARCHAR(500) = NULL,
    @Status         NVARCHAR(20) = 'Active',
    @NewCategoryID  INT = NULL OUTPUT
AS
BEGIN
    SET NOCOUNT OFF;
    INSERT INTO [dbo].[tblcategories] ([CategoryName], [CategoryImage], [Status])
    VALUES (@CategoryName, @CategoryImage, @Status);

    SET @NewCategoryID = SCOPE_IDENTITY();
    SELECT @NewCategoryID AS NewCategoryID;
END
GO

-- 4.4 Update Category
CREATE OR ALTER PROCEDURE [dbo].[sp_UpdateCategory]
    @CategoryID     INT,
    @CategoryName   NVARCHAR(100),
    @CategoryImage  NVARCHAR(500) = NULL,
    @Status         NVARCHAR(20)
AS
BEGIN
    SET NOCOUNT OFF;
    UPDATE [dbo].[tblcategories]
    SET [CategoryName]  = @CategoryName,
        [CategoryImage] = @CategoryImage,
        [Status]        = @Status
    WHERE [CategoryID]  = @CategoryID;
END
GO

-- 4.5 Delete Category
CREATE OR ALTER PROCEDURE [dbo].[sp_DeleteCategory]
    @CategoryID INT
AS
BEGIN
    SET NOCOUNT OFF;
    DELETE FROM [dbo].[tblcategories]
    WHERE [CategoryID] = @CategoryID;
END
GO

-- ==============================================================
-- 5. Stored Procedures for Item Management
-- ==============================================================

-- 5.1 Get All Items (joined with tblcategories)
CREATE OR ALTER PROCEDURE [dbo].[sp_GetAllItems]
AS
BEGIN
    SET NOCOUNT ON;
    SELECT 
        i.ItemID,
        i.ItemName,
        c.CategoryName,
        i.CategoryID,
        i.UnitPrice,
        i.Status,
        i.Description,
        i.ItemImage
    FROM [dbo].[tblitems] i
    INNER JOIN [dbo].[tblcategories] c ON i.CategoryID = c.CategoryID
    ORDER BY i.ItemID DESC;
END
GO

-- 5.2 Get Items By Category (Filtered)
CREATE OR ALTER PROCEDURE [dbo].[sp_GetItemsByCategory]
    @CategoryID INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    SELECT 
        i.ItemID,
        i.ItemName,
        c.CategoryName,
        i.CategoryID,
        i.UnitPrice,
        i.Status,
        i.Description,
        i.ItemImage
    FROM [dbo].[tblitems] i
    INNER JOIN [dbo].[tblcategories] c ON i.CategoryID = c.CategoryID
    WHERE (@CategoryID IS NULL OR @CategoryID = 0 OR i.CategoryID = @CategoryID)
    ORDER BY i.ItemID DESC;
END
GO

-- 5.3 Insert Item
CREATE OR ALTER PROCEDURE [dbo].[sp_InsertItem]
    @ItemName     NVARCHAR(150),
    @CategoryID   INT,
    @Description  NVARCHAR(MAX) = NULL,
    @UnitPrice    DECIMAL(18,2),
    @ItemImage    NVARCHAR(500) = NULL,
    @Status       NVARCHAR(20) = 'Active',
    @NewItemID    INT = NULL OUTPUT
AS
BEGIN
    SET NOCOUNT OFF;
    INSERT INTO [dbo].[tblitems] ([ItemName], [CategoryID], [Description], [UnitPrice], [ItemImage], [Status])
    VALUES (@ItemName, @CategoryID, @Description, @UnitPrice, @ItemImage, @Status);

    SET @NewItemID = SCOPE_IDENTITY();
    SELECT @NewItemID AS NewItemID;
END
GO

-- 5.4 Update Item
CREATE OR ALTER PROCEDURE [dbo].[sp_UpdateItem]
    @ItemID       INT,
    @ItemName     NVARCHAR(150),
    @CategoryID   INT,
    @Description  NVARCHAR(MAX) = NULL,
    @UnitPrice    DECIMAL(18,2),
    @ItemImage    NVARCHAR(500) = NULL,
    @Status       NVARCHAR(20)
AS
BEGIN
    SET NOCOUNT OFF;
    UPDATE [dbo].[tblitems]
    SET [ItemName]    = @ItemName,
        [CategoryID]  = @CategoryID,
        [Description] = @Description,
        [UnitPrice]   = @UnitPrice,
        [ItemImage]   = @ItemImage,
        [Status]      = @Status
    WHERE [ItemID]    = @ItemID;
END
GO

-- 5.5 Delete Item
CREATE OR ALTER PROCEDURE [dbo].[sp_DeleteItem]
    @ItemID INT
AS
BEGIN
    SET NOCOUNT OFF;
    DELETE FROM [dbo].[tblitems]
    WHERE [ItemID] = @ItemID;
END
GO
