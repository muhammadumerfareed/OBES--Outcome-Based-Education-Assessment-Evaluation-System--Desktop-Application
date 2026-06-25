-- MySQL dump 10.13  Distrib 8.0.33, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: projectbdb26
-- ------------------------------------------------------
-- Server version	8.0.33

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
-- Table structure for table `assessment`
--

DROP TABLE IF EXISTS `assessment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `assessment` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Title` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `DateCreated` datetime(3) NOT NULL,
  `TotalMarks` int NOT NULL,
  `TotalWeightage` int NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `assessment`
--

LOCK TABLES `assessment` WRITE;
/*!40000 ALTER TABLE `assessment` DISABLE KEYS */;
/*!40000 ALTER TABLE `assessment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `assessmentcomponent`
--

DROP TABLE IF EXISTS `assessmentcomponent`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `assessmentcomponent` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `RubricId` int NOT NULL,
  `TotalMarks` int NOT NULL,
  `DateCreated` datetime(3) NOT NULL,
  `DateUpdated` datetime(3) NOT NULL,
  `AssessmentId` int NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `FK_AssessmentComponent_Assessment` (`AssessmentId`),
  KEY `FK_AssessmentComponent_Rubric` (`RubricId`),
  CONSTRAINT `FK_AssessmentComponent_Assessment` FOREIGN KEY (`AssessmentId`) REFERENCES `assessment` (`Id`),
  CONSTRAINT `FK_AssessmentComponent_Rubric` FOREIGN KEY (`RubricId`) REFERENCES `rubric` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `assessmentcomponent`
--

LOCK TABLES `assessmentcomponent` WRITE;
/*!40000 ALTER TABLE `assessmentcomponent` DISABLE KEYS */;
/*!40000 ALTER TABLE `assessmentcomponent` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `classattendance`
--

DROP TABLE IF EXISTS `classattendance`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `classattendance` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `AttendanceDate` datetime(3) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `classattendance`
--

LOCK TABLES `classattendance` WRITE;
/*!40000 ALTER TABLE `classattendance` DISABLE KEYS */;
/*!40000 ALTER TABLE `classattendance` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clo`
--

DROP TABLE IF EXISTS `clo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clo` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `DateCreated` datetime(3) NOT NULL,
  `DateUpdated` datetime(3) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clo`
--

LOCK TABLES `clo` WRITE;
/*!40000 ALTER TABLE `clo` DISABLE KEYS */;
/*!40000 ALTER TABLE `clo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lookup`
--

DROP TABLE IF EXISTS `lookup`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `lookup` (
  `LookupId` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `Category` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  PRIMARY KEY (`LookupId`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lookup`
--

LOCK TABLES `lookup` WRITE;
/*!40000 ALTER TABLE `lookup` DISABLE KEYS */;
INSERT INTO `lookup` VALUES (1,'Present','ATTENDANCE_STATUS'),(2,'Absent','ATTENDANCE_STATUS'),(3,'Leave','ATTENDANCE_STATUS'),(4,'Late','ATTENDANCE_STATUS'),(5,'Active','STUDENT_STATUS'),(6,'InActive','STUDENT_STATUS');
/*!40000 ALTER TABLE `lookup` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rubric`
--

DROP TABLE IF EXISTS `rubric`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `rubric` (
  `Id` int NOT NULL,
  `Details` longtext NOT NULL,
  `CloId` int NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `FK_Rubric_Clo` (`CloId`),
  CONSTRAINT `FK_Rubric_Clo` FOREIGN KEY (`CloId`) REFERENCES `clo` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rubric`
--

LOCK TABLES `rubric` WRITE;
/*!40000 ALTER TABLE `rubric` DISABLE KEYS */;
/*!40000 ALTER TABLE `rubric` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rubriclevel`
--

DROP TABLE IF EXISTS `rubriclevel`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `rubriclevel` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `RubricId` int NOT NULL,
  `Details` longtext NOT NULL,
  `MeasurementLevel` int NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `FK_RubricLevel_Rubric` (`RubricId`),
  CONSTRAINT `FK_RubricLevel_Rubric` FOREIGN KEY (`RubricId`) REFERENCES `rubric` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rubriclevel`
--

LOCK TABLES `rubriclevel` WRITE;
/*!40000 ALTER TABLE `rubriclevel` DISABLE KEYS */;
/*!40000 ALTER TABLE `rubriclevel` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `student`
--

DROP TABLE IF EXISTS `student`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `student` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `FirstName` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `LastName` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `Contact` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `Email` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `RegistrationNumber` varchar(20) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `Status` int NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `FK_Student_Lookup` (`Status`),
  CONSTRAINT `FK_Student_Lookup` FOREIGN KEY (`Status`) REFERENCES `lookup` (`LookupId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `student`
--

LOCK TABLES `student` WRITE;
/*!40000 ALTER TABLE `student` DISABLE KEYS */;
/*!40000 ALTER TABLE `student` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `studentattendance`
--

DROP TABLE IF EXISTS `studentattendance`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `studentattendance` (
  `AttendanceId` int NOT NULL,
  `StudentId` int NOT NULL,
  `AttendanceStatus` int NOT NULL,
  PRIMARY KEY (`AttendanceId`,`StudentId`),
  KEY `FK_StudentAttendance_Lookup` (`AttendanceStatus`),
  KEY `FK_StudentAttendance_Student` (`StudentId`),
  CONSTRAINT `FK_StudentAttendance_ClassAttendance` FOREIGN KEY (`AttendanceId`) REFERENCES `classattendance` (`Id`),
  CONSTRAINT `FK_StudentAttendance_Lookup` FOREIGN KEY (`AttendanceStatus`) REFERENCES `lookup` (`LookupId`),
  CONSTRAINT `FK_StudentAttendance_Student` FOREIGN KEY (`StudentId`) REFERENCES `student` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `studentattendance`
--

LOCK TABLES `studentattendance` WRITE;
/*!40000 ALTER TABLE `studentattendance` DISABLE KEYS */;
/*!40000 ALTER TABLE `studentattendance` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `studentresult`
--

DROP TABLE IF EXISTS `studentresult`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `studentresult` (
  `StudentId` int NOT NULL,
  `AssessmentComponentId` int NOT NULL,
  `RubricMeasurementId` int NOT NULL,
  `EvaluationDate` datetime(3) NOT NULL,
  PRIMARY KEY (`StudentId`,`AssessmentComponentId`),
  KEY `FK_StudentResult_AssessmentComponent` (`AssessmentComponentId`),
  KEY `FK_StudentResult_RubricLevel` (`RubricMeasurementId`),
  CONSTRAINT `FK_StudentResult_AssessmentComponent` FOREIGN KEY (`AssessmentComponentId`) REFERENCES `assessmentcomponent` (`Id`),
  CONSTRAINT `FK_StudentResult_RubricLevel` FOREIGN KEY (`RubricMeasurementId`) REFERENCES `rubriclevel` (`Id`),
  CONSTRAINT `FK_StudentResult_Student` FOREIGN KEY (`StudentId`) REFERENCES `student` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `studentresult`
--

LOCK TABLES `studentresult` WRITE;
/*!40000 ALTER TABLE `studentresult` DISABLE KEYS */;
/*!40000 ALTER TABLE `studentresult` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-03-10  0:23:40
