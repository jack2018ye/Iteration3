/****** Object:  Table [dbo].[buildings]    Script Date: 13/05/2018 16:10:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[buildings](
	[Id] [int] NOT NULL,
	[Area] [nvarchar](150) NULL,
	[Trading_name] [nvarchar](150) NULL,
	[Industry_description] [nvarchar](150) NULL,
	[Location] [nvarchar](150) NULL,
	[Street_address] [nvarchar](150) NULL,
	[Accessibility_type] [nvarchar](150) NULL,
	[Accessibility_type_description] [nvarchar](150) NULL,
	[Accessibility_rating] [int] NULL,
 CONSTRAINT [PK_buildings] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


