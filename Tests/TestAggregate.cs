using DiagramAnalysisTest.OutputWriters;
using DiagramAnalysisTest.Shapes;
using System.Threading.Tasks;
using Xunit;

namespace DiagramAnalysisTest.Tests
{
    public class TestAggregate
    {
        [Fact]
        public void TestSumArea()
        {
            var writer = new Printer();
            var aggregator = new AreaAggregator(writer);

            var circle = new Circle { Radius = 3 };
            var rectangle = new Rectangle { Height = 3, Width = 7 };
            var square = new Square { Height = 3, Width = 3 };

            var expectedResult = circle.Area + rectangle.Area + square.Area;

            Assert.Equal(expectedResult, aggregator.SumArea(circle, rectangle, square, null));
        }

        [Fact]
        public async Task TestPrintAreasAsync()
        {
            var writer = new Printer();
            var aggregator = new AreaAggregator(writer);

            var circle = new Circle { Radius = 3 };
            var rectangle = new Rectangle { Height = 3, Width = 7 };
            var square = new Square { Height = 3, Width = 3 };

            var expectedResult = circle.Area + rectangle.Area + square.Area;

            var exception = await Record.ExceptionAsync(async () => await aggregator.PrintAreasAsync(circle, rectangle, square, null));

            Assert.Null(exception);
        }
    }
}