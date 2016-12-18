using System;
using System.Collections.Generic;
using Band.Business.Exceptions;

namespace Band.Business.Songs
{
    public class ChordTransposer
    {
        private SongReader _songReader;
        public ChordTransposer(SongReader songReader)
        {
            _songReader = songReader;
        }

        public SongReader Transpose(Chord songChord)
        {
            if (_songReader.SongChord.IsMajor() != songChord.IsMajor())
                throw new WrongScaleConversionException(songChord.ToString(), _songReader.SongChord.ToString());
  
            var result = new SongReader(songChord);
            int difference = (12 - (_songReader.SongChord.GetPositionOnKeyboard() - songChord.GetPositionOnKeyboard()));

            var newSongIdentities = new List<SongEntity>();
            foreach(var identity in _songReader.SongIdentities)
            {
                if(identity is Chord)
                {
                   Chord oldChord = identity as Chord;
                   Chord newChord = MoveChord(_songReader.SongChord,oldChord, difference);
                   newSongIdentities.Add(newChord); 
                }
                else
                {
                   newSongIdentities.Add(identity);
                }
                
            }
            result.SongIdentities = newSongIdentities;
            return result;
        }

        public SongReader Transpose(int semiTones, bool bSharp)
        {
            Chord newSongChord = MoveChord(_songReader.SongChord, _songReader.SongChord, semiTones);
            
            var newSongIdentities = new List<SongEntity>();
            foreach (var identity in _songReader.SongIdentities)
            {
                if (identity is Chord)
                {
                    Chord oldChord = identity as Chord;
                    Chord newChord = MoveChord(_songReader.SongChord, oldChord, semiTones);
                    newSongIdentities.Add(newChord);
                }
                else
                {
                    newSongIdentities.Add(identity);
                }

            }
            var result = new SongReader(newSongChord);
            result.SongIdentities = newSongIdentities;
            return result;
        }

        public static Chord MoveChord(Chord oldSongChord, Chord oldChord, int semiTones)
        {
            int oldSongChordPositionOnKeyboard = oldSongChord.GetPositionOnKeyboard();
            int oldChordPositionOnKeyboard = oldChord.GetPositionOnKeyboard();
            int newChordPositionOnKeyboard = GetNewPositionOnKeyboard(oldChordPositionOnKeyboard, semiTones);
            int newSongChordPositionOnKeyboard = GetNewPositionOnKeyboard(oldSongChordPositionOnKeyboard, semiTones);

            //Fix the new scale...

            Chord newSongChord = oldSongChord.IsMajor() ? 
                           new Chord(ChordsTypes.Instance.PreferredMajorChordsArrangement[newSongChordPositionOnKeyboard]) :                          
                           new Chord(ChordsTypes.Instance.PreferredMinorChordsArrangement[newSongChordPositionOnKeyboard]);
            string sNewChord = null;
            if (newSongChord.IsFlat())
            {
                sNewChord = ChordsTypes.Instance.FlatChordsArrangement[newChordPositionOnKeyboard];
            }
            else if(newSongChord.IsSharp())
            {
                sNewChord = ChordsTypes.Instance.SharpChordsArrangement[newChordPositionOnKeyboard];    
            }
            else
            {
                throw new NotImplementedException();
            }
            

            if (oldChord.BasicChord.ToLower() == oldChord.BasicChord) //if old chord was moll 
                return new Chord(sNewChord.ToLower(), oldChord.Extension);

            return new Chord(sNewChord[0] + (sNewChord.Substring(1).ToLower()), oldChord.Extension);
        }

       

        public static int GetNewPositionOnKeyboard(int positionOnKeyboard, int semiTones)
        {
            int sum = positionOnKeyboard + semiTones;
            if (sum >= 0 && sum < 12)
            {
                return sum;
            }
            
            if (sum >= 12)
            {
                return sum % 12;
            }
            
            if (sum < 0)
            {
                return 12 - (Math.Abs(sum) % 12);    
            }

            throw new NotImplementedException();

        }
    }
}