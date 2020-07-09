using System.Linq;
using IntersectingTimePairs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntersectingPairs.Tests
{
    [TestClass]
    public class IntersectingTimePairTests
    {

        [TestMethod]
        public void FunctionExecutesGracefullyWithZeroAsCount()
        {
            var timeFrames = from timeFrame in TimeFrameGenerator.Generate(0)
                             select timeFrame;

            Assert.AreEqual(timeFrames.Count(), 0);
        }

        [TestMethod]
        public void EndDateIsGreaterThanStartDateForGeneratedValues()
        {
            var timeFrames = from timeFrame in TimeFrameGenerator.Generate(10000)
                             where timeFrame.Start > timeFrame.End
                             select timeFrame;

            Assert.AreEqual(timeFrames.Count(),0);
        }
    }
}
