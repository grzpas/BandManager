using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Band.Domain;

namespace Band.Commands
{
    public class SaveSongsCommand : ICommand
    {
        private readonly IRepository<Song, int> _songRepository;

        public SaveSongsCommand(IRepository<Song, int> songRepository)
        {
            _songRepository = songRepository;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var songs = parameter as ObservableCollection<Song>;
            if (songs != null)
            {
                foreach (var song in songs)
                {
                    var foundSong = _songRepository.Find(x => x.Title.Equals(song.Title));
                    if (foundSong != null)
                    {
                        _songRepository.Update(song);
                    }
                    else
                    {
                        _songRepository.Create(song);
                    }
                }
            }
        }

        public event EventHandler CanExecuteChanged;
    }
}