CREATE TABLE atividade (
    id INT PRIMARY KEY AUTO_INCREMENT,
    titulo VARCHAR(100) NOT NULL,
    situacao INT NOT NULL DEFAULT 0
);

INSERT INTO atividade (titulo) VALUES (@titulo);

UPDATE atividade SET situacao = @situacao WHERE id = @id;

SELECT * FROM atividade WHERE situacao = 1;

SELECT * FROM atividade WHERE situacao = 0;

SELECT * FROM atividade;