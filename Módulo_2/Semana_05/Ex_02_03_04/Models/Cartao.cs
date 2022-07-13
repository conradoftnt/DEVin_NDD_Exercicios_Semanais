namespace Ex_02_03_04.Models;

internal class Cartao
{
    public string Bandeira;
    public double Saldo;
    public double ValorTaxa;

    public Cartao(string bandeira, double saldo, double valorTaxa)
    {
        Bandeira = bandeira;
        Saldo = saldo;
        ValorTaxa = valorTaxa;
    }

    public virtual double VerificarValorTaxaCartao()
    {
        return Saldo * ValorTaxa;
    }
}