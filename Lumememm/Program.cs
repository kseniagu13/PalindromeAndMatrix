using System;

namespace Lumememm
{
    class Program
    {
        //build a snowman
        //snowman has got a name and mass (int mass=10)
        //snowman melts if temp is higher than 0 and loses 20% of his mass
        //snowman stands outside for 3 days
        //the temp outside fluctates from -5 to +10
        //display the final mass of the snowman after 3 days of being outside

            class Snowman
        {
            string name;
            double mass = 10;
            //public int age;

            public Snowman (string _name) //mass on vaikimisi 10, siis ei lisa siia
            {
                name = _name;
                
                //age = _age;
            }

            public string Name //getter 
            {
                get { return name; }  
            }
            public double Mass
            {
                get { return mass; }
            }

            public void SnowmanMelting(int temp)
            {
                if (temp >= 0)
                {
                    mass-= mass * 0.2;
                    Console.WriteLine("Help, I am melting!");
                }
            }
        }

        static void Main(string[] args)
        {
            
            Snowman snowman = new Snowman("Lumi");
            Console.WriteLine($"Snowman {snowman.Name}.");
            Random rnd = new Random();
            for (int i=0; i<3; i++)
            {

                int temp = rnd.Next(-5, 11);
                Console.WriteLine($"Its {temp} degree today.");
                snowman.SnowmanMelting(temp);
            }

            Console.WriteLine($"The mass of the snowman after 3 days: {snowman.Mass}");

            Console.ReadLine();


        }
    }
}
