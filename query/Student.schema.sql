USE [GSS]
GO

/****** Object:  Table [dbo].[Students]    Script Date: 13 Jan 2019 10:35:04 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Students](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[StudentNumber] [nchar](20) NOT NULL,
	[FirstName] [nchar](20) NOT NULL,
	[MiddleName] [nchar](20) NULL,
	[LastName] [nchar](20) NOT NULL,
	[FingerPrintID] [int] NULL,
	[Year] [nchar](10) NULL,
	[Section] [nchar](10) NULL,
	[CourseCode] [nchar](10) NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

