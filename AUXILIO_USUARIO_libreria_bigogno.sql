-- MySQL Administrator dump 1.4
--
-- ------------------------------------------------------
-- Server version	5.5.19


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


--
-- Create schema libreria_bigogno
--

CREATE DATABASE IF NOT EXISTS libreria_bigogno;
USE libreria_bigogno;


--
-- Definition of table `articulo`
--

--
-- Definition of table `misdatos`
--

DROP TABLE IF EXISTS `misdatos`;
CREATE TABLE `misdatos` (
  `RazonSocial` varchar(45) NOT NULL,
  `Direccion` varchar(45) DEFAULT NULL,
  `Ciudad` varchar(45) DEFAULT NULL,
  `Telefono` varchar(45) DEFAULT NULL,
  `Email` varchar(45) DEFAULT NULL,
  `Cuit` varchar(13) DEFAULT NULL,
  PRIMARY KEY (`RazonSocial`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `misdatos`
--

/*!40000 ALTER TABLE `misdatos` DISABLE KEYS */;
INSERT INTO `misdatos` (`RazonSocial`,`Direccion`,`Ciudad`,`Telefono`,`Email`,`Cuit`) VALUES 
 ('MI_Comercio','calle 2 n° 100','Mercedes','2324- 400000','micorreo@gmail.com','22-20123456-9');
/*!40000 ALTER TABLE `misdatos` ENABLE KEYS */;



--
-- Definition of table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
CREATE TABLE `usuario` (
  `usuario` varchar(45) NOT NULL,
  `clave` varchar(45) NOT NULL,
  PRIMARY KEY (`usuario`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `usuario`
--

/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` (`usuario`,`clave`) VALUES 
 ('1','1'),
 ('Admin','admin'),
 ('Vendedor','1234');
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;




/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
