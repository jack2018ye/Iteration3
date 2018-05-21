/****** Object:  Table [dbo].[PedestrianVolume]    Script Date: 13/05/2018 16:12:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PedestrianVolume](
	[Id] [int] NOT NULL,
	[Sensor_ID] [float] NULL,
	[Day] [varchar](20) NULL,
	[Time] [int] NULL,
	[HoursCount] [int] NULL,
	[Coordinates] [varchar](41) NULL,
	[Latitude] [float] NULL,
	[Longitude] [float] NULL,
 CONSTRAINT [PK_PedestrianVolume] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


