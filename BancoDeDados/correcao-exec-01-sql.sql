CREATE TABLE empregado (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL,
    idade INT NOT NULL,
    departamento VARCHAR(50) NOT NULL,
    salario INT NOT NULL
);

INSERT INTO empregado (nome, idade, salario, departamento) VALUES
('João', 30, 50000, 'RH'),
('Sarah', 28, 60000, 'TI'),
('Miguel', 35, 55000, 'Vendas'),
('Ana', 27, 62000, 'TI');

INSERT INTO empregado (nome, idade, salario, departamento) VALUES
('Paulo', 59, 75000, 'Vendas');

SELECT 
    *
FROM
    empregado
WHERE
	departamento = 'TI';
    
SELECT 
    nome, salario
FROM
    empregado
WHERE
    salario > 55000;

SELECT 
    *
FROM
    empregado
ORDER BY idade DESC;

SELECT 
    *
FROM
    empregado
WHERE
    idade BETWEEN 28 AND 35;
    
SELECT 
    *
FROM
    empregado
WHERE
    nome LIKE 'm%';
    
SELECT 
    *
FROM
    empregado
WHERE
    departamento <> 'rh';
    
SELECT 
    departamento,
    COUNT(id)
FROM
    empregado
GROUP BY departamento;

SELECT 
    AVG(salario)
FROM
    empregado
WHERE
    departamento = 'TI';
    
SELECT 
    SUM(salario)
FROM
    empregado
WHERE
    departamento = 'Vendas';

DROP TABLE empregado;

CREATE TABLE departamento (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL
);

CREATE TABLE empregado (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL,
    idade INT NOT NULL,
    id_departamento INT NOT NULL,
    salario INT NOT NULL,
    FOREIGN KEY (id_departamento)
        REFERENCES departamento (id)
);

INSERT INTO departamento (nome)
VALUES ('RH'),('TI'),('Vendas');

INSERT INTO departamento (nome)
VALUES ('Compras');

SELECT 
    *
FROM
    departamento;

INSERT INTO empregado (nome, idade, salario, id_departamento) VALUES
('João', 30, 50000, 1),
('Sarah', 28, 60000, 2),
('Miguel', 35, 55000, 3),
('Ana', 27, 62000, 2),
('Paulo', 59, 75000, 3);

SELECT 
    e.nome AS Empregado, d.nome AS Departamento
FROM
    empregado e
        INNER JOIN
    departamento d ON e.id_departamento = d.id;
    
SELECT 
    d.nome AS Departamento, e.nome AS Empregado
FROM
    departamento d
        LEFT JOIN
    empregado e ON d.id = e.id_departamento;

SELECT 
    *
FROM
    empregado
WHERE
    salario > (SELECT 
            AVG(salario)
        FROM
            empregado);

SELECT 
    e.nome AS Empregado, d.nome AS Departamento
FROM
    empregado e
        INNER JOIN
    departamento d ON e.id_departamento = d.id
WHERE
    id_departamento = (SELECT 
            e.id_departamento
        FROM
            empregado e
        WHERE
            nome = 'Sarah');
            
INSERT INTO empregado (nome, idade, salario, id_departamento)
VALUES ('Tomás', 38, 58000, 3);

SELECT 
    d.nome, COUNT(e.id) AS Total
FROM
    empregado e
        JOIN
    departamento d ON e.id_departamento = d.id
GROUP BY id_departamento;

UPDATE empregado 
SET 
    salario = salario * 1.05
WHERE
    id_departamento = (SELECT 
            id
        FROM
            departamento
        WHERE
            nome = 'TI');

DELETE FROM empregado WHERE idade > 40;

SELECT * FROM empregado;