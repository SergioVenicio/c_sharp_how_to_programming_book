namespace _10_9_Employee.Models
{
    public abstract class Employee
    {
        public string firstName { get; private set; }
        public string lastName { get; private set; }

        public Employee(string firstNameValue, string lastNameValue)
        {
            firstName = firstNameValue;
            lastName = lastNameValue;
        }

        public override string ToString()
        {
            return $"{firstName} {lastName}";
        }

        public abstract decimal Earnings();
    }
}
