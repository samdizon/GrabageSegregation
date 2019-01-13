USE [GSS]
GO

/****** Object:  Table [dbo].[WasteSorting]    Script Date: 13 Jan 2019 10:35:24 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[WasteSorting](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[StudentID] [int] NOT NULL,
	[SortingCategoryID] [int] NOT NULL,
	[Result] [int] NOT NULL,
	[Timestamp] [datetime] NULL,
 CONSTRAINT [PK_WasteSorting] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[WasteSorting] ADD  CONSTRAINT [DF_WasteSorting_Timestamp]  DEFAULT (getdate()) FOR [Timestamp]
GO

