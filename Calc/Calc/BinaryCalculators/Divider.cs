namespace Calc.BinaryCalculators
{
    public class Divider : IBinaryOperation
    {
        public double Calculation(double firstArgument, double secondArgument)
        {
            double result = firstArgument / secondArgument;
            return result;
        }
    }
}
