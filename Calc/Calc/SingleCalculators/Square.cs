namespace Calc.SingleCalculators
{
    public class Square : ISingleOperation
    {
        public double Calculation(double firstArgument)
        {
            double result = firstArgument * firstArgument;
            return result;
        }
    }
}
