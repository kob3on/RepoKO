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
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Привет, мир!");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("hi lol");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("hi lol");
            Console.ReadKey();
        }
    }
}
