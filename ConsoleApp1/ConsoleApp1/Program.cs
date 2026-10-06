using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n < 1 || n > 999){
                Console.WriteLine("n должно быть в диапазоне от 1 до 999.");
                return;
            }
            if (n % 10 == 0){
                Console.WriteLine("количество единиц не должно быть равно нулю.");
                return;
            }
            int f = n / 100;
            int s = (n / 10) % 10;
            int t = n % 10;
            if (f == 0)
            {
                if (s == 0)
                {
                    int x1 = t;
                    Console.WriteLine($"Искомое число x = {x1}");
                    return;
                }
                int x2 = 10 * t + s;
                Console.WriteLine($"Искомое число x = {x2}");
                return;
            }
            int x = 100 * t + 10 * s + f;
            if (x < 100 || x > 999)
            {
                Console.WriteLine("x не трехзначное");
                return;
            }
            Console.WriteLine($"Искомое число x = {x}");
        }
    }
}
