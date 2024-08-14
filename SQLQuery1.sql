CREATE DATABASE USERS;
GO
USE users

CREATE TABLE OurUsers(
	id int primary key identity (1,1),
	email varchar (50),
	name varchar (50),
	password varchar (50),
	image varchar (max)
);
select * from OurUsers
truncate table OurUsers;
