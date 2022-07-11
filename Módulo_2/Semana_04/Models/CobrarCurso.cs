namespace Semana_04.Models;

public class CobrarCurso
{
    private float ValorCurso;
    private float ValorDesconto;
    private float ValorMulta;
    public float Resultado;

    CobrarCurso(FichaInscricao Usuario)
    {
        ValorCurso = Usuario.ValorCurso;
        ValorDesconto = Usuario.ValorDesconto;
        ValorMulta = Usuario.ValorMulta;

        Calculo();
    }

    private void Calculo()
    {
        if (ValorMulta > 0)
        {
            Resultado = ValorCurso + ValorMulta;
        }
        else
        {
            Resultado = ValorCurso - ValorDesconto;
        }
    }
}