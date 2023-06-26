/* Query Of Create Table Function Of EmployeHobby Table */
CREATE TABLE EmployeeHobby (
Id INT PRIMARY KEY,
Emp_Id INT,
Hobby_Id INT,
FOREIGN KEY (Emp_Id) REFERENCES Employee(Id),
FOREIGN KEY (Hobby_Id) REFERENCES Hobby(Id)
);

/* Query Of Insert Function Of EmployeeHobby Table */
insert into dbo.EmployeeHobby(id,Emp_Id,Hobby_Id)
values
	(1,1,1);

insert into dbo.EmployeeHobby(id,Emp_Id,Hobby_Id)
values
	(2,2,2);
insert into dbo.EmployeeHobby(id,Emp_Id,Hobby_Id)
values
	(3,3,3);
insert into dbo.EmployeeHobby(id,Emp_Id,Hobby_Id)
values
	(4,4,4);
insert into dbo.EmployeeHobby(id,Emp_Id,Hobby_Id)
values
	(5,5,5);


/* Query Of Select Function Of EmployeeHobby Table */
Select * From EmployeeHobby;

/* Query Of Update Function Of EmployeeHobby Table */
UPDATE EmployeeHobby
SET Hobby_Id = 6, Emp_Id = 6
WHERE Id = 5;

/* Query Of Delete Function Of EmployeeHobby Table */ 
DELETE FROM EmployeeHobby WHERE Id=5;
DELETE FROM EmployeeHobby WHERE Id=4;

/* Query Of Truncate Function Of EmployeeHobby Table */ 
TRUNCATE TABLE EmployeeHobby