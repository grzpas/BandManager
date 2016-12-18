using Band.Business.Songs;
using NUnit.Framework;

namespace Band.Business.Tests
{
    [TestFixture]
    public class SongTest
    {
        [Test]
        public void ReadTest()
        {
            const string sContents = "a C [x2] \n [ref:] e F";
            SongReader songReader = new SongReader(new Chord("a"));
            songReader.Read(sContents);
            var identities = songReader.SongIdentities;
            Assert.AreEqual(7, identities.Count);
            Assert.AreEqual(new SongEntity("a").ToString(), identities[0].ToString() );
            Assert.AreEqual(new SongEntity("C").ToString(), identities[1].ToString());
            Assert.AreEqual(new SongEntity("[x2]").ToString(), identities[2].ToString());
            Assert.AreEqual(new SongEntity("\n").ToString(), identities[3].ToString());
            Assert.AreEqual(new SongEntity("[ref:]").ToString(), identities[4].ToString());
            Assert.AreEqual(new SongEntity("e").ToString(), identities[5].ToString());
            Assert.AreEqual(new SongEntity("F").ToString(), identities[6].ToString());
        }

        [Test]
        public void ReadTest2()
        {
            const string sContents = "a\n C  \ne F";
            SongReader songReader = new SongReader(new Chord("a"));
            songReader.Read(sContents);
            var identities = songReader.SongIdentities;
            Assert.AreEqual(6, identities.Count);
        }
    }
}
