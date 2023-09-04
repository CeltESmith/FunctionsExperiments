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
            IterationCalculator sentence1 = new IterationCalculator();

            int apperanceOfA = sentence1.NumberOfOccurances("A new day and watery day.", 'a');
            Console.WriteLine($"There are a total of {apperanceOfA} a's");
        }
    }
}