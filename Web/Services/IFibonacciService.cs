using System.Collections.Generic;

namespace Web.Services
{
    public interface IFibonacciService
    {
        IEnumerable<int> GenerateFibonacciSequence(int numbersToGenerate);
    }
}