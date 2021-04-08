namespace _10_9_Employee.Models
{
    class HourlyWorker: Employee
    {
        public decimal Wage { get; private set; }
        public int HoursWorked { get; private set; }

        public HourlyWorker(string firstName, string lastName, decimal wageValue, int hoursWorked): base(firstName, lastName)
        {
            Wage = wageValue;
            HoursWorked = hoursWorked;
        }

        public override decimal Earnings()
        {
            int extra = HoursWorked - 40;
            decimal baseSalary = HoursWorked * Wage;
            return extra > 0 ? baseSalary + ((extra * Wage) * (decimal)1.5): baseSalary;
        }

        public override string ToString()
        {
            return $"HourlyWorker: {base.ToString()}";
        }
    }
}
