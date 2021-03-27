using System;

namespace Interest
{
    class Program
    {
        static void Main(string[] args)
        {
            double amount, principal = 1000.00;
            double rate = 0.06;

            Console.WriteLine("Year\tAmount on deposit");
            for(int year = 1; year <= 10; year++)
            {
                amount = principal * (double)Math.Pow(1.0 + rate, year);
                Console.WriteLine($"{year}\t{String.Format("{0:C}", amount)}");
            }

            Console.ReadLine();
        }
    }
}
