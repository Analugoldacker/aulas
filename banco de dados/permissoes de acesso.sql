/*select * from mysql.user;

show grants for root@localhost;

create user dba@localhost identified by '123456';

drop user dba;

grant all on vendas.* to dba@localhost;*/

/*create user gerente@localhost identified by '123456';

grant select on vendas.tb_categorias to gerente@localhost*/

/*conceder privilegio*/

grant select on vendas.tb_categorias to gerente@localhost;

/*retira/revoga*/
revoke select on vendas.tb_categorias from gerente@localhost;

/*criar usuario operador e conceder a ele permissao paqra inserir, alterar, e consultar tabela de produto*/

create user ana@localhost identified by '123456';

grant select on vendas.tb_produtos to ana@localhost;

grant insert, update on vendas.tb_produtos to ana@localhost;

show grants for ana@localhost;

select * from mysql.user





