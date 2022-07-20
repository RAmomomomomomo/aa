#날짜 : 2022/07/20
#이름 : 배석현 
#내용: 종합실습 

#5-1
CREATE DATABASE `SaleDB`;
CREATE USER 'manager'@'%' IDENTIFIED BY '1234';
GRANT ALL PRIVILEGES ON SaleDB.*TO'manager'@'%';
FLUSH PRIVILEGES; 

#5-2
CREATE TABLE `Member`(
`uid` VARCHAR(10) PRIMARY KEY,
`name` VARCHAR(10),
`hp` VARCHAR(13) UNIQUE NOT NULL	,
`pos` VARCHAR(10),
`dep` INT,
`rdate` DATETIME	

);

CREATE TABLE `Department`(
`depNo` INT PRIMARY KEY ,
`name` VARCHAR(10),
`tel` CHAR(12)
);

salesCREATE TABLE `Sales`(
`seq` INT AUTO_INCREMENT PRIMARY KEY,
`uid` VARCHAR(10) NOT NULL	,
`year` YEAR NOT NULL,
`month` TINYINT NOT NULL,
`sale` INT NOT null
	

);
#5-3
INSERT INTO `Member` VALUES('a101','박혁거세','010-1234-1001','부장',101,'2020-11-19 11:39:48');
INSERT INTO `Member` VALUES('a102','김유신','010-1234-1002','차장',101,'2020-11-19 11:39:48');
INSERT INTO `Member` VALUES('a103','김춘추','010-1234-1003','사원',101,'2020-11-19 11:39:48');
INSERT INTO `Member` VALUES('a104','장보고','010-1234-1004','대리',102,'2020-11-19 11:39:48');
INSERT INTO `Member` VALUES('a105','강감찬','010-1234-1005','과장',102,'2020-11-19 11:39:48');
INSERT INTO `Member` VALUES('a106','이성계','010-1234-1006','차장',103,'2020-11-19 11:39:48');
INSERT INTO `Member` VALUES('a107','정철','010-1234-1007','차장',103,'2020-11-19 11:39:48');
INSERT INTO `Member` VALUES('a108','이순신','010-1234-1008','부장',104,'2020-11-19 11:39:48');
INSERT INTO `Member` VALUES('a109','허균','010-1234-1009','부장',104,'2020-11-19 11:39:48');
INSERT INTO `Member` VALUES('a110','정약용','010-1234-1010','사원',105,'2020-11-19 11:39:48');
INSERT INTO `Member` VALUES('a111','박지원','010-1234-1011','사원',105,'2020-11-19 11:39:48');

INSERT INTO `Department` VALUES (101,'영업1부','051-512-1001');
INSERT INTO `Department` VALUES (102,'영업2부','051-512-1002');
INSERT INTO `Department` VALUES (103,'영업3부','051-512-1003');
INSERT INTO `Department` VALUES (104,'영업4부','051-512-1004');
INSERT INTO `Department` VALUES (105,'영업5부','051-512-1005');
INSERT INTO `Department` VALUES (106,'영업지원부','051-512-1006');
INSERT INTO `Department` VALUES (107,'인사부','051-512-1007');

INSERT INTO `Sales` (`uid`,`year`,`month`,`sale`)VALUES('a101',2018,1,98100);
INSERT INTO `Sales` (`uid`,`year`,`month`,`sale`)VALUES('a102',2018,1,136000);
INSERT INTO `Sales` (`uid`,`year`,`month`,`sale`)VALUES('a103',2018,1,80100);
INSERT INTO `Sales` (`uid`,`year`,`month`,`sale`)VALUES('a104',2018,1,78000);
INSERT INTO `Sales` (`uid`,`year`,`month`,`sale`)VALUES('a105',2018,1,93000);
INSERT INTO `Sales` (`uid`,`year`,`month`,`sale`)VALUES('a101',2018,2,23500);
INSERT INTO `Sales` (`uid`,`year`,`month`,`sale`)VALUES('a102',2018,2,126000);
INSERT INTO `Sales` (`uid`,`year`,`month`,`sale`)VALUES('a103',2018,2,18500);
INSERT INTO `Sales` (`uid`,`year`,`month`,`sale`)VALUES('a105',2018,2,19000);
INSERT INTO `Sales` (`uid`,`year`,`month`,`sale`)VALUES('a106',2018,2,53000);
INSERT INTO `Sales` (`uid`,`year`,`month`,`sale`)VALUES('a101',2019,1,24000);
INSERT INTO `Sales` (`uid`,`year`,`month`,`sale`)VALUES('a102',2019,1,109000);
INSERT INTO `Sales` (`uid`,`year`,`month`,`sale`)VALUES('a103',2019,1,101000;
INSERT INTO `Sales` (`uid`,`year`,`month`,`sale`)VALUES('a104',2019,1,43000;
INSERT INTO `Sales` (`uid`,`year`,`month`,`sale`)VALUES('a107',2019,1,24000);

#5-4

SELECT *FROM `Member` WHERE `name`='김유신';
SELECT *FROM `Member` WHERE `pos`='차장' AND dep=101;
SELECT *FROM `Member` WHERE `pos`='차장'OR dep=101;
SELECT *FROM `Member` WHERE `name`!='김춘추';
SELECT *FROM `Member` WHERE `name`<>'김춘추';
SELECT *FROM `Member` WHERE `pos`='사원' OR  `pos`='대리';
SELECT *FROM `Member` WHERE `pos`IN ('사원','대리');
SELECT *FROM `Member` WHERE `dep` IN (101,102,103);

#5-6
SELECT*FROM `sales` LIMIT 3;
SELECT*FROM `sales` LIMIT 0,3;
SELECT*FROM `sales` LIMIT 1,3;
SELECT*FROM `sales` LIMIT 4,5;
SELECT*FROM `sales` LIMIT 3;

#확인문제1
SELECT SUM(`sale`) AS`2018년 1월 매출 총합`FROM `Sales` WHERE `year`=2018 AND `month`=1;

SELECT*FROM `Sales`AS a JOIN `Member` AS b ON a.uid=b.uid;

