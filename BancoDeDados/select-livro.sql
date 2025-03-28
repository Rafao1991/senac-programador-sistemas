SELECT 
    *
FROM
    livro
WHERE
    data_publicacao >= '1990-01-01 00:00:00'
        AND data_publicacao <= '1999-12-31 23:59:59';

SELECT 
    *
FROM
    livro
WHERE
    data_publicacao BETWEEN '1990-01-01 00:00:00' AND '1999-12-31 23:59:59';

SELECT 
    *
FROM
    livro
WHERE
    YEAR(data_publicacao) BETWEEN '1990' AND '1999';

SELECT 
    autor
FROM
    livro;

SELECT DISTINCT
    (autor)
FROM
    livro;

SELECT 
    SUM(preco), AVG(preco), MAX(preco), MIN(preco)
FROM
    livro
WHERE
    autor = 'rafael sousa';

SELECT 
    COUNT(id)
FROM
    livro;

SELECT 
    *
FROM
    livro
ORDER BY titulo DESC;

SELECT DISTINCT
    LOWER(autor)
FROM
    livro;
    
SELECT DISTINCT
    LOWER(genero)
FROM
    livro;
    
SELECT DISTINCT
    LOWER(editora)
FROM
    livro;