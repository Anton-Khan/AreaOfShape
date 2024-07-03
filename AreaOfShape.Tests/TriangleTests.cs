namespace AreaOfShape.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public async Task Triangle_sideBelowZero_throwsArgumentOutOfRangeException()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(-1, 2, 4));
        }

        [TestMethod]
        public async Task CalculateAreaOfTriangle_345_6()
        {
            IShapeWithArea shape = new Triangle(3, 4, 5);
            double expected = 6;

            double actual = shape.CalculateArea();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public async Task IsRightAngled_345_True()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            bool expected = true;

            bool actual = triangle.IsRightAngled();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public async Task IsRightAngled_346_False()
        {
            Triangle triangle = new Triangle(3, 4, 6);
            bool expected = false;

            bool actual = triangle.IsRightAngled();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public async Task GetHalfOfPerimeter_345_6()
        {
            TrianglePerimetrTest triangle = new TrianglePerimetrTest(3, 4, 5);
            double expected = 6;

            double actual = triangle.GetHalfOfPerimeterTest();

            Assert.AreEqual(expected, actual);
        }
    }
    public class TrianglePerimetrTest : Triangle
    {
        public TrianglePerimetrTest(double a, double b , double c) : base(a, b, c){}

        public double GetHalfOfPerimeterTest()
        {
            return GetHalfOfPerimeter();
        }
    }
}
