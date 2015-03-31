﻿'------------------------------------------------------------------------------
' <auto-generated>
'     此代码由工具生成。
'     运行时版本:4.0.30319.0
'
'     对此文件的更改可能会导致不正确的行为，并且如果
'     重新生成代码，这些更改将会丢失。
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="Blog")>  _
Partial Public Class BlogDbDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "可扩展性方法定义"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InsertUsers(instance As Users)
    End Sub
  Partial Private Sub UpdateUsers(instance As Users)
    End Sub
  Partial Private Sub DeleteUsers(instance As Users)
    End Sub
  Partial Private Sub InsertArticleHistorys(instance As ArticleHistorys)
    End Sub
  Partial Private Sub UpdateArticleHistorys(instance As ArticleHistorys)
    End Sub
  Partial Private Sub DeleteArticleHistorys(instance As ArticleHistorys)
    End Sub
  Partial Private Sub InsertArticles(instance As Articles)
    End Sub
  Partial Private Sub UpdateArticles(instance As Articles)
    End Sub
  Partial Private Sub DeleteArticles(instance As Articles)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.System.Configuration.ConfigurationManager.ConnectionStrings("BlogConnectionString1").ConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property Users() As System.Data.Linq.Table(Of Users)
		Get
			Return Me.GetTable(Of Users)
		End Get
	End Property
	
	Public ReadOnly Property ArticleHistorys() As System.Data.Linq.Table(Of ArticleHistorys)
		Get
			Return Me.GetTable(Of ArticleHistorys)
		End Get
	End Property
	
	Public ReadOnly Property Articles() As System.Data.Linq.Table(Of Articles)
		Get
			Return Me.GetTable(Of Articles)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Users")>  _
Partial Public Class Users
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _UserID As Integer
	
	Private _UserCode As String
	
	Private _UserName As String
	
	Private _Password As String
	
	Private _Email As String
	
    #Region "可扩展性方法定义"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnUserIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnUserIDChanged()
    End Sub
    Partial Private Sub OnUserCodeChanging(value As String)
    End Sub
    Partial Private Sub OnUserCodeChanged()
    End Sub
    Partial Private Sub OnUserNameChanging(value As String)
    End Sub
    Partial Private Sub OnUserNameChanged()
    End Sub
    Partial Private Sub OnPasswordChanging(value As String)
    End Sub
    Partial Private Sub OnPasswordChanged()
    End Sub
    Partial Private Sub OnEmailChanging(value As String)
    End Sub
    Partial Private Sub OnEmailChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_UserID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property UserID() As Integer
		Get
			Return Me._UserID
		End Get
		Set
			If ((Me._UserID = value)  _
						= false) Then
				Me.OnUserIDChanging(value)
				Me.SendPropertyChanging
				Me._UserID = value
				Me.SendPropertyChanged("UserID")
				Me.OnUserIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_UserCode", DbType:="NVarChar(50)")>  _
	Public Property UserCode() As String
		Get
			Return Me._UserCode
		End Get
		Set
			If (String.Equals(Me._UserCode, value) = false) Then
				Me.OnUserCodeChanging(value)
				Me.SendPropertyChanging
				Me._UserCode = value
				Me.SendPropertyChanged("UserCode")
				Me.OnUserCodeChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_UserName", DbType:="NVarChar(100)")>  _
	Public Property UserName() As String
		Get
			Return Me._UserName
		End Get
		Set
			If (String.Equals(Me._UserName, value) = false) Then
				Me.OnUserNameChanging(value)
				Me.SendPropertyChanging
				Me._UserName = value
				Me.SendPropertyChanged("UserName")
				Me.OnUserNameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Password", DbType:="NVarChar(1000)")>  _
	Public Property Password() As String
		Get
			Return Me._Password
		End Get
		Set
			If (String.Equals(Me._Password, value) = false) Then
				Me.OnPasswordChanging(value)
				Me.SendPropertyChanging
				Me._Password = value
				Me.SendPropertyChanged("Password")
				Me.OnPasswordChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Email", DbType:="NVarChar(1000)")>  _
	Public Property Email() As String
		Get
			Return Me._Email
		End Get
		Set
			If (String.Equals(Me._Email, value) = false) Then
				Me.OnEmailChanging(value)
				Me.SendPropertyChanging
				Me._Email = value
				Me.SendPropertyChanged("Email")
				Me.OnEmailChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.ArticleHistorys")>  _
