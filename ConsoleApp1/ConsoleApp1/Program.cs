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
            int h = n / 100;
            int d = (n / 10) % 10;
            int e = n % 10;
            int x = 100 * e + 10 * d + h;
            if (x < 100 || x > 999)
            {
                Console.WriteLine("x не трехзначное");
                return;
            }
            Console.WriteLine($"Искомое число x = {x}");
        }
    }
}
