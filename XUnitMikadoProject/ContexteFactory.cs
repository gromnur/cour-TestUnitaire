using Microsoft.EntityFrameworkCore;
using MikadoProject.Models;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Text;

namespace XUnitMikadoProject
{
    public static class ContextFactory
    {
        public static MySqlConnection CreateDbFactory()
        {
            return new MySqlConnection("Server=127.0.0.1;Port=3306;Database=mikado;Uid=root;Pwd=root;");
        }

        public static MikadoContexte CreateContext(this MySqlConnection connection)
        {
            connection.Open();

            DbContextOptionsBuilder<MikadoContexte> dbOptionBuilder = new DbContextOptionsBuilder<MikadoContexte>();

            var methodInfos = new StackTrace().GetFrame(1).GetMethod();
            var className = methodInfos.ReflectedType.ReflectedType != null ? methodInfos.ReflectedType.ReflectedType.Name : methodInfos.ReflectedType.Name;

            dbOptionBuilder.UseMySql(connection);
            
            var context = new MikadoContexte(dbOptionBuilder.Options);

            context.Database.EnsureCreated();

            return context;
        }

        public static void InitialSeed(this MikadoContexte context)
        {

        }
    }
}
