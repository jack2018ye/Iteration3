/****** Object:  Table [dbo].[PublicToilet]    Script Date: 13/05/2018 16:13:02 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PublicToilet](
	[id] [int] NOT NULL,
	[lat] [float] NULL,
	[lon] [float] NULL,
	[name] [nvarchar](150) NULL,
	[female] [nvarchar](150) NULL,
	[male] [nvarchar](150) NULL,
	[wheelchair] [nvarchar](150) NULL,
	[operator] [nvarchar](150) NULL,
	[baby_facil] [nvarchar](150) NULL,
	[location] [nvarchar](150) NULL,
	[Address] [nvarchar](150) NULL,
	[Postcode] [int] NULL,
 CONSTRAINT [PK_PublicToilet] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


