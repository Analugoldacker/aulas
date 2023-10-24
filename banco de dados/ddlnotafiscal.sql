CREATE TABLE tb_endereco(
  id INT PRIMARY KEY AUTO_INCREMENT,
  rua VARCHAR(45) NOT NULL,
  numero VARCHAR(45) NOT NULL,
  bairro VARCHAR(45) NOT NULL,
  municiopio VARCHAR(45) NOT NULL,
  estado VARCHAR(45) NOT NULL
);

CREATE TABLE tb_remetente(
  id INT PRIMARY KEY AUTO_INCREMENT,
  nome VARCHAR(45) NOT NULL,
  cnpjCpf DECIMAL(14) NOT NULL,
  telefone DECIMAL(20) NOT NULL,
  tb_vendas_id INT NOT NULL,
  tb_endereco_id INT NOT NULL,
  FOREIGN KEY (tb_vendas_id)
  REFERENCES tb_vendas(id),
  FOREIGN KEY (tb_endereco_id)
  REFERENCES tb_endereco (id)
);

CREATE TABLE tb_vendas(
  id INT PRIMARY KEY NOT NULL,
  data VARCHAR(45) NULL,
  horaSaida VARCHAR(45) NULL,
  dataSaida VARCHAR(45) NULL
  );

CREATE TABLE tb_fatura(
  id INT PRIMARY KEY NOT NULL,
  duplicata VARCHAR(45) NOT NULL,
  vencimento DATE NOT NULL,
  valor DECIMAL NOT NULL,
  tb_vendas_id INT NOT NULL,
  FOREIGN KEY (tb_vendas_id)
  REFERENCES tb_vendas (id)
  );
    
CREATE TABLE tb_produtos(
  id INT PRIMARY KEY AUTO_INCREMENT,
  descricao VARCHAR(45) NOT NULL,
  unidade VARCHAR(15) NOT NULL,
  quantidade VARCHAR(45) NOT NULL,
  valorUnitario VARCHAR(45) NOT NULL,
  valorTotal VARCHAR(45) NOT NULL
  );

CREATE TABLE tb_vendas_has_tb_produtos(
    tb_vendas_id INT NOT NULL,
    tb_produtos_id INT NOT NULL,
    FOREIGN KEY (tb_vendas_id)
    REFERENCES tb_vendas(id),
    FOREIGN KEY (tb_produtos_id)
    REFERENCES tb_produtos (id)
);


