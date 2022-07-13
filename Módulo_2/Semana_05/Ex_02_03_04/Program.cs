namespace Ex_02_03_04;
using Ex_02_03_04.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Cartao cartao = new Cartao("Master", 1000, 0.01);
        cartao.VerificarValorTaxaCartao();

        VR vr = new VR("PayPal", 2000, 0.08);
        vr.VerificarValorTaxaCartao();

        VA va = new VA("Visa", 3000, 0.02);
        va.VerificarValorTaxaCartao();

        VT vt = new VT("Elo", 4000, 0.06);
        vt.VerificarValorTaxaCartao();
    }
}