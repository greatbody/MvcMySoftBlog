/*
   2015年3月31日23:47:53
   用户: sa
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
CREATE TABLE dbo.Tmp_Articles
	(
	ID int NOT NULL IDENTITY (1, 1),
	ArticleTitle nvarchar(500) NULL,
	ArticleContent text NULL,
	CreatedOn datetime NULL,
	LastUpdate datetime NULL,
	UserID int NOT NULL,
	IsCaoGao bit NULL,
	Likes int NULL,
	DisLikes int NULL,
	ForDate datetime NULL,
	ArticleType tinyint NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_Articles SET (LOCK_ESCALATION = TABLE)
GO
SET IDENTITY_INSERT dbo.Tmp_Articles ON
GO
IF EXISTS(SELECT * FROM dbo.Articles)
	 EXEC('INSERT INTO dbo.Tmp_Articles (ID, ArticleTitle, ArticleContent, CreatedOn, LastUpdate, UserID, IsCaoGao, Likes, DisLikes, ForDate, ArticleType)
		SELECT ID, ArticleTitle, ArticleContent, CreatedOn, LastUpdate, UserID, IsCaoGao, Likes, DisLikes, ForDate, CONVERT(tinyint, ArticleType) FROM dbo.Articles WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_Articles OFF
GO
DROP TABLE dbo.Articles
GO
EXECUTE sp_rename N'dbo.Tmp_Articles', N'Articles', 'OBJECT' 
GO
ALTER TABLE dbo.Articles ADD CONSTRAINT
	PK_Articles PRIMARY KEY CLUSTERED 
	(
	ID
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
select Has_Perms_By_Name(N'dbo.Articles', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Articles', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Articles', 'Object', 'CONTROL') as Contr_Per 