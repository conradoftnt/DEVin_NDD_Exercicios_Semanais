USE Banking;

INSERT INTO cliente (nomeCompleto, primeiroNome, sobrenome, dataNascimento) VALUES 
('Santiago Rodrigues Gilberto','Santiago','Rodrigues Gilberto','1984-09-15'),
('Andressa Santos Scheifer','Andressa','Santos Scheifer','1998-02-10'),
('Helena Silva','Helena','Silva','1973-05-30'),
('Jo�o Borges','Jo�o','Borges','1992-07-22'),
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
VALUES ('conta-sal�rio'), ('conta-corrente'), ('conta-poupan�a');

INSERT INTO categoria 
VALUES ('b�sica'),('prata'),('ouro'),('premium');

INSERT INTO movimentoTipo (nomeTipo)
VALUES  ('entrada de fundos - transfer�ncia'),
('entrada de fundos - dep�sito'),('entrada de fundos - pix'),
('entrada de fundos - cobran�a'),('entrada de fundos - estorno'),
('sa�da de fundos - transfer�ncia'),('sa�da de fundos - saque'),
('sa�da de fundos - pix'),('sa�da de fundos - pagamento de boleto'),
('sa�da de fundos - taxa de opera��o banc�ria');

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
(2,'cart�o de d�bito',99,499),(2,'pix',99,0),(3,'cadastro de conta',1,499),
(3,'saque caixa eletronico',10,0),(3,'extrato caixa eletronico',99,0),(3,'extrato online',99,0),
(3,'atendimento 24/7',99,0),(3,'cart�o de d�bito',1,499),(3,'pix',99,0),
(3,'internet banking',99,0),(3,'cart�o de cr�dito',1,499),(3,'seguro de autom�vel',1,79999),
(3,'limite pr� aprovado R$ 5.000,00',1,0),(4,'cadastro de conta',1,2999),(4,'saque caixa eletronico',99,0),
(4,'extrato caixa eletronico',99,0),(4,'extrato online',99,0),(4,'atendimento 24/7',99,0),
(4,'cart�o de d�bito',99,0),(4,'pix',99,0),(4,'internet banking',99,0),
(4,'cart�o de cr�dito',3,0),(4,'previd�ncia privada',12,49999),(4,'limite pr� aprovado R$ 50.000,00',1,0),
(4,'seguro de autom�vel',3,199999),(4,'seguro de vida',12,4999),(4,'desconto em viagens',12,999),
(4,'t�tulo de capitaliza��o',12,9999),(4,'cons�rcio automotivo',3,399999);
