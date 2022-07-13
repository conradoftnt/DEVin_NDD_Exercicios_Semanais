namespace Ex_02_03_04.Models;

class VT : Cartao
{
    public VT(string bandeira, double saldo, double valorTaxa) : base(bandeira, saldo, valorTaxa)
    {
    }

    public override double VerificarValorTaxaCartao()
    {
        return Saldo * 0.04;
    }
}