using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Fraction fr1 = new Fraction();
            Console.WriteLine(fr1);
            Console.WriteLine(fr1.Reverse());
            Console.WriteLine();

            Fraction fr2 = new Fraction(2);
            Console.WriteLine(fr2);
            Console.WriteLine(fr2.Reverse());
            Console.WriteLine();
            */

            Fraction fr3 = new Fraction(6, 3);
            Console.WriteLine(fr3);
            Console.WriteLine();
            Console.WriteLine("Reverse:");
            Console.WriteLine(fr3.Reverse());

            Console.WriteLine("\nSum:");
            Console.WriteLine(Fraction.Sum(new Fraction(1,2), new Fraction(7,3)));
            

            Console.WriteLine("\nMulti:");
            Console.WriteLine(Fraction.Multi(new Fraction(1,2), new Fraction(7,3)));
            

            Console.WriteLine("\nReduction:");
            Console.WriteLine(new Fraction(84,36).Reduction());
            Console.WriteLine(new Fraction(2,12,36).Reduction());
            

            Console.WriteLine("\nNormal, DeNormal:");    
            Fraction fr4 = new Fraction(7, 2);    
            Console.WriteLine(fr4.Normal());
            Console.WriteLine(fr4.DeNormal());

            Console.WriteLine();
        }
    }
}
