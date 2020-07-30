-- MySQL Workbench Synchronization
-- Generated: 2020-07-30 08:22
-- Model: New Model
-- Version: 1.0
-- Project: Name of the project
-- Author: abraa

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

ALTER TABLE `monitorasus`.`empresaexame` 
ADD INDEX `INDEX_CNES` (`cnes` ASC) ;
;

ALTER TABLE `monitorasus`.`exame` 
DROP INDEX `fk_exame_municipio1_idx` ,
ADD INDEX `fk_exame_municipio1_idx` (`idMunicipio` ASC),
ADD INDEX `fk_exame_CodigoColeta` (`codigoColeta` ASC);
;

ALTER TABLE `monitorasus`.`pessoa` 
ADD INDEX `INDEX_CNS` (`cns` ASC);
;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
