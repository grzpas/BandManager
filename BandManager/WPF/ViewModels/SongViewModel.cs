﻿using Band.Domain;
using System.Collections.ObjectModel;
using NHibernate.Mapping;

namespace Band.ViewModels
{
    public class SongViewModel : BindableBase
    {
        private ObservableCollection<Song> _songs;
        private ObservableCollection<SongType> _songTypes;
        private Song _selectedSong;

        public Song SelectedSong
        {
            get { return _selectedSong; }
            set
            {
                SetProperty(ref _selectedSong, value);
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
    }
}