using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DiagramAnalysisTest
{
    public interface IValidator
    {
        bool Validate<T>(T obj, out ICollection<ValidationResult> results);
    }

    public class ShapeValidator : IValidator
    {
        public bool Validate<T>(T obj, out ICollection<ValidationResult> results)
        {
            results = new List<ValidationResult>();

            return Validator.TryValidateObject(obj, new ValidationContext(obj), results, true);
        }
    }
}
