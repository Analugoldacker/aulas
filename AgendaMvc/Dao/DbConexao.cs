using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace AgendaMvc.Dao
{
    public class DbConexao
    {
        public static string stringConexao = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bd_agenda;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
    }
}
