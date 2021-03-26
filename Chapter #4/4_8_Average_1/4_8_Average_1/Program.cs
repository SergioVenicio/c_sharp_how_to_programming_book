using System;
using System.Collections.Generic;
using System.Linq;

namespace _4_8_Average_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = RequestStudentGrade();
            var StudentsGrade = new List<double>();

            while (grade > -1.0)
            {
                StudentsGrade.Add(grade);
                grade = RequestStudentGrade();
            }

            double Average = StudentsGrade.Sum() / StudentsGrade.Count;
            Console.WriteLine($"Average: {Average}");
            Console.ReadKey();
        }

        public static double RequestStudentGrade()
        {
            Console.Write("Student Grade: ");
            try
            {
                return Convert.ToDouble(Console.ReadLine());
            } catch(FormatException)
            {
                Console.WriteLine("Invalid Value, Try Again!");
                return RequestStudentGrade();
            }
        }
    }
}
