using G_NET69_EF_Assignment_2.DatabaseCalls;
using Microsoft.EntityFrameworkCore;

namespace G_NET69_EF_Assignment_2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

          using  DataBaseContext DBContext = new DataBaseContext();

            var pendingMigrations = await DBContext.Database.GetPendingMigrationsAsync();

            if (pendingMigrations.Any())
                await DBContext.Database.MigrateAsync();



        }
    }
}
