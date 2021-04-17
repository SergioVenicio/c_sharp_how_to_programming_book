using System;
using MySqlConnector;

namespace _19_27_TableDisplay
{
    [Serializable]
    class Author
    {
        public int authorId { get; private set; }
        public string firstName { get; private set; }
        public string lastName { get; private set; }

        public Author(int id, string name, string lName)
        {
            authorId = id;
            firstName = name;
            lastName = lName;
        }

        public Author(MySqlDataReader reader)
        {
            authorId = reader.GetInt32(0);
            firstName = reader.GetString(1);
            lastName = reader.GetString(2);
        }

        public override string ToString()
        {
            return $"Author Id: {authorId}\nFirst Name: {firstName}\nLast Name: {lastName}";
        }
    }
}
