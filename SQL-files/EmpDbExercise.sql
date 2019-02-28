CREATE DATABASE ex1;
CREATE TABLE Department
(
Id INT PRIMARY KEY IDENTITY,
Name NVARCHAR(100) NOT NULL,
Location NVARCHAR(100) NOT NULL
);
CREATE TABLE Employee
(
Id INT PRIMARY KEY IDENTITY,
FirstName NVARCHAR(100) NOT NULL,
LastName NVARCHAR(100) NOT NULL,
SSN INT NOT NULL,
DeptId INT
);
CREATE TABLE EmpDetails
(
Id INT PRIMARY KEY,
EmployeeId INT NOT NULL FOREIGN KEY REFERENCES Employee (Id),
Salary INT,
Address1 NVARCHAR(100),
Address2 NVARCHAR(100),
City NVARCHAR(50),
State NVARCHAR(2),
Country NVARCHAR(50)
)

ALTER TABLE Employee ADD
CONSTRAINT EmpToDepFK FOREIGN KEY (DeptId) REFERENCES Department (Id);

INSERT INTO Department (Name, Location) VALUES
('Kitchen', 'HQ'),
('Restaurant', 'Branch 2'),
('School', 'Branch 3')

INSERT INTO Employee (FirstName, LastName, SSN, DeptId) VALUES
('Locke', 'Lannis', 3848194, 1),
('Sel', 'Sal', 4829104, 3),
('Lurking', 'Bear', 1934772, 2)

INSERT INTO EmpDetails (Id,EmployeeId, Salary, Address1, Address2,
City, State, Country) VALUES
(1,1, 1000000, '123 Money Way', null, 'Bank', 'GA', 'USA'),
(2,2, 193920, '345 Not Much Money Way', 'Apt 3', 'Bank', 'WA', 'USA'),
(3,3, 447262783, '1 All The Money Way', null, 'Vault', 'TX', 'USA')

INSERT INTO Employee (FirstName, LastName, SSN, DeptId) VALUES
('Tina', 'Smith', 483472, 2)

INSERT INTO EmpDetails (Id, EmployeeId, Salary, Address1,
Address2, City, State, Country) VALUES
(4, (SELECT Id FROM Employee WHERE FirstName = 'Tina'),
18392, '1234 Suck Way', null, 'Suckville', 'Ga', 'USA')

INSERT INTO Department (Name, Location) VALUES
('Marketing', 'HQ')

SELECT *
FROM Department AS d
	JOIN Employee AS e ON d.Id = e.DeptId
WHERE d.Name = 'Marketing'


