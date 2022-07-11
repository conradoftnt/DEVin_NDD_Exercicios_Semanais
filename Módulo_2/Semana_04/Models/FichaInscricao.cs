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

    public FichaInscricao(string NNome, string NCurso, string NEscolaridade, DateTime NDataNascimento, float NValorCurso, float NValorDesconto, float NValorMulta)
    {
        Nome = NNome;
        Curso = NCurso;
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
}