CREATE DATABASE Empresa;

USE Empresa;

CREATE TABLE Cargos (
	id_cargo int PRIMARY KEY IDENTITY (1,1),
	nome_cargo VARCHAR(200) NOT NULL
);

CREATE TABLE Gestores (
	id_gestor int PRIMARY KEY IDENTITY (1,1),
	nome_gestor VARCHAR(200) NOT NULL,
	gestor_id int NOT NULL,
	CONSTRAINT fk_Gestor_Cargo FOREIGN KEY (gestor_id) REFERENCES Gestores(id_gestor)
);

CREATE TABLE Empregados (
	id_emp int PRIMARY KEY IDENTITY (1,1), 
	nome_emp VARCHAR(200) NOT NULL,
	endereco VARCHAR(200) NOT NULL,
	idade int NOT NULL,
	cargo_id int NOT NULL,
	gestor_id int NOT NULL,
	CONSTRAINT fk_Empregados_Cargos FOREIGN KEY (cargo_id) REFERENCES Cargos(id_cargo),
	CONSTRAINT fk_Gestor_Empregado FOREIGN KEY (gestor_id) REFERENCES Gestores(id_gestor)
);