/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     05/12/2024 23:34:34                          */
/*==============================================================*/
create database QL_KHACHSAN
use QL_KHACHSAN
go
-------Tạo database trước------
if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CHITIETKH') and o.name = 'FK_CHITIETK_RELATIONS_HOADON')
alter table CHITIETKH
   drop constraint FK_CHITIETK_RELATIONS_HOADON
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CTDV') and o.name = 'FK_CTDV_CTDV_DICHVU')
alter table CTDV
   drop constraint FK_CTDV_CTDV_DICHVU
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CTDV') and o.name = 'FK_CTDV_CTDV2_HOADON')
alter table CTDV
   drop constraint FK_CTDV_CTDV2_HOADON
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CTHD') and o.name = 'FK_CTHD_CHTD3_HOADON')
alter table CTHD
   drop constraint FK_CTHD_CHTD3_HOADON
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CTHD') and o.name = 'FK_CTHD_CHTD4_PHONG')
alter table CTHD
   drop constraint FK_CTHD_CHTD4_PHONG
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HOADON') and o.name = 'FK_HOADON_RELATIONS_NHANVIEN')
alter table HOADON
   drop constraint FK_HOADON_RELATIONS_NHANVIEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HOADON') and o.name = 'FK_HOADON_RELATIONS_KHACHSAN')
alter table HOADON
   drop constraint FK_HOADON_RELATIONS_KHACHSAN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HOADON') and o.name = 'FK_HOADON_RELATIONS_KHACHHAN')
alter table HOADON
   drop constraint FK_HOADON_RELATIONS_KHACHHAN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HOADON') and o.name = 'FK_HOADON_RELATIONS_PHUONGTH')
alter table HOADON
   drop constraint FK_HOADON_RELATIONS_PHUONGTH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('NHANVIEN') and o.name = 'FK_NHANVIEN_RELATIONS_BOPHAN')
alter table NHANVIEN
   drop constraint FK_NHANVIEN_RELATIONS_BOPHAN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PHONG') and o.name = 'FK_PHONG_RELATIONS_LOAIPHON')
alter table PHONG
   drop constraint FK_PHONG_RELATIONS_LOAIPHON
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BOPHAN')
            and   type = 'U')
   drop table BOPHAN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CHITIETKH')
            and   name  = 'RELATIONSHIP_12_FK'
            and   indid > 0
            and   indid < 255)
   drop index CHITIETKH.RELATIONSHIP_12_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CHITIETKH')
            and   type = 'U')
   drop table CHITIETKH
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CTDV')
            and   name  = 'CTDV2_FK'
            and   indid > 0
            and   indid < 255)
   drop index CTDV.CTDV2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CTDV')
            and   name  = 'CTDV_FK'
            and   indid > 0
            and   indid < 255)
   drop index CTDV.CTDV_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CTDV')
            and   type = 'U')
   drop table CTDV
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CTHD')
            and   name  = 'CHTD4_FK'
            and   indid > 0
            and   indid < 255)
   drop index CTHD.CHTD4_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CTHD')
            and   name  = 'CHTD3_FK'
            and   indid > 0
            and   indid < 255)
   drop index CTHD.CHTD3_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CTHD')
            and   type = 'U')
   drop table CTHD
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DICHVU')
            and   type = 'U')
   drop table DICHVU
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('HOADON')
            and   name  = 'RELATIONSHIP_11_FK'
            and   indid > 0
            and   indid < 255)
   drop index HOADON.RELATIONSHIP_11_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('HOADON')
            and   name  = 'RELATIONSHIP_10_FK'
            and   indid > 0
            and   indid < 255)
   drop index HOADON.RELATIONSHIP_10_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('HOADON')
            and   name  = 'RELATIONSHIP_9_FK'
            and   indid > 0
            and   indid < 255)
   drop index HOADON.RELATIONSHIP_9_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('HOADON')
            and   name  = 'RELATIONSHIP_7_FK'
            and   indid > 0
            and   indid < 255)
   drop index HOADON.RELATIONSHIP_7_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('HOADON')
            and   type = 'U')
   drop table HOADON
go

if exists (select 1
            from  sysobjects
           where  id = object_id('KHACHHANG')
            and   type = 'U')
   drop table KHACHHANG
go

if exists (select 1
            from  sysobjects
           where  id = object_id('KHACHSAN')
            and   type = 'U')
   drop table KHACHSAN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LOAIPHONG')
            and   type = 'U')
   drop table LOAIPHONG
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('NHANVIEN')
            and   name  = 'RELATIONSHIP_5_FK'
            and   indid > 0
            and   indid < 255)
   drop index NHANVIEN.RELATIONSHIP_5_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('NHANVIEN')
            and   type = 'U')
   drop table NHANVIEN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PHONG')
            and   name  = 'RELATIONSHIP_8_FK'
            and   indid > 0
            and   indid < 255)
   drop index PHONG.RELATIONSHIP_8_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PHONG')
            and   type = 'U')
   drop table PHONG
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PHUONGTHUCTHANHTOAN')
            and   type = 'U')
   drop table PHUONGTHUCTHANHTOAN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAIKHOAN') and o.name = 'FK_TAIKHOAN_REFERENCE_NHANVIEN')
