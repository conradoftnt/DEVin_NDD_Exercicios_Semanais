USE Banking;

SELECT 
	categoria.nomeCategoria AS 'Categoria',
	COUNT(idCliente) AS 'Quantidade de Clientes' 
FROM cliente 
INNER JOIN conta ON cliente.idCliente = conta.cliente_id
INNER JOIN categoria ON conta.categoria_id = categoria.idCategoria
WHERE categoria.nomeCategoria = 'ouro'
GROUP BY categoria.nomeCategoria;