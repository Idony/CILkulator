namespace Calc.SingleCalculators
{
    internal class swap : ISingleOperation
    {
        public double Calculation(double firstArgument)
        {
            double result = (firstArgument)*(-1);
            return result;
        }
    }
}
