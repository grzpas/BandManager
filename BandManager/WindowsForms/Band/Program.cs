using System;
using System.Windows.Forms;
using Autofac;
using Band.Business;
using Band.Db.Nhibernate;
using Band.Domain;
using NHibernate;

namespace WindowsForms.Band
{
    public class WindowsFormsAppDependencies : IAppDependencies
    {
        public IRepository<Song, string> SongRepository { get; set; }
        public IRepository<Agreement, int> AgreementsRepository { get; set; }
    }


    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            var builder = new ContainerBuilder();
            builder.RegisterInstance(DataBase.CreateSessionFactory()).As<ISessionFactory>().SingleInstance();
            builder.Register(x => x.Resolve<ISessionFactory>().OpenSession()).As<ISession>().InstancePerLifetimeScope();
            builder.RegisterType<NHibernateRepository<Song, string>>()
                .As<IRepository<Song, string>>()
                .InstancePerDependency();

            builder.RegisterType<NHibernateRepository<Agreement, int>>()
               .As<IRepository<Agreement, int>>()
               .InstancePerDependency();

            builder.Register(c => new WindowsFormsAppDependencies()
            {
                SongRepository = c.Resolve<IRepository<Song, string>>(),
                AgreementsRepository = c.Resolve<IRepository<Agreement, int>>()
            }).As<IAppDependencies>();

            var container = builder.Build();
            using (var scope = container.BeginLifetimeScope())
            {
                Application.Run(new MainBandForm(scope.Resolve<IAppDependencies>()));
            }
        }
    }
}
