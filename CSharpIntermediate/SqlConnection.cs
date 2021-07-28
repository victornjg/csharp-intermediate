using System;

namespace CSharpIntermediate
{
    partial class Program
    {
        public class SqlConnection : DbConnection
        {
            public SqlConnection(string connectionString, TimeSpan timeout) : base(connectionString, timeout) { }

            public override void Open()
            {
                Console.WriteLine("Openning connection to a SQL database...");
            }

            public override void Close()
            {
                Console.WriteLine("Closing connection to a SQL database...");
            }
        }
    }
}
