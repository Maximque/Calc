using System;

namespace Calc
{
    class Program
    {
        static int count = 0;
        static void Main()
        {
            count += 1;

            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < Console.BufferWidth; i += 1)
            {
                Console.Write('-');
            }

            if (count == 1)
            {
                Console.WriteLine("Доступные операторы:\n '+' - cложение\n '-' - вычитание\n '*' - умножение\n '/' - деление");
                for (int i = 0; i < Console.BufferWidth; i += 1)
                {
                    Console.Write('-');
                }
            }
            Console.ResetColor();

            Calc calculator = new Calc();
            Main();

        }
    }
}
