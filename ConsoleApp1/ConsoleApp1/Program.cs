namespace ConsoleApp1
{
    internal class Program
    {
        

        public class animal
        {
            public int speed;
            public int weight;
            public string name;
        }

        public class Varg : animal
        {
            public bool isDog;
            public int maxSpeed;
            public int acceleration;
            
            public void increasespeed()
            {
                if (speed < maxSpeed)
                {
                    speed = speed + acceleration;
                }
                
            }
            public void stop()
            {
                speed = 0;
            }

            public Varg(string Name)
            {
                name = Name;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Varg minVarg = new Varg("Karl");
            minVarg.speed = 100;
            
            minVarg.weight = 200;
            Console.WriteLine(minVarg.speed);
            minVarg.increasespeed(); 
            Console.WriteLine(minVarg.speed);
            minVarg.isDog = true;
            if (minVarg.isDog = true)
            {
                Console.WriteLine("Its a dog");
            }
            Console.WriteLine(minVarg.name);

        }
    }
}
