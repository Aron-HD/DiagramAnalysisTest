using DiagramAnalysisTest.OutputWriters;
using System.Threading.Tasks;
using Xunit;

namespace DiagramAnalysisTest.Tests
{
    public class TestPrinter
    {
        [Fact]
        public async Task TestPrintAsync()
        {
            var printer = new Printer();
            await printer.PrintAsync("Test");
        }

        [Fact]
        public void TestPrint()
        {
            var printer = new Printer();
            printer.Print("Test");
        }
    }
}