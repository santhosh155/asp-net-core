# asp-net-core


SQL Table DDl

#USER Class

CREATE TABLE [dbo].[Users](
	[Id] [uniqueidentifier] NOT NULL,
	[FullName] [varchar](50) NULL,
	[UserName] [varchar](50) NULL,
	[Password] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]