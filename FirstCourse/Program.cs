using System;

namespace FirstCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Console.WriteLine("Hello World!");
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            int latime;
            int lungime = 3;
            Console.WriteLine("Aria unei camere");
            Console.WriteLine("Introduceti latimea: ");
            latime = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceri lungimea: ");

            lungime = int.Parse(Console.ReadLine());

            int ariaCamerei = latime * lungime;

            Console.WriteLine("Aria dreptunghiului este: " + ariaCamerei);
            //Console.ReadKey();

            if (latime == lungime)
            {
                Console.WriteLine("camera este patrata");
            }
            else
            {
                Console.WriteLine("Camera nu este patrata");
            }

            if (latime < lungime)
            {
                Console.WriteLine("Lungimea este mai mare");
            }
            else
            {
                Console.WriteLine("Lungimea este mai mica");
            }


        }
    }
}
