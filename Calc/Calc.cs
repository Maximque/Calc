namespace Calc
{
    class Calc
    {
        private double result;
        public Calc()
        {
            IOHandler iohandler = new IOHandler();
            iohandler.SetOperands();
            iohandler.SetOperator();
            Engine engine = new Engine(iohandler.GetFirstOperand(), iohandler.GetSecondOperand(), iohandler.GetOperator());
            result = engine.calculate();
            iohandler.ShowResult(result);
        }
    }
}
