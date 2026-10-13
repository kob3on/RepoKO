using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static double CalculateFunction(double x)
        {
            double result = Math.Sqrt(x + 1);

            result = Math.Abs(x + result);
            result = Math.Abs(x + result);
            result = Math.Abs(x + result);

            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите значение x (x >= -1): ");

            if (double.TryParse(Console.ReadLine(), out double x))
            {
                if (x < -1)
                {
                    Console.WriteLine("Ошибка: подкоренное выражение не может быть отрицательным. x должен быть >= -1.");
                }
                else
                {
                    double y = CalculateFunction(x);

                    Console.WriteLine($"Значение функции f({x}) = {y:F3}");
                }
            }
            else
            {
                Console.WriteLine("Ошибка: введено некорректное число.");
            }
        }
    }
}