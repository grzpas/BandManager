using Band.Model.Exceptions;

namespace Band.Model.Songs
{
    public class Chord : SongEntity
    {
        private string _basicChord;
        private string _chordExtension;
        private bool _isFlat;
        private bool _isSharp;
        public Chord(string identity)
        : base(identity)
        {
            if (!IsValid(identity, ref _basicChord, ref _chordExtension))
                throw new WrongChordFormatException(identity);
            setIndicators();
        }

        

        public Chord (string basicChord, string extension)
        : base (basicChord + (!string.IsNullOrEmpty(extension)? ("." + extension):""))
        {
            _basicChord = basicChord;
            _chordExtension = extension;
            setIndicators();
        }

        private void setIndicators()
        {
            
            _isFlat = ChordsTypes.Instance.FlatChordsArrangement.ContainsValue(_basicChord.ToUpper());
            
            //_isSharp = ChordsTypes.Instance.SharpChordsArrangement.ContainsValue(_basicChord.ToUpper());
            _isSharp = !_isFlat;
        }

        public static bool IsValid(string identity, ref string basicChord, ref string chordExtension)
        {
            char[] separator = {'.'};
            string[] parts = identity.Split(separator);

            if(parts.Length == 0 || parts.Length > 2 || string.IsNullOrEmpty(identity))
                return false;

            basicChord = parts[0];
          
            if (!ChordsTypes.Instance.AllChords.Contains(basicChord.ToUpper()))
                return false;

            chordExtension = parts.Length > 1 ? parts[1] : "";
            if (!ChordsTypes.Instance.ChordExtensions.Contains(chordExtension))
                return false;

            return true;
        }

        public int GetPositionOnKeyboard()
        {
            return ChordsTypes.Instance.AllChordsArrangement[_basicChord.ToUpper()];
        }

        public bool IsFlat()
        {
            return _isFlat;
        }

        public bool IsSharp()
        {
            return _isSharp;
        }
        /// <summary>
        /// suspended is not mayor....
        /// </summary>
        /// <returns></returns>
        public bool IsMajor()
        {
            return !IsMinor();
        }

        public bool IsMinor()
        {
            return _basicChord == _basicChord.ToLower();
        }

        public string BasicChord
        {
            get { return _basicChord; }
        }

        public string Extension
        {
            get { return _chordExtension; }
        }

        public new string ToString()
        {
            return _basicChord + (!string.IsNullOrEmpty(_chordExtension) ? ("." + _chordExtension) : "");
        }


    }
}
