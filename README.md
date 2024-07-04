Hello!

To ensure the program works correctly, you need to have MySQL Server installed and enter this code in MySQL:


CREATE DATABASE quiz;
USE quiz;

DROP TABLE IF EXISTS `kontinente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `kontinente` (
  `NR` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`NR`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

LOCK TABLES `kontinente` WRITE;
/*!40000 ALTER TABLE `kontinente` DISABLE KEYS */;
INSERT INTO `kontinente` VALUES 
(1,'EUROBA'),(2,'Afrika'),(3,'Asien'),(4,'Nordamerika'),
(5,'Australien'),(6,'Sudamerika');
/*!40000 ALTER TABLE `kontinente` ENABLE KEYS */;
UNLOCK TABLES;

DROP TABLE IF EXISTS `laender`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `laender` (
  `NR` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) NOT NULL,
  `Hauptstadt` varchar(255) NOT NULL,
  `KoNr` int(11) DEFAULT NULL,
  PRIMARY KEY (`NR`),
  KEY `KoNr` (`KoNr`),
  CONSTRAINT `laender_ibfk_1` FOREIGN KEY (`KoNr`) REFERENCES `kontinente` (`NR`)
) ENGINE=InnoDB AUTO_INCREMENT=64 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

LOCK TABLES `laender` WRITE;
/*!40000 ALTER TABLE `laender` DISABLE KEYS */;
INSERT INTO `laender` VALUES 
(1,'Deutschland','Berlin',1),(2,'Albanien','Tirana',1),(3,'Bulgarien','Sofia',1),(4,'Aland','Mariehamn',1),(5,'Finnland','Helsinki',1),
(6,'Irland','Dublin',1),(7,'Island','Reykjavik',1),(8,'Kosovo','Pristina',1),(9,'Lettland','Riga',1),(10,'Luxemburg','Luxemburg',1),
(11,'Malta','Valletta',1),(12,'Norwegen','Oslo',1),(13,'Russland','Moskau',1),(14,'Algerien','Algier',2),(15,'Dschibuti','Dschibuti',2),
(16,'Eritrea','Asmara',2),(17,'Gabun','Libreville',2),(18,'Gambia','Banjul',2),(19,'Ghana','Accra',2),(20,'Ghana','Conakry',2),
(21,'?gypten','Kairo',2),(22,'Nigeria','Abuja',2),(23,'S?dafrika','Pretoria',2),(24,'Kenia','Nairobi',2),(25,'Marokko','Rabat',2),
(26,'Marokko','Rabat',2),(27,'Bahrain','Manama',3),(28,'Bangladesch','Dhaka',3),(29,'China','Peking',3),(30,'Iran','Teheran',3),
(31,'Japan','Tokio',3),(32,'Oman','Maskat',3),(33,'Pakistan','Islamabad',3),(34,'Philippinen','Philippinen',3),(35,'Singapur','Singapur',3),
(36,'Tadschikistan','Duschanbe',3),(37,'Taiwan','Taipeh',3),(38,'Jemen','Sanaa',3),(39,'Taiwan','Taipeh',3),(40,'USA','Washington',4),
(41,'Kanada','Ottawa',4),(42,'Mexiko','Mexiko-Stadt',4),(43,'Guatemala','Guatemala-Stadt',4),(44,'Belize','Belmopan',4),
(45,'Honduras','Tegucigalpa',4),(46,'Salvador','San Salvador',4),(47,'Nicaragua','Managua',4),(48,'Costa Rica','San Jos?',4),
(49,'Panama','Panama-Stadt',4),(50,'Australien','Canberra',5),(51,'Papua-Neuguinea','Port Moresby',5),(52,'Neuseeland','Wellington',5),
(53,'Argentinien','Buenos Aires',6),(54,'Brasilien','Bras?lia',6),(55,'Chile','Santiago',6),(56,'Ecuador','Quito',6),(57,'Guyana','Georgetown',6),
(58,'Kolumbien','Bogot?',6),(59,'Paraguay','Asunci?n',6),(60,'Peru','Lima',6),(61,'Suriname','Paramaribo',6),(62,'Uruguay','Montevideo',6),
(63,'Venezuela','Caracas',6);
/*!40000 ALTER TABLE `laender` ENABLE KEYS */;
UNLOCK TABLES;

DROP TABLE IF EXISTS `userandresults`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `userandresults` (
  `NR` int(11) NOT NULL AUTO_INCREMENT,
  `User` varchar(255) NOT NULL,
  `Results` int(11) DEFAULT NULL,
  PRIMARY KEY (`NR`)
) ENGINE=InnoDB AUTO_INCREMENT=58 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

LOCK TABLES `userandresults` WRITE;
/*!40000 ALTER TABLE `userandresults` DISABLE KEYS */;
INSERT INTO `userandresults` VALUES 
(1,'ccc',30),(2,'ertz',60),(3,'',70),(4,'',0),(5,'',10),(6,'',40),(7,'',40),(8,'',90),(9,'',10),(10,'',20),
(11,'',0),(12,'',0),(13,'',0),(14,'',0),(15,'',40),(16,'',20),(17,'',-120),(18,'',-200),(19,'',-200),(20,'',0),
(21,'',0),(22,'',0),(23,'',0),(24,'',-160),(25,'',-80),(26,'',-10),(27,'',-30),(28,'',0),(29,'',-20),(30,'',-20),
(31,'',-20),(32,'',-30),(33,'',-30),(34,'',-30),(35,'',-30),(36,'',-30),(37,'',-70),(38,'',-30),(39,'',-30),
(40,'',20),(41,'',10),(42,'',-50),(43,'',-50),(44,'',-50),(45,'',-70),(46,'',-90),(47,'',-90),(48,'',-90),
(49,'',-100),(50,'',-120),(51,'',-120),(52,'',-120),(53,'',-120),(54,'',-160),(55,'',-160),(56,'',-200),(57,'',70);
/*!40000 ALTER TABLE `userandresults` ENABLE KEYS */;
UNLOCK TABLES;

