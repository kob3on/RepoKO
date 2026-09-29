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
            Console.WriteLine("Введите длину:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите ширину:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите высоту:");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Объём:");
            Console.WriteLine(a * b * c);
            Console.WriteLine("Площадь поверхности:");
            Console.WriteLine(2 * ((a * b) + (a * c) + (b * c)));
        }
    }
}
