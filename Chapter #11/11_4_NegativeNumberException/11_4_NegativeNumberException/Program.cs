using System;

namespace _11_4_NegativeNumberException
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = .0;
            double result = .0;

            try
            {
                number = Convert.ToDouble(Console.ReadLine());
            } catch(FormatException)
            {
                Console.WriteLine("Invalid Number");
                return;
            }

            try
            {
                result = SquareRoot(number);
            }
            catch (NegativeNumberException)
            {
                Console.WriteLine("Invalid Number");
                return;
            }

            Console.WriteLine(result);
            Console.ReadLine();
        }

        static double SquareRoot(double operand)
        {
            if (operand < 0)
            {
                throw new NegativeNumberException("Square root of negative number not permitted");
            }
            return Math.Sqrt(operand);
        }
    }
}
