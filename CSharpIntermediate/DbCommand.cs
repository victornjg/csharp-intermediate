using System;

namespace CSharpIntermediate
{
    partial class Program
    {
        public class DbCommand
        {
            private readonly DbConnection _dbConnection;
            private readonly string _instruction;

            public DbCommand(DbConnection dbConnection, string instruction)
            {
                if (dbConnection == null)
                    throw new ArgumentNullException("Provide a valid instance of DbConnection.");
                if (string.IsNullOrWhiteSpace(instruction))
                    throw new ArgumentException("Provide a valid instruction.");
                this._dbConnection = dbConnection;
                this._instruction = instruction;
            }

            public void Execute()
            {
                this._dbConnection.Open();
                Console.WriteLine(_instruction);
                Console.WriteLine("Running instruction...");
                this._dbConnection.Close();
            }
        }
    }
}
