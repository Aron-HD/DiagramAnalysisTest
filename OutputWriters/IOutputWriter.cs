using System.Threading.Tasks;

namespace DiagramAnalysisTest.OutputWriters
{
    public interface IOutputWriter

    {
        void Print(string message);
        Task PrintAsync(string message);
    }
}
