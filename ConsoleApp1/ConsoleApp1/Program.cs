using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static bool IsMultipleOfThree(int k, int m, int n)
        {
            return k % 3 == 0 && m % 3 == 0 && n % 3 == 0;
        }

        static void Main()
        {
            Console.Write("Введите k: ");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите m: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            bool result = IsMultipleOfThree(k, m, n);

            Console.WriteLine(result);
        }
    }
}
    

