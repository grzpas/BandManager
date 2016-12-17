using Band.Model.Songs;
using NUnit.Framework;

namespace ClassLibrary1
{   
    [TestFixture]
    public class ChordTransposerTest
    {
        [Test]
        public void TransposeTest()
        {
            SongReader songReader = GetSong1();
            ChordTransposer chordTransposer = new ChordTransposer(songReader);
            var songTransposed  = chordTransposer.Transpose(new Chord("d"));
            Assert.AreEqual("d F g C", songTransposed.ToString());
        }

        private SongReader GetSong1()
        {
            SongReader songReader = new SongReader(new Chord("a"));
            songReader.Read("a C d G");
            return songReader;
        }

        private SongReader GetSong2()
        {
            SongReader songReader = new SongReader(new Chord("Es"));
            songReader.Read("Es f.7 B F");
            return songReader;
        }

        

        [Test]
        public void TransposeUpTest()
        {
            SongReader songReader = GetSong1();
            ChordTransposer chordTransposer = new ChordTransposer(songReader);
            SongReader songReaderTransposed = chordTransposer.Transpose(5, true);
            Assert.AreEqual("d F g C", songReaderTransposed.ToString());
        }

        [Test]
        public void TransposeUpTest2()
        {
            SongReader songReader = GetSong1();
            ChordTransposer chordTransposer = new ChordTransposer(songReader);
            SongReader songReaderTransposed = chordTransposer.Transpose(new Chord("d"));
            Assert.AreEqual("d F g C", songReaderTransposed.ToString());
        }

        [Test]
        public void TransposeUpTest3()
        {
            SongReader songReader = GetSong2();
            ChordTransposer chordTransposer = new ChordTransposer(songReader);
            SongReader songReaderTransposed = chordTransposer.Transpose(new Chord("F"));
            Assert.AreEqual("F g.7 C G", songReaderTransposed.ToString());
        }


        [Test]
        public void MoveChordUpTest2()
        {
            var chord = new Chord("a");
            var flatChord = ChordTransposer.MoveChord(chord, chord, 1);
            Assert.AreEqual(new Chord("b").ToString(), flatChord.ToString());
        }

      
        [Test]
        public void MoveChordUpTest4()
        {
            var chord = new Chord("f.7+");
            var songChord = new Chord("c");
            var sharpChord = ChordTransposer.MoveChord(songChord, chord, 2);
            Assert.AreEqual(new Chord("g.7+").ToString(), sharpChord.ToString());
        }

        [Test]
        public void MoveChordUpTest5()
        {
            var chord = new Chord("H");
            var sharpChord = ChordTransposer.MoveChord(chord, chord, 3);
            Assert.AreEqual(new Chord("D").ToString(), sharpChord.ToString());
        }

        [Test]
        public void MoveChordDownTest()
        {
            var chord = new Chord("D");
            var sharpChord = ChordTransposer.MoveChord(chord, chord, -15);
            Assert.AreEqual(new Chord("H").ToString(), sharpChord.ToString());
        }

        [Test]
        public void MoveChordUpTest()
        {
            var songChord = new Chord("e");
            var chord = new Chord("C");
            var transposedChord = ChordTransposer.MoveChord(songChord, chord, 1);
            Assert.AreEqual("Des", transposedChord.ToString());
        }

        [Test]
        public void MoveChordUpTest6()
        {
            var songChord = new Chord("e");
            var chord = new Chord("h");
            var transposedChord = ChordTransposer.MoveChord(songChord, chord, 7);
            Assert.AreEqual("fis", transposedChord.ToString());
        }

        [Test]
        public void GetNewPositionOnKeyboardTest1()
        {
            int result = ChordTransposer.GetNewPositionOnKeyboard(1, -1);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void MoveChordUpTest7()
        {
            var songChord = new Chord("G");
            var chord = new Chord("e");
            var transposedChord = ChordTransposer.MoveChord(songChord, chord, 2);
            Assert.AreEqual("fis", transposedChord.ToString());
        }
     }
}
