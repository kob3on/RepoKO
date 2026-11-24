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
            Console.Write("Введите количество групп n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Введите количество студентов m: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Введите количество экзаменов k: ");
            int k = int.Parse(Console.ReadLine());

            double bestAverage = -1;
            int bestGroup = 0;

            for (int i = 1; i <= n; i++)
            {
                int sum = 0;

                Console.WriteLine("Группа " + i);

                for (int j = 1; j <= m; j++)
                {
                    Console.WriteLine("Студент " + j);

                    for (int p = 1; p <= k; p++)
                    {
                        Console.Write("Введите оценку за экзамен: ");
                        int grade = int.Parse(Console.ReadLine());

                        sum += grade;
                    }
                }
                double average = (double)sum / (m * k);
                Console.WriteLine("Средний балл группы " + i + ": " + average);

                if (average > bestAverage)

                {
                    bestAverage = average;
                    bestGroup = i;
                }
            }

            Console.WriteLine("Лучшая группа: " + bestGroup);
            Console.WriteLine("Её средний балл: " + bestAverage);
        }
    }
}