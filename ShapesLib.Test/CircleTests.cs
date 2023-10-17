using FluentAssertions;

namespace ShapesLib.Test
{
    public class CircleTests
    {
        [Fact]
        public void Circle_Area_Calculated_Correctly()
        {
            // Arrange
            var circle = new Circle(5);
            var expectedArea = 78.54;

            // Act
            var actualArea = circle.Area;

            // Assert
            actualArea.Should().BeApproximately(expectedArea, 2);
        }

       [Theory]
        [InlineData(-5)]
        [InlineData(0)]
        public void Circle_With_NonPositive_Radius_Throws_ArgumentException(double radius)
        {
            string expectedMessage = "Радиус должен быть положительным конечным числом.";
       

            // Act & Assert
            FluentActions.Invoking(() => new Circle(radius))
                .Should()
                .Throw<ArgumentException>()
                .WithMessage(expectedMessage); 
        }

        [Fact]
        public void Circle_With_PositiveInfinity_Radius_Throws_ArgumentException()
        {
            string expectedMessage = "Радиус не может быть бесконечностью.";

            // Act & Assert
            FluentActions.Invoking(() => new Circle(double.PositiveInfinity))
                .Should()
                .Throw<ArgumentException>()
                .WithMessage(expectedMessage);
        }

        [Fact]
        public void Circle_With_NegativeInfinity_Radius_Throws_ArgumentException()
        {
            string expectedMessage = "Радиус не может быть бесконечностью.";

            // Act & Assert
            FluentActions.Invoking(() => new Circle(double.NegativeInfinity))
                .Should()
                .Throw<ArgumentException>()
                .WithMessage(expectedMessage);
        }
        [Fact]
        public void Circle_Inherits_IShape_Interface()
        {
            // Arrange
            var circle = new Circle(5d);

            // Act & Assert
            circle.Should().BeAssignableTo<IShape>();
        }
    }
}
