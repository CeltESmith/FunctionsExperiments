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
            Calculator firstArray = new Calculator();

            decimal mean = firstArray.CalculateMean(new decimal[] { 10.0m, 5.0m, 25.0m });

            Console.WriteLine($"The mean value of the given array is: {mean}");
        }
    }
}