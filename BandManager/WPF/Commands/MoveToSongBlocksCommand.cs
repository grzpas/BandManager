using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Linq;
using System.Windows.Input;
using Band.Domain;

namespace Band.Commands
{
    public class MoveToSongBlocksCommand : ICommand
    {
        private ObservableCollection<Song> _selectedSongs;

        public MoveToSongBlocksCommand(ObservableCollection<Song> selectedSongs)
        {
            _selectedSongs = selectedSongs;
        }

        public bool CanExecute(object parameter)
        {
            /*var songs = parameter as ObservableCollection<Song>;
            if (songs != null)
            {
                return songs.Any();
            }
            return false;*/
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter != null)
            {
                MessageBox.Show(parameter.ToString());
            }
            var songs = parameter as ObservableCollection<Song>;
            if (songs != null)
            {
                var clonedList = songs.Select(objEntity => (Song)objEntity.Clone()).ToList();
                _selectedSongs = new ObservableCollection<Song>(clonedList);
            }
        }

        public event EventHandler CanExecuteChanged;
    }
}