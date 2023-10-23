create table tb_produtos(
id int primary key auto_increment,
protodutos varchar(45),
tb_categoria_id int,
tb_fornecedor_id int,
foreign key(tb_categoria_id) references tb_categoria(id),
foreign key(tb_fornecedor_id) references tb_fornecedor(id)
);

/*drop table tb_produtos;*/

create table tb_categoria(
id int primary key auto_increment,
nome varchar(45)
);

create table tb_fornecedor(
id int primary key auto_increment,
representante varchar(45),
numerorepresentante varchar(45)
);

create table tb_itens_venda(
quantidade varchar(45),
valorUnitario varchar(45),
tb_produtos_id int not null,
tb_vendas_id int not null,
foreign key(tb_produtos_id) references tb_produtos(id),
foreign key(tb_vendas_id) references tb_vendas(id)
);

/*drop table tb_itens_venda;*/

create table tb_vendas(
id int primary key auto_increment,
dataDeVendas date,
tb_clientes_id int not null,
foreign key(tb_clientes_id) references tb_clientes(id)
);

/*drop table tb_vendas;*/

create table tb_clientes(
id int primary key auto_increment,
nome varchar(45),
telefone varchar(14)
);

create table tb_valor_a_receber(
id int primary key auto_increment,
valor decimal,
dataDeVencimento date,
valorDaParcela decimal,
tb_vendas_id int not null,
foreign key(tb_vendas_id) references tb_vendas(id)
);

create table tb_compras_produtos(
tb_compras_id int not null,
tb_produtos_id int not null,
foreign key(tb_produtos_id) references tb_produtos(id),
foreign key(tb_compras_id) references tb_compras(id)
);

create table tb_compras(
id int primary key auto_increment,
dataCompra date,
tb_fornecedor_id int not null,
foreign key(tb_fornecedor_id) references tb_fornecedor(id)
);

create table tb_contas_a_pagar(
id int primary key auto_increment,
nomeDuplicata varchar(45),
valor decimal,
parcelas decimal,
dataVencimento date,
tb_compras_id int not null,
foreign key(tb_compras_id) references tb_compras(id)
);
select * from tb_produtos;

insert into tb_produtos(tb_categoria_id,tb_fornecedor_id,produtos)
values(1,1,'Milho'),(1,2,'Trigo');
select * from tb_produtos;

insert into tb_categoria(nome)values('Cereais'),('Açougue'),('Frios');
select * from tb_categoria;




