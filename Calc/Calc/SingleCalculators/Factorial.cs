namespace Calc.SingleCalculators
{
    public class Factorial : ISingleOperation
    {
        public double Calculation(double firstArgument)
        {
            double result =1;
            for (int i = 1; i <= firstArgument; i++)
                result *= i;
            return result;
        }
    }
}
