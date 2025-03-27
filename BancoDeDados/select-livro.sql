select * from livro
where data_publicacao >= '1990-01-01 00:00:00'
and data_publicacao <= '1999-12-31 23:59:59';

select * from livro
where data_publicacao between '1990-01-01 00:00:00' and '1999-12-31 23:59:59';

select * from livro
where year(data_publicacao) between '1990' and '1999';

select autor from livro;

select distinct(autor) from livro;

select sum(preco), avg(preco), max(preco), min(preco) from livro
where autor = 'rafael sousa';

select count(id) from livro;

select * from livro
order by titulo desc;