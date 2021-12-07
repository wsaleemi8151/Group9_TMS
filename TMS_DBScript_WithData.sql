 
CREATE DATABASE IF NOT EXISTS TMS_DB;
USE TMS_DB;

-- MySQL dump 10.13  Distrib 8.0.27, for Win64 (x86_64)
--
-- Host: localhost    Database: tms_db
-- ------------------------------------------------------
-- Server version	8.0.26

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
-- Table structure for table `address`
--

DROP TABLE IF EXISTS `address`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `address` (
  `AddressID` int NOT NULL AUTO_INCREMENT,
  `StreetAddress` varchar(150) NOT NULL,
  `CityID` int NOT NULL,
  PRIMARY KEY (`AddressID`),
  KEY `CityID` (`CityID`),
  CONSTRAINT `address_ibfk_1` FOREIGN KEY (`CityID`) REFERENCES `city` (`CityID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `address`
--

LOCK TABLES `address` WRITE;
/*!40000 ALTER TABLE `address` DISABLE KEYS */;
/*!40000 ALTER TABLE `address` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `carrier`
--

DROP TABLE IF EXISTS `carrier`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `carrier` (
  `CarrierID` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL,
  `VehicleDimensions` varchar(100) NOT NULL,
  `CreatedBy` int NOT NULL,
  `CreatedOn` datetime NOT NULL,
  `UpdatedBy` int NOT NULL,
  `UpdatedOn` datetime NOT NULL,
  PRIMARY KEY (`CarrierID`),
  KEY `CreatedBy` (`CreatedBy`),
  KEY `UpdatedBy` (`UpdatedBy`),
  CONSTRAINT `carrier_ibfk_1` FOREIGN KEY (`CreatedBy`) REFERENCES `user` (`UserID`),
  CONSTRAINT `carrier_ibfk_2` FOREIGN KEY (`UpdatedBy`) REFERENCES `user` (`UserID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `carrier`
--

LOCK TABLES `carrier` WRITE;
/*!40000 ALTER TABLE `carrier` DISABLE KEYS */;
INSERT INTO `carrier` VALUES (1,'Carrier1','18x40x12',1,'0000-00-00 00:00:00',1,'0000-00-00 00:00:00');
/*!40000 ALTER TABLE `carrier` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `city`
--

DROP TABLE IF EXISTS `city`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `city` (
  `CityID` int NOT NULL AUTO_INCREMENT,
  `City` varchar(50) NOT NULL,
  `StateID` int NOT NULL,
  PRIMARY KEY (`CityID`),
  KEY `StateID` (`StateID`),
  CONSTRAINT `city_ibfk_1` FOREIGN KEY (`StateID`) REFERENCES `state` (`StateID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `city`
--

LOCK TABLES `city` WRITE;
/*!40000 ALTER TABLE `city` DISABLE KEYS */;
/*!40000 ALTER TABLE `city` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `contract`
--

DROP TABLE IF EXISTS `contract`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `contract` (
  `ContractID` int NOT NULL AUTO_INCREMENT,
  `ContractDetails` varchar(200) NOT NULL,
  `CustomerID` int NOT NULL,
  `CreatedBy` int NOT NULL,
  `CreatedOn` datetime NOT NULL,
  `UpdatedBy` int NOT NULL,
  `UpdatedOn` datetime NOT NULL,
  PRIMARY KEY (`ContractID`),
  KEY `CustomerID` (`CustomerID`),
  KEY `CreatedBy` (`CreatedBy`),
  KEY `UpdatedBy` (`UpdatedBy`),
  CONSTRAINT `contract_ibfk_1` FOREIGN KEY (`CustomerID`) REFERENCES `customer` (`CustomerID`),
  CONSTRAINT `contract_ibfk_2` FOREIGN KEY (`CreatedBy`) REFERENCES `user` (`UserID`),
  CONSTRAINT `contract_ibfk_3` FOREIGN KEY (`UpdatedBy`) REFERENCES `user` (`UserID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `contract`
--

LOCK TABLES `contract` WRITE;
/*!40000 ALTER TABLE `contract` DISABLE KEYS */;
/*!40000 ALTER TABLE `contract` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `country`
--

DROP TABLE IF EXISTS `country`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `country` (
  `CountryID` int NOT NULL AUTO_INCREMENT,
  `Country` varchar(50) NOT NULL,
  PRIMARY KEY (`CountryID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `country`
--

LOCK TABLES `country` WRITE;
/*!40000 ALTER TABLE `country` DISABLE KEYS */;
/*!40000 ALTER TABLE `country` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customer`
--

DROP TABLE IF EXISTS `customer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customer` (
  `CustomerID` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL,
  `CompanyName` varchar(200) DEFAULT NULL,
  `CreatedBy` int NOT NULL,
  `CreatedOn` datetime NOT NULL,
  `UpdatedBy` int NOT NULL,
  `UpdatedOn` datetime NOT NULL,
  PRIMARY KEY (`CustomerID`),
  KEY `CreatedBy` (`CreatedBy`),
  KEY `UpdatedBy` (`UpdatedBy`),
  CONSTRAINT `customer_ibfk_1` FOREIGN KEY (`CreatedBy`) REFERENCES `user` (`UserID`),
  CONSTRAINT `customer_ibfk_2` FOREIGN KEY (`UpdatedBy`) REFERENCES `user` (`UserID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer`
--

LOCK TABLES `customer` WRITE;
/*!40000 ALTER TABLE `customer` DISABLE KEYS */;
/*!40000 ALTER TABLE `customer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customerorder`
--

DROP TABLE IF EXISTS `customerorder`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customerorder` (
  `OrderID` int NOT NULL AUTO_INCREMENT,
  `OrderDetails` varchar(200) NOT NULL,
  `OrderStatusID` int NOT NULL,
  `CustomerID` int NOT NULL,
  `CarrierID` int NOT NULL,
  `InvoiceID` int DEFAULT NULL,
  `CreatedBy` int NOT NULL,
  `CreatedOn` datetime NOT NULL,
  `UpdatedBy` int NOT NULL,
  `UpdatedOn` datetime NOT NULL,
  PRIMARY KEY (`OrderID`),
  KEY `OrderStatusID` (`OrderStatusID`),
  KEY `CustomerID` (`CustomerID`),
  KEY `CarrierID` (`CarrierID`),
  KEY `InvoiceID` (`InvoiceID`),
  KEY `CreatedBy` (`CreatedBy`),
  KEY `UpdatedBy` (`UpdatedBy`),
  CONSTRAINT `customerorder_ibfk_1` FOREIGN KEY (`OrderStatusID`) REFERENCES `orderstatus` (`OrderStatusID`),
  CONSTRAINT `customerorder_ibfk_2` FOREIGN KEY (`CustomerID`) REFERENCES `customer` (`CustomerID`),
  CONSTRAINT `customerorder_ibfk_3` FOREIGN KEY (`CarrierID`) REFERENCES `carrier` (`CarrierID`),
  CONSTRAINT `customerorder_ibfk_4` FOREIGN KEY (`InvoiceID`) REFERENCES `invoice` (`InvoiceID`),
  CONSTRAINT `customerorder_ibfk_5` FOREIGN KEY (`CreatedBy`) REFERENCES `user` (`UserID`),
  CONSTRAINT `customerorder_ibfk_6` FOREIGN KEY (`UpdatedBy`) REFERENCES `user` (`UserID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customerorder`
--

LOCK TABLES `customerorder` WRITE;
/*!40000 ALTER TABLE `customerorder` DISABLE KEYS */;
/*!40000 ALTER TABLE `customerorder` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fee`
--

DROP TABLE IF EXISTS `fee`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `fee` (
  `FeeID` int NOT NULL AUTO_INCREMENT,
  `Description` varchar(200) NOT NULL,
  `Fees` decimal(18,0) NOT NULL,
  `CreatedBy` int NOT NULL,
  `CreatedOn` datetime NOT NULL,
  `UpdatedBy` int NOT NULL,
  `UpdatedOn` datetime NOT NULL,
  PRIMARY KEY (`FeeID`),
  KEY `CreatedBy` (`CreatedBy`),
  KEY `UpdatedBy` (`UpdatedBy`),
  CONSTRAINT `fee_ibfk_1` FOREIGN KEY (`CreatedBy`) REFERENCES `user` (`UserID`),
  CONSTRAINT `fee_ibfk_2` FOREIGN KEY (`UpdatedBy`) REFERENCES `user` (`UserID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fee`
--

LOCK TABLES `fee` WRITE;
/*!40000 ALTER TABLE `fee` DISABLE KEYS */;
INSERT INTO `fee` VALUES (1,'Rout 1',200,1,'0000-00-00 00:00:00',1,'0000-00-00 00:00:00'),(2,'Rout 2',300,1,'0000-00-00 00:00:00',1,'0000-00-00 00:00:00'),(3,'Rout 3',100,1,'0000-00-00 00:00:00',1,'0000-00-00 00:00:00'),(4,'Rout 4',250,1,'0000-00-00 00:00:00',1,'0000-00-00 00:00:00'),(5,'Rout 5',450,1,'0000-00-00 00:00:00',1,'0000-00-00 00:00:00');
/*!40000 ALTER TABLE `fee` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `invoice`
--

DROP TABLE IF EXISTS `invoice`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `invoice` (
  `InvoiceID` int NOT NULL AUTO_INCREMENT,
  `FeeID` int NOT NULL,
  `PaymentStatus` varchar(50) NOT NULL,
  `CreatedBy` int NOT NULL,
  `CreatedOn` datetime NOT NULL,
  `UpdatedBy` int NOT NULL,
  `UpdatedOn` datetime NOT NULL,
  PRIMARY KEY (`InvoiceID`),
  KEY `FeeID` (`FeeID`),
  KEY `CreatedBy` (`CreatedBy`),
  KEY `UpdatedBy` (`UpdatedBy`),
  CONSTRAINT `invoice_ibfk_1` FOREIGN KEY (`FeeID`) REFERENCES `fee` (`FeeID`),
  CONSTRAINT `invoice_ibfk_2` FOREIGN KEY (`CreatedBy`) REFERENCES `user` (`UserID`),
  CONSTRAINT `invoice_ibfk_3` FOREIGN KEY (`UpdatedBy`) REFERENCES `user` (`UserID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `invoice`
--

LOCK TABLES `invoice` WRITE;
/*!40000 ALTER TABLE `invoice` DISABLE KEYS */;
/*!40000 ALTER TABLE `invoice` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `log`
--

DROP TABLE IF EXISTS `log`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `log` (
  `LogID` int NOT NULL AUTO_INCREMENT,
  `FileName` varchar(150) NOT NULL,
  `CreatedOn` datetime NOT NULL,
  PRIMARY KEY (`LogID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `log`
--

LOCK TABLES `log` WRITE;
/*!40000 ALTER TABLE `log` DISABLE KEYS */;
INSERT INTO `log` VALUES (1,'1.txt','0000-00-00 00:00:00'),(2,'2.txt','0000-00-00 00:00:00'),(3,'3.txt','0000-00-00 00:00:00'),(4,'4.txt','0000-00-00 00:00:00');
/*!40000 ALTER TABLE `log` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orderstatus`
--

DROP TABLE IF EXISTS `orderstatus`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orderstatus` (
  `OrderStatusID` int NOT NULL AUTO_INCREMENT,
  `Status` varchar(50) NOT NULL,
  PRIMARY KEY (`OrderStatusID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orderstatus`
--

LOCK TABLES `orderstatus` WRITE;
/*!40000 ALTER TABLE `orderstatus` DISABLE KEYS */;
/*!40000 ALTER TABLE `orderstatus` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ordertrip`
--

DROP TABLE IF EXISTS `ordertrip`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ordertrip` (
  `TripID` int NOT NULL AUTO_INCREMENT,
  `OrderID` int NOT NULL,
  `CarrierID` int NOT NULL,
  PRIMARY KEY (`TripID`),
  KEY `OrderID` (`OrderID`),
  KEY `CarrierID` (`CarrierID`),
  CONSTRAINT `ordertrip_ibfk_1` FOREIGN KEY (`OrderID`) REFERENCES `customerorder` (`OrderID`),
  CONSTRAINT `ordertrip_ibfk_2` FOREIGN KEY (`CarrierID`) REFERENCES `carrier` (`CarrierID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ordertrip`
--

LOCK TABLES `ordertrip` WRITE;
/*!40000 ALTER TABLE `ordertrip` DISABLE KEYS */;
/*!40000 ALTER TABLE `ordertrip` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `role`
--

DROP TABLE IF EXISTS `role`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `role` (
  `RoleID` int NOT NULL AUTO_INCREMENT,
  `Role` varchar(50) NOT NULL,
  `Description` varchar(200) NOT NULL,
  PRIMARY KEY (`RoleID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `role`
--

LOCK TABLES `role` WRITE;
/*!40000 ALTER TABLE `role` DISABLE KEYS */;
INSERT INTO `role` VALUES (1,'Admin','Admin'),(2,'Planner','Planner'),(3,'Buyer','Buyer');
/*!40000 ALTER TABLE `role` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `route`
--

DROP TABLE IF EXISTS `route`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `route` (
  `RouteID` int NOT NULL AUTO_INCREMENT,
  `Description` varchar(200) NOT NULL,
  `SourceAddressID` int NOT NULL,
  `DestinationAddressID` int NOT NULL,
  `CreatedBy` int NOT NULL,
  `CreatedOn` datetime NOT NULL,
  `UpdatedBy` int NOT NULL,
  `UpdatedOn` datetime NOT NULL,
  PRIMARY KEY (`RouteID`),
  KEY `SourceAddressID` (`SourceAddressID`),
  KEY `DestinationAddressID` (`DestinationAddressID`),
  KEY `CreatedBy` (`CreatedBy`),
  KEY `UpdatedBy` (`UpdatedBy`),
  CONSTRAINT `route_ibfk_1` FOREIGN KEY (`SourceAddressID`) REFERENCES `address` (`AddressID`),
  CONSTRAINT `route_ibfk_2` FOREIGN KEY (`DestinationAddressID`) REFERENCES `address` (`AddressID`),
  CONSTRAINT `route_ibfk_3` FOREIGN KEY (`CreatedBy`) REFERENCES `user` (`UserID`),
  CONSTRAINT `route_ibfk_4` FOREIGN KEY (`UpdatedBy`) REFERENCES `user` (`UserID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `route`
--

LOCK TABLES `route` WRITE;
/*!40000 ALTER TABLE `route` DISABLE KEYS */;
/*!40000 ALTER TABLE `route` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `state`
--

DROP TABLE IF EXISTS `state`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `state` (
  `StateID` int NOT NULL AUTO_INCREMENT,
  `State` varchar(50) NOT NULL,
  `CountryID` int NOT NULL,
  PRIMARY KEY (`StateID`),
  KEY `CountryID` (`CountryID`),
  CONSTRAINT `state_ibfk_1` FOREIGN KEY (`CountryID`) REFERENCES `country` (`CountryID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `state`
--

LOCK TABLES `state` WRITE;
/*!40000 ALTER TABLE `state` DISABLE KEYS */;
/*!40000 ALTER TABLE `state` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user` (
  `UserID` int NOT NULL AUTO_INCREMENT,
  `UserName` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `FirstName` varchar(50) NOT NULL,
  `LastName` varchar(50) NOT NULL,
  `RoleID` int NOT NULL,
  `CreatedBy` int NOT NULL,
  `CreatedOn` datetime NOT NULL,
  `UpdatedBy` int NOT NULL,
  `UpdatedOn` datetime NOT NULL,
  PRIMARY KEY (`UserID`),
  KEY `CreatedBy` (`CreatedBy`),
  KEY `UpdatedBy` (`UpdatedBy`),
  CONSTRAINT `user_ibfk_1` FOREIGN KEY (`CreatedBy`) REFERENCES `user` (`UserID`),
  CONSTRAINT `user_ibfk_2` FOREIGN KEY (`UpdatedBy`) REFERENCES `user` (`UserID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (1,'Admin','test','User','Test',1,1,'0000-00-00 00:00:00',1,'0000-00-00 00:00:00'),(2,'Planner','test','Planner','User',2,1,'0000-00-00 00:00:00',1,'0000-00-00 00:00:00'),(3,'Buyer','test','Buyer','User',3,1,'0000-00-00 00:00:00',1,'0000-00-00 00:00:00');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-12-08  0:40:34
