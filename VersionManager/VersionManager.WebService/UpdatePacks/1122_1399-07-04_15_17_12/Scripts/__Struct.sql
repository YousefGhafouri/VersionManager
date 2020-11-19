
CREATE TABLE [dbo].[Versions](
	[ID] [INT] NOT NULL,
	[VersionCode] [VARCHAR](50) NULL,
	[VersionName] [NVARCHAR](200) NULL,
	[DllPath] [NVARCHAR](250) NULL,
	[StructureScriptPath] [NVARCHAR](250) NULL,
	[AlterScriptPath] [NVARCHAR](250) NULL,
	[VersionDescription] [NVARCHAR](500) NULL,
	[CreationDateTime] [DATETIME] NULL,
	[EditionDateTime] [DATETIME] NULL,
 CONSTRAINT [PK_Version] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]




CREATE TABLE [dbo].[Versions](
	[ID] [INT] NOT NULL,
	[VersionCode] [VARCHAR](50) NULL,
	[VersionName] [NVARCHAR](200) NULL,
	[DllPath] [NVARCHAR](250) NULL,
	[StructureScriptPath] [NVARCHAR](250) NULL,
	[AlterScriptPath] [NVARCHAR](250) NULL,
	[VersionDescription] [NVARCHAR](500) NULL,
	[CreationDateTime] [DATETIME] NULL,
	[EditionDateTime] [DATETIME] NULL,
 CONSTRAINT [PK_Version] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


