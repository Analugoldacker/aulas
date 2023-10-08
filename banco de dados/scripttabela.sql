/*insert into tb_contatos(nome, email) values('maria','maria@gmail.com')*/

insert into tb_contatos(nome, email, fone)values ('jose','jose@gmail.com','(47)98851-1756');

insert into tb_contatos(nome, email) values ('jose','jose@gmail.com','(47)98851-1756');

/*delete from tb_contatos whwre id < 5*/

/*select * from tb_contatos;

alter table tb_contatos dorp colomn nome;

alter table tb_contatos add column nome varchar(45) not null;*/

insert into tb_locais(nome, rua, numero) values('Clube de bocha','Rua XV','200');
select * from tb_locais;

insert into tb_compromissos(descricao, data, hora, tb_contatos_id, tb_locais_id) values('Jogar bocha','2023-10-18','18:00:00',4,1)
