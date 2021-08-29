-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 29, 2021 at 12:10 PM
-- Server version: 10.4.17-MariaDB
-- PHP Version: 8.0.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `toko`
--

-- --------------------------------------------------------

--
-- Table structure for table `barang`
--

CREATE TABLE `barang` (
  `Id_Barang` char(15) NOT NULL,
  `Nama_Barang` varchar(30) NOT NULL,
  `Jenis_Barang` varchar(30) NOT NULL,
  `Id_Supplier` char(15) NOT NULL,
  `Stok` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `barang`
--

INSERT INTO `barang` (`Id_Barang`, `Nama_Barang`, `Jenis_Barang`, `Id_Supplier`, `Stok`) VALUES
('788', 'Makanan', 'bukan Minuman', '34', 4);

-- --------------------------------------------------------

--
-- Table structure for table `customers`
--

CREATE TABLE `customers` (
  `Id_Customers` char(15) NOT NULL,
  `Nama_Customers` varchar(30) NOT NULL,
  `Jenis_Kelamin` char(2) NOT NULL,
  `Tanggal_Lahir` date NOT NULL,
  `Alamat` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `customers`
--

INSERT INTO `customers` (`Id_Customers`, `Nama_Customers`, `Jenis_Kelamin`, `Tanggal_Lahir`, `Alamat`) VALUES
('1', 'Orang', 'P', '2021-06-01', 'Bumi');

-- --------------------------------------------------------

--
-- Table structure for table `supplier`
--

CREATE TABLE `supplier` (
  `Id_Supplier` char(15) NOT NULL,
  `Nama_Supplier` varchar(30) NOT NULL,
  `Jenis_Kelamin` char(2) NOT NULL,
  `Tanggal_Lahir` date NOT NULL,
  `Alamat` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `supplier`
--

INSERT INTO `supplier` (`Id_Supplier`, `Nama_Supplier`, `Jenis_Kelamin`, `Tanggal_Lahir`, `Alamat`) VALUES
('34', 'Orang', 'LK', '2021-06-15', 'Mars');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `barang`
--
ALTER TABLE `barang`
  ADD PRIMARY KEY (`Id_Barang`);

--
-- Indexes for table `customers`
--
ALTER TABLE `customers`
  ADD PRIMARY KEY (`Id_Customers`);

--
-- Indexes for table `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`Id_Supplier`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
