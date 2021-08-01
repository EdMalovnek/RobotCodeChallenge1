using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace RobotCodeChallenge.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestRegexPatternRight()
        {
            Regex pattern = new Regex(@"\b(\w*PLACE\w*)\b\s\d,\d,\b(?:NORTH|SOUTH|EAST|WEST)\b");

            string sample = "PLACE 0,0,NORTH";

            bool matched = pattern.IsMatch(sample);

            Assert.IsTrue(matched);
        }

        [TestMethod]
        public void TestRegexPatternWrong()
        {
            Regex pattern = new Regex(@"\b(\w*PLACE\w*)\b\s\d,\d,\b(?:NORTH|SOUTH|EAST|WEST)\b");

            string sample = "PLCE 0,0,WES";

            bool matched = pattern.IsMatch(sample);

            Assert.IsFalse(matched);
        }

        [TestMethod]
        public void FallOffTableRestrictionX()
        {
            int posX = 5;

            posX++;

            if (posX > 5)
            {
                posX = 5;
            }

            Assert.AreEqual(posX, 5);
        }

        [TestMethod]
        public void FallOffTableRestrictionY()
        {
            int posY = 0;

            posY--;

            if (posY < 0)
            {
                posY = 0;
            }

            Assert.AreEqual(posY, 0);
        }
    }
}
