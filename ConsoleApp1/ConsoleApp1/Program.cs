using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите количество чисел n: ");
            int n = int.Parse(Console.ReadLine());

            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Введите число: ");
                double a = double.Parse(Console.ReadLine());

                sum += Math.Abs(a);
            }

            Console.WriteLine("Сумма модулей = " + sum);
        }
    }
}



