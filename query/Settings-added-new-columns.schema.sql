USE [GSS]
GO

/****** Object:  Table [dbo].[Settings]    Script Date: 17 Feb 2019 12:31:28 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Settings](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PortName] [nchar](20) NULL,
	[DataBits] [int] NULL,
	[PortBaudRate] [int] NULL,
	[ReadTimeout] [int] NULL,
	[CorrectEquivalent] [decimal](18, 0) NULL,
	[IncorrectEquivalent] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Settings] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

