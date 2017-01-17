using Band.Domain;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Band.ViewModels
{
    public class SongViewModel : BindableBase
    {
        private ObservableCollection<Song> _songs;
        private ObservableCollection<SongType> _songTypes;
        private ObservableCollection<Song> _selectedSongs;
        private Song _firstSelectedSong;

        public SongViewModel()
        {
            _songTypes = new ObservableCollection<SongType>();
            _songs = new ObservableCollection<Song>();
            _selectedSongs = new ObservableCollection<Song>();
        }

        public ObservableCollection<Song> SelectedSongs
        {
            get { return _selectedSongs; }
            set
            {
                SetProperty(ref _selectedSongs, value);
            }
        }

        public Song FirstSelectedSong
        {
            get { return _firstSelectedSong; }
            set
            {
                SetProperty(ref _firstSelectedSong, value);
            }
        }

        public ObservableCollection<Song> Songs
        {
            get { return _songs; }
            set { SetProperty(ref _songs, value); }
        }

        public ObservableCollection<SongType> SongTypes
        {
            get { return _songTypes; }
            set { SetProperty(ref _songTypes, value); }
        }

        public ICommand AddNewSongCommand { get; set; }
        public ICommand DeleteSongCommand { get; set; }
        public ICommand SaveSongsCommand { get; set; }
        public ICommand MoveToSongBlocksCommand { get; set; }
    }
}