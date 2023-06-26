/* Query Of Create Table Function Of Employe Table */
CREATE TABLE Employee
(  
    Id int,
    FirstName nvarchar(50) NOT NULL,  
    LastName nvarchar(50) NOT NULL, 
    Age int,
    MobileNumber varchar(10),
    Address varchar(Max),
);
/* Query Of Insert Function Of Employee Table */
insert into dbo.Employee(id,FirstName,LastName,Age,MobileNumber,Address)
values
	(1,'Meet','Pandya',23,9104959836,'Near Animal Hospital');

insert into dbo.Employee(id,FirstName,LastName,Age,MobileNumber,Address)
values
	(2,'Jeet','Pandya',23,9879562894,'near animal hospital');
insert into dbo.Employee(id,FirstName,LastName,Age,MobileNumber,Address)
values
	(3,'Reet','Pandya',23,9104959836,'near animal hospital,Porbandar');

insert into dbo.Employee(id,FirstName,LastName,Age,MobileNumber,Address)
values
	(4,'ram','verma',20,9019562894,'vadi vistar,bhod');

insert into dbo.Employee(id,FirstName,LastName,Age,MobileNumber,Address)
values
	(3,'Jayesh bhai','jordar',29,7567723558,'Ram Nagar,Ranavav');

/* Query Of Select Function Of Employee Table */
Select * From Employee;

/* Query Of Update Function Of Employee Table */
UPDATE Employee
SET MobileNumber = '9104959836', Address = 'Near Animal Hospital,Porbandar'
WHERE Id = 1;

/* Query Of Delete Function Of Employee Table */ 
DELETE FROM Employee WHERE FirstName = 'ram';
DELETE FROM Employee WHERE FirstName = 'Reet';

/* Query Of Truncate Function Of Employee Table */
TRUNCATE TABLE Employee
