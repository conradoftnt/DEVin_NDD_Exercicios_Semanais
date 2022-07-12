namespace Ex_01.Models;

class FuncionarioHorista : Empregado
{
    public string Cnpj;
    public double Taxa;
    public FuncionarioHorista(int id, string nome, string cnpj, double taxa) : base(id, nome)
    {
        this.Cnpj = cnpj;
        this.Taxa = taxa;
    }

    public void CalcularTaxas() { }

    public void EmitirNota() { }
}