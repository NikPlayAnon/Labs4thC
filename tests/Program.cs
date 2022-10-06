using System;
using ImaginaryNumbers;
using AbstractClasses;

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

            
        }
    }
}
