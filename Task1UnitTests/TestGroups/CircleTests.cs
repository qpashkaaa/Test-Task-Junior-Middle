using Task1;
using Task1.Shapes;

namespace Task1UnitTests.TestGroups
{
    [TestFixture]
    public class CircleTests
    {

        [Test]
        public void Square_Radius8_Return201_06()
        {
            // Arrange
            double radius = 8;
            double expected = 201.06;

            // Act
            Shape circle = new Circle(radius);
            double actual = circle.Square();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IsExists_Radius0_ReturnException()
        {
            // Arrange
            double radius = 0;

            // Assert
            Assert.That(() => new Circle(radius), Throws.Exception);
        }
    }
}