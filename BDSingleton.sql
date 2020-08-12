/*
SQLyog Ultimate v11.11 (64 bit)
MySQL - 5.7.17-log : Database - bdsingleton
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`bdsingleton` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `bdsingleton`;

/*Table structure for table `tbldetallesprods` */

DROP TABLE IF EXISTS `tbldetallesprods`;

CREATE TABLE `tbldetallesprods` (
  `iddetalle` int(11) NOT NULL AUTO_INCREMENT,
  `preciocompra` float DEFAULT NULL,
  `precioventa` float DEFAULT NULL,
  `stockprod` int(11) DEFAULT NULL,
  `gananciaprod` float DEFAULT NULL,
  `idprod` int(11) DEFAULT NULL,
  PRIMARY KEY (`iddetalle`),
  KEY `fk_prod` (`idprod`),
  CONSTRAINT `fk_prod` FOREIGN KEY (`idprod`) REFERENCES `tblproductos` (`idprod`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

/*Data for the table `tbldetallesprods` */

insert  into `tbldetallesprods`(`iddetalle`,`preciocompra`,`precioventa`,`stockprod`,`gananciaprod`,`idprod`) values (1,6,12,80,6,1);

/*Table structure for table `tblproductos` */

DROP TABLE IF EXISTS `tblproductos`;

CREATE TABLE `tblproductos` (
  `idprod` int(11) NOT NULL AUTO_INCREMENT,
  `nombreprod` varchar(50) DEFAULT NULL,
  `tipoprod` varchar(50) DEFAULT NULL,
  `proveedorprod` varchar(50) DEFAULT NULL,
  `marcaprod` varchar(50) DEFAULT NULL,
  `codprod` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`idprod`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

/*Data for the table `tblproductos` */

insert  into `tblproductos`(`idprod`,`nombreprod`,`tipoprod`,`proveedorprod`,`marcaprod`,`codprod`) values (1,'Soda','Bebidas','Coca cola company','Coca cola','co0121'),(2,'Cafe','Bebidas','Nescafe Company','Nescafe','ne0121'),(3,'Leche','Lacteo','Lala','Lala','le0102');

/* Procedure structure for procedure `spAllDetails` */

/*!50003 DROP PROCEDURE IF EXISTS  `spAllDetails` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `spAllDetails`(
	op varchar(50),
	pc float,
	pv float,
	stock int,
	ganancia float,
	idp int,
	id int
    )
BEGIN
	IF op="insert" THEN
		INSERT INTO `tbldetallesprods`(`preciocompra`, `precioventa`, `stockprod`, `gananciaprod`, `idprod`) values(pc, pv, stock, ganancia, idp);
		ELSE IF op="update" THEN
			UPDATE `tbldetallesprods` set `preciocompra`=pc, `precioventa`=pv, `stockprod`=stock, `gananciaprod`=ganancia, `idprod`=idp where `iddetalle`=id;
			ELSE IF op="select" THEN
				SELECT * FROM `tbldetallesprods`;
				ELSE IF op="delete" THEN
					DELETE FROM `tbldetallesprods` where `iddetalle`=id;
				END IF;
			END IF;
		END IF;
	END IF;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `spAllProds` */

/*!50003 DROP PROCEDURE IF EXISTS  `spAllProds` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `spAllProds`(
	op varchar(50),
	nom varchar(50),
	tipo varchar(50),
	prov varchar(50),
	marca varchar(50),
	cod varchar(50),
	id int
    )
BEGIN
	IF op="insert" THEN
		insert into `tblproductos`(`nombreprod`, `tipoprod`, `proveedorprod`, `marcaprod`, `codprod`) values(nom, tipo, prov, marca, cod);
		ELSE IF op="update" THEN
			update `tblproductos` set`nombreprod`=nom, `tipoprod`=tipo, `proveedorprod`=prov, `marcaprod`=marca, `codprod`=cod where `idprod`=id;
			ELSE IF op="select" THEN
				SELECT * FROM `tblproductos`;
				else if op="delete" then
					Delete from `tblproductos` where `idprod`=id;
				end if;
			end if;
		end if;
	END IF;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `spList` */

/*!50003 DROP PROCEDURE IF EXISTS  `spList` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `spList`(
	op varchar(20)
    )
BEGIN
	IF op="prods" THEN
		SELECT `idprod` AS ID, `nombreprod` AS Producto, `tipoprod` AS Tipo, `proveedorprod` AS Proveedor, `marcaprod` AS Marca, `codprod` AS Codigo FROM `tblproductos`;
		ELSE IF op="detalles" THEN
			SELECT `iddetalle` AS ID, `preciocompra` AS 'Precio compra', `precioventa` AS 'Precio venta', `stockprod` AS Stock, `gananciaprod` AS 'Ganancia producto', `nombreprod` AS Producto FROM `tbldetallesprods` INNER JOIN `tblproductos` ON `tblproductos`.`idprod`=`tbldetallesprods`.`idprod`;
		END IF;
	END IF;
    END */$$
DELIMITER ;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
