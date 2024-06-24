namespace AreaOfShape.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void Triangle_sideBelowZero_throwsArgumentOutOfRangeException()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(-1, 2, 4));
        }

        [TestMethod]
        public void GetArea_345_6()
        {
            IShapeWithArea shape = new Triangle(3, 4, 5);
            double expected = 6;

            double actual = shape.CalculateArea();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsRightAngled_345_True()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            bool expected = true;

            bool actual = triangle.IsRightAngled();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsRightAngled_346_False()
        {
            Triangle triangle = new Triangle(3, 4, 6);
            bool expected = false;

            bool actual = triangle.IsRightAngled();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetHalfOfPerimeter_345_6()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            double expected = 6;

            double actual = triangle.GetHalfOfPerimeter();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsEquilateral_334_False()
        {
            Triangle triangle = new Triangle(3, 3, 4);
            bool expected = false;

            bool actual = triangle.IsEquilateral();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsEquilateral_333_True()
        {
            Triangle triangle = new Triangle(3, 3, 3);
            bool expected = true;

            bool actual = triangle.IsEquilateral();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsIsosceles_334_True()
        {
            Triangle triangle = new Triangle(3, 3, 4);
            bool expected = true;

            bool actual = triangle.IsIsosceles();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsIsosceles_333_True()
        {
            Triangle triangle = new Triangle(3, 3, 3);
            bool expected = true;

            bool actual = triangle.IsIsosceles();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsIsosceles_356_False()
        {
            Triangle triangle = new Triangle(3, 5, 6);
            bool expected = false;

            bool actual = triangle.IsIsosceles();

            Assert.AreEqual(expected, actual);
        }
    }
}
