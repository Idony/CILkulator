namespace Calc.BinaryCalculators
{
    public class Srhombus: IBinaryOperation
    {
        public double Calculation(double firstArgument, double secondArgument)
        {
            double result = 0.5*(firstArgument*secondArgument);
            return  result;
        }
    }
}
