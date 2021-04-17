CREATE TABLE authors (
	authorID INT NOT NULL AUTO_INCREMENT,
	firstName VARCHAR(255) NOT NULL,
	lastName VARCHAR(255) NOT NULL,
	PRIMARY KEY (authorID)
);

CREATE TABLE publishers (
	publisherID INT NOT NULL AUTO_INCREMENT,
	publisherName VARCHAR(255) NOT NULL,
	PRIMARY KEY (publisherID)
);

CREATE TABLE titles (
	isbn VARCHAR(255) NOT NULL,
	title VARCHAR(255) NOT NULL,
	editionNumber INT NOT NULL,
	copyright INT NOT NULL,
	publisherID INT NOT NULL,
	imageFile LONGBLOB,
	price DECIMAL(19,9) NOT NULL,
	PRIMARY KEY (isbn),
	FOREIGN KEY (publisherID) REFERENCES publishers(publisherID)
);

CREATE TABLE authorISBN (
	authorID INT NOT NULL,
	isbn VARCHAR(255) NOT NULL,
	PRIMARY KEY (isbn),
	FOREIGN KEY (authorID) REFERENCES authors(authorID),
	FOREIGN KEY (isbn) REFERENCES titles(isbn)
);

INSERT INTO authors (firstName, lastName) VALUES
	("Harvey", "Deitel"),
	("Paul", "Deitel"),
	("Tem", "Nieto"),
	("Kate", "Steibuhler"),
	("Sean", "Santry"),
	("Ted", "Lin"),
	("Praveen", "Sadhu"),
	("David", "McPhie"),
	("Cheryl", "Yaeger"),
	("Marina", "Wiedermann"),
	("Jonathan", "Liperi"),
	("Jeffrey", "Listfield");
	
INSERT INTO publishers (publisherName) VALUES
	("Prentice Hall"),
	("Prentice Hall PTG");

INSERT INTO titles (isbn, title, editionNumber, publisherID, copyright, price) VALUE
	("0130622214", "C# How to Program", 1, 1, 2002, 69.95);
	
INSERT INTO authorISBN (authorID, isbn) VALUE (1, "0130622214");