using System;


namespace T3_PR1_Pràctica1
{
    public class EcoEnergy
    {

        public static void Main()
        {

            int opcio = 0, simulacions = 0, sistema = 0, sistemadenergia = 0;

            const string Pregunta1 = "\nQuantes simulacions vols generar? (Maxim 20)\n";
            const string Pregunta2 = "\nQuin sistema de energia vols escollir solar (1), eòlic (2) o hidroelèctric (3)?\n";
            const string Menu = ":-----Menú del sistema d'energia------:\n" +
                                "¦                                     ¦\n" +
                                "¦Seleciona quina opcio vols escollir: ¦\n" +
                                "¦                                     ¦\n" +
                                "¦1.Iniciar simulació                  ¦\n" +
                                "¦2.Veure Informe de simulacions       ¦\n" +
                                "¦3.Sortir                             ¦\n" +
                                ":_____________________________________:\n";
            const string errorsimulacio = "\nError dades introduides incorrectes siusplau introdueix un valor de l'1 al 3 (ºoº): \n";
            const string errorquantitatsimulacio = "\nError dades introduides incorrectes o has sobrepasat el limit\n\nProva amb un numero menor o igual que 20 (º-º)\n";
            const string simulacioactual = "\nSimulacions restants: ";

          


            Console.WriteLine(Menu);
            opcio = Convert.ToInt32(Console.ReadLine());

            while (opcio == 0 || opcio >= 4)
            {
                Console.Clear();
                Console.WriteLine(errorsimulacio);
                Console.WriteLine(Menu);
                opcio = Convert.ToInt32(Console.ReadLine());  
            }
            switch (opcio)
            {
                case 1:

                    Console.WriteLine(Pregunta1);
                    simulacions = Convert.ToInt32(Console.ReadLine());

                    while (simulacions <= 0 || simulacions >= 21)
                    {
                        Console.WriteLine(errorquantitatsimulacio);
                        Console.WriteLine(Pregunta1);
                        simulacions = Convert.ToInt32(Console.ReadLine());
                      
                    }

                    
            while (simulacions > 0) {
                    Console.WriteLine(simulacioactual + (simulacions));    
                    Console.WriteLine(Pregunta2);
                    sistemadenergia = Convert.ToInt32(Console.ReadLine());


                    while (sistemadenergia <= 0 || sistemadenergia >= 4) { 
                        Console.WriteLine(Pregunta2);
                        sistemadenergia = Convert.ToInt32(Console.ReadLine());
                        if (sistemadenergia <= 0)
                        {
                            Console.WriteLine(errorsimulacio);
                        }
                    }

                    switch (sistemadenergia)
                        {
                            case 1:

                                Console.WriteLine("\nHas selecionat energia solar.\n \nIntrodueix las horas de sol que estara actiu per fer el calcul de la energia generada: \n");
                                double horesDeSol = Convert.ToDouble(Console.ReadLine());
                                SistemaSolar sol = new SistemaSolar(horesDeSol);
                                Console.WriteLine("\n" + "Energia Total Generada: " + sol.EnergiaGenerada);
                                simulacions--;



                                break;
                            case 2:

                                Console.WriteLine("\nHas selecionat energia eolica .\n \nIntrodueix la velocitat del vent per fer el calcul de la energia generada: \n");
                                double CabalAigua = Convert.ToDouble(Console.ReadLine());
                                SistemaHidroelectric Hydro = new SistemaHidroelectric(CabalAigua);
                                Console.WriteLine("\n Energia Total Generada: " + Hydro.EnergiaGenerada);
                                simulacions--;


                                break;
                            case 3:


                                Console.WriteLine("\nHas selecionat energia acuatica .\n \nIntrodueix els cabals d'Aigua per fer el calcul de la energia generada: \n");
                                double eolic = Convert.ToInt32(Console.ReadLine());
                                SistemaEolic eolics = new SistemaEolic(eolic);
                                Console.WriteLine("\n" + "Energia Total Generada: " + eolics.EnergiaGenerada);
                            simulacions--;



                                break;
                        }
                    }

                        break;
                case 2:

                            break;
                        case 3:

                            Console.WriteLine("Tancant sistema de energia .....\n");


                            break;

                        }
                    }
            }
        }



    
