namespace Ex_05_06.Models;
using System.Text.RegularExpressions;

public class Funcionario
{
    public string? Nome;
    public string? Id;

    public Funcionario(string nome, string id)
    {
        try
        {
            if (VerificaNome(nome))
            {
                Nome = nome;
            }
            if (VerificaId(id))
            {
                Id = id;
            }
        }

        catch
        {
            throw;
        }
    }

    Boolean VerificaNome(string Nome)
    {
        if (Regex.IsMatch(Nome, "^[a-zA-Z]+$"))
        {
            return true;
        }
        throw new Exception("Nome inserido inválido. O nome deve conter apenas caracteres alfabéticos.");
    }

    Boolean VerificaId(string Id)
    {
        if (Regex.IsMatch(Id, "^[0-9]+$"))
        {
            return true;
        }
        throw new Exception("ID inserido inválido. O ID inserido deve conter apenas caracteres numericos.");
    }
}