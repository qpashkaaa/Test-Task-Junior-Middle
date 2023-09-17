using Task1;
using Task1.Shapes;

namespace Task1UnitTests.TestGroups
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void Square_ab15_bc21_ac14_Return104_88()
        {
            // Arrange
            double ab = 15;
            double bc = 21;
            double ac = 14;
            double expected = 104.88;

            // Act
            Shape triangle = new Triangle(ab, bc, ac);
            double actual = triangle.Square();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IsExists_abMinus1_bc3_ac5_ReturnException()
        {
            // Arrange
            double ab = -1;
            double bc = 3;
            double ac = 5;

            // Assert
            Assert.That(() => new Triangle(ab,bc,ac), Throws.Exception);
        }

        [Test]
        public void IsExists_ab2_bc35_ac4_ReturnException()
        {
            // Arrange
            double ab = 2;
            double bc = 35;
            double ac = 4;

            // Assert
            Assert.That(() => new Triangle(ab, bc, ac), Throws.Exception);
        }

        [Test]
        public void TriangleIsRectangular_ab5_bc4_ac3_ReturnTrue()
        {
            // Arrange
            double ab = 5;
            double bc = 4;
            double ac = 3;

            // Act
            Triangle triangle = new Triangle(ab,bc,ac);
            bool actual = triangle.TriangleIsRectangular();

            // Assert
            Assert.IsTrue(actual);
        }

        [Test]
        public void TriangleIsRectangular_ab15_b15_ac15_ReturnFalse()
        {
            // Arrange
            double ab = 15;
            double bc = 15;
            double ac = 15;

            // Act
            Triangle triangle = new Triangle(ab, bc, ac);
            bool actual = triangle.TriangleIsRectangular();

            // Assert
            Assert.IsFalse(actual);
        }
    }
}
