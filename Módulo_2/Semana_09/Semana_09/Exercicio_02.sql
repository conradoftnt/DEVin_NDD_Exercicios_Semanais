USE Banking;

INSERT INTO cliente (nomeCompleto, primeiroNome, sobrenome, dataNascimento) VALUES 
('Santiago Rodrigues Gilberto','Santiago','Rodrigues Gilberto','1984-09-15'),
('Andressa Santos Scheifer','Andressa','Santos Scheifer','1998-02-10'),
('Helena Silva','Helena','Silva','1973-05-30'),
('João Borges','João','Borges','1992-07-22'),
('Vanessa Luz','Vanessa','Luz','1995-04-01'),
('Rosa Amorim','Rosa','Amorim','1989-07-11'),
('Cristiano Machado','Cristiano','Machado','2000-01-29'),
('Estefani Silveira','Estefani','Silveira','1994-12-17'),
('Samanta Fagundes','Samanta','Fagundes','1987-10-05'),
('Camila Marques','Camila','Marques','1997-09-30'),
('Orlando Souza','Orlando','Souza','2001-02-20'),
('Renata Correia','Renata','Correia','1996-04-10'),
('Gabriel Borba','Gabriel','Borba','1978-08-30');

INSERT INTO contaTipo (nome) 
VALUES ('conta-salário'), ('conta-corrente'), ('conta-poupança');

INSERT INTO categoria 
VALUES ('básica'),('prata'),('ouro'),('premium');

INSERT INTO movimentoTipo (nomeTipo)
VALUES  ('entrada de fundos - transferência'),
('entrada de fundos - depósito'),('entrada de fundos - pix'),
('entrada de fundos - cobrança'),('entrada de fundos - estorno'),
('saída de fundos - transferência'),('saída de fundos - saque'),
('saída de fundos - pix'),('saída de fundos - pagamento de boleto'),
('saída de fundos - taxa de operação bancária');

INSERT INTO movimentoStatus (nomeStatus)
VALUES ('pendente'), ('sucesso'), ('falha');

INSERT INTO conta (cliente_id, tipo_id,categoria_id, valor)
VALUES (1,2,4,2000),(3,1,2,2500),(1,3,1,2700),(3,3,2,3080),
(1,2,4,2000),(3,1,2,4500),(1,3,1,500),(3,3,2,300),
(1,2,4,7000),(3,1,2,8500),(1,3,1,1700),(3,3,2,700);

INSERT INTO movimento (valor, tipo_id, conta_id, status_id)
VALUES 
	(2300,2,12,1),(2300,2,12,1),(2300,2,12,1),
	(2300,2,12,1),(2300,2,12,1),(2300,2,12,1),
	(2300,2,12,1),(2300,2,12,1),(2300,2,12,1),
	(2300,2,12,1),(2300,2,12,1),(2300,2,12,1);

INSERT INTO contaServicos (categoria_id, nome, quantidade, taxa) 
VALUES (1,'cadastro de conta',1,0),(1,'saque caixa eletronico',1,0),
(1,'extrato caixa eletronico',99,0),(1,'extrato online',99,0),(1,'atendimento fone',99,0),
(2,'cadastro de conta',1,1999),(2,'saque caixa eletronico',6,50),(2,'extrato caixa eletronico',99,0),
(2,'extrato online',99,0),(2,'atendimento fone',99,0),(2,'atendimento 24/7',99,0),
(2,'cartão de débito',99,499),(2,'pix',99,0),(3,'cadastro de conta',1,499),
(3,'saque caixa eletronico',10,0),(3,'extrato caixa eletronico',99,0),(3,'extrato online',99,0),
(3,'atendimento 24/7',99,0),(3,'cartão de débito',1,499),(3,'pix',99,0),
(3,'internet banking',99,0),(3,'cartão de crédito',1,499),(3,'seguro de automóvel',1,79999),
(3,'limite pré aprovado R$ 5.000,00',1,0),(4,'cadastro de conta',1,2999),(4,'saque caixa eletronico',99,0),
(4,'extrato caixa eletronico',99,0),(4,'extrato online',99,0),(4,'atendimento 24/7',99,0),
(4,'cartão de débito',99,0),(4,'pix',99,0),(4,'internet banking',99,0),
(4,'cartão de crédito',3,0),(4,'previdência privada',12,49999),(4,'limite pré aprovado R$ 50.000,00',1,0),
(4,'seguro de automóvel',3,199999),(4,'seguro de vida',12,4999),(4,'desconto em viagens',12,999),
(4,'título de capitalização',12,9999),(4,'consórcio automotivo',3,399999);
