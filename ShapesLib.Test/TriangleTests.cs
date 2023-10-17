using FluentAssertions;

namespace ShapesLib.Test
{
    public class TriangleTests
    {

        [Fact]


        public void Triangle_Is_Created()
        {
            // Arrange
            var triangle = new Triangle(5d, 6d, 7d);

            // Act & Assert
            triangle.SideA.Should().Be(5d);
            triangle.SideB.Should().Be(6d);
            triangle.SideC.Should().Be(7d);
        }


       [Fact]
        public void Triangle_Area_Calculated_Correctly()
        {
            // Arrange
            var triangle = new Triangle(6, 8, 10);
            var expectedArea = 24;

            // Act & Assert
            triangle.Area.Should().Be(expectedArea);
        }

       [Theory]
        [InlineData(6d, 8d, 10d)]
        [InlineData(6d, 10d, 8d)]
        [InlineData(10d, 8d, 6d)]
        public void Triangle_Is_Rectangular(double a, double b, double c)
        {
            // Arrange
            var triangle = new Triangle(a, b, c);

            // Act
            var isRectangular = triangle.IsRectangular();

            // Assert
            isRectangular.Should().BeTrue();
        }
        
       [Theory]
        [InlineData(8d, 2d, 4d)]
        [InlineData(2d, 9d, 5d)]
        [InlineData(1d, 3d, 6d)]
        [InlineData(double.MaxValue, double.MaxValue, double.MaxValue)]
        public void Triangle_With_Invalid_Sides_Throws_ArgumentException(double a, double b, double c)
        {
            // Act & Assert
            FluentActions.Invoking(() => new Triangle(a, b, c))
                .Should()
                .Throw<ArgumentException>();
        }

         [Theory]
        [InlineData(0, 3, 4)]
        [InlineData(2, 0, 3)]
        [InlineData(2, 3, 0)]
        [InlineData(-2, 3, 4)]
        [InlineData(2, -3, 4)]
        [InlineData(2, 3, -4)]
        [InlineData(double.NaN, 3, 4)]
        [InlineData(2, double.NaN, 4)]
        [InlineData(2, 3, double.NaN)]
        [InlineData(double.NegativeInfinity, 3, 4)]
        [InlineData(2, double.NegativeInfinity, 4)]
        [InlineData(2, 3, double.NegativeInfinity)]
        [InlineData(double.PositiveInfinity, 3, 4)]
        [InlineData(2, double.PositiveInfinity, 4)]
        [InlineData(2, 3, double.PositiveInfinity)]
        public void Triangle_With_Invalid_Sides_Throws_ArgumentOutOfRangeException(double a, double b, double c)
        {
            // Act & Assert
            FluentActions.Invoking(() => new Triangle(a, b, c))
                .Should()
                .Throw<ArgumentOutOfRangeException>();
        }
    }
}
