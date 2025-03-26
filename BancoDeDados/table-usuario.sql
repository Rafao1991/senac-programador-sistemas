CREATE TABLE IF NOT EXISTS usuario (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    email VARCHAR(50) NOT NULL UNIQUE,
    senha VARCHAR(16) NOT NULL
);

SELECT 
    *
FROM
    usuario;

INSERT INTO usuario (
	nome,
    email,
    senha
)
VALUES (
	'rafael sousa',
    'rafael.csvasousa@email.com',
    'Senha@123'
);

INSERT INTO usuario (nome, email, senha)
VALUES 
	('Neymar Jr.', 'njr@email.com', 'Brun@'),
	('Maria Madalena', 'mmadalena@email.com', 'a1s2d3f4!'),
	('Pablo Vitar', 'p.vitar@email.com', 'Senh@Fort3');

INSERT INTO usuario (
	nome,
    email,
    senha
)
VALUES (
	'João Silva',
    'silva.joao@email.com',
    'Senh@123'
);