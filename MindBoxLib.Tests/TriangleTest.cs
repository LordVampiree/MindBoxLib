namespace MindBoxLib.Tests
{
    [TestClass]
    public class TriangleTest : IFigureTest
    {
        [TestMethod]
        public void CalcSquare()
        {
            //arrange
            Triangle triangle = new(6d, 8d, 10d);
            double expected = 24d;

            //act
            double result = triangle.GetSquare();

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void isRight_ReturnFalse()
        {
            //arrange
            Triangle triangle = new(2d, 3d, 4d);

            //act
            bool result = triangle.IsRight();

            //assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void isRight_ReturnTrue()
        {
            //arrange
            Triangle triangle = new(3d, 4d, 5d);

            //act
            bool result = triangle.IsRight();

            //assert
            Assert.IsTrue(result);
        }
    }
}