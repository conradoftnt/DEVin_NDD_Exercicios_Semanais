USE Banking;

SELECT 
	movimentoStatus.nomeStatus AS 'Status', 
	COUNT(*) AS 'Quantidade Falhas'
FROM movimento
INNER JOIN movimentoStatus ON movimento.status_id = movimentoStatus.idMovimentoStatus
WHERE movimentoStatus.nomeStatus = 'falha'
GROUP BY movimentoStatus.nomeStatus;