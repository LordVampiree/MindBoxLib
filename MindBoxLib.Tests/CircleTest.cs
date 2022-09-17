using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MindBoxLib.Tests
{
    [TestClass]
    public class CircleTest : IFigureTest
    {
        [TestMethod]
        public void CalcSquare()
        {
            //arrange
            Circle circle = new(3d);
            double expected = 28.27d;

            //act
            double result = circle.GetSquare();

            //assert
            Assert.AreEqual(expected, result);
        }
    }
}