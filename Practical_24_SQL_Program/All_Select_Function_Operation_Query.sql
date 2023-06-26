SELECT Id AS 'Id',FirstName AS 'Employee Name and Hobby Name' FROM Employee
UNION ALL
SELECT Id AS 'Id',Name  FROM Hobby;

SELECT e.FirstName AS 'Employee Name', es.Salary AS 'Employee Salary'
FROM Employee e
JOIN EmployeeSalary es ON e.Id = es.Employee_Id;

SELECT
  e.FirstName AS 'Employee Name',
  SUM(es.Salary) AS 'Total Salary',
  (
    SELECT STUFF((
      SELECT ', ' + h.Name
      FROM EmployeeHobby eh
      JOIN Hobby h ON eh.Id = h.Id
      WHERE eh.Emp_Id = e.Id
      FOR XML PATH('')
    ), 1, 2, '')
  ) AS 'Hobby Names'
FROM
  Employee e
JOIN
  EmployeeSalary es ON e.Id = es.Employee_Id
GROUP BY
  e.FirstName, e.Id;