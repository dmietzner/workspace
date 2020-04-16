-- ********* INNER JOIN ***********

-- Let's find out who made payment 16666:
select * from payment where payment_id = 16666
-- Ok, that gives us a customer_id, but not the name. We can use the customer_id to get the name FROM the customer table
select * from payment join customer on payment.customer_id = customer.customer_id where payment_id = 16666
-- We can see that the * pulls back everything from both tables. We just want everything from payment and then the first and last name of the customer:
select payment.*,first_name,last_name from payment join customer on payment.customer_id = customer.customer_id where payment_id = 16666
-- But when did they return the rental? Where would that data come from? From the rental table, so let’s join that.
select payment.*,first_name,last_name,return_date from payment 
	join customer on payment.customer_id = customer.customer_id 
	join rental on rental.rental_id = payment.rental_id
	 where payment_id = 16666
-- What did they rent? Film id can be gotten through inventory.
select payment.*,first_name,last_name,return_date,title from payment 
	join customer on payment.customer_id = customer.customer_id 
	join rental on rental.rental_id = payment.rental_id
	join inventory on rental.inventory_id = inventory.inventory_id
	join film on film.film_id = inventory.film_id
	 where payment_id = 16666
-- What if we wanted to know who acted in that film?
select payment.*,C.first_name,C.last_name,A.first_name,A.last_name,title from payment 
	join customer as C on payment.customer_id = C.customer_id 
	join rental on rental.rental_id = payment.rental_id
	join inventory on rental.inventory_id = inventory.inventory_id
	join film on film.film_id = inventory.film_id
	join film_actor on film.film_id = film_actor.film_id
	join actor as A on A.actor_id = film_actor.actor_id
	 where payment_id = 16666

-- What if we wanted a list of all the films and their categories ordered by film title
select film.title,category.name from film join film_category on film.film_id = film_category.film_id
	join category on category.category_id = film_category.category_id
	order by film.title
-- Show all the 'Comedy' films ordered by film title
select * from film
	join film_category on film.film_id = film_category.film_id
	join category on film_category.category_id = category.category_id
	where category.name = 'Comedy'
	order by title
-- Finally, let's count the number of films under each category
select count(*),category.name from film
	join film_category on film.film_id = film_category.film_id
	join category on category.category_id = film_category.category_id
	group by category.name
	order by category.name
-- ********* LEFT JOIN ***********

-- (There aren't any great examples of left joins in the "dvdstore" database, so the following queries are for the "world" database)
Use World
-- A Left join, selects all records from the "left" table and matches them with records from the "right" table if a matching record exists.

-- Let's display a list of all countries and their capitals, if they have some.
select * from country join city on capital = city.id
-- Only 232 rows
-- But we’re missing entries:

-- There are 239 countries. So how do we show them all even if they don’t have a capital?
-- That’s because if the rows don’t exist in both tables, we won’t show any information for it. If we want to show data FROM the left side table everytime, we can use a different join:
select * from country left join city on capital = city.id

-- *********** UNION *************

-- Back to the "dvdstore" database...

-- Gathers a list of all first names used by actors and customers
select first_name,last_name from customer
union
select first_name,last_name from actor
-- By default removes duplicates

-- Gather the list, but this time note the source table with 'A' for actor and 'C' for customer
select first_name,last_name,'C' as source from customer
union
select first_name,last_name,'A' from actor
order by source
