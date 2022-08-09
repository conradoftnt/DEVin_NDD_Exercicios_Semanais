CREATE DATABASE Banking;
GO

--CRIANDO AS TABELAS:

CREATE TABLE cliente(
	idCliente INT PRIMARY KEY IDENTITY(1,1),
	nomeCompleto VARCHAR(200) NOT NULL,
	primeiroNome VARCHAR(200) NOT NULL,
	sobrenome VARCHAR(200) NOT NULL,
	dataNascimento DATE NOT NULL
);

CREATE TABLE categoria(
	idCategoria INT PRIMARY KEY IDENTITY(1,1),
	nomeCategoria VARCHAR(60)
);

CREATE TABLE conta(
	idConta INT PRIMARY KEY IDENTITY(1,1),
	cliente_id INT NOT NULL, 
	tipo_id INT NOT NULL,
	categoria_id INT NOT NULL,
	valor INT NOT NULL
);

CREATE TABLE contaServicos(
	idContaServico INT PRIMARY KEY IDENTITY(1,1),
	categoria_id INT NOT NULL, 
	nome VARCHAR(60) NOT NULL,
	quantidade INT NOT NULL,
	taxa INT NOT NULL
);

CREATE TABLE contaTipo(
	idContaTipo INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(60) NOT NULL 
);

CREATE TABLE movimento(
	idMovimento INT PRIMARY KEY IDENTITY(1,1),
	valor INT NOT NULL,
	cadastradoEm DATETIME,
	atualizadoEm DATETIME,
	tipo_id INT NOT NULL,
	conta_id INT NOT NULL,
	status_id INT NOT NULL
);

CREATE TABLE movimentoStatus(
	idMovimentoStatus INT PRIMARY KEY IDENTITY(1,1),
	nomeStatus VARCHAR(60) NOT NULL
);

CREATE TABLE movimentoTipo(
	idMovimentoTipo INT PRIMARY KEY IDENTITY(1,1),
	nomeTipo VARCHAR(60) NOT NULL
);

--ADICIONANDO AS CHAVES ESTRANGEIRAS:

ALTER TABLE conta 
ADD CONSTRAINT fk_conta_cliente FOREIGN KEY (cliente_id) REFERENCES cliente(idCliente);

ALTER TABLE conta
ADD CONSTRAINT fk_conta_contaTipo FOREIGN KEY (tipo_id) REFERENCES contaTipo(idContaTipo);

ALTER TABLE conta
ADD CONSTRAINT fk_conta_categoria FOREIGN KEY (categoria_id) REFERENCES categoria(idCategoria);

ALTER TABLE contaServicos
ADD CONSTRAINT fk_contaServicos_categoria FOREIGN KEY (categoria_id) REFERENCES categoria(idCategoria);

ALTER TABLE movimento
ADD CONSTRAINT fk_movimento_movimentoTipo FOREIGN KEY (tipo_id) REFERENCES movimentoTipo(idMovimentoTipo);

ALTER TABLE movimento
ADD CONSTRAINT fk_movimento_conta FOREIGN KEY (conta_id) REFERENCES conta(idConta);

ALTER TABLE movimento
ADD CONSTRAINT fk_movimento_movimentoStatus FOREIGN KEY (status_id) REFERENCES movimentoStatus(idMovimentoStatus);
