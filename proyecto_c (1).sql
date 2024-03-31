-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 01-04-2024 a las 00:00:01
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `proyecto_c`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empleadoin`
--

CREATE TABLE `empleadoin` (
  `identificacion` int(11) NOT NULL,
  `nombre` varchar(20) NOT NULL,
  `hora_in` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `empleadoin`
--

INSERT INTO `empleadoin` (`identificacion`, `nombre`, `hora_in`) VALUES
(233443, 'juan camor padua may', '08:00:00'),
(32444532, 'Camilo Padua', '10:00:00'),
(102323223, 'carlos alberto', '14:30:00'),
(103423223, 'juan alberto', '18:30:00'),
(123456789, 'carlos orjuela', '09:00:00');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empleadosal`
--

CREATE TABLE `empleadosal` (
  `identificacion` int(11) NOT NULL,
  `nombre` varchar(20) NOT NULL,
  `hora_sal` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `empleadosal`
--

INSERT INTO `empleadosal` (`identificacion`, `nombre`, `hora_sal`) VALUES
(32444532, 'Camilo Padua', '16:00:00'),
(103423223, 'juan alberto', '23:30:00'),
(123456789, 'carlos orjuela', '18:00:00');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `empleadoin`
--
ALTER TABLE `empleadoin`
  ADD PRIMARY KEY (`identificacion`);

--
-- Indices de la tabla `empleadosal`
--
ALTER TABLE `empleadosal`
  ADD PRIMARY KEY (`identificacion`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
