USE Empresa;

ALTER TABLE Empregados ADD cor_favorita VARCHAR(20);
GO

UPDATE Empregados
SET cor_favorita = 'Azul'
WHERE id_emp % 2 = 0;

UPDATE Empregados
SET cor_favorita = 'Vermelho'
WHERE id_emp % 2 != 0;