using System;
using ImaginaryNumbers;
using AbstractClasses;
using _4B;

namespace tests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello testing World!");
            //ImaginaryClass num = new ImaginaryClass(1,2);
            //Console.WriteLine(num.print());

            Angle angle = new Angle(1,2,'N');
            angle.GetAngle();

            Angle angle2 = new Angle();
            angle2.GetAngle();
            
            Console.WriteLine("1)Tea ");
            Console.WriteLine("2)Coffee ");
            int tipe = 0;
            while (tipe == 0)
            {
                string temp1 = Console.ReadLine();
                if (temp1 == "1")
                {
                    tipe = 1;
                };
                if (temp1 == "2")
                {
                    tipe = 2;
                };
                if (tipe == 0)
                {
                    Console.WriteLine("input is not correct try agein");
                };
            }
            ProcessCup cup = new ProcessCup(tipe);
        }
    }
}
