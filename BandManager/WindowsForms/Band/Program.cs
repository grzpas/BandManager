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
        public WindowsFormsAppDependencies(IRepository<Song, string> songRepository)
        {
            SongRepository = songRepository;
        }

        public IRepository<Song, string> SongRepository { get; }
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
            builder.RegisterInstance(DataBase.CreateSessionFactory()).As<ISessionFactory>();
            builder.Register(x => x.Resolve<ISessionFactory>().OpenSession()).As<ISession>();
            builder.RegisterType<NHibernateRepository<Song, string>>().As<IRepository<Song, string>>();
            builder.RegisterType<WindowsFormsAppDependencies>().As<IAppDependencies>();
       
            var container = builder.Build();
            using (var scope = container.BeginLifetimeScope())
            {
                Application.Run(new MainBandForm(scope.Resolve<IAppDependencies>()));
            }
        }
    }
}
