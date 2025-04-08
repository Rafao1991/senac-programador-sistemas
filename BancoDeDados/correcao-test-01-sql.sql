SELECT 
    *
FROM
    produto
WHERE
    categoria = 'ELETRONICOS'
        AND preco > 3000
ORDER BY preco DESC;

--
INSERT INTO cliente (nome, cidade, idade) VALUES
('João Silva', 'Pindamonhangaba', 35);

SELECT 
    *
FROM
    cliente
WHERE
    cidade <> 'sao paulo' AND idade > 30;
    
--

SELECT 
    *
FROM
    pedido
WHERE
    data_pedido BETWEEN '2024-03-10' AND '2024-03-15'
ORDER BY data_pedido ASC;

--

INSERT INTO produto (nome, categoria, preco, estoque, fornecedor_id) VALUES
('Celular J', 'Eletrônicos', 1500.00, 3, 1);

SELECT 
    *
FROM
    produto
WHERE
    estoque < 10
ORDER BY estoque ASC;

--

INSERT INTO fornecedor (nome, cidade) VALUES
('TechBrasil Campinas', 'Campinas'),
('TechBrasil RJ', 'Rio de Janeiro');

select * from fornecedor
where cidade <> 'rio de janeiro'
and nome like 't%';

--

SELECT 
	categoria,
    AVG(preco)
FROM
    produto
GROUP BY categoria;

--

SELECT 
	cliente.nome,
    COUNT(pedido.id) as 'Qtd de pedidos'
FROM
    pedido
INNER JOIN cliente ON pedido.cliente_id = cliente.id
group by cliente_id;

--

SELECT 
	categoria,
    SUM(estoque) as 'Total em estoque'
FROM
    produto
group by categoria;

--

SELECT 
    id, produto_id, quantidade
FROM
    pedido
WHERE
    quantidade = (SELECT 
            MAX(quantidade)
        FROM
            pedido);

--

SELECT 
    cidade, COUNT(id) as 'qtd de clientes'
FROM
    cliente
GROUP BY cidade
ORDER BY 'qtd de clientes' DESC;

--

SELECT 
    produto.id,
    produto.nome as 'nome do produto',
    produto.categoria,
    produto.preco,
    produto.estoque,
    fornecedor.nome as 'nome do fornecedor'
FROM
    produto
        INNER JOIN
    fornecedor ON produto.fornecedor_id = fornecedor.id
ORDER BY fornecedor.nome ASC;

--

SELECT 
    pedido.id AS 'id do pedido',
    pedido.data_pedido AS 'data do pedido',
    cliente.nome AS 'nome do cliente',
    produto.nome AS 'nome do produto'
FROM
    pedido
        INNER JOIN
    cliente ON pedido.cliente_id = cliente.id
        INNER JOIN
    produto ON pedido.produto_id = produto.id
ORDER BY pedido.data_pedido;

--

SELECT 
    pedido.id AS 'id do pedido',
    cliente.nome AS 'nome do cliente',
    produto.nome AS 'nome do produto',
    fornecedor.nome AS 'nome do fornecedor'
FROM
    pedido
        INNER JOIN
    cliente ON pedido.cliente_id = cliente.id
        INNER JOIN
    produto ON pedido.produto_id = produto.id
        INNER JOIN
    fornecedor ON produto.fornecedor_id = fornecedor.id;
    
--

SELECT 
    cliente.nome AS 'nome do cliente',
    SUM(pedido.quantidade) AS 'quantidade total'
FROM
    pedido
        INNER JOIN
    cliente ON pedido.cliente_id = cliente.id
GROUP BY pedido.cliente_id;

--

INSERT INTO produto (nome, categoria, preco, estoque, fornecedor_id) VALUES
('Tapete higienico', 'Pet', 40.99, 340, 3),
('Ração p/ Texugo', 'Pet', 7.80, 158, 3);

SELECT 
    *
FROM
    produto p
WHERE
    preco > (SELECT 
            AVG(preco)
        FROM
            produto pr
        WHERE
            p.categoria = pr.categoria)
ORDER BY p.categoria;
            
--

UPDATE produto 
SET 
    preco = preco * 1.1
WHERE
    categoria = 'eletronicos';
    
--

select * from cliente;

DELETE FROM pedido 
WHERE
    cliente_id IN (SELECT 
        id
    FROM
        cliente
    WHERE
        cidade = 'curitiba');
        
--

insert into cliente (nome, cidade, idade)
values ('ricardo lopes', 'porto alegre', 38);

--

SELECT 
    id
FROM
    produto
WHERE
    nome = 'Notebook Y';

SELECT 
    *
FROM
    cliente
WHERE
    nome = 'joao silva'
        AND cidade = 'sao paulo';

insert into pedido (quantidade, data_pedido, produto_id, cliente_id)
values (
2,
'2024-03-25',
(select id from produto where nome = 'Notebook Y'),
(select id from cliente where nome = 'joao silva' and cidade = 'sao paulo')
);

select * from pedido;

--

SELECT DISTINCT
    cliente.nome
FROM
    cliente
        INNER JOIN
    pedido ON cliente.id = pedido.cliente_id
        INNER JOIN
    produto ON pedido.produto_id = produto.id
WHERE
    produto.categoria = 'moveis';