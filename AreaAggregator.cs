using DiagramAnalysisTest.OutputWriters;
using DiagramAnalysisTest.Shapes;
using System.Diagnostics;
using System.Threading.Tasks;

namespace DiagramAnalysisTest
{
    public class AreaAggregator
    {
        readonly IOutputWriter _writer;

        public AreaAggregator(IOutputWriter writer)
        {
            _writer = writer;
        }

        public float SumArea(params object[] shapes)
        {
            float retVal = 0;

            foreach (var shape in shapes)
            {

                //if (shape is Shape shape1 && _validator.Validate(shape1, out ICollection<ValidationResult> results))
                //    retVal += shape1.Area;
                //else
                //    Debug.WriteLine($"Shape valid: \n{shape}\n"); // + string.Join("\n", results.Select(o => o.ErrorMessage))) ;

                // doesn't feel robust, I would opt for proper validation of some kind. 
                if (shape is Shape shape1)
                    retVal += shape1.Area;
                else
                    Debug.WriteLine($"Shape was invalid. {shape}");
            }

            return retVal;
        }

        // Should this be part of the responsibility of the aggregator or the output writer?
        public async Task PrintAreasAsync(params object[] shapes)
        {
            foreach (var shape in shapes)
            {
                if (shape is Shape shape1)
                    await _writer.PrintAsync(shape1.Area.ToString());
                else
                    Debug.WriteLine($"Shape was invalid. {shape}");
            }
        }

    }
}
