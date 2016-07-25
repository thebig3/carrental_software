-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Jul 25, 2016 at 09:22 AM
-- Server version: 10.1.13-MariaDB
-- PHP Version: 5.5.35

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `car_rental_system`
--
CREATE DATABASE IF NOT EXISTS `car_rental_system` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `car_rental_system`;

-- --------------------------------------------------------

--
-- Table structure for table `car`
--

CREATE TABLE `car` (
  `PlateNumber` varchar(45) NOT NULL,
  `Brand` varchar(45) DEFAULT NULL,
  `Model` varchar(45) DEFAULT NULL,
  `PricePerDay` decimal(10,2) DEFAULT NULL,
  `IsAvailable` varchar(45) DEFAULT 'Yes'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `car`
--

INSERT INTO `car` (`PlateNumber`, `Brand`, `Model`, `PricePerDay`, `IsAvailable`) VALUES
('AAB 1149', 'Kia', 'Sorento', '800.00', 'Yes'),
('AAG 12345', 'MITSUBISHI', 'MONTERO', '3000.00', 'Yes'),
('AAG 1241', 'Toyota', 'Corolla', '800.00', 'Yes'),
('AAH 1077', 'Ford', 'EcoSport', '1000.00', 'Yes'),
('ABC 2222', 'FORD', 'RANGER', '3500.00', 'Yes'),
('LCM 101', 'Honda', 'Civic', '750.00', 'Yes'),
('LCS 326', 'Toyota', 'Vios', '750.00', 'Yes'),
('LHF 262', 'Toyota', 'Innova', '1250.00', 'Yes');

-- --------------------------------------------------------

--
-- Table structure for table `rentedcar`
--

CREATE TABLE `rentedcar` (
  `PlateNumber` varchar(45) NOT NULL,
  `RenterName` varchar(45) DEFAULT NULL,
  `RenterAddress` varchar(45) DEFAULT NULL,
  `RentDate` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `returnlog`
--

CREATE TABLE `returnlog` (
  `PlateNumber` varchar(45) DEFAULT NULL,
  `RenterName` varchar(45) DEFAULT NULL,
  `RentDate` date DEFAULT NULL,
  `ReturnDate` date DEFAULT NULL,
  `PricePerDay` decimal(10,2) DEFAULT NULL,
  `Total` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `returnlog`
--

INSERT INTO `returnlog` (`PlateNumber`, `RenterName`, `RentDate`, `ReturnDate`, `PricePerDay`, `Total`) VALUES
('AAG 12345', 'JP', '2016-07-25', '2016-07-25', '3000.00', '3000.00'),
('LCM 101', 'JP', '2016-07-25', '2016-07-25', '750.00', '750.00');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `car`
--
ALTER TABLE `car`
  ADD PRIMARY KEY (`PlateNumber`);

--
-- Indexes for table `rentedcar`
--
ALTER TABLE `rentedcar`
  ADD PRIMARY KEY (`PlateNumber`);

--
-- Indexes for table `returnlog`
--
ALTER TABLE `returnlog`
  ADD KEY `PlateNumber_FK2` (`PlateNumber`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `rentedcar`
--
ALTER TABLE `rentedcar`
  ADD CONSTRAINT `PlateNumber_FK` FOREIGN KEY (`PlateNumber`) REFERENCES `car` (`PlateNumber`) ON DELETE CASCADE ON UPDATE NO ACTION;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
