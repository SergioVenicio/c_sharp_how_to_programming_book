using System;

namespace _10_15_IAge.Models
{
    public class Person: IAge
    {
        private string firstName;
        private string lastName;
        private int yearBorn;

        public Person(string firstName, string lastName, int yearBorn)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.yearBorn = yearBorn;
        }

        public int Age
        {
            get
            {
                return DateTime.Now.Year - yearBorn;
            }
        }

        public string Name
        {
            get {
                return $"{firstName} {lastName}";
            }
        }

    }
}
