using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static string ToLeet(string text)
        {
            string result = "";

            foreach (char c in text)
            {
                switch (char.ToUpper(c))
                {
                    case 'A': result += "4"; break;
                    case 'B': result += "8"; break;
                    case 'C': result += "("; break;
                    case 'D': result += "|)"; break;
                    case 'E': result += "3"; break;
                    case 'F': result += "|="; break;
                    case 'G': result += "6"; break;
                    case 'H': result += "|-|"; break;
                    case 'I': result += "!"; break;
                    case 'J': result += ")"; break;
                    case 'K': result += "|<"; break;
                    case 'L': result += "1"; break;
                    case 'M': result += "|\\/|"; break;
                    case 'N': result += "|\\|"; break;
                    case 'O': result += "0"; break;
                    case 'P': result += "|>"; break;
                    case 'Q': result += "9"; break;
                    case 'R': result += "|2"; break;
                    case 'S': result += "5"; break;
                    case 'T': result += "7"; break;
                    case 'U': result += "|_|"; break;
                    case 'V': result += "\\/"; break;
                    case 'W': result += "\\/\\/"; break;
                    case 'X': result += "><"; break;
                    case 'Y': result += "'/"; break;
                    case 'Z': result += "2"; break;

                    default:
                        result += c;
                        break;
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите текст на английском языке: ");
            string text = Console.ReadLine();

            string leetText = ToLeet(text);

            Console.WriteLine("Текст на Leet: " + leetText);
            Console.ReadKey();
        }
    }
}
    

