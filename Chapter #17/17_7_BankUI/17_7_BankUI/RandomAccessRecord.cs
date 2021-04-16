namespace _17_7_BankUI
{
    public class RandomAccessRecord
    {
        private const int CHAR_ARRAY_LENGTH = 15;

        private const int SIZE_OF_CHAR = 2;
        private const int SIZE_OF_INT32 = 4;
        private const int SIZE_OF_DOUBLE = 8;

        public const int SIZE = SIZE_OF_CHAR + 2 * (SIZE_OF_CHAR * CHAR_ARRAY_LENGTH) + SIZE_OF_DOUBLE;
        private int account;
        private char[] firstName = new char[CHAR_ARRAY_LENGTH];
        private char[] lastName = new char[CHAR_ARRAY_LENGTH];
        private double balance;

        public int Account
        {
            get
            {
                return account;
            }
            set
            {
                account = value;
            }
        }

        public string FirstName
        {
            get
            {
                return new string(firstName);
            }
            set
            {
                int stringSize = value.Length;
                string stringValue = value;
                if (CHAR_ARRAY_LENGTH >= stringSize)
                {
                    stringValue = value + new string(' ', CHAR_ARRAY_LENGTH - stringSize);
                }
                else
                {
                    stringValue = value.Substring(0, CHAR_ARRAY_LENGTH);
                }

                firstName = stringValue.ToCharArray();
            }
        }

        public string LastName
        {
            get
            {
                return new string(lastName);
            }
            set
            {
                int stringSize = value.Length;
                string stringValue = value;
                if (CHAR_ARRAY_LENGTH >= stringSize)
                {
                    stringValue = value + new string(' ', CHAR_ARRAY_LENGTH - stringSize);
                }
                else
                {
                    stringValue = value.Substring(0, CHAR_ARRAY_LENGTH);
                }

                lastName = stringValue.ToCharArray();
            }
        }

        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }

        public RandomAccessRecord() : this(0, "", "", 0.0)
        {
        }

        public RandomAccessRecord(int account, string firstName, string lastName, double balance)
        {
            Account = account;
            FirstName = firstName;
            LastName = lastName;
            Balance = balance;
        }
    }
}
