USE [VersionManager]
GO
/****** Object:  Table [dbo].[Versions]    Script Date: 2020/10/01 22:46:26  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Versions](
	[ID] [int] NOT NULL,
	[VersionCode] [varchar](50) NULL,
	[VersionName] [nvarchar](200) NULL,
	[DllPath] [nvarchar](250) NULL,
	[StructureScriptPath] [nvarchar](250) NULL,
	[AlterScriptPath] [nvarchar](250) NULL,
	[VersionDescription] [nvarchar](500) NULL,
	[CreationDateTime] [datetime] NULL,
	[EditionDateTime] [datetime] NULL,
 CONSTRAINT [PK_Version] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Versions] ([ID], [VersionCode], [VersionName], [DllPath], [StructureScriptPath], [AlterScriptPath], [VersionDescription], [CreationDateTime], [EditionDateTime]) VALUES (1, N'1', N'Version_1', N'F:\Programming\Ghafouri\VersionManager\Dlls', N'F:\Programming\Ghafouri\VersionManager\CreateTable.sql', N'F:\Programming\Ghafouri\VersionManager\CreateSelect.sql', N'dsdc', CAST(N'2020-08-21 18:43:51.530' AS DateTime), CAST(N'2020-10-01 21:55:06.557' AS DateTime))
GO
INSERT [dbo].[Versions] ([ID], [VersionCode], [VersionName], [DllPath], [StructureScriptPath], [AlterScriptPath], [VersionDescription], [CreationDateTime], [EditionDateTime]) VALUES (2, N'2', N'Version_2', N'F:\Programming\Ghafouri\VersionManager\Dlls', N'F:\Programming\Ghafouri\VersionManager\CreateTable.sql', N'F:\Programming\Ghafouri\VersionManager\CreateSelect.sql', N'dsvsd', CAST(N'2020-08-21 18:47:42.147' AS DateTime), NULL)
GO
/****** Object:  StoredProcedure [dbo].[Versions_Delete]    Script Date: 2020/10/01 22:46:26  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Versions_Delete] @ID INT
AS
BEGIN


    DELETE FROM dbo.Versions
    WHERE ID = @ID;

END;
GO
/****** Object:  StoredProcedure [dbo].[Versions_INSERT]    Script Date: 2020/10/01 22:46:26  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Versions_INSERT]
    @VersionCode VARCHAR(50),
    @VersionName VARCHAR(200),
    @DllPath VARCHAR(250),
    @StructureScriptPath VARCHAR(250),
    @AlterScriptPath VARCHAR(250),
    @VersionDescription VARCHAR(MAX)
AS
BEGIN
    DECLARE @ID INT;

    SELECT @ID = ISNULL(MAX(ID), 0) + 1
    FROM dbo.Versions;

    INSERT INTO dbo.Versions
    (
        ID,
        VersionCode,
        VersionName,
        DllPath,
        StructureScriptPath,
        AlterScriptPath,
        VersionDescription,
        CreationDateTime,
        EditionDateTime
    )
    VALUES
    (   @ID,                  -- ID - int
        @VersionCode,         -- VersionCode - varchar(50)
        @VersionName,         -- VersionName - nvarchar(200)
        @DllPath,             -- DllPath - nvarchar(250)
        @StructureScriptPath, -- StructureScriptPath - nvarchar(250)
        @AlterScriptPath,     -- AlterScriptPath - nvarchar(250)
        @VersionDescription,  -- VersionDescription - nvarchar(500)
        GETDATE(),            -- CreationDateTime - datetime
        NULL                  -- EditionDateTime - datetime
        );

    SELECT ID,
           VersionCode,
           VersionName,
           DllPath,
           StructureScriptPath,
           AlterScriptPath,
           VersionDescription,
           CreationDateTime,
           EditionDateTime
    FROM dbo.Versions
    WHERE ID = @ID;
END;
GO
/****** Object:  StoredProcedure [dbo].[Versions_MaxCode]    Script Date: 2020/10/01 22:46:26  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Versions_MaxCode]
AS
BEGIN

    SELECT ISNULL(CAST(MAX(CAST(VersionCode AS BIGINT)) + 1 AS VARCHAR),'1') AS MaxCode
    FROM dbo.Versions;

END;
GO
/****** Object:  StoredProcedure [dbo].[Versions_Select]    Script Date: 2020/10/01 22:46:26  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Versions_Select]
AS
BEGIN
    SELECT ID,
           VersionCode,
           VersionName,
           DllPath,
           StructureScriptPath,
           AlterScriptPath,
           VersionDescription,
           CreationDateTime,
           EditionDateTime
    FROM dbo.Versions;
END;
GO
/****** Object:  StoredProcedure [dbo].[Versions_SelectById]    Script Date: 2020/10/01 22:46:26  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Versions_SelectById]
@Id INT 
AS
BEGIN
    SELECT ID,
           VersionCode,
           VersionName,
           DllPath,
           StructureScriptPath,
           AlterScriptPath,
           VersionDescription,
           CreationDateTime,
           EditionDateTime
    FROM dbo.Versions
	WHERE ID = @Id;
END;
GO
/****** Object:  StoredProcedure [dbo].[Versions_SelectForUpdate]    Script Date: 2020/10/01 22:46:26  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Versions_SelectForUpdate]
@VersionCode VARCHAR(50) 
AS
BEGIN
    SELECT ID,
           VersionCode,
           VersionName,
           DllPath,
           StructureScriptPath,
           AlterScriptPath,
           VersionDescription,
           CreationDateTime,
           EditionDateTime
    FROM dbo.Versions
	WHERE VersionCode >  @VersionCode;
END;
GO
/****** Object:  StoredProcedure [dbo].[Versions_Update]    Script Date: 2020/10/01 22:46:26  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Versions_Update]
    @ID INT,
    @VersionCode VARCHAR(50),
    @VersionName VARCHAR(200),
    @DllPath VARCHAR(250),
    @StructureScriptPath VARCHAR(250),
    @AlterScriptPath VARCHAR(250),
    @VersionDescription VARCHAR(MAX)
AS
BEGIN


    UPDATE dbo.Versions
    SET VersionCode = @VersionCode,
        VersionName = @VersionName,
        DllPath = @DllPath,
        StructureScriptPath = @StructureScriptPath,
        AlterScriptPath = @AlterScriptPath,
        VersionDescription = @VersionDescription,
        EditionDateTime = GETDATE()
    WHERE ID = @ID;
END;
GO
