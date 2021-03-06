-- SELECT ... FROM
-- Selecting the names for all countries
select name from country;

-- Selecting the name and population of all countries
select name,population from country;

-- Selecting all columns from the city table
select * from city;

-- SELECT ... FROM ... WHERE
-- Selecting the cities in Ohio
select * from city where district='Pennsylvania';

-- Selecting countries that gained independence in the year 1776
select * from country where indepyear = 1776;

-- Selecting countries not in Asia
select name,continent from country where continent != 'Asia'
select name,continent from country where continent <> 'Asia'

-- Selecting countries that do not have an independence year
select name from country where indepyear is NULL;
-- Selecting countries that do have an independence year
select name from country where indepyear is not NULL;


-- Selecting countries that have a population greater than 5 million
select * from country where population > 5000000

-- SELECT ... FROM ... WHERE ... AND/OR
-- Selecting cities in Ohio and Population greater than 400,000
select name,population from city where district='Ohio' and population > 400000
-- Selecting country names on the continent North America or South America
select name,continent from country where continent='North America' or continent='South America';
select name,continent from country where continent in ('North America','South America');
select name,continent,region from country where region like 'South%';


-- SELECTING DATA w/arithmetic
-- Selecting the population, life expectancy, and population per area
--	note the use of the 'as' keyword
select name,population,surfacearea,lifeexpectancy as 'Life Expectancy',(population/surfacearea) as Density
	from country 
	where continent='Asia'


