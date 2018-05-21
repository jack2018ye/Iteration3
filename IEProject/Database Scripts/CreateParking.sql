/****** Object:  Table [dbo].[Parking]    Script Date: 13/05/2018 16:11:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Parking](
	[Id] [int] NOT NULL,
	[BayId] [int] NULL,
	[lat] [float] NULL,
	[lon] [float] NULL,
	[area] [nvarchar](150) NULL,
	[location] [nvarchar](150) NULL,
	[des_dis_ext] [nvarchar](150) NULL,
 CONSTRAINT [PK_Parking] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


