using System;
using MySqlConnector;

namespace _19_27_TableDisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            string authorsQuery = @"
                SELECT
                    authorID
                    , firstName
                    , lastName
                FROM authors
                ORDER BY authorID;
            ";
            using (var conn = GetConn())
            {
                conn.Open();

                using (var command = conn.CreateCommand())
                {
                    command.CommandText = authorsQuery;

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(new Author(reader));
                        }
                    }
                }
            }

            Console.ReadLine();
        }

        static MySqlConnection GetConn()
        {
            var builder = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                Database = "books",
                UserID = "books",
                Password = "books",
                SslMode = MySqlSslMode.Required,
            };
            return new MySqlConnection(builder.ConnectionString);
        }
    }
}
