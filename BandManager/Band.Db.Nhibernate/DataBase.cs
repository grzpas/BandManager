﻿using System.Reflection;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace Band.Db.Nhibernate
{
    public class DataBase
    {        
        private static DataBase _instance;
        public readonly ISessionFactory SessionFactory;
        private DataBase()
        {
            SessionFactory = CreateSessionFactory();
        }

        public static DataBase Instance => _instance ?? (_instance = new DataBase());

        private static ISessionFactory CreateSessionFactory()
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
                            c => c.Server("localhost").Database("band").Username("maestro").Password("maestro"))).
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