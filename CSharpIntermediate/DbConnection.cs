using System;

namespace CSharpIntermediate
{
    partial class Program
    {
        public abstract class DbConnection
        {
            private readonly string _connectionString;
            private readonly TimeSpan _timeout;

            public DbConnection(string connectionString, TimeSpan timeout)
            {
                if (string.IsNullOrWhiteSpace(connectionString))
                    throw new ArgumentException("Provide a valid connection string.");
                _connectionString = connectionString;
                _timeout = timeout;
            }

            public abstract void Open();

            public abstract void Close();
        }
    }
}
