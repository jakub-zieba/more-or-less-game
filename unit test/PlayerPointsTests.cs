using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

namespace UnitTestProject
{
    [TestClass]
    public class PlayerPointsTests
    {
     

        public int PointsSum { get; private set; }

        [TestInitialize]
        public void TestInitialize()
        {

        }


        private PlayerPoints CreatePlayerPoints()
        {
            return new PlayerPoints(
               PointsSum);
        }

        [TestMethod]
        public void ModifyPointsSum_StateUnderTest_ExpectedBehavior()
        {
            
            var unitUnderTest = this.CreatePlayerPoints();
            int _Amount = PointsSum;

            
            unitUnderTest.ModifyPointsSum(
                _Amount);

            Assert.Fail();
        }
    }
}
