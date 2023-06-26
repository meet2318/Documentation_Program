/* Query Of Create Table Function Of EmployeSalary Table */
CREATE TABLE Employee
(  
    Id int,
    Salary int NOT NULL,  
    Date date NOT NULL, 
    Age int,
    Employee_Id int,
    FOREIGN KEY (Employee_Id) REFERENCES Employee(Id),
);


/* Query Of Insert Function Of EmployeeSalary Table */
insert into dbo.EmployeeSalary(id,Salary,Date,Employee_Id)
values
	(10,20000,'26-jul-2023',10);

insert into dbo.EmployeeSalary(id,Salary,Date,Employee_Id)
values
	(6,300000,'05-feb-2024',6);
insert into dbo.EmployeeSalary(id,Salary,Date,Employee_Id)
values
	(7,45000,'20-mar-2022',7);

insert into dbo.EmployeeSalary(id,Salary,Date,Employee_Id)
values
	(8,56000,'12-oct-2018',8);

insert into dbo.EmployeeSalary(id,Salary,Date,Employee_Id)
values
	(2,34000,'14-mar-2025',2);

/* Query Of Select Function Of EmployeeSalary Table */
Select * From EmployeeSalary;

/* Query Of Update Function Of EmployeeSalary Table */
UPDATE EmployeeSalary
SET Salary = '20000', Date = '25-jan-2005'
WHERE Id = 5;

/* Query Of Delete Function Of EmployeeSalary Table */ 
DELETE FROM EmployeeSalary WHERE Salary = 20000;
DELETE FROM EmployeeSalary WHERE Salary = 20000;

/* Query Of Truncate Function Of Employee Table */
TRUNCATE TABLE EmployeeSalary
