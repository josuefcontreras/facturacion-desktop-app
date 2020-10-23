-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 23, 2020 at 07:13 PM
-- Server version: 10.4.14-MariaDB
-- PHP Version: 7.4.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `practica_final_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `cliente`
--

CREATE TABLE `cliente` (
  `codigo_cliente` int(11) NOT NULL,
  `nombre` varchar(200) NOT NULL,
  `apellido` varchar(200) NOT NULL,
  `cedula` char(8) NOT NULL,
  `telefono` varchar(30) NOT NULL,
  `activo` char(1) NOT NULL DEFAULT '1',
  `fecha_creacion` date NOT NULL DEFAULT utc_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `cliente`
--

INSERT INTO `cliente` (`codigo_cliente`, `nombre`, `apellido`, `cedula`, `telefono`, `activo`, `fecha_creacion`) VALUES
(1, 'Juan M.', 'Perez', 'SDO00001', '8092201111', '1', '2020-10-15'),
(2, 'Jose', 'Perez', 'SDO00002', '8092201212', '1', '2020-10-15');

-- --------------------------------------------------------

--
-- Table structure for table `factura`
--

CREATE TABLE `factura` (
  `codigo_factura` int(11) NOT NULL,
  `fecha_creacion` date NOT NULL DEFAULT utc_timestamp(),
  `total_factura` decimal(8,2) NOT NULL,
  `activa` char(1) NOT NULL DEFAULT '1',
  `codigo_cliente` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `factura_producto`
--

CREATE TABLE `factura_producto` (
  `codigo_factura` int(11) NOT NULL,
  `codigo_producto` int(11) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `precio_unitario` decimal(8,2) NOT NULL,
  `total` decimal(12,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `producto`
--

CREATE TABLE `producto` (
  `codigo_producto` int(11) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `descripcion` varchar(500) NOT NULL,
  `precio` decimal(8,2) NOT NULL,
  `costo` decimal(8,2) NOT NULL,
  `existencia` int(11) NOT NULL,
  `activo` char(1) NOT NULL DEFAULT '1',
  `tipo_producto` int(11) NOT NULL,
  `fecha_creacion` datetime NOT NULL DEFAULT utc_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `producto`
--

INSERT INTO `producto` (`codigo_producto`, `nombre`, `descripcion`, `precio`, `costo`, `existencia`, `activo`, `tipo_producto`, `fecha_creacion`) VALUES
(7, 'CHAMPAGNE LAFORGE GRANDE CUVEE', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla at.', '6000.00', '2550.00', 1000, '1', 3, '2020-10-15 13:18:12'),
(8, 'CHAMPAGNE DUNTZE LEGENDE ROSE', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla at.', '8000.00', '1500.00', 1000, '1', 3, '2020-10-15 13:18:12'),
(11, 'Pera B', 'Pera Colombiana', '150.00', '50.00', 15000, '1', 11, '2020-10-18 11:57:48');

-- --------------------------------------------------------

--
-- Table structure for table `tipo_producto`
--

CREATE TABLE `tipo_producto` (
  `codigo_tipo_producto` int(11) NOT NULL,
  `descripcion` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tipo_producto`
--

INSERT INTO `tipo_producto` (`codigo_tipo_producto`, `descripcion`) VALUES
(3, 'Champagne'),
(14, 'Detergentes'),
(11, 'Frutas'),
(7, 'Ginebra'),
(4, 'Sidra'),
(12, 'Soda'),
(6, 'Tequila'),
(10, 'Vegetales'),
(5, 'Vodka');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`codigo_cliente`),
  ADD UNIQUE KEY `cedula` (`cedula`);

--
-- Indexes for table `factura`
--
ALTER TABLE `factura`
  ADD PRIMARY KEY (`codigo_factura`),
  ADD KEY `codigo_cliente` (`codigo_cliente`);

--
-- Indexes for table `factura_producto`
--
ALTER TABLE `factura_producto`
  ADD PRIMARY KEY (`codigo_factura`,`codigo_producto`),
  ADD KEY `codigo_producto` (`codigo_producto`);

--
-- Indexes for table `producto`
--
ALTER TABLE `producto`
  ADD PRIMARY KEY (`codigo_producto`),
  ADD KEY `tipo_producto` (`tipo_producto`);

--
-- Indexes for table `tipo_producto`
--
ALTER TABLE `tipo_producto`
  ADD PRIMARY KEY (`codigo_tipo_producto`),
  ADD UNIQUE KEY `descripcion` (`descripcion`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `cliente`
--
ALTER TABLE `cliente`
  MODIFY `codigo_cliente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `factura`
--
ALTER TABLE `factura`
  MODIFY `codigo_factura` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `producto`
--
ALTER TABLE `producto`
  MODIFY `codigo_producto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `tipo_producto`
--
ALTER TABLE `tipo_producto`
  MODIFY `codigo_tipo_producto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `factura`
--
ALTER TABLE `factura`
  ADD CONSTRAINT `factura_ibfk_1` FOREIGN KEY (`codigo_cliente`) REFERENCES `cliente` (`codigo_cliente`) ON DELETE CASCADE;

--
-- Constraints for table `factura_producto`
--
ALTER TABLE `factura_producto`
  ADD CONSTRAINT `factura_producto_ibfk_1` FOREIGN KEY (`codigo_factura`) REFERENCES `factura` (`codigo_factura`) ON DELETE CASCADE,
  ADD CONSTRAINT `factura_producto_ibfk_2` FOREIGN KEY (`codigo_producto`) REFERENCES `producto` (`codigo_producto`) ON DELETE CASCADE;

--
-- Constraints for table `producto`
--
ALTER TABLE `producto`
  ADD CONSTRAINT `producto_ibfk_1` FOREIGN KEY (`tipo_producto`) REFERENCES `tipo_producto` (`codigo_tipo_producto`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
