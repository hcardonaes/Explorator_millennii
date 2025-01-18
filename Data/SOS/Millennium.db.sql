BEGIN TRANSACTION;
CREATE TABLE IF NOT EXISTS "cargos" (
	"id"	INTEGER,
	"personaje_id"	INTEGER NOT NULL,
	"tipo_cargo_id"	INTEGER NOT NULL,
	"institucion_id"	INTEGER NOT NULL,
	"fecha_inicio"	TEXT,
	"fecha_fin"	TEXT,
	PRIMARY KEY("id"),
	FOREIGN KEY("institucion_id") REFERENCES "instituciones"("id"),
	FOREIGN KEY("personaje_id") REFERENCES "personajes"("id"),
	FOREIGN KEY("tipo_cargo_id") REFERENCES "tipos_de_cargos"("id")
);
CREATE TABLE IF NOT EXISTS "eventos" (
	"id"	INTEGER,
	"nombre"	TEXT NOT NULL,
	"fecha_inicio"	TEXT,
	"fecha_fin"	TEXT,
	"lugar_id"	INTEGER,
	"descripcion"	TEXT,
	PRIMARY KEY("id" AUTOINCREMENT),
	FOREIGN KEY("lugar_id") REFERENCES "lugares"("id")
);
CREATE TABLE IF NOT EXISTS "instituciones" (
	"id"	INTEGER,
	"nombre"	TEXT NOT NULL UNIQUE,
	"descripcion"	TEXT,
	PRIMARY KEY("id" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "lazosFamiliares" (
	"id"	INTEGER,
	"personaje_id1"	INTEGER NOT NULL,
	"tipo_relacion_id"	INTEGER NOT NULL,
	"personaje_id2"	INTEGER NOT NULL,
	"fecha_inicio"	TEXT,
	"fecha_fin"	TEXT,
	PRIMARY KEY("id"),
	FOREIGN KEY("personaje_id1") REFERENCES "personajes"("id"),
	FOREIGN KEY("personaje_id2") REFERENCES "personajes"("id"),
	FOREIGN KEY("tipo_relacion_id") REFERENCES "tipoParentesco"("id")
);
CREATE TABLE IF NOT EXISTS "lugares" (
	"id"	INTEGER,
	"nombre"	TEXT NOT NULL UNIQUE,
	"latitud"	REAL,
	"longitud"	REAL,
	"descripcion"	TEXT,
	PRIMARY KEY("id" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "personajes" (
	"id"	INTEGER,
	"nombre"	TEXT NOT NULL,
	"apellido"	TEXT,
	"mote"	TEXT,
	"fecha_nacimiento"	TEXT,
	"fecha_muerte"	TEXT,
	"importancia"	INTEGER,
	"biografia"	TEXT,
	PRIMARY KEY("id" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "protagonismos_de_eventos" (
	"id"	INTEGER,
	"personaje_id"	INTEGER NOT NULL,
	"rol_id"	INTEGER NOT NULL,
	"evento_id"	INTEGER NOT NULL,
	"descripcion"	TEXT,
	PRIMARY KEY("id"),
	FOREIGN KEY("evento_id") REFERENCES "eventos"("id"),
	FOREIGN KEY("personaje_id") REFERENCES "personajes"("id"),
	FOREIGN KEY("rol_id") REFERENCES "roles"("id")
);
CREATE TABLE IF NOT EXISTS "relacionesPersonales" (
	"id"	INTEGER,
	"personaje_id1"	INTEGER NOT NULL,
	"tipo_relacion_id"	INTEGER NOT NULL,
	"personaje_id2"	INTEGER NOT NULL,
	"fecha_inicio"	TEXT,
	"fecha_fin"	TEXT,
	PRIMARY KEY("id"),
	FOREIGN KEY("personaje_id1") REFERENCES "personajes"("id"),
	FOREIGN KEY("personaje_id2") REFERENCES "personajes"("id"),
	FOREIGN KEY("tipo_relacion_id") REFERENCES "tipos_relaciones_personales"("id")
);
CREATE TABLE IF NOT EXISTS "rolPersonajes" (
	"id"	INTEGER,
	"personaje_id"	INTEGER NOT NULL,
	"rol_id"	INTEGER NOT NULL,
	"evento_id"	INTEGER,
	"fecha_inicio"	TEXT,
	"fecha_fin"	TEXT,
	PRIMARY KEY("id"),
	FOREIGN KEY("evento_id") REFERENCES "eventos"("id"),
	FOREIGN KEY("personaje_id") REFERENCES "personajes"("id"),
	FOREIGN KEY("rol_id") REFERENCES "roles"("id")
);
CREATE TABLE IF NOT EXISTS "roles" (
	"id"	INTEGER,
	"nombre"	TEXT NOT NULL,
	"descripcion"	TEXT,
	PRIMARY KEY("id" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "tipoParentesco" (
	"id"	INTEGER,
	"nombre"	TEXT NOT NULL UNIQUE,
	"reciproca"	TEXT NOT NULL,
	PRIMARY KEY("id" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "tipos_de_cargos" (
	"id"	INTEGER,
	"nombre"	TEXT NOT NULL UNIQUE,
	PRIMARY KEY("id" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "tipos_relaciones_personales" (
	"id"	INTEGER,
	"nombre"	TEXT NOT NULL UNIQUE,
	"reciproca"	TEXT,
	PRIMARY KEY("id" AUTOINCREMENT)
);
INSERT INTO "cargos" VALUES (0,1,4,3,'1001-01-01','1002-01-05');
INSERT INTO "cargos" VALUES (1,1,1,1,'0739-01-01','0757-01-01');
INSERT INTO "eventos" VALUES (1,'Nuevo Evento Famoso','1000-01-01','1000-01-01',1,'Por algo será');
INSERT INTO "eventos" VALUES (2,'Nuevo Evento Famosillo','1021-01-22','1000-01-01',9,'Por algo será si es-');
INSERT INTO "instituciones" VALUES (2,'Ministerio de Fomento','agricolas');
INSERT INTO "instituciones" VALUES (3,'Casa de Bernarda','Literarias');
INSERT INTO "lazosFamiliares" VALUES (1,1,1,2,NULL,NULL);
INSERT INTO "lazosFamiliares" VALUES (2,2,2,1,NULL,NULL);
INSERT INTO "lugares" VALUES (1,'El Tejado',381.0,11.0,'pruebas');
INSERT INTO "lugares" VALUES (2,'OtroSitio',381.0,31.0,'no');
INSERT INTO "lugares" VALUES (3,'Cuarto oscuro',373.0,13.0,'Est es una descripción somera de lo que vale un peine');
INSERT INTO "lugares" VALUES (4,'Quintus',379.0,133.0,'k');
INSERT INTO "lugares" VALUES (5,'Boniatos',377.0,22.0,'l');
INSERT INTO "lugares" VALUES (6,'tris',383.0,21.0,'kkk');
INSERT INTO "lugares" VALUES (7,'Sigo',399.0,25.0,'hhh');
INSERT INTO "lugares" VALUES (8,'tras',77.0,11.0,'pp');
INSERT INTO "lugares" VALUES (9,'Mi casaaa',NULL,NULL,'pruebas raras');
INSERT INTO "personajes" VALUES (1,'Repapalos','Perez y Ras','el Catolico','0693-01-01','0757-01-01',8,'Era yerno de don Pelayo, ya que estaba casado con su hija Ermesinda,1​ e hijo de Pedro, duque de Cantabria, el cual a su vez, hasta el siglo XIX, basándose en los antiguos cronistas, se creyó que fue hijo del rey visigodo Ervigio. Sin embargo, no existe ninguna prueba documental. Según la versión rotense de la Crónica albeldense, Pedro era exregni prosapiem; o sea, de estirpe real visigoda y por consiguiente también lo sería su hijo Alfonso.2​ Las Crónicas declaran que los reyes asturianos son descendientes de Leovigildo y Recaredo y tratan de crear una continuidad institucional entre ambas realidades políticas. La moderna historiografía coincide en que la causa final de este fenómeno radica en lo que se denominada «neogoticismo» que respondía a una red de intereses políticos y al reforzamiento del prestigio personal de Alfonso III.a​ Fruela de Cantabria, hermano de Alfonso I, fue padre de dos reyes: Aurelio y Bermudo I. ');
INSERT INTO "personajes" VALUES (2,'Pedro de Cantabria','dux de Cantabria','','0680-01-01','0730-01-01',9,'Pedro de Cantabria (?-730) fue duque (dux) de Cantabria; lo era en 702 (año de la muerte de Egica) y en 710 (año de la muerte de Vitiza).1​ Probablemente nació hacia 680 y murió en el año 730.

Es el antepasado común de todos los reyes de Asturias. Su hijo Alfonso I el Católico se casó con la hija de Pelayo, fundador del reino de Asturias. Pero, tras la muerte de su hijo Favila, que reinó durante dos años, la corona del Reino de Asturias volvió definitivamente al linaje de Pedro de Cantabria, que es el antepasado más antiguo conocido de los reyes de España. ');
INSERT INTO "roles" VALUES (1,'Amo de casa','Cosa tonta');
INSERT INTO "tipoParentesco" VALUES (1,'Hijo/a','Progenitor');
INSERT INTO "tipoParentesco" VALUES (2,'Progenitor','Descendiente');
INSERT INTO "tipoParentesco" VALUES (3,'Abuelo/a','Nieto/a');
INSERT INTO "tipoParentesco" VALUES (4,'Hermano/a','Hermano/a');
INSERT INTO "tipoParentesco" VALUES (5,'Tio/a','Sobrino/a');
INSERT INTO "tipoParentesco" VALUES (6,'Padre nat.','Bastardo');
INSERT INTO "tipoParentesco" VALUES (7,'Primo/a','Primo/a');
INSERT INTO "tipoParentesco" VALUES (8,'Cuñado/a','Cuñado/a');
INSERT INTO "tipoParentesco" VALUES (9,'Bisabuelo/a','Bisnieto/a');
INSERT INTO "tipoParentesco" VALUES (10,'Esposos','Esposos');
INSERT INTO "tipoParentesco" VALUES (11,'Nieto/a','Abuelo/a');
INSERT INTO "tipoParentesco" VALUES (12,'Sobrino/a','Tio/a');
INSERT INTO "tipoParentesco" VALUES (13,'Bastardo','Padre nat.');
INSERT INTO "tipoParentesco" VALUES (14,'Bisnieto/a','Bisabuelo/a');
INSERT INTO "tipos_de_cargos" VALUES (1,'Rey de Asturias');
INSERT INTO "tipos_de_cargos" VALUES (2,'Duque de Cantabria');
INSERT INTO "tipos_de_cargos" VALUES (3,'Amo de casa');
INSERT INTO "tipos_de_cargos" VALUES (4,'Tonto l`haba');
COMMIT;
