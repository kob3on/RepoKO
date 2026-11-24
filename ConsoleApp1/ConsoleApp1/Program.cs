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
            Console.Write("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());

            int number;

            if (a > b)
            {
                number = a;
            }
            else
            {
                number = b;
            }

            while (number % a != 0 || number % b != 0)
            {
                number++;
            }

            Console.WriteLine("НОК = " + number);
        }
    }
}