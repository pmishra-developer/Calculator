using System.Reflection.Metadata.Ecma335;

namespace CalculatorApi.Services
{
    public class CalculatorService : ICalculatorService
    {
        
        public double AddNumbers(params double[] numbers)
        {
            double sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        public double SubtractNumbers(params double[] numbers)
        {
            double result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                result -= numbers[i];
            }
            return result;
        }

        public double MultiplyNumbers(params double[] numbers)
        {
            double result = 1;
            foreach (var number in numbers)
            {
                result *= number;
            }
            return result;
        }

        public double DivideNumbers(params double[] numbers)
        {
            double result = numbers[0];
            for (int i = 1;i < numbers.Length;i++)
            {
                if (numbers[i] == 0)
                {
                    throw new DivideByZeroException("Divisor cannot be zero for Division calculation.");
                }
                result /= numbers[i];
            }
            return result;
        }

        //public double SquareRoot(int number)
        //{
        //    if (number < 0)
        //        throw new ArgumentException("Cannot calculate square root of a negative number.");
        //    return Math.Sqrt(number);
        //}

        //public double Power(int number, int power)
        //{
        //    return Math.Pow(number, power);
        //}

        //public long Factorial(int number)
        //{
        //    if (number < 0)
        //        throw new ArgumentException("Cannot calculate factorial of a negative number.");
        //    return Enumerable.Range(1, number).Aggregate(1L, (acc, x) => acc * x);
        //}
        //public double Percentage(int number, int total)
        //{
        //    if (total == 0)
        //        throw new DivideByZeroException("Total cannot be zero for percentage calculation.");
        //    return (double)number / total * 100;
        //}
        //public double Modulus(int number, int divisor)
        //{
        //    if (divisor == 0)
        //        throw new DivideByZeroException("Divisor cannot be zero for modulus calculation.");
        //    return number % divisor;
        //}
    }
}
