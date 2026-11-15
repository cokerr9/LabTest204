-- ==============================================================
-- Stored Procedures for LabTestDB: Category & Item Management
-- Run this script in SQL Server Management Studio (SSMS)
-- ==============================================================

USE [LabTestDB];
GO

-- ==============================================================
-- 1. Stored Procedures for tblcategories
-- ==============================================================

-- 1.1 Get All Categories for DataGridView
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

-- 1.2 Get Categories for Dropdown / Lookup ComboBox
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

-- 1.3 Insert Category
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

-- 1.4 Update Category
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

-- 1.5 Delete Category
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
-- 2. Stored Procedures for tblitems
-- ==============================================================

-- 2.1 Get All Items (with Category Name joined)
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

-- 2.2 Get Items By Category (Optional Filter)
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

-- 2.3 Insert Item
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

-- 2.4 Update Item
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

-- 2.5 Delete Item
CREATE OR ALTER PROCEDURE [dbo].[sp_DeleteItem]
    @ItemID INT
AS
BEGIN
    SET NOCOUNT OFF;
    DELETE FROM [dbo].[tblitems]
    WHERE [ItemID] = @ItemID;
END
GO
