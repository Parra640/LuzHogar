-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 20-11-2019 a las 20:09:36
-- Versión del servidor: 10.1.25-MariaDB
-- Versión de PHP: 7.1.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `luzhogardb`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `aspnetroleclaims`
--

CREATE TABLE `aspnetroleclaims` (
  `Id` int(11) NOT NULL,
  `RoleId` varchar(255) NOT NULL,
  `ClaimType` longtext,
  `ClaimValue` longtext
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `aspnetroles`
--

CREATE TABLE `aspnetroles` (
  `Id` varchar(255) NOT NULL,
  `Name` varchar(256) DEFAULT NULL,
  `NormalizedName` varchar(256) DEFAULT NULL,
  `ConcurrencyStamp` longtext
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `aspnetroles`
--

INSERT INTO `aspnetroles` (`Id`, `Name`, `NormalizedName`, `ConcurrencyStamp`) VALUES
('16a192bd-4d3f-44fa-a755-e74fa285a9e5', 'admin', 'ADMIN', '507a1e37-97c1-4bda-a8a0-cb2983af7c39'),
('19513f7c-f3c1-4c6a-ab04-5fa619963478', 'usuario', 'USUARIO', '1868dac0-8246-4dca-9bb9-0464a9a66055');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `aspnetuserclaims`
--

CREATE TABLE `aspnetuserclaims` (
  `Id` int(11) NOT NULL,
  `UserId` varchar(255) NOT NULL,
  `ClaimType` longtext,
  `ClaimValue` longtext
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `aspnetuserlogins`
--

CREATE TABLE `aspnetuserlogins` (
  `LoginProvider` varchar(255) NOT NULL,
  `ProviderKey` varchar(255) NOT NULL,
  `ProviderDisplayName` longtext,
  `UserId` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `aspnetuserroles`
--

CREATE TABLE `aspnetuserroles` (
  `UserId` varchar(255) NOT NULL,
  `RoleId` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `aspnetuserroles`
--

INSERT INTO `aspnetuserroles` (`UserId`, `RoleId`) VALUES
('bd33c6b2-b8b7-46ed-8919-02cb00491e2c', '19513f7c-f3c1-4c6a-ab04-5fa619963478'),
('c74c0aaf-db49-4c3e-9e9e-140745d35431', '16a192bd-4d3f-44fa-a755-e74fa285a9e5'),
('c74c0aaf-db49-4c3e-9e9e-140745d35431', '19513f7c-f3c1-4c6a-ab04-5fa619963478');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `aspnetusers`
--

CREATE TABLE `aspnetusers` (
  `Id` varchar(255) NOT NULL,
  `UserName` varchar(256) DEFAULT NULL,
  `NormalizedUserName` varchar(256) DEFAULT NULL,
  `Email` varchar(256) DEFAULT NULL,
  `NormalizedEmail` varchar(256) DEFAULT NULL,
  `EmailConfirmed` bit(1) NOT NULL,
  `PasswordHash` longtext,
  `SecurityStamp` longtext,
  `ConcurrencyStamp` longtext,
  `PhoneNumber` longtext,
  `PhoneNumberConfirmed` bit(1) NOT NULL,
  `TwoFactorEnabled` bit(1) NOT NULL,
  `LockoutEnd` datetime(6) DEFAULT NULL,
  `LockoutEnabled` bit(1) NOT NULL,
  `AccessFailedCount` int(11) NOT NULL,
  `Discriminator` longtext NOT NULL,
  `Nombre` longtext,
  `ApePaterno` longtext,
  `ApeMaterno` longtext,
  `Direccion` longtext,
  `Referencia` longtext,
  `Telefono` longtext,
  `Dni` longtext,
  `Correo` longtext
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `aspnetusers`
--

INSERT INTO `aspnetusers` (`Id`, `UserName`, `NormalizedUserName`, `Email`, `NormalizedEmail`, `EmailConfirmed`, `PasswordHash`, `SecurityStamp`, `ConcurrencyStamp`, `PhoneNumber`, `PhoneNumberConfirmed`, `TwoFactorEnabled`, `LockoutEnd`, `LockoutEnabled`, `AccessFailedCount`, `Discriminator`, `Nombre`, `ApePaterno`, `ApeMaterno`, `Direccion`, `Referencia`, `Telefono`, `Dni`, `Correo`) VALUES
('bd33c6b2-b8b7-46ed-8919-02cb00491e2c', 'daddygianko@gmail.com', 'DADDYGIANKO@GMAIL.COM', NULL, NULL, b'1111111111111111111111111111111', 'AQAAAAEAACcQAAAAEIZrG68W7HXzEC6turlGAVHdY+ke5q0qXcmR6ytvWowf4p7V8PJkBf2YcscuD7IoHA==', '4DVECM4YXU7GDHBBIUCWNULZN4LY4J4R', 'b4a4c784-9dd4-4398-8a10-41913030160a', NULL, b'1111111111111111111111111111111', b'1111111111111111111111111111111', NULL, b'1111111111111111111111111111111', 0, 'Usuario', 'gianfranco', 'mello', 'loayza', '6tugy', '6tyg', '76867', '7679', 'daddygianko@gmail.com'),
('c74c0aaf-db49-4c3e-9e9e-140745d35431', 'admin@hotmail.com', 'ADMIN@HOTMAIL.COM', NULL, NULL, b'1111111111111111111111111111111', 'AQAAAAEAACcQAAAAEGD38k37lUfce6RNnfpO3p405gUk7ePr9ErH8GbspnZ8QsvdJrwHk/8w0biS72p0jA==', 'FKG4E4RKXILJNFXPC735VOE2OXWAX35T', '53586a0d-204f-4003-a57b-3c70d4379948', NULL, b'1111111111111111111111111111111', b'1111111111111111111111111111111', NULL, b'1111111111111111111111111111111', 0, 'Usuario', 'admin', 'sdiuj', 'sudj', '6ut7yh', 'u7yiuhj', '234587', '67876', 'admin@hotmail.com');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `aspnetusertokens`
--

CREATE TABLE `aspnetusertokens` (
  `UserId` varchar(255) NOT NULL,
  `LoginProvider` varchar(255) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `Value` longtext
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `categorias`
--

CREATE TABLE `categorias` (
  `Id` int(11) NOT NULL,
  `Nombre` longtext
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `categorias`
--

INSERT INTO `categorias` (`Id`, `Nombre`) VALUES
(1, 'Otros'),
(5, 'Comedor'),
(6, 'Sala'),
(7, 'Dormitorio');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `contratos`
--

CREATE TABLE `contratos` (
  `Id` int(11) NOT NULL,
  `UsuarioId` varchar(255) DEFAULT NULL,
  `MuebleId` int(11) NOT NULL,
  `Progreso` longtext,
  `Cantidad` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `contratos`
--

INSERT INTO `contratos` (`Id`, `UsuarioId`, `MuebleId`, `Progreso`, `Cantidad`) VALUES
(13, 'bd33c6b2-b8b7-46ed-8919-02cb00491e2c', 5, 'finalizado', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `muebles`
--

CREATE TABLE `muebles` (
  `Id` int(11) NOT NULL,
  `Nombre` longtext,
  `Color` longtext,
  `Descripcion` longtext,
  `Precio` float NOT NULL,
  `Stock` int(11) NOT NULL,
  `Foto` longtext,
  `CategoriaId` int(11) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `muebles`
--

INSERT INTO `muebles` (`Id`, `Nombre`, `Color`, `Descripcion`, `Precio`, `Stock`, `Foto`, `CategoriaId`) VALUES
(3, 'Sillon 01', 'gris', 'para 3 personas', 120, 10, 'https://mlstaticquic-a.akamaihd.net/sofa-cama-livings-sillon-cama-living-sala-sillones-divino-D_NQ_NP_893527-MLU27776353065_072018-F.jpg', 1),
(4, 'Mesa Comedor 01', 'marron', 'mesa para el comedor sin sillas', 170, 5, 'http://siducdesign.com/wp-content/uploads/2019/02/Untitled-8.jpg', 5),
(5, 'Cama 02', 'marron oscuro', 'para 2 personas', 250, 19, 'https://rosen.vteximg.com.br/arquivos/ids/178767-830-830/Cama-Ergo-T-2-Plazas-Base-Dividida-con-Textil-y-Muebles-Bilbao-1-29.jpg?v=636426311845700000', 7);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pedidosespeciales`
--

CREATE TABLE `pedidosespeciales` (
  `Id` int(11) NOT NULL,
  `Nombre` longtext,
  `Color` longtext,
  `Descripcion` longtext,
  `Precio` float NOT NULL,
  `Cantidad` int(11) NOT NULL,
  `Foto` longtext,
  `UsuarioId` varchar(255) DEFAULT NULL,
  `Estado` longtext
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `pedidosespeciales`
--

INSERT INTO `pedidosespeciales` (`Id`, `Nombre`, `Color`, `Descripcion`, `Precio`, `Cantidad`, `Foto`, `UsuarioId`, `Estado`) VALUES
(2, 'cama grande', 'azul', 'para dos personas', 800, 1, 'https://rosen.vteximg.com.br/arquivos/ids/178767-830-830/Cama-Ergo-T-2-Plazas-Base-Dividida-con-Textil-y-Muebles-Bilbao-1-29.jpg?v=636426311845700000', 'bd33c6b2-b8b7-46ed-8919-02cb00491e2c', 'Fabricando el mueble'),
(3, 'cama 4', 'gris', 'cama grandota', 500, 2, 'https://rosen.vteximg.com.br/arquivos/ids/178767-830-830/Cama-Ergo-T-2-Plazas-Base-Dividida-con-Textil-y-Muebles-Bilbao-1-29.jpg?v=636426311845700000', 'bd33c6b2-b8b7-46ed-8919-02cb00491e2c', 'Finalizado');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `__efmigrationshistory`
--

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(95) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `__efmigrationshistory`
--

INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
('20191109213228_BDInicial', '2.2.6-servicing-10079'),
('20191113051909_agregandoTablas', '2.2.6-servicing-10079'),
('20191113052742_ModificandoUsuario', '2.2.6-servicing-10079'),
('20191113192940_creacionadmi', '2.2.6-servicing-10079'),
('20191116223629_cambioEnPedidoEspecial', '2.2.6-servicing-10079'),
('20191117221246_CambioIdUsuario', '2.2.6-servicing-10079'),
('20191119131210_AgregadoCategorias', '2.2.6-servicing-10079');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `aspnetroleclaims`
--
ALTER TABLE `aspnetroleclaims`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_AspNetRoleClaims_RoleId` (`RoleId`);

--
-- Indices de la tabla `aspnetroles`
--
ALTER TABLE `aspnetroles`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `RoleNameIndex` (`NormalizedName`);

--
-- Indices de la tabla `aspnetuserclaims`
--
ALTER TABLE `aspnetuserclaims`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_AspNetUserClaims_UserId` (`UserId`);

--
-- Indices de la tabla `aspnetuserlogins`
--
ALTER TABLE `aspnetuserlogins`
  ADD PRIMARY KEY (`LoginProvider`,`ProviderKey`),
  ADD KEY `IX_AspNetUserLogins_UserId` (`UserId`);

--
-- Indices de la tabla `aspnetuserroles`
--
ALTER TABLE `aspnetuserroles`
  ADD PRIMARY KEY (`UserId`,`RoleId`),
  ADD KEY `IX_AspNetUserRoles_RoleId` (`RoleId`);

--
-- Indices de la tabla `aspnetusers`
--
ALTER TABLE `aspnetusers`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `UserNameIndex` (`NormalizedUserName`),
  ADD KEY `EmailIndex` (`NormalizedEmail`);

--
-- Indices de la tabla `aspnetusertokens`
--
ALTER TABLE `aspnetusertokens`
  ADD PRIMARY KEY (`UserId`,`LoginProvider`,`Name`);

--
-- Indices de la tabla `categorias`
--
ALTER TABLE `categorias`
  ADD PRIMARY KEY (`Id`);

--
-- Indices de la tabla `contratos`
--
ALTER TABLE `contratos`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_Contratos_MuebleId` (`MuebleId`),
  ADD KEY `IX_Contratos_UsuarioId` (`UsuarioId`);

--
-- Indices de la tabla `muebles`
--
ALTER TABLE `muebles`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_Muebles_CategoriaId` (`CategoriaId`);

--
-- Indices de la tabla `pedidosespeciales`
--
ALTER TABLE `pedidosespeciales`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_PedidosEspeciales_UsuarioId` (`UsuarioId`);

--
-- Indices de la tabla `__efmigrationshistory`
--
ALTER TABLE `__efmigrationshistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `aspnetroleclaims`
--
ALTER TABLE `aspnetroleclaims`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `aspnetuserclaims`
--
ALTER TABLE `aspnetuserclaims`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `categorias`
--
ALTER TABLE `categorias`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
--
-- AUTO_INCREMENT de la tabla `contratos`
--
ALTER TABLE `contratos`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;
--
-- AUTO_INCREMENT de la tabla `muebles`
--
ALTER TABLE `muebles`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT de la tabla `pedidosespeciales`
--
ALTER TABLE `pedidosespeciales`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `aspnetroleclaims`
--
ALTER TABLE `aspnetroleclaims`
  ADD CONSTRAINT `FK_AspNetRoleClaims_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE;

--
-- Filtros para la tabla `aspnetuserclaims`
--
ALTER TABLE `aspnetuserclaims`
  ADD CONSTRAINT `FK_AspNetUserClaims_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Filtros para la tabla `aspnetuserlogins`
--
ALTER TABLE `aspnetuserlogins`
  ADD CONSTRAINT `FK_AspNetUserLogins_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Filtros para la tabla `aspnetuserroles`
--
ALTER TABLE `aspnetuserroles`
  ADD CONSTRAINT `FK_AspNetUserRoles_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_AspNetUserRoles_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Filtros para la tabla `aspnetusertokens`
--
ALTER TABLE `aspnetusertokens`
  ADD CONSTRAINT `FK_AspNetUserTokens_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Filtros para la tabla `contratos`
--
ALTER TABLE `contratos`
  ADD CONSTRAINT `FK_Contratos_AspNetUsers_UsuarioId` FOREIGN KEY (`UsuarioId`) REFERENCES `aspnetusers` (`Id`),
  ADD CONSTRAINT `FK_Contratos_Muebles_MuebleId` FOREIGN KEY (`MuebleId`) REFERENCES `muebles` (`Id`) ON DELETE CASCADE;

--
-- Filtros para la tabla `muebles`
--
ALTER TABLE `muebles`
  ADD CONSTRAINT `FK_Muebles_Categorias_CategoriaId` FOREIGN KEY (`CategoriaId`) REFERENCES `categorias` (`Id`) ON DELETE CASCADE;

--
-- Filtros para la tabla `pedidosespeciales`
--
ALTER TABLE `pedidosespeciales`
  ADD CONSTRAINT `FK_PedidosEspeciales_AspNetUsers_UsuarioId` FOREIGN KEY (`UsuarioId`) REFERENCES `aspnetusers` (`Id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
