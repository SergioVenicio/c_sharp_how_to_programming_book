using System;

namespace _17_7_BankUI
{
    [Serializable]
    public class Record
    {
        public int account { get; private set; }
        public string firstName { get; private set; }
        public string lastName { get; private set; }
        public double balance { get; private set; }

        public Record() : this(0, "", "", 0.0)
        {
        }

        public Record(int account, string firstName, string lastName, double balance)
        {
            this.account = account;
            this.firstName = firstName;
            this.lastName = lastName;
            this.balance = balance;
        }
    }
}
