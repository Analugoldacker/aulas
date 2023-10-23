create table tb_clientes(
  id int primary key auto_increment,
  nome varchar(45)
);

 create table tb_vendas(
    id int primary key auto_increment,
    data date,
    status char default 'A',
    tb_clientes_id int,
    foreign key(tb_clientes_id) references tb_clientes(id)
 );

create table tb_categorias(
 id int primary key auto_increment,
 nome varchar(20)
 );
 
 create table tb_produtos(
    id int primary key auto_increment,
    descricao varchar(45),
    valorUnitario decimal(8,2),
    estoque decimal(8,2),
    tb_categorias_id int,
    foreign key(tb_categorias_id) references tb_categorias(id)    
 );
 
 create table tb_itens_venda(
     tb_vendas_id int,
     tb_produtos_id int,
     quantidade decimal(8,2),
     preco decimal(8,2),
     foreign key(tb_vendas_id) references tb_vendas(id),
     foreign key(tb_produtos_id) references tb_produtos(id)
 );
 

 insert into tb_categorias(nome)values('Cereais'),('Açougue'),('Frios');
select * from tb_categorias;

insert into tb_produtos(descricao, valorUnitario, estoque, tb_categorias_id)
values('Milho',10.55, 10, 1),('Trigo',7.50, 30, 1);

insert into tb_produtos(descricao, valorUnitario, estoque, tb_categorias_id)
values('Alcatra', 22.99, 2, 2),('Costela',19.50, 5, 2);

insert into tb_produtos(descricao, valorUnitario, estoque, tb_categorias_id)
values('Queijo',14.79, 2, 3),('Nata',3.50, 30, 3);

insert into tb_produtos(descricao, valorUnitario, estoque, tb_categorias_id)
values('Manteiga',4.79, 2, 3),('Iogurte',1.99, 30, 3);
select * from tb_produtos;

insert into tb_clientes(nome)values('Maria'),('Jose');
select * from tb_clientes;

insert into tb_vendas(data, tb_clientes_id)values('2023-09-10',1),('2023-10-10',1);
insert into tb_vendas(data, tb_clientes_id)values('2023-08-10',1),('2023-08-30',2);
/*insert into tb_vendas(data, tb_clientes_id)values('2023-07-10',1),('2023-07-310',1);*/

select * from tb_vendas;

insert into tb_itens_venda(tb_vendas_id,tb_produtos_id,quantidade, preco)
values(1,1,2,10.55),(1,2,1,7.50);

insert into tb_itens_venda(tb_vendas_id,tb_produtos_id,quantidade, preco)
values(2,1,2,10.55),(2,2,1,7.50),(2,3,3,22.99);

insert into tb_itens_venda(tb_vendas_id,tb_produtos_id,quantidade, preco)
values(3,1,2,10.55),(3,2,1,7.50);

insert into tb_itens_venda(tb_vendas_id,tb_produtos_id,quantidade, preco)
values(4,1,2,10.55),(4,2,1,7.50),(4,3,3,22.99);

select * from tb_itens_venda;

/**/

select min(valorUnitario) from tb_produtos; /*menor valor tabela*/

select max(valorUnitario) from tb_produtos; /*maior valor tabela*/

select count(*) from tb_produtos; /*numeros de cadastros*/

select sum(estoque) from tb_produtos;  /*soma total de uma coluna numérica.*/

select avg(estoque) from tb_produtos; /*valor médio de uma coluna numérica.*/

select (sum(estoque)/count(*)) from tb_produtos;

select * from tb_produtos
where estoque = 2; /*o que tem o numero*/

select * from tb_produtos
where descricao like "%a%"; /*procura coisas com a letra A no meio*/

select * from tb_produtos
where descricao = "Nata"; /*procura o que ta entre "aspas"*/

select * from tb_produtos
where descricao like "m%a"; /*procura o que esta no meio e no final*/

/*cupom fiscal*/

select tp.id, tp.descricao, ti.quantidade,
ti.preco, (ti.quantidade * ti.preco) as Subtotal
from tb_itens_venda ti 
inner join tb_produtos tp on tp.id = ti.tb_produtos_id
where ti.tb_vendas_id = 9; /*inner join serve para unir duas tabelas*/

/*select tp.id, tp.descricao, ti.quantidade,
ti.preco, (ti.quantidade * ti.preco) as Subtotal
from tb_itens_venda ti, tb_produtos tp 
where tp.id = ti.tb_produtos_id
and ti.tb_vendas_id = 9; maneira diferente */


select valorUnitario from tb_produtos 
where id =1;

insert into tb_itens_venda
(tb_vendas_id, tb_produtos_id, quantidade, preco) 
values (9,1,2,(select valorUnitario from tb_produtos where id =1));
/**/
select tp.id, tp.descricao, tc.nome as Categoria, ti.quantidade,
ti.preco, (ti.quantidade * ti.preco) as Subtotal
from tb_itens_venda ti 
inner join tb_produtos tp on tp.id = ti.tb_produtos_id
inner join tb_categorias tc on tc.id = tp.tb_categorias_id
where ti.tb_vendas_id = 9;

select * from tb_vendas
where data between '2023-07-01' and '2023-08-30'; /*pesquisar por data*/

select *from tb_produtos
where tb_categorias_id not in(1) /*mostra menos a categoria 1*/
/*where tb_categorias_id in (2,3)*/ /*maneiras de mostrar 2,3*/
/*where tb_categorias_id between 2 and 4*/ /*maneira de mostrar 2,4*/
/*where tb_categorias_id > 2 tb_categorias < 4*/ /*aparecer a categoria*/





