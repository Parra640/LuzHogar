-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 16-11-2019 a las 22:45:29
-- Versión del servidor: 10.4.8-MariaDB
-- Versión de PHP: 7.3.10

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
  `ClaimType` longtext DEFAULT NULL,
  `ClaimValue` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `aspnetroles`
--

CREATE TABLE `aspnetroles` (
  `Id` varchar(255) NOT NULL,
  `Name` varchar(256) DEFAULT NULL,
  `NormalizedName` varchar(256) DEFAULT NULL,
  `ConcurrencyStamp` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `aspnetroles`
--

INSERT INTO `aspnetroles` (`Id`, `Name`, `NormalizedName`, `ConcurrencyStamp`) VALUES
('20512fc4-14dd-4bf6-b860-eded0eef6b01', 'usuario', 'USUARIO', '03f83196-4e9a-4a33-9ec5-33a322a5da7b'),
('6eddf940-50a2-41d8-8078-357b6c13ebe7', 'admin', 'ADMIN', '083f66c3-ed93-4963-a19d-b461cc7de23a');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `aspnetuserclaims`
--

CREATE TABLE `aspnetuserclaims` (
  `Id` int(11) NOT NULL,
  `UserId` varchar(255) NOT NULL,
  `ClaimType` longtext DEFAULT NULL,
  `ClaimValue` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `aspnetuserlogins`
--

CREATE TABLE `aspnetuserlogins` (
  `LoginProvider` varchar(255) NOT NULL,
  `ProviderKey` varchar(255) NOT NULL,
  `ProviderDisplayName` longtext DEFAULT NULL,
  `UserId` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `aspnetuserroles`
--

CREATE TABLE `aspnetuserroles` (
  `UserId` varchar(255) NOT NULL,
  `RoleId` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `aspnetuserroles`
--

INSERT INTO `aspnetuserroles` (`UserId`, `RoleId`) VALUES
('f03c77bc-a505-4150-89c9-1dd9813fb7ff', '20512fc4-14dd-4bf6-b860-eded0eef6b01');

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
  `PasswordHash` longtext DEFAULT NULL,
  `SecurityStamp` longtext DEFAULT NULL,
  `ConcurrencyStamp` longtext DEFAULT NULL,
  `PhoneNumber` longtext DEFAULT NULL,
  `PhoneNumberConfirmed` bit(1) NOT NULL,
  `TwoFactorEnabled` bit(1) NOT NULL,
  `LockoutEnd` datetime(6) DEFAULT NULL,
  `LockoutEnabled` bit(1) NOT NULL,
  `AccessFailedCount` int(11) NOT NULL,
  `Discriminator` longtext NOT NULL,
  `Nombre` longtext DEFAULT NULL,
  `ApePaterno` longtext DEFAULT NULL,
  `ApeMaterno` longtext DEFAULT NULL,
  `Direccion` longtext DEFAULT NULL,
  `Referencia` longtext DEFAULT NULL,
  `Telefono` longtext DEFAULT NULL,
  `Dni` longtext DEFAULT NULL,
  `Correo` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `aspnetusers`
--

INSERT INTO `aspnetusers` (`Id`, `UserName`, `NormalizedUserName`, `Email`, `NormalizedEmail`, `EmailConfirmed`, `PasswordHash`, `SecurityStamp`, `ConcurrencyStamp`, `PhoneNumber`, `PhoneNumberConfirmed`, `TwoFactorEnabled`, `LockoutEnd`, `LockoutEnabled`, `AccessFailedCount`, `Discriminator`, `Nombre`, `ApePaterno`, `ApeMaterno`, `Direccion`, `Referencia`, `Telefono`, `Dni`, `Correo`) VALUES
('f03c77bc-a505-4150-89c9-1dd9813fb7ff', 'admin@hotmail.com', 'ADMIN@HOTMAIL.COM', NULL, NULL, b'0', 'AQAAAAEAACcQAAAAEJBSHaUlDstyJptHI66Y+FyPJlcSrL8dK0yti3Kh8Bm/BKphDSzf1nFKsjaHTX2kOA==', 'JTDFETWWC7SCKR3NVKELES43PWKGB3R7', 'ba84b2cc-b82e-4f49-aa71-4d2441eccbab', NULL, b'0', b'0', NULL, b'1', 0, 'Usuario', 'Adela', 'Otayza', 'Grados', 'kaskam', 'kskm', 'dd', 'jjjjjj', 'admin@hotmail.com');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `aspnetusertokens`
--

CREATE TABLE `aspnetusertokens` (
  `UserId` varchar(255) NOT NULL,
  `LoginProvider` varchar(255) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `Value` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `contratos`
--

CREATE TABLE `contratos` (
  `Id` int(11) NOT NULL,
  `UsuarioId` int(11) NOT NULL DEFAULT 0,
  `MuebleId` int(11) NOT NULL,
  `Progreso` longtext DEFAULT NULL,
  `Cantidad` int(11) NOT NULL,
  `UsuarioId1` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `muebles`
--

CREATE TABLE `muebles` (
  `Id` int(11) NOT NULL,
  `Nombre` longtext DEFAULT NULL,
  `Color` longtext DEFAULT NULL,
  `Descripcion` longtext DEFAULT NULL,
  `Precio` float NOT NULL,
  `Stock` int(11) NOT NULL,
  `Foto` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pedidosespeciales`
--

CREATE TABLE `pedidosespeciales` (
  `Id` int(11) NOT NULL,
  `Nombre` longtext DEFAULT NULL,
  `Color` longtext DEFAULT NULL,
  `Descripcion` longtext DEFAULT NULL,
  `Precio` float NOT NULL,
  `Cantidad` int(11) NOT NULL,
  `Foto` longtext DEFAULT NULL,
  `UsuarioId1` varchar(255) DEFAULT NULL,
  `UsuarioId` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `__efmigrationshistory`
--

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(95) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `__efmigrationshistory`
--

INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
('20191109213228_BDInicial', '2.2.6-servicing-10079'),
('20191113051909_agregandoTablas', '2.2.6-servicing-10079'),
('20191113052742_ModificandoUsuario', '2.2.6-servicing-10079'),
('20191113192940_creacionadmi', '2.2.6-servicing-10079');

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
-- Indices de la tabla `contratos`
--
ALTER TABLE `contratos`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_Contratos_MuebleId` (`MuebleId`),
  ADD KEY `IX_Contratos_UsuarioId1` (`UsuarioId1`);

--
-- Indices de la tabla `muebles`
--
ALTER TABLE `muebles`
  ADD PRIMARY KEY (`Id`);

--
-- Indices de la tabla `pedidosespeciales`
--
ALTER TABLE `pedidosespeciales`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_PedidosEspeciales_UsuarioId1` (`UsuarioId1`);

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
-- AUTO_INCREMENT de la tabla `contratos`
--
ALTER TABLE `contratos`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `muebles`
--
ALTER TABLE `muebles`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `pedidosespeciales`
--
ALTER TABLE `pedidosespeciales`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

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
  ADD CONSTRAINT `FK_Contratos_AspNetUsers_UsuarioId1` FOREIGN KEY (`UsuarioId1`) REFERENCES `aspnetusers` (`Id`),
  ADD CONSTRAINT `FK_Contratos_Muebles_MuebleId` FOREIGN KEY (`MuebleId`) REFERENCES `muebles` (`Id`) ON DELETE CASCADE;

--
-- Filtros para la tabla `pedidosespeciales`
--
ALTER TABLE `pedidosespeciales`
  ADD CONSTRAINT `FK_PedidosEspeciales_AspNetUsers_UsuarioId1` FOREIGN KEY (`UsuarioId1`) REFERENCES `aspnetusers` (`Id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
