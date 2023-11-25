CREATE TABLE [dbo].[productDetailID]
(
	[productDetailID] INT NOT NULL PRIMARY KEY, 
    [productID] INT NOT NULL, 
    [modules] VARCHAR(50) NOT NULL, 
    [bussinessArea] VARCHAR(50) NOT NULL, 
    [companyID] INT NOT NULL, 
    [productDetail] VARCHAR(50) NOT NULL
)
