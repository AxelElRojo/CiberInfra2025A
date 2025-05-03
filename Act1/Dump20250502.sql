-- MySQL dump 10.13  Distrib 8.0.41, for Win64 (x86_64)
--
-- Host: localhost    Database: ciberinfraestructura
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
-- Table structure for table `catempleados`
--

DROP TABLE IF EXISTS `catempleados`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `catempleados` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(80) NOT NULL,
  `Cargo` varchar(80) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `catempleados`
--

LOCK TABLES `catempleados` WRITE;
/*!40000 ALTER TABLE `catempleados` DISABLE KEYS */;
/*!40000 ALTER TABLE `catempleados` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `catproducto`
--

DROP TABLE IF EXISTS `catproducto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `catproducto` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(40) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `catproducto`
--

LOCK TABLES `catproducto` WRITE;
/*!40000 ALTER TABLE `catproducto` DISABLE KEYS */;
/*!40000 ALTER TABLE `catproducto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblinventario`
--

DROP TABLE IF EXISTS `tblinventario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblinventario` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `FechaAlta` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `IDProducto` int DEFAULT NULL,
  `Cantidad` int NOT NULL DEFAULT '1',
  PRIMARY KEY (`ID`),
  KEY `IDProducto` (`IDProducto`),
  CONSTRAINT `tblinventario_ibfk_1` FOREIGN KEY (`IDProducto`) REFERENCES `catproducto` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblinventario`
--

LOCK TABLES `tblinventario` WRITE;
/*!40000 ALTER TABLE `tblinventario` DISABLE KEYS */;
/*!40000 ALTER TABLE `tblinventario` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-05-02 17:50:52
