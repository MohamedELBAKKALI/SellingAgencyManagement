Create database SellingAgencyManagement;
use SellingAgencyManagement;

Create Table OfficesSales(Idoffice int primary key,NameOffice varchar(100));

create table Customers(Id int primary key ,FirstName varchar(55),LastName varchar(55),
Age int,phone varchar(55),Occupation varchar(55),IdOffice int foreign key references OfficesSales(Idoffice) );

Create table Contracts(Id int primary Key , IdCustomer int foreign key references Customers(Id),
CntType varchar(55),FirstBatch float,Installement float);

Create table Apartements(Id int primary key,Price float,AparAdress varchar(100),AparFloor int ,NbrRooms int)

Create table Contract_Apartement (IdContract int foreign key references Contracts(Id),
IdApartement int foreign key references Apartements(Id));

select * from Customers
select * from OfficesSales
select * from Contracts
select * from Apartements
select * from Contract_Apartement;
--Update Customers set FirstName='',LastName='',Age=1,phone='',Occupation='' where IdOffice=1 
Insert into OfficesSales values(1,'Office1');
Insert into OfficesSales values(2,'Office2');
insert into Customers values(1,'firsName','lastname',25,'0652411500','Emploiye',1);
insert into Customers values(2,'Mohamed','Elbakkai',21,'0652411500','Programmer',1);
insert into Customers values(3,'firsName2','LastName2',25,'0621411555','Doctor',2);
insert into Customers values(4,'testfor delete','delet',25,'0621411555','Doctor',2);

--delete from Customers where Id=3
--insert into Contracts values (1,1,'',1,1,'');

--insert into Apartements values(1,1,'',1,1);

--insert into Contract_Apartement values(1,1);

Select Idoffice from OfficesSales;