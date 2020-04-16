USE master;
GO


DROP DATABASE IF EXISTS ProjectOrganizer;
Create Database ProjectOrganizer;
GO

USE ProjectOrganizer;
GO

BEGIN TRANSACTION
CREATE TABLE Department
(
	DepartmentNum	int not null,
	DepartmentName nvarchar(25) not null,
	constraint pk_department primary key (DepartmentNum)
);
	CREATE TABLE Project
(
	ProjectNum	int not null,
	ProjectName	nvarchar (64) not null,
	StartDate	DATE not null,
	constraint pk_project primary key (ProjectNum)
);
CREATE TABLE Employee
(
	EmployeeNumber	int not null,
	JobTitle	nvarchar(64) not null,
	FirstName	nvarchar(64) not null,
	LastName	nvarchar(64)  null,
	Gender		nvarchar(8) not null,
	DateOfBirth	DATE not null,
	HireDate	Date not null,
	DepartmentNum	int not null,
	ProjectNum		int not null,
	constraint pk_employee primary key (EmployeeNumber),
	constraint fk_employee_department foreign key (DepartmentNum) references Department (DepartmentNum),
	constraint fk_employee_project foreign key (ProjectNum) references Project (ProjectNum)
);
COMMIT TRANSACTION;

INSERT INTO Department values (1, 'Consulting')
INSERT INTO Department values (2, 'Business')
INSERT INTO Department values (3, 'Lab')

INSERT INTO Project values (1, 'Business Project', '2018-11-12')
INSERT INTO Project values (2, 'Consulting Project', '2019-04-15')
INSERT INTO Project values (3, 'Lab Project', '2017-08-03')
INSERT INTO Project values (4, 'Equipment Project', '2019-12-02')

INSERT INTO Employee values (1, 'Sales Person', 'Israr', 'Ramsay', 'M', '1993-10-15', '2016-11-17', 2, 1)
INSERT INTO Employee values	(2, 'Lab Assistant', 'Finn', 'Barclay', 'M', '1995-01-03', '2019-06-11', 3, 3)
INSERT INTO Employee values (3, 'Lab Manager', 'Katherine', 'Sheridan', 'F', '1985-02-14', '2016-11-17', 3, 3)
INSERT INTO Employee values (4, 'Lab Consultant', 'Dottie', 'Kane', 'F', '1990-11-16', '2018-12-24', 1, 2)
INSERT INTO Employee values (5, 'Consulting Director', 'Hadiya', 'Pugh', 'F', '1985-03-06', '2016-10-09', 1, 2)
INSERT INTO Employee values (6, 'Sales Director', 'Lucas', 'Mcguire', 'M', '1982-06-30', '2015-06-17', 2, 4)
INSERT INTO Employee values (7, 'Lab Assistant', 'Cameron', 'Bernard', 'M', '1991-12-14', '2018-09-18', 3, 3)
INSERT INTO Employee values	(8, 'Sales Person', 'Ephraim', 'Philip', 'M', '1996-04-01', '2018-05-05', 2, 1)


select * FROM Employee
select * FROM Department
SELECT * FROM Project