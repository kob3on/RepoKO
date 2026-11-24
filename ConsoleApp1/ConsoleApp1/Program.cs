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

            for (int i = 1; i * i <= n; i++)
            {
                Console.WriteLine(i * i);
            }
        }
    }
}



