using System;

public class SistemaSolar : ASistemaEnergia, ICalculEnergia
{
    public double HoresDeSol { get; set; }
    public SistemaSolar()
    {
        HoresDeSol = 1.1;
        EnergiaGenerada = CalculEnergia(HoresDeSol);
        DataSimulacio = DateTime.Now;
    }

    public SistemaSolar(double horesDeSol)
    {
        HoresDeSol = (horesDeSol > 1) ? horesDeSol : 1.1;
        EnergiaGenerada = CalculEnergia(HoresDeSol);
        DataSimulacio = DateTime.Now;
    }


    public double CalculEnergia(double horesDeSol)
    {

        double energiaGenerada = horesDeSol * 1.5;
        return energiaGenerada;

    }
    
    

}

