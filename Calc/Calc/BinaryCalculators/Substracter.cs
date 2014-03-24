namespace Calc.BinaryCalculators
{
    public class Substracter : IBinaryOperation
    {
        public double Calculation(double firstArgument, double secondArgument)
        {
            double result = firstArgument - secondArgument;
            return result;
        }
    }
}
