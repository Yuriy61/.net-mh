/*��վ������Ϣ*/
truncate table MldWebSite
insert into MldWebSite values('','','','','')
/*����Ա��*/
truncate table MldAdmin
insert into MldAdmin values(1,'admin0909','0a290b7b649f452b30901aa273e16a87',GETDATE(),GETDATE(),'127.0.0.1',0)
go
truncate table MldProductCategory
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(0,N'����̨',0,GETDATE())/*1*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(0,N'��ҵ���Ͳ�',0,GETDATE())/*2*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(0,N'Χ����������',0,GETDATE())/*3*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(0,N'��ҵ��/̨̤/��ҵƽ̨',0,GETDATE())/*4*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(0,N'���Ͳ����',0,GETDATE())/*5*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(0,N'��ģ����',0,GETDATE())/*6*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(0,N'���ͲĿ��Ӧ��',0,GETDATE())/*7*/

/*����̨*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(1,N'�����繤��̨',0,GETDATE())/*8*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(1,N'��ˮ�߹���̨',0,GETDATE())/*9*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(1,N'���乤��̨',0,GETDATE())/*10*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(1,N'���ͲĹ���̨',0,GETDATE())/*11*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(1,N'���͹���̨',0,GETDATE())/*12*/

/*��ҵ���Ͳ�*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(2,N'15ϵ��',0,GETDATE())/*13*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(2,N'16ϵ��',0,GETDATE())/*14*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(2,N'20ϵ��',0,GETDATE())/*15*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(2,N'25ϵ��',0,GETDATE())/*16*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(2,N'30ϵ��',0,GETDATE())/*17*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(2,N'35ϵ��',0,GETDATE())/*18*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(2,N'40ϵ��',0,GETDATE())/*19*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(2,N'45ϵ��',0,GETDATE())/*20*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(2,N'50ϵ��',0,GETDATE())/*21*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(2,N'60ϵ��',0,GETDATE())/*22*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(2,N'80ϵ��',0,GETDATE())/*23*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(2,N'90ϵ��',0,GETDATE())/*24*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(2,N'100ϵ��',0,GETDATE())/*25*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(2,N'�������Ͳ�',0,GETDATE())/*26*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(2,N'����',0,GETDATE())/*27*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(2,N'�߲�/�����Ͳ�',0,GETDATE())/*28*/

/*Χ����������*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(3,N'������',0,GETDATE())/*29*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(3,N'��ҵΧ��',0,GETDATE())/*30*/

/*��ҵ��/̨̤/��ҵƽ̨*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(4,N'��ҵƽ̨',0,GETDATE())/*31*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(4,N'��ҵ̤���Ǹ���',0,GETDATE())/*32*/

/*���Ͳ����*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(5,N'�Ǽ�',0,GETDATE())/*33*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(5,N'֧�����',0,GETDATE())/*34*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(5,N'ר�����Ӽ�',0,GETDATE())/*35*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(5,N'ר����˨��ĸ',0,GETDATE())/*36*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(5,N'װ���',0,GETDATE())/*37*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(5,N'װ�μ�',0,GETDATE())/*38*/

/*��ģ����*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(6,N'����',0,GETDATE())/*39*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(6,N'����',0,GETDATE())/*40*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(6,N'ɢ��',0,GETDATE())/*41*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(6,N'���͹�',0,GETDATE())/*42*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(6,N'Բ��',0,GETDATE())/*43*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(6,N'װ��',0,GETDATE())/*44*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(6,N'����',0,GETDATE())/*45*/

/*���ͲĿ��Ӧ��*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(7,N'�ྻ��',0,GETDATE())/*46*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(7,N'��ˮ��֧��',0,GETDATE())/*47*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(7,N'���ͲĻ���',0,GETDATE())/*48*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(7,N'���ͲĻ���',0,GETDATE())/*49*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(7,N'���Ͳ��豸���',0,GETDATE())/*50*/
insert into MldProductCategory(Tid,Name,[Order],AddTime) values(7,N'���Ͳ�չ��',0,GETDATE())/*51*/

go


truncate table MldPage
insert into MldPage values(N'��ϵ����','','','','')
insert into MldPage values(N'�ִ�����','','','','')
insert into MldPage values(N'������Ƶ','','','','')
insert into MldPage values(N'�ӹ�����','','','','')
insert into MldPage values(N'��ҵ�Ļ�','','','','')
insert into MldPage values(N'��������','','','','')
insert into MldPage values(N'Ա�����','','','','')