Partial Public Class ArticleHistorys
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _ID As Integer
	
	Private _ArticleID As Integer
	
	Private _UserID As System.Nullable(Of Integer)
	
	Private _UpdateDate As System.Nullable(Of Date)
	
	Private _ArticleTile As String
	
	Private _ArticleContent As String
	
	Private _Likes As System.Nullable(Of Integer)
	
	Private _DisLiks As System.Nullable(Of Integer)
	
    #Region "可扩展性方法定义"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnIDChanged()
    End Sub
    Partial Private Sub OnArticleIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnArticleIDChanged()
    End Sub
    Partial Private Sub OnUserIDChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnUserIDChanged()
    End Sub
    Partial Private Sub OnUpdateDateChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnUpdateDateChanged()
    End Sub
    Partial Private Sub OnArticleTileChanging(value As String)
    End Sub
    Partial Private Sub OnArticleTileChanged()
    End Sub
    Partial Private Sub OnArticleContentChanging(value As String)
    End Sub
    Partial Private Sub OnArticleContentChanged()
    End Sub
    Partial Private Sub OnLikesChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnLikesChanged()
    End Sub
    Partial Private Sub OnDisLiksChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnDisLiksChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property ID() As Integer
		Get
			Return Me._ID
		End Get
		Set
			If ((Me._ID = value)  _
						= false) Then
				Me.OnIDChanging(value)
				Me.SendPropertyChanging
				Me._ID = value
				Me.SendPropertyChanged("ID")
				Me.OnIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ArticleID", DbType:="Int NOT NULL")>  _
	Public Property ArticleID() As Integer
		Get
			Return Me._ArticleID
		End Get
		Set
			If ((Me._ArticleID = value)  _
						= false) Then
				Me.OnArticleIDChanging(value)
				Me.SendPropertyChanging
				Me._ArticleID = value
				Me.SendPropertyChanged("ArticleID")
				Me.OnArticleIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_UserID", DbType:="Int")>  _
	Public Property UserID() As System.Nullable(Of Integer)
		Get
			Return Me._UserID
		End Get
		Set
			If (Me._UserID.Equals(value) = false) Then
				Me.OnUserIDChanging(value)
				Me.SendPropertyChanging
				Me._UserID = value
				Me.SendPropertyChanged("UserID")
				Me.OnUserIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_UpdateDate", DbType:="DateTime")>  _
	Public Property UpdateDate() As System.Nullable(Of Date)
		Get
			Return Me._UpdateDate
		End Get
		Set
			If (Me._UpdateDate.Equals(value) = false) Then
				Me.OnUpdateDateChanging(value)
				Me.SendPropertyChanging
				Me._UpdateDate = value
				Me.SendPropertyChanged("UpdateDate")
				Me.OnUpdateDateChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ArticleTile", DbType:="NVarChar(500)")>  _
	Public Property ArticleTile() As String
		Get
			Return Me._ArticleTile
		End Get
		Set
			If (String.Equals(Me._ArticleTile, value) = false) Then
				Me.OnArticleTileChanging(value)
				Me.SendPropertyChanging
				Me._ArticleTile = value
				Me.SendPropertyChanged("ArticleTile")
				Me.OnArticleTileChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ArticleContent", DbType:="Text", UpdateCheck:=UpdateCheck.Never)>  _
	Public Property ArticleContent() As String
		Get
			Return Me._ArticleContent
		End Get
		Set
			If (String.Equals(Me._ArticleContent, value) = false) Then
				Me.OnArticleContentChanging(value)
				Me.SendPropertyChanging
				Me._ArticleContent = value
				Me.SendPropertyChanged("ArticleContent")
				Me.OnArticleContentChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Likes", DbType:="Int")>  _
	Public Property Likes() As System.Nullable(Of Integer)
		Get
			Return Me._Likes
		End Get
		Set
			If (Me._Likes.Equals(value) = false) Then
				Me.OnLikesChanging(value)
				Me.SendPropertyChanging
				Me._Likes = value
				Me.SendPropertyChanged("Likes")
				Me.OnLikesChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_DisLiks", DbType:="Int")>  _
	Public Property DisLiks() As System.Nullable(Of Integer)
		Get
			Return Me._DisLiks
		End Get
		Set
			If (Me._DisLiks.Equals(value) = false) Then
				Me.OnDisLiksChanging(value)
				Me.SendPropertyChanging
				Me._DisLiks = value
				Me.SendPropertyChanged("DisLiks")
				Me.OnDisLiksChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Articles")>  _
