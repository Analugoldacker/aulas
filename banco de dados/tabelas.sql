/*create table tb_contatos(
  id int primary key auto_increment,
  nome varchar(45) not null,
  email varchar(45),
  fone varchar(14)
)*/
 drop table tb_contatos;
 
 /*create table tb_contatos(
  id int not null auto_increment,
  nome varchar(45) not null,
  email varchar(45),
  fone varchar(14),
  primary key(id) 
)*/

create table tb_contatos(
  id int not null,
  nome varchar(45) not null,
  email varchar(45),
  fone varchar(14)
);

alter table tb_contatos add constraint pk primary key(id)PRIMARY


/*create table tb_locais(
  id int primary key auto_increment,
  nome varchar(45) not null,
  rua varchar(45),
  numero int
)*/

/*create table tb_compromissos(
   id int primary key auto_increment,
   descricao varchar(100) not null,
   data date not null,
   hora time not null
)*/
/*
alter table tb_compromissos
 add column tb_contatos_id int;
 
alter table tb_compromissos 
add constraint fk_contatos
foreign key(tb_contatos_id)
references tb_contatos(id);*/

/*drop table tb_compromissos*/

/*create table tb_compromissos(
   id int primary key auto_increment,
   descricao varchar(100) not null,
   data date not null,
   hora time not null,
   tb_contatos_id int not null,
   tb_locais_id int not null,
   foreign key(tb_contatos_id) references tb_contatos(id),
   foreign key(tb_locais_id) references tb_locais(id)
)
*/

/*drop table tb_contatos*/
/*alter table tb_compromissos 
drop constraint tb_compromissos_ibfk_1;

alter table tb_compromissos 
drop column tb_contatos_id;

drop table tb_contatos;*/


/*drop table tb_compromissos*/

create table tb_compromissos(
   id int primary key auto_increment,
   descricao varchar(100) not null,
   data date not null,
   hora time not null,
   tb_contatos_id int not null,
   tb_locais_id int not null,
   foreign key(tb_contatos_id) references tb_contatos(id),
   foreign key(tb_locais_id) references tb_locais(id)
)

/*insert into tb_contatos(nome, email)
values('maria','maria@gmail.com')*/
insert into tb_contatos(nome, email, fone)
values('jose','jose@gmail.com','(47)98851-1756');

insert into tb_contatos(email, fone)
values('jose@gmail.com','(47)98851-1756');

/*delete from tb_contatos where id < 5*/

/*select * from tb_contatos;

alter table tb_contatos drop column nome;

alter table tb_contatos 
add column nome varchar(45) not null;*/

insert into tb_locais(nome, rua, numero)
values('Clube de bocha','Rua XV', 200);
select * from tb_locais;

insert into tb_compromissos
(descricao, data, hora,tb_contatos_id, tb_locais_id)
values('Jogar bocha','2023-10-18','18:00:00',4,1) 


/*CREATE TABLE books (
    id INT AUTO_INCREMENT PRIMARY KEY,
    title VARCHAR(255) NOT NULL
) */

/*DELIMITER $$
CREATE PROCEDURE load_book_data(IN num INT(4))
BEGIN
	DECLARE counter INT(4) DEFAULT 0;
	DECLARE book_title VARCHAR(255) DEFAULT '';

	WHILE counter < num DO
	  SET book_title = CONCAT('Book title #',counter);
	  SET counter = counter + 1;

	  INSERT INTO books(title)
	  VALUES(book_title);
	END WHILE;
END$$

DELIMITER ;
*/

CALL load_book_data(100);

/* delete remove todos os campos mas não reseta o auto_increment*/
delete from books where id < 2000;

SELECT * FROM books;
/*Truncate reseta a coluna auto_increment*/
truncate books;

/*another way to reset auto_increment*/
alter table books auto_increment = 1

/*insert into tb_contatos(nome, email)values('maria','maria@gmail.com');

select * from tb_contatos;

update tb_contatos set
fone = '(47)9087-0987',
nome = 'Maria das Dores'
where id = 2*/
/*
insert into tb_locais(nome, rua)values('Pesqueiro','rua vii');
select * from tb_locais*/

/*insert into tb_compromissos
(descricao, data, hora, tb_contatos_id, tb_locais_id)
values('Jogar bocha','2023-10-15','13:00:00',1, 1),
('Pescar','2023-10-05','13:00:00',2, 1)*/

/*insert into tb_compromissos
(descricao, data, hora, tb_contatos_id, tb_locais_id)
values('Jogar bocha','2023-10-15','13:00:00',1, 1);

insert into tb_compromissos
(descricao, data, hora, tb_contatos_id, tb_locais_id)
values('Pescar','2023-10-05','13:00:00',2, 1);

select * from tb_compromissos*/
/*
select tb_compromissos.id, descricao, data, hora, nome
from tb_compromissos, tb_contatos
where tb_compromissos.tb_contatos_id = tb_contatos.id
*/

/*select tb_comp.id, descricao as Descrição, data, hora, nome as Contato
from tb_compromissos tb_comp, tb_contatos tc
where tb_comp.tb_contatos_id = tc.id
*/
select tb_comp.id, descricao as Descrição, data, hora, nome as Contato
from tb_compromissos tb_comp
inner join tb_contatos tc on tb_comp.tb_contatos_id = tc.id
where tb_comp.tb_contatos_id = 2