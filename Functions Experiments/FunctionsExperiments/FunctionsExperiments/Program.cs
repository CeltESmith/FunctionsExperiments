using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace FunctionsExperiments
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator absoluteSum= new Calculator();

            decimal solutionValue = absoluteSum.ArraySumOfAbsolute(new decimal[] { 3.0m, -5.0m, 6 });
            Console.WriteLine($"The array has a sum of {solutionValue}");
        }
    }
}