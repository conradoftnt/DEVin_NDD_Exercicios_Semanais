USE Banking;

SELECT 
	nomeCompleto,
	FORMAT(dataNascimento, 'd', 'pt-br') AS dataNascimento,
	DATEDIFF(yy, dataNascimento, GETDATE()) AS idade
FROM cliente
WHERE dataNascimento = (SELECT MIN(dataNascimento) FROM cliente);
