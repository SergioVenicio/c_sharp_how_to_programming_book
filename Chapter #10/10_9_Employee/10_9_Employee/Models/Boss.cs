
using System;

namespace _10_9_Employee.Models
{
    class Boss: Employee
    {
        private decimal salary;

        public Boss(string firstName, string lastName, decimal salaryValue): base(firstName, lastName)
        {
            WeeklySalary = salaryValue;
        }

        public decimal WeeklySalary
        { 
            get
            {
                return salary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }

                salary = value;
            }
        }

        public override decimal Earnings()
        {
            return WeeklySalary;
        }

        public override string ToString()
        {
            return $"Boss: {base.ToString()}";
        }

    }
}
