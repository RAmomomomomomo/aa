#날짜 : 2022/07/19
#이름 : 배석현
#내용 : 데이터 베이스 관리

#실습하기 3-1
CREATE DATABASE `tigerDB`;
CREATE USER `tiger`@`%`IDENTIFIED BY '1234';
GRANT ALL PRIVILEGES ON tigerDB.*TO'tiger'@'%';
FLUSH PRIVILEGES;

#실습하기 3-2
SET PASSWORD FOR 'tiger'@'%'=PASSWORD('12345');
userDROP USER 'tiger'@'%';
#실습하기 3-3
CREATE DATABASE`UserDB`;