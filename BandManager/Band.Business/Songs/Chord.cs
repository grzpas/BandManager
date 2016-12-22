using Band.Business.Exceptions;

namespace Band.Business.Songs
{
    public class Chord : SongEntity
    {
        private readonly string _basicChord;
        private readonly string _chordExtension;
        private bool _isFlat;
        private bool _isSharp;
        public Chord(string identity)
        : base(identity)
        {
            if (!IsValid(identity, ref _basicChord, ref _chordExtension))
                throw new WrongChordFormatException(identity);
            SetIndicators();
        }

        

        public Chord (string basicChord, string extension)
        : base (basicChord + (!string.IsNullOrEmpty(extension)? ("." + extension): string.Empty))
        {
            _basicChord = basicChord;
            _chordExtension = extension;
            SetIndicators();
        }

        private void SetIndicators()
        {
            _isFlat = ChordsTypes.Instance.FlatChordsArrangement.ContainsValue(_basicChord.ToUpper());
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

        public string BasicChord => _basicChord;

        public string Extension => _chordExtension;

        public new string ToString()
        {
            return _basicChord + (!string.IsNullOrEmpty(_chordExtension) ? ("." + _chordExtension) : "");
        }


    }
}