Partial Public Class Articles
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _ID As Integer
	
	Private _ArticleTitle As String
	
	Private _ArticleContent As String
	
	Private _CreatedOn As System.Nullable(Of Date)
	
	Private _LastUpdate As System.Nullable(Of Date)
	
	Private _UserID As Integer
	
	Private _IsCaoGao As System.Nullable(Of Boolean)
	
	Private _Likes As System.Nullable(Of Integer)
	
	Private _DisLikes As System.Nullable(Of Integer)
	
	Private _ForDate As System.Nullable(Of Date)
	
	Private _ArticleType As System.Nullable(Of Byte)
	
    #Region "可扩展性方法定义"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnIDChanged()
    End Sub
    Partial Private Sub OnArticleTitleChanging(value As String)
    End Sub
    Partial Private Sub OnArticleTitleChanged()
    End Sub
    Partial Private Sub OnArticleContentChanging(value As String)
    End Sub
    Partial Private Sub OnArticleContentChanged()
    End Sub
    Partial Private Sub OnCreatedOnChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnCreatedOnChanged()
    End Sub
    Partial Private Sub OnLastUpdateChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnLastUpdateChanged()
    End Sub
    Partial Private Sub OnUserIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnUserIDChanged()
    End Sub
    Partial Private Sub OnIsCaoGaoChanging(value As System.Nullable(Of Boolean))
    End Sub
    Partial Private Sub OnIsCaoGaoChanged()
    End Sub
    Partial Private Sub OnLikesChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnLikesChanged()
    End Sub
    Partial Private Sub OnDisLikesChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnDisLikesChanged()
    End Sub
    Partial Private Sub OnForDateChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnForDateChanged()
    End Sub
    Partial Private Sub OnArticleTypeChanging(value As System.Nullable(Of Byte))
    End Sub
    Partial Private Sub OnArticleTypeChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property ID() As Integer
		Get
			Return Me._ID
		End Get
		Set
			If ((Me._ID = value)  _
						= false) Then
				Me.OnIDChanging(value)
				Me.SendPropertyChanging
				Me._ID = value
				Me.SendPropertyChanged("ID")
				Me.OnIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ArticleTitle", DbType:="NVarChar(500)")>  _
	Public Property ArticleTitle() As String
		Get
			Return Me._ArticleTitle
		End Get
		Set
			If (String.Equals(Me._ArticleTitle, value) = false) Then
				Me.OnArticleTitleChanging(value)
				Me.SendPropertyChanging
				Me._ArticleTitle = value
				Me.SendPropertyChanged("ArticleTitle")
				Me.OnArticleTitleChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ArticleContent", DbType:="Text", UpdateCheck:=UpdateCheck.Never)>  _
	Public Property ArticleContent() As String
		Get
			Return Me._ArticleContent
		End Get
		Set
			If (String.Equals(Me._ArticleContent, value) = false) Then
				Me.OnArticleContentChanging(value)
				Me.SendPropertyChanging
				Me._ArticleContent = value
				Me.SendPropertyChanged("ArticleContent")
				Me.OnArticleContentChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CreatedOn", DbType:="DateTime")>  _
	Public Property CreatedOn() As System.Nullable(Of Date)
		Get
			Return Me._CreatedOn
		End Get
		Set
			If (Me._CreatedOn.Equals(value) = false) Then
				Me.OnCreatedOnChanging(value)
				Me.SendPropertyChanging
				Me._CreatedOn = value
				Me.SendPropertyChanged("CreatedOn")
				Me.OnCreatedOnChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_LastUpdate", DbType:="DateTime")>  _
	Public Property LastUpdate() As System.Nullable(Of Date)
		Get
			Return Me._LastUpdate
		End Get
		Set
			If (Me._LastUpdate.Equals(value) = false) Then
				Me.OnLastUpdateChanging(value)
				Me.SendPropertyChanging
				Me._LastUpdate = value
				Me.SendPropertyChanged("LastUpdate")
				Me.OnLastUpdateChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_UserID", DbType:="Int NOT NULL")>  _
	Public Property UserID() As Integer
		Get
			Return Me._UserID
		End Get
		Set
			If ((Me._UserID = value)  _
						= false) Then
				Me.OnUserIDChanging(value)
				Me.SendPropertyChanging
				Me._UserID = value
				Me.SendPropertyChanged("UserID")
				Me.OnUserIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_IsCaoGao", DbType:="Bit")>  _
	Public Property IsCaoGao() As System.Nullable(Of Boolean)
		Get
			Return Me._IsCaoGao
		End Get
		Set
			If (Me._IsCaoGao.Equals(value) = false) Then
				Me.OnIsCaoGaoChanging(value)
				Me.SendPropertyChanging
				Me._IsCaoGao = value
				Me.SendPropertyChanged("IsCaoGao")
				Me.OnIsCaoGaoChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Likes", DbType:="Int")>  _
	Public Property Likes() As System.Nullable(Of Integer)
		Get
			Return Me._Likes
		End Get
		Set
			If (Me._Likes.Equals(value) = false) Then
				Me.OnLikesChanging(value)
				Me.SendPropertyChanging
				Me._Likes = value
				Me.SendPropertyChanged("Likes")
				Me.OnLikesChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_DisLikes", DbType:="Int")>  _
	Public Property DisLikes() As System.Nullable(Of Integer)
		Get
			Return Me._DisLikes
		End Get
		Set
			If (Me._DisLikes.Equals(value) = false) Then
				Me.OnDisLikesChanging(value)
				Me.SendPropertyChanging
				Me._DisLikes = value
				Me.SendPropertyChanged("DisLikes")
				Me.OnDisLikesChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ForDate", DbType:="DateTime")>  _
	Public Property ForDate() As System.Nullable(Of Date)
		Get
			Return Me._ForDate
		End Get
		Set
			If (Me._ForDate.Equals(value) = false) Then
				Me.OnForDateChanging(value)
				Me.SendPropertyChanging
				Me._ForDate = value
				Me.SendPropertyChanged("ForDate")
				Me.OnForDateChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ArticleType", DbType:="TinyInt")>  _
	Public Property ArticleType() As System.Nullable(Of Byte)
		Get
			Return Me._ArticleType
		End Get
		Set
			If (Me._ArticleType.Equals(value) = false) Then
				Me.OnArticleTypeChanging(value)
				Me.SendPropertyChanging
				Me._ArticleType = value
				Me.SendPropertyChanged("ArticleType")
				Me.OnArticleTypeChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class
