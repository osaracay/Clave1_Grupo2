-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 13-10-2024 a las 01:32:21
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
-- Base de datos: `clave1_grupo2db`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cat_especie`
--

CREATE TABLE `cat_especie` (
  `id_especie` int(11) NOT NULL,
  `nom_especie` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `cat_especie`
--

INSERT INTO `cat_especie` (`id_especie`, `nom_especie`) VALUES
(3, 'Conejo'),
(4, 'Cuyo'),
(1, 'Gato'),
(5, 'Hamster'),
(8, 'Pajaro'),
(2, 'Perro'),
(6, 'Pez'),
(9, 'Serpiente'),
(7, 'Tortuga');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cat_estado`
--

CREATE TABLE `cat_estado` (
  `id_estado` int(11) NOT NULL,
  `nom_estado` varchar(25) NOT NULL,
  `desc_estado` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `cat_estado`
--

INSERT INTO `cat_estado` (`id_estado`, `nom_estado`, `desc_estado`) VALUES
(1, 'Activacion pendiente', ''),
(2, 'Activo', ''),
(3, 'Inactivo', ''),
(4, 'Suspendido', '');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cat_estado_cita`
--

CREATE TABLE `cat_estado_cita` (
  `id_estado_cita` int(11) NOT NULL,
  `nom_estado_cita` varchar(25) NOT NULL,
  `desc_estado_cita` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `cat_estado_cita`
--

INSERT INTO `cat_estado_cita` (`id_estado_cita`, `nom_estado_cita`, `desc_estado_cita`) VALUES
(1, 'Agendada', ''),
(2, 'Reagendada', ''),
(3, 'Cancelada', ''),
(4, 'Completada', ''),
(5, 'Pausa', 'En caso la fecha agendada llega pero surja un compromiso para el veterinario');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cat_estado_pago`
--

CREATE TABLE `cat_estado_pago` (
  `id_estado_pago` int(11) NOT NULL,
  `nom_estado_pago` varchar(25) NOT NULL,
  `desc_estado_pago` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `cat_estado_pago`
--

INSERT INTO `cat_estado_pago` (`id_estado_pago`, `nom_estado_pago`, `desc_estado_pago`) VALUES
(1, 'Pendiente', 'La cita se ejecuto y se genero una obligacion de pago'),
(2, 'Parcial', 'Subpagado'),
(3, 'Pagado', 'el pago se completó con éxito'),
(4, 'Sobrepagado', 'se pagó más de lo acordado'),
(5, 'Incobrable', '');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cat_met_pago`
--

CREATE TABLE `cat_met_pago` (
  `id_met_pago` int(11) NOT NULL,
  `nom_met_pago` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `cat_met_pago`
--

INSERT INTO `cat_met_pago` (`id_met_pago`, `nom_met_pago`) VALUES
(5, 'Bitcoin'),
(1, 'Efectivo'),
(4, 'Tarjeta Credito'),
(3, 'Tarjeta Debito'),
(2, 'Transferencia');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cat_tipo_cita`
--

CREATE TABLE `cat_tipo_cita` (
  `id_tipo_cita` int(11) NOT NULL,
  `nom_tipo_cita` varchar(25) NOT NULL,
  `desc_tipo_cita` varchar(150) DEFAULT NULL,
  `precio_tipo_cita` decimal(5,2) DEFAULT 0.00 CHECK (`precio_tipo_cita` >= 0)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cat_tipo_insumo`
--

CREATE TABLE `cat_tipo_insumo` (
  `id_tipo_insumo` int(11) NOT NULL,
  `nom_tipo_insumo` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `cat_tipo_insumo`
--

INSERT INTO `cat_tipo_insumo` (`id_tipo_insumo`, `nom_tipo_insumo`) VALUES
(1, 'ACCESORIOS'),
(2, 'ALIMENTOS'),
(7, 'EQUIPOS'),
(4, 'LIMPIEZA'),
(3, 'MATERIAL'),
(5, 'MEDICAMENTOS'),
(6, 'VACUNAS');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cat_tipo_usuario`
--

CREATE TABLE `cat_tipo_usuario` (
  `id_tipo_usuario` int(11) NOT NULL,
  `nom_tipo_usuario` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `cat_tipo_usuario`
--

INSERT INTO `cat_tipo_usuario` (`id_tipo_usuario`, `nom_tipo_usuario`) VALUES
(1, 'Administrador'),
(3, 'Cliente'),
(2, 'Veterinario');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cita`
--

CREATE TABLE `cita` (
  `id_cita` int(11) NOT NULL,
  `id_tipo_cita` int(11) NOT NULL,
  `id_mascota` int(11) NOT NULL,
  `id_veterinario` int(11) NOT NULL,
  `id_estado_cita` int(11) NOT NULL,
  `motivo_cita` varchar(250) DEFAULT NULL,
  `sintomas_mascota` varchar(350) DEFAULT NULL,
  `diagnostico` varchar(350) DEFAULT NULL,
  `tratamiento` varchar(350) DEFAULT NULL,
  `observaciones` varchar(350) DEFAULT NULL,
  `monto_pago` decimal(5,2) DEFAULT 0.00 CHECK (`monto_pago` >= 0),
  `fecha_pago` datetime DEFAULT NULL,
  `id_met_pago` int(11) NOT NULL DEFAULT 1,
  `id_estado_pago` int(11) NOT NULL DEFAULT 1,
  `peso_mascota` decimal(5,2) DEFAULT NULL,
  `unit_med_peso` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_compra`
--

CREATE TABLE `detalle_compra` (
  `id_mov` int(11) NOT NULL,
  `fecha` datetime NOT NULL,
  `nombre` varchar(90) NOT NULL,
  `id_insumo` int(11) NOT NULL,
  `nom_insumo` varchar(90) NOT NULL,
  `precio` decimal(10,0) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `stock_final` int(11) NOT NULL,
  `condicion` varchar(12) NOT NULL,
  `tipo` varchar(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `detalle_compra`
--

INSERT INTO `detalle_compra` (`id_mov`, `fecha`, `nombre`, `id_insumo`, `nom_insumo`, `precio`, `cantidad`, `stock_final`, `condicion`, `tipo`) VALUES
(1, '0000-00-00 00:00:00', 'NOMBRE PRUEBA', 6, 'Analgesicos Anti-inflamatorios Meloxicam', 34, 500, 5002, 'CONTADO', 'Entrada'),
(2, '2024-10-12 00:00:00', 'NOMBRE PRUEBA', 8, 'Vacuna de Parvovirus', 3, 12, 50, 'CONTADO', 'Entrada'),
(3, '2024-10-12 00:00:00', 'NOMBRE PRUEBA', 10, 'Algodon y gasas esteriles', 2, 5, 50, 'CONTADO', 'Entrada'),
(4, '2024-10-12 00:00:00', 'FARMACIA LOS ANGELES', 8, 'Vacuna de Parvovirus', 3, 24, 36, 'CONTADO', 'Entrada'),
(5, '2024-10-12 00:00:00', 'COMERCIAL', 12, 'Collares isabelinos', 8, 50, 62, 'CONTADO', 'Entrada'),
(6, '2024-10-12 00:00:00', '', 4, 'Antibióticos Amoxicilina 500ML', 13, 80, 100, 'CONTADO', 'Entrada'),
(7, '2024-10-12 00:00:00', '', 4, 'Antibióticos Amoxicilina 500ML', 13, 80, 100, 'CONTADO', 'Entrada'),
(8, '2024-10-12 00:00:00', 'AAAA', 4, 'Antibióticos Amoxicilina 500ML', 13, 80, 100, 'CONTADO', 'Entrada'),
(9, '2024-10-12 00:00:00', '', 4, 'Antibióticos Amoxicilina 500ML', 13, 80, 100, 'CONTADO', 'Entrada'),
(10, '2024-10-12 00:00:00', '', 4, 'Antibióticos Amoxicilina 500ML', 13, 80, 100, 'CONTADO', 'Entrada');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_factura`
--

CREATE TABLE `detalle_factura` (
  `id_detalle_factura` int(11) NOT NULL,
  `id_factura` int(11) NOT NULL,
  `id_insumo` int(11) NOT NULL,
  `q_insumo` int(11) NOT NULL,
  `subtotal` decimal(10,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `factura`
--

CREATE TABLE `factura` (
  `id_factura` int(11) NOT NULL,
  `fecha` datetime NOT NULL,
  `monto_total` decimal(10,2) NOT NULL,
  `id_met_pago` int(11) NOT NULL,
  `estado_factura` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `insumo`
--

CREATE TABLE `insumo` (
  `id_insumo` int(11) NOT NULL,
  `nom_insumo` varchar(45) NOT NULL,
  `id_tipo_insumo` int(11) NOT NULL,
  `desc_insumo` varchar(150) DEFAULT NULL,
  `precio_unit` decimal(5,2) DEFAULT 0.00 CHECK (`precio_unit` >= 0.0),
  `unit_medida` varchar(20) DEFAULT NULL,
  `existencias_insumo` int(10) UNSIGNED DEFAULT 0,
  `punto_reorden_insumo` int(10) UNSIGNED DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `insumo`
--

INSERT INTO `insumo` (`id_insumo`, `nom_insumo`, `id_tipo_insumo`, `desc_insumo`, `precio_unit`, `unit_medida`, `existencias_insumo`, `punto_reorden_insumo`) VALUES
(4, 'Antibióticos Amoxicilina 500ML', 5, 'MEDICAMENTOS', 12.58, 'UND', 20, 6),
(6, 'Analgesicos Anti-inflamatorios Meloxicam', 5, 'MEDICAMENTOS', 34.25, 'UND', 500, 50),
(7, 'Desparasitantes  Ivermectina 250ml', 5, 'MEDICAMENTOS', 6.50, 'UND', 25, 6),
(8, 'Vacuna de Parvovirus', 6, 'VACUNAS', 2.65, 'UND', 12, 3),
(9, 'Vacuna para Rabia', 6, 'VACUNAS', 3.75, 'UND', 325, 25),
(10, 'Algodon y gasas esteriles', 3, 'MATERIAL', 2.00, 'UND', 45, 12),
(11, 'Suplementos vitamínicos', 2, 'ALIMENTOS', 1.85, 'LIBRA', 1250, 100),
(12, 'Collares isabelinos', 1, 'ACCESORIOS', 6.50, 'UND', 12, 2),
(13, 'Bozales', 1, 'ACCESORIOS', 2.55, 'UND', 23, 5);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `mascota`
--

CREATE TABLE `mascota` (
  `id_mascota` int(11) NOT NULL,
  `nom_mascota` varchar(25) NOT NULL,
  `especie` int(11) NOT NULL,
  `raza` varchar(20) DEFAULT NULL,
  `edad` int(10) UNSIGNED DEFAULT NULL,
  `genero_mascota` enum('M','F','X') DEFAULT NULL,
  `id_propietario` int(11) NOT NULL,
  `estado_mascota` int(11) NOT NULL,
  `color` varchar(25) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE `usuario` (
  `id_usuario` int(11) NOT NULL,
  `nombre` varchar(30) NOT NULL,
  `apellido` varchar(30) NOT NULL,
  `fecha_nacimiento` datetime DEFAULT NULL,
  `tipo_usuario` int(11) NOT NULL,
  `estado_usuario` int(11) NOT NULL,
  `email` varchar(80) NOT NULL,
  `genero` enum('M','F','X') NOT NULL,
  `usr_login` varchar(30) NOT NULL,
  `usr_pw` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`id_usuario`, `nombre`, `apellido`, `fecha_nacimiento`, `tipo_usuario`, `estado_usuario`, `email`, `genero`, `usr_login`, `usr_pw`) VALUES
(1, 'MILTON', 'AGUIRRE', '2000-10-01 09:25:48', 3, 2, 'aguirre@gmail.com', 'M', 'AGUIRRE', '+DwF8Wg9eKs=');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `cat_especie`
--
ALTER TABLE `cat_especie`
  ADD PRIMARY KEY (`id_especie`),
  ADD UNIQUE KEY `nom_especie` (`nom_especie`);

--
-- Indices de la tabla `cat_estado`
--
ALTER TABLE `cat_estado`
  ADD PRIMARY KEY (`id_estado`),
  ADD UNIQUE KEY `nom_estado` (`nom_estado`);

--
-- Indices de la tabla `cat_estado_cita`
--
ALTER TABLE `cat_estado_cita`
  ADD PRIMARY KEY (`id_estado_cita`),
  ADD UNIQUE KEY `nom_estado_cita` (`nom_estado_cita`);

--
-- Indices de la tabla `cat_estado_pago`
--
ALTER TABLE `cat_estado_pago`
  ADD PRIMARY KEY (`id_estado_pago`),
  ADD UNIQUE KEY `nom_estado_pago` (`nom_estado_pago`);

--
-- Indices de la tabla `cat_met_pago`
--
ALTER TABLE `cat_met_pago`
  ADD PRIMARY KEY (`id_met_pago`),
  ADD UNIQUE KEY `nom_met_pago` (`nom_met_pago`);

--
-- Indices de la tabla `cat_tipo_cita`
--
ALTER TABLE `cat_tipo_cita`
  ADD PRIMARY KEY (`id_tipo_cita`),
  ADD UNIQUE KEY `nom_tipo_cita` (`nom_tipo_cita`);

--
-- Indices de la tabla `cat_tipo_insumo`
--
ALTER TABLE `cat_tipo_insumo`
  ADD PRIMARY KEY (`id_tipo_insumo`),
  ADD UNIQUE KEY `nom_tipo_insumo` (`nom_tipo_insumo`);

--
-- Indices de la tabla `cat_tipo_usuario`
--
ALTER TABLE `cat_tipo_usuario`
  ADD PRIMARY KEY (`id_tipo_usuario`),
  ADD UNIQUE KEY `nom_tipo_usuario` (`nom_tipo_usuario`);

--
-- Indices de la tabla `cita`
--
ALTER TABLE `cita`
  ADD PRIMARY KEY (`id_cita`),
  ADD KEY `id_tipo_cita` (`id_tipo_cita`),
  ADD KEY `id_mascota` (`id_mascota`),
  ADD KEY `id_veterinario` (`id_veterinario`),
  ADD KEY `id_estado_cita` (`id_estado_cita`),
  ADD KEY `id_met_pago` (`id_met_pago`),
  ADD KEY `id_estado_pago` (`id_estado_pago`);

--
-- Indices de la tabla `detalle_compra`
--
ALTER TABLE `detalle_compra`
  ADD PRIMARY KEY (`id_mov`);

--
-- Indices de la tabla `detalle_factura`
--
ALTER TABLE `detalle_factura`
  ADD PRIMARY KEY (`id_detalle_factura`);

--
-- Indices de la tabla `factura`
--
ALTER TABLE `factura`
  ADD PRIMARY KEY (`id_factura`);

--
-- Indices de la tabla `insumo`
--
ALTER TABLE `insumo`
  ADD PRIMARY KEY (`id_insumo`),
  ADD UNIQUE KEY `nom_insumo` (`nom_insumo`),
  ADD KEY `id_tipo_insumo` (`id_tipo_insumo`);

--
-- Indices de la tabla `mascota`
--
ALTER TABLE `mascota`
  ADD PRIMARY KEY (`id_mascota`),
  ADD KEY `especie` (`especie`),
  ADD KEY `id_propietario` (`id_propietario`),
  ADD KEY `estado_mascota` (`estado_mascota`);

--
-- Indices de la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`id_usuario`),
  ADD UNIQUE KEY `email` (`email`),
  ADD UNIQUE KEY `usr_login` (`usr_login`),
  ADD KEY `tipo_usuario` (`tipo_usuario`),
  ADD KEY `estado_usuario` (`estado_usuario`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `cat_especie`
--
ALTER TABLE `cat_especie`
  MODIFY `id_especie` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT de la tabla `cat_estado`
--
ALTER TABLE `cat_estado`
  MODIFY `id_estado` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de la tabla `cat_estado_cita`
--
ALTER TABLE `cat_estado_cita`
  MODIFY `id_estado_cita` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `cat_estado_pago`
--
ALTER TABLE `cat_estado_pago`
  MODIFY `id_estado_pago` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `cat_met_pago`
--
ALTER TABLE `cat_met_pago`
  MODIFY `id_met_pago` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `cat_tipo_cita`
--
ALTER TABLE `cat_tipo_cita`
  MODIFY `id_tipo_cita` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `cat_tipo_insumo`
--
ALTER TABLE `cat_tipo_insumo`
  MODIFY `id_tipo_insumo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de la tabla `cat_tipo_usuario`
--
ALTER TABLE `cat_tipo_usuario`
  MODIFY `id_tipo_usuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de la tabla `cita`
--
ALTER TABLE `cita`
  MODIFY `id_cita` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `detalle_compra`
--
ALTER TABLE `detalle_compra`
  MODIFY `id_mov` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT de la tabla `detalle_factura`
--
ALTER TABLE `detalle_factura`
  MODIFY `id_detalle_factura` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `factura`
--
ALTER TABLE `factura`
  MODIFY `id_factura` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `insumo`
--
ALTER TABLE `insumo`
  MODIFY `id_insumo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT de la tabla `mascota`
--
ALTER TABLE `mascota`
  MODIFY `id_mascota` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `usuario`
--
ALTER TABLE `usuario`
  MODIFY `id_usuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `cita`
--
ALTER TABLE `cita`
  ADD CONSTRAINT `cita_ibfk_1` FOREIGN KEY (`id_tipo_cita`) REFERENCES `cat_tipo_cita` (`id_tipo_cita`),
  ADD CONSTRAINT `cita_ibfk_2` FOREIGN KEY (`id_mascota`) REFERENCES `mascota` (`id_mascota`),
  ADD CONSTRAINT `cita_ibfk_3` FOREIGN KEY (`id_veterinario`) REFERENCES `usuario` (`id_usuario`),
  ADD CONSTRAINT `cita_ibfk_4` FOREIGN KEY (`id_estado_cita`) REFERENCES `cat_estado_cita` (`id_estado_cita`),
  ADD CONSTRAINT `cita_ibfk_5` FOREIGN KEY (`id_met_pago`) REFERENCES `cat_met_pago` (`id_met_pago`),
  ADD CONSTRAINT `cita_ibfk_6` FOREIGN KEY (`id_estado_pago`) REFERENCES `cat_estado_pago` (`id_estado_pago`);

--
-- Filtros para la tabla `insumo`
--
ALTER TABLE `insumo`
  ADD CONSTRAINT `insumo_ibfk_1` FOREIGN KEY (`id_tipo_insumo`) REFERENCES `cat_tipo_insumo` (`id_tipo_insumo`);

--
-- Filtros para la tabla `mascota`
--
ALTER TABLE `mascota`
  ADD CONSTRAINT `mascota_ibfk_1` FOREIGN KEY (`especie`) REFERENCES `cat_especie` (`id_especie`),
  ADD CONSTRAINT `mascota_ibfk_2` FOREIGN KEY (`id_propietario`) REFERENCES `usuario` (`id_usuario`),
  ADD CONSTRAINT `mascota_ibfk_3` FOREIGN KEY (`estado_mascota`) REFERENCES `cat_estado` (`id_estado`);

--
-- Filtros para la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD CONSTRAINT `usuario_ibfk_1` FOREIGN KEY (`tipo_usuario`) REFERENCES `cat_tipo_usuario` (`id_tipo_usuario`),
  ADD CONSTRAINT `usuario_ibfk_2` FOREIGN KEY (`estado_usuario`) REFERENCES `cat_estado` (`id_estado`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
