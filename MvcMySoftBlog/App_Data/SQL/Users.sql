/*
   2015年3月26日22:38:52
   用户: team
   服务器: SUNSOFT-PC\SUNSOFT
   数据库: Blog
   应用程序: 
*/

/* 为了防止任何可能出现的数据丢失问题，您应该先仔细检查此脚本，然后再在数据库设计器的上下文之外运行此脚本。*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_Users
	(
	ID int NOT NULL IDENTITY (1, 1),
	UserName nvarchar(MAX) NULL,
	UserCode nvarchar(MAX) NULL,
	Age int NULL,
	Sex nvarchar(50) NULL,
	RegDate datetime NULL,
	Role nvarchar(50) NULL,
	IsLocked tinyint NULL,
	IsEnabled tinyint NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_Users SET (LOCK_ESCALATION = TABLE)
GO
SET IDENTITY_INSERT dbo.Tmp_Users ON
GO
IF EXISTS(SELECT * FROM dbo.Users)
	 EXEC('INSERT INTO dbo.Tmp_Users (ID, UserName, UserCode, Age, Sex, RegDate, Role, IsLocked, IsEnabled)
		SELECT ID, UserName, UserCode, CONVERT(int, Age), CONVERT(nvarchar(50), Sex), CONVERT(datetime, RegDate), CONVERT(nvarchar(50), Role), CONVERT(tinyint, IsLocked), CONVERT(tinyint, IsEnabled) FROM dbo.Users WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_Users OFF
GO
DROP TABLE dbo.Users
GO
EXECUTE sp_rename N'dbo.Tmp_Users', N'Users', 'OBJECT' 
GO
ALTER TABLE dbo.Users ADD CONSTRAINT
	PK_Users PRIMARY KEY CLUSTERED 
	(
	ID
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
select Has_Perms_By_Name(N'dbo.Users', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Users', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Users', 'Object', 'CONTROL') as Contr_Per 