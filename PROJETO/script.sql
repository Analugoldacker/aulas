CREATE TABLE receita (
  id INT PRIMARY KEY NOT NULL auto_increment,
  descricao VARCHAR(45) NOT NULL
)
;

CREATE TABLE ingredientes (
id INT PRIMARY KEY NOT NULL auto_increment,
nome VARCHAR(45) NOT NULL,
descricao VARCHAR(45) NULL
)
;

CREATE TABLE receita_has_ingredientes(
receita_id INT NOT NULL,
ingredientes_id INT NOT NULL,
preparo LONGTEXT NOT NULL,
FOREIGN KEY (receita_id)
REFERENCES receita (id),
FOREIGN KEY (ingredientes_id)
REFERENCES ingredientes(id)
);

INSERT INTO ingredientes (nome, descricao) VALUES
('sal', 'grosso'),
('açúcar', 'refinado'),
('farinha de trigo', 'orgânica'),
('ovos', 'frescos'),
('leite', 'desnatado'),
('queijo', 'cheddar'),
('presunto', 'cru'),
('tomate', 'maduro'),
('cebola', 'roxa'),
('pimentão', 'verde'),
('cenoura', 'orgânica'),
('batata', 'doce'),
('alho', 'picado'),
('azeite', 'extra virgem'),
('vinagre', 'balsâmico'),
('limão', 'suculento'),
('pimenta', 'vermelha'),
('coentro', 'fresco'),
('manjericão', 'fresco'),
('gengibre', 'ralado'),
('canela', 'em pó'),
('noz-moscada', 'ralada'),
('páprica', 'defumada'),
('salsa', 'picada'),
('alecrim', 'seco'),
('cogumelos', 'portobello'),
('abacate', 'maduro'),
('morangos', 'frescos'),
('abacaxi', 'doce'),
('mel', 'puro');

select * from ingredientes;
select * from  receita;
INSERT INTO receita (descricao) VALUES
('Risoto de frango'),
('Lasanha à bolonhesa'),
('Salmão grelhado com molho de limão'),
('Salada César com frango grelhado'),
('Macarrão com pesto de manjericão'),
('Tacos de carne com guacamole'),
('Frango à parmegiana'),
('Ratatouille'),
('Sopa de abóbora com gengibre'),
('Bife de filé com molho de cogumelos'),
('Arroz frito com legumes'),
('Sushi de salmão'),
('Pizza margherita'),
('Molho de tomate caseiro'),
('Frango ao curry'),
('Feijoada brasileira'),
('Massa carbonara'),
('Bolinho de bacalhau'),
('Torta de maçã'),
('Hambúrguer caseiro'),
('Peixe grelhado com legumes'),
('Tacos de peixe com coentro e cebola roxa'),
('Costelas de porco com molho barbecue'),
('Ceviche de camarão'),
('Salada de frutas frescas'),
('Sorvete de baunilha com calda de chocolate'),
('Muffins de mirtilo'),
('Torta de chocolate'),
('Pudim de leite condensado'),
('Brownie de nozes');










