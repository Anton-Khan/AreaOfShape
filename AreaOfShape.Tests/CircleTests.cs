namespace AreaOfShape.Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public async Task Circle_radiusBelowZero_throwsArgumentOutOfRangeException()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Circle(-1));
        }

        [TestMethod]
        public async Task CalculateAreaOfCircle_5_25PI()
        {
            IShapeWithArea shape = new Circle(5);
            double expected = 25 * Math.PI;

            double actual = shape.CalculateArea();

            Assert.AreEqual(expected, actual);
        }
    }
}
