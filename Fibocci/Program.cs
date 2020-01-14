using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Fibocci
{
    class Program
    {


        static void Main(string[] args)
        {
            #region Fibonacci class instantiation

            var fibonac = new Fibonacci(); //why not be more specific since you already know the data type (int), as opposed to var

            fibonac.FibonacEngine(5000000);

            Console.WriteLine();
            #endregion

            #region Even-valued terms in a Fibonacci

            foreach (var evenValue in fibonac.EvenSequence)
            {
                Console.WriteLine($" even-valued term: {evenValue}");

            }

            Console.WriteLine();
            Console.WriteLine($"Count of even-valued terms: {fibonac.EvenSequence.Count}");
            Console.WriteLine();
            Console.WriteLine($"Sum of even-valued terms in a Fibonacci " +
                              $"sequence\nwhere the sum of those terms" +
                              $" does not exceed 5 million is {fibonac.EvenSequence.Sum()} ");

            #endregion

            Console.WriteLine();

            #region Fibonacci Sequence numbers

            foreach (var i in fibonac.FiboSequence)
            {
               // Console.WriteLine($"  {i}");

            }

            Console.WriteLine($"Count of all fibonacci sequence" +
                              $" numbers within 5 million: {fibonac.FiboSequence.Count}");

            #endregion

            Console.ReadKey();
        }

    }
}

