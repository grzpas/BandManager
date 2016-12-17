using Band.Model.Google;
using Band.Model.Internet;
using NUnit.Framework;

namespace ClassLibrary1
{
    [TestFixture]
    public class PBandDistanceCalculatorTest
    {
        [Test]
        public void Test1()
        {
            var pbandDistanceCalculator = new PBDistanceCalculator(new MyHttpResponse());
            pbandDistanceCalculator.AddLocation("Kraków");
            Assert.AreEqual(314, pbandDistanceCalculator.CalculateDistance());
            Assert.IsNotNull(pbandDistanceCalculator.Locations);
            Assert.AreEqual(4, pbandDistanceCalculator.Locations.Count);
            Assert.AreEqual("Rejterówka", pbandDistanceCalculator.Locations[0]);
            Assert.AreEqual("Połaniec", pbandDistanceCalculator.Locations[1]);
            Assert.AreEqual("Staszów", pbandDistanceCalculator.Locations[2]);
            Assert.AreEqual("Kraków", pbandDistanceCalculator.Locations[3]);
        }
    }
}
