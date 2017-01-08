using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using Band.Db.Nhibernate;
using Band.Domain;
using Band.ViewModels;

namespace Band
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            IList<Song> songs = new List<Song>();
            IList<SongType> songTypes = new List<SongType>();
            using (var session = DataBase.CreateSessionFactory().OpenSession())
            {
                var songRepository = new NHibernateRepository<Song, int>(session);
                songs = songRepository.GetAll();
                var songTypeRepository = new NHibernateRepository<SongType, int>(session);
                songTypes = songTypeRepository.GetAll();
            }

            var songViewModel = new SongViewModel
            {
                Songs = new ObservableCollection<Song>(songs),
                SongTypes = new ObservableCollection<SongType>(songTypes)
            };

            MainSongWindow songWindow = new MainSongWindow
            {
                DataContext = songViewModel
            };
            songWindow.Show();
        }
    }
}
