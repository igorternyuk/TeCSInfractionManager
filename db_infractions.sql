CREATE DATABASE bd_infractions;
GO
USE bd_infractions;
GO

CREATE TABLE brand(
	id INT IDENTITY(1,1),
	name VARCHAR(100) NOT NULL,
	PRIMARY KEY(id)
);

CREATE TABLE model(
	id INT IDENTITY(1,1),
	name VARCHAR(50) NOT NULL,
	id_brand INT NOT NULL,
	PRIMARY KEY(id),
	CONSTRAINT constraint1 FOREIGN KEY (id_brand) REFERENCES brand(id)	
);

CREATE TABLE infraction(
	id INT IDENTITY(1,1),
	patent VARCHAR(10) NOT NULL,
	id_model INT NOT NULL,
	details VARCHAR(300),
	fecha DATE NOT NULL,
	fine INT NOT NULL,
	PRIMARY KEY(id),
	CONSTRAINT constraint2 FOREIGN KEY (id_model) REFERENCES model(id)
);

INSERT INTO brand VALUES('VAZ');
INSERT INTO brand VALUES('Moskvich');
INSERT INTO brand VALUES('Volga');

INSERT INTO model VALUES('Kopeyka-2101', 1);
INSERT INTO model VALUES('2103', 1);
INSERT INTO model VALUES('2105', 1);
INSERT INTO model VALUES('2107', 1);
INSERT INTO model VALUES('2108', 1);
INSERT INTO model VALUES('2109', 1);

INSERT INTO model VALUES('408', 2);
INSERT INTO model VALUES('412', 2);

INSERT INTO model VALUES('GAZ-21', 3);
INSERT INTO model VALUES('GAZ-24', 3);

INSERT INTO infraction VALUES('44-aa-2b', 1, 'Details', '2017-05-04', 1400);
INSERT INTO infraction VALUES('7k-cc-2b', 2, 'Details', '2017-07-14', 517);
INSERT INTO infraction VALUES('99-ca-37', 4, 'Details', '2017-10-13', 800);

SELECT patent, model.name, brand.name, details, fecha, fine FROM
infraction, model, brand WHERE infraction.id_model =  model.id
AND model.id_brand = brand.id;

SELECT i.patent, m.name, b.name, i.details, i.fecha, i.fine
FROM infraction i
INNER JOIN model m ON i.id_model =  m.id
INNER JOIN brand b ON m.id_brand = b.id;
    
SELECT * FROM model;