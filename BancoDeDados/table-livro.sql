CREATE TABLE IF NOT EXISTS livro (
    id INT PRIMARY KEY AUTO_INCREMENT,
    titulo VARCHAR(100) NOT NULL,
    data_publicacao DATETIME NOT NULL,
    numero_paginas INT NULL,
    preco DECIMAL(10, 2) NULL,
    isbn VARCHAR(17) NOT NULL UNIQUE,
    genero VARCHAR(30) NOT NULL,
    editora VARCHAR(50) NOT NULL,
    autor VARCHAR(100) NOT NULL
);

INSERT INTO livro (
	titulo, data_publicacao, preco, isbn, genero, editora, autor
) VALUES (
	'titulo do meu livro',
    '1991-08-31 22:38:48',
    129.99,
    '978-3-16-148410-0',
    'tecnologia',
    'editora',
    'rafael sousa'
);

INSERT INTO livro (
	titulo, data_publicacao, preco, isbn, genero, editora, autor
) VALUES (
	'titulo do meu livro 2',
    '1994-08-31',
    87.99,
    '978-3-16-148410-1',
    'tecnologia',
    'editora',
    'rafael sousa'
);

INSERT INTO livro (
	titulo, data_publicacao, numero_paginas, preco, isbn, genero, editora, autor
) VALUES (
	'titulo do meu livro 3',
    '1998-08-31',
    209,
    93.99,
    '978-3-16-148410-2',
    'tecnologia',
    'editora',
    'rafael sousa'
);