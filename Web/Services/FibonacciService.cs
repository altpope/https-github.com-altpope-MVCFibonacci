using System.Collections.Generic;

namespace Web.Services
{
    public class FibonacciService : IFibonacciService
    {
        public IEnumerable<int> GenerateFibonacciSequence(int numbersToGenerate)
        {
            // TODO: Have not done the implementation yet.

            List<int> sequence = new List<int>();

            if (numbersToGenerate < 0)
            {
                return sequence;
            }
            
            checked
            {
                int fib_a = 0;
                int fib_b = 1;
                int temp;
                sequence.Add(fib_a);

                for (int i = 0; i < numbersToGenerate; i++)
                {
                    temp = fib_a;
                    fib_a = fib_b;
                    try
                    {
                        fib_b = temp + fib_b;
                    }
                    catch (System.OverflowException)
                    {
                        sequence.Clear();                        
                        break;

                    }

                    sequence.Add(fib_a);
                }
            }

            return sequence;
        }
    }
}