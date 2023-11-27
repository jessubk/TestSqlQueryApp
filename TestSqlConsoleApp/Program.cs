using System.Data;
using NPoco;
using NPoco.SqlServer;

Console.WriteLine("Type connection string:");
string connString = Console.ReadLine();

string sql = "EXECUTE {{stored proc name}} {{parameter list e.g. @@parameter1=@parameter1}}";

var parameters = new
{
    //{{parameter1}} = {{paramter1 value}}
};

IDatabase db = new SqlServerDatabase(connString);

var result = await db.FetchAsync<object>(sql, parameters);

Console.WriteLine("Records returned: " + result.Count);