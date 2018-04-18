USE [MachineAcafe]
GO

/****** Object:  Table [dbo].[userchoices]    Script Date: 18/04/2018 12:34:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[userchoices](
	[NumBadge] [varchar](10) NOT NULL,
	[TypeBoisson] [varchar](10) NULL,
	[QuantiteSucre] [int] NULL,
	[UtiliserSonMug] [int] NULL,
	[LastSelectionDate] [datetime] NULL,
 CONSTRAINT [PK_userchoices] PRIMARY KEY CLUSTERED 
(
	[NumBadge] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


