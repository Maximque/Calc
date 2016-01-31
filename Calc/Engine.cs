namespace Calc
{
    class Engine
    {
        private char operation;
        private double firstOperand, secondOperand, result;

        public Engine(double firstOperand, double secondOperand, char operation)
        {
            this.firstOperand = firstOperand;
            this.secondOperand = secondOperand;
            this.operation = operation;
        }

        private double Add(double a, double b)
        {
            return a + b;
        }

        private double Subtract(double a, double b)
        {
            return a - b;
        }

        private double Divide(double a, double b)
        {
            if (b == 0)
            {
                return 0;
            }
            return a / b;
        }

        private double Multiply(double a, double b)
        {
            return a * b;
        }

        public double calculate()
        {
            switch (operation)
            {
                case '+':
                    result = Add(firstOperand, secondOperand);
                    break;

                case '-':
                    result = Subtract(firstOperand, secondOperand);
                    break;

                case '*':
                    result = Multiply(firstOperand, secondOperand);
                    break;

                case '/':
                    result = Divide(firstOperand, secondOperand);
                    break;
            }
            return result;
        }
    }
}
