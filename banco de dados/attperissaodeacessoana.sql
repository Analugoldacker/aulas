/*ana*/

show databases;

use vendas;

show tables;

select * from tb_produtos;

insert into tb_produtos(descricao,valorUnitario, estoque,tb_categorias_id)values('torta',1,1,1);

update tb_produtos set descricao = 'torta' where id = 9;

delete from tb_produtos where id = 9;/*nao tem permisao para deletar,nao ira deletar*/

show grants for ana@localhost;

