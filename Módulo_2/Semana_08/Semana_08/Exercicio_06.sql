USE Empresa;

INSERT INTO Cargos
VALUES 
	('Dono'),
	('Diretor'),
	('Chefe'),
	('Analista'),
	('Secretario'),
	('Especialista'),
	('Vendedor'),
	('Contador'),
	('Zelador'),
	('Estagiario');

INSERT INTO Gestores
VALUES 
	('Adriana', 2),
	('Eduardo', 10),
	('Cleber', 7),
	('Ana', 1),
	('Maria', 5),
	('Denise', 8),
	('João', 4),
	('Lucas', 6),
	('Pablo', 9),
	('Gustavo', 3);

INSERT INTO Empregados
VALUES 
	('Adriana', 'Rua Certa', 23, 2, 1),
	('Gustavo', 'Rua Errada', 27, 3, 2),
	('Denise', 'Rua Indeterminada', 35, 8, 3),
	('Pablo', 'Rua Sem Saida', 46, 9, 3),
	('Eduardo', 'Rua Com Saida', 22, 10, 3),
	('Cleber', 'Rua Não Registrada', 39, 7, 3),
	('Otavio', 'Rua Registrada', 17, 10, 3),
	('João', 'Rua Azul', 27, 4, 2),
	('Maria', 'Rua Verde', 18, 5, 2),
	('Lucas', 'Rua Amarela', 26, 6, 2);