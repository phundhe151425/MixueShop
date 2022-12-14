USE [MixueProject]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 8/19/2022 10:22:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[accountID] [int] IDENTITY(1,1) NOT NULL,
	[roleID] [int] NOT NULL,
	[username] [varchar](30) NOT NULL,
	[u_password] [varchar](30) NOT NULL,
	[fullname] [nvarchar](50) NOT NULL,
	[phone] [varchar](20) NOT NULL,
	[email] [varchar](100) NOT NULL,
	[a_address] [nvarchar](max) NOT NULL,
 CONSTRAINT [pk_accountID] PRIMARY KEY CLUSTERED 
(
	[accountID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 8/19/2022 10:22:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[cateID] [int] IDENTITY(1,1) NOT NULL,
	[cateName] [nvarchar](50) NOT NULL,
 CONSTRAINT [pk_cateID] PRIMARY KEY CLUSTERED 
(
	[cateID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 8/19/2022 10:22:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[orderID] [int] IDENTITY(1,1) NOT NULL,
	[orderDate] [date] NOT NULL,
	[amount] [float] NOT NULL,
 CONSTRAINT [pk_orderID] PRIMARY KEY CLUSTERED 
(
	[orderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 8/19/2022 10:22:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[detailOrderID] [int] IDENTITY(1,1) NOT NULL,
	[orderID] [int] NOT NULL,
	[productID] [int] NOT NULL,
	[price] [float] NOT NULL,
	[quantity] [int] NOT NULL,
	[odAmount] [float] NOT NULL,
 CONSTRAINT [pk_detailOrderID] PRIMARY KEY CLUSTERED 
(
	[detailOrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 8/19/2022 10:22:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[productID] [int] IDENTITY(1,1) NOT NULL,
	[productName] [nvarchar](100) NOT NULL,
	[productPrice] [float] NOT NULL,
	[cateID] [int] NOT NULL,
	[discount] [float] NULL,
 CONSTRAINT [pk_productID] PRIMARY KEY CLUSTERED 
(
	[productID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoleAccount]    Script Date: 8/19/2022 10:22:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoleAccount](
	[roleID] [int] IDENTITY(1,1) NOT NULL,
	[roleName] [varchar](30) NOT NULL,
 CONSTRAINT [pk_roleID] PRIMARY KEY CLUSTERED 
(
	[roleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Account] ON 

INSERT [dbo].[Account] ([accountID], [roleID], [username], [u_password], [fullname], [phone], [email], [a_address]) VALUES (1, 1, N'admin', N'123', N'Admin', N'0999999999', N'admibn@gmail.com', N'Every where')
INSERT [dbo].[Account] ([accountID], [roleID], [username], [u_password], [fullname], [phone], [email], [a_address]) VALUES (2, 2, N'hpdong', N'123', N'Ho Phuong Dong', N'098765432', N'hophuongdong@gmail.com', N'Bac Ninh')
INSERT [dbo].[Account] ([accountID], [roleID], [username], [u_password], [fullname], [phone], [email], [a_address]) VALUES (3, 2, N'ndphu', N'123', N'Nguyen Dinh Phu', N'098765432', N'nguyendinhphu@gmail.com', N'Ha Noi')
INSERT [dbo].[Account] ([accountID], [roleID], [username], [u_password], [fullname], [phone], [email], [a_address]) VALUES (4, 2, N'pdhai', N'123', N'Phung Duc Hai', N'098765432', N'phungduchai@gmail.com', N'Ha Noi')
SET IDENTITY_INSERT [dbo].[Account] OFF
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([cateID], [cateName]) VALUES (1, N'Trà hoa quả')
INSERT [dbo].[Category] ([cateID], [cateName]) VALUES (2, N'Ice-Cream & Tea')
INSERT [dbo].[Category] ([cateID], [cateName]) VALUES (3, N'Trà sữa')
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Order] ON 

INSERT [dbo].[Order] ([orderID], [orderDate], [amount]) VALUES (1, CAST(N'2022-07-01' AS Date), 150)
INSERT [dbo].[Order] ([orderID], [orderDate], [amount]) VALUES (2, CAST(N'2022-07-02' AS Date), 120)
INSERT [dbo].[Order] ([orderID], [orderDate], [amount]) VALUES (3, CAST(N'2022-07-05' AS Date), 65)
SET IDENTITY_INSERT [dbo].[Order] OFF
GO
SET IDENTITY_INSERT [dbo].[OrderDetail] ON 

INSERT [dbo].[OrderDetail] ([detailOrderID], [orderID], [productID], [price], [quantity], [odAmount]) VALUES (1, 1, 1, 30, 5, 150)
INSERT [dbo].[OrderDetail] ([detailOrderID], [orderID], [productID], [price], [quantity], [odAmount]) VALUES (2, 2, 6, 25, 3, 75)
INSERT [dbo].[OrderDetail] ([detailOrderID], [orderID], [productID], [price], [quantity], [odAmount]) VALUES (3, 2, 9, 30, 2, 60)
INSERT [dbo].[OrderDetail] ([detailOrderID], [orderID], [productID], [price], [quantity], [odAmount]) VALUES (4, 3, 2, 20, 6, 120)
SET IDENTITY_INSERT [dbo].[OrderDetail] OFF
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([productID], [productName], [productPrice], [cateID], [discount]) VALUES (1, N'Chanh leo bách hương', 35, 1, 0)
INSERT [dbo].[Product] ([productID], [productName], [productPrice], [cateID], [discount]) VALUES (2, N'Dương chi cam lộ', 35, 1, 0)
INSERT [dbo].[Product] ([productID], [productName], [productPrice], [cateID], [discount]) VALUES (3, N'Trà xanh chanh', 22, 1, 0)
INSERT [dbo].[Product] ([productID], [productName], [productPrice], [cateID], [discount]) VALUES (4, N'Hồng trà chanh', 22, 1, 0)
INSERT [dbo].[Product] ([productID], [productName], [productPrice], [cateID], [discount]) VALUES (5, N'Trà ô long bốn mùa', 20, 1, 0)
INSERT [dbo].[Product] ([productID], [productName], [productPrice], [cateID], [discount]) VALUES (6, N'Trà chanh lô hội', 20, 1, 0)
INSERT [dbo].[Product] ([productID], [productName], [productPrice], [cateID], [discount]) VALUES (7, N'Trà xanh mật ong', 20, 1, 0)
INSERT [dbo].[Product] ([productID], [productName], [productPrice], [cateID], [discount]) VALUES (8, N'Hồng trà mật ong', 20, 1, 0)
INSERT [dbo].[Product] ([productID], [productName], [productPrice], [cateID], [discount]) VALUES (9, N'Hồng trà đào', 17, 1, 0)
INSERT [dbo].[Product] ([productID], [productName], [productPrice], [cateID], [discount]) VALUES (10, N'Kem ốc quế nguyên vị', 10, 2, 0)
INSERT [dbo].[Product] ([productID], [productName], [productPrice], [cateID], [discount]) VALUES (11, N'Super sundae dâu tây', 25, 2, 0)
INSERT [dbo].[Product] ([productID], [productName], [productPrice], [cateID], [discount]) VALUES (12, N'Super sundae xoài', 25, 2, 0)
INSERT [dbo].[Product] ([productID], [productName], [productPrice], [cateID], [discount]) VALUES (13, N'Super sundae trân châu đường đen', 25, 2, 0)
INSERT [dbo].[Product] ([productID], [productName], [productPrice], [cateID], [discount]) VALUES (14, N'Super sundae socola', 25, 2, 0)
INSERT [dbo].[Product] ([productID], [productName], [productPrice], [cateID], [discount]) VALUES (15, N'Super sundae lô hội', 25, 2, 0)
INSERT [dbo].[Product] ([productID], [productName], [productPrice], [cateID], [discount]) VALUES (16, N'Sữa kem lắc dâu tây', 25, 2, 0)
INSERT [dbo].[Product] ([productID], [productName], [productPrice], [cateID], [discount]) VALUES (17, N'Trà kem bốn mùa', 25, 2, 0)
INSERT [dbo].[Product] ([productID], [productName], [productPrice], [cateID], [discount]) VALUES (18, N'Hồng trà kem', 25, 2, 0)
INSERT [dbo].[Product] ([productID], [productName], [productPrice], [cateID], [discount]) VALUES (19, N'Trà kem hoa nhài', 25, 2, 0)
INSERT [dbo].[Product] ([productID], [productName], [productPrice], [cateID], [discount]) VALUES (20, N'Trà sữa Bá Vương', 30, 3, 0)
INSERT [dbo].[Product] ([productID], [productName], [productPrice], [cateID], [discount]) VALUES (21, N'Trà sữa nướng', 25, 3, 0)
INSERT [dbo].[Product] ([productID], [productName], [productPrice], [cateID], [discount]) VALUES (22, N'Trà sữa 3Q', 25, 3, 0)
INSERT [dbo].[Product] ([productID], [productName], [productPrice], [cateID], [discount]) VALUES (23, N'Trà sữa thạch dừa', 25, 3, 0)
INSERT [dbo].[Product] ([productID], [productName], [productPrice], [cateID], [discount]) VALUES (24, N'Trà sữa trân châu', 25, 3, 0)
INSERT [dbo].[Product] ([productID], [productName], [productPrice], [cateID], [discount]) VALUES (25, N'Trà sữa 2J', 25, 3, 0)
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
SET IDENTITY_INSERT [dbo].[RoleAccount] ON 

INSERT [dbo].[RoleAccount] ([roleID], [roleName]) VALUES (1, N'Manager')
INSERT [dbo].[RoleAccount] ([roleID], [roleName]) VALUES (2, N'Staff')
SET IDENTITY_INSERT [dbo].[RoleAccount] OFF
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [fk_account_roleID] FOREIGN KEY([roleID])
REFERENCES [dbo].[RoleAccount] ([roleID])
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [fk_account_roleID]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [fk_OrderDetail_orderID] FOREIGN KEY([orderID])
REFERENCES [dbo].[Order] ([orderID])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [fk_OrderDetail_orderID]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [fk_OrderDetail_productID] FOREIGN KEY([productID])
REFERENCES [dbo].[Product] ([productID])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [fk_OrderDetail_productID]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [fk_product_cateID] FOREIGN KEY([cateID])
REFERENCES [dbo].[Category] ([cateID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [fk_product_cateID]
GO
