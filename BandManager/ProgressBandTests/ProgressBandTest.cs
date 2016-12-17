using NUnit.Framework;

namespace ClassLibrary1
{
    [TestFixture]
    public class ProgressBandTest
    {
        [Test]
        public void SplitTest()
        {
            string line = "1.   \"Krakowski spleen\"                             ";
            string separators = "\"";
            char[] separatorsArray = separators.ToCharArray() ;
            string[] columns = line.Split(separatorsArray);
            string sTitle = columns[1];
            Assert.AreEqual("Krakowski spleen", sTitle);
        }
    }
}
