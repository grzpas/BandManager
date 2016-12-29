using System.Collections.Generic;
using Band.Domain;
using System.Collections.ObjectModel;

namespace Band.ViewModels
{
    public class SongViewModel
    {
        public SongViewModel(IEnumerable<Song> songs, IList<SongType> songTypes)
        {
            Songs = new ObservableCollection<Song>(songs);
            SongTypes = new ObservableCollection<SongType>(songTypes);
        }

        public ObservableCollection<Song> Songs { get; }
        public ObservableCollection<SongType> SongTypes { get; }
    }
}