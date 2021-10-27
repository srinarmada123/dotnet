sql queries

create database project_sm

use project_sm

create table register(id int primary key identity(1,1),firstname varchar(20),lastname varchar(20),dateofbirth date,emailorphone varchar(50),password varchar(20),isactive bit default 1) 

select * from register

alter table register alter column dateofbirth varchar(20)


select * from register
