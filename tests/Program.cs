using System;
using ImaginaryNumbers;

namespace tests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ImaginaryClass num = new ImaginaryClass(1,2);
            Console.WriteLine(num.print());
        }
    }
}
