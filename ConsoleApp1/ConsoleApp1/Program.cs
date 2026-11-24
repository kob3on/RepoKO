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
            Console.Write("Введите a: ");
            int a = int.Parse(Console.ReadLine());

            long sum = 0;

            for (int i = a; i <= 500; i++)
            {
                sum += (long)i * i * i;
            }

            Console.WriteLine("Сумма кубов = " + sum);
        }
    }
}
    

