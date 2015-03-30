/*
   2015年3月26日22:57:50
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
CREATE TABLE dbo.Tmp_ArticleHistorys
	(
	ID int NOT NULL,
	ArticleID int NOT NULL,
	UserID int NULL,
	UpdateDate datetime NULL,
	ArticleTile nvarchar(500) NULL,
	ArticleContent text NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_ArticleHistorys SET (LOCK_ESCALATION = TABLE)
GO
IF EXISTS(SELECT * FROM dbo.ArticleHistorys)
	 EXEC('INSERT INTO dbo.Tmp_ArticleHistorys (ID, ArticleID, UserID, UpdateDate, ArticleTile, ArticleContent)
		SELECT ID, ArticleID, UserID, UpdateDate, ArticleTile, ArticleContent FROM dbo.ArticleHistorys WITH (HOLDLOCK TABLOCKX)')
GO
DROP TABLE dbo.ArticleHistorys
GO
EXECUTE sp_rename N'dbo.Tmp_ArticleHistorys', N'ArticleHistorys', 'OBJECT' 
GO
ALTER TABLE dbo.ArticleHistorys ADD CONSTRAINT
	PK_ArticleHsistory PRIMARY KEY CLUSTERED 
	(
	ID
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
select Has_Perms_By_Name(N'dbo.ArticleHistorys', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.ArticleHistorys', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.ArticleHistorys', 'Object', 'CONTROL') as Contr_Per 

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
ALTER TABLE dbo.ArticleHistorys ADD
	Likes int NULL,
	DisLiks int NULL
GO
ALTER TABLE dbo.ArticleHistorys SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.ArticleHistorys', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.ArticleHistorys', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.ArticleHistorys', 'Object', 'CONTROL') as Contr_Per 