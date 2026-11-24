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
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Введите k: ");
            int k = int.Parse(Console.ReadLine());

            int sum = 0;

            while (n > 0)
            {
                int digit = n % 10;

                if (digit > k)
                {
                    sum += digit;
                }

                n = n / 10;
            }

            Console.WriteLine("Сумма цифр = " + sum);
        }
    } 

}

