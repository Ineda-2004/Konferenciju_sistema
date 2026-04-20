-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: May 09, 2025 at 12:17 AM
-- Server version: 9.1.0
-- PHP Version: 8.3.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `konferenciju_sistema`
--

-- --------------------------------------------------------

--
-- Table structure for table `dalyvioistorija`
--

DROP TABLE IF EXISTS `dalyvioistorija`;
CREATE TABLE IF NOT EXISTS `dalyvioistorija` (
  `DalyvioIstorijosID` int NOT NULL AUTO_INCREMENT,
  `NaudotojoID` int DEFAULT NULL,
  `KonferencijosID` int DEFAULT NULL,
  `PazymejimoID` int DEFAULT NULL,
  PRIMARY KEY (`DalyvioIstorijosID`),
  KEY `NaudotojoID` (`NaudotojoID`),
  KEY `KonferencijosID` (`KonferencijosID`),
  KEY `PazymejimoID` (`PazymejimoID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `dalyvioistorija`
--

INSERT INTO `dalyvioistorija` (`DalyvioIstorijosID`, `NaudotojoID`, `KonferencijosID`, `PazymejimoID`) VALUES
(1, 7, 8, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `konferencijos`
--

DROP TABLE IF EXISTS `konferencijos`;
CREATE TABLE IF NOT EXISTS `konferencijos` (
  `KonferencijosID` int NOT NULL AUTO_INCREMENT,
  `Pavadinimas` varchar(150) COLLATE utf8mb4_general_ci NOT NULL,
  `Data` date DEFAULT NULL,
  `Aprasymas` text COLLATE utf8mb4_general_ci,
  `MiestasID` int DEFAULT NULL,
  `TemaID` int DEFAULT NULL,
  `Busena` varchar(50) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `NaudotojoID` int DEFAULT NULL,
  PRIMARY KEY (`KonferencijosID`),
  KEY `MiestasID` (`MiestasID`),
  KEY `TemaID` (`TemaID`),
  KEY `NaudotojoID` (`NaudotojoID`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `konferencijos`
--

INSERT INTO `konferencijos` (`KonferencijosID`, `Pavadinimas`, `Data`, `Aprasymas`, `MiestasID`, `TemaID`, `Busena`, `NaudotojoID`) VALUES
(1, 'AI Lietuva 2025', '2025-06-10', 'DI mokslo konferencija', 1, 1, 'Planuojama', 2),
(2, 'Zalias rytojus', '2025-07-12', 'Klimato issukiai ir veiksmai', 2, 2, 'Patvirtinta', NULL),
(3, 'Biotech Forumas', '2025-08-20', 'Biotechnologijos Lietuvoje', 3, 3, 'Vyksta', NULL),
(4, 'DI moksle', '2025-05-16', 'Dirbtinis inteklektas moksle', 1, 1, 'Vyksta', NULL),
(6, '5', '2025-05-24', '45', 1, 2, 'Atšaukta', NULL),
(8, '1', '2025-05-09', '1', 1, 1, 'Patvirtinta', 2);

-- --------------------------------------------------------

--
-- Table structure for table `miestai`
--

DROP TABLE IF EXISTS `miestai`;
CREATE TABLE IF NOT EXISTS `miestai` (
  `MiestasID` int NOT NULL AUTO_INCREMENT,
  `Pavadinimas` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`MiestasID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `miestai`
--

INSERT INTO `miestai` (`MiestasID`, `Pavadinimas`) VALUES
(1, 'Vilnius'),
(2, 'Siauliai'),
(3, 'Utena');

-- --------------------------------------------------------

--
-- Table structure for table `naudotojai`
--

DROP TABLE IF EXISTS `naudotojai`;
CREATE TABLE IF NOT EXISTS `naudotojai` (
  `NaudotojoID` int NOT NULL AUTO_INCREMENT,
  `Vardas` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  `ElPastas` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  `VaidmuoID` int DEFAULT NULL,
  `Slaptazodis` varchar(255) COLLATE utf8mb4_general_ci NOT NULL DEFAULT '',
  `Vaidmuo` enum('dalyvis','organizatorius') COLLATE utf8mb4_general_ci NOT NULL DEFAULT 'dalyvis',
  PRIMARY KEY (`NaudotojoID`),
  UNIQUE KEY `ElPastas` (`ElPastas`),
  KEY `VaidmuoID` (`VaidmuoID`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `naudotojai`
--

INSERT INTO `naudotojai` (`NaudotojoID`, `Vardas`, `ElPastas`, `VaidmuoID`, `Slaptazodis`, `Vaidmuo`) VALUES
(1, 'Adminas Aidas', 'aidas.adminas@konf.lt', 3, '1', 'dalyvis'),
(2, 'Organizatore Olga', 'olga@konf.lt', 2, '1', 'organizatorius'),
(3, 'Organizatorius Lukas', 'lukas@konf.lt', 2, '24', 'organizatorius'),
(4, 'Organizatore Egle', 'egle@konf.lt', 2, '54', 'organizatorius'),
(5, 'Organizatorius Tomas', 'tomas@konf.lt', 2, '57', 'organizatorius'),
(6, 'Organizatore Lina', 'lina@konf.lt', 2, '789', 'organizatorius'),
(7, 'Dalyvis Jonas', 'jonas@konf.lt', 1, '1234', 'dalyvis'),
(8, 'Dalyve Milda', 'milda@konf.lt', 1, '/952', 'dalyvis'),
(9, 'Dalyvis Paulius', 'paulius@konf.lt', 1, '\\751', 'dalyvis'),
(10, 'Dalyve Ieva', 'ieva@konf.lt', 1, '', 'dalyvis'),
(11, 'Dalyvis Andrius', 'andrius@konf.lt', 1, '786', 'dalyvis'),
(12, 'Dalyve Agne', 'agne@konf.lt', 1, '', 'dalyvis'),
(13, 'Dalyvis Dainius', 'dainius@konf.lt', 1, '78655', 'dalyvis'),
(14, 'Dalyve Karina', 'karina@konf.lt', 1, '578', 'dalyvis'),
(15, 'Dalyvis Edvinas', 'edvinas@konf.lt', 1, '', 'dalyvis'),
(16, 'Dalyve Ruta', 'ruta@konf.lt', 1, '', 'dalyvis');

-- --------------------------------------------------------

--
-- Table structure for table `pazymejimai`
--

DROP TABLE IF EXISTS `pazymejimai`;
CREATE TABLE IF NOT EXISTS `pazymejimai` (
  `PazymejimoID` int NOT NULL AUTO_INCREMENT,
  `NaudotojoID` int DEFAULT NULL,
  `KonferencijosID` int DEFAULT NULL,
  PRIMARY KEY (`PazymejimoID`),
  KEY `KonferencijosID` (`KonferencijosID`),
  KEY `NaudotojoID` (`NaudotojoID`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `pazymejimai`
--

INSERT INTO `pazymejimai` (`PazymejimoID`, `NaudotojoID`, `KonferencijosID`) VALUES
(1, 7, 1),
(2, 8, 1),
(3, 10, 2),
(4, 12, 3),
(5, 13, 2),
(6, 14, 1),
(7, 15, 2),
(8, 16, 3);

-- --------------------------------------------------------

--
-- Table structure for table `programos`
--

DROP TABLE IF EXISTS `programos`;
CREATE TABLE IF NOT EXISTS `programos` (
  `ProgramosID` int NOT NULL AUTO_INCREMENT,
  `KonferencijosID` int DEFAULT NULL,
  `TemosID` int DEFAULT NULL,
  `Laikas` time DEFAULT NULL,
  `Pranesejas` varchar(100) COLLATE utf8mb4_general_ci DEFAULT NULL,
  PRIMARY KEY (`ProgramosID`),
  KEY `TemosID` (`TemosID`),
  KEY `KonferencijosID` (`KonferencijosID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `programos`
--

INSERT INTO `programos` (`ProgramosID`, `KonferencijosID`, `TemosID`, `Laikas`, `Pranesejas`) VALUES
(1, 1, 1, '10:00:00', 'Organizatore Olga'),
(2, 2, 2, '11:30:00', 'Organizatorius Lukas'),
(3, 3, 3, '09:00:00', 'Organizatore Egle');

-- --------------------------------------------------------

--
-- Table structure for table `registracija`
--

DROP TABLE IF EXISTS `registracija`;
CREATE TABLE IF NOT EXISTS `registracija` (
  `RegistracijosID` int NOT NULL AUTO_INCREMENT,
  `KonferencijosID` int DEFAULT NULL,
  `NaudotojoID` int DEFAULT NULL,
  `Statusas` varchar(50) COLLATE utf8mb4_general_ci DEFAULT NULL,
  PRIMARY KEY (`RegistracijosID`),
  KEY `KonferencijosID` (`KonferencijosID`),
  KEY `NaudotojoID` (`NaudotojoID`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `registracija`
--

INSERT INTO `registracija` (`RegistracijosID`, `KonferencijosID`, `NaudotojoID`, `Statusas`) VALUES
(1, 1, 7, 'Patvirtinta'),
(2, 1, 8, 'Patvirtinta'),
(3, 2, 9, 'Laukia'),
(4, 2, 10, 'Patvirtinta'),
(5, 3, 11, 'Patvirtinta'),
(6, 3, 12, 'Patvirtinta'),
(7, 2, 13, 'Patvirtinta'),
(8, 1, 14, 'Patvirtinta'),
(9, 2, 15, 'Patvirtinta'),
(10, 3, 16, 'Patvirtinta');

-- --------------------------------------------------------

--
-- Table structure for table `registracijoszinute`
--

DROP TABLE IF EXISTS `registracijoszinute`;
CREATE TABLE IF NOT EXISTS `registracijoszinute` (
  `ZinutesID` int NOT NULL AUTO_INCREMENT,
  `RegistracijosID` int DEFAULT NULL,
  `Turinys` text COLLATE utf8mb4_general_ci,
  `SukurimoData` datetime DEFAULT NULL,
  `Siuntejas` varchar(100) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `Tipas` varchar(50) COLLATE utf8mb4_general_ci DEFAULT NULL,
  PRIMARY KEY (`ZinutesID`),
  KEY `RegistracijosID` (`RegistracijosID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `registracijoszinute`
--

INSERT INTO `registracijoszinute` (`ZinutesID`, `RegistracijosID`, `Turinys`, `SukurimoData`, `Siuntejas`, `Tipas`) VALUES
(1, 1, 'Registracija patvirtinta. Laukiame jusu.', '2025-05-01 09:00:00', 'Organizatoriai', 'Patvirtinimas'),
(2, 3, 'Primename apie registracija.', '2025-05-03 10:30:00', 'Organizatoriai', 'Priminimas'),
(3, 6, 'Jusu registracija sekmingai patvirtinta.', '2025-05-05 09:00:00', 'Organizatoriai', 'Patvirtinimas'),
(4, 7, 'Sveikiname prisijungus prie konferencijos.', '2025-05-06 10:00:00', 'Organizatoriai', 'Sveikinimas');

-- --------------------------------------------------------

--
-- Table structure for table `temos`
--

DROP TABLE IF EXISTS `temos`;
CREATE TABLE IF NOT EXISTS `temos` (
  `TemosID` int NOT NULL AUTO_INCREMENT,
  `Pavadinimas` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  `Aprasymas` text COLLATE utf8mb4_general_ci,
  PRIMARY KEY (`TemosID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `temos`
--

INSERT INTO `temos` (`TemosID`, `Pavadinimas`, `Aprasymas`) VALUES
(1, 'Dirbtinis intelektas', 'DI technologijos ir taikymai'),
(2, 'Aplinkosauga', 'Klimato pokyciai ir gamta'),
(3, 'Biotechnologijos', 'Nauji medicinos sprendimai');

-- --------------------------------------------------------

--
-- Table structure for table `vaidmenys`
--

DROP TABLE IF EXISTS `vaidmenys`;
CREATE TABLE IF NOT EXISTS `vaidmenys` (
  `VaidmuoID` int NOT NULL AUTO_INCREMENT,
  `Pavadinimas` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`VaidmuoID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `vaidmenys`
--

INSERT INTO `vaidmenys` (`VaidmuoID`, `Pavadinimas`) VALUES
(1, 'Dalyvis'),
(2, 'Organizatorius'),
(3, 'Adminas');

-- --------------------------------------------------------

--
-- Table structure for table `vietos`
--

DROP TABLE IF EXISTS `vietos`;
CREATE TABLE IF NOT EXISTS `vietos` (
  `VietosID` int NOT NULL AUTO_INCREMENT,
  `KonferencijosID` int DEFAULT NULL,
  `Adresas` varchar(200) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `PastatoPavadinimas` varchar(100) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `YraNuotolinis` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`VietosID`),
  KEY `KonferencijosID` (`KonferencijosID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `vietos`
--

INSERT INTO `vietos` (`VietosID`, `KonferencijosID`, `Adresas`, `PastatoPavadinimas`, `YraNuotolinis`) VALUES
(1, 1, 'Gedimino pr. 9', 'VU Aula', 0),
(2, 2, 'Ausros al. 2', 'Siauliu arena', 1),
(3, 3, 'Mokslo g. 5', 'Utenos kolegija', 0),
(4, 6, '54', '556', 1),
(6, 8, '1', '1', 0);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `dalyvioistorija`
--
ALTER TABLE `dalyvioistorija`
  ADD CONSTRAINT `dalyvioistorija_ibfk_1` FOREIGN KEY (`NaudotojoID`) REFERENCES `naudotojai` (`NaudotojoID`),
  ADD CONSTRAINT `dalyvioistorija_ibfk_2` FOREIGN KEY (`KonferencijosID`) REFERENCES `konferencijos` (`KonferencijosID`),
  ADD CONSTRAINT `dalyvioistorija_ibfk_3` FOREIGN KEY (`PazymejimoID`) REFERENCES `pazymejimai` (`PazymejimoID`);

--
-- Constraints for table `konferencijos`
--
ALTER TABLE `konferencijos`
  ADD CONSTRAINT `konferencijos_ibfk_1` FOREIGN KEY (`MiestasID`) REFERENCES `miestai` (`MiestasID`),
  ADD CONSTRAINT `konferencijos_ibfk_2` FOREIGN KEY (`TemaID`) REFERENCES `temos` (`TemosID`),
  ADD CONSTRAINT `konferencijos_ibfk_3` FOREIGN KEY (`NaudotojoID`) REFERENCES `naudotojai` (`NaudotojoID`);

--
-- Constraints for table `naudotojai`
--
ALTER TABLE `naudotojai`
  ADD CONSTRAINT `naudotojai_ibfk_1` FOREIGN KEY (`VaidmuoID`) REFERENCES `vaidmenys` (`VaidmuoID`);

--
-- Constraints for table `pazymejimai`
--
ALTER TABLE `pazymejimai`
  ADD CONSTRAINT `pazymejimai_ibfk_1` FOREIGN KEY (`KonferencijosID`) REFERENCES `konferencijos` (`KonferencijosID`),
  ADD CONSTRAINT `pazymejimai_ibfk_2` FOREIGN KEY (`NaudotojoID`) REFERENCES `naudotojai` (`NaudotojoID`);

--
-- Constraints for table `programos`
--
ALTER TABLE `programos`
  ADD CONSTRAINT `programos_ibfk_1` FOREIGN KEY (`TemosID`) REFERENCES `temos` (`TemosID`),
  ADD CONSTRAINT `programos_ibfk_2` FOREIGN KEY (`KonferencijosID`) REFERENCES `konferencijos` (`KonferencijosID`);

--
-- Constraints for table `registracija`
--
ALTER TABLE `registracija`
  ADD CONSTRAINT `registracija_ibfk_1` FOREIGN KEY (`KonferencijosID`) REFERENCES `konferencijos` (`KonferencijosID`),
  ADD CONSTRAINT `registracija_ibfk_2` FOREIGN KEY (`NaudotojoID`) REFERENCES `naudotojai` (`NaudotojoID`);

--
-- Constraints for table `registracijoszinute`
--
ALTER TABLE `registracijoszinute`
  ADD CONSTRAINT `registracijoszinute_ibfk_1` FOREIGN KEY (`RegistracijosID`) REFERENCES `registracija` (`RegistracijosID`);

--
-- Constraints for table `vietos`
--
ALTER TABLE `vietos`
  ADD CONSTRAINT `vietos_ibfk_1` FOREIGN KEY (`KonferencijosID`) REFERENCES `konferencijos` (`KonferencijosID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
