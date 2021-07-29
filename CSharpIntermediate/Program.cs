using System;

namespace CSharpIntermediate
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //var sqlConnection = new SqlConnection("mysqldb;123456", TimeSpan.FromMinutes(1));
            var oracleConnection = new OracleConnection("myoracledb;abcdef", TimeSpan.FromMinutes(2));

            var dbCommand = new DbCommand(oracleConnection, "select * from test");
            dbCommand.Execute();       
        }
    }
}
