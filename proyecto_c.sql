-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 31-03-2024 a las 11:18:08
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
(102323223, 'carlos alberto', '14:30:00');

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
