using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Threading;
using Band.Commands;
using BandBindingNavigator;
using Band.Domain;
using Band.ViewModels;
using Band.Db.EntityFramework;

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

            using (var dbContext = new BandDbContext())
            {
                var songRepository = new EntityFrameworkRepository<Song, int>(dbContext);
                var songs = songRepository.GetAll();
                var songTypeRepository = new EntityFrameworkRepository<SongType, int>(dbContext);
                var songTypes = songTypeRepository.GetAll();

                var songViewModel = new SongViewModel
                {
                    Songs = new ObservableCollection<Song>(songs),
                    FirstSelectedSong = songs.FirstOrDefault(),
                    SongTypes = new ObservableCollection<SongType>(songTypes),
                    AddNewSongCommand = new RelayCommand(obj => { }, obj => true),
                    DeleteSongCommand = new RelayCommand(obj => { }, obj => false),
                    SaveSongsCommand = new RelayCommand(obj => { }, obj => false)
                };
                songViewModel.MoveToSongBlocksCommand = new MoveToSongBlocksCommand(songViewModel.SelectedSongs);
                songViewModel.SaveSongsCommand = new SaveSongsCommand(songRepository);

                MainSongWindow songWindow = new MainSongWindow
                {
                    DataContext = songViewModel
                };
                songWindow.Show();
            }
        }

        private void App_OnDispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
            e.Handled = true;
        }
    }
}
