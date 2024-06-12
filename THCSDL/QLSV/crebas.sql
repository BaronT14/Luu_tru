/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     5/17/2024 9:49:30 PM                         */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('KETQUA') and o.name = 'FK_KETQUA_RELATIONS_MONHOC')
alter table KETQUA
   drop constraint FK_KETQUA_RELATIONS_MONHOC
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('KETQUA') and o.name = 'FK_KETQUA_RELATIONS_SINHVIEN')
alter table KETQUA
   drop constraint FK_KETQUA_RELATIONS_SINHVIEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SINHVIEN') and o.name = 'FK_SINHVIEN_RELATIONS_LOP')
alter table SINHVIEN
   drop constraint FK_SINHVIEN_RELATIONS_LOP
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('KETQUA')
            and   name  = 'RELATIONSHIP_4_FK'
            and   indid > 0
            and   indid < 255)
   drop index KETQUA.RELATIONSHIP_4_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('KETQUA')
            and   name  = 'RELATIONSHIP_3_FK'
            and   indid > 0
            and   indid < 255)
   drop index KETQUA.RELATIONSHIP_3_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('KETQUA')
            and   type = 'U')
   drop table KETQUA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LOP')
            and   type = 'U')
   drop table LOP
go

if exists (select 1
            from  sysobjects
           where  id = object_id('MONHOC')
            and   type = 'U')
   drop table MONHOC
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SINHVIEN')
            and   name  = 'RELATIONSHIP_1_FK'
            and   indid > 0
            and   indid < 255)
   drop index SINHVIEN.RELATIONSHIP_1_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SINHVIEN')
            and   type = 'U')
   drop table SINHVIEN
go

/*==============================================================*/
/* Table: KETQUA                                                */
/*==============================================================*/
create table KETQUA (
   MAMH                 char(10)             not null,
   MSSV                 char(10)             not null,
   DIEM                 float                null,
   constraint PK_KETQUA primary key (MAMH, MSSV)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_3_FK                                     */
/*==============================================================*/




create nonclustered index RELATIONSHIP_3_FK on KETQUA (MAMH ASC)
go

/*==============================================================*/
/* Index: RELATIONSHIP_4_FK                                     */
/*==============================================================*/




create nonclustered index RELATIONSHIP_4_FK on KETQUA (MSSV ASC)
go

/*==============================================================*/
/* Table: LOP                                                   */
/*==============================================================*/
create table LOP (
   MALOP                char(10)             not null,
   TENLOP               nvarchar(50)         null,
   SISO                 int                  null,
   constraint PK_LOP primary key (MALOP)
)
go

/*==============================================================*/
/* Table: MONHOC                                                */
/*==============================================================*/
create table MONHOC (
   MAMH                 char(10)             not null,
   TENMH                nvarchar(50)         null,
   SOTC                 int                  null,
   constraint PK_MONHOC primary key (MAMH)
)
go

/*==============================================================*/
/* Table: SINHVIEN                                              */
/*==============================================================*/
create table SINHVIEN (
   MSSV                 char(10)             not null,
   MALOP                char(10)             null,
   HOTEN                nvarchar(50)         null,
   GIOITINH             nvarchar(3)          null,
   NGAYSINH             datetime             null,
   constraint PK_SINHVIEN primary key (MSSV)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_1_FK                                     */
/*==============================================================*/




create nonclustered index RELATIONSHIP_1_FK on SINHVIEN (MALOP ASC)
go

alter table KETQUA
   add constraint FK_KETQUA_RELATIONS_MONHOC foreign key (MAMH)
      references MONHOC (MAMH)
go

alter table KETQUA
   add constraint FK_KETQUA_RELATIONS_SINHVIEN foreign key (MSSV)
      references SINHVIEN (MSSV)
go

alter table SINHVIEN
   add constraint FK_SINHVIEN_RELATIONS_LOP foreign key (MALOP)
      references LOP (MALOP)
go

