CREATE DATABASE farmacia;

USE farmacia;

CREATE TABLE produtos (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100),
    fabricante VARCHAR(100),
    preco DECIMAL(10,2),
    estoque INT
);
