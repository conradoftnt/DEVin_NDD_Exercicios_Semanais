namespace Semana_04.Models;

public static class FormatacaoTexto
{
    public static string Formatacao(string Nome, string Curso, float ValorCurso)
    {
        return $"Nome: {Nome}, Curso: {Curso}, Valor do Curso: R$ {ValorCurso}";
    }
    public static string Formatacao(string Nome, string Curso, float ValorCurso, float ValorDesconto)
    {
        return $"Nome: {Nome}, Curso: {Curso}, Valor do Curso: R$ {ValorCurso}, Valor do Desconto: R$ {ValorDesconto}";
    }
    public static string Formatacao(string Nome, string Curso, float ValorCurso, float ValorDesconto, int Idade)
    {
        return $"Nome: {Nome}, Curso: {Curso}, Valor do Curso: R$ {ValorCurso}, Valor do Desconto: R$ {ValorDesconto}, Idade: {Idade}";
    }
}