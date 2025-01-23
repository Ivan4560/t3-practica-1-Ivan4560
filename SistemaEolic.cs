using System;

public class SistemaEolic : ASistemaEnergia, ICalculEnergia
{
    public double VelocitatVent { get; set; }
    public SistemaEolic()
    {
        VelocitatVent = 5;
        EnergiaGenerada = CalculEnergia(VelocitatVent);
        DataSimulacio = DateTime.Now;
    }

    public SistemaEolic(double velocitatVent)
    {
        VelocitatVent = (velocitatVent >= 5) ? velocitatVent : 5;
        EnergiaGenerada = CalculEnergia(VelocitatVent);
        DataSimulacio = DateTime.Now;
    }


    public double CalculEnergia(double velocitatVent)
    {

        double energiaGenerada = Math.Pow(velocitatVent, 3) * 0.2;
        return energiaGenerada;

    }
}
