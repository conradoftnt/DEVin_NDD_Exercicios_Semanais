USE Banking;

SELECT
	idConta,
	cliente.nomeCompleto,
	valor AS saldo
FROM conta INNER JOIN cliente
ON conta.cliente_id = cliente.idCliente
WHERE conta.valor = (SELECT MAX(valor) FROM conta);