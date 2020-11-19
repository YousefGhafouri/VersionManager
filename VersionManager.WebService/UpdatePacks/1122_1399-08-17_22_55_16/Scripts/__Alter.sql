
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
END