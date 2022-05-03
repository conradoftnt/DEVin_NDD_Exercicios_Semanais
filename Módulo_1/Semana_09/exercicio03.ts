let aluno: {
    nome: string;
    matricula: number;
    ativo: boolean;
    cadeiras: string[];
};

aluno.nome = "Conrado";
aluno.matricula = 1278952;
aluno.ativo = true;
aluno.cadeiras.push("Ensino Médio");
aluno.cadeiras.push("DEVin House NDD");
aluno.cadeiras.push("Ensino Fudamental");
aluno.cadeiras.push("UFSC");

console.log(aluno);
