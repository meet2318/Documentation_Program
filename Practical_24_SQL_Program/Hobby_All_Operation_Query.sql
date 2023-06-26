/* Query Of Create Table Function Of Hobby Table */
CREATE TABLE Hobby (
Id INT PRIMARY KEY,
Name nvarchar(50),
);

/* Query Of Insert Function Of Hobby Table */
insert into dbo.Hobby(id,Name)
values
	(1,'Music,Travelling,Writer');

insert into dbo.Hobby(id,Name)
values
	(2,'Music');
insert into dbo.Hobby(id,Name)
values
	(3,'Travelling');
insert into dbo.Hobby(id,Name)
values
	(4,'Write Qoem');
insert into dbo.Hobby(id,Name)
values
	(5,'Motivational Speaker');


/* Query Of Select Function Of Hobby Table */
select * From Hobby;

/* Query Of Update Function Of Hobby Table */
UPDATE Hobby
SET Name = 'Music,Writing'
WHERE Id = 2;

/* Query Of Delete Function Of Hobby Table */ 
DELETE FROM Hobby WHERE Id=5;
DELETE FROM Hobby WHERE Id=4;

/* Query Of Truncate Function Of Hobby Table */
TRUNCATE TABLE Hobby