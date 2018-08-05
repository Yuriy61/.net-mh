if object_id(N'MldAdmin',N'U') is not null
drop table MldAdmin
go
create table MldAdmin(--管理员表
	ID int identity(1,1) primary key,
	Rid int not null default 0,
	Name nvarchar(32) not null unique,
	Pwd varchar(32) not null,
	AddTime datetime,
	LastLoginTime [datetime] ,
	LastLoginIP [varchar](15) ,
	IsLock [int]
)
go
if object_id(N'MldWebSite',N'U') is not null
drop table MldWebSite
go
create table MldWebSite(
	ID int identity(1,1) primary key,
	[Title] [nvarchar](128) NULL,
	[Logo] [varchar](64) NULL,
	[KeyWord] [nvarchar](256) NULL,
	[Description] [nvarchar](512) NULL,
	[Content] [nvarchar](max) NULL
)
go
if object_id(N'MldAdv',N'U') is not null
drop table MldAdv
go
create table MldAdv(--广告
	ID int identity(1,1) primary key,
	Title nvarchar(128),
	SubHead nvarchar(512),
	AdvType int,--广告类型1为banner
	Link nvarchar(128),
	Img varchar(128),
	[IsShow] [int],
	[Priority] [int]
)
go
create table MldProductCategory(
	ID int identity(1,1) primary key,
	Tid int,
	Name nvarchar(32),
	[Order] int,
	AddTime datetime
)
go
create table MldProduct(
	ID int identity(1,1) primary key,
	Cid int,
	AllShowFlag int,
	HomeShowFlag int,
	IsElite int,
	Name nvarchar(64),
	SubHead nvarchar(256),
	Img nvarchar(128),
	[Profile] nvarchar(32),
	[Application] nvarchar(128),
	Material nvarchar(64),
	[Weight] nvarchar(32),
	[Length] nvarchar(32),
	MassOfInertia nvarchar(64),
	SectionModulus nvarchar(64),
	ProfileImg nvarchar(128),
	Content nvarchar(max),
	AddTime datetime
)
go
create table MldNews(
	ID int identity(1,1) primary key,
	NewsType int,
	Title nvarchar(64),
	SubHead nvarchar(256),
	Img nvarchar(128),
	Content nvarchar(max),
	[IsShow] [int],
	[Priority] [int],
	AddTime datetime
)
go
create table MldForm(
	ID int identity(1,1) primary key,
	Name nvarchar(32),
	Phone nvarchar(32),
	Content nvarchar(512),
	AddTime datetime
)
go
create table MldPage(
	ID int identity(1,1) primary key,
	Title nvarchar(64),
	[KeyWord] [nvarchar](256),
	[Description] [nvarchar](512),
	[Intro] [nvarchar](max),
	[Content] [nvarchar](max)
)
go
create table MldComment(
	ID int identity(1,1) primary key,
	Content nvarchar(512),
	AddTime datetime
)
go
CREATE TABLE [dbo].[MldProductImg](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Pid] [int] NULL,
	[Img] [varchar](128) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

go
create table MldApplicationArea(
	ID int identity(1,1) primary key,
	Name nvarchar(32),
	HomeBg nvarchar(128),
	Icon nvarchar(128),
	SubHead nvarchar(128),
	Content nvarchar(max),
	HomeShowFlag int,
	AddTime datetime
)
go
alter table MldProduct add ShowType int
go
update MldProduct set ShowType=1

update MldProduct set ShowType=2 where Cid in(select ID from MldProductCategory where Tid=3)