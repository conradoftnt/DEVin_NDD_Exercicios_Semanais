namespace Semana_04.Models;

public class FichaInscricao
{
    public string? Nome;
    public int Idade;
    public string? Curso;
    public string? Escolaridade;
    public DateTime DataNascimento;
    public float ValorCurso;
    public float ValorDesconto;
    public float ValorMulta;

    private static IList<string> ListaCursos;

    public FichaInscricao(string NNome, string NCurso, string NEscolaridade, DateTime NDataNascimento, float NValorCurso, float NValorDesconto, float NValorMulta)
    {
        ListaCursos = new List<string>();

        Nome = NNome;

        AdicionaCurso(NCurso);

        Escolaridade = NEscolaridade;

        DataNascimento = NDataNascimento;
        CalcularIdade();

        ValorCurso = NValorCurso;
        ValorDesconto = NValorDesconto;
        ValorMulta = NValorMulta;
    }

    private void CalcularIdade()
    {
        int DataAtual = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
        Idade = (DataAtual - int.Parse(DataNascimento.ToString("yyyyMMdd")) / 10000);
    }

    public void AdicionaCurso(string NewCurso)
    {
        ListaCursos.Add(NewCurso);
        Curso = NewCurso;
    }

    public void MostraCursos()
    {
        string StringCursos = "";

        foreach (string item in ListaCursos)
        {
            StringCursos = StringCursos + $"| {item} ";
        }

        Console.WriteLine(StringCursos);
    }
}