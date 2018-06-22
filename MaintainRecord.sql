
/****** Object:  Table [dbo].[MaintainRecord]    Script Date: 2018-05-17 22:49:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[MaintainRecord](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SallID] [numeric](18, 0) NULL,
	[Saleman] [nvarchar](50) NULL,
	[Status] [int] NULL,
	[MaintainDate] [datetime] NULL,
 CONSTRAINT [PK_MaintainRecord] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


