using System;


namespace _10_9_Employee.Models
{
    class CommisionWorker : Employee
    {
        private decimal salary;
        private decimal commision;
        private int quantity;

        public CommisionWorker(
            string firstName, string lastName,
            decimal salaryValue, decimal commisionValue, int quantityValue
        ) : base(firstName, lastName)
        {
            WeeklySalary = salaryValue;
            Commision = commisionValue;
            quantity = quantityValue;
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

        public decimal Commision
        {
            get
            {
                return commision;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }

                commision = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }

                quantity = value;
            }
        }

        public override decimal Earnings()
        {
            return WeeklySalary + Commision * Quantity;
        }

        public override string ToString()
        {
            return $"CommisionWorker: {base.ToString()}";
        }

    }
}
