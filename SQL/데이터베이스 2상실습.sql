CREATE DATABASE `OrderDB`;
CREATE USER 'master'@'%'IDENTIFIED BY '1234';
GRANT ALL PRIVILEGES ON OrderDB.*TO 'master';
FLUSH PRIVILEGES;orderdb


CREATE TABLE `Customer`
(
`custld` VARCHAR(10) NOT NULL PRIMARY KEY ,
`name` VARCHAR(10)NOT NULL,
`hp` CHAR(13) UNIQUE,
`addr` VARCHAR(100),
`rdate` DATE NOT NULL 

);

CREATE TABLE `Product`
(
`prodNo` INT  PRIMARY KEY AUTO_INCREMENT ,
`prodName` VARCHAR(10)NOT NULL,
`stock` INT NOT NULL DEFAULT 0 ,
`price` INT DEFAULT NULL ,
`company` VARCHAR(20) NOT NULL 

);

CREATE TABLE `Order`
(
`orderNo` INT  NOT NULL PRIMARY KEY ,
`orderld` VARCHAR(10)NOT NULL,
`orderProduct` INT NOT NULL,
`orderCount` INT NOT NULL DEFAULT 1 ,
`orderDate` DATE NOT NULL 

);

INSERT INTO `Customer` VALUES ('heoj','허준',NULL,NULL,'2022-01-07');
INSERT INTO `Customer` VALUES ('jang','장보고','010-1234-1003','완도군 청상면','2022-01-03');
INSERT INTO `Customer` VALUES ('jeongc','정철','010-1234-1006','경기도 용인시','2022-01-06');
INSERT INTO `Customer` VALUES ('jeongyy','정약용','010-1234-1010','경기도 광주시','2022-01-10');
INSERT INTO `Customer` VALUES ('kang','강감찬','010-1234-1004','서울시 마포구 ','2022-01-04');
INSERT INTO `Customer` (`custld`,`name`,`hp`,`addr`,`rdate`) VALUES ('kimcc','김춘추','010-1234-1002','경주시 보문동','2022-01-02');
INSERT INTO `Customer` (`custld`,`name`,`hp`,`addr`,`rdate`) VALUES ('kimys','김유신','010-1234-1001','김해시 봉황동','2022-01-01');
INSERT INTO `Customer` (`custld`,`name`,`hp`,`addr`,`rdate`) VALUES ('leesg','이성계',NULL ,NULL ,'2022-01-05');
INSERT INTO `Customer` (`custld`,`name`,`hp`,`addr`,`rdate`) VALUES ('leess','이순신','010-1234-1008','서울시 영등포구','2022-01-08');
INSERT INTO `Customer` (`custld`,`name`,`hp`,`addr`,`rdate`) VALUES ('songsh','송상현','010-1234-1009','부산시 동래구 ','2022-01-09');


INSERT INTO `Product` VALUES (NULL,'새우깡',5000,1500,'농심');
INSERT INTO `Product` VALUES (NULL,'초코파이',2500,2500,'오리온');
INSERT INTO `Product` VALUES (NULL,'포카칩',3600,1700,'오리온');
INSERT INTO `Product` VALUES (NULL,'양파링',1250,1800,'농심');
INSERT INTO `Product` VALUES (NULL,'죠리퐁',2200,NULL,'크라운');
INSERT INTO `Product` VALUES (NULL,'마카렛트',3500,3500,'롯데');
INSERT INTO `Product` VALUES (NULL,'뿌셔뿌셔',1650,1200,'오뚜기');
