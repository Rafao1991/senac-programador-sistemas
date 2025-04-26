CREATE DATABASE sorteio_apresentacoes;

USE sorteio_apresentacoes;

CREATE TABLE grupo (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL
);

INSERT INTO grupo (nome)
VALUES ('prodbase'), ('workbridge'), ('garagem 13'), ('panorama'), ('gamebuster'), ('C#belos');

CREATE TABLE apresentacao (
    id INT PRIMARY KEY AUTO_INCREMENT,
    data_apresentacao DATE DEFAULT NOW()
);

CREATE TABLE ordem (
    id_apresentacao INT NOT NULL,
    id_grupo INT NOT NULL,
    ordem INT NOT NULL,
    PRIMARY KEY (id_apresentacao , id_grupo , ordem),
    FOREIGN KEY (id_apresentacao)
        REFERENCES apresentacao (id),
    FOREIGN KEY (id_grupo)
        REFERENCES grupo (id)
);

SELECT o.ordem, g.nome FROM apresentacao a INNER JOIN ordem o ON a.id = o.id_apresentacao INNER JOIN grupo g ON o.id_grupo = g.id WHERE a.data_apresentacao = '2025-04-25' ORDER BY o.ordem ASC;

INSERT INTO apresentacao () VALUES ();
SELECT id FROM apresentacao ORDER BY id DESC LIMIT 1;

INSERT INTO ordem (id_apresentacao, id_grupo, ordem)
VALUES (2, 1, 1), (2, 2, 2), (2, 3, 6), (2, 4, 4), (2, 5, 5), (2, 6, 3);

select * FROM grupo;
select * from apresentacao;
select * from ordem;