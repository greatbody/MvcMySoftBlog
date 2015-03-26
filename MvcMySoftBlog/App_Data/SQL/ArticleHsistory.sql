/*
   2015年3月26日22:53:38
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
CREATE TABLE dbo.ArticleHsistory
	(
	ID int NOT NULL,
	ArticleID int NULL,
	UserID int NULL,
	UpdateDate datetime NULL,
	ArticleTile nvarchar(500) NULL,
	ArticleContent text NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE dbo.ArticleHsistory ADD CONSTRAINT
	PK_ArticleHsistory PRIMARY KEY CLUSTERED 
	(
	ID
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.ArticleHsistory SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.ArticleHsistory', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.ArticleHsistory', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.ArticleHsistory', 'Object', 'CONTROL') as Contr_Per 