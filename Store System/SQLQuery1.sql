USE [Database]
GO

/****** Object:  Table [dbo].[Branch]    Script Date: 3/30/2024 4:36:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Branch](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[ManagerName] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[Phone] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[MainMoneyStock] [float] NOT NULL,
 CONSTRAINT [PK_Branch] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BranchSuppliers]    Script Date: 3/30/2024 4:36:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BranchSuppliers](
	[Branch_Id] [int] NOT NULL,
	[Supplier_Id] [int] NOT NULL,
	[BranchID] [int] NULL,
	[SupplierID] [int] NULL,
 CONSTRAINT [PK_BranchSuppliers] PRIMARY KEY CLUSTERED 
(
	[Supplier_Id] ASC,
	[Branch_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 3/30/2024 4:36:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](max) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 3/30/2024 4:36:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Phone] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 3/30/2024 4:36:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Phone] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[branch_ID] [int] NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 3/30/2024 4:36:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[OrderDate] [datetime2](7) NULL,
	[ShippedDate] [datetime2](7) NULL,
	[CustomerName] [nvarchar](max) NULL,
	[IsSale] [bit] NOT NULL,
	[user_id] [int] NULL,
	[Customer_Id] [int] NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderItems]    Script Date: 3/30/2024 4:36:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderItems](
	[Order_Id] [int] NOT NULL,
	[product_Id] [int] NOT NULL,
	[TotalPrice] [float] NOT NULL,
	[Discount] [float] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Size] [nvarchar](max) NULL,
	[Color] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_OrderItems] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 3/30/2024 4:36:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Barcode] [nvarchar](max) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[SellingPrice] [float] NOT NULL,
	[Cost] [float] NOT NULL,
	[Discount] [float] NOT NULL,
	[Size] [int] NULL,
	[Color] [nvarchar](max) NULL,
	[Production_Date] [datetime2](7) NULL,
	[Expiry_date] [datetime2](7) NULL,
	[StockAmount] [int] NOT NULL,
	[Category_id] [int] NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductsStocks]    Script Date: 3/30/2024 4:36:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductsStocks](
	[Product_Id] [int] NOT NULL,
	[Stock_Id] [int] NOT NULL,
	[QuantityInStock] [int] NOT NULL,
	[MinQuantity] [int] NOT NULL,
	[ProductID] [int] NULL,
	[StockID] [int] NULL,
 CONSTRAINT [PK_ProductsStocks] PRIMARY KEY CLUSTERED 
(
	[Stock_Id] ASC,
	[Product_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductsSuppliers]    Script Date: 3/30/2024 4:36:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductsSuppliers](
	[product_Id] [int] NOT NULL,
	[Supplier_Id] [int] NOT NULL,
	[ProductID] [int] NULL,
	[SupplierID] [int] NULL,
 CONSTRAINT [PK_ProductsSuppliers] PRIMARY KEY CLUSTERED 
(
	[product_Id] ASC,
	[Supplier_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Returned]    Script Date: 3/30/2024 4:36:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Returned](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime2](7) NOT NULL,
	[OrderID] [int] NULL,
 CONSTRAINT [PK_Returned] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReturnedItems]    Script Date: 3/30/2024 4:36:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReturnedItems](
	[Returned_Id] [int] NOT NULL,
	[Product_Id] [int] NOT NULL,
	[Notes] [nvarchar](max) NULL,
	[OrderID] [int] NULL,
	[ReturnedQuantity] [int] NULL,
	[ProductID] [int] NULL,
	[Returnedid] [int] NULL,
 CONSTRAINT [PK_ReturnedItems] PRIMARY KEY CLUSTERED 
(
	[Returned_Id] ASC,
	[Product_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stock]    Script Date: 3/30/2024 4:36:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stock](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[StockManager] [nvarchar](max) NULL,
 CONSTRAINT [PK_Stock] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 3/30/2024 4:36:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supplier](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Address] [nvarchar](max) NULL,
	[Phone] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NULL,
	[ContractDate] [datetime2](7) NULL,
 CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 3/30/2024 4:36:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Phone] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[UserName] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[Role] [int] NOT NULL,
	[Branch_Id] [int] NULL,
	[MoneyStockName] [nvarchar](max) NOT NULL,
	[MoneyStockAmount] [float] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[BranchSuppliers]  WITH CHECK ADD  CONSTRAINT [FK_BranchSuppliers_Branch_Branch_Id] FOREIGN KEY([Branch_Id])
REFERENCES [dbo].[Branch] ([ID])
GO
ALTER TABLE [dbo].[BranchSuppliers] CHECK CONSTRAINT [FK_BranchSuppliers_Branch_Branch_Id]
GO
ALTER TABLE [dbo].[BranchSuppliers]  WITH CHECK ADD  CONSTRAINT [FK_BranchSuppliers_Branch_BranchID] FOREIGN KEY([BranchID])
REFERENCES [dbo].[Branch] ([ID])
GO
ALTER TABLE [dbo].[BranchSuppliers] CHECK CONSTRAINT [FK_BranchSuppliers_Branch_BranchID]
GO
ALTER TABLE [dbo].[BranchSuppliers]  WITH CHECK ADD  CONSTRAINT [FK_BranchSuppliers_Supplier_Supplier_Id] FOREIGN KEY([Supplier_Id])
REFERENCES [dbo].[Supplier] ([ID])
GO
ALTER TABLE [dbo].[BranchSuppliers] CHECK CONSTRAINT [FK_BranchSuppliers_Supplier_Supplier_Id]
GO
ALTER TABLE [dbo].[BranchSuppliers]  WITH CHECK ADD  CONSTRAINT [FK_BranchSuppliers_Supplier_SupplierID] FOREIGN KEY([SupplierID])
REFERENCES [dbo].[Supplier] ([ID])
GO
ALTER TABLE [dbo].[BranchSuppliers] CHECK CONSTRAINT [FK_BranchSuppliers_Supplier_SupplierID]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Branch_branch_ID] FOREIGN KEY([branch_ID])
REFERENCES [dbo].[Branch] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Branch_branch_ID]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Customer_Customer_Id] FOREIGN KEY([Customer_Id])
REFERENCES [dbo].[Customer] ([ID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Customer_Customer_Id]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_User_user_id] FOREIGN KEY([user_id])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_User_user_id]
GO
ALTER TABLE [dbo].[OrderItems]  WITH CHECK ADD  CONSTRAINT [FK_OrderItems_Order_Order_Id] FOREIGN KEY([Order_Id])
REFERENCES [dbo].[Order] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderItems] CHECK CONSTRAINT [FK_OrderItems_Order_Order_Id]
GO
ALTER TABLE [dbo].[OrderItems]  WITH CHECK ADD  CONSTRAINT [FK_OrderItems_Product_product_Id] FOREIGN KEY([product_Id])
REFERENCES [dbo].[Product] ([ID])
GO
ALTER TABLE [dbo].[OrderItems] CHECK CONSTRAINT [FK_OrderItems_Product_product_Id]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Category_Category_id] FOREIGN KEY([Category_id])
REFERENCES [dbo].[Category] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Category_Category_id]
GO
ALTER TABLE [dbo].[ProductsStocks]  WITH CHECK ADD  CONSTRAINT [FK_ProductsStocks_Product_Product_Id] FOREIGN KEY([Product_Id])
REFERENCES [dbo].[Product] ([ID])
GO
ALTER TABLE [dbo].[ProductsStocks] CHECK CONSTRAINT [FK_ProductsStocks_Product_Product_Id]
GO
ALTER TABLE [dbo].[ProductsStocks]  WITH CHECK ADD  CONSTRAINT [FK_ProductsStocks_Product_ProductID] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ID])
GO
ALTER TABLE [dbo].[ProductsStocks] CHECK CONSTRAINT [FK_ProductsStocks_Product_ProductID]
GO
ALTER TABLE [dbo].[ProductsStocks]  WITH CHECK ADD  CONSTRAINT [FK_ProductsStocks_Stock_Stock_Id] FOREIGN KEY([Stock_Id])
REFERENCES [dbo].[Stock] ([ID])
GO
ALTER TABLE [dbo].[ProductsStocks] CHECK CONSTRAINT [FK_ProductsStocks_Stock_Stock_Id]
GO
ALTER TABLE [dbo].[ProductsStocks]  WITH CHECK ADD  CONSTRAINT [FK_ProductsStocks_Stock_StockID] FOREIGN KEY([StockID])
REFERENCES [dbo].[Stock] ([ID])
GO
ALTER TABLE [dbo].[ProductsStocks] CHECK CONSTRAINT [FK_ProductsStocks_Stock_StockID]
GO
ALTER TABLE [dbo].[ProductsSuppliers]  WITH CHECK ADD  CONSTRAINT [FK_ProductsSuppliers_Product_product_Id] FOREIGN KEY([product_Id])
REFERENCES [dbo].[Product] ([ID])
GO
ALTER TABLE [dbo].[ProductsSuppliers] CHECK CONSTRAINT [FK_ProductsSuppliers_Product_product_Id]
GO
ALTER TABLE [dbo].[ProductsSuppliers]  WITH CHECK ADD  CONSTRAINT [FK_ProductsSuppliers_Product_ProductID] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ID])
GO
ALTER TABLE [dbo].[ProductsSuppliers] CHECK CONSTRAINT [FK_ProductsSuppliers_Product_ProductID]
GO
ALTER TABLE [dbo].[ProductsSuppliers]  WITH CHECK ADD  CONSTRAINT [FK_ProductsSuppliers_Supplier_Supplier_Id] FOREIGN KEY([Supplier_Id])
REFERENCES [dbo].[Supplier] ([ID])
GO
ALTER TABLE [dbo].[ProductsSuppliers] CHECK CONSTRAINT [FK_ProductsSuppliers_Supplier_Supplier_Id]
GO
ALTER TABLE [dbo].[ProductsSuppliers]  WITH CHECK ADD  CONSTRAINT [FK_ProductsSuppliers_Supplier_SupplierID] FOREIGN KEY([SupplierID])
REFERENCES [dbo].[Supplier] ([ID])
GO
ALTER TABLE [dbo].[ProductsSuppliers] CHECK CONSTRAINT [FK_ProductsSuppliers_Supplier_SupplierID]
GO
ALTER TABLE [dbo].[Returned]  WITH CHECK ADD  CONSTRAINT [FK_Returned_Order_OrderID] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Order] ([ID])
GO
ALTER TABLE [dbo].[Returned] CHECK CONSTRAINT [FK_Returned_Order_OrderID]
GO
ALTER TABLE [dbo].[ReturnedItems]  WITH CHECK ADD  CONSTRAINT [FK_ReturnedItems_Product_Product_Id] FOREIGN KEY([Product_Id])
REFERENCES [dbo].[Product] ([ID])
GO
ALTER TABLE [dbo].[ReturnedItems] CHECK CONSTRAINT [FK_ReturnedItems_Product_Product_Id]
GO
ALTER TABLE [dbo].[ReturnedItems]  WITH CHECK ADD  CONSTRAINT [FK_ReturnedItems_Product_ProductID] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ID])
GO
ALTER TABLE [dbo].[ReturnedItems] CHECK CONSTRAINT [FK_ReturnedItems_Product_ProductID]
GO
ALTER TABLE [dbo].[ReturnedItems]  WITH CHECK ADD  CONSTRAINT [FK_ReturnedItems_Returned_Returned_Id] FOREIGN KEY([Returned_Id])
REFERENCES [dbo].[Returned] ([id])
GO
ALTER TABLE [dbo].[ReturnedItems] CHECK CONSTRAINT [FK_ReturnedItems_Returned_Returned_Id]
GO
ALTER TABLE [dbo].[ReturnedItems]  WITH CHECK ADD  CONSTRAINT [FK_ReturnedItems_Returned_Returnedid] FOREIGN KEY([Returnedid])
REFERENCES [dbo].[Returned] ([id])
GO
ALTER TABLE [dbo].[ReturnedItems] CHECK CONSTRAINT [FK_ReturnedItems_Returned_Returnedid]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Branch_Branch_Id] FOREIGN KEY([Branch_Id])
REFERENCES [dbo].[Branch] ([ID])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Branch_Branch_Id]
GO

