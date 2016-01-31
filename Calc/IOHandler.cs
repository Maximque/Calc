using System;

namespace Calc
{
    class IOHandler
    {
        private char operation;
        private double firstOperand, secondOperand;


        public void SetOperands()
        {
            try
            {
                Console.Write("Введите первый операнд: ");
                Console.ForegroundColor = ConsoleColor.Green;
                firstOperand = double.Parse(Console.ReadLine());
                Console.ResetColor();
                Console.Write("Введите второй операнд: ");
                Console.ForegroundColor = ConsoleColor.Green;
                secondOperand = double.Parse(Console.ReadLine());
                Console.ResetColor();
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Неправильный операнд! Попробуйте снова.");
                Console.ResetColor();
                SetOperands();
            }
        }

        public void SetOperator()
        {
            try
            {
                Console.Write("Введите оператор: ");
                Console.ForegroundColor = ConsoleColor.Green;
                operation = char.Parse(Console.ReadLine());
                Console.ResetColor();

                if (operation == '/' && secondOperand == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Нельзя делить на ноль!");
                    Console.ResetColor();
                    SetOperator();
                }

                if (!(operation == '+' || operation == '-' || operation == '*' || operation == '/'))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неправильный оператор!");
                    Console.ResetColor();
                    SetOperator();
                }
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Неправильный оператор! Попробуйте снова.");
                Console.ResetColor();
                SetOperator();
            }
        }

        public char GetOperator()
        {
            return operation;
        }

        public double GetFirstOperand()
        {
            return firstOperand;
        }

        public double GetSecondOperand()
        {
            return secondOperand;
        }

        public void ShowResult(double result)
        {
            Console.Write("Результат: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(result);
            Console.ResetColor();
        }
    }
}
