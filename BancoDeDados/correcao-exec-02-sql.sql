CREATE TABLE cliente (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL,
    idade INT NOT NULL,
    cidade VARCHAR(50) NOT NULL,
    saldo NUMERIC(10 , 2 ) NOT NULL
);

INSERT INTO cliente
(nome, idade, cidade, saldo)
VALUES
('Carlos', 45, 'São Paulo', 2500.00),
('Mariana', 32, 'Rio de Janeiro', 3200.50),
('Pedro', 27, 'Belo Horizonte', 1500.75),
('Fernanda', 38, 'Curitiba', 4200.00);

SELECT 
    *
FROM
    cliente
WHERE
    cidade = 'Rio de Janeiro';
    
SELECT 
    *
FROM
    cliente
WHERE
    saldo > 2000
ORDER BY saldo DESC;

SELECT 
    nome, idade
FROM
    cliente
WHERE
    idade > 30;
    
SELECT 
    *
FROM
    cliente
WHERE
    idade BETWEEN 25 AND 40;
    
SELECT 
    *
FROM
    cliente
WHERE
    nome LIKE 'f%';
    
SELECT 
    *
FROM
    cliente
WHERE
    cidade <> 'São Paulo'
        AND cidade <> 'Curitiba';
        
CREATE TABLE pedido (
    id INT PRIMARY KEY AUTO_INCREMENT,
    cliente_id INT NOT NULL,
    valor NUMERIC(10 , 2 ) NOT NULL,
    data_pedido DATE NOT NULL,
    FOREIGN KEY (cliente_id)
        REFERENCES cliente (id)
);

INSERT INTO pedido
(cliente_id, valor, data_pedido)
VALUES
(1, 500, '2024-03-10'),
(2, 1200, '2024-03-12'),
(3, 300.50, '2024-03-15'),
(1, 800, '2024-03-18');

SELECT 
    COUNT(id)
FROM
    pedido;
    
SELECT 
    AVG(valor)
FROM
    pedido;
    
SELECT 
    c.nome, SUM(p.valor) as Total
FROM
    cliente c
        INNER JOIN
    pedido p ON c.id = p.cliente_id
GROUP BY p.cliente_id;

SELECT 
    p.*, c.nome
FROM
    pedido p
        JOIN
    cliente c ON p.cliente_id = c.id;
    
SELECT 
    *
FROM
    cliente c
        LEFT JOIN
    pedido p ON c.id = p.cliente_id;
    
    SELECT 
    c.nome AS cliente, p.valor
FROM
    cliente c
        JOIN
    pedido p ON c.id = p.cliente_id
WHERE
    p.valor > (SELECT 
            AVG(valor)
        FROM
            pedido);
            
	SELECT 
    c.nome
FROM
    cliente c
        JOIN
    pedido p ON c.id = p.cliente_id
WHERE
    p.id IN (SELECT 
            id
        FROM
            pedido
        WHERE
            valor > 1000);
            
INSERT INTO cliente
(nome, idade, cidade, saldo)
VALUES
('Rafael', 62, 'Porto Alegre', 2500.00);

UPDATE cliente 
SET 
    saldo = saldo * 1.1;
    
DELETE FROM pedido 
WHERE
    valor < 500;