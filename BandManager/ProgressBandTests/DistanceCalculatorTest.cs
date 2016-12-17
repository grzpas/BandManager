using Band.Model.Google;
using Band.Model.Internet;
using NUnit.Framework;

namespace ClassLibrary1
{
    [TestFixture]
    public class DistanceCalculatorTest
    {
        [Test]
        public void CalculateDistancesTest1()
        {
            var response = new MyHttpResponse();
            var transportCostCalculator = new DistanceCalculator(response);
            transportCostCalculator.AddLocation("Seattle");
            transportCostCalculator.AddLocation("San+Francisco");
            Assert.AreEqual(1300026, transportCostCalculator.CalculateDistance());
        }

        [Test]
        public void CalculateDistancesTest2()
        {
            var response = new MyHttpResponse();
            var transportCostCalculator = new DistanceCalculator(response);
            transportCostCalculator.AddLocation("Krakow");
            transportCostCalculator.AddLocation("Budapest");
            transportCostCalculator.AddLocation("Split");
            transportCostCalculator.AddLocation("Tirana");
            Assert.AreEqual(1712109, transportCostCalculator.CalculateDistance());
        }
    }
}
