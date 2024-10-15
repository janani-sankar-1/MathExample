using System;

namespace MathExample
{
    class Program
    {
        static void Main(string[] args)
        {
            double a=Math.Pow(10, 4);
            double b = Math.Min(5.234, 2.32);
            double c = Math.Max(1.141, 4.14);
            double d = Math.Floor(20.14414);
            double e = Math.Ceiling(22.414);
            double f = Math.Round(20.2398);
            double g = Math.Sign(-10);
            double h = Math.Abs(-10);
            int rem;
            double quo = Math.DivRem(10, 3, out rem);
            double k = Math.Sqrt(25);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
           Console.WriteLine(g);
            Console.WriteLine(h);
            Console.WriteLine("Quotient:" + quo + "Remainder:" + rem);
            Console.WriteLine(Math.Floor(Convert.ToDouble(10) / 3));
            Console.WriteLine(k);

            Console.ReadKey();

        }
    }
}
