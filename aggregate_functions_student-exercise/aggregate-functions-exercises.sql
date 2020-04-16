-- The following queries utilize the "world" database.
-- Write queries for the following problems. 
-- Notes:
--   GNP is expressed in units of one million US Dollars
--   The value immediately after the problem statement is the expected number 
--   of rows that should be returned by the query.

-- 1. The name and state plus population of all cities in states that border Ohio 
-- (i.e. cities located in Pennsylvania, West Virginia, Kentucky, Indiana, and 
-- Michigan).  
-- The name and state should be returned as a single column called 
-- name_and_state and should contain values such as ‘Detroit, Michigan’.  
-- The results should be ordered alphabetically by state name and then by city 
-- name. 
-- (19 rows)
SELECT name + ' , ' + district as 'name_and_state', sum(population) as 'population'
FROM World.dbo.city 
WHERE district in ('Pennsylvania','West Virginia', 'Kentucky', 'Indiana', 'Michigan') group by name, district 
order by name, district DESC 

-- 2. The name, country code, and region of all countries in Africa.  The name and
-- country code should be returned as a single column named country_and_code 
-- and should contain values such as ‘Angola (AGO)’ 
-- (58 rows)
SELECT name + ' (' + code + ')' as 'country_and_code' , region 
FROM World.dbo.country
WHERE region like ('% Africa')

-- 3. The per capita GNP (i.e. GNP multipled by 1000000 then divided by population) of all countries in the 
-- world sorted from highest to lowest. Recall: GNP is express in units of one million US Dollars 
-- (highest per capita GNP in world: 37459.26)
SELECT gnp, (gnp * 1000000 / population) as 'per_capita_gnp'
FROM World.dbo.country
WHERE population != 0
ORDER BY per_capita_gnp desc

-- 4. The average life expectancy of countries in South America.
-- (average life expectancy in South America: 70.9461)
select avg(lifeexpectancy) as 'avg_le_sa'
FROM World.dbo.country
WHERE region in ('South America')

-- 5. The sum of the population of all cities in California.
-- (total population of all cities in California: 16716706)
SELECT sum(population) as 'cali_pop'
FROM World.dbo.city
WHERE district in ('California')

-- 6. The sum of the population of all cities in China.
-- (total population of all cities in China: 175953614)
SELECT sum(population)
FROM World.dbo.city
WHERE countrycode in ('CHN')

-- 7. The maximum population of all countries in the world.
-- (largest country population in world: 1277558000)
SELECT max(population) as 'largest_world_pop'
FROM World.dbo.country

-- 8. The maximum population of all cities in the world.
-- (largest city population in world: 10500000)
SELECT max(population) as 'max_pop_of_cities_of_world'
FROM World.dbo.city

-- 9. The maximum population of all cities in Australia.
-- (largest city population in Australia: 3276207)
SELECT max(population) as 'max_pop_Australia'
FROM World.dbo.city
WHERE countrycode in ('AUS')

-- 10. The minimum population of all countries in the world.
-- (smallest_country_population in world: 50)
SELECT min(population) as 'smallest_country_population'
FROM World.dbo.country
WHERE population != 0

-- 11. The average population of cities in the United States.
-- (avgerage city population in USA: 286955.3795)
SELECT avg(population) as 'avg_pop_usa'
FROM World.dbo.city
WHERE countrycode in ('USA')

-- 12. The average population of cities in China.
-- (average city population in China: 484720.6997 approx.)
SELECT avg(population) as 'avg_pop_chn'
FROM World.dbo.city
WHERE countrycode in ('CHN')

-- 13. The surface area of each continent ordered from highest to lowest.
-- (largest continental surface area: 31881000, "Asia")
SELECT continent, sum(surfacearea) as 'continental_sa'
FROM World.dbo.country
GROUP BY continent
ORDER BY 'continental_sa' DESC

-- 14. The highest population density (population divided by surface area) of all 
-- countries in the world. 
-- (highest population density in world: 26277.7777)
SELECT max(population / surfacearea) as 'highest_pop_density'
FROM World.dbo.country

-- 15. The population density and life expectancy of the top ten countries with the 
-- highest life expectancies in descending order. 
-- (highest life expectancies in world: 83.5, 166.6666, "Andorra")
SELECT TOP 10 lifeexpectancy, (population / surfacearea) as 'pop_density'
FROM World.dbo.country
GROUP BY name
ORDER By lifeexpectancy DESC

-- 16. The difference between the previous and current GNP of all the countries in 
-- the world ordered by the absolute value of the difference. Display both 
-- difference and absolute difference.
-- (smallest difference: 1.00, 1.00, "Ecuador")
Select abs(min(gnp - gnpold)) as 'gnp_dif_abs', min(gnp - gnpold) as 'gnp_dif', name
FROM country
WHERE 'gnp_dif_abs' is not null and 'gnp_dif' is not null
GROUP BY name
ORDER BY gnp_dif_abs desc




-- 17. The average population of cities in each country (hint: use city.countrycode)
-- ordered from highest to lowest.
-- (highest avg population: 4017733.0000, "SGP")
	SELECT avg(population) as 'avg_pop', countrycode 
	from city
	group by countrycode
	order by avg_pop desc
	


-- 18. The count of cities in each state in the USA, ordered by state name.
-- (45 rows)
SELECT count(*) as 'count', district
FROM world.dbo.city
WHERE countrycode in ('USA')
GROUP BY district
ORDER BY 'count' DESC
	
-- 19. The count of countries on each continent, ordered from highest to lowest.
-- (highest count: 58, "Africa")
SELECT count(*) as 'count', continent
FROM world.dbo.country
GROUP BY continent
ORDER BY 'count' DESC

-- 20. The count of cities in each country ordered from highest to lowest.
-- (largest number of  cities ib a country: 363, "CHN")
SELECT count(*) as 'count', countrycode
FROM world.dbo.city
GROUP BY countrycode
ORDER BY 'count' DESC

-- 21. The population of the largest city in each country ordered from highest to 
-- lowest.
-- (largest city population in world: 10500000, "IND")
SELECT max(population) as 'max_pop', countrycode
FROM World.dbo.city
Group BY countrycode
Order By 'max_pop' DESC

-- 22. The average, minimum, and maximum non-null life expectancy of each continent 
-- ordered from lowest to highest average life expectancy. 
-- (lowest average life expectancy: 52.5719, 37.2, 76.8, "Africa")

SELECT avg(lifeexpectancy) as 'avg_le', min(lifeexpectancy) as 'min_le', max (lifeexpectancy) as 'max_le', continent
FROM World.dbo.country
WHERE lifeexpectancy is not null
Group by continent
Order by avg_le


