USE master;
GO

-- Only use in class, better to have an error that db already exists than to drop a db you didn't know was there
DROP DATABASE IF EXISTS ArtGallery;

Create Database ArtGallery;
GO

USE ArtGallery;
GO

Begin Transaction
CREATE TABLE Customers
(
	customerID	int	identity(1,1),
	FirstName	nvarchar(100) not null,
	LastName	nvarchar(100) null,
	UserName	nvarchar(25) not null,
	Phone	nvarchar(15)	null,

	constraint pk_customers primary key (customerID)

);

CREATE TABLE Artists
(
	ArtistID	int		identity(1,1),
	FirstName	nvarchar(100) not null,
	-- This sets the default value to Celebrity if no value is provided
	LastName	nvarchar(100)	null DEFAULT 'Celebrity',

	constraint pk_artists primary key (ArtistID)
);

CREATE TABLE ArtXArtist
(
	ArtID	int not null,
	ArtistID int not null,

	constraint pk_art_artist primary key (ArtID,ArtistID)
);

CREATE TABLE Art
(
	ArtID	int	identity(1,1),
	Title	nvarchar(100)	not null,
	ArtistID	int	not null,
	
	constraint pk_art primary key (ArtID),
	constraint fk_art_artists foreign key (ArtistID) references Artists(ArtistID)
);


CREATE Table Customer_Purchases
(
	CustomerID	int	not null,
	ArtID	int	not null,
	PurchaseDate datetime	not null,
	Price	money	not null,

	constraint pk_customer_purchase primary key (CustomerID,ArtID)
);

-- Add foreing keys after all the tables are built to make sure the referenced table exists
ALTER TABLE ArtXArtist
ADD CONSTRAINT fk_artxartist_art foreign key (ArtID) references Art(ArtID);

ALTER TABLE ArtXArtist
ADD CONSTRAINT fk_artxartist_artist foreign key (ArtistID) references Artists(ArtistID);

ALTER TABLE Customer_Purchases
ADD CONSTRAINT fk_purchases_customer foreign key (CustomerID) references Customers(CustomerID),
 CONSTRAINT fk_purchases_art foreign key (ArtID) references Art(ArtID);

 -- Just another way to add a default value
 ALTER TABLE Art ADD CONSTRAINT default_title DEFAULT 'Untitled' FOR Title;

Commit Transaction

