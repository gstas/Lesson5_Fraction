using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction fr1 = new Fraction();
            Console.WriteLine(fr1);
            Console.WriteLine(fr1.Reverse());
            Console.WriteLine();

            Fraction fr2 = new Fraction(2);
            Console.WriteLine(fr2);
            Console.WriteLine(fr2.Reverse());
            Console.WriteLine();

            Fraction fr3 = new Fraction(2, 3);
            Console.WriteLine(fr3);
            Console.WriteLine(fr3.Reverse());

            Console.WriteLine();
            Console.WriteLine(Fraction.Sum(new Fraction(1,2), new Fraction(7,3)));

        }
    }
}
