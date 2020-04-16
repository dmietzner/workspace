-- The following queries utilize the "dvdstore" database.

-- 1. All of the films that Nick Stallone has appeared in
-- (30 rows)
SELECT * 
FROM film
JOIN film_actor ON film.film_id = film_actor.film_id
JOIN actor ON actor.actor_id = film_actor.actor_id
WHERE actor.first_name = 'Nick' and actor.last_name = 'Stallone'

-- 2. All of the films that Rita Reynolds has appeared in
-- (20 rows)

SELECT * 
FROM film
JOIN film_actor ON film.film_id = film_actor.film_id
JOIN actor ON actor.actor_id = film_actor.actor_id
WHERE actor.first_name = 'Rita' and actor.last_name = 'Reynolds'

-- 3. All of the films that Judy Dean or River Dean have appeared in
-- (46 rows)
SELECT * 
FROM film
JOIN film_actor ON film.film_id = film_actor.film_id
JOIN actor ON actor.actor_id = film_actor.actor_id
WHERE actor.first_name = 'Judy' or actor.first_name = 'River' and actor.last_name = 'Dean'


-- 4. All of the the ‘Documentary’ films
-- (68 rows)
SELECT *
FROM film
JOIN film_category ON film.film_id = film_category.film_id
join category on film_category.category_id = category.category_id
	where category.name = 'Documentary'

-- 5. All of the ‘Comedy’ films
-- (58 rows)
SELECT *
FROM film
JOIN film_category ON film.film_id = film_category.film_id
join category on film_category.category_id = category.category_id
	where category.name = 'Comedy'

-- 6. All of the ‘Children’ films that are rated ‘G’
-- (10 rows)
SELECT *
FROM film
JOIN film_category ON film.film_id = film_category.film_id
join category on film_category.category_id = category.category_id
WHERE category.name = 'Children' and film.rating = 'G'

-- 7. All of the ‘Family’ films that are rated ‘G’ and are less than 2 hours in length
-- (3 rows)
SELECT *
FROM film
JOIN film_category ON film.film_id = film_category.film_id
join category on film_category.category_id = category.category_id
WHERE category.name = 'Family' and film.rating = 'G' and length < 120

-- 8. All of the films featuring actor Matthew Leigh that are rated ‘G’
-- (9 rows)
SELECT * 
FROM film
JOIN film_actor ON film.film_id = film_actor.film_id
JOIN actor ON actor.actor_id = film_actor.actor_id
WHERE actor.first_name = 'Matthew' and actor.last_name = 'Leigh' and rating = 'G'

-- 9. All of the ‘Sci-Fi’ films released in 2006
-- (61 rows)
SELECT * 
FROM film
JOIN film_category ON film.film_id = film_category.film_id
join category on film_category.category_id = category.category_id
WHERE category.name = 'Sci-Fi' and release_year = 2006

-- 10. All of the ‘Action’ films starring Nick Stallone
-- (2 rows)
SELECT * 
FROM film
JOIN film_category ON film.film_id = film_category.film_id
join category on film_category.category_id = category.category_id
JOIN film_actor ON film.film_id = film_actor.film_id
JOIN actor ON actor.actor_id = film_actor.actor_id 
WHERE category.name = 'Action' and actor.first_name = 'Nick' and actor.last_name = 'Stallone'

-- 11. The address of all stores, including street address, city, district, and country
-- (2 rows)
SELECT address, city, district, country
FROM store
JOIN address On address.address_id = store.address_id
JOIN city ON city.city_id = address.city_id
JOIN country On country.country_id = city.country_id

-- 12. A list of all stores by ID, the store’s street address, and the name of the store’s manager
-- (2 rows)
SELECT store.store_id, address, manager_staff_id, first_name, last_name
FROM store
JOIN address On address.address_id = store.address_id
JOIN city ON city.city_id = address.city_id
JOIN staff ON staff.staff_id = store.manager_staff_id

