/*网站基本信息*/
truncate table MldWebSite
insert into MldWebSite values('','','','','')
/*管理员表*/
truncate table MldAdmin
insert into MldAdmin values(1,'admin0909','0a290b7b649f452b30901aa273e16a87',GETDATE(),GETDATE(),'127.0.0.1',0)
go
truncate table MldProductCategory
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(0,N'工作台',0,GETDATE())/*1*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(0,N'工业铝型材',0,GETDATE())/*2*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(0,N'围栏及防护罩',0,GETDATE())/*3*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(0,N'工业梯/踏台/工业平台',0,GETDATE())/*4*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(0,N'铝型材配件',0,GETDATE())/*5*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(0,N'开模定制',0,GETDATE())/*6*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(0,N'铝型材框架应用',0,GETDATE())/*7*/

/*工作台*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(1,N'防静电工作台',0,GETDATE())/*8*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(1,N'流水线工作台',0,GETDATE())/*9*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(1,N'车间工作台',0,GETDATE())/*10*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(1,N'铝型材工作台',0,GETDATE())/*11*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(1,N'重型工作台',0,GETDATE())/*12*/

/*工业铝型材*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(2,N'15系列',0,GETDATE())/*13*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(2,N'16系列',0,GETDATE())/*14*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(2,N'20系列',0,GETDATE())/*15*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(2,N'25系列',0,GETDATE())/*16*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(2,N'30系列',0,GETDATE())/*17*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(2,N'35系列',0,GETDATE())/*18*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(2,N'40系列',0,GETDATE())/*19*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(2,N'45系列',0,GETDATE())/*20*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(2,N'50系列',0,GETDATE())/*21*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(2,N'60系列',0,GETDATE())/*22*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(2,N'80系列',0,GETDATE())/*23*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(2,N'90系列',0,GETDATE())/*24*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(2,N'100系列',0,GETDATE())/*25*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(2,N'倍数链型材',0,GETDATE())/*26*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(2,N'角铝',0,GETDATE())/*27*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(2,N'线槽/槽条型材',0,GETDATE())/*28*/

/*围栏及防护罩*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(3,N'防护罩',0,GETDATE())/*29*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(3,N'工业围栏',0,GETDATE())/*30*/

/*工业梯/踏台/工业平台*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(4,N'工业平台',0,GETDATE())/*31*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(4,N'工业踏步登高梯',0,GETDATE())/*32*/

/*铝型材配件*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(5,N'角件',0,GETDATE())/*33*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(5,N'支撑组件',0,GETDATE())/*34*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(5,N'专用连接件',0,GETDATE())/*35*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(5,N'专用螺栓螺母',0,GETDATE())/*36*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(5,N'装配件',0,GETDATE())/*37*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(5,N'装饰件',0,GETDATE())/*38*/

/*开模定制*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(6,N'导轨',0,GETDATE())/*39*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(6,N'方管',0,GETDATE())/*40*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(6,N'散热',0,GETDATE())/*41*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(6,N'异型管',0,GETDATE())/*42*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(6,N'圆管',0,GETDATE())/*43*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(6,N'装饰',0,GETDATE())/*44*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(6,N'其它',0,GETDATE())/*45*/

/*铝型材框架应用*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(7,N'洁净房',0,GETDATE())/*46*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(7,N'流水线支架',0,GETDATE())/*47*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(7,N'铝型材货架',0,GETDATE())/*48*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(7,N'铝型材机柜',0,GETDATE())/*49*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(7,N'铝型材设备框架',0,GETDATE())/*50*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(7,N'铝型材展架',0,GETDATE())/*51*/

go


truncate table MldPage
insert into MldPage values(N'联系我们','','','','')
insert into MldPage values(N'仓储配送','','','','')
insert into MldPage values(N'皇闽视频','','','','')
insert into MldPage values(N'加工工艺','','','','')
insert into MldPage values(N'企业文化','','','','')
insert into MldPage values(N'荣誉资质','','','','')
insert into MldPage values(N'员工风采','','','','')
