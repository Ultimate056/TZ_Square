using TZ_Square.Interfaces;
using TZ_Square;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestTriangle()
        {
            Triangle shape = new Triangle(3, 2, 4);

            double? result = Main.GetSquare(shape);

            Assert.NotNull(result);
            Assert.True(result >= 0);

        }

        [Fact]
        public void TestCircle()
        {
            Circle shape = new Circle(2);

            double? result = Main.GetSquare(shape);

            Assert.NotNull(result);
            Assert.True(result >= 0);
        }
    }
}