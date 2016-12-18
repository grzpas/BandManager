﻿using System.Reflection;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;

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
            Assembly assembly = Assembly.GetAssembly(typeof(DataBase));
            var config =
                Fluently.Configure().Database(
                    MySQLConfiguration.Standard.ConnectionString(
                        c => c.Server("188.40.103.151").Database("pband_db").Username("pband").Password("yaya2000"))).
                    Mappings(m => m.FluentMappings.AddFromAssembly(assembly));
            return config.BuildSessionFactory();

        }
    }
}