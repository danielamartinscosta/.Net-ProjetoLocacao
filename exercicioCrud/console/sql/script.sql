CREATE TABLE produtos(
    id int NOT NULL AUTO_INCREMENT,
    nome varchar(100) NOT NULL,
    descricao varchar(250),
    data_criacao DATETIME NOT NULL,
    data_validade DATETIME NOT NULL,
    quantidade_estoque int NOT NULL,
    PRIMARY KEY (id)
);

insert into produtos(nome, descricao, data_criacao, data_validade, quantidade_estoque)values('dipirona', 'Analgésico', '2021-11-05', '2023-01-10', '30');
insert into produtos(nome, descricao, data_criacao, data_validade, quantidade_estoque)values('paracetamol', 'Analgésico e antipirético', '2021-08-01', '2025-01-10', '50');
insert into produtos(nome, descricao, data_criacao, data_validade, quantidade_estoque)values('cetoconazol', 'Antomicótico', '2021-01-04', '2023-01-01', '10');
insert into produtos(nome, descricao, data_criacao, data_validade, quantidade_estoque)values('Histamin', 'Antialérgico', '2021-12-02', '2025-01-10', '80');
insert into produtos(nome, descricao, data_criacao, data_validade, quantidade_estoque)values('Neosaldina', 'Analgésico', '2021-05-01', '2022-12-10', '5');
insert into produtos(nome, descricao, data_criacao, data_validade, quantidade_estoque)values('Aspirina', 'Anti-Inflamatório', '2021-05-05', '2023-01-01', '30');