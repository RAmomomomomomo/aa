#날짜 : 2022/07/19
#이름 : 배석현
#내용 : SQL확인문제

#4-1
CREATE TABLE `Tbl_member`
(
`memberID` VARCHAR(10) PRIMARY KEY ,
`memberName` VARCHAR(10),
`memberHP` CHAR(13)UNIQUE,
`memberAge` INT, 
`memberAddr`VARCHAR(20)
);

DROP TABLE `Tbl_member`;

INSERT INTO `Tbl_member` VALUES('p101','김유신','010-1234-1001',25,'신라');
INSERT INTO `Tbl_member` VALUES('p102','김춘추','010-1234-1002',25,'신라');
INSERT INTO `Tbl_member` VALUES('p103','장보고',NULL ,25,'통일신라');
INSERT INTO `Tbl_member` VALUES('p104','강감찬',NULL ,NULL,'고려');
INSERT INTO `Tbl_member` VALUES('p105','이순신','010-1234-1005',25,NULL);

userdbCREATE TABLE `Tbl_product`
(
`productCode` INT AUTO_INCREMENT PRIMARY KEY ,
`productName` VARCHAR(10),
`price` INT ,
`amount` INT , 
`company`VARCHAR(10),
`makeDate`DATE	
);


INSERT INTO `Tbl_product` VALUES(NULL,'냉장고',800,10,'LG','2022-01-06');
INSERT INTO `Tbl_product` VALUES(NULL,'노트북',1200,20,'삼성','2022-01-06');
INSERT INTO `Tbl_product` VALUES(NULL,'TV',1400,6,'LG','2022-01-06');
INSERT INTO `Tbl_product` VALUES(NULL,'세탁기',1000 ,8,'LG','2022-01-06');
INSERT INTO `Tbl_product` VALUES(NULL,'컴퓨터',1100,0,NULL,'2022-01-06');
INSERT INTO `Tbl_product` VALUES(NULL,'휴대폰',900,102,'삼성','2022-01-06');