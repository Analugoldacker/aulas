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
values('Jogar bocha','2023-10-15','13:00:00',5, 1);

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