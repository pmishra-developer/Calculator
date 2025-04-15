namespace CalculatorApi.Services
{
    public class CalculatorService : ICalculatorService
    {
        public int AddNumbers(params int[] numbers)
        {
            return numbers.Sum();
        }

        public int SubtractNumbers(params int[] numbers)
        {
            if (numbers.Length < 2)
                throw new ArgumentException("At least two numbers are required for subtraction.");
            return numbers[0] - numbers.Skip(1).Sum();
        }

        public int MultiplyNumbers(params int[] numbers)
        {
            return numbers.Aggregate(1, (acc, number) => acc * number);
        }

        public double DivideNumbers(params int[] numbers)
        {
            if (numbers.Length < 2)
                throw new ArgumentException("At least two numbers are required for division.");
            if (numbers.Skip(1).Any(n => n == 0))
                throw new DivideByZeroException("Cannot divide by zero");
            return numbers[0] / numbers.Skip(1).Aggregate(1.0, (acc, number) => acc * number);
        }

        public double SquareRoot(int number)
        {
            if (number < 0)
                throw new ArgumentException("Cannot calculate square root of a negative number.");
            return Math.Sqrt(number);
        }

        public double Power(int number, int power)
        {
            return Math.Pow(number, power);
        }

        public long Factorial(int number)
        {
            if (number < 0)
                throw new ArgumentException("Cannot calculate factorial of a negative number.");
            return Enumerable.Range(1, number).Aggregate(1L, (acc, x) => acc * x);
        }
        public double Percentage(int number, int total)
        {
            if (total == 0)
                throw new DivideByZeroException("Total cannot be zero for percentage calculation.");
            return (double)number / total * 100;
        }
        public double Modulus(int number, int divisor)
        {
            if (divisor == 0)
                throw new DivideByZeroException("Divisor cannot be zero for modulus calculation.");
            return number % divisor;
        }
    }
}
