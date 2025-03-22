-- MySQL dump 10.13  Distrib 8.0.41, for Win64 (x86_64)
--
-- Host: localhost    Database: dbmcpms
-- ------------------------------------------------------
-- Server version	8.0.41

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
-- Table structure for table `tblallowance`
--

DROP TABLE IF EXISTS `tblallowance`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblallowance` (
  `allowanceID` int NOT NULL AUTO_INCREMENT,
  `allowanceName` varchar(45) NOT NULL,
  `status` varchar(45) NOT NULL,
  PRIMARY KEY (`allowanceID`),
  UNIQUE KEY `allowanceID_UNIQUE` (`allowanceID`),
  UNIQUE KEY `allowanceName_UNIQUE` (`allowanceName`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblallowance`
--

LOCK TABLES `tblallowance` WRITE;
/*!40000 ALTER TABLE `tblallowance` DISABLE KEYS */;
/*!40000 ALTER TABLE `tblallowance` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblattendance`
--

DROP TABLE IF EXISTS `tblattendance`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblattendance` (
  `attendanceID` int NOT NULL AUTO_INCREMENT,
  `employeeID` int NOT NULL,
  `date` date NOT NULL,
  `login` datetime DEFAULT NULL,
  `logout` datetime DEFAULT NULL,
  `report` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`attendanceID`),
  UNIQUE KEY `attendanceID_UNIQUE` (`employeeID`,`date`)
) ENGINE=InnoDB AUTO_INCREMENT=43 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblattendance`
--

LOCK TABLES `tblattendance` WRITE;
/*!40000 ALTER TABLE `tblattendance` DISABLE KEYS */;
INSERT INTO `tblattendance` VALUES (1,1,'2024-11-01','2024-11-01 08:00:51','2024-11-01 17:00:52','Present'),(2,1,'2024-11-02','2024-11-02 08:00:57','2024-11-02 19:01:02','Present'),(3,1,'2024-11-03','2024-11-03 08:01:16','2024-11-03 17:01:21','Present'),(4,1,'2024-11-06','2024-11-06 08:00:34','2024-11-06 17:00:40','Present'),(5,1,'2024-11-07','2024-11-07 08:00:48','2024-11-07 17:00:53','Present'),(6,1,'2024-11-08','2024-11-08 08:01:02','2024-11-08 19:01:05','Present'),(7,1,'2024-11-09','2024-11-09 09:01:12','2024-11-09 16:01:16','Present'),(8,1,'2024-11-11','2024-11-11 08:01:52','2024-11-11 17:01:58','Present'),(9,1,'2024-11-12','2024-11-12 08:01:01','2024-11-12 18:01:04','Present'),(10,1,'2024-11-13','2024-11-13 07:48:10','2024-11-13 17:00:15','Present'),(11,1,'2024-11-14','2024-11-14 08:00:18','2024-11-14 17:00:26','Present'),(12,1,'2024-11-15','2024-11-15 08:00:32','2024-11-15 17:00:35','Present'),(13,2,'2024-11-01','2024-11-01 08:01:14','2024-11-01 17:01:32','Present'),(14,4,'2024-11-01','2024-11-01 08:01:20','2024-11-01 17:01:30','Present'),(15,3,'2024-11-01','2024-11-01 08:01:24','2024-11-01 17:01:34','Present'),(16,4,'2024-11-02','2024-11-02 08:00:39','2024-11-02 17:00:46','Present'),(17,2,'2024-11-02','2024-11-02 08:00:41','2024-11-02 17:00:50','Present'),(18,3,'2024-11-02','2024-11-02 08:00:43','2024-11-02 17:00:52','Present'),(19,4,'2024-11-03','2024-11-03 08:00:56','2024-11-03 17:01:01','Present'),(20,2,'2024-11-03','2024-11-03 08:00:58','2024-11-03 17:01:04','Present'),(21,3,'2024-11-03','2024-11-03 08:01:00','2024-11-03 17:01:07','Present'),(22,4,'2024-11-06','2024-11-06 08:01:11','2024-11-06 17:01:21','Present'),(23,2,'2024-11-06','2024-11-06 08:01:15','2024-11-06 17:01:23','Present'),(24,3,'2024-11-06','2024-11-06 08:01:17','2024-11-06 17:01:25','Present'),(25,4,'2024-11-08','2024-11-08 08:01:31','2024-11-08 17:01:39','Present'),(26,2,'2024-11-08','2024-11-08 08:01:33','2024-11-08 17:01:41','Present'),(27,3,'2024-11-08','2024-11-08 08:01:35','2024-11-08 17:01:43','Present'),(28,4,'2024-11-10','2024-11-10 08:00:48','2024-11-10 17:00:58','Present'),(29,2,'2024-11-10','2024-11-10 08:00:52','2024-11-10 17:01:00','Present'),(30,3,'2024-11-10','2024-11-10 08:00:54','2024-11-10 17:01:02','Present'),(31,4,'2024-11-12','2024-11-12 08:01:09','2024-11-12 17:02:07','Present'),(32,2,'2024-11-12','2024-11-12 08:01:11','2024-11-12 17:02:09','Present'),(33,3,'2024-11-12','2024-11-12 08:01:13','2024-11-12 17:02:11','Present'),(34,4,'2024-11-13','2024-11-13 08:00:10','2024-11-13 17:00:18','Present'),(35,2,'2024-11-13','2024-11-13 08:00:11','2024-11-13 17:00:19','Present'),(36,3,'2024-11-13','2024-11-13 08:00:13','2024-11-13 17:00:21','Present'),(37,1,'2024-11-04',NULL,NULL,'On Leave'),(38,2,'2024-11-04',NULL,NULL,'On Leave'),(39,1,'2024-12-15','2024-12-15 13:17:12','2024-12-16 13:23:35','Present'),(40,1,'2024-12-16','2024-12-16 13:23:41',NULL,'Present'),(41,1,'2024-12-18','2024-12-18 13:24:05','2024-12-19 13:25:34','Present'),(42,1,'2024-12-19','2024-12-19 13:25:48',NULL,'Present');
/*!40000 ALTER TABLE `tblattendance` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblaudit`
--

DROP TABLE IF EXISTS `tblaudit`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblaudit` (
  `auditID` int NOT NULL AUTO_INCREMENT,
  `action` varchar(100) NOT NULL,
  `dateActed` varchar(100) NOT NULL,
  PRIMARY KEY (`auditID`)
) ENGINE=InnoDB AUTO_INCREMENT=82 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblaudit`
--

LOCK TABLES `tblaudit` WRITE;
/*!40000 ALTER TABLE `tblaudit` DISABLE KEYS */;
INSERT INTO `tblaudit` VALUES (1,'De Guzman Albert added a Payroll Staff account: Ryan Lumayag','2024-11-29 08:40:29'),(2,'De Guzman Albert added a Payroll Staff account: Renz Garcia','2024-11-29 08:41:18'),(3,'De Guzman Albert updated a Payroll Staff Account: Clifford Villena','2024-11-29 08:42:23'),(4,'De Guzman Albert added a Payroll Staff account: Ryan Lumayag','2024-11-29 08:42:45'),(5,'De Guzman Albert added department: It Department','2024-11-29 08:43:14'),(6,'De Guzman Albert added department: Accounting Department','2024-11-29 08:43:26'),(7,'De Guzman Albert added department: Payroll Department','2024-11-29 08:43:37'),(8,'De Guzman Albert added position: It Head','2024-11-29 08:44:34'),(9,'De Guzman Albert added position: It Staff','2024-11-29 08:44:48'),(10,'De Guzman Albert added position: Accounting Head','2024-11-29 08:45:02'),(11,'De Guzman Albert added position: Accounting Staff','2024-11-29 08:45:13'),(12,'De Guzman Albert added position: Payroll Head','2024-11-29 08:45:22'),(13,'De Guzman Albert added position: Payroll Staff','2024-11-29 08:45:32'),(14,'De Guzman Albert updated a department: It','2024-11-29 08:46:01'),(15,'De Guzman Albert updated a position name: It Head','2024-11-29 08:46:43'),(16,'De Guzman Albert added a type of leave: Sick Leave','2024-11-29 08:47:09'),(17,'De Guzman Albert added a type of leave: Vacation Leave','2024-11-29 08:47:17'),(18,'De Guzman Albert added an allowance: Transportation Allowance','2024-11-29 08:47:36'),(19,'De Guzman Albert added an allowance: Food Allowance','2024-11-29 08:47:44'),(20,'De Guzman Albert added an allowance: Clothing Allowance','2024-11-29 08:47:51'),(21,'De Guzman Albert not sure kung anong message ng audit nito.','2024-11-29 08:49:48'),(22,'De Guzman Albert not sure kung anong message ng audit nito.','2024-11-29 08:52:18'),(23,'De Guzman Albert not sure kung anong message ng audit nito.','2024-11-29 08:53:23'),(24,'De Guzman Albert added an incentive: Performance Bonus','2024-11-29 08:56:32'),(25,'De Guzman Albert added an incentive: Attendance Bonus','2024-11-29 08:56:40'),(26,'De Guzman Albert added a holiday: Bonifacio Day','2024-11-29 08:57:27'),(27,'De Guzman Albert added a holiday: Immaculate Conception','2024-11-29 08:58:38'),(28,'De Guzman Albert updated Night Differential Rate\'s rate','2024-11-29 09:00:05'),(29,'De Guzman Albert updated Overtime - Regular Rate\'s rate','2024-11-29 09:00:18'),(30,'De Guzman Albert updated Overtime - Special Rate\'s rate','2024-11-29 09:00:34'),(31,'De Guzman Albert updated Rest Day Rate\'s rate','2024-11-29 09:00:47'),(32,'De Guzman Albert updated Special Holiday Rate\'s rate','2024-11-29 09:01:06'),(33,'De Guzman Albert updated Regular Holiday Rate\'s rate','2024-11-29 09:01:14'),(34,'De Guzman Albert updated Double Holiday Rate\'s rate','2024-11-29 09:01:24'),(35,'De Guzman Albert added new tax.','2024-11-29 09:11:32'),(36,'De Guzman Albert added new tax.','2024-11-29 09:11:44'),(37,'De Guzman Albert added new tax.','2024-11-29 09:23:07'),(38,'De Guzman Albert added new tax.','2024-11-29 09:23:34'),(39,'De Guzman Albert added new tax.','2024-11-29 09:30:25'),(40,'De Guzman Albert added new tax.','2024-11-29 09:31:49'),(41,'De Guzman Albert added SSS.','2024-11-29 09:38:48'),(42,'De Guzman Albert added SSS.','2024-11-29 09:41:10'),(43,'De Guzman Albert added SSS.','2024-11-29 09:41:24'),(44,'De Guzman Albert added SSS.','2024-11-29 09:41:32'),(45,'De Guzman Albert deleted an SSS.','2024-11-29 09:41:39'),(46,'De Guzman Albert added SSS.','2024-11-29 09:41:46'),(47,'De Guzman Albert added SSS.','2024-11-29 09:42:01'),(48,'De Guzman Albert added SSS.','2024-11-29 09:42:10'),(49,'De Guzman Albert added SSS.','2024-11-29 09:42:16'),(50,'De Guzman Albert added SSS.','2024-11-29 09:42:27'),(51,'De Guzman Albert added SSS.','2024-11-29 09:42:34'),(52,'De Guzman Albert added SSS.','2024-11-29 09:42:41'),(53,'De Guzman Albert added SSS.','2024-11-29 09:42:48'),(54,'De Guzman Albert added SSS.','2024-11-29 09:43:09'),(55,'De Guzman Albert updated PAGIBIG rates.','2024-11-29 09:43:46'),(56,'De Guzman Albert updated PhilHealth\'s rate.','2024-11-29 09:44:01'),(57,'De Guzman Albert added a voluntary contribution: Addtional Sss','2024-11-29 09:45:45'),(58,'De Guzman Albert added a voluntary contribution: Insurance','2024-11-29 09:46:12'),(59,'De Guzman Albert added a voluntary contribution: Hmo','2024-11-29 09:46:22'),(60,'De Guzman Albert added a voluntary contribution: Loan','2024-11-29 09:46:28'),(61,'Ryan James Lumayag set \'s schedule.','2024-11-29 10:40:36'),(62,'Ryan James Lumayag set \'s schedule.','2024-11-29 10:41:05'),(63,'Clifford Fru Villena set \'s schedule.','2024-11-29 10:52:11'),(64,'Ryan James Lumayag set \'s schedule.','2024-11-29 10:55:18'),(65,'Ryan James Lumayag set \'s schedule.','2024-11-29 10:56:28'),(66,'Ryan James Lumayag approved Ryan James Lumayag\'s overtime.','2024-11-29 11:19:32'),(67,'Ryan James Lumayag approved Ryan James Lumayag\'s overtime.','2024-11-29 11:19:52'),(68,'Ryan James Lumayag declined Ryan James Lumayag\'s overtime.','2024-11-29 11:20:03'),(69,'Ryan James Lumayag filed  from 11/29/2024 11:30:58 AM to 11/29/2024 11:30:58 AM','2024-11-29 11:30:58'),(70,'Ryan James Lumayag approved Ryan James Lumayag\'s leave.','2024-11-29 11:31:04'),(71,'Clifford Fru Villena filed  from 11/29/2024 11:47:09 AM to 11/29/2024 11:47:09 AM','2024-11-29 11:47:09'),(72,'Clifford Fru Villena approved Clifford Fru Villena\'s leave.','2024-11-29 11:47:22'),(73,'De Guzman Albert added a Payroll Staff account: Albert De Guzman','2024-12-20 22:01:59'),(74,'De Guzman Albert added department: Bookeeper Department','2024-12-20 22:02:16'),(75,'De Guzman Albert added a type of leave: Maternity Leave','2024-12-20 22:02:24'),(76,'De Guzman Albert added position: Libraian','2024-12-20 22:02:36'),(77,'De Guzman Albert added an allowance: Dinner Allowance','2024-12-20 22:02:56'),(78,'De Guzman Albert not sure kung anong message ng audit nito.','2024-12-20 22:03:17'),(79,'De Guzman Albert added an incentive: Christmas Bonus','2024-12-20 22:03:26'),(80,'De Guzman Albert added a holiday: Christmas Day','2024-12-20 22:03:43'),(81,'De Guzman Albert set Albert Nerza De Guzman as Department Head in Bookeeper Department','2024-12-20 22:05:02');
/*!40000 ALTER TABLE `tblaudit` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbldepartment`
--

DROP TABLE IF EXISTS `tbldepartment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbldepartment` (
  `departmentID` int NOT NULL AUTO_INCREMENT,
  `departmentName` varchar(45) NOT NULL,
  `status` varchar(45) NOT NULL,
  PRIMARY KEY (`departmentID`),
  UNIQUE KEY `departmentID_UNIQUE` (`departmentID`),
  UNIQUE KEY `departmentName_UNIQUE` (`departmentName`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbldepartment`
--

LOCK TABLES `tbldepartment` WRITE;
/*!40000 ALTER TABLE `tbldepartment` DISABLE KEYS */;
INSERT INTO `tbldepartment` VALUES (1,'It','Active'),(2,'Accounting Department','Active'),(3,'Payroll Department','Active'),(4,'Bookeeper Department','Active');
/*!40000 ALTER TABLE `tbldepartment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbldepartmenthead`
--

DROP TABLE IF EXISTS `tbldepartmenthead`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbldepartmenthead` (
  `departmentheadID` int NOT NULL AUTO_INCREMENT,
  `departmentID` int NOT NULL,
  `employeeID` int DEFAULT NULL,
  PRIMARY KEY (`departmentheadID`),
  UNIQUE KEY `departmentID_UNIQUE` (`departmentID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbldepartmenthead`
--

LOCK TABLES `tbldepartmenthead` WRITE;
/*!40000 ALTER TABLE `tbldepartmenthead` DISABLE KEYS */;
INSERT INTO `tbldepartmenthead` VALUES (1,1,1),(2,2,2),(3,4,5);
/*!40000 ALTER TABLE `tbldepartmenthead` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblempallowance`
--

DROP TABLE IF EXISTS `tblempallowance`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblempallowance` (
  `empallowanceID` int NOT NULL AUTO_INCREMENT,
  `employeeID` int NOT NULL,
  `allowance` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`empallowanceID`),
  UNIQUE KEY `employeeID_UNIQUE` (`employeeID`)
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblempallowance`
--

LOCK TABLES `tblempallowance` WRITE;
/*!40000 ALTER TABLE `tblempallowance` DISABLE KEYS */;
INSERT INTO `tblempallowance` VALUES (10,1,1000.00),(11,5,0.00),(12,2,0.00),(22,4,5000.00),(33,6,5000.00),(35,3,0.00);
/*!40000 ALTER TABLE `tblempallowance` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblemployee`
--

DROP TABLE IF EXISTS `tblemployee`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblemployee` (
  `employeeID` int NOT NULL AUTO_INCREMENT,
  `employeeNumber` int NOT NULL,
  `rfidnumber` varchar(45) NOT NULL,
  `firstname` varchar(45) NOT NULL,
  `middlename` varchar(45) DEFAULT NULL,
  `lastname` varchar(45) NOT NULL,
  `departmentID` int NOT NULL,
  `positionID` int DEFAULT NULL,
  `status` varchar(45) DEFAULT NULL,
  `password` varchar(45) DEFAULT NULL,
  `logged` varchar(45) DEFAULT 'No',
  PRIMARY KEY (`employeeID`),
  UNIQUE KEY `rfidnumber_UNIQUE` (`rfidnumber`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblemployee`
--

LOCK TABLES `tblemployee` WRITE;
/*!40000 ALTER TABLE `tblemployee` DISABLE KEYS */;
INSERT INTO `tblemployee` VALUES (1,20240001,'2711325364','Ryan','James','Lumayag',1,1,'Regular','123','No'),(2,20240002,'2686212532','Clifford','Fru','Villena',2,2,'Regular','123','No'),(3,20240003,'2714610820','renz','morano','garcia',3,3,'Regular',NULL,'No'),(4,20240004,'2687603892','jm','renz','buna',1,5,'Regular',NULL,'No'),(5,20240005,'2000000000','Albert','Nerza','De Guzman',4,11,'Regular',NULL,'No'),(6,20240006,'1234567890','Jomari',NULL,'Tenorio',1,5,'Probationary','123','Yes');
/*!40000 ALTER TABLE `tblemployee` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblemployeeleave`
--

DROP TABLE IF EXISTS `tblemployeeleave`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblemployeeleave` (
  `employeeleaveID` int NOT NULL AUTO_INCREMENT,
  `employeeID` int NOT NULL,
  `leaveID` int NOT NULL,
  `days` decimal(5,1) DEFAULT NULL,
  PRIMARY KEY (`employeeleaveID`),
  UNIQUE KEY `Unique` (`employeeID`,`leaveID`)
) ENGINE=InnoDB AUTO_INCREMENT=111 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblemployeeleave`
--

LOCK TABLES `tblemployeeleave` WRITE;
/*!40000 ALTER TABLE `tblemployeeleave` DISABLE KEYS */;
INSERT INTO `tblemployeeleave` VALUES (1,1,1,15.0),(2,5,3,100.0),(3,5,1,0.0),(4,5,2,0.0),(5,3,3,50.0),(6,3,1,100.0),(7,3,2,0.0),(15,1,3,120.0),(17,1,2,15.0),(27,2,3,0.0),(28,2,1,0.0),(29,2,2,0.0),(69,4,3,15.0),(70,4,1,15.0),(71,4,2,15.0),(102,6,3,120.0),(103,6,1,15.0),(104,6,2,15.0);
/*!40000 ALTER TABLE `tblemployeeleave` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblempvoluntary`
--

DROP TABLE IF EXISTS `tblempvoluntary`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblempvoluntary` (
  `empvoluntaryID` int NOT NULL AUTO_INCREMENT,
  `employeeID` int NOT NULL,
  `voluntaryID` int NOT NULL,
  `amount` decimal(10,2) NOT NULL,
  PRIMARY KEY (`empvoluntaryID`),
  UNIQUE KEY `Unique` (`employeeID`,`voluntaryID`)
) ENGINE=InnoDB AUTO_INCREMENT=210 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblempvoluntary`
--

LOCK TABLES `tblempvoluntary` WRITE;
/*!40000 ALTER TABLE `tblempvoluntary` DISABLE KEYS */;
INSERT INTO `tblempvoluntary` VALUES (33,1,1,50.00),(34,4,1,0.00),(35,4,3,0.00),(36,4,2,0.00),(37,4,4,0.00),(38,3,1,25.00),(39,3,3,500.00),(40,3,2,0.00),(41,3,4,0.00),(50,2,1,0.00),(51,2,3,0.00),(52,2,2,0.00),(53,2,4,0.00),(55,1,3,1000.00),(56,1,2,500.00),(57,1,4,250.00),(66,5,1,0.00),(67,5,3,0.00),(68,5,2,0.00),(69,5,4,0.00),(198,6,1,500.00),(199,6,3,350.00),(200,6,2,100.00),(201,6,4,300.00);
/*!40000 ALTER TABLE `tblempvoluntary` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblfiledftio`
--

DROP TABLE IF EXISTS `tblfiledftio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblfiledftio` (
  `ftioID` int NOT NULL AUTO_INCREMENT,
  `employeeID` int NOT NULL,
  `date` date NOT NULL,
  `time` time NOT NULL,
  `classification` varchar(45) NOT NULL,
  `reason` varchar(1000) NOT NULL,
  `status` varchar(45) NOT NULL,
  PRIMARY KEY (`ftioID`),
  UNIQUE KEY `Unique` (`employeeID`,`date`,`classification`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblfiledftio`
--

LOCK TABLES `tblfiledftio` WRITE;
/*!40000 ALTER TABLE `tblfiledftio` DISABLE KEYS */;
/*!40000 ALTER TABLE `tblfiledftio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblfiledleave`
--

DROP TABLE IF EXISTS `tblfiledleave`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblfiledleave` (
  `filedleaveID` int NOT NULL AUTO_INCREMENT,
  `employeeID` int NOT NULL,
  `leavefrom` date NOT NULL,
  `leaveto` date NOT NULL,
  `leaveID` int NOT NULL,
  `leavereason` varchar(1000) NOT NULL,
  `noofdays` int NOT NULL,
  `status` varchar(45) NOT NULL,
  PRIMARY KEY (`filedleaveID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblfiledleave`
--

LOCK TABLES `tblfiledleave` WRITE;
/*!40000 ALTER TABLE `tblfiledleave` DISABLE KEYS */;
INSERT INTO `tblfiledleave` VALUES (1,1,'2024-11-04','2024-11-04',1,'nagkasakit',1,'Approve'),(2,2,'2024-11-04','2024-11-04',1,'nagkasakit',1,'Approve');
/*!40000 ALTER TABLE `tblfiledleave` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblholiday`
--

DROP TABLE IF EXISTS `tblholiday`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblholiday` (
  `holidayID` int NOT NULL AUTO_INCREMENT,
  `date` date NOT NULL,
  `classification` varchar(45) NOT NULL,
  `holidayName` varchar(45) NOT NULL,
  PRIMARY KEY (`holidayID`),
  UNIQUE KEY `holidayID_UNIQUE` (`holidayID`) /*!80000 INVISIBLE */,
  UNIQUE KEY `holidayName` (`holidayName`,`date`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblholiday`
--

LOCK TABLES `tblholiday` WRITE;
/*!40000 ALTER TABLE `tblholiday` DISABLE KEYS */;
INSERT INTO `tblholiday` VALUES (1,'2024-11-30','Regular Holiday','Bonifacio Day'),(2,'2024-12-08','Special Holiday','Immaculate Conception'),(3,'2024-11-25','Double Holiday','Christmas Day');
/*!40000 ALTER TABLE `tblholiday` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblincentives`
--

DROP TABLE IF EXISTS `tblincentives`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblincentives` (
  `incentiveID` int NOT NULL AUTO_INCREMENT,
  `incentiveName` varchar(45) NOT NULL,
  `status` varchar(45) NOT NULL,
  PRIMARY KEY (`incentiveID`),
  UNIQUE KEY `idtblincentives_UNIQUE` (`incentiveID`),
  UNIQUE KEY `incentiveName_UNIQUE` (`incentiveName`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblincentives`
--

LOCK TABLES `tblincentives` WRITE;
/*!40000 ALTER TABLE `tblincentives` DISABLE KEYS */;
INSERT INTO `tblincentives` VALUES (1,'Performance Bonus','Active'),(2,'Attendance Bonus','Active'),(3,'Christmas Bonus','Active');
/*!40000 ALTER TABLE `tblincentives` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbljoballowance`
--

DROP TABLE IF EXISTS `tbljoballowance`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbljoballowance` (
  `jobAllowanceID` int NOT NULL AUTO_INCREMENT,
  `positionID` int NOT NULL,
  `allowanceID` int NOT NULL,
  `amount` decimal(10,2) NOT NULL,
  PRIMARY KEY (`jobAllowanceID`),
  UNIQUE KEY `jobAllowanceID_UNIQUE` (`jobAllowanceID`) /*!80000 INVISIBLE */,
  UNIQUE KEY `Unique` (`positionID`,`allowanceID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbljoballowance`
--

LOCK TABLES `tbljoballowance` WRITE;
/*!40000 ALTER TABLE `tbljoballowance` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbljoballowance` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbljobleave`
--

DROP TABLE IF EXISTS `tbljobleave`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbljobleave` (
  `jobleaveID` int NOT NULL AUTO_INCREMENT,
  `positionID` int NOT NULL,
  `leaveID` int NOT NULL,
  `days` decimal(10,0) NOT NULL,
  PRIMARY KEY (`jobleaveID`),
  UNIQUE KEY `jobleaveID_UNIQUE` (`jobleaveID`),
  UNIQUE KEY `Unique Combi` (`positionID`,`leaveID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbljobleave`
--

LOCK TABLES `tbljobleave` WRITE;
/*!40000 ALTER TABLE `tbljobleave` DISABLE KEYS */;
INSERT INTO `tbljobleave` VALUES (1,1,1,15),(2,1,2,15),(3,1,3,15),(4,2,1,10),(5,2,2,12),(6,2,3,1);
/*!40000 ALTER TABLE `tbljobleave` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblleave`
--

DROP TABLE IF EXISTS `tblleave`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblleave` (
  `leaveID` int NOT NULL AUTO_INCREMENT,
  `leaveType` varchar(45) NOT NULL,
  `status` varchar(45) NOT NULL,
  PRIMARY KEY (`leaveID`),
  UNIQUE KEY `idtblleave_UNIQUE` (`leaveID`),
  UNIQUE KEY `leaveType_UNIQUE` (`leaveType`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblleave`
--

LOCK TABLES `tblleave` WRITE;
/*!40000 ALTER TABLE `tblleave` DISABLE KEYS */;
INSERT INTO `tblleave` VALUES (1,'Sick Leave','Active'),(2,'Vacation Leave','Active'),(3,'Maternity Leave','Active');
/*!40000 ALTER TABLE `tblleave` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblovertime`
--

DROP TABLE IF EXISTS `tblovertime`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblovertime` (
  `overtimeID` int NOT NULL AUTO_INCREMENT,
  `employeeID` int NOT NULL,
  `attendanceID` int NOT NULL,
  `remarks` varchar(45) NOT NULL,
  PRIMARY KEY (`overtimeID`),
  UNIQUE KEY `Unique` (`employeeID`,`attendanceID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblovertime`
--

LOCK TABLES `tblovertime` WRITE;
/*!40000 ALTER TABLE `tblovertime` DISABLE KEYS */;
INSERT INTO `tblovertime` VALUES (1,1,2,'Approved'),(2,1,6,'Approved'),(3,1,9,'Declined');
/*!40000 ALTER TABLE `tblovertime` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblpagibig`
--

DROP TABLE IF EXISTS `tblpagibig`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblpagibig` (
  `pagibigID` int NOT NULL AUTO_INCREMENT,
  `rate` int NOT NULL,
  `date` datetime NOT NULL,
  PRIMARY KEY (`pagibigID`),
  UNIQUE KEY `idtblpagibig_UNIQUE` (`pagibigID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblpagibig`
--

LOCK TABLES `tblpagibig` WRITE;
/*!40000 ALTER TABLE `tblpagibig` DISABLE KEYS */;
INSERT INTO `tblpagibig` VALUES (1,200,'2024-11-29 09:43:44');
/*!40000 ALTER TABLE `tblpagibig` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblpayroll`
--

DROP TABLE IF EXISTS `tblpayroll`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblpayroll` (
  `payrollID` int NOT NULL AUTO_INCREMENT,
  `employeeID` int NOT NULL,
  `payrollperiodID` int NOT NULL,
  `overtime` decimal(25,12) NOT NULL,
  `allowance` decimal(25,12) DEFAULT NULL,
  `incentives` decimal(25,12) DEFAULT NULL,
  `nightdifferential` decimal(25,12) DEFAULT NULL,
  `late` decimal(25,12) DEFAULT NULL,
  `undertime` decimal(25,12) DEFAULT NULL,
  `voluntary` decimal(25,12) DEFAULT NULL,
  `sss` decimal(25,12) DEFAULT NULL,
  `philhealth` decimal(25,12) DEFAULT NULL,
  `pagibig` decimal(25,12) DEFAULT NULL,
  `tax` decimal(25,12) DEFAULT NULL,
  `mandatory` decimal(25,12) DEFAULT NULL,
  `totalincrease` decimal(25,12) DEFAULT NULL,
  `totaldeduc` decimal(25,12) DEFAULT NULL,
  `grosspay` decimal(25,12) DEFAULT NULL,
  `netpay` decimal(25,12) DEFAULT NULL,
  PRIMARY KEY (`payrollID`),
  UNIQUE KEY `Unique` (`employeeID`,`payrollperiodID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblpayroll`
--

LOCK TABLES `tblpayroll` WRITE;
/*!40000 ALTER TABLE `tblpayroll` DISABLE KEYS */;
INSERT INTO `tblpayroll` VALUES (1,2,1,0.000000000000,180100.000000000000,0.000000000000,0.000000000000,5.375000000000,0.000000000000,0.000000000000,270.000000000000,277.350000000000,200.000000000000,0.000000000000,747.350000000000,180100.000000000000,752.725000000000,5547.000000000000,184894.275000000000);
/*!40000 ALTER TABLE `tblpayroll` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblpayrollperiod`
--

DROP TABLE IF EXISTS `tblpayrollperiod`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblpayrollperiod` (
  `payrollperiodID` int NOT NULL AUTO_INCREMENT,
  `payrollperiodname` varchar(45) NOT NULL,
  `datefrom` date NOT NULL,
  `dateto` date NOT NULL,
  `payout` varchar(45) NOT NULL,
  `released` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`payrollperiodID`),
  UNIQUE KEY `payrollperiodname_UNIQUE` (`payrollperiodname`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblpayrollperiod`
--

LOCK TABLES `tblpayrollperiod` WRITE;
/*!40000 ALTER TABLE `tblpayrollperiod` DISABLE KEYS */;
INSERT INTO `tblpayrollperiod` VALUES (1,'Nov 1-15','2024-11-01','2024-11-15','Yes','Released'),(2,'Friday Roll','2024-12-15','2024-12-31','Yes','Not Released');
/*!40000 ALTER TABLE `tblpayrollperiod` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblphilhealth`
--

DROP TABLE IF EXISTS `tblphilhealth`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblphilhealth` (
  `philhealthID` int NOT NULL AUTO_INCREMENT,
  `rate` int NOT NULL,
  `date` datetime NOT NULL,
  PRIMARY KEY (`philhealthID`),
  UNIQUE KEY `philhealthID_UNIQUE` (`philhealthID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblphilhealth`
--

LOCK TABLES `tblphilhealth` WRITE;
/*!40000 ALTER TABLE `tblphilhealth` DISABLE KEYS */;
INSERT INTO `tblphilhealth` VALUES (1,5,'2024-11-29 09:43:54');
/*!40000 ALTER TABLE `tblphilhealth` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblposition`
--

DROP TABLE IF EXISTS `tblposition`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblposition` (
  `positionID` int NOT NULL AUTO_INCREMENT,
  `positionName` varchar(45) NOT NULL,
  `status` varchar(45) NOT NULL,
  `departmentID` int NOT NULL,
  PRIMARY KEY (`positionID`),
  UNIQUE KEY `positionID_UNIQUE` (`positionID`),
  UNIQUE KEY `position` (`positionName`,`departmentID`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblposition`
--

LOCK TABLES `tblposition` WRITE;
/*!40000 ALTER TABLE `tblposition` DISABLE KEYS */;
INSERT INTO `tblposition` VALUES (1,'Department Head','Active',1),(2,'Department Head','Active',2),(3,'Department Head','Active',3),(4,'It Head','Active',1),(5,'It Staff','Active',1),(6,'Accounting Head','Active',2),(7,'Accounting Staff','Active',2),(8,'Payroll Head','Active',3),(9,'Payroll Staff','Active',3),(11,'Department Head','Active',4),(12,'Libraian','Active',4);
/*!40000 ALTER TABLE `tblposition` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblrates`
--

DROP TABLE IF EXISTS `tblrates`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblrates` (
  `ratesID` int NOT NULL AUTO_INCREMENT,
  `rateClassification` varchar(45) NOT NULL,
  `rate` int NOT NULL,
  PRIMARY KEY (`ratesID`),
  UNIQUE KEY `ratesID_UNIQUE` (`ratesID`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblrates`
--

LOCK TABLES `tblrates` WRITE;
/*!40000 ALTER TABLE `tblrates` DISABLE KEYS */;
INSERT INTO `tblrates` VALUES (1,'Night Differential Rate',110),(2,'Overtime - Regular Rate',125),(3,'Overtime - Special Rate',130),(4,'Rest Day Rate',130),(5,'Special Holiday Rate',130),(6,'Regular Holiday Rate',200),(7,'Double Holiday Rate',260);
/*!40000 ALTER TABLE `tblrates` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblsalary`
--

DROP TABLE IF EXISTS `tblsalary`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblsalary` (
  `salaryID` int NOT NULL AUTO_INCREMENT,
  `employeeID` int NOT NULL,
  `salary` decimal(10,0) NOT NULL,
  `type` varchar(45) NOT NULL,
  `daily` decimal(20,7) DEFAULT NULL,
  PRIMARY KEY (`salaryID`),
  UNIQUE KEY `employeeID_UNIQUE` (`employeeID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblsalary`
--

LOCK TABLES `tblsalary` WRITE;
/*!40000 ALTER TABLE `tblsalary` DISABLE KEYS */;
INSERT INTO `tblsalary` VALUES (1,1,35000,'Monthly',1609.1954023),(2,2,750,'Daily',750.0000000),(3,3,20000,'Monthly',766.7731629),(4,4,30000,'Monthly',1722.4880383),(5,5,50000,'Monthly',NULL),(6,6,30000,'Monthly',NULL);
/*!40000 ALTER TABLE `tblsalary` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblsalaryhistory`
--

DROP TABLE IF EXISTS `tblsalaryhistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblsalaryhistory` (
  `salaryhistoryID` int NOT NULL AUTO_INCREMENT,
  `employeeID` int NOT NULL,
  `salary` varchar(450) NOT NULL,
  `date` datetime DEFAULT NULL,
  PRIMARY KEY (`salaryhistoryID`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblsalaryhistory`
--

LOCK TABLES `tblsalaryhistory` WRITE;
/*!40000 ALTER TABLE `tblsalaryhistory` DISABLE KEYS */;
INSERT INTO `tblsalaryhistory` VALUES (24,1,'35000','2025-03-16 19:07:37'),(25,6,'30000','2025-03-16 19:09:16');
/*!40000 ALTER TABLE `tblsalaryhistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblschedule`
--

DROP TABLE IF EXISTS `tblschedule`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblschedule` (
  `scheduleID` int NOT NULL AUTO_INCREMENT,
  `employeeID` int NOT NULL,
  `day` varchar(45) NOT NULL,
  `remark` varchar(45) NOT NULL,
  PRIMARY KEY (`scheduleID`),
  UNIQUE KEY `Unique` (`employeeID`,`day`)
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblschedule`
--

LOCK TABLES `tblschedule` WRITE;
/*!40000 ALTER TABLE `tblschedule` DISABLE KEYS */;
INSERT INTO `tblschedule` VALUES (1,1,'Monday','With Duty'),(2,1,'Tuesday','With Duty'),(3,1,'Wednesday','With Duty'),(4,1,'Thursday','With Duty'),(5,1,'Friday','With Duty'),(6,1,'Saturday','Day Off'),(7,1,'Sunday','Day Off'),(15,2,'Monday','Day Off'),(16,2,'Tuesday','With Duty'),(17,2,'Wednesday','Day Off'),(18,2,'Thursday','With Duty'),(19,2,'Friday','With Duty'),(20,2,'Saturday','With Duty'),(21,2,'Sunday','With Duty'),(22,3,'Monday','With Duty'),(23,3,'Tuesday','With Duty'),(24,3,'Wednesday','With Duty'),(25,3,'Thursday','With Duty'),(26,3,'Friday','With Duty'),(27,3,'Saturday','With Duty'),(28,3,'Sunday','Day Off'),(29,4,'Monday','With Duty'),(30,4,'Tuesday','With Duty'),(31,4,'Wednesday','With Duty'),(32,4,'Thursday','With Duty'),(33,4,'Friday','Day Off'),(34,4,'Saturday','Day Off'),(35,4,'Sunday','Day Off');
/*!40000 ALTER TABLE `tblschedule` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblsss`
--

DROP TABLE IF EXISTS `tblsss`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblsss` (
  `sssID` int NOT NULL AUTO_INCREMENT,
  `minSalary` decimal(10,2) NOT NULL,
  `maxSalary` decimal(10,2) NOT NULL,
  `EE` decimal(10,2) NOT NULL,
  `WISP` decimal(10,2) NOT NULL,
  `total` decimal(10,2) NOT NULL,
  PRIMARY KEY (`sssID`),
  UNIQUE KEY `sssID_UNIQUE` (`sssID`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblsss`
--

LOCK TABLES `tblsss` WRITE;
/*!40000 ALTER TABLE `tblsss` DISABLE KEYS */;
INSERT INTO `tblsss` VALUES (1,0.00,4250.00,180.00,0.00,180.00),(2,4250.01,5000.00,225.00,0.00,225.00),(3,5000.01,6000.00,270.00,0.00,270.00),(5,6000.01,7000.00,315.00,0.00,315.00),(6,7000.01,8000.00,360.00,0.00,360.00),(7,8000.01,9000.00,405.00,0.00,405.00),(8,9000.01,10000.00,450.00,0.00,450.00),(9,10000.01,11000.00,495.00,0.00,495.00),(10,11000.01,12000.00,540.00,0.00,540.00),(11,12000.01,13000.00,585.00,0.00,585.00),(12,13000.01,14000.00,630.00,0.00,630.00),(13,14000.01,15000.00,675.00,0.00,675.00);
/*!40000 ALTER TABLE `tblsss` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbltaxdaily`
--

DROP TABLE IF EXISTS `tbltaxdaily`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbltaxdaily` (
  `taxDailyID` int NOT NULL AUTO_INCREMENT,
  `minSalary` decimal(10,2) NOT NULL,
  `maxSalary` decimal(10,2) NOT NULL,
  `fixedAmount` decimal(10,2) NOT NULL,
  `percentage` int NOT NULL,
  PRIMARY KEY (`taxDailyID`),
  UNIQUE KEY `taxID_UNIQUE` (`taxDailyID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbltaxdaily`
--

LOCK TABLES `tbltaxdaily` WRITE;
/*!40000 ALTER TABLE `tbltaxdaily` DISABLE KEYS */;
INSERT INTO `tbltaxdaily` VALUES (1,0.00,10417.00,0.00,0),(2,10417.01,16666.00,0.00,15),(3,16666.01,33332.00,1250.00,20),(4,33332.01,83332.00,5416.67,25),(5,83332.01,333332.00,20416.67,30),(6,333332.01,99999999.00,100416.67,35);
/*!40000 ALTER TABLE `tbltaxdaily` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbltaxmonthly`
--

DROP TABLE IF EXISTS `tbltaxmonthly`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbltaxmonthly` (
  `taxMonthlyID` int NOT NULL AUTO_INCREMENT,
  `minSalary` decimal(10,2) NOT NULL,
  `maxSalary` decimal(10,2) NOT NULL,
  `fixedAmount` decimal(10,2) NOT NULL,
  `percentage` int NOT NULL,
  PRIMARY KEY (`taxMonthlyID`),
  UNIQUE KEY `taxID_UNIQUE` (`taxMonthlyID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbltaxmonthly`
--

LOCK TABLES `tbltaxmonthly` WRITE;
/*!40000 ALTER TABLE `tbltaxmonthly` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbltaxmonthly` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbltimeschedule`
--

DROP TABLE IF EXISTS `tbltimeschedule`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbltimeschedule` (
  `timescheduleID` int NOT NULL AUTO_INCREMENT,
  `employeeID` int NOT NULL,
  `timein` time DEFAULT NULL,
  `timeout` time DEFAULT NULL,
  `breakin` time DEFAULT NULL,
  `breakout` time DEFAULT NULL,
  `noofhours` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`timescheduleID`),
  UNIQUE KEY `employeeID_UNIQUE` (`employeeID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbltimeschedule`
--

LOCK TABLES `tbltimeschedule` WRITE;
/*!40000 ALTER TABLE `tbltimeschedule` DISABLE KEYS */;
INSERT INTO `tbltimeschedule` VALUES (1,1,'08:00:00','17:00:00','12:00:00','13:00:00',8.00),(3,2,'08:00:00','17:00:00','12:00:00','13:00:00',8.00),(4,3,'08:00:00','17:00:00','12:00:00','13:00:00',8.00),(5,4,'08:00:00','17:00:00','12:00:00','13:00:00',8.00);
/*!40000 ALTER TABLE `tbltimeschedule` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblusers`
--

DROP TABLE IF EXISTS `tblusers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblusers` (
  `userID` int NOT NULL AUTO_INCREMENT,
  `firstName` varchar(45) NOT NULL,
  `lastName` varchar(45) NOT NULL,
  `role` varchar(45) NOT NULL,
  `username` varchar(45) NOT NULL,
  `password` varchar(45) DEFAULT NULL,
  `status` varchar(45) NOT NULL,
  `logged` varchar(45) DEFAULT 'No',
  PRIMARY KEY (`userID`),
  UNIQUE KEY `userID_UNIQUE` (`userID`),
  UNIQUE KEY `username_UNIQUE` (`username`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblusers`
--

LOCK TABLES `tblusers` WRITE;
/*!40000 ALTER TABLE `tblusers` DISABLE KEYS */;
INSERT INTO `tblusers` VALUES (1,'De Guzman','Albert','Admin','aru','123','Active','Yes'),(2,'Attendance','Attendance','Attendance','attendance','passwordattendance','Active','no'),(3,'Clifford','Villena','Payroll Staff','clifford',NULL,'Active','no'),(5,'Renz','Garcia','Payroll Staff','ryan123',NULL,'Active','no'),(6,'Ryan','Lumayag','Payroll Staff','ryan',NULL,'Active','no'),(7,'Albert','De Guzman','Payroll Staff','arushi',NULL,'Active','no');
/*!40000 ALTER TABLE `tblusers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblvoluntary`
--

DROP TABLE IF EXISTS `tblvoluntary`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblvoluntary` (
  `voluntaryID` int NOT NULL AUTO_INCREMENT,
  `name` varchar(45) NOT NULL,
  `status` varchar(45) NOT NULL,
  PRIMARY KEY (`voluntaryID`),
  UNIQUE KEY `idtblvoluntary_UNIQUE` (`voluntaryID`),
  UNIQUE KEY `name_UNIQUE` (`name`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblvoluntary`
--

LOCK TABLES `tblvoluntary` WRITE;
/*!40000 ALTER TABLE `tblvoluntary` DISABLE KEYS */;
INSERT INTO `tblvoluntary` VALUES (1,'Addtional Sss','Active'),(2,'Insurance','Active'),(3,'Hmo','Active'),(4,'Loan','Active');
/*!40000 ALTER TABLE `tblvoluntary` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-03-22 17:00:57
