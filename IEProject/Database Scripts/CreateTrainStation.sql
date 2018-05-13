/****** Object:  Table [dbo].[TrainStation]    Script Date: 13/05/2018 16:13:29 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TrainStation](
	[Id] [int] NOT NULL,
	[station] [nvarchar](150) NULL,
	[location] [nvarchar](150) NULL,
	[passenger_information_display_system] [nvarchar](150) NULL,
	[hearing_aid] [nvarchar](150) NULL,
	[lift] [nvarchar](150) NULL,
 CONSTRAINT [PK_TrainStation] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


