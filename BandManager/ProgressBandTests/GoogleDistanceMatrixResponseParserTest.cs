using System.Xml;
using Band.Model.Google;
using NUnit.Framework;

namespace ClassLibrary1
{
    [TestFixture]
    public class GoogleDistanceMatrixResponseParserTest
    {
        [Test]
        public void GetDistanceTest()
        {
            var document = new XmlDocument();
            document.Load("GoogleDistanceMatrixResponse.xml");
            var googleParser = new GoogleDistanceMatrixResponseParser(document);
            Assert.AreEqual(1300026, googleParser.GetDistance());
        }

        [Test]
        public void GetDistanceTest2()
        {
            var document = new XmlDocument();
            document.Load("GoogleDistanceMatrixResponse2.xml");
            var googleParser = new GoogleDistanceMatrixResponseParser(document);
            Assert.AreEqual(1712109, googleParser.GetDistance());
        }

        [Test]
        public void GetDestinationsTest()
        {
            var document = new XmlDocument();
            document.Load("GoogleDistanceMatrixResponse2.xml");
            var googleParser = new GoogleDistanceMatrixResponseParser(document);
            var result = googleParser.GetDestinations();
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count);
            Assert.AreEqual("Krakw, Poland", result[0].Key);
            Assert.AreEqual("Budapest, Hungary", result[0].Value);
            Assert.AreEqual("Budapest, Hungary", result[1].Key);
            Assert.AreEqual("Split, Croatia", result[1].Value);
            Assert.AreEqual("Split, Croatia", result[2].Key);
            Assert.AreEqual("Tirana, Albania", result[2].Value);
        }
    }
}
