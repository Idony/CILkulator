namespace Calc.SingleCalculators
{
    internal class Swap : ISingleOperation
    {
        public double Calculation(double firstArgument)
        {
            double result = -1 * firstArgument;
            return result;
        }
    }
}
