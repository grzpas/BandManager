using System.Reflection;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace Band.Db.Nhibernate
{
    public class DataBase
    {        
        public static ISessionFactory CreateSessionFactory()
        {
            var config = CreateFluentConfiguration();
            return config.BuildSessionFactory();
        }

        private static FluentConfiguration CreateFluentConfiguration()
        {
            Assembly assembly = Assembly.GetAssembly(typeof(DataBase));
            var config =
                Fluently.Configure().Database(
                        MySQLConfiguration.Standard.ConnectionString(
                            c => c.Server("localhost").Database("band").Username("maestro").Password("maestro")).ShowSql()).
                    Mappings(m => m.FluentMappings.AddFromAssembly(assembly));
            return config;
        }

        public static void CreateDatabase()
        {
            var config = CreateFluentConfiguration().BuildConfiguration();
            var exporter = new SchemaExport(config);
            exporter.Execute(true, true, false);
        }
    }
}