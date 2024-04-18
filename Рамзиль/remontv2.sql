-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: localhost    Database: remontv2
-- ------------------------------------------------------
-- Server version	8.0.34

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `clients_table`
--

DROP TABLE IF EXISTS `clients_table`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clients_table` (
  `id_client` int NOT NULL AUTO_INCREMENT,
  `clientName` varchar(45) NOT NULL,
  `clientSurname` varchar(45) DEFAULT NULL,
  `clientPhone` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id_client`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clients_table`
--

LOCK TABLES `clients_table` WRITE;
/*!40000 ALTER TABLE `clients_table` DISABLE KEYS */;
INSERT INTO `clients_table` VALUES (1,'Марат',NULL,NULL),(2,'Максим','Колмагоров','1111111');
/*!40000 ALTER TABLE `clients_table` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `performers_table`
--

DROP TABLE IF EXISTS `performers_table`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `performers_table` (
  `stuffId` int NOT NULL,
  `requestId` int NOT NULL,
  PRIMARY KEY (`stuffId`),
  KEY `stuff_fkey_idx` (`stuffId`),
  KEY `request_fkey_idx` (`requestId`),
  CONSTRAINT `request_fkey` FOREIGN KEY (`requestId`) REFERENCES `requests_table` (`id_request`),
  CONSTRAINT `stuff_fkey` FOREIGN KEY (`stuffId`) REFERENCES `staffs_table` (`id_staff`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `performers_table`
--

LOCK TABLES `performers_table` WRITE;
/*!40000 ALTER TABLE `performers_table` DISABLE KEYS */;
INSERT INTO `performers_table` VALUES (4,6);
/*!40000 ALTER TABLE `performers_table` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `requests_table`
--

DROP TABLE IF EXISTS `requests_table`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `requests_table` (
  `id_request` int NOT NULL AUTO_INCREMENT,
  `requestCreateDate` datetime NOT NULL,
  `requestFinishedDate` datetime DEFAULT NULL,
  `reuestEquipment` varchar(45) NOT NULL,
  `requestsDescription` text NOT NULL,
  `requestTypeFaultId` int NOT NULL,
  `requestClietnId` int NOT NULL,
  `requestStatusId` int DEFAULT NULL,
  `requestPriority` enum('Низкое','Среднее','Высокое') DEFAULT NULL,
  `requestComment` text,
  PRIMARY KEY (`id_request`),
  KEY `client_fk_idx` (`requestClietnId`),
  KEY `status_fk_idx` (`requestStatusId`),
  KEY `type_fk_idx` (`requestTypeFaultId`),
  CONSTRAINT `client_fk` FOREIGN KEY (`requestClietnId`) REFERENCES `clients_table` (`id_client`),
  CONSTRAINT `status_fk` FOREIGN KEY (`requestStatusId`) REFERENCES `status_table` (`id_status`),
  CONSTRAINT `type_fk` FOREIGN KEY (`requestTypeFaultId`) REFERENCES `type_fault_table` (`id_typeFault`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `requests_table`
--

LOCK TABLES `requests_table` WRITE;
/*!40000 ALTER TABLE `requests_table` DISABLE KEYS */;
INSERT INTO `requests_table` VALUES (6,'2024-03-13 22:40:24',NULL,'Ноутбук','testttt',1,1,1,'Среднее','trst'),(9,'2024-03-13 22:57:44',NULL,'sd','asdtest',1,1,1,'Высокое',NULL),(10,'2024-03-14 09:02:45',NULL,'qweqwe','qweqweqw',1,2,1,'Высокое',NULL),(11,'2024-03-14 09:03:53',NULL,'asd','asdasd',1,1,1,NULL,NULL);
/*!40000 ALTER TABLE `requests_table` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `roles_table`
--

DROP TABLE IF EXISTS `roles_table`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `roles_table` (
  `id_role` int NOT NULL AUTO_INCREMENT,
  `roleName` varchar(45) NOT NULL,
  PRIMARY KEY (`id_role`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roles_table`
--

LOCK TABLES `roles_table` WRITE;
/*!40000 ALTER TABLE `roles_table` DISABLE KEYS */;
INSERT INTO `roles_table` VALUES (1,'Сотрудник'),(2,'Исполнитель'),(3,'Менеджер');
/*!40000 ALTER TABLE `roles_table` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `services_table`
--

DROP TABLE IF EXISTS `services_table`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `services_table` (
  `id_services` int NOT NULL AUTO_INCREMENT,
  `servicesRequestId` int NOT NULL,
  `servicesName` varchar(45) NOT NULL,
  `servicesCost` decimal(19,2) NOT NULL,
  `servicesCount` int NOT NULL,
  `servicesDate` datetime NOT NULL,
  PRIMARY KEY (`id_services`),
  KEY `req_fk_idx` (`servicesRequestId`),
  CONSTRAINT `req_fk` FOREIGN KEY (`servicesRequestId`) REFERENCES `requests_table` (`id_request`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `services_table`
--

LOCK TABLES `services_table` WRITE;
/*!40000 ALTER TABLE `services_table` DISABLE KEYS */;
/*!40000 ALTER TABLE `services_table` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `staffs_table`
--

DROP TABLE IF EXISTS `staffs_table`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `staffs_table` (
  `id_staff` int NOT NULL AUTO_INCREMENT,
  `staffName` varchar(45) NOT NULL,
  `staffSurname` varchar(45) NOT NULL,
  `staffPhone` varchar(45) NOT NULL,
  `staffPassword` varchar(45) NOT NULL,
  `staffRoleId` int NOT NULL,
  `stuffLogin` varchar(45) NOT NULL,
  PRIMARY KEY (`id_staff`),
  UNIQUE KEY `stuffLogin_UNIQUE` (`stuffLogin`),
  KEY `role_fkey_idx` (`staffRoleId`),
  CONSTRAINT `role_fkey` FOREIGN KEY (`staffRoleId`) REFERENCES `roles_table` (`id_role`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `staffs_table`
--

LOCK TABLES `staffs_table` WRITE;
/*!40000 ALTER TABLE `staffs_table` DISABLE KEYS */;
INSERT INTO `staffs_table` VALUES (1,'Ramzil','Ибрагимов','79174216677','admin',1,'admin'),(2,'Роберт','Мухаметшин','79000000000','admin123',2,'admin123'),(3,'Мксим','Мусин','79988888888','123',3,'test'),(4,'Николай','Комилов','79988888888','test123',2,'tes123');
/*!40000 ALTER TABLE `staffs_table` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `status_table`
--

DROP TABLE IF EXISTS `status_table`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `status_table` (
  `id_status` int NOT NULL AUTO_INCREMENT,
  `statusName` varchar(45) NOT NULL,
  PRIMARY KEY (`id_status`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `status_table`
--

LOCK TABLES `status_table` WRITE;
/*!40000 ALTER TABLE `status_table` DISABLE KEYS */;
INSERT INTO `status_table` VALUES (1,'в ожидании');
/*!40000 ALTER TABLE `status_table` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `type_fault_table`
--

DROP TABLE IF EXISTS `type_fault_table`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `type_fault_table` (
  `id_typeFault` int NOT NULL AUTO_INCREMENT,
  `typeFaultName` varchar(45) NOT NULL,
  PRIMARY KEY (`id_typeFault`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `type_fault_table`
--

LOCK TABLES `type_fault_table` WRITE;
/*!40000 ALTER TABLE `type_fault_table` DISABLE KEYS */;
INSERT INTO `type_fault_table` VALUES (1,'Механическое');
/*!40000 ALTER TABLE `type_fault_table` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-04-18  0:23:54
