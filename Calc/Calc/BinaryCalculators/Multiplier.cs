namespace Calc.BinaryCalculators
{
    public class Multiplier : IBinaryOperation
    {
        public double Calculation(double firstArgument, double secondArgument)
        {
            double result = firstArgument * secondArgument;
            return result;
        }
    }
}
