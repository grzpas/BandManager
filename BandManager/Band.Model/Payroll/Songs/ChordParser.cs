using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgressBand
{
    public class ChordParser
    {
        private readonly List<string> _identities = new List<string>();
        public ChordParser(string textToParse)
        { 
            const string separators = " ";
            textToParse = textToParse.Trim();
            textToParse = textToParse.Replace("\n", " \n ");
            string[] items = textToParse.Split(separators.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            _identities = items.ToList();
        }

      
        public List<SongEntity> Parse()
        {
            var result = new List<SongEntity>();
            foreach(var identity in _identities)
            {
                string basicChord = null;
                string extension = null;
                SongEntity songEntity = Chord.IsValid(identity, ref basicChord, ref extension) ? new Chord(basicChord, extension):new SongEntity(identity);
                result.Add(songEntity);
            }
            return result;
        }
    }
}
