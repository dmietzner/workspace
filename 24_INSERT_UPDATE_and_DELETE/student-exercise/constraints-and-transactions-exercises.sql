-- Write queries to return the following:
-- The following changes are applied to the "dvdstore" database.**

-- 1. Add actors, Hampton Avenue, and Lisa Byway to the actor table.
INSERT INTO actor values ('Hampton', 'Avenue')
INSERT INTO actor values ('Lisa', 'Byway')
-- 2. Add "Euclidean PI", "The epic story of Euclid as a pizza delivery boy in
-- ancient Greece", to the film table. The movie was released in 2008 in English.
-- Since its an epic, the run length is 3hrs and 18mins. There are no special
-- features, the film speaks for itself, and doesn't need any gimmicks.
INSERT INTO film values ('Euclidean PI', 'The epic story of Euclid as a pizza delivery boy inancient Greece', 2008, 1, null, 7, 5.99, 198, 10.99, null) 
-- 3. Hampton Avenue plays Euclid, while Lisa Byway plays his slightly
-- overprotective mother, in the film, "Euclidean PI". Add them to the film.
insert into film_actor values (201, 1001)
insert into film_actor values (202, 1001)
-- 4. Add Mathmagical to the category table.
insert into category values ('Mathmagical')
-- 5. Assign the Mathmagical category to the following films, "Euclidean PI",
-- "EGG IGBY", "KARATE MOON", "RANDOM GO", and "YOUNG LANGUAGE"
insert into film_category values (1001, 17)
insert into film_category values (274, 17)
insert into film_category values (494, 17)
insert into film_category values (714, 17)
insert into film_category values (996, 17)
-- 6. Mathmagical films always have a "G" rating, adjust all Mathmagical films
-- accordingly.
-- (5 rows affected)
update film set rating = 'G' where film_id = 1001
update film set rating = 'G' where film_id = 274
update film set rating = 'G' where film_id = 494
update film set rating = 'G' where film_id = 714
update film set rating = 'G' where film_id = 996
-- 7. Add a copy of "Euclidean PI" to all the stores.
insert into inventory values (1001, 1)
insert into inventory values (1001, 2)
-- 8. The Feds have stepped in and have impounded all copies of the pirated film,
-- "Euclidean PI". The film has been seized from all stores, and needs to be
-- deleted from the film table. Delete "Euclidean PI" from the film table.
-- (Did it succeed? Why?)
delete film where title = 'Euclidean PI'
-- <No 'Euclidean PI' is unable to be deleted because of the foreign keys linked to film_actor because I had assigned the actors "Hampton Avenue" and "Lisa Byway" to the film id for Euclidean PI.>

-- 9. Delete Mathmagical from the category table.
-- (Did it succeed? Why?)
delete category where name = 'Mathmagical'
-- <No because the category name is a foreign key of category table and the category_id was generated when I created the mathmagical category>

-- 10. Delete all links to Mathmagical in the film_category tale.
-- (Did it succeed? Why?)
-- <Yes, it succeeded because I deleted the category id which holds the mathmagical category which is the foreign key that connects to the category table.>
delete film_category WHERE category_id = 17
-- 11. Retry deleting Mathmagical from the category table, followed by retrying
-- to delete "Euclidean PI".
-- (Did either deletes succeed? Why?)
delete category WHERE name = 'Mathmagical'
delete film where title = 'Euclidean PI'
-- <Deleting the mathmagical category_id succeeded. Deleting 'Euclidean PI' did not because the film_id number is a primary key of the film table.>

-- 12. Check database metadata to determine all constraints of the film id, and
-- describe any remaining adjustments needed before the film "Euclidean PI" can
-- be removed from the film table.

--