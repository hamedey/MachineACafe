USE [MachineAcafe]
GO

/****** Object:  Table [dbo].[boisson]    Script Date: 18/04/2018 13:42:44 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[boisson](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TypeBoisson] [varchar](30) NULL,
 CONSTRAINT [PK_boisson] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

