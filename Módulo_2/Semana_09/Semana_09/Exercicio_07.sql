USE Banking;

SELECT nome AS 'Serviços da Premium' 
FROM contaServicos 
INNER JOIN categoria ON contaServicos.categoria_id = categoria.idCategoria
WHERE categoria.nomeCategoria = 'premium'