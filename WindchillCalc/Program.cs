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
                WindChillcalc = 13.12 + 0.6215 * Temp - 11.37 * Math.Pow(Wind, 016) + 0.3965 * Temp * Math.Pow(Wind, 0.16);
                Console.WriteLine("Känns som " + WindChillcalc.ToString() + " grader celsius");
            }
            else if (enhet == 2)
            {
                WindChillcalc = 13.12 + 0.6215 * Temp - 11.37 * Math.Pow(Wind, 016) + 0.3965 * Temp * Math.Pow(Wind, 0.16);
                Console.WriteLine("Känns som " + WindChillcalc.ToString() + " grader celsius");
            }
            else
            {
                Console.WriteLine("Fel input!");
            }
            
            

            



        }
    }
}   




