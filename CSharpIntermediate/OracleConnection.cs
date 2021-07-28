using System;

namespace CSharpIntermediate
{
    partial class Program
    {
        public class OracleConnection : DbConnection
        {
            public OracleConnection(string connectionString, TimeSpan timeout) : base(connectionString, timeout) { }

            public override void Open()
            {
                Console.WriteLine("Openning connection to a Oracle database...");
            }

            public override void Close()
            {
                Console.WriteLine("Closing connection to a Oracle database...");
            }
        }
    }
}
