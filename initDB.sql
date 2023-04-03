CREATE DATABASE IF NOT EXISTS keyman;

CREATE TABLE IF NOT EXISTS `keyman`.`ranklist` (
  `id` 		int(10) unsigned NOT NULL AUTO_INCREMENT,
  `clas` 	varchar(100) NOT NULL,
  `name` 	varchar(5)	 NOT NULL,
  `level` varchar(10)	 NOT NULL,
  `score` int(40)			 NOT NULL,
  `date` 	varchar(20)	 NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;