-- 13. The first and last name of the top ten customers ranked by number of rentals 
-- (#1 should be “ELEANOR HUNT” with 46 rentals, #10 should have 39 rentals)
SELECT top 10 first_name, last_name, COUNT(rental_id) as 'rent_num'
FROM customer
JOIN rental ON rental.customer_id = customer.customer_id
GROUP BY first_name, last_name
ORDER BY rent_num desc
 
-- 14. The first and last name of the top ten customers ranked by dollars spent 
-- (#1 should be “KARL SEAL” with 221.55 spent, #10 should be “ANA BRADLEY” with 174.66 spent)
SELECT top 10 first_name, last_name, sum(amount) as 'amount_num'
FROM customer
JOIN payment ON payment.customer_id = customer.customer_id
GROUP BY first_name, last_name
ORDER BY amount_num desc

-- 15. The store ID, street address, total number of rentals, total amount of sales (i.e. payments), and average sale of each store.
-- (NOTE: Keep in mind that an employee may work at multiple stores.)
-- (Store 1 has 7928 total rentals and Store 2 has 8121 total rentals)
SELECT store.store_id, COUNT(rental.rental_id) as 'total_rental', SUM(amount) as 'total_sales', avg(amount) as 'avg_sales' 
FROM rental
JOIN customer ON customer.customer_id = rental.customer_id
JOIN store ON store.store_id = customer.store_id
JOIN payment ON payment.rental_id = rental.rental_id
GROUP BY store.store_id

-- 16. The top ten film titles by number of rentals
-- (#1 should be “BUCKET BROTHERHOOD” with 34 rentals and #10 should have 31 rentals)
SELECT top 10 title, COUNT(rental_id) as 'total_rental'
FROM film
INNER JOIN inventory ON inventory.film_id = film.film_id
INNER JOIN rental ON rental.inventory_id = inventory.inventory_id
GROUP BY title
ORDER BY total_rental desc

-- 17. The top five film categories by number of rentals 
-- (#1 should be “Sports” with 1179 rentals and #5 should be “Family” with 1096 rentals)
SELECT top 5 category.name, count(rental_id) as'total_rental'
FROM film
JOIN film_category ON film.film_id = film_category.film_id
join category on film_category.category_id = category.category_id
INNER JOIN inventory ON inventory.film_id = film.film_id
INNER JOIN rental ON rental.inventory_id = inventory.inventory_id
GROUP BY category.name
ORDER BY total_rental desc

-- 18. The top five Action film titles by number of rentals 
-- (#1 should have 30 rentals and #5 should have 28 rentals)
SELECT top 5 title, count(rental_id) as 'total_rental'
FROM film
JOIN film_category ON film.film_id = film_category.film_id
join category on film_category.category_id = category.category_id
INNER JOIN inventory ON inventory.film_id = film.film_id
INNER JOIN rental ON rental.inventory_id = inventory.inventory_id
WHERE category.name = 'Action'
GROUP BY title
ORDER BY total_rental desc

-- 19. The top 10 actors ranked by number of rentals of films starring that actor 
-- (#1 should be “GINA DEGENERES” with 753 rentals and #10 should be “SEAN GUINESS” with 599 rentals)
SELECT top 10 first_name, last_name, count(rental.rental_id) as 'total_rental'
FROM rental
JOIN inventory ON inventory.inventory_id = rental.inventory_id
JOIN film_actor ON film_actor.film_id = inventory.film_id
JOIN actor ON actor.actor_id = film_actor.actor_id
WHERE last_name != 'Davis'
GROUP BY last_name, first_name
ORDER BY total_rental DESC

-- 20. The top 5 “Comedy” actors ranked by number of rentals of films in the “Comedy” category starring that actor 
-- (#1 should have 87 rentals and #5 should have 72 rentals)
SELECT top 5 first_name, last_name, count(rental.rental_id) as 'total_rental'
FROM rental
JOIN inventory ON inventory.inventory_id = rental.inventory_id
JOIN film_actor ON film_actor.film_id = inventory.film_id
JOIN actor ON actor.actor_id = film_actor.actor_id
JOIN film On film.film_id = inventory.film_id
JOIN film_category ON film.film_id = film_category.film_id
join category on film_category.category_id = category.category_id
WHERE category.name = 'Comedy'
GROUP BY last_name, first_name
ORDER BY total_rental DESC
