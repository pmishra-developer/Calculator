namespace CalculatorApi.Services
{
    public interface ICalculatorService
    {
        double AddNumbers(params double[] numbers);
        double SubtractNumbers(params double[] numbers);
        double MultiplyNumbers(params double[] numbers);
        double DivideNumbers(params double[] numbers);
        //double SquareRoot(int number);
        //double Power(int number, int power);
        //long Factorial(int number);
        //double Percentage(int number, int total);
        //double Modulus(int number, int divisor);
    }
}
