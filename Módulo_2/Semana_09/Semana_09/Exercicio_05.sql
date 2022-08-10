USE Banking;

SELECT contaTipo.nome AS 'Tipo de Conta', COUNT(*) AS 'Quantidade'
FROM conta INNER JOIN contaTipo
ON conta.tipo_id = contaTipo.idContaTipo
WHERE contaTipo.nome = 'conta-salário'
GROUP BY contaTipo.nome;