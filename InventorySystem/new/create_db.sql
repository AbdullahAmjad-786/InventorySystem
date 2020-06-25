/* SCRIPT: CREATE_DB.sql */
/* BUILD A DATABASE */

-- This is the main caller for each script
SET NOCOUNT ON
GO

PRINT 'CREATING DATABASE'
WHILE EXISTS(select NULL from sys.databases where name='Inventory')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'Inventory') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE [Inventory]
END
GO

CREATE DATABASE Inventory
GO


:On Error exit

USE [Inventory]
GO
/****** Object:  Table [dbo].[category]    Script Date: 08-Mar-16 6:18:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[category](
	[categoryID] [int] IDENTITY(1,1) NOT NULL,
	[categoryName] [nvarchar](max) NOT NULL,
	[categoryDiscription] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[categoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[customers]    Script Date: 08-Mar-16 6:18:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[customers](
	[customerFirstName] [varchar](50) NOT NULL,
	[customerLastName] [varchar](50) NOT NULL,
	[customerContactNumber] [bigint] NOT NULL,
	[customerCity] [varchar](50) NULL,
	[Balance] [varchar](100) NULL,
	[CustomerState] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[customerContactNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[invoice]    Script Date: 08-Mar-16 6:18:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[invoice](
	[InvoiceID] [int] IDENTITY(1,1) NOT NULL,
	[customerID] [bigint] NOT NULL,
	[grandTotal] [money] NOT NULL,
	[cutomerName] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[InvoiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[login]    Script Date: 08-Mar-16 6:18:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[login](
	[username] [varchar](50) NOT NULL,
	[password] [text] NOT NULL,
	[type] [text] NOT NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_login] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[product]    Script Date: 08-Mar-16 6:18:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[product](
	[productname] [nvarchar](50) NOT NULL,
	[barcode] [nvarchar](50) NOT NULL,
	[purchaseprice] [money] NOT NULL,
	[sellingprice] [money] NOT NULL,
	[noofcartons] [int] NOT NULL,
	[qtyincartons] [int] NOT NULL,
	[productno] [int] NOT NULL,
	[category] [nvarchar](50) NOT NULL,
	[expirydate] [nvarchar](50) NULL,
	[totalqty] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[barcode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[sales]    Script Date: 08-Mar-16 6:18:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[sales](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[custumerID] [bigint] NOT NULL,
	[barcode] [varchar](100) NOT NULL,
	[invoiceID] [int] NOT NULL,
	[qty] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[staff]    Script Date: 08-Mar-16 6:18:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[staff](
	[SId] [int] IDENTITY(1,1) NOT NULL,
	[fname] [nvarchar](50) NOT NULL,
	[lname] [nvarchar](50) NULL,
	[mid] [nchar](10) NULL,
	[state] [nvarchar](50) NOT NULL,
	[city] [nvarchar](50) NOT NULL,
	[province] [nvarchar](50) NULL,
	[contact] [nchar](15) NULL,
	[username] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[stock]    Script Date: 08-Mar-16 6:18:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stock](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[barcode] [int] NOT NULL,
	[unitprice] [money] NOT NULL,
	[currentstock] [int] NOT NULL,
	[newstock] [int] NOT NULL,
	[totalstock] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[category] ON 

INSERT [dbo].[category] ([categoryID], [categoryName], [categoryDiscription]) VALUES (3, N'CAKE 500 GM', N'Nestle cake')
INSERT [dbo].[category] ([categoryID], [categoryName], [categoryDiscription]) VALUES (4, N'ENERGY DRINKS', N'')
SET IDENTITY_INSERT [dbo].[category] OFF
INSERT [dbo].[customers] ([customerFirstName], [customerLastName], [customerContactNumber], [customerCity], [Balance], [CustomerState]) VALUES (N'huzaifa', N'ahmed', 1, N'bhoraay wala', N'121', N'pakistan')
INSERT [dbo].[customers] ([customerFirstName], [customerLastName], [customerContactNumber], [customerCity], [Balance], [CustomerState]) VALUES (N'abdullah', N'amjad', 2, N'fsd', N'232', N'pakistan')
SET IDENTITY_INSERT [dbo].[invoice] ON 

INSERT [dbo].[invoice] ([InvoiceID], [customerID], [grandTotal], [cutomerName]) VALUES (1, 21, 12.0000, N' ')
INSERT [dbo].[invoice] ([InvoiceID], [customerID], [grandTotal], [cutomerName]) VALUES (2, 1312, 12.0000, N' ')
INSERT [dbo].[invoice] ([InvoiceID], [customerID], [grandTotal], [cutomerName]) VALUES (3, 2, 24.0000, N' ')
INSERT [dbo].[invoice] ([InvoiceID], [customerID], [grandTotal], [cutomerName]) VALUES (4, 2, 420.0000, N' ')
INSERT [dbo].[invoice] ([InvoiceID], [customerID], [grandTotal], [cutomerName]) VALUES (5, 1, 12.0000, N' ')
INSERT [dbo].[invoice] ([InvoiceID], [customerID], [grandTotal], [cutomerName]) VALUES (6, 1, 36.0000, N' ')
INSERT [dbo].[invoice] ([InvoiceID], [customerID], [grandTotal], [cutomerName]) VALUES (7, 1, 48.0000, N' ')
INSERT [dbo].[invoice] ([InvoiceID], [customerID], [grandTotal], [cutomerName]) VALUES (8, 1, 36.0000, N' ')
SET IDENTITY_INSERT [dbo].[invoice] OFF
SET IDENTITY_INSERT [dbo].[login] ON 

INSERT [dbo].[login] ([username], [password], [type], [id]) VALUES (N'admin', N'123', N'Admin', 1)
INSERT [dbo].[login] ([username], [password], [type], [id]) VALUES (N'uzibonda', N'123', N'Cashier', 2)
SET IDENTITY_INSERT [dbo].[login] OFF
INSERT [dbo].[product] ([productname], [barcode], [purchaseprice], [sellingprice], [noofcartons], [qtyincartons], [productno], [category], [expirydate], [totalqty]) VALUES (N'CAKE', N'121', 10.0000, 12.0000, 10, 2, 2121, N'CAKE 500 GM', N'07-04-2016', 9)
INSERT [dbo].[product] ([productname], [barcode], [purchaseprice], [sellingprice], [noofcartons], [qtyincartons], [productno], [category], [expirydate], [totalqty]) VALUES (N'CAKE', N'12312', 12.0000, 21.0000, 0, 2, 2341, N'ENERGY DRINKS', N'07-03-2016', 0)
SET IDENTITY_INSERT [dbo].[sales] ON 

INSERT [dbo].[sales] ([Id], [custumerID], [barcode], [invoiceID], [qty]) VALUES (1, 21, N'121', 1, 1)
INSERT [dbo].[sales] ([Id], [custumerID], [barcode], [invoiceID], [qty]) VALUES (2, 1312, N'121', 2, 1)
INSERT [dbo].[sales] ([Id], [custumerID], [barcode], [invoiceID], [qty]) VALUES (3, 2, N'121', 3, 1)
INSERT [dbo].[sales] ([Id], [custumerID], [barcode], [invoiceID], [qty]) VALUES (4, 2, N'121', 3, 1)
INSERT [dbo].[sales] ([Id], [custumerID], [barcode], [invoiceID], [qty]) VALUES (5, 2, N'12312', 4, 20)
INSERT [dbo].[sales] ([Id], [custumerID], [barcode], [invoiceID], [qty]) VALUES (6, 1, N'121', 5, 1)
INSERT [dbo].[sales] ([Id], [custumerID], [barcode], [invoiceID], [qty]) VALUES (7, 1, N'121', 6, 1)
INSERT [dbo].[sales] ([Id], [custumerID], [barcode], [invoiceID], [qty]) VALUES (8, 1, N'121', 6, 1)
INSERT [dbo].[sales] ([Id], [custumerID], [barcode], [invoiceID], [qty]) VALUES (9, 1, N'121', 6, 1)
INSERT [dbo].[sales] ([Id], [custumerID], [barcode], [invoiceID], [qty]) VALUES (10, 1, N'121', 7, 1)
INSERT [dbo].[sales] ([Id], [custumerID], [barcode], [invoiceID], [qty]) VALUES (11, 1, N'121', 7, 1)
INSERT [dbo].[sales] ([Id], [custumerID], [barcode], [invoiceID], [qty]) VALUES (12, 1, N'121', 7, 1)
INSERT [dbo].[sales] ([Id], [custumerID], [barcode], [invoiceID], [qty]) VALUES (13, 1, N'121', 7, 1)
INSERT [dbo].[sales] ([Id], [custumerID], [barcode], [invoiceID], [qty]) VALUES (14, 1, N'121', 8, 1)
INSERT [dbo].[sales] ([Id], [custumerID], [barcode], [invoiceID], [qty]) VALUES (15, 1, N'121', 8, 1)
INSERT [dbo].[sales] ([Id], [custumerID], [barcode], [invoiceID], [qty]) VALUES (16, 1, N'121', 8, 1)
SET IDENTITY_INSERT [dbo].[sales] OFF
SET IDENTITY_INSERT [dbo].[staff] ON 

INSERT [dbo].[staff] ([SId], [fname], [lname], [mid], [state], [city], [province], [contact], [username]) VALUES (5, N'XYZ', N'ABC', N'          ', N'', N'Ohio', N'Claifornia', N'3213131        ', N'syntax')
INSERT [dbo].[staff] ([SId], [fname], [lname], [mid], [state], [city], [province], [contact], [username]) VALUES (6, N'baba :D', N'Chusar', N'          ', N'', N'', N'Punjab', N'3223121        ', N'uzibonda')
SET IDENTITY_INSERT [dbo].[staff] OFF
SET IDENTITY_INSERT [dbo].[stock] ON 

INSERT [dbo].[stock] ([Id], [barcode], [unitprice], [currentstock], [newstock], [totalstock]) VALUES (1, 121, 12.0000, 2, 2, 4)
INSERT [dbo].[stock] ([Id], [barcode], [unitprice], [currentstock], [newstock], [totalstock]) VALUES (2, 121, 12.0000, 2, 4, 6)
INSERT [dbo].[stock] ([Id], [barcode], [unitprice], [currentstock], [newstock], [totalstock]) VALUES (3, 121, 12.0000, 6, 1, 7)
INSERT [dbo].[stock] ([Id], [barcode], [unitprice], [currentstock], [newstock], [totalstock]) VALUES (4, 121, 12.0000, 7, 1, 8)
INSERT [dbo].[stock] ([Id], [barcode], [unitprice], [currentstock], [newstock], [totalstock]) VALUES (5, 121, 12.0000, 8, 2, 10)
SET IDENTITY_INSERT [dbo].[stock] OFF
