USE [GSS]
GO

/****** Object:  Table [dbo].[Users]    Script Date: 13 Jan 2019 10:35:15 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Users](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FIrstName] [nchar](50) NOT NULL,
	[MiddleName] [nchar](50) NULL,
	[LastName] [nchar](50) NOT NULL,
	[Username] [nchar](20) NOT NULL,
	[Password] [text] NOT NULL,
	[RoleID] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

