namespace CalculatorApi.Services
{
    public interface ICalculatorService
    {
        int AddNumbers(params int[] numbers);
        int SubtractNumbers(params int[] numbers);
        int MultiplyNumbers(params int[] numbers);
        double DivideNumbers(params int[] numbers);
        double SquareRoot(int number);
        double Power(int number, int power);
        long Factorial(int number);
        double Percentage(int number, int total);
        double Modulus(int number, int divisor);
    }
}
