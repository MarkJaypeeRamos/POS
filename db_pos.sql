-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Jun 30, 2021 at 04:32 PM
-- Server version: 5.7.23
-- PHP Version: 7.2.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_pos`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_employee`
--

DROP TABLE IF EXISTS `tbl_employee`;
CREATE TABLE IF NOT EXISTS `tbl_employee` (
  `EMP_ID` varchar(50) NOT NULL,
  `EMP_NAME` varchar(30) NOT NULL,
  `EMP_ADDRESS` varchar(50) NOT NULL,
  `EMP_CONTACT` varchar(11) NOT NULL,
  `EMP_POSITION` varchar(20) NOT NULL,
  `EMP_USERNAME` varchar(20) NOT NULL,
  `EMP_PASSWORD` varchar(50) NOT NULL,
  PRIMARY KEY (`EMP_ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_employee`
--

INSERT INTO `tbl_employee` (`EMP_ID`, `EMP_NAME`, `EMP_ADDRESS`, `EMP_CONTACT`, `EMP_POSITION`, `EMP_USERNAME`, `EMP_PASSWORD`) VALUES
('1', 'Mark Jaypee Ramos', 'Biñan', '09658438741', 'Administrator', 'mark', 'mark'),
('2', 'Jasper Jacob', 'Carmona', '09475738475', 'Cashier', 'jaja', 'jaja'),
('3', 'Rafael Hara', 'Sta. Rosa', '09876536453', 'Administrator', 'raf', 'raf');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
