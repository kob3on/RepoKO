using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static bool DecodePosition(string position, out int x, out int y)
        {
            x = 0;
            y = 0;

            if (position.Length != 2)
                return false;

            char letter = char.ToLower(position[0]);
            char number = position[1];

            if (letter < 'a' || letter > 'h' || number < '1' || number > '8')
                return false;

            x = letter - 'a' + 1;
            y = number - '0';

            return true;
        }
        static bool QueenAttacks(int x1, int y1, int x2, int y2)
        {
            return x1 == x2 ||
                   y1 == y2 ||
                   Math.Abs(x1 - x2) == Math.Abs(y1 - y2);
        }

        static bool KingAttacks(int x1, int y1, int x2, int y2)
        {
            return Math.Abs(x1 - x2) <= 1 &&
                   Math.Abs(y1 - y2) <= 1 &&
                   (x1 != x2 || y1 != y2);
        }

        static void Main()
        {
            Console.Write("Введите позицию ферзя: ");
            string queenPosition = Console.ReadLine();

            Console.Write("Введите позицию короля: ");
            string kingPosition = Console.ReadLine();

            int qx, qy, kx, ky;

            // Проверка корректности позиций
            if (!DecodePosition(queenPosition, out qx, out qy) ||
                !DecodePosition(kingPosition, out kx, out ky))
            {
                Console.WriteLine("Ошибка! Некорректная позиция.");
                return;
            }

            // Проверка, что позиции не совпадают
            if (qx == kx && qy == ky)
            {
                Console.WriteLine("Ошибка! Позиции фигур совпадают.");
                return;
            }

            bool queenHitsKing = QueenAttacks(qx, qy, kx, ky);
            bool kingHitsQueen = KingAttacks(kx, ky, qx, qy);

            if (queenHitsKing && kingHitsQueen)
            {
                Console.WriteLine("Обе фигуры находятся под боем друг друга.");
            }
            else if (queenHitsKing)
            {
                Console.WriteLine("Ферзь бьёт короля.");
            }
            else if (kingHitsQueen)
            {
                Console.WriteLine("Король бьёт ферзя.");
            }
            else
            {
                Console.WriteLine("Ни одна фигура не находится под боем другой.");
            }
        }
    }
}
    

