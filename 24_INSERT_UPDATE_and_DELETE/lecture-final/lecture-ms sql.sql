-- INSERT

-- 1. Add Klingon as a spoken language in the USA
insert into countrylanguage (countrycode,language,isofficial,percentage) values ('USA','Klingon',0,5)
insert into countrylanguage (countrycode,language,percentage,isofficial) values ('USA','Elvish',42,0)
-- 2. Add Klingon as a spoken language in Great Britain
insert into countrylanguage values ('GBR','Klingon',1,75)

-- UPDATE

-- 1. Update the capital of the USA to Houston
update country set capital=(select id from city where name='Houston') where code='USA'
-- 2. Update the capital of the USA to Washington DC and the head of state
update country set capital=(select id from city where name='Washington' AND district='District of Columbia'), headofstate='Justin Driscoll' where code='USA'

-- DELETE

-- 1. Delete English as a spoken language in the USA
delete countrylanguage where language='English' and countrycode='USA'
-- 2. Delete all occurrences of the Klingon language 
delete countrylanguage where language='Klingon'

-- REFERENTIAL INTEGRITY

-- 1. Try just adding Elvish to the country language table.
insert into countrylanguage values('XXY','Elvish',1,99)
-- 2. Try inserting English as a spoken language in the country ZZZ. What happens?

-- 3. Try deleting the country USA. What happens?
delete country where code='USA'

-- CONSTRAINTS

-- 1. Try inserting English as a spoken language in the USA
insert into countrylanguage values ('USA','English',1,76)
-- 2. Try again. What happens?
insert into countrylanguage values ('USA','English',1,76)

-- 3. Let's relocate the USA to the continent - 'Outer Space'
update country set continent='Outer Space'

-- How to view all of the constraints

SELECT * FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
SELECT * FROM INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE
SELECT * FROM INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS


-- TRANSACTIONS

-- 1. Try deleting all of the rows from the country language table and roll it back.
begin transaction
delete countrylanguage
rollback transaction
select * from countrylanguage
-- 2. Try updating all of the cities to be in the USA and roll it back
begin transaction
update city set countrycode='USA'
select * from city
rollback transaction
-- 3. Demonstrate two different SQL connections trying to access the same table where one happens to be inside of a transaction but hasn't committed yet.