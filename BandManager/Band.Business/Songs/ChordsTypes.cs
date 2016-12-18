using System.Collections.Generic;
using System.Linq;

namespace Band.Business.Songs
{
    public class ChordsTypes
    {
        public static string C = "C";
        public static string Cis = "CIS";
        public static string Des = "DES";
        public static string D = "D";
        public static string Dis = "DIS";
        public static string Es = "ES";
        public static string E = "E";
        public static string F = "F";
        public static string Fis = "FIS";
        public static string Ges = "GES";
        public static string G = "G";
        public static string Gis = "GIS";
        public static string As = "AS";
        public static string A = "A";
        public static string Ais = "AIS";
        public static string B = "B";
        public static string H = "H";
        public static string Ces = "CES";

        public static string With7S =  "7";
        public static string With7B =  "7+";
        public static string Reduced = "5-"; //zmniejszony
        public static string Suspended = "4";
        public static string With5 = "5";
        public static string Clean = "";
        private readonly Dictionary<string, int> _sharpChords = new Dictionary<string, int>();
        private readonly Dictionary<string, int> _flatChords = new Dictionary<string, int>();
        private readonly Dictionary<string, int> _allChordsArrangement = new Dictionary<string, int>();
        private readonly Dictionary<int, string> _sharpChordsArrangement = new Dictionary<int, string>();
        private readonly Dictionary<int, string> _flatChordsArrangement = new Dictionary<int, string>();
        private readonly Dictionary<int, string> _preferredMajorChordsArrangement = new Dictionary<int, string>();
        private readonly Dictionary<int, string> _preferredMinorChordsArrangement = new Dictionary<int, string>();
        private readonly List<string> _chordExtensions = new List<string>();
        
        private static ChordsTypes _instance;

        public static ChordsTypes Instance
        {
            get { return _instance ?? (_instance = new ChordsTypes()); }
        }



        private  ChordsTypes()
        {
            _allChordsArrangement.Add(C, 0);
            _allChordsArrangement.Add(Cis, 1);
            _allChordsArrangement.Add(Des, 1);
            _allChordsArrangement.Add(D, 2);
            _allChordsArrangement.Add(Dis, 3);
            _allChordsArrangement.Add(Es, 3);
            _allChordsArrangement.Add(E, 4);
            _allChordsArrangement.Add(F, 5);
            _allChordsArrangement.Add(Fis, 6);
            _allChordsArrangement.Add(Ges, 6);
            _allChordsArrangement.Add(G, 7);
            _allChordsArrangement.Add(Gis, 8);
            _allChordsArrangement.Add(As, 8);
            _allChordsArrangement.Add(A, 9);
            _allChordsArrangement.Add(Ais, 10);
            _allChordsArrangement.Add(B, 10);
            _allChordsArrangement.Add(H, 11);
            _allChordsArrangement.Add(Ces, 11);

            _sharpChordsArrangement.Add(0, C);
            _sharpChordsArrangement.Add(1, Cis);
            _sharpChordsArrangement.Add(2, D);
            _sharpChordsArrangement.Add(3, Dis);
            _sharpChordsArrangement.Add(4, E);
            _sharpChordsArrangement.Add(5, F);
            _sharpChordsArrangement.Add(6, Fis);
            _sharpChordsArrangement.Add(7, G);
            _sharpChordsArrangement.Add(8, Gis);
            _sharpChordsArrangement.Add(9, A);
            _sharpChordsArrangement.Add(10, Ais);
            _sharpChordsArrangement.Add(11, H);

            _flatChordsArrangement.Add(0, C);
            _flatChordsArrangement.Add(1, Des);
            _flatChordsArrangement.Add(2, D);
            _flatChordsArrangement.Add(3, Es);
            _flatChordsArrangement.Add(4, E);
            _flatChordsArrangement.Add(5, F);
            _flatChordsArrangement.Add(6, Ges);
            _flatChordsArrangement.Add(7, G);
            _flatChordsArrangement.Add(8, As);
            _flatChordsArrangement.Add(9, A);
            _flatChordsArrangement.Add(10, B);
            _flatChordsArrangement.Add(11, Ces);

            //C Des D Es E F Fis G As A B H C 

            _preferredMajorChordsArrangement.Add(0, C);
            _preferredMajorChordsArrangement.Add(1, Des);
            _preferredMajorChordsArrangement.Add(2, D);
            _preferredMajorChordsArrangement.Add(3, Es);
            _preferredMajorChordsArrangement.Add(4, E);
            _preferredMajorChordsArrangement.Add(5, F);
            _preferredMajorChordsArrangement.Add(6, Fis);
            _preferredMajorChordsArrangement.Add(7, G);
            _preferredMajorChordsArrangement.Add(8, As);
            _preferredMajorChordsArrangement.Add(9, A);
            _preferredMajorChordsArrangement.Add(10, B);
            _preferredMajorChordsArrangement.Add(11, H);

            //a b h c cis d es e f fis g

            _preferredMinorChordsArrangement.Add(0, C.ToLower());
            _preferredMinorChordsArrangement.Add(1, Cis.ToLower());
            _preferredMinorChordsArrangement.Add(2, D.ToLower());
            _preferredMinorChordsArrangement.Add(3, Dis.ToLower());
            _preferredMinorChordsArrangement.Add(4, E.ToLower());
            _preferredMinorChordsArrangement.Add(5, F.ToLower());
            _preferredMinorChordsArrangement.Add(6, Fis.ToLower());
            _preferredMinorChordsArrangement.Add(7, G.ToLower());
            _preferredMinorChordsArrangement.Add(8, Gis.ToLower());
            _preferredMinorChordsArrangement.Add(9, A.ToLower());
            _preferredMinorChordsArrangement.Add(10,B.ToLower());
            _preferredMinorChordsArrangement.Add(11,H.ToLower());

            _chordExtensions.Add(With7S);
            _chordExtensions.Add(With7B);
            _chordExtensions.Add(Reduced);
            _chordExtensions.Add(Suspended);
            _chordExtensions.Add(With5);
            _chordExtensions.Add(Clean);
        }

        public List<string> AllChords
        {
            get { return _allChordsArrangement.Keys.ToList(); }
        }

        public  List<string> ChordExtensions
        {
            get { return _chordExtensions; }
        }

        public Dictionary<string, int> AllChordsArrangement
        {
            get { return _allChordsArrangement; }
        }

        public Dictionary<int, string> SharpChordsArrangement
        {
            get { return _sharpChordsArrangement; }
        }

        public Dictionary<int, string> FlatChordsArrangement
        {
            get { return _flatChordsArrangement; }
        }

        public Dictionary<int, string> PreferredMajorChordsArrangement
        {
            get { return _preferredMajorChordsArrangement; }
        }

        public Dictionary<int, string> PreferredMinorChordsArrangement
        {
            get { return _preferredMinorChordsArrangement; }
        }

        public  int? GetPosition(string chord)
        {
            if (_allChordsArrangement.ContainsKey(chord))
                return _allChordsArrangement[chord];
            return null;
        }


    }
}
