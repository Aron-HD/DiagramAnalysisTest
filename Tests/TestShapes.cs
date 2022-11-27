using DiagramAnalysisTest.Shapes;
using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xunit;

namespace DiagramAnalysisTest.Tests
{
    public class TestShapes
    {
        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(1, 0, 0)]
        [InlineData(0, 1, 0)]
        [InlineData(1, 1, 1)]
        public void TestWithRectangle(float value1, float value2, float expected)
        {
            var sut = new Rectangle
            {
                Height = value1,
                Width = value2,
            };

            Assert.Equal(expected, sut.Area);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 0)]
        public void TestWithRectangleWidth(float value1, float expected)
        {
            var sut = new Rectangle
            {
                Width = value1,
            };

            Assert.Equal(expected, sut.Area);
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(1, 0, 0)]
        [InlineData(0, 1, 1)]
        [InlineData(1, 1, 1)]
        [InlineData(2, 0, 0)]
        [InlineData(0, 2, 4)]
        public void TestWithSquare(float value1, float value2, float expected)
        {
            var sut = new Square
            {
                Height = value1,
                Width = value2
            };
            Assert.Equal(expected, sut.Area);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        public void TestWithCircle(float radius)
        {
            float expectedResult = radius * radius * (float)Math.PI;

            var sut = new Circle()
            {
                Radius = radius
            };

            Assert.Equal(expectedResult, sut.Area);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        public void TestWithCircleHeightAndWidth(float radius)
        {
            float expectedResult = radius * radius * (float)Math.PI;

            float size = radius * 2;

            var sut = new Circle()
            {
                Width = size,
                Height = size,
            };

            Assert.Equal(expectedResult, sut.Area);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        public void TestWithCircleProperties(float radius)
        {
            float size = radius * 2;

            var sut = new Circle()
            {
                Height = size,
            };

            // figured this was fine as all three properties are linked and we are testing the relationship between them
            Assert.Equal(sut.Radius, radius);
            Assert.Equal(sut.Width, sut.Height);
        }
    }
}
