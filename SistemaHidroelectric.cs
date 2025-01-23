using System;

public class SistemaHidroelectric : ASistemaEnergia, ICalculEnergia
{
    public double CabalAigua { get; set; }
    public SistemaHidroelectric()
    {
        CabalAigua = 20;
        EnergiaGenerada = CalculEnergia(CabalAigua);
        DataSimulacio = DateTime.Now;
    }

    public SistemaHidroelectric(double cabalAigua)
    {
        CabalAigua = (cabalAigua >= 20) ? cabalAigua : 20;
        EnergiaGenerada = CalculEnergia(CabalAigua);
        DataSimulacio = DateTime.Now;
    }


    public double CalculEnergia(double cabalAigua)
    {

        double energiaGenerada = cabalAigua * 9.8 * 0.8;
        return energiaGenerada;

    }
}