alter table TAIKHOAN
   drop constraint FK_TAIKHOAN_REFERENCE_NHANVIEN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAIKHOAN')
            and   type = 'U')
   drop table TAIKHOAN
go

/*==============================================================*/
/* Table: BOPHAN                                                */
/*==============================================================*/
create table BOPHAN (
   MABP                 varchar(10)          not null,
   TENBP                nvarchar(50)          null,
   constraint PK_BOPHAN primary key (MABP)
)
go

/*==============================================================*/
/* Table: CHITIETKH                                             */
/*==============================================================*/
create table CHITIETKH (
   MAHD                 varchar(10)          null,
   HOTEN                nvarchar(50)          null,
   SOCCCD               varchar(12)          null,
   NGSINH               datetime             null,
   GIOITINH             nvarchar(10)          null,
   QUANHE               nvarchar(50)          null
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_12_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_12_FK on CHITIETKH (MAHD ASC)
go

/*==============================================================*/
/* Table: CTDV                                                  */
/*==============================================================*/
create table CTDV (
   MADV                 varchar(10)          not null,
   MAHD                 varchar(10)          not null,
   SOLUONG              int                  null,
   constraint PK_CTDV primary key (MADV, MAHD)
)
go

/*==============================================================*/
/* Index: CTDV_FK                                               */
/*==============================================================*/




create nonclustered index CTDV_FK on CTDV (MADV ASC)
go

/*==============================================================*/
/* Index: CTDV2_FK                                              */
/*==============================================================*/




create nonclustered index CTDV2_FK on CTDV (MAHD ASC)
go

/*==============================================================*/
/* Table: CTHD                                                  */
/*==============================================================*/
create table CTHD (
   MAHD                 varchar(10)          not null,
   MAPH                 varchar(10)          not null,
   NGAYNHAN             datetime             null,
   NGAYTRA              datetime             null,
   SOLUONG              int                  null,
   TINHTRANG            nvarchar(50)          null,
   THANHTIEN            money                null,
   constraint PK_CTHD primary key (MAHD, MAPH)
)
go

/*==============================================================*/
/* Index: CHTD3_FK                                              */
/*==============================================================*/




create nonclustered index CHTD3_FK on CTHD (MAHD ASC)
go

/*==============================================================*/
/* Index: CHTD4_FK                                              */
/*==============================================================*/




create nonclustered index CHTD4_FK on CTHD (MAPH ASC)
go

/*==============================================================*/
/* Table: DICHVU                                                */
/*==============================================================*/
create table DICHVU (
   MADV                 varchar(10)          not null,
   TENDV                nvarchar(50)          null,
   GIADV                money                null,
   constraint PK_DICHVU primary key (MADV)
)
go

/*==============================================================*/
/* Table: HOADON                                                */
/*==============================================================*/
create table HOADON (
   MAHD                 varchar(10)          not null,
   MAKH                 varchar(10)          null,
   MAPT                 varchar(10)          null,
   MANV                 varchar(10)          null,
   MAKS                 varchar(10)          null,
   NGAYDAT              datetime             null,
   NGAYTHANHTOAN        datetime             null,
   TONGTIEN             money                null,
   TINHTRANG            nvarchar(50)          null,
   GHICHU               nvarchar(255)         null,
   DATRA                money                null,
   constraint PK_HOADON primary key (MAHD)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_7_FK                                     */
/*==============================================================*/




create nonclustered index RELATIONSHIP_7_FK on HOADON (MAKH ASC)
go

/*==============================================================*/
/* Index: RELATIONSHIP_9_FK                                     */
/*==============================================================*/




create nonclustered index RELATIONSHIP_9_FK on HOADON (MAPT ASC)
go

/*==============================================================*/
/* Index: RELATIONSHIP_10_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_10_FK on HOADON (MANV ASC)
go

/*==============================================================*/
/* Index: RELATIONSHIP_11_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_11_FK on HOADON (MAKS ASC)
go

/*==============================================================*/
/* Table: KHACHHANG                                             */
/*==============================================================*/
create table KHACHHANG (
   MAKH                 varchar(10)          not null,
   TENKH                nvarchar(50)          null,
   NGSINH               datetime             null,
   GTINH                nvarchar(10)          null,
   QUOCTICH             nvarchar(50)          null,
   SOCCCD               varchar(12)          null,
   SLKHACH              int                  null,
   SDT                  char(10)             null,
   EMAIL                varchar(50)          null,
   constraint PK_KHACHHANG primary key (MAKH)
)
go

/*==============================================================*/
/* Table: KHACHSAN                                              */
/*==============================================================*/
create table KHACHSAN (
   MAKS                 varchar(10)          not null,
   TENKS                nvarchar(50)          null,
   DIACHI               nvarchar(255)         null,
   SDT                  char(10)             null,
   EMAIL                varchar(50)          null,
   TANG                 int                  null,
   constraint PK_KHACHSAN primary key (MAKS)
)
go

/*==============================================================*/
/* Table: LOAIPHONG                                             */
/*==============================================================*/
create table LOAIPHONG (
   MALOAI               varchar(10)          not null,
   TENLOAI              nvarchar(50)          null,
   MOTA                 nvarchar(255)         null,
   constraint PK_LOAIPHONG primary key (MALOAI)
)
go

/*==============================================================*/
/* Table: NHANVIEN                                              */
/*==============================================================*/
create table NHANVIEN (
   MANV                 varchar(10)          not null,
   MABP                 varchar(10)          null,
   TENNV                nvarchar(30)          null,
   SODT                 varchar(10)          null,
   CMND                 char(12)             null,
   constraint PK_NHANVIEN primary key (MANV)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_5_FK                                     */
/*==============================================================*/




create nonclustered index RELATIONSHIP_5_FK on NHANVIEN (MABP ASC)
go

/*==============================================================*/
/* Table: PHONG                                                 */
/*==============================================================*/
create table PHONG (
   MAPH                 varchar(10)          not null,
   MALOAI               varchar(10)          null,
   TENPH                nvarchar(50)          null,
   TANG                 int                  null,
   TINHTRANG            nvarchar(50)          null,
   SLCHUA               int                  null,
   SOGIUONG             int                  null,
   GIAPHONG             money                null,
   constraint PK_PHONG primary key (MAPH)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_8_FK                                     */
/*==============================================================*/




create nonclustered index RELATIONSHIP_8_FK on PHONG (MALOAI ASC)
go

/*==============================================================*/
/* Table: PHUONGTHUCTHANHTOAN                                   */
/*==============================================================*/
create table PHUONGTHUCTHANHTOAN (
   MAPT                 varchar(10)          not null,
   TENPT                nvarchar(50)          null,
   constraint PK_PHUONGTHUCTHANHTOAN primary key (MAPT)
)
go


/*==============================================================*/
/* Table: TAIKHOAN                                              */
/*==============================================================*/
create table TAIKHOAN (
   TENDN                varchar(30)          not null,
   MANV                 varchar(10)          null,
   MK                   varchar(30)          null,
   constraint PK_TAIKHOAN primary key (TENDN)
)
go

alter table TAIKHOAN
   add constraint FK_TAIKHOAN_REFERENCE_NHANVIEN foreign key (MANV)
      references NHANVIEN (MANV)
go

alter table CHITIETKH
   add constraint FK_CHITIETK_RELATIONS_HOADON foreign key (MAHD)
      references HOADON (MAHD)
go

alter table CTDV
   add constraint FK_CTDV_CTDV_DICHVU foreign key (MADV)
      references DICHVU (MADV)
go

alter table CTDV
   add constraint FK_CTDV_CTDV2_HOADON foreign key (MAHD)
      references HOADON (MAHD)
go

alter table CTHD
   add constraint FK_CTHD_CHTD3_HOADON foreign key (MAHD)
      references HOADON (MAHD)
go

alter table CTHD
   add constraint FK_CTHD_CHTD4_PHONG foreign key (MAPH)
      references PHONG (MAPH)
go

alter table HOADON
   add constraint FK_HOADON_RELATIONS_NHANVIEN foreign key (MANV)
      references NHANVIEN (MANV)
go

alter table HOADON
   add constraint FK_HOADON_RELATIONS_KHACHSAN foreign key (MAKS)
      references KHACHSAN (MAKS)
go

alter table HOADON
   add constraint FK_HOADON_RELATIONS_KHACHHAN foreign key (MAKH)
      references KHACHHANG (MAKH)
go

alter table HOADON
   add constraint FK_HOADON_RELATIONS_PHUONGTH foreign key (MAPT)
      references PHUONGTHUCTHANHTOAN (MAPT)
go

alter table NHANVIEN
   add constraint FK_NHANVIEN_RELATIONS_BOPHAN foreign key (MABP)
      references BOPHAN (MABP)
go

alter table PHONG
   add constraint FK_PHONG_RELATIONS_LOAIPHON foreign key (MALOAI)
      references LOAIPHONG (MALOAI)
go

ALTER TABLE CHITIETKH
ALTER COLUMN SOCCCD NVARCHAR(50) NOT NULL;
go

ALTER TABLE CHITIETKH
ADD CONSTRAINT PK_SOCCCD PRIMARY KEY (SOCCCD);
go