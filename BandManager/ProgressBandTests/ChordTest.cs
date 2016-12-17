using Band.Model.Exceptions;
using Band.Model.Songs;
using NUnit.Framework;

namespace ClassLibrary1
{ 
    [TestFixture]
    public class ChordTest
    {
        private Chord WrongChord(string identity)
        {
            return new Chord(identity);
        }
        [Test]
        public void ConstructorTest1()
        {
            var chord = new Chord("G");
            Assert.AreEqual("G", chord.BasicChord);
            Assert.AreEqual("", chord.Extension);
        }

        [Test]
        public void ConstructorTest2()
        {
            var chord = new Chord("Cis");
            Assert.AreEqual("Cis", chord.BasicChord);
            Assert.AreEqual("", chord.Extension);
        }

        [Test]
        public void ConstructorTest3()
        {
            var chord = new Chord("cis.7");
            Assert.AreEqual("cis", chord.BasicChord);
            Assert.AreEqual("7", chord.Extension);
        }

        [Test]
        public void ConstructorTest4()
        {
            var chord = new Chord("C.7+");
            Assert.AreEqual("C", chord.BasicChord);
            Assert.AreEqual("7+", chord.Extension);
        }

        [Test]
        public void ConstructorTest5()
        {
            var chord = new Chord("fis.5-");
            Assert.AreEqual("fis", chord.BasicChord);
            Assert.AreEqual("5-",chord.Extension);
        }

        [Test]
        public void ConstructorTest6()
        {
            TestDelegate throwingException = () => WrongChord("");
            Assert.Throws<WrongChordFormatException>(throwingException);  
        }

        [Test]
        public void IsFlatTest()
        {
            var chord = new Chord("D");
            Assert.AreEqual(false, chord.IsFlat());
        }

        [Test]
        public void IsFlatTest2()
        {
            var chord = new Chord("d");
            Assert.AreEqual(true, chord.IsFlat());
        }
        
        [Test]
        public void ConstructorTest7()
        {
            TestDelegate throwingException = () => WrongChord("h.7+1");
            Assert.Throws<WrongChordFormatException>(throwingException);
        }


    }
}
