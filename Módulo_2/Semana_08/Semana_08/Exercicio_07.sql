USE Empresa;

ALTER TABLE Empregados ADD setor CHAR(1);
GO

UPDATE Empregados
SET setor = 'A'
WHERE id_emp % 2 = 0;

UPDATE Empregados
SET setor = 'B'
WHERE id_emp % 2 != 0;