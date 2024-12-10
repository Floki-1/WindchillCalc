namespace WindchillCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            while (true)

            {

                Console.WriteLine("1: Beräkna windchill-faktor: ");
                Console.WriteLine("2: Avsluta: ");
                int userinput = int.Parse(Console.ReadLine());   

                switch (userinput)
                {
                    case 1:
                        
                        räkna();
                        break;

               

                    case 2:
                        Environment.Exit(0);
                        break;
                }
                if (userinput != 1 && userinput != 2)
                {
                    Console.WriteLine("Fel input!");
                }
                Console.WriteLine();









            }







        }

        static void räkna()
        {
            double Temp = 0;
            double Wind = 0;
            double WindChillcalc = 0;


            Console.WriteLine("Ange utomhustempraturen i celsius: ");
            Temp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Fyll i vindhastighetet ( ange i m/s eller km/h ): ");
            Console.WriteLine("1: m/s");
            Console.WriteLine("2: km/h");

            int enhet = int.Parse(Console.ReadLine());

            Console.WriteLine("Vindhastigheten");
            Wind = Convert.ToDouble(Console.ReadLine());
            if (enhet == 1)
            {
                if (Wind < 1.39)
                {
                    Console.WriteLine("Vindhastighet för låg för att beräkna!");
                    Environment.Exit(0);
                }
                else
                {
                    
                    ms(Temp, Wind, WindChillcalc);
                    
                }
            } else if (enhet == 2) {
                if(Wind < 5) {
                    Console.WriteLine("Vindhastighet för låg för att beräkna!");
                    Environment.Exit(0);


                }
                else
                {
                   
                    kmh(Temp, Wind, WindChillcalc);
                   
                }

            } else { Console.WriteLine("Fel input!"); }

            
            
            

            



        }

        static void ms(double temp, double wind, double WindChill)
        {
            double Wind = wind * 3.6;
            
            WindChill = 13.12 + 0.6215 * temp - 11.37 * Math.Pow(Wind, 0.16) + 0.3965 * temp * Math.Pow(Wind, 0.16); //Tack Isak
            
            Console.WriteLine($"Känns som {WindChill:F2} grader celsius");

            if(WindChill > -25)
            {

                Console.WriteLine("Kallt");

            } else if (WindChill > -35 && WindChill < -25)
            {
                Console.WriteLine("Mycket kallt");
            }
            else if (WindChill > -65 && WindChill < -35)
            {
                Console.WriteLine("Risk för frostskada"); 
                
            }
            else if (WindChill < -60)
            {
                Console.WriteLine("Risk för frostskada");
            }

        }
        static void kmh(double temp, double wind, double WindChill)
        {
            
            
            //WindChill = 13.12 + 0.6215 * temp - 11.37 * Math.Pow(Wind, 0.16) + 0.3965 * temp * Math.Pow(Wind, 0.16);

            WindChill = 13.12 + 0.6215 * temp - 11.37 * Math.Pow(wind, 0.16) + 0.3965 * temp * Math.Pow(wind, 0.16); //Tack Isak

            Console.WriteLine($"Känns som {WindChill:F2} grader celsius");

            if (WindChill > -25)
            {
                Console.WriteLine("Kallt");
            }
            else if (WindChill > -35 && WindChill < -25)
            {
                Console.WriteLine("Mycket kallt");
            }
            else if (WindChill > -65 && WindChill < -35)
            {
                Console.WriteLine("Risk för frostskada");
            }
            else if (WindChill < -60)
            {
                Console.WriteLine("Risk för frostskada");
            }

        }


    }
}   




