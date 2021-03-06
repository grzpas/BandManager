﻿using System;
using System.Collections.Generic;

namespace Band.Business.Songs
{
    public class SongReader
    {
        private List<SongEntity> _songIdentities = new List<SongEntity>();
        
        public Chord SongChord { get; }

        public SongReader(Chord scale)
        {
            if(scale.Extension != "")
                throw new Exception("Wrong scale");
           SongChord = scale;
        }

        public void Read(string songIdentities)
        {
            ChordParser chordParser = new ChordParser(songIdentities);
            _songIdentities = chordParser.Parse();
        }

        public List<SongEntity> SongIdentities
        {
            get { return _songIdentities; }
            set { _songIdentities = value; }
        }
        
        public new string ToString()
        {
            string sResult = "";
            foreach(var songIdentity in _songIdentities)
            {
                sResult += songIdentity.ToString() + ((songIdentity.ToString() == "\n") ? "" : " "); //remove last space
            }
            return sResult.TrimEnd();
        }
    }
}