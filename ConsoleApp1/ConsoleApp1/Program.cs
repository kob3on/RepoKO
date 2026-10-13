using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static double CalculateTerm(double a, double b)
        {
            return Math.Sqrt((a + Math.Exp(-a)) / b);
        }

        static void Main(string[] args)
        {
            double term1 = CalculateTerm(2, 3);
            double term2 = CalculateTerm(3, 5);
            double term3 = CalculateTerm(5, 7);

            double x = term1 + term2 + term3;

            Console.WriteLine($"Результат x = {x:F3}");
        }
    }
}
