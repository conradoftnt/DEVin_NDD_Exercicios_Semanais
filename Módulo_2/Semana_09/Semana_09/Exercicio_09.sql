USE Banking;

SELECT 
	TOP 1
	movimentoTipo.nomeTipo AS 'Tipo de Movimento',
	COUNT(*) AS 'Quantidade de Transações'
FROM movimento
INNER JOIN movimentoTipo ON movimento.tipo_id = movimentoTipo.idMovimentoTipo
GROUP BY movimentoTipo.nomeTipo
ORDER BY COUNT(*) DESC