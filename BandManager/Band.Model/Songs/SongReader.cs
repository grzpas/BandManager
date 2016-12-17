using System;
using System.Collections.Generic;

namespace Band.Model.Songs
{
    public class SongReader
    {
        private Chord _scale;
        private List<SongEntity> _songIdentities = new List<SongEntity>();
        
        public Chord SongChord
        {
            get { return _scale; }

        }

        public SongReader(Chord scale)
        {
            if(scale.Extension != "")
                throw new Exception("Wrong scale");
           _scale = scale;
